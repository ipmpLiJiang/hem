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
    public partial class STAFF_EDUCATION : User_Page
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

        protected void btn_SaveNext_Click(object sender, EventArgs e)
        {
            if (ViewState["OBJ_ID"] != null)
            {
                bool bl = SaveMethod();
                if (bl)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_WORK.aspx';</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_WORK.aspx';</script>");
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            bool bl = SaveMethod();
            if (bl)
            {
                this.btn_SaveNext.CausesValidation = false;
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
            EntityObject_HEM_B_STAFF_EDUCATION entity = new EntityObject_HEM_B_STAFF_EDUCATION();
            SetEditEntity(entity);
            //学校名称
            if (string.IsNullOrEmpty(entity.INSTI))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "学校名称不能为空！";
                //WebControlHelper.ShowAlert(null, "学校名称不能为空！");
                return false;
            }

            //开始日期
            if (string.IsNullOrEmpty(entity.BEGDA.ToString()))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "开始日期不能为空！";
                //WebControlHelper.ShowAlert(null, "开始日期不能为空！");
                return false;
            }

            //结束日期
            if (string.IsNullOrEmpty(entity.ENDDA.ToString()))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "结束日期不能为空！";
                //WebControlHelper.ShowAlert(null, "结束日期不能为空！");
                return false;
            }


            //学历
            if (string.IsNullOrEmpty(entity.SLART))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "请选择学历！";
                //WebControlHelper.ShowAlert(null, "请选择学历！");
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtInputZHRDSXM.Text) && (entity.SLART == "10" || entity.SLART == "11"))
                {
                    ddlInputTYPE_ID.Enabled = true;
                    lbl_ZHRDSXM.Visible = true;
                    return false;
                }

                if (entity.SLART != "10" && entity.SLART != "11")
                {
                    entity.ZHRDSXM = "";
                }
            }

            //学科专业1
            if (string.IsNullOrEmpty(entity.ZHRXKZY1))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "学科专业1不能为空！";
                //WebControlHelper.ShowAlert(null, "学科专业1不能为空！");
                return false;
            }

            //学科类型
            if (entity.SLART == "10" || entity.SLART == "11")
            {
                if (string.IsNullOrEmpty(entity.TYPE_ID))
                {
                    ddlInputTYPE_ID.Enabled = true;
                    lbl_TYPE_ID.Visible = true;
                    return false;
                }
            }

            EntityObject_HEM_B_STAFF staffEntity = ViewState["CUR_STAFF"] as EntityObject_HEM_B_STAFF;
            if (ViewState["OBJ_ID"] == null)
            {
                entity.STAFF_ID = staffEntity.ID;
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Save(entity, staffEntity, 2);
                IsTrturn = msg.Succeed;
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + msg.Message + "');</script>");
                }
            }
            else
            {
                string ID = ViewState["OBJ_ID"].ToString();
                entity.ID = ID;
                entity.STAFF_ID = staffEntity.ID;
                entity.SetNotUpdate("STAFF_ID");
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Update(entity);
                IsTrturn = msg.Succeed;
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('"+msg.Message+"');</script>");
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

        protected void ThisPage(string operate)
        {
            ViewState["OBJ_ID"] = null;
            SetEditClear();
            if (operate == "D")
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('删除成功,完善/修改简历后请提交简历!');location.href='STAFF_EDUCATION.aspx';</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!');location.href='STAFF_EDUCATION.aspx';</script>");
            }

            //Response.Redirect(HttpContext.Current.Request.Url.PathAndQuery);
        }

        protected void BindData()
        {
            DdlBindData();
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        public void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1005";
            //请选择
            ddlInputSLART.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputSLART.DataTextField = "NAME";
            ddlInputSLART.DataValueField = "CODE";
            ddlInputSLART.DataBind();
            ddlInputSLART.Items.Insert(0, new ListItem("--请选择--", ""));


            cause.PARENT_ID = "HEM_1017";
            ddlInputTYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputTYPE_ID.DataTextField = "NAME";
            ddlInputTYPE_ID.DataValueField = "CODE";
            ddlInputTYPE_ID.DataBind();
            ddlInputTYPE_ID.Items.Insert(0, new ListItem("--请选择--", ""));

            ddlInputSLART.Attributes.Add("onchange", "onChangClick('" + ddlInputSLART.ClientID + "','" + ddlInputTYPE_ID.ClientID + "')");
        }

        protected void ShowQueryResult(string page, CauseObject_HEM_B_STAFF_EDUCATION parameter)
        {
            ViewState["OBJ_ID"] = null;
            SetEditClear();

            CauseObject_HEM_B_STAFF_EDUCATION cause = parameter;
            try
            {
                int[] arrPage = (int[])ViewState["pageNum"];
                int npage = GetPageIndex(page, arrPage, txt_PageNo);
                PagingParamter paging = new PagingParamter() { PageIndex = npage, PageSize = 4 };
                OrderByParameter orderBy = new OrderByParameter() { Asc = true, OrderBy = "SLART" };
                DisplayObject_HEM_B_STAFF_EDUCATION[] disSE = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Query(cause, paging, orderBy);
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

        public CauseObject_HEM_B_STAFF_EDUCATION CauseObject_Where()
        {
            CauseObject_HEM_B_STAFF_EDUCATION cause = new CauseObject_HEM_B_STAFF_EDUCATION();
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

        protected EntityObject_HEM_B_STAFF_EDUCATION SetEditEntity(EntityObject_HEM_B_STAFF_EDUCATION entity)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            //学校名称
            if (!string.IsNullOrEmpty(this.txtInputINSTI.Text))
            {
                entity.INSTI = this.txtInputINSTI.Text;
            }
            else
            {
                entity.INSTI = "";
            }

            //开始日期
            if (!string.IsNullOrEmpty(this.txtInputBEGDA.Text))
            {
                entity.BEGDA = DateTime.Parse(this.txtInputBEGDA.Text);
            }
            else
            {
                entity.BEGDA = Ipedf.Common.Template.UndefineDatetime;
            }

            //结束日期
            if (!string.IsNullOrEmpty(this.txtInputENDDA.Text))
            {
                entity.ENDDA = DateTime.Parse(this.txtInputENDDA.Text);
            }
            else
            {
                entity.ENDDA = Ipedf.Common.Template.UndefineDatetime;
            }

            //学历
            if (!string.IsNullOrEmpty(this.ddlInputSLART.SelectedValue))
            {
                entity.SLART = this.ddlInputSLART.SelectedValue;
            }
            else
            {
                entity.SLART = "";
            }

            //学科专业1
            if (!string.IsNullOrEmpty(this.txtInputZHRXKZY1.Text))
            {
                entity.ZHRXKZY1 = this.txtInputZHRXKZY1.Text;
            }
            else
            {
                entity.ZHRXKZY1 = "";
            }

            //学科专业2
            if (!string.IsNullOrEmpty(this.txtInputZHRXKZY2.Text))
            {
                entity.ZHRXKZY2 = this.txtInputZHRXKZY2.Text;
            }
            else
            {
                entity.ZHRXKZY2 = "";
            }
            //研究方向
            if (!string.IsNullOrEmpty(this.txtInputZHRXYJFX.Text))
            {
                entity.ZHRXYJFX = this.txtInputZHRXYJFX.Text;
            }
            else
            {
                entity.ZHRXYJFX = "";
            }

            //导师
            if (!string.IsNullOrEmpty(this.txtInputZHRDSXM.Text))
            {
                entity.ZHRDSXM = this.txtInputZHRDSXM.Text;
            }
            else
            {
                entity.ZHRDSXM = "";
            }

            //学科类型
            if (!string.IsNullOrEmpty(this.ddlInputTYPE_ID.SelectedValue))
            {
                entity.TYPE_ID = this.ddlInputTYPE_ID.SelectedValue;
            }
            else
            {
                entity.TYPE_ID = "";
            }

            if (this.ckInputIS_HIGHEST.Checked)
            {
                entity.IS_HIGHEST = 1;
            }
            else
            {
                entity.IS_HIGHEST = 0;
            }

            return entity;
        }

        protected void GetEditEntity(EntityObject_HEM_B_STAFF_EDUCATION entity)
        {
            //学校名称
            if (entity.INSTI != null)
            {
                this.txtInputINSTI.Text = entity.INSTI.Trim();
            }
            //开始日期
            this.txtInputBEGDA.Text = entity.BEGDA.ToString("yyyy-MM-dd");

            //结束日期
            this.txtInputENDDA.Text = entity.ENDDA.ToString("yyyy-MM-dd");

            //学历
            if (entity.SLART != null)
            {
                foreach (ListItem it in this.ddlInputSLART.Items)
                {
                    if (it.Value == entity.SLART.Trim())
                    {
                        this.ddlInputSLART.Items.FindByValue(entity.SLART.Trim()).Selected = true;
                        break;
                    }
                }

                if (entity.SLART != "10" && entity.SLART != "11")
                {
                    ddlInputTYPE_ID.Enabled = false;
                }
                else
                {
                    ddlInputTYPE_ID.Enabled = true;
                }

            }
            //学科类型
            if (entity.TYPE_ID != null)
            {
                foreach (ListItem it in this.ddlInputTYPE_ID.Items)
                {
                    if (it.Value == entity.TYPE_ID.Trim())
                    {
                        this.ddlInputTYPE_ID.Items.FindByValue(entity.TYPE_ID.Trim()).Selected = true;
                        break;
                    }
                }
            }


            //学科专业1
            if (entity.ZHRXKZY1 != null)
            {
                this.txtInputZHRXKZY1.Text = entity.ZHRXKZY1.Trim();
            }
            //学科专业2
            if (entity.ZHRXKZY2 != null)
            {
                this.txtInputZHRXKZY2.Text = entity.ZHRXKZY2.Trim();
            }
            //研究方向
            if (entity.ZHRXYJFX != null)
            {
                this.txtInputZHRXYJFX.Text = entity.ZHRXYJFX.Trim();
            }

            //导师
            if (entity.ZHRDSXM != null)
            {
                this.txtInputZHRDSXM.Text = entity.ZHRDSXM.Trim();
            }

            if (entity.IS_HIGHEST == 1)
            {
                this.ckInputIS_HIGHEST.Checked = true;
            }
            else
            {
                this.ckInputIS_HIGHEST.Checked = false;
            }
        }

        protected void SetEditClear()
        {
            //学校名称
            this.txtInputINSTI.Text = "";
            //开始日期
            this.txtInputBEGDA.Text = "";

            //结束日期
            this.txtInputENDDA.Text = "";

            //学历
            this.ddlInputSLART.ClearSelection();

            this.ddlInputTYPE_ID.ClearSelection();
            this.ddlInputTYPE_ID.Enabled = false;

            //学科专业1
            this.txtInputZHRXKZY1.Text = "";

            //学科专业2
            this.txtInputZHRXKZY2.Text = "";

            //研究方向
            this.txtInputZHRXYJFX.Text = "";

            this.ckInputIS_HIGHEST.Checked = false;

            this.txtInputZHRDSXM.Text = "";
        }

        protected void rpt_List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ID = e.CommandArgument.ToString();
            EntityObject_HEM_B_STAFF_EDUCATION entity = new EntityObject_HEM_B_STAFF_EDUCATION();
            entity.ID = ID;
            if (e.CommandName == "Edit")
            {
                ddlInputSLART.ClearSelection();
                ddlInputTYPE_ID.ClearSelection();
                try
                {
                    entity = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Get(entity);
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
                EntityObject_HEM_B_STAFF staffEntity = ViewState["CUR_STAFF"] as EntityObject_HEM_B_STAFF;
                CauseObject_HEM_B_STAFF_EDUCATION causeStaffEducation = new CauseObject_HEM_B_STAFF_EDUCATION();
                causeStaffEducation.STAFF_ID = staffEntity.ID;
                DisplayObject_HEM_B_STAFF_EDUCATION[] displayStaffEducation = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Query(causeStaffEducation);
                if (displayStaffEducation.Length != 1)
                {
                    BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Delete(entity);
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
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "教育信息为必填信息,不能全部删除!";
                }
            }
        }

        protected void rpt_List_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DisplayObject_HEM_B_STAFF_EDUCATION display = (DisplayObject_HEM_B_STAFF_EDUCATION)e.Item.DataItem;

                if (!string.IsNullOrEmpty(display.SLART))
                {
                    display.SLART = ddlInputSLART.Items.FindByValue(display.SLART).Text;
                    ((Label)e.Item.FindControl("lbl_SLART")).Text = display.SLART;
                }

                ((Label)e.Item.FindControl("lbl_ZHRXKZY1")).Text = StrCutOut(display.ZHRXKZY1, 5);

                Label lbl_TYPE_ID = ((Label)e.Item.FindControl("lbl_TYPE_ID"));
                if (!string.IsNullOrEmpty(display.TYPE_ID))
                {
                    display.TYPE_ID = ddlInputTYPE_ID.Items.FindByValue(display.TYPE_ID).Text;
                    lbl_TYPE_ID.Text = display.TYPE_ID;
                }
                else
                {
                    lbl_TYPE_ID.Text = "";
                }

            }
        }
    }
}
