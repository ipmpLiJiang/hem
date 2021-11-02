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
    public partial class STAFF_NURSE_WORK : User_Page
    {
        private const decimal cIS_NURSE = 1;
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
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('护理简历,提交成功!');</script>");
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
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_NURSE_PROJECT.aspx';</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_NURSE_PROJECT.aspx';</script>");
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
            EntityObject_HEM_B_STAFF_WORK entity = new EntityObject_HEM_B_STAFF_WORK();
            SetEditEntity(entity);
            //学校_单位
            if (string.IsNullOrEmpty(entity.ZHRXXDW))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "学校_单位不能为空！";
                //WebControlHelper.ShowAlert(null, "姓名不能为空！");
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

            //专业_部门
            if (string.IsNullOrEmpty(entity.ZHRZYBM))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "专业_部门不能为空！";
                //WebControlHelper.ShowAlert(null, "专业_部门不能为空！");
                return false;
            }

            //职务
            if (string.IsNullOrEmpty(entity.ZHRGZZW))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "职务不能为空！";
                //WebControlHelper.ShowAlert(null, "职务不能为空！");
                return false;
            }

            EntityObject_HEM_B_STAFF staffEntity = ViewState["CUR_STAFF"] as EntityObject_HEM_B_STAFF;
            if (ViewState["OBJ_ID"] == null)
            {
                entity.STAFF_ID = staffEntity.ID;
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_WORK.Proxy.Save(entity);
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
                entity.SetNotUpdate("STAFF_ID");
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_WORK.Proxy.Update(entity);
                IsTrturn = msg.Succeed;
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
            }

            return IsTrturn;
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


        }

        protected void rpt_List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ID = e.CommandArgument.ToString();
            EntityObject_HEM_B_STAFF_WORK entity = new EntityObject_HEM_B_STAFF_WORK();
            entity.ID = ID;
            if (e.CommandName == "Edit")
            {
                ddlInputSLART.ClearSelection();
                try
                {
                    entity = BizLogicObject_HEM_B_STAFF_WORK.Proxy.Get(entity);
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

                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_WORK.Proxy.Delete(entity);
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
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('删除成功,完善/修改简历后请提交简历!');location.href='STAFF_NURSE_WORK.aspx';</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!');location.href='STAFF_NURSE_WORK.aspx';</script>");
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

        protected void ShowQueryResult(string page, CauseObject_HEM_B_STAFF_WORK parameter)
        {
            ViewState["OBJ_ID"] = null;
            SetEditClear();
            CauseObject_HEM_B_STAFF_WORK cause = parameter;
            try
            {
                int[] arrPage = (int[])ViewState["pageNum"];
                int npage = GetPageIndex(page, arrPage, txt_PageNo);
                PagingParamter paging = new PagingParamter() { PageIndex = npage, PageSize = 4 };
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "ENDDA" };
                DisplayObject_HEM_B_STAFF_WORK[] disSE = BizLogicObject_HEM_B_STAFF_WORK.Proxy.Query(cause, paging, orderBy);
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

        public CauseObject_HEM_B_STAFF_WORK CauseObject_Where()
        {
            CauseObject_HEM_B_STAFF_WORK cause = new CauseObject_HEM_B_STAFF_WORK();
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

        protected EntityObject_HEM_B_STAFF_WORK SetEditEntity(EntityObject_HEM_B_STAFF_WORK entity)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            //学校_单位
            if (!string.IsNullOrEmpty(this.txtInputZHRXXDW.Text))
            {
                entity.ZHRXXDW = this.txtInputZHRXXDW.Text;
            }
            else
            {
                entity.ZHRXXDW = "";
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

            //学历/学位
            if (!string.IsNullOrEmpty(this.ddlInputSLART.SelectedValue))
            {
                entity.SLART = this.ddlInputSLART.SelectedValue;
            }
            else
            {
                entity.SLART = "";
            }

            //专业_部门
            if (!string.IsNullOrEmpty(this.txtInputZHRZYBM.Text))
            {
                entity.ZHRZYBM = this.txtInputZHRZYBM.Text;
            }
            else
            {
                entity.ZHRZYBM = "";
            }

            //职务
            if (!string.IsNullOrEmpty(this.txtInputZHRGZZW.Text))
            {
                entity.ZHRGZZW = this.txtInputZHRGZZW.Text;
            }
            else
            {
                entity.ZHRGZZW = "";
            }

            return entity;
        }

        protected void GetEditEntity(EntityObject_HEM_B_STAFF_WORK entity)
        {
            //学校_单位
            if (entity.ZHRXXDW != null)
            {
                this.txtInputZHRXXDW.Text = entity.ZHRXXDW.Trim();
            }
            //开始日期
            this.txtInputBEGDA.Text = entity.BEGDA.ToString("yyyy-MM-dd");

            //结束日期
            this.txtInputENDDA.Text = entity.ENDDA.ToString("yyyy-MM-dd");

            //学历/学位
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
            }
            //专业_部门
            if (entity.ZHRZYBM != null)
            {
                this.txtInputZHRZYBM.Text = entity.ZHRZYBM.Trim();
            }
            //职务
            if (entity.ZHRGZZW != null)
            {
                this.txtInputZHRGZZW.Text = entity.ZHRGZZW.Trim();
            }
        }

        protected void SetEditClear()
        {
            //学校_单位
            this.txtInputZHRXXDW.Text = "";
            //开始日期
            this.txtInputBEGDA.Text = "";

            //结束日期
            this.txtInputENDDA.Text = "";

            //学历/学位
            this.ddlInputSLART.ClearSelection();

            //专业_部门
            this.txtInputZHRZYBM.Text = "";

            //职务
            this.txtInputZHRGZZW.Text = "";

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
                DisplayObject_HEM_B_STAFF_WORK display = (DisplayObject_HEM_B_STAFF_WORK)e.Item.DataItem;
                if (!string.IsNullOrEmpty(display.SLART))
                {
                    display.SLART = ddlInputSLART.Items.FindByValue(display.SLART).Text;
                    ((Label)e.Item.FindControl("lbl_SLART")).Text = display.SLART;
                }
                else
                {
                    ((Label)e.Item.FindControl("lbl_SLART")).Text = "";
                }

                ((Label)e.Item.FindControl("lab_ZHRZYBM")).Text = StrCutOut(display.ZHRZYBM, 7);
                ((Label)e.Item.FindControl("lab_ZHRGZZW")).Text = StrCutOut(display.ZHRGZZW, 7);
            }
        }
    }
}
