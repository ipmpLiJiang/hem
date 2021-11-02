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
using System.IO;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class STAFF_FILEUPLOAD : User_Page
    {
        private const decimal cIS_NURSE = 2;
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                if (ViewState["CUR_STAFF"] == null)
                {
                    try
                    {
                        EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                        CauseObject_HEM_B_STAFF_TYPE cause = new CauseObject_HEM_B_STAFF_TYPE();
                        cause.USER_ID = UserInfo.USER_ID;
                        cause.IS_NURSE = cIS_NURSE;
                        DisplayObject_HEM_B_STAFF_TYPE[] displayNurse = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Query(cause);
                        if (displayNurse.Length > 0)
                        {
                            string staffID = displayNurse[0].STAFF_ID;
                            string ID = displayNurse[0].ID;
                            string FILE_PATH = displayNurse[0].FILE_PATH;
                            EntityObject_HEM_B_STAFF sfEntity = new EntityObject_HEM_B_STAFF();
                            sfEntity.ID = staffID;
                            sfEntity = BizLogicObject_HEM_B_STAFF.Proxy.Get(sfEntity);
                            if (sfEntity != null)
                            {
                                EntityObject_HEM_B_STAFF_TYPE entityStaffType = new EntityObject_HEM_B_STAFF_TYPE();
                                entityStaffType.ID = ID;
                                entityStaffType.FILE_PATH = FILE_PATH;
                                if (!string.IsNullOrEmpty(FILE_PATH))
                                {
                                    lbl_ulmsg.Text = "Word简历已上传";
                                    fu_load.Visible = false;
                                    btn_upload.Visible = false;
                                    btn_delete.Visible = true;

                                    lbl_FILE_PATH.Text = "<a href='../" + FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
                                }
                                ViewState["CUR_OBJ"] = entityStaffType;
                            }
                            else
                            {
                                skipAspx();
                            }
                        }
                        else
                        {
                            skipAspx();
                            //Response.Redirect("STAFF_BASIC.aspx");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

        }

        public void skipAspx()
        {
            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_BASIC.aspx';</script>");
        }

        protected void btn_SubmitCheck_Click(object sender, EventArgs e)
        {
            if (Session["UserLogin"] != null)
            {
                EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF.Proxy.StaffSubmitOrCheck(UserInfo.USER_ID, cIS_NURSE);
                if (!string.IsNullOrEmpty(msg.Message))
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + msg.Message + "');</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('简历,提交成功!');</script>");
                }
            }
        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {
            if (ViewState["CUR_OBJ"] != null)
            {
                string sfile = "*.DOC||*.DOCX";
                string extension = "";
                string saveAsFileName = "";
                //System.IO.FileInfo finfo = new FileInfo(fu_load.PostedFile.FileName);
                if (!string.IsNullOrEmpty(fu_load.PostedFile.FileName))
                {
                    string filelastname = fu_load.FileName.Substring(fu_load.FileName.LastIndexOf("."));
                    extension = System.IO.Path.GetExtension(fu_load.FileName).ToLower();
                    if (!sfile.Contains(filelastname.ToUpper()))
                    {
                        ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('请上传Word文件!');</script>");
                    }
                    else
                    {
                        if (fu_load.PostedFile.ContentLength > 5120000)
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('文件仅限5M以下');</script>");
                            //WebControlHelper.ShowAlert(this, "文件仅限5M以下！");
                        }
                        else
                        {
                            //上传文件到本地服务器
                            string fileUrl = "doc/attached";
                            string strDate = DateTime.Now.ToString("yyMMddHHmmss");
                            string strFileName = this.fu_load.FileName.Substring(0, (fu_load.FileName.Length - extension.Length));

                            saveAsFileName = strFileName.Trim() + strDate + extension;
                            try
                            {
                                if (Directory.Exists(Server.MapPath("~/" + fileUrl)) == false)//如果不存在就创建文件夹
                                {
                                    Directory.CreateDirectory(Server.MapPath("~/" + fileUrl));
                                }

                                if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                {
                                    File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                    //Msg("文件名重复，请修改后再上传！");
                                    //return ;
                                }

                                string excelServerURL = MapPath("~/" + fileUrl + "/") + saveAsFileName;
                                fu_load.SaveAs(excelServerURL);

                                EntityObject_HEM_B_STAFF_TYPE curObj = ViewState["CUR_OBJ"] as EntityObject_HEM_B_STAFF_TYPE;
                                curObj = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Get(curObj);
                                if (File.Exists(Server.MapPath("~/" + curObj.FILE_PATH)))
                                {
                                    File.Delete(Server.MapPath("~/" + curObj.FILE_PATH));
                                }
                                curObj.FILE_PATH = fileUrl + "/" + saveAsFileName;
                                curObj.SetUpdate("FILE_PATH");
                                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(curObj);
                                if (!msg.Succeed)
                                {
                                    lbl_Error.Visible = true;
                                    lbl_Error.Text = msg.Message;
                                }
                                else
                                {
                                    btn_upload.Visible = false;
                                    fu_load.Visible = false;
                                    btn_delete.Visible = true;
                                    lbl_ulmsg.Text = "上传成功！";
                                    lbl_FILE_PATH.Text = "<a href='../" + curObj.FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
                                    ViewState["CUR_OBJ"] = curObj;
                                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('上传成功,完善/修改简历后请提交简历!');</script>");
                                }
                            }
                            catch (Exception)
                            {
                                if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                {
                                    File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                }
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('上传的Word文件异常错误,请联系管理员！');</script>");
                                //WebControlHelper.ShowAlert(this, "上传的Word文件异常错误,请联系管理员！");
                            }

                        }
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('未选择文件！');</script>");
                    //WebControlHelper.ShowAlert(this, "未选择Word文件！");
                }
            }
            else
            {
                lbl_ulmsg.Text = "请先保存简历信息！";
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            if (ViewState["CUR_OBJ"] != null)
            {
                try
                {
                    EntityObject_HEM_B_STAFF_TYPE curObj = ViewState["CUR_OBJ"] as EntityObject_HEM_B_STAFF_TYPE;
                    if (File.Exists(Server.MapPath("~/" + curObj.FILE_PATH)))
                    {
                        File.Delete(Server.MapPath("~/" + curObj.FILE_PATH));
                    }
                    curObj.FILE_PATH = "";
                    curObj.SetUpdate("FILE_PATH");
                    BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(curObj);
                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        btn_upload.Visible = true;
                        fu_load.Visible = true;
                        btn_delete.Visible = false;
                        lbl_ulmsg.Text = "删除成功！";
                        lbl_FILE_PATH.Text = "";
                        ViewState["CUR_OBJ"] = curObj;
                    }
                }
                catch
                {
                    lbl_ulmsg.Text = "删除时发生错误！";
                }
            }
        }
    }
}
