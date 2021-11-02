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
    public partial class USER_STAFF_LIST : Manage_Page
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

        protected void BindData()
        {
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        public void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1012";
            ddlInputTYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputTYPE_ID.DataTextField = "NAME";
            ddlInputTYPE_ID.DataValueField = "CODE";
            ddlInputTYPE_ID.DataBind();
            ddlInputTYPE_ID.Items.Insert(0, new ListItem("--全部--", ""));

            cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1014";
            ddlInputPageSize.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPageSize.DataTextField = "NAME";
            ddlInputPageSize.DataValueField = "CODE";
            ddlInputPageSize.DataBind();
        }

        public CauseObject_V_HEM_B_USER_STAFF CauseObject_Where()
        {
            CauseObject_V_HEM_B_USER_STAFF cause = new CauseObject_V_HEM_B_USER_STAFF();
            cause = getCauseObject();
            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_V_HEM_B_USER_STAFF parameter)
        {
            CauseObject_V_HEM_B_USER_STAFF cause = parameter;
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
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "ID" };
                DisplayObject_V_HEM_B_USER_STAFF[] disQuery = BizLogicObject_V_HEM_B_USER_STAFF.Proxy.Query(cause, paging, orderBy);
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

        public CauseObject_V_HEM_B_USER_STAFF getCauseObject()
        {
            string NACHN = txt_NACHN.Text;
            string MOBILE = txt_MOBILE.Text;
            string STAFF_TYPE_ID = this.ddlInputTYPE_ID.SelectedValue;
            CauseObject_V_HEM_B_USER_STAFF cause = new CauseObject_V_HEM_B_USER_STAFF();
            string sqlWhere = "";
            if (!string.IsNullOrEmpty(MOBILE))
            {
                cause.USRID_TEL = MOBILE;
            }
            if (!string.IsNullOrEmpty(NACHN))
            {
                sqlWhere = sqlWhere + " AND V_HEM_B_USER_STAFF.NACHN LIKE '%" + NACHN + "%'";
            }

            if (!string.IsNullOrEmpty(STAFF_TYPE_ID))
            {
                sqlWhere = sqlWhere + " AND V_HEM_B_USER_STAFF.TYPE_ID LIKE '" + STAFF_TYPE_ID + "'";
            }

            if (!string.IsNullOrEmpty(sqlWhere))
            {
                cause.SetCustomCondition(sqlWhere);
            }
            return cause;
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

        public string UrlDetail(object id)
        {
            if (id != null)
            {
                if (KeyNotNull(id.ToString()))
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("ID", id.ToString());
                    string url = WebControlHelper.EncodeUrl("RECRUIT_RESUME_PREVIEW.aspx", parameters);
                    return url;
                }
            }
            return "";
        }

        protected void ThisPage()
        {
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
    }
}
