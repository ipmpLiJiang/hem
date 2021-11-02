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
    public partial class RECRUIT_POSTER_LIST_PCD : Manage_Page
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

        protected void lkBen_Over_Click(object sender, EventArgs e)
        {
            LinkButton BtnOver = (LinkButton)sender;//强转
            string id = BtnOver.CommandArgument.ToString();
            if (KeyNotNull(id))
            {
                EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                entity.ID = id;
                entity.STATUS = (decimal)POSTER_STATUS.已过期;
                entity.SetUpdate("STATUS");

                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Update(entity);
                if (msg.Succeed)
                {
                    ThisPage();
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
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

        protected void BindData()
        {
            int[] arrPage = new int[3] { 0, 0, 0 };

            ViewState["pageNum"] = arrPage;
            ShowQueryResult("1", CauseObject_Where());
        }

        public CauseObject_V_HEM_B_RECRUIT_POSTER CauseObject_Where()
        {
            CauseObject_V_HEM_B_RECRUIT_POSTER cause = new CauseObject_V_HEM_B_RECRUIT_POSTER();
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
            if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
            {
                cause.SetCustomCondition(" AND V_HEM_B_RECRUIT_POSTER.END_DATE > (to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd')-1) AND ( V_HEM_B_RECRUIT_POSTER.USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_RECRUIT_POSTER.IS_PUBLIC = 1 )");
            }
            else
            {
                cause.SetCustomCondition(" AND V_HEM_B_RECRUIT_POSTER.END_DATE > (to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd')-1)");
            }
            cause.STATUS = (decimal)POSTER_STATUS.已发布;

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

        protected void btn_gq_Click(object sender, EventArgs e)
        {
            List<EntityObject_HEM_B_RECRUIT_POSTER> entityItem = ListEntity((decimal)POSTER_STATUS.已过期);
            if (entityItem.Count > 0)
            {
                EntityObject_HEM_B_RECRUIT_POSTER[] Item = new EntityObject_HEM_B_RECRUIT_POSTER[entityItem.Count];
                entityItem.CopyTo(Item);
                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Update(Item);
                if (msg.Succeed)
                {
                    ThisPage();
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
            }
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

        protected List<EntityObject_HEM_B_RECRUIT_POSTER> ListEntity(decimal Status)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            List<EntityObject_HEM_B_RECRUIT_POSTER> entityItem = new List<EntityObject_HEM_B_RECRUIT_POSTER>();
            foreach (RepeaterItem Item in this.rpt_List.Items)
            {
                CheckBox select = (CheckBox)Item.FindControl("cbSelect");

                if (select.Checked)
                {
                    LinkButton lbt = (LinkButton)Item.FindControl("lkBtnEdit");
                    EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                    entity.ID = lbt.CommandArgument.ToString();
                    if (KeyNotNull(entity.ID))
                    {
                        entity.SetUpdate("STATUS");
                        entity.STATUS = Status;
                        entityItem.Add(entity);
                    }
                }
            }

            return entityItem;
        }

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }
    }
}
