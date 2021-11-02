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
    public partial class RECRUIT_POSTER_LIST : Manage_Page
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

        public CauseObject_HEM_B_RECRUIT_POSTER CauseObject_Where()
        {
            CauseObject_HEM_B_RECRUIT_POSTER cause = new CauseObject_HEM_B_RECRUIT_POSTER();
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
            if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
            {
                cause.SetCustomCondition(" AND ( HEM_B_RECRUIT_POSTER.USER_ID = '" + UserInfo.USER_ID + "' OR HEM_B_RECRUIT_POSTER.IS_PUBLIC = 1 )");
            }

            cause.STATUS = (decimal)POSTER_STATUS.未发布;
            return cause;
        }

        protected void ShowQueryResult(string page, CauseObject_HEM_B_RECRUIT_POSTER parameter)
        {
            CauseObject_HEM_B_RECRUIT_POSTER cause = parameter;
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
                DisplayObject_HEM_B_RECRUIT_POSTER[] disQuery = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Query(cause, paging, orderBy);
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

        protected void lkBtnDel_Click(object sender, EventArgs e)
        {
            LinkButton BtnDel = (LinkButton)sender;//强转
            string id = BtnDel.CommandArgument.ToString();
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            if (KeyNotNull(id))
            {
                EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                entity.ID = id;

                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Delete(entity);
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
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
                else
                {
                    Response.Redirect("~/HEM_HPP/RECRUIT_POSTER_LIST.aspx");
                }
            }
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            List<EntityObject_HEM_B_RECRUIT_POSTER> entityItem = ListEntity("delete");
            if (entityItem.Count > 0)
            {
                EntityObject_HEM_B_RECRUIT_POSTER[] Item = new EntityObject_HEM_B_RECRUIT_POSTER[entityItem.Count];
                entityItem.CopyTo(Item);
                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Delete(Item);
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

        protected void btn_FB_Click(object sender, EventArgs e)
        {
            List<EntityObject_HEM_B_RECRUIT_POSTER> entityItem = ListEntity("FB");
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

        protected List<EntityObject_HEM_B_RECRUIT_POSTER> ListEntity(string action)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            List<EntityObject_HEM_B_RECRUIT_POSTER> entityItem = new List<EntityObject_HEM_B_RECRUIT_POSTER>();
            foreach (RepeaterItem Item in this.rpt_List.Items)
            {
                CheckBox select = (CheckBox)Item.FindControl("cbSelect");

                if (select.Checked)
                {
                    LinkButton lbt = (LinkButton)Item.FindControl("lkBtnCopy");
                    EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                    entity.ID = lbt.CommandArgument.ToString();
                    if (KeyNotNull(entity.ID))
                    {
                        if (action == "FB")
                        {
                            entity.STATUS = (decimal)POSTER_STATUS.已发布;
                            entity.SetUpdate("STATUS");
                        }
                        entityItem.Add(entity);
                    }

                }
            }
            return entityItem;
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

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }
        protected string String_Staff(string staff)
        {
            string str = "";
            switch (staff)
            {
                case "1":
                    str = "护理";
                    break;
                case "2":
                    str = "非护理";
                    break;
                case "3":
                    str = "派遣制";
                    break;
            }
            return str;
        }
    }
}
