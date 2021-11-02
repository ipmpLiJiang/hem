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
    public partial class STAFF_SEND_ESSAY : User_Page
    {
        private const decimal cIS_NURSE = 3;
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

        protected void btn_SaveNext_Click(object sender, EventArgs e)
        {
            if (ViewState["OBJ_ID"] != null)
            {
                bool bl = SaveMethod();
                if (bl)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_SEND_MEMBER.aspx';</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_SEND_MEMBER.aspx';</script>");
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
            EntityObject_HEM_B_STAFF_ESSAY entity = new EntityObject_HEM_B_STAFF_ESSAY();
            SetEditEntity(entity);
            //文章名称
            if (string.IsNullOrEmpty(entity.ZHRWZMC))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "文章名称不能为空！";
                //WebControlHelper.ShowAlert(null, "文章名称不能为空！");
                return false;
            }

            //出版时间
            if (string.IsNullOrEmpty(entity.BEGDA.ToString()))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "出版时间不能为空！";
                //WebControlHelper.ShowAlert(null, "出版时间不能为空！");
                return false;
            }

            //出版刊物
            if (string.IsNullOrEmpty(entity.ZHRCBKW.ToString()))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "出版刊物不能为空！";
                //WebControlHelper.ShowAlert(null, "出版刊物不能为空！");
                return false;
            }

            //刊物级别
            if (string.IsNullOrEmpty(entity.ZHRKWJB))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "请选择刊物级别！";
                //WebControlHelper.ShowAlert(null, "请选择刊物级别！");
                return false;
            }

            //本人排名
            if (string.IsNullOrEmpty(entity.ZHRBRMP))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "请选择本人排名！";
                //WebControlHelper.ShowAlert(null, "请选择本人排名！");
                return false;
            }

            EntityObject_HEM_B_STAFF staffEntity = ViewState["CUR_STAFF"] as EntityObject_HEM_B_STAFF;
            if (ViewState["OBJ_ID"] == null)
            {
                entity.STAFF_ID = staffEntity.ID;
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_ESSAY.Proxy.Save(entity);
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
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_ESSAY.Proxy.Update(entity);
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

                DisplayObject_HEM_B_STAFF_ESSAY display = (DisplayObject_HEM_B_STAFF_ESSAY)e.Item.DataItem;

                ((Label)e.Item.FindControl("lbl_ZHRCBKW")).Text = StrCutOut(display.ZHRCBKW, 5);

                if (!string.IsNullOrEmpty(display.ZHRKWJB))
                {
                    display.ZHRKWJB = ddlInputZHRKWJB.Items.FindByValue(display.ZHRKWJB).Text;
                    ((Label)e.Item.FindControl("lbl_ZHRKWJB")).Text = display.ZHRKWJB;
                }

                if (!string.IsNullOrEmpty(display.ZHRBRMP))
                {
                    display.ZHRBRMP = ddlInputZHRBRMP.Items.FindByValue(display.ZHRBRMP).Text;
                    ((Label)e.Item.FindControl("lbl_ZHRBRMP")).Text = display.ZHRBRMP;
                }

                if (!string.IsNullOrEmpty(display.ZHRFBZT))
                {
                    display.ZHRFBZT = ddlInputZHRFBZT.Items.FindByValue(display.ZHRFBZT).Text;
                    ((Label)e.Item.FindControl("lbl_ZHRFBZT")).Text = display.ZHRFBZT;
                }

                ((Label)e.Item.FindControl("lab_ZHRCBKH")).Text = StrCutOut(display.ZHRCBKH, 10);
            }
        }

        protected void rpt_List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ID = e.CommandArgument.ToString();
            EntityObject_HEM_B_STAFF_ESSAY entity = new EntityObject_HEM_B_STAFF_ESSAY();
            entity.ID = ID;
            if (e.CommandName == "Edit")
            {
                SetEditClear();
                try
                {
                    entity = BizLogicObject_HEM_B_STAFF_ESSAY.Proxy.Get(entity);
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

                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_ESSAY.Proxy.Delete(entity);
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
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('删除成功,完善/修改简历后请提交简历!');location.href='STAFF_ESSAY.aspx';</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!');location.href='STAFF_ESSAY.aspx';</script>");
            }
            //Response.Redirect(HttpContext.Current.Request.Url.PathAndQuery);
        }

        public void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1007";
            //请选择
            ddlInputZHRBRMP.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRBRMP.DataTextField = "NAME";
            ddlInputZHRBRMP.DataValueField = "CODE";
            ddlInputZHRBRMP.DataBind();
            ddlInputZHRBRMP.Items.Insert(0, new ListItem("--请选择--", ""));

            cause.PARENT_ID = "HEM_1006";
            ddlInputZHRKWJB.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRKWJB.DataTextField = "NAME";
            ddlInputZHRKWJB.DataValueField = "CODE";
            ddlInputZHRKWJB.DataBind();
            ddlInputZHRKWJB.Items.Insert(0, new ListItem("--请选择--", ""));

            cause.PARENT_ID = "HEM_1011";
            ddlInputZHRFBZT.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRFBZT.DataTextField = "NAME";
            ddlInputZHRFBZT.DataValueField = "CODE";
            ddlInputZHRFBZT.DataBind();

        }

        protected void BindData()
        {
            DdlBindData();
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void ShowQueryResult(string page, CauseObject_HEM_B_STAFF_ESSAY parameter)
        {
            ViewState["OBJ_ID"] = null;
            SetEditClear();
            CauseObject_HEM_B_STAFF_ESSAY cause = parameter;
            try
            {
                int[] arrPage = (int[])ViewState["pageNum"];
                int npage = GetPageIndex(page, arrPage, txt_PageNo);
                PagingParamter paging = new PagingParamter() { PageIndex = npage, PageSize = 4 };
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "BEGDA" };
                DisplayObject_HEM_B_STAFF_ESSAY[] disSE = BizLogicObject_HEM_B_STAFF_ESSAY.Proxy.Query(cause, paging, orderBy);
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

        public CauseObject_HEM_B_STAFF_ESSAY CauseObject_Where()
        {
            CauseObject_HEM_B_STAFF_ESSAY cause = new CauseObject_HEM_B_STAFF_ESSAY();
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

        protected EntityObject_HEM_B_STAFF_ESSAY SetEditEntity(EntityObject_HEM_B_STAFF_ESSAY entity)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            //文章名称
            if (!string.IsNullOrEmpty(this.txtInputZHRWZMC.Text))
            {
                entity.ZHRWZMC = this.txtInputZHRWZMC.Text;
            }
            else
            {
                entity.ZHRWZMC = "";
            }

            //出版时间
            if (!string.IsNullOrEmpty(this.txtInputBEGDA.Text))
            {
                entity.BEGDA = DateTime.Parse(this.txtInputBEGDA.Text);
            }
            else
            {
                entity.BEGDA = Ipedf.Common.Template.UndefineDatetime;
            }

            //出版刊物
            if (!string.IsNullOrEmpty(this.txtInputZHRCBKW.Text))
            {
                entity.ZHRCBKW = this.txtInputZHRCBKW.Text;
            }
            else
            {
                entity.ZHRCBKW = "";
            }

            //刊物级别
            if (!string.IsNullOrEmpty(this.ddlInputZHRKWJB.SelectedValue))
            {
                entity.ZHRKWJB = this.ddlInputZHRKWJB.SelectedValue;
            }
            else
            {
                entity.ZHRKWJB = "";
            }

            //刊号
            if (!string.IsNullOrEmpty(this.txtInputZHRCBKH.Text))
            {
                entity.ZHRCBKH = this.txtInputZHRCBKH.Text;
            }
            else
            {
                entity.ZHRCBKH = "";
            }

            //影响因子
            if (!string.IsNullOrEmpty(this.txtInputZHRYXYZ.Text))
            {
                entity.ZHRYXYZ = this.txtInputZHRYXYZ.Text;
            }
            else
            {
                entity.ZHRYXYZ = "";
            }
            //本人排名
            if (!string.IsNullOrEmpty(this.ddlInputZHRBRMP.SelectedValue))
            {
                entity.ZHRBRMP = this.ddlInputZHRBRMP.SelectedValue;
            }
            else
            {
                entity.ZHRBRMP = "";
            }

            //发布状态
            if (!string.IsNullOrEmpty(this.ddlInputZHRFBZT.SelectedValue))
            {
                entity.ZHRFBZT = this.ddlInputZHRFBZT.SelectedValue;
            }
            else
            {
                entity.ZHRFBZT = "";
            }
            return entity;
        }

        protected void GetEditEntity(EntityObject_HEM_B_STAFF_ESSAY entity)
        {
            //文章名称
            if (entity.ZHRWZMC != null)
            {
                this.txtInputZHRWZMC.Text = entity.ZHRWZMC.Trim();
            }
            //出版时间
            this.txtInputBEGDA.Text = entity.BEGDA.ToString("yyyy-MM-dd");

            //出版刊物
            if (entity.ZHRCBKW != null)
            {
                this.txtInputZHRCBKW.Text = entity.ZHRCBKW.Trim();
            }
            //刊物级别
            if (entity.ZHRKWJB != null)
            {
                foreach (ListItem it in this.ddlInputZHRKWJB.Items)
                {
                    if (it.Value == entity.ZHRKWJB.Trim())
                    {
                        this.ddlInputZHRKWJB.Items.FindByValue(entity.ZHRKWJB.Trim()).Selected = true;
                        break;
                    }
                }
            }
            //刊号
            if (entity.ZHRCBKH != null)
            {
                this.txtInputZHRCBKH.Text = entity.ZHRCBKH.Trim();
            }
            //影响因子
            if (entity.ZHRYXYZ != null)
            {
                this.txtInputZHRYXYZ.Text = entity.ZHRYXYZ.Trim();
            }
            //本人排名
            if (entity.ZHRBRMP != null)
            {
                foreach (ListItem it in this.ddlInputZHRBRMP.Items)
                {
                    if (it.Value == entity.ZHRBRMP.Trim())
                    {
                        this.ddlInputZHRBRMP.Items.FindByValue(entity.ZHRBRMP.Trim()).Selected = true;
                        break;
                    }
                }
            }
            //发布状态
            if (entity.ZHRFBZT != null)
            {
                foreach (ListItem it in this.ddlInputZHRFBZT.Items)
                {
                    if (it.Value == entity.ZHRFBZT.Trim())
                    {
                        this.ddlInputZHRFBZT.Items.FindByValue(entity.ZHRFBZT.Trim()).Selected = true;
                        break;
                    }
                }
            }
        }

        protected void SetEditClear()
        {
            //文章名称
            this.txtInputZHRWZMC.Text = "";
            //出版时间
            this.txtInputBEGDA.Text = "";

            //出版刊物
            this.txtInputZHRCBKW.Text = "";

            //刊物级别
            this.ddlInputZHRKWJB.ClearSelection();

            //刊号
            this.txtInputZHRCBKH.Text = "";

            //影响因子
            this.txtInputZHRYXYZ.Text = "";

            //本人排名
            this.ddlInputZHRBRMP.ClearSelection();

            //发布状态
            this.ddlInputZHRFBZT.ClearSelection();

        }
    }
}
