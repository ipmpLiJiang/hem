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

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class STAFF_NURSE_REWARD : User_Page
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
                        DisplayObject_HEM_B_STAFF_TYPE[] displayNurse = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Query(new CauseObject_HEM_B_STAFF_TYPE() { USER_ID = UserInfo.USER_ID });
                        if (displayNurse.Length > 0)
                        {
                            EntityObject_HEM_B_STAFF sfEntity = new EntityObject_HEM_B_STAFF();
                            sfEntity.ID = displayNurse[0].STAFF_ID;
                            sfEntity = BizLogicObject_HEM_B_STAFF.Proxy.Get(sfEntity);

                            if (sfEntity != null)
                            {
                                ViewState["CUR_STAFF"] = sfEntity;
                                BindData();
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
                else
                {
                    BindData();
                }
            }

        }

        public void skipAspx()
        {
            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_NURSE_BASIC.aspx';</script>");
        }

        protected void btn_SaveNext_Click(object sender, EventArgs e)
        {
            if (ViewState["OBJ_ID"] != null)
            {
                bool bl = SaveMethod();
                if (bl)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_FILEUPLOAD.aspx';</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_FILEUPLOAD.aspx';</script>");
            }
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

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            bool bl = SaveMethod();
            if (bl)
            {
                ThisPage("S");
                EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                BizLogicMsg msg1 = BizLogicObject_HEM_B_STAFF.Proxy.StaffSubmitOrCheckNoMessage(UserInfo.USER_ID, cIS_NURSE);
            }
        }

        private bool SaveMethod()
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            bool IsTrturn = false;
            EntityObject_HEM_B_STAFF_REWARD entity = new EntityObject_HEM_B_STAFF_REWARD();
            SetEditEntity(entity);

            //奖项名次
            if (string.IsNullOrEmpty(entity.JXNAME))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "奖项名次不能为空！";
                //WebControlHelper.ShowAlert(null, "奖项名次不能为空！");
                return false;
            }
            //名次
            if (string.IsNullOrEmpty(entity.MINGCI))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "名次不能为空！";
                //WebControlHelper.ShowAlert(null, "名次不能为空！");
                return false;
            }

            //备注
            if (string.IsNullOrEmpty(entity.COMMENTS))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "备注不能为空！";
                //WebControlHelper.ShowAlert(null, "备注不能为空！");
                return false;
            }

            EntityObject_HEM_B_STAFF staffEntity = ViewState["CUR_STAFF"] as EntityObject_HEM_B_STAFF;
            if (ViewState["OBJ_ID"] == null)
            {
                entity.STAFF_ID = staffEntity.ID;
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_REWARD.Proxy.Save(entity);
                IsTrturn = msg.Succeed;
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
            }
            else
            {
                string ID = ViewState["OBJ_ID"].ToString();
                entity.ID = ID;
                //entity.STAFF_ID = staffEntity.ID;
                entity.SetNotUpdate("STAFF_ID");
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_REWARD.Proxy.Update(entity);
                IsTrturn = msg.Succeed;
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }

            }

            return IsTrturn;
        }

        public string StrCutOut(string str, int len)
        {
            if (str != null)
            {
                if (str.Length > len)
                {
                    return str.Substring(0, len) + "..";
                }
                else
                {
                    return str;
                }
            }
            return "";
        }

        protected void rpt_List_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DisplayObject_HEM_B_STAFF_REWARD display = (DisplayObject_HEM_B_STAFF_REWARD)e.Item.DataItem;

                ((Label)e.Item.FindControl("lbl_JXNAME")).Text = StrCutOut(display.JXNAME, 10);

                ((Label)e.Item.FindControl("lbl_MINGCI")).Text = StrCutOut(display.MINGCI, 10);

                ((Label)e.Item.FindControl("lab_COMMENTS")).Text = StrCutOut(display.COMMENTS, 10);
            }
        }

        protected void rpt_List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ID = e.CommandArgument.ToString();
            EntityObject_HEM_B_STAFF_REWARD entity = new EntityObject_HEM_B_STAFF_REWARD();
            entity.ID = ID;
            if (e.CommandName == "Edit")
            {
                SetEditClear();
                try
                {
                    entity = BizLogicObject_HEM_B_STAFF_REWARD.Proxy.Get(entity);
                    GetEditEntity(entity);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                ViewState["OBJ_ID"] = ID;
                this.btn_SaveNext.CausesValidation = true;
            }
            if (e.CommandName == "Delete")
            {

                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_REWARD.Proxy.Delete(entity);
                if (msg.Succeed)
                {
                    ThisPage("D");
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
            }
        }

        protected void ThisPage(string operate)
        {
            ViewState["OBJ_ID"] = null;
            SetEditClear();
            if (operate == "D")
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('删除成功,完善/修改简历后请提交简历!');location.href='STAFF_REWARD.aspx';</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!');location.href='STAFF_REWARD.aspx';</script>");
            }
            //Response.Redirect(HttpContext.Current.Request.Url.PathAndQuery);
        }

        public void DdlBindData()
        {

        }

        protected void BindData()
        {
            DdlBindData();
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void ShowQueryResult(string page, CauseObject_HEM_B_STAFF_REWARD parameter)
        {
            ViewState["OBJ_ID"] = null;
            SetEditClear();
            CauseObject_HEM_B_STAFF_REWARD cause = parameter;
            try
            {
                int[] arrPage = (int[])ViewState["pageNum"];
                int npage = GetPageIndex(page, arrPage, txt_PageNo);
                PagingParamter paging = new PagingParamter() { PageIndex = npage, PageSize = 4 };
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "MINGCI" };
                DisplayObject_HEM_B_STAFF_REWARD[] disSE = BizLogicObject_HEM_B_STAFF_REWARD.Proxy.Query(cause, paging, orderBy);
                arrPage[0] = paging.PageIndex;
                arrPage[1] = paging.TotalRecords;
                arrPage[2] = paging.PageCount;
                ViewState["pageNum"] = arrPage;
                rpt_List.DataSource = disSE;
                rpt_List.DataBind();
                PageText(paging, lbt_back, lbt_next, lbl_PageNo, txt_PageNo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CauseObject_HEM_B_STAFF_REWARD CauseObject_Where()
        {
            CauseObject_HEM_B_STAFF_REWARD cause = new CauseObject_HEM_B_STAFF_REWARD();
            if (ViewState["CUR_STAFF"] != null)
            {
                EntityObject_HEM_B_STAFF staffEntity = ViewState["CUR_STAFF"] as EntityObject_HEM_B_STAFF;
                cause.STAFF_ID = staffEntity.ID;
            }
            return cause;
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

        public bool KeyNotNull(string id)
        {
            if (id != null && id != "00000000-0000-0000-0000-000000000000")
            {
                return true;
            }
            return false;
        }

        protected EntityObject_HEM_B_STAFF_REWARD SetEditEntity(EntityObject_HEM_B_STAFF_REWARD entity)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            //奖项名称
            if (!string.IsNullOrEmpty(this.txtInputJXNAME.Text))
            {
                entity.JXNAME = this.txtInputJXNAME.Text;
            }
            else
            {
                entity.JXNAME = "";
            }

            //名次
            if (!string.IsNullOrEmpty(this.txtInputMINGCI.Text))
            {
                entity.MINGCI = this.txtInputMINGCI.Text;
            }
            else
            {
                entity.MINGCI = "";
            }

            //获奖时间
            if (!string.IsNullOrEmpty(this.txtInputHJSJ.Text))
            {
                entity.HJSJ = DateTime.Parse(this.txtInputHJSJ.Text);
            }
            else
            {
                entity.HJSJ = Ipedf.Common.Template.UndefineDatetime;
            }

            //备注
            if (!string.IsNullOrEmpty(this.txtInputCOMMENTS.Text))
            {
                entity.COMMENTS = this.txtInputCOMMENTS.Text;
            }
            else
            {
                entity.COMMENTS = "";
            }
            return entity;
        }

        protected void GetEditEntity(EntityObject_HEM_B_STAFF_REWARD entity)
        {
            //奖项名称
            if (entity.JXNAME != null)
            {
                this.txtInputJXNAME.Text = entity.JXNAME.Trim();
            }

            //名次
            if (entity.MINGCI != null)
            {
                this.txtInputMINGCI.Text = entity.MINGCI.Trim();
            }
            //获奖时间
            this.txtInputHJSJ.Text = entity.HJSJ.ToString("yyyy-MM-dd");

            //备注
            if (entity.COMMENTS != null)
            {
                this.txtInputCOMMENTS.Text = entity.COMMENTS.Trim();
            }
        }

        protected void SetEditClear()
        {
            //奖项名称
            this.txtInputJXNAME.Text = "";

            //名次
            this.txtInputMINGCI.Text = "";
            //获奖时间
            this.txtInputHJSJ.Text = "";

            //备注
            this.txtInputCOMMENTS.Text = "";

        }
    }
}
