using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Ipedf.Web.Control;
using Ipedf.Core;
using Ipedf.Hrp.Hem.Sap.BizLogic;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Common;
using System.IO;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class STAFF_REAL_LIST : Manage_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                try
                {
                    DdlBindData();
                    BindData();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1014";
            ddlInputPageSize.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPageSize.DataTextField = "NAME";
            ddlInputPageSize.DataValueField = "CODE";
            ddlInputPageSize.DataBind();
        }

        protected void BindData()
        {
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        public CauseObject_HEM_B_STAFF_REAL CauseObject_Where()
        {
            CauseObject_HEM_B_STAFF_REAL cause = new CauseObject_HEM_B_STAFF_REAL();
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
            cause.STATUS = 0;
            cause.USER_ID = UserInfo.USER_ID;
            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_HEM_B_STAFF_REAL parameter)
        {
            CauseObject_HEM_B_STAFF_REAL cause = parameter;
            try
            {
                int[] arrPage = (int[])ViewState["pageNum"];
                int npage = GetPageIndex(page, arrPage, txt_PageNo);
                int PageSize = 10;
                if (ddlInputPageSize.Items.Count != 0)
                {
                    PageSize = int.Parse(ddlInputPageSize.SelectedValue);
                }

                PagingParamter paging = new PagingParamter() { PageIndex = npage, PageSize = PageSize };
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "NUM" };
                DisplayObject_HEM_B_STAFF_REAL[] disQuery = BizLogicObject_HEM_B_STAFF_REAL.Proxy.Query(cause, paging, orderBy);
                arrPage[0] = paging.PageIndex;
                arrPage[1] = paging.TotalRecords;
                arrPage[2] = paging.PageCount;
                ViewState["pageNum"] = arrPage;
                rpt_List.DataSource = disQuery;
                rpt_List.DataBind();
                PageText(paging, lbt_back, lbt_next, lbl_PageNo, txt_PageNo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btn_query_Click(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        public bool KeyNotNull(string id)
        {
            if (!string.IsNullOrEmpty(id) && id != "00000000-0000-0000-0000-000000000000")
            {
                return true;
            }
            return false;
        }

        protected void ThisPage()
        {
            //Response.Redirect(HttpContext.Current.Request.Url.PathAndQuery);
            if (!string.IsNullOrEmpty(this.txt_PageNo.Text))
            {
                ShowQueryResult(this.txt_PageNo.Text, CauseObject_Where());
            }
            else
            {
                ShowQueryResult("1", CauseObject_Where());
            }
        }

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void lbt_home_Click(object sender, EventArgs e)
        {
            ShowQueryResult("home", CauseObject_Where());
        }
        protected void lbt_back_Click(object sender, EventArgs e)
        {
            ShowQueryResult("back", CauseObject_Where());
        }
        protected void lbt_next_Click(object sender, EventArgs e)
        {
            ShowQueryResult("next", CauseObject_Where());
        }
        protected void lbt_last_Click(object sender, EventArgs e)
        {
            ShowQueryResult("last", CauseObject_Where());
        }
        protected void btn_GoPage_Click(object sender, EventArgs e)
        {
            ShowQueryResult("custom", CauseObject_Where());
        }

        protected void btn_download_Click(object sender, EventArgs e)
        {
            string fileName = "导入模板.xls";//客户端保存的文件名
            string filePath = Server.MapPath("~/excel/dowmload/导入模板.xls");//路径
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);
            if (fileInfo.Exists == true)
            {
                const long ChunkSize = 102400;//100K 每次读取文件，只读取100Ｋ，这样可以缓解服务器的压力
                byte[] buffer = new byte[ChunkSize];
                Response.Clear();
                System.IO.FileStream iStream = System.IO.File.OpenRead(filePath);
                long dataLengthToRead = iStream.Length;//获取下载的文件总大小
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName));
                while (dataLengthToRead > 0 && Response.IsClientConnected)
                {
                    int lengthRead = iStream.Read(buffer, 0, Convert.ToInt32(ChunkSize));//读取的大小
                    Response.OutputStream.Write(buffer, 0, lengthRead);
                    Response.Flush();
                    dataLengthToRead = dataLengthToRead - lengthRead;
                }
                Response.Close();
            }
        }
        protected void btn_update_Click(object sender, EventArgs e)
        {
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
            BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_REAL.Proxy.Update(UserInfo.USER_ID);
            if (msg.Succeed)
            {
                BindData();
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = msg.Message;
            }
        }

        protected void btnup_Click(object sender, EventArgs e)
        {
            string extension = "";
            string saveAsFileName = "";
            FileStream fs = null;
            string sfile = "*.XLS||*.XLSX";

            if (upfile.HasFile)
            {
                string filelastname = upfile.FileName.Substring(upfile.FileName.LastIndexOf("."));
                extension = System.IO.Path.GetExtension(upfile.FileName).ToLower();
                if (!sfile.Contains(filelastname.ToUpper()))
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('请上传Excel文件！');</script>");
                }
                else
                {
                    if (upfile.PostedFile.ContentLength > 1024000)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('文件仅限1M以下！');</script>");
                    }
                    else
                    {
                        //上传文件到本地服务器
                        string fileUrl = "excel/attached";
                        try
                        {
                            if (Directory.Exists(Server.MapPath("~/" + fileUrl)) == false)//如果不存在就创建文件夹
                            {
                                Directory.CreateDirectory(Server.MapPath("~/" + fileUrl));
                            }
                            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;

                            string strFileName = this.upfile.FileName.Substring(0, (upfile.FileName.Length - extension.Length));
                            //string strDate = DateTime.Now.ToString("yyMMddHHmmss");
                            ////string strDate = "";

                            //saveAsFileName = strFileName.Trim() + strDate + extension;
                            saveAsFileName = strFileName.Trim() + UserInfo.ACCOUNT + extension;

                            if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                            {
                                File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                //Msg("文件名重复，请修改后再上传！");
                                //return ;
                            }

                            string excelServerURL = MapPath("~/" + fileUrl + "/") + saveAsFileName;
                            upfile.SaveAs(excelServerURL);

                            fs = new FileStream(excelServerURL, FileMode.Open, FileAccess.Read);
                            string retMessage = "";

                            EntityObject_HEM_B_STAFF_REAL[] itemEntity = NPOIHelper.GetImportExcelData(fs, extension, UserInfo.USER_ID, "Sheet1", ref retMessage);
                            BizLogicMsg msg = new BizLogicMsg();
                            if (itemEntity.Length > 0 && string.IsNullOrEmpty(retMessage))
                            {
                                msg = BizLogicObject_HEM_B_STAFF_REAL.Proxy.Save(itemEntity);
                                if (msg.Succeed)
                                {
                                    BindData();
                                }
                                else
                                {
                                    lbl_Error.Visible = true;
                                    lbl_Error.Text = msg.Message;
                                }
                            }
                            else
                            {
                                lbl_Error.Visible = true;
                                lbl_Error.Text = retMessage;
                            }

                        }
                        catch (Exception)
                        {
                            if (fs != null)
                            {
                                fs.Dispose();
                                fs.Close();
                            }
                            if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                            {
                                File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                            }

                        }

                    }
                }
            }
            else
            {

            }
        }
    }
}
