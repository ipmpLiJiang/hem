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
    public partial class RECRUIT_STAFF_LIST_FINISH : Manage_Page
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

            cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1012";
            ddlInputTYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputTYPE_ID.DataTextField = "NAME";
            ddlInputTYPE_ID.DataValueField = "CODE";
            ddlInputTYPE_ID.DataBind();
            ddlInputTYPE_ID.Items.Insert(0, new ListItem("--全部--", "All"));
            ddlInputTYPE_ID.Items.Insert(1, new ListItem("研究生", "YJS"));
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
            cause.SetINValue("STATUS", (decimal)APPLY_STATUS.已完成);
            cause.SetINValue("STATUS", (decimal)APPLY_STATUS.传输成功);
            cause.SetINValue("POSTER_STATUS", (decimal)POSTER_STATUS.已发布);
            cause.SetINValue("POSTER_STATUS", (decimal)POSTER_STATUS.已过期);

            string strTypeID = ddlInputTYPE_ID.SelectedValue;
            if (!string.IsNullOrEmpty(strTypeID) && strTypeID != "All")
            {
                if (strTypeID == "YJS")
                {
                    cause.SF_SS_EDUCATION_SLART = "11";
                }
                else
                {
                    cause.TYPE_ID = strTypeID;
                }
            }

            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;

            string NACHN = txt_NACHN.Text;
            string MOBILE = txt_MOBILE.Text;
            string RECRUIT_POSITION = txt_RECRUIT_POSITION.Text;

            string sqlWhere = "";
            if (!string.IsNullOrEmpty(MOBILE))
            {
                cause.USRID_TEL = MOBILE;
            }

            if (!string.IsNullOrEmpty(NACHN))
            {
                sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY.NACHN LIKE '%" + NACHN + "%'";
            }

            if (!string.IsNullOrEmpty(RECRUIT_POSITION))
            {
                sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY.RECRUIT_POSITION LIKE '%" + RECRUIT_POSITION + "%'";
            }

            if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
            {
                sqlWhere = " AND ( V_HEM_B_STAFF_APPLY.MANAGE_USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_STAFF_APPLY.IS_PUBLIC = 1 )";
            }

            if (!string.IsNullOrEmpty(sqlWhere))
            {
                cause.SetCustomCondition(sqlWhere);
            }

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
                OrderByParameter orderBy = new OrderByParameter() { Asc = false, OrderBy = "POSTER_ID" };
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

        protected void btnSAP_Click(object sender, EventArgs e)
        {
            DisplayObject_V_HEM_B_STAFF_APPLY display = LinkDisplay();
            if (display != null)
            {
                if (display.STATUS == (decimal)APPLY_STATUS.传输成功 || display.STATUS == (decimal)APPLY_STATUS.已完成)
                {
                    Update(display.ID, display.STAFF_TYPE_ID, (decimal)APPLY_STATUS.传输成功);
                }
            }
        }

        protected void btnNotAllow_Click(object sender, EventArgs e)
        {
            DisplayObject_V_HEM_B_STAFF_APPLY display = LinkDisplay();
            if (display != null)
            {
                if (display.STATUS != (decimal)APPLY_STATUS.传输成功)
                {
                    Update(display.ID, display.STAFF_TYPE_ID, (decimal)APPLY_STATUS.已拒绝);
                }
            }
        }

        private void Update(string Id, string StaffType_Id, decimal Status)
        {
            List<EntityObject_HEM_B_STAFF_APPLY> list = new List<EntityObject_HEM_B_STAFF_APPLY>();
            EntityObject_HEM_B_STAFF_APPLY entity = new EntityObject_HEM_B_STAFF_APPLY();
            entity.ID = Id;
            entity.STATUS = Status;
            entity.STAFF_TYPE_ID = StaffType_Id;
            entity.SetUpdate("STATUS");
            list.Add(entity);
            BizLogicMsg msg = new BizLogicMsg();
            if (Status == (decimal)APPLY_STATUS.传输成功)
            {
                msg = TransferSAP(list);
                if (msg.Succeed)
                {
                    msg = BizLogicObject_HEM_B_STAFF_APPLY.Proxy.UpdateState(entity);
                    ClickMessage(msg, false);
                }
                else
                {
                    ClickMessage(msg, false);
                }
            }
            else
            {
                msg = BizLogicObject_HEM_B_STAFF_APPLY.Proxy.UpdateState(entity);
                ClickMessage(msg, false);
            }
        }

        private BizLogicMsg TransferSAP(List<EntityObject_HEM_B_STAFF_APPLY> list)
        {
            CauseObject_HEM_B_STAFF causeStaff = new CauseObject_HEM_B_STAFF();
            CauseObject_HEM_B_STAFF_TYPE causeStaffType = new CauseObject_HEM_B_STAFF_TYPE();

            foreach (EntityObject_HEM_B_STAFF_APPLY entity in list)
            {
                causeStaffType.SetINValue("ID", entity.STAFF_TYPE_ID);
            }
            DisplayObject_HEM_B_STAFF_TYPE[] displayStaffType = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Query(causeStaffType);

            foreach (DisplayObject_HEM_B_STAFF_TYPE entity in displayStaffType)
            {
                causeStaff.SetINValue("ID", entity.STAFF_ID);
            }

            return BizLogicObject_HEM_SAP.Proxy.ChannelSAP(causeStaff);
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
            List<string> ListStaff = new List<string>();
            List<DisplayObject_V_HEM_B_STAFF_APPLY> list = ckListDisplay();

            foreach (DisplayObject_V_HEM_B_STAFF_APPLY vsa in list)
            {
                //等于传进来的STATUS
                if (vsa.STATUS == 4 || vsa.STATUS == 5)
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
            List<DisplayObject_V_HEM_B_STAFF_APPLY> list = new List<DisplayObject_V_HEM_B_STAFF_APPLY>();
            cause = CauseObject_Where();
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

        private string ckNpoiString()
        {
            List<DisplayObject_V_HEM_B_STAFF_APPLY> list = ckListDisplay();
            List<string> listStr = new List<string>();
            string staffTypeIds = "";
            foreach (DisplayObject_V_HEM_B_STAFF_APPLY vha in list)
            {
                if (!listStr.Contains(vha.STAFF_TYPE_ID))
                {
                    listStr.Add(vha.STAFF_TYPE_ID);
                    if (string.IsNullOrEmpty(staffTypeIds))
                    {
                        staffTypeIds = vha.STAFF_TYPE_ID.Trim();
                    }
                    else
                    {
                        staffTypeIds = staffTypeIds + "," + vha.STAFF_TYPE_ID.Trim();
                    }
                }
            }

            return staffTypeIds;
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
                string url = "RECRUIT_STAFF_LIST_FINISH.aspx";
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

        #region 传输SAP
        protected void btn_SAP_Click(object sender, EventArgs e)
        {
            string strName = "";
            List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.传输成功, ref strName);
            UpdateApplyStatus(entityItem, strName);

        }
        #endregion

        private void UpdateApplyStatus(List<EntityObject_HEM_B_STAFF_APPLY> entityItem, string strName)
        {
            BizLogicMsg msg = new BizLogicMsg();
            if (entityItem.Count > 0)
            {
                msg = TransferSAP(entityItem);
                if (msg.Succeed)
                {
                    EntityObject_HEM_B_STAFF_APPLY[] Item = new EntityObject_HEM_B_STAFF_APPLY[entityItem.Count];
                    entityItem.CopyTo(Item);
                    msg = BizLogicObject_HEM_B_STAFF_APPLY.Proxy.Update(Item);
                    ClickMessage(msg, false);
                }
                else
                {
                    ClickMessage(msg, false);
                }
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

        protected void rpt_List_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DisplayObject_V_HEM_B_STAFF_APPLY display = (DisplayObject_V_HEM_B_STAFF_APPLY)e.Item.DataItem;
                if (!string.IsNullOrEmpty(display.MSSAGE_ID))
                {
                    if (display.IS_SEND == 0)
                    {
                        ((Label)e.Item.FindControl("lbl_IS_SEND")).Text = "待发送";
                    }
                    else if (display.IS_SEND == 1)
                    {
                        if (!string.IsNullOrEmpty(display.CONTENT))
                        {
                            ((Label)e.Item.FindControl("lbl_IS_SEND")).Text = "已回复";
                        }
                        else
                        {
                            ((Label)e.Item.FindControl("lbl_IS_SEND")).Text = "已发送";
                        }
                    }
                }
                else
                {
                    ((Label)e.Item.FindControl("lbl_IS_SEND")).Text = "未发送";
                }

            }
        }

        protected void ddlInputPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void btn_query_Click(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        //短信提醒
        protected void btn_duanxin_Click(object sender, EventArgs e)
        {
            string strName = "";
            List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.已完成, ref strName);
            BizLogicMsg msg = new BizLogicMsg();
            if (entityItem.Count > 0)
            {
                EntityObject_HEM_B_STAFF_APPLY[] Item = new EntityObject_HEM_B_STAFF_APPLY[entityItem.Count];
                entityItem.CopyTo(Item);
                msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.PhoneMsg(Item, txt_Content.Text);
                if (msg.Succeed)
                {
                    ClickMessage(msg, false);
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
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

        public CauseObject_V_HEM_B_STAFF_APPLY_NPOI CauseObject_Where_Npoi()
        {
            CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause = new CauseObject_V_HEM_B_STAFF_APPLY_NPOI();
            cause.SetINValue("STATUS", (decimal)APPLY_STATUS.已完成);
            cause.SetINValue("STATUS", (decimal)APPLY_STATUS.传输成功);
            cause.SetINValue("POSTER_STATUS", (decimal)POSTER_STATUS.已发布);
            cause.SetINValue("POSTER_STATUS", (decimal)POSTER_STATUS.已过期);

            string strTypeID = ddlInputTYPE_ID.SelectedValue;
            if (!string.IsNullOrEmpty(strTypeID) && strTypeID != "All")
            {
                if (strTypeID == "YJS")
                {
                    cause.SF_SS_EDUCATION_SLART = "11";
                }
                else
                {
                    cause.TYPE_ID = strTypeID;
                }
            }

            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;

            string NACHN = txt_NACHN.Text;
            string MOBILE = txt_MOBILE.Text;
            string RECRUIT_POSITION = txt_RECRUIT_POSITION.Text;

            string sqlWhere = "";
            if (!string.IsNullOrEmpty(MOBILE))
            {
                cause.USRID_TEL = MOBILE;
            }

            if (!string.IsNullOrEmpty(NACHN))
            {
                sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY_NPOI.NACHN LIKE '%" + NACHN + "%'";
            }

            if (!string.IsNullOrEmpty(RECRUIT_POSITION))
            {
                sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY_NPOI.RECRUIT_POSITION LIKE '%" + RECRUIT_POSITION + "%'";
            }

            if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
            {
                sqlWhere = " AND ( V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC = 1 )";
            }

            if (!string.IsNullOrEmpty(sqlWhere))
            {
                cause.SetCustomCondition(sqlWhere);
            }

            return cause;
        }

        private CauseObject_V_HEM_B_STAFF_APPLY_NPOI ckInNpoi(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause, ref bool IsOK)
        {
            List<DisplayObject_V_HEM_B_STAFF_APPLY> list = ckListDisplay();

            foreach (DisplayObject_V_HEM_B_STAFF_APPLY vha in list)
            {
                cause.SetINValue("STAFF_TYPE_ID", vha.STAFF_TYPE_ID);
            }

            if (list.Count == 0)
            {
                IsOK = false;
            }

            return cause;
        }

        protected void btn_Npoi_Click(object sender, EventArgs e)
        {
            string val = ddlInputTYPE_ID.SelectedValue;
            CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause = CauseObject_Where_Npoi();
            DataSet ds = new DataSet();
            CauseObject_V_HEM_STAFF_NPOI_ALL causeHeade = new CauseObject_V_HEM_STAFF_NPOI_ALL();

            bool IsOk = true;
            //if (ck_ISALL.Checked == false)
            //{
            cause = ckInNpoi(cause, ref IsOk);
            //}

            if (IsOk)
            {
                string xlsStr = DateTime.Now.ToString() + ".xls";

                if (val == "All")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, true);
                    if (ds.Tables.Count == 5)
                    {
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemDisplay = BizLogicObject_V_HEM_STAFF_NPOI_ALL.Proxy.Query(causeHeade);
                        if (itemDisplay.Length > 0)
                        {
                            NPOIHelper.GridToMunyExcelByNPOI(ds, itemDisplay, xlsStr);
                        }
                    }
                }
                else if (val == "YJS")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, false);
                    if (ds.Tables.Count == 1)
                    {
                        causeHeade.NUM = 1;
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemDisplay = BizLogicObject_V_HEM_STAFF_NPOI_ALL.Proxy.Query(causeHeade);
                        if (itemDisplay.Length > 0)
                        {
                            NPOIHelper.GridToExcelByNPOI(ds.Tables[0], itemDisplay, xlsStr);
                        }
                    }
                }
                else if (val == "1001")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, false);
                    if (ds.Tables.Count == 1)
                    {
                        causeHeade.NUM = 3;
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemDisplay = BizLogicObject_V_HEM_STAFF_NPOI_ALL.Proxy.Query(causeHeade);
                        if (itemDisplay.Length > 0)
                        {
                            NPOIHelper.GridToExcelByNPOI(ds.Tables[0], itemDisplay, xlsStr);
                        }
                    }
                }
                else if (val == "1002")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, false);
                    if (ds.Tables.Count == 1)
                    {
                        causeHeade.NUM = 4;
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemDisplay = BizLogicObject_V_HEM_STAFF_NPOI_ALL.Proxy.Query(causeHeade);
                        if (itemDisplay.Length > 0)
                        {
                            NPOIHelper.GridToExcelByNPOI(ds.Tables[0], itemDisplay, xlsStr);
                        }
                    }
                }
                else if (val == "1003")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, false);
                    if (ds.Tables.Count == 1)
                    {
                        causeHeade.NUM = 2;
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemDisplay = BizLogicObject_V_HEM_STAFF_NPOI_ALL.Proxy.Query(causeHeade);
                        if (itemDisplay.Length > 0)
                        {
                            NPOIHelper.GridToExcelByNPOI(ds.Tables[0], itemDisplay, xlsStr);
                        }
                    }
                }
                else if (val == "1004")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, true);
                    if (ds.Tables.Count == 1)
                    {
                        causeHeade.NUM = 5;
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemDisplay = BizLogicObject_V_HEM_STAFF_NPOI_ALL.Proxy.Query(causeHeade);
                        if (itemDisplay.Length > 0)
                        {
                            NPOIHelper.GridToExcelByNPOI(ds.Tables[0], itemDisplay, xlsStr);
                        }
                    }
                }
            }
        }
    }
}
