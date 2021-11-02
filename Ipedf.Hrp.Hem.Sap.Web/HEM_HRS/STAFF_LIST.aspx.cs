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
    public partial class STAFF_LIST : User_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                if (ViewState["CUR_STAFF"] == null)
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
                else
                {
                    DdlBindData();
                    BindData();
                }
            }
        }

        protected void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();

            //护理类型
            cause.PARENT_ID = "HEM_1012";
            ddlInputTYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputTYPE_ID.DataTextField = "NAME";
            ddlInputTYPE_ID.DataValueField = "CODE";
            ddlInputTYPE_ID.DataBind();

            cause = new CauseObject_SYS_DATA_TYPE();
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

        public CauseObject_HEM_B_STAFF_TYPE CauseObject_Where()
        {
            CauseObject_HEM_B_STAFF_TYPE cause = new CauseObject_HEM_B_STAFF_TYPE();
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
            //cause.MANAGE_USER_IS_USABL
            cause.USER_ID = UserInfo.USER_ID;
            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_HEM_B_STAFF_TYPE parameter)
        {
            CauseObject_HEM_B_STAFF_TYPE cause = parameter;
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
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "IS_NURSE" };
                DisplayObject_HEM_B_STAFF_TYPE[] disSE = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Query(cause, paging, orderBy);
                foreach (DisplayObject_HEM_B_STAFF_TYPE st in disSE)
                {
                    if (st.IS_NURSE == 1)
                    {
                        lbl_StaffNurse.Visible = false;
                    }
                    else if (st.IS_NURSE == 2)
                    {
                        lbl_Staff.Visible = false;
                    }
                    else if (st.IS_NURSE == 3)
                    {
                        lbl_Send.Visible = false;
                    }
                }
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
            if (e.CommandName == "EDIT")
            {
                string IS_NURSE = e.CommandArgument.ToString();
                //System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                //parameters.Add("ID", ID);
                if (IS_NURSE == "1")
                {
                    Response.Write("<script>location.href='STAFF_NURSE_BASIC.aspx';</script>");
                    //Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_HRS/STAFF_NURSE_BASIC.aspx", parameters));
                }
                else if (IS_NURSE == "2")
                {
                    Response.Write("<script>location.href='STAFF_BASIC.aspx';</script>");
                    //Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_HRS/STAFF_BASIC.aspx", parameters));
                }
                else
                {
                    Response.Write("<script>location.href='STAFF_SEND_BASIC.aspx';</script>");
                    //Response.Redirect(WebControlHelper.EncodeUrl("~/HEM_HRS/STAFF_BASIC.aspx", parameters));
                }
            }
        }

        protected void rpt_List_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DisplayObject_HEM_B_STAFF_TYPE display = (DisplayObject_HEM_B_STAFF_TYPE)e.Item.DataItem;

                if (!string.IsNullOrEmpty(display.TYPE_ID))
                {
                    if (display.IS_NURSE == 3)
                    {
                        ((Label)e.Item.FindControl("lbl_Type_Id")).Text = "派遣制";
                    }
                    else
                    {
                        display.TYPE_ID = ddlInputTYPE_ID.Items.FindByValue(display.TYPE_ID).Text;

                        ((Label)e.Item.FindControl("lbl_Type_Id")).Text = display.TYPE_ID;
                    }
                }

                if (!string.IsNullOrEmpty(display.ID))
                {
                    ((Label)e.Item.FindControl("lb_Look")).Text = "<a href=\"" + UrlDetail(display.ID) + "\" target=\"_blank\">浏览</a>";
                }
            }
        }

        public string UrlDetail(string ID)
        {
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
            parameters.Add("ID", ID);
            string url = WebControlHelper.EncodeUrl("RESUME_PREVIEW.aspx", parameters);
            return url;
        }

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void lbl_Staff_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='STAFF_BASIC.aspx';</script>");
        }

        protected void lbl_StaffNurse_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='STAFF_NURSE_BASIC.aspx';</script>");
        }
        protected void lbl_Send_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='STAFF_SEND_BASIC.aspx';</script>");
        }
        protected string String_Staff(string staff)
        {
            string str = "";
            switch (staff)
            { 
                case "1":
                    str = "护理简历";
                    break;
                case "2":
                    str = "非护理简历";
                    break;
                case "3":
                    str = "派遣制简历";
                    break;
            }
            return str;
        }
    }
}
