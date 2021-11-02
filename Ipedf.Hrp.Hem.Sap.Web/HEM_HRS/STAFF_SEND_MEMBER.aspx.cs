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
    public partial class STAFF_SEND_MEMBER : User_Page
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
            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_SEND_BASIC.aspx';</script>");
        }

        protected void btn_SaveNext_Click(object sender, EventArgs e)
        {
            if (ViewState["OBJ_ID"] != null)
            {
                bool bl = SaveMethod();
                if (bl)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_SEND_REWARD.aspx';</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_SEND_REWARD.aspx';</script>");
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
            EntityObject_HEM_B_STAFF_MEMBER entity = new EntityObject_HEM_B_STAFF_MEMBER();
            SetEditEntity(entity);
            //称谓名称
            if (string.IsNullOrEmpty(entity.WEIC))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "称谓名称不能为空！";
                //WebControlHelper.ShowAlert(null, "称谓名称不能为空！");
                return false;
            }

            //姓名
            if (string.IsNullOrEmpty(entity.MINGC.ToString()))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "姓名刊物不能为空！";
                //WebControlHelper.ShowAlert(null, "姓名不能为空！");
                return false;
            }

            //出生年月
            /*if (string.IsNullOrEmpty(entity.MGBDAT.ToString()))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "出生年月不能为空！";
                //WebControlHelper.ShowAlert(null, "出生年月不能为空！");
                return false;
            }*/

            //政治面貌
            if (string.IsNullOrEmpty(entity.MPCODE))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "请选择政治面貌！";
                //WebControlHelper.ShowAlert(null, "请选择政治面貌！");
                return false;
            }

            //工作单位及职务
            if (string.IsNullOrEmpty(entity.GZDWJZW))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "工作单位及职务不能为空！";
                //WebControlHelper.ShowAlert(null, "工作单位及职务不能为空！");
                return false;
            }

            EntityObject_HEM_B_STAFF staffEntity = ViewState["CUR_STAFF"] as EntityObject_HEM_B_STAFF;
            if (ViewState["OBJ_ID"] == null)
            {
                entity.STAFF_ID = staffEntity.ID;
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_MEMBER.Proxy.Save(entity);
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
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_MEMBER.Proxy.Update(entity);
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

                DisplayObject_HEM_B_STAFF_MEMBER display = (DisplayObject_HEM_B_STAFF_MEMBER)e.Item.DataItem;

                ((Label)e.Item.FindControl("lbl_WEIC")).Text = StrCutOut(display.WEIC, 5);

                ((Label)e.Item.FindControl("lbl_MINGC")).Text = StrCutOut(display.MINGC, 5);

                if (!string.IsNullOrEmpty(display.MPCODE))
                {
                    display.MPCODE = ddlInputMPCODE.Items.FindByValue(display.MPCODE).Text;
                    ((Label)e.Item.FindControl("lbl_MPCODE")).Text = display.MPCODE;
                }

                ((Label)e.Item.FindControl("lab_GZDWJZW")).Text = StrCutOut(display.GZDWJZW, 10);


                if (display.MGBDAT == Ipedf.Common.Template.UndefineDatetime)
                {
                    ((Label)e.Item.FindControl("lbl_MGBDAT")).Text = string.Empty;
                }
                else {
                    ((Label)e.Item.FindControl("lbl_MGBDAT")).Text = display.MGBDAT.ToString("yyyy-MM-dd");
                }
            }
        }

        protected void rpt_List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ID = e.CommandArgument.ToString();
            EntityObject_HEM_B_STAFF_MEMBER entity = new EntityObject_HEM_B_STAFF_MEMBER();
            entity.ID = ID;
            if (e.CommandName == "Edit")
            {
                SetEditClear();
                try
                {
                    entity = BizLogicObject_HEM_B_STAFF_MEMBER.Proxy.Get(entity);
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

                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_MEMBER.Proxy.Delete(entity);
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
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('删除成功,完善/修改简历后请提交简历!');location.href='STAFF_MEMBER.aspx';</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!');location.href='STAFF_MEMBER.aspx';</script>");
            }
            //Response.Redirect(HttpContext.Current.Request.Url.PathAndQuery);
        }

        public void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();

            cause.PARENT_ID = "HEM_1002";
            ddlInputMPCODE.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputMPCODE.DataTextField = "NAME";
            ddlInputMPCODE.DataValueField = "CODE";
            ddlInputMPCODE.DataBind();

            //if (display_MPCODE.Length > 0) {
            //    int count = display_MPCODE.Where(p => p.NAME.Equals("群众")).Count();
            //    if (count > 0) { 
            //        this.ddlInputMPCODE.Items.FindByText("群众").Selected = true;
            //    }
            //}

        }

        protected void BindData()
        {
            DdlBindData();
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void ShowQueryResult(string page, CauseObject_HEM_B_STAFF_MEMBER parameter)
        {
            ViewState["OBJ_ID"] = null;
            SetEditClear();
            CauseObject_HEM_B_STAFF_MEMBER cause = parameter;
            try
            {
                int[] arrPage = (int[])ViewState["pageNum"];
                int npage = GetPageIndex(page, arrPage, txt_PageNo);
                PagingParamter paging = new PagingParamter() { PageIndex = npage, PageSize = 4 };
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "WEIC" };
                DisplayObject_HEM_B_STAFF_MEMBER[] disSE = BizLogicObject_HEM_B_STAFF_MEMBER.Proxy.Query(cause, paging, orderBy);
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

        public CauseObject_HEM_B_STAFF_MEMBER CauseObject_Where()
        {
            CauseObject_HEM_B_STAFF_MEMBER cause = new CauseObject_HEM_B_STAFF_MEMBER();
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

        protected EntityObject_HEM_B_STAFF_MEMBER SetEditEntity(EntityObject_HEM_B_STAFF_MEMBER entity)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            //称谓
            if (!string.IsNullOrEmpty(this.txtInputWEIC.Text))
            {
                entity.WEIC = this.txtInputWEIC.Text;
            }
            else
            {
                entity.WEIC = "";
            }

            //姓名
            if (!string.IsNullOrEmpty(this.txtInputMINGC.Text))
            {
                entity.MINGC = this.txtInputMINGC.Text;
            }
            else
            {
                entity.MINGC = "";
            }

            //出生年月
            if (!string.IsNullOrEmpty(this.txtInputMGBDAT.Text))
            {
                entity.MGBDAT = DateTime.Parse(this.txtInputMGBDAT.Text);
            }
            else
            {
                entity.MGBDAT = Ipedf.Common.Template.UndefineDatetime;
            }

            //政治面貌
            if (!string.IsNullOrEmpty(this.ddlInputMPCODE.SelectedValue))
            {
                entity.MPCODE = this.ddlInputMPCODE.SelectedValue;
            }
            else
            {
                entity.MPCODE = "";
            }

            //工作单位及职务
            if (!string.IsNullOrEmpty(this.txtInputGZDWJZW.Text))
            {
                entity.GZDWJZW = this.txtInputGZDWJZW.Text;
            }
            else
            {
                entity.GZDWJZW = "";
            }
            return entity;
        }

        protected void GetEditEntity(EntityObject_HEM_B_STAFF_MEMBER entity)
        {
            //称谓
            if (entity.WEIC != null)
            {
                this.txtInputWEIC.Text = entity.WEIC.Trim();
            }

            //姓名
            if (entity.MINGC != null)
            {
                this.txtInputMINGC.Text = entity.MINGC.Trim();
            }
            //出生年月
            if (entity.MGBDAT == Ipedf.Common.Template.UndefineDatetime)
            {
                this.txtInputMGBDAT.Text = string.Empty;

            } else {
                this.txtInputMGBDAT.Text = entity.MGBDAT.ToString("yyyy-MM-dd");
            }
        

            //政治面貌
            if (entity.MPCODE != null)
            {
                foreach (ListItem it in this.ddlInputMPCODE.Items)
                {
                    if (it.Value == entity.MPCODE.Trim())
                    {
                        this.ddlInputMPCODE.Items.FindByValue(entity.MPCODE.Trim()).Selected = true;
                        break;
                    }
                }
            }
            //工作单位及职务
            if (entity.GZDWJZW != null)
            {
                this.txtInputGZDWJZW.Text = entity.GZDWJZW.Trim();
            }
        }

        protected void SetEditClear()
        {
            //称谓
            this.txtInputWEIC.Text = "";
            //姓名
            this.txtInputMINGC.Text = "";
            //出生年月
            this.txtInputMGBDAT.Text = "";
            //政治面貌
            this.ddlInputMPCODE.ClearSelection();
            //工作单位及职务
            this.txtInputGZDWJZW.Text = "";

        }
    }
}
