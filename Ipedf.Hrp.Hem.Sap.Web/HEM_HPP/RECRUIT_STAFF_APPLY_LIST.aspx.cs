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

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class RECRUIT_STAFF_APPLY_LIST : User_Page
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

        public CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF CauseObject_Where()
        {
            CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause = new CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF();
            //cause.STATUS = (decimal)POSTER_STATUS.已发布;
            cause.SetCustomCondition(" AND V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE > (to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd')-1) AND V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE <= (to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd'))");

            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF parameter)
        {
            CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause = parameter;
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
                DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] disSE = BizLogicObject_V_HEM_B_RECRUIT_POSTER_STAFF.Proxy.Query(cause, paging, orderBy);
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

        protected void rpt_List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "APPLY")
            {
                string ID = e.CommandArgument.ToString();
                System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                parameters.Add("ID", ID);
                Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_HPP/RECRUIT_STAFF_APPLY.aspx", parameters));
            }
        }

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }
    }
}
