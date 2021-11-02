using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
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

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class RECRUIT_STAFF_LIST : Manage_Page
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
            cause.PARENT_ID = "HEM_1013";
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

        public CauseObject_V_HEM_B_STAFF_APPLY CauseObject_Where()
        {
            CauseObject_V_HEM_B_STAFF_APPLY cause = new CauseObject_V_HEM_B_STAFF_APPLY();
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
            if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
            {
                cause.SetCustomCondition(" AND V_HEM_B_STAFF_APPLY.END_DATE > (to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd')-1) AND ( V_HEM_B_STAFF_APPLY.MANAGE_USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_STAFF_APPLY.IS_PUBLIC = 1 )");
            }
            else
            {
                cause.SetCustomCondition(" AND V_HEM_B_STAFF_APPLY.END_DATE > (to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd')-1)");
            }
            cause.POSTER_STATUS = (decimal)POSTER_STATUS.已发布;
            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_V_HEM_B_STAFF_APPLY parameter)
        {
            CauseObject_V_HEM_B_STAFF_APPLY cause = parameter;
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
                OrderByParameter orderBy = new OrderByParameter() { Asc = true, OrderBy = "STATUS" };
                DisplayObject_V_HEM_B_STAFF_APPLY[] disQuery = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(cause, paging, orderBy);
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

        public string UrlDetail(object id, object applyId)
        {
            if (id != null)
            {
                if (KeyNotNull(id.ToString()))
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("ID", id.ToString());
                    parameters.Add("APPLY_ID", applyId.ToString());
                    string url = WebControlHelper.EncodeUrl("RECRUIT_RESUME_PREVIEW.aspx", parameters);
                    return url;
                }
            }
            return "";
        }

        private DisplayObject_V_HEM_B_STAFF_APPLY LinkDisplay()
        {
            string id = txt_hd_retid.Value;
            CauseObject_V_HEM_B_STAFF_APPLY cause = new CauseObject_V_HEM_B_STAFF_APPLY();
            cause = CauseObject_Where();
            cause.ID = id;

            DisplayObject_V_HEM_B_STAFF_APPLY[] display = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(cause);
            DisplayObject_V_HEM_B_STAFF_APPLY vsa = new DisplayObject_V_HEM_B_STAFF_APPLY();

            if (display.Length > 0)
            {
                vsa = display[0];
            }

            return vsa;
        }

        protected void btnPass_Click(object sender, EventArgs e)
        {
            DisplayObject_V_HEM_B_STAFF_APPLY vsa = LinkDisplay();
            if (vsa != null)
            {
                if (vsa.STATUS != (decimal)APPLY_STATUS.传输成功)
                {
                    Update(vsa.ID, vsa.STAFF_TYPE_ID, (decimal)APPLY_STATUS.简历通过);
                }
            }
        }

        protected void btnNotAllow_Click(object sender, EventArgs e)
        {
            DisplayObject_V_HEM_B_STAFF_APPLY vsa = LinkDisplay();
            if (vsa != null)
            {
                if (vsa.STATUS != (decimal)APPLY_STATUS.传输成功)
                {
                    Update(vsa.ID, vsa.STAFF_TYPE_ID, (decimal)APPLY_STATUS.已拒绝);
                }
            }
        }

        private void Update(string Id, string StaffType_Id, decimal Status)
        {
            EntityObject_HEM_B_STAFF_APPLY entity = new EntityObject_HEM_B_STAFF_APPLY();
            entity.ID = Id;
            entity.STATUS = Status;
            entity.STAFF_TYPE_ID = StaffType_Id;
            entity.SetUpdate("STATUS");
            BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_APPLY.Proxy.UpdateState(entity);
            if (msg.Succeed)
            {
                if (!string.IsNullOrEmpty(msg.Message))
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('以下人员简历已处理:" + msg.Message + "！');</script>");
                }
                else
                {
                    ThisPage();
                }
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = msg.Message;
                ThisPage();
            }
        }

        public bool KeyNotNull(string id)
        {
            if (!string.IsNullOrEmpty(id) && id != "00000000-0000-0000-0000-000000000000")
            {
                return true;
            }
            return false;
        }

        protected List<EntityObject_HEM_B_STAFF_APPLY> ListEntity(decimal STATUS, ref string StrName)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            List<EntityObject_HEM_B_STAFF_APPLY> entityItem = new List<EntityObject_HEM_B_STAFF_APPLY>();
            List<DisplayObject_V_HEM_B_STAFF_APPLY> list = ckListDisplay();
            List<string> ListStaff = new List<string>();

            foreach (DisplayObject_V_HEM_B_STAFF_APPLY vsa in list)
            {
                if (vsa.STATUS != 5)
                {
                    EntityObject_HEM_B_STAFF_APPLY entity = new EntityObject_HEM_B_STAFF_APPLY();
                    entity.ID = vsa.ID;
                    entity.STAFF_TYPE_ID = vsa.STAFF_TYPE_ID;
                    if (!ListStaff.Contains(vsa.STAFF_ID))
                    {
                        ListStaff.Add(vsa.STAFF_ID);
                        if (KeyNotNull(entity.ID))
                        {
                            entity.STATUS = STATUS;

                            entity.SetUpdate("STATUS");
                            entityItem.Add(entity);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(StrName))
                        {
                            StrName = vsa.NACHN;
                        }
                        else
                        {
                            StrName = StrName + ";" + vsa.NACHN;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(StrName))
            {
                entityItem.Clear();
            }

            return entityItem;
        }

        private List<DisplayObject_V_HEM_B_STAFF_APPLY> ckListDisplay()
        {
            CauseObject_V_HEM_B_STAFF_APPLY cause = new CauseObject_V_HEM_B_STAFF_APPLY();
            cause = CauseObject_Where();
            List<DisplayObject_V_HEM_B_STAFF_APPLY> list = new List<DisplayObject_V_HEM_B_STAFF_APPLY>();
            bool IsTrue = false;
            foreach (RepeaterItem Item in this.rpt_List.Items)
            {
                CheckBox select = (CheckBox)Item.FindControl("cbSelect");
                if (select.Checked)
                {
                    Label lbl_ID = (Label)Item.FindControl("lbl_ID");
                    if (!string.IsNullOrEmpty(lbl_ID.Text))
                    {
                        IsTrue = true;
                        cause.SetINValue("ID", lbl_ID.Text);
                    }
                }
            }

            if (IsTrue)
            {
                DisplayObject_V_HEM_B_STAFF_APPLY[] display = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(cause);
                list = display.ToList();
            }
            return list;
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

        public void ClickMessage(BizLogicMsg msg, bool IsAlertError)
        {
            if (msg.Succeed && string.IsNullOrEmpty(msg.Message))
            {
                ThisPage();
            }
            else if (msg.Succeed && !string.IsNullOrEmpty(msg.Message))
            {
                string quy = HttpContext.Current.Request.Url.Query;
                string url = "RECRUIT_STAFF_LIST.aspx";
                if (!string.IsNullOrEmpty(quy))
                {
                    url = url + quy;
                }
                if (!IsAlertError)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('以下人员(" + msg.Message + ")正在处理中!');location.href='" + url + "';</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + msg.Message + "');location.href='" + url + "';</script>");
                }
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = msg.Message;
            }
        }

        #region 简历通过
        protected void btn_YTG_Click(object sender, EventArgs e)
        {
            string strName = "";
            List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.简历通过, ref strName);
            UpdateApplyStatus(entityItem, strName);
        }
        #endregion

        #region 安排面试
        protected void btn_YMS_Click(object sender, EventArgs e)
        {
            string strName = "";
            List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.安排面试, ref strName);
            UpdateApplyStatus(entityItem, strName);
        }
        #endregion

        #region 已拒绝
        protected void btn_YJJ_Click(object sender, EventArgs e)
        {
            string strName = "";
            List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.已拒绝, ref strName);
            UpdateApplyStatus(entityItem, strName);
        }
        #endregion

        #region 已完成
        protected void btn_YWC_Click(object sender, EventArgs e)
        {
            string strName = "";
            List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.已完成, ref strName);
            UpdateApplyStatus(entityItem, strName);
        }
        #endregion




        private void UpdateApplyStatus(List<EntityObject_HEM_B_STAFF_APPLY> entityItem, string strName)
        {
            BizLogicMsg msg = new BizLogicMsg();
            if (entityItem.Count > 0)
            {
                EntityObject_HEM_B_STAFF_APPLY[] Item = new EntityObject_HEM_B_STAFF_APPLY[entityItem.Count];
                entityItem.CopyTo(Item);
                msg = BizLogicObject_HEM_B_STAFF_APPLY.Proxy.Update(Item);
                ClickMessage(msg, false);
            }
            else
            {
                if (!string.IsNullOrEmpty(strName))
                {
                    msg.Succeed = true;
                    msg.Message = "以下人员重复选择：[" + strName + "]";
                    ClickMessage(msg, true);
                }
            }
        }

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }
    }
}
