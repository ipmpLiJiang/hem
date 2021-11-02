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
using System.Collections.Generic;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class RECRUIT_POSTER_LIST_DUE : Manage_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                try
                {
                    DdlBindData();
                    BindData(false);
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

        protected void lkBtnEdit_Click(object sender, EventArgs e)
        {
            LinkButton BtnEdit = (LinkButton)sender;//强转
            string id = BtnEdit.CommandArgument.ToString();
            if (KeyNotNull(id))
            {
                System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                parameters.Add("ID", id);
                Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_HPP/RECRUIT_POSTER_EDIT.aspx", parameters));

            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txt_hd_id.Value;
            if (KeyNotNull(id))
            {
                System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                parameters.Add("ID", id);
                Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_HPP/RECRUIT_POSTER_EDIT.aspx", parameters));

            }
        }

        protected void BindData(bool ck)
        {
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where(ck));
        }

        public CauseObject_V_HEM_B_RECRUIT_POSTER CauseObject_Where(bool ck)
        {
            CauseObject_V_HEM_B_RECRUIT_POSTER cause = new CauseObject_V_HEM_B_RECRUIT_POSTER();
            string yfb = ((decimal)POSTER_STATUS.已发布).ToString();
            string ygq = ((decimal)POSTER_STATUS.已过期).ToString();
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
            if (ck)
            {
                // AND ( V_HEM_B_RECRUIT_POSTER.USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_RECRUIT_POSTER.IS_PUBLIC = 1 )
                if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
                {
                    cause.SetCustomCondition(" AND ((V_HEM_B_RECRUIT_POSTER.WCL > 0 OR V_HEM_B_RECRUIT_POSTER.YTG > 0 OR V_HEM_B_RECRUIT_POSTER.YMS > 0) AND ((V_HEM_B_RECRUIT_POSTER.STATUS = " + ygq + ") OR (V_HEM_B_RECRUIT_POSTER.STATUS = " + yfb + " AND V_HEM_B_RECRUIT_POSTER.END_DATE < to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd'))) AND ( V_HEM_B_RECRUIT_POSTER.USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_RECRUIT_POSTER.IS_PUBLIC = 1 ))");
                }
                else
                {
                    cause.SetCustomCondition(" AND (V_HEM_B_RECRUIT_POSTER.WCL > 0 OR V_HEM_B_RECRUIT_POSTER.YTG > 0 OR V_HEM_B_RECRUIT_POSTER.YMS > 0) AND ((V_HEM_B_RECRUIT_POSTER.STATUS = " + ygq + ") OR (V_HEM_B_RECRUIT_POSTER.STATUS = " + yfb + " AND V_HEM_B_RECRUIT_POSTER.END_DATE < to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd')))");
                }
            }
            else
            {
                if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
                {
                    cause.SetCustomCondition(" AND (((V_HEM_B_RECRUIT_POSTER.STATUS = " + ygq + ") OR (V_HEM_B_RECRUIT_POSTER.STATUS = " + yfb + " AND V_HEM_B_RECRUIT_POSTER.END_DATE < to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd'))) AND ( V_HEM_B_RECRUIT_POSTER.USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_RECRUIT_POSTER.IS_PUBLIC = 1 ))");
                }
                else
                {
                    cause.SetCustomCondition(" AND ((V_HEM_B_RECRUIT_POSTER.STATUS = " + ygq + ") OR (V_HEM_B_RECRUIT_POSTER.STATUS = " + yfb + " AND V_HEM_B_RECRUIT_POSTER.END_DATE < to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd')))");
                }
            }
            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_V_HEM_B_RECRUIT_POSTER parameter)
        {
            CauseObject_V_HEM_B_RECRUIT_POSTER cause = parameter;
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
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "PUBLISH_DATE" };
                DisplayObject_V_HEM_B_RECRUIT_POSTER[] disQuery = BizLogicObject_V_HEM_B_RECRUIT_POSTER.Proxy.Query(cause, paging, orderBy);
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

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where(this.cb_wcl.Checked));
        }

        public string UrlDetail(object id)
        {
            if (id != null)
            {
                if (KeyNotNull(id.ToString()))
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("ID", id.ToString());
                    string url = WebControlHelper.EncodeUrl("RECRUIT_POSTER_DETAIL.aspx", parameters);
                    return url;
                }
            }
            return "";
        }

        public string UrlPosterQuery(object id, object status)
        {
            if (id != null)
            {
                if (KeyNotNull(id.ToString()))
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("POSTER_ID", id.ToString());
                    parameters.Add("STATUS", status.ToString());
                    string url = WebControlHelper.EncodeUrl("RECRUIT_STAFF_LIST_Q.aspx", parameters);
                    return url;
                }
            }
            return "";
        }

        protected void lkBtnCopy_Click(object sender, EventArgs e)
        {
            LinkButton BtnCopy = (LinkButton)sender;//强转
            string id = BtnCopy.CommandArgument.ToString();

            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            if (KeyNotNull(id))
            {
                EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                entity.ID = id;
                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Copy(entity);
                if (msg.Succeed)
                {
                    Response.Redirect("~/HEM_HPP/RECRUIT_POSTER_LIST.aspx");
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
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

        protected void lbt_home_Click(object sender, EventArgs e)
        {
            PageMethod("home");
        }
        protected void lbt_back_Click(object sender, EventArgs e)
        {
            PageMethod("back");
        }
        protected void lbt_next_Click(object sender, EventArgs e)
        {
            PageMethod("next");
        }
        protected void lbt_last_Click(object sender, EventArgs e)
        {
            PageMethod("last");
        }
        protected void btn_GoPage_Click(object sender, EventArgs e)
        {
            PageMethod("custom");
        }

        public void PageMethod(string act)
        {
            bool ck = this.cb_wcl.Checked;
            ShowQueryResult(act, CauseObject_Where(ck));
        }

        protected void cb_wcl_CheckedChanged(object sender, EventArgs e)
        {
            bool ck = this.cb_wcl.Checked;
            BindData(ck);
        }
    }
}
