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
    public partial class MANAGE_USER_LIST : Manage_Page
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

        protected void DdlBindData()
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

        public CauseObject_V_USER_LOGIN_INFO CauseObject_Where()
        {
            CauseObject_V_USER_LOGIN_INFO cause = new CauseObject_V_USER_LOGIN_INFO();
            //cause.IS_USABL = 1;
            cause.SetCustomCondition(" AND V_USER_LOGIN_INFO.ACCOUNT <> 'admin'");
            cause.FLAG = 1;
            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_V_USER_LOGIN_INFO parameter)
        {
            CauseObject_V_USER_LOGIN_INFO cause = parameter;
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
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "CREATE_DATE" };
                DisplayObject_V_USER_LOGIN_INFO[] disQuery = BizLogicObject_V_USER_LOGIN_INFO.Proxy.Query(cause, paging, orderBy);
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

        public BizLogicMsg UpdateIsUsabl(string ID, int Is_Usabl)
        {
            EntityObject_HEM_B_USER_LOGIN entityUserLogin = new EntityObject_HEM_B_USER_LOGIN();
            entityUserLogin.ID = ID;
            entityUserLogin.IS_USABL = Is_Usabl;
            entityUserLogin.SetUpdate("IS_USABL");
            //biz.Update(entityUserLogin);
            BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Update(entityUserLogin);
            return msg;
        }

        protected void rpt_List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ID = e.CommandArgument.ToString();
            DisplayObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as DisplayObject_V_USER_LOGIN_INFO;
            if (UserInfo.ACCOUNT == "admin")
            {
                if (e.CommandName == "EDIT")
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("ID", ID);
                    Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_SYS/MANAGE_USER_EDIT.aspx", parameters));
                }

                if (e.CommandName == "PASSEDIT")
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("ID", ID);
                    Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_SYS/MANAGE_USER_PWD_EDIT.aspx", parameters));
                }

                if (e.CommandName == "UPDATE1")
                {
                    BizLogicMsg msg = UpdateIsUsabl(ID, 1);
                    ThisPage();
                }
                if (e.CommandName == "UPDATE2")
                {
                    BizLogicMsg msg = UpdateIsUsabl(ID, 0);
                    ThisPage();
                }
            }
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

        public bool KeyNotNull(string id)
        {
            if (!string.IsNullOrEmpty(id) && id != "00000000-0000-0000-0000-000000000000")
            {
                return true;
            }
            return false;
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
