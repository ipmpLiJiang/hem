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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
using System.Net;
using System.Text;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class RECRUIT_STAFF_LIST_Q : Manage_Page
    {
        private string POSTER_ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            System.Collections.Specialized.NameValueCollection parameters1 = WebControlHelper.DecodeParameter(this.Request);
            POSTER_ID = parameters1["POSTER_ID"].ToString();
            if (!IsPostBack)
            {
                try
                {
                    System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                    string STATUS = parameters["STATUS"].ToString();
                    if (STATUS == "3")
                    {
                        this.btn_WCL.Visible = true;
                    }
                    EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                    entity.ID = POSTER_ID;
                    entity = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Get(entity);

                    if (entity != null)
                    {
                        DdlBindData(entity);

                        ViewState["CUR_OBJ"] = entity;
                        BindData();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('招聘广告不存在!');location.href='RECRUIT_POSTER_LIST_PCD.aspx';</script>");
                    }
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

        public CauseObject_V_HEM_B_STAFF_APPLY CauseObject_Where()
        {
            CauseObject_V_HEM_B_STAFF_APPLY cause = new CauseObject_V_HEM_B_STAFF_APPLY();
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);

            if (parameters.Count != 0)
            {
                string STATUS = parameters["STATUS"].ToString();
                string POSTER_ID = parameters["POSTER_ID"].ToString();
                cause.POSTER_ID = POSTER_ID;
                if (STATUS == "4")
                {
                    cause.SetINValue("STATUS", (decimal)APPLY_STATUS.已完成);
                    cause.SetINValue("STATUS", (decimal)APPLY_STATUS.传输成功);
                }
                else if (STATUS != "10")
                {
                    cause.STATUS = decimal.Parse(STATUS);
                }
                string sqlWhere = "";
                EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
                if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
                {
                    sqlWhere = " AND ( V_HEM_B_STAFF_APPLY.MANAGE_USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_STAFF_APPLY.IS_PUBLIC = 1 )";
                }

                string Is_Send = ddlInputIsSend.SelectedValue;

                if (!string.IsNullOrEmpty(Is_Send))
                {

                    if (Is_Send == "-1")
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY.MSSAGE_ID IS NULL";
                    }
                    else if (Is_Send == "100")
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY.IS_SEND = 1 AND V_HEM_B_STAFF_APPLY.CONTENT IS NOT NULL";
                    }
                    else if (Is_Send == "1000")
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY.IS_SEND = 1 AND V_HEM_B_STAFF_APPLY.SEND_ERROR IS NOT NULL";
                    }
                    else
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY.SEND_ERROR IS NULL AND V_HEM_B_STAFF_APPLY.IS_SEND = " + Is_Send;
                    }
                }

                string sql = strQuery("V_HEM_B_STAFF_APPLY.");
                if (!string.IsNullOrEmpty(sql))
                {
                    if (sql != "0")
                    {
                        sqlWhere = sqlWhere + sql;
                    }
                    else
                    {
                        sqlWhere = sqlWhere + " AND 1=2";
                    }
                }
                EntityObject_HEM_B_RECRUIT_POSTER entity = ViewState["CUR_OBJ"] as EntityObject_HEM_B_RECRUIT_POSTER;
                if (entity.IS_NURSE == 1)
                {
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
                }

                if (!string.IsNullOrEmpty(sqlWhere))
                {
                    cause.SetCustomCondition(sqlWhere);
                }


            }
            else
            {
                cause.SetCustomCondition(" AND 1=2");
            }

            return cause;
        }

        private string strQuery(string strTab)
        {
            string sql = "";
            string strHf = hf.Value;
            if (!string.IsNullOrEmpty(strHf))
            {
                object el = JsonConvert.DeserializeObject(strHf);
                JArray jarr = (JArray)el;

                string strFh = "";
                string strVal = "";
                string strFiled = "";
                //[{"S":"NACHN","Y":"=","V":"张曦"},{"S":"NACHN","Y":"=","V":"男"}]
                foreach (JToken jt in jarr)
                {
                    if (jt["S"].ToString() != "0")
                    {
                        if (!string.IsNullOrEmpty(jt["V"].ToString()))
                        {
                            string[] arr = jt["S"].ToString().Split('|');
                            strFh = jt["Y"].ToString();
                            strVal = jt["V"].ToString();
                            strFiled = strTab + arr[0];
                            //=,>,<,>=,<=,LIKE
                            if (arr[1].ToString() == "V")
                            {
                                if (strFh != "=")
                                {
                                    sql = sql + " AND " + strFiled + " LIKE '%" + strVal + "%'";
                                }
                                else
                                {
                                    sql = sql + " AND " + strFiled + strFh + "'" + strVal + "'";
                                }
                            }
                            else if (arr[1].ToString() == "D")
                            {
                                bool bl = DateYz(strVal);
                                if (bl)
                                {
                                    //DateTime dt = DateTime.Parse(strVal);
                                    //to_date('','yyyy-MM-dd')
                                    if (strFh == "LIKE")
                                    {
                                        sql = sql + " AND " + strFiled + " = to_date('" + strVal + "','yyyy-MM-dd')";
                                    }
                                    //else if (strFh == "<" || strFh == "<=")
                                    //{

                                    //}
                                    else
                                    {
                                        sql = sql + " AND " + strFiled + strFh + "to_date('" + strVal + "','yyyy-MM-dd')";
                                    }
                                }
                                else
                                {
                                    return "0";
                                }
                            }
                            else if (arr[1].ToString() == "I")
                            {
                                if (strFh == "LIKE")
                                {
                                    sql = sql + " AND " + strFiled + "=" + strVal;
                                }
                                else
                                {
                                    sql = sql + " AND " + strFiled + strFh + strVal;
                                }
                            }
                        }
                    }
                }
            }
            return sql;
        }

        public bool DateYz(string str)
        {
            return Regex.IsMatch(str, @"^(\d{4}(\/|\-)\d{1,2}(\/|\-)\d{1,2})*$");
        }


        protected void btnQuertJson_Click(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
        }

        protected void btn_query_Click(object sender, EventArgs e)
        {
            ShowQueryResult("1", CauseObject_Where());
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

        public string UrlDetail(object id, object aid)
        {
            if (id != null)
            {
                if (KeyNotNull(id.ToString()))
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("ID", id.ToString());
                    parameters.Add("APPLY_ID", aid.ToString());
                    parameters.Add("POSTER_ID", POSTER_ID.ToString());
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
            entity.STAFF_TYPE_ID = StaffType_Id;
            entity.STATUS = Status;
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
            List<string> ListStaff = new List<string>();
            List<DisplayObject_V_HEM_B_STAFF_APPLY> list = ckListDisplay();

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
                string url = "RECRUIT_STAFF_LIST_Q.aspx";
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

        #region 未处理
        protected void btn_WCL_Click(object sender, EventArgs e)
        {
            if (ck_ISALL.Checked == false)
            {
                string strName = "";
                List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.未处理, ref strName);
                UpdateApplyStatus(entityItem, strName);
            }
            else
            {
                UpdateAll((decimal)APPLY_STATUS.未处理);
            }
        }
        #endregion

        public void UpdateAll(decimal STATUS)
        {
            CauseObject_V_HEM_B_STAFF_APPLY cause = new CauseObject_V_HEM_B_STAFF_APPLY();
            cause = CauseObject_Where();
            BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_APPLY.Proxy.Update(cause, STATUS);
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

        #region 简历通过
        protected void btn_YTG_Click(object sender, EventArgs e)
        {
            if (ck_ISALL.Checked == false)
            {
                string strName = "";
                List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.简历通过, ref strName);
                UpdateApplyStatus(entityItem, strName);
            }
            else
            {
                UpdateAll((decimal)APPLY_STATUS.简历通过);
            }
        }
        #endregion

        #region 安排面试
        protected void btn_YMS_Click(object sender, EventArgs e)
        {
            if (ck_ISALL.Checked == false)
            {
                string strName = "";
                List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.安排面试, ref strName);
                UpdateApplyStatus(entityItem, strName);
            }
            else
            {
                UpdateAll((decimal)APPLY_STATUS.安排面试);
            }
        }
        #endregion

        #region 已拒绝
        protected void btn_YJJ_Click(object sender, EventArgs e)
        {
            if (ck_ISALL.Checked == false)
            {
                string strName = "";
                List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.已拒绝, ref strName);
                UpdateApplyStatus(entityItem, strName);
            }
            else
            {
                UpdateAll((decimal)APPLY_STATUS.已拒绝);
            }
        }
        #endregion

        #region 已完成
        protected void btn_YWC_Click(object sender, EventArgs e)
        {
            if (ck_ISALL.Checked == false)
            {
                string strName = "";
                List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.已完成, ref strName);
                UpdateApplyStatus(entityItem, strName);
            }
            else
            {
                UpdateAll((decimal)APPLY_STATUS.已完成);
            }
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

        //短信提醒
        protected void btn_duanxin_Click(object sender, EventArgs e)
        {
            BizLogicMsg msg = new BizLogicMsg();
            if (ck_ISALL.Checked == false)
            {
                string strName = "";
                List<EntityObject_HEM_B_STAFF_APPLY> entityItem = ListEntity((decimal)APPLY_STATUS.简历通过, ref strName);
                msg = new BizLogicMsg();
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
            else
            {
                CauseObject_V_HEM_B_STAFF_APPLY cause = new CauseObject_V_HEM_B_STAFF_APPLY();
                cause = CauseObject_Where();
                msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.PhoneMsg(cause, txt_Content.Text);
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
                            if (!string.IsNullOrEmpty(display.SEND_ERROR))
                            {
                                ((Label)e.Item.FindControl("lbl_IS_SEND")).Text = "发送失败";
                            }
                            else
                            {
                                ((Label)e.Item.FindControl("lbl_IS_SEND")).Text = "已发送";
                            }
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

        //protected void btn_Npoi_Click(object sender, EventArgs e)
        //{
        //    List<string> listStr = new List<string>();
        //    string staffTypeIds = ckNpoiString();

        //    if (!string.IsNullOrEmpty(staffTypeIds))
        //    {
        //        DataTable dt = new DataTable();
        //        dt = BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Staff_Gather(staffTypeIds);
        //        if (dt.Rows.Count > 0)
        //        {
        //            string xlsStr = DateTime.Now.ToString() + ".xls";
        //            NPOIHelper.GridToExcelByNPOI(dt, BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Header_Gather(), xlsStr);
        //        }
        //    }
        //}

        //protected void btn_Nyn_Npoi_Click(object sender, EventArgs e)
        //{
        //    List<string> listStr = new List<string>();
        //    string staffTypeIds = ckNpoiString();

        //    if (!string.IsNullOrEmpty(staffTypeIds))
        //    {
        //        DataTable dt = new DataTable();
        //        dt = BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Staff_Nyn_Gather(staffTypeIds);
        //        if (dt.Rows.Count > 0)
        //        {
        //            string xlsStr = DateTime.Now.ToString() + ".xls";
        //            NPOIHelper.GridToExcelByNPOI(dt, BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Nyn_Header_Gather(), xlsStr);
        //        }
        //    }
        //}

        //protected void btn_Nyw_Npoi_Click(object sender, EventArgs e)
        //{
        //    List<string> listStr = new List<string>();
        //    string staffTypeIds = ckNpoiString();
        //    if (!string.IsNullOrEmpty(staffTypeIds))
        //    {
        //        DataTable dt = new DataTable();
        //        dt = BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Staff_Nyw_Gather(staffTypeIds);
        //        if (dt.Rows.Count > 0)
        //        {
        //            string xlsStr = DateTime.Now.ToString() + ".xls";
        //            NPOIHelper.GridToExcelByNPOI(dt, BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Nyw_Header_Gather(), xlsStr);
        //        }
        //    }
        //}

        //protected void btn_Nwj_Npoi_Click(object sender, EventArgs e)
        //{
        //    List<string> listStr = new List<string>();
        //    string staffTypeIds = ckNpoiString();
        //    if (!string.IsNullOrEmpty(staffTypeIds))
        //    {
        //        DataTable dt = new DataTable();
        //        dt = BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Staff_Nwj_Gather(staffTypeIds);
        //        if (dt.Rows.Count > 0)
        //        {
        //            string xlsStr = DateTime.Now.ToString() + ".xls";
        //            NPOIHelper.GridToExcelByNPOI(dt, BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Nwj_Header_Gather(), xlsStr);
        //        }
        //    }
        //}

        //protected void btn_Nyj_Npoi_Click(object sender, EventArgs e)
        //{
        //    List<string> listStr = new List<string>();
        //    string staffTypeIds = ckNpoiString();
        //    if (!string.IsNullOrEmpty(staffTypeIds))
        //    {
        //        DataTable dt = new DataTable();
        //        dt = BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Staff_Nyj_Gather(staffTypeIds);
        //        if (dt.Rows.Count > 0)
        //        {
        //            string xlsStr = DateTime.Now.ToString() + ".xls";
        //            NPOIHelper.GridToExcelByNPOI(dt, BizLogicObject_HEM_B_STAFF.Proxy.GetHem_Nyj_Header_Gather(), xlsStr);
        //        }
        //    }
        //}

        public void DdlBindData(EntityObject_HEM_B_RECRUIT_POSTER entity)
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            if (entity.IS_NURSE == 1)
            {
                cause.SetCustomCondition(" AND SYS_DATA_TYPE.CODE != '1004'");
            }
            else if (entity.IS_NURSE == 2)
            {
                cause.SetCustomCondition(" AND SYS_DATA_TYPE.CODE = '1004'");
            }
            else
            {
                cause.SetCustomCondition(" AND SYS_DATA_TYPE.CODE = '1005'");
            }
            cause.PARENT_ID = "HEM_1012";
            ddlInputTYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputTYPE_ID.DataTextField = "NAME";
            ddlInputTYPE_ID.DataValueField = "CODE";
            ddlInputTYPE_ID.DataBind();
            if (entity.IS_NURSE == 1)
            {
                ddlInputTYPE_ID.Items.Insert(0, new ListItem("--全部--", "All"));
                ddlInputTYPE_ID.Items.Insert(1, new ListItem("研究生", "YJS"));
            }
            if (entity.IS_NURSE == 3)
            {
                ddlInputTYPE_ID.Items.Insert(0, new ListItem("派遣制", "PQZ"));
            }

            cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1013";
            ddlInputPageSize.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPageSize.DataTextField = "NAME";
            ddlInputPageSize.DataValueField = "CODE";
            ddlInputPageSize.DataBind();

            cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1015";
            lselect.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            lselect.DataTextField = "NAME";
            lselect.DataValueField = "CODE";
            lselect.DataBind();
            lselect.Items.Insert(0, new ListItem("选择", "0"));
        }

        public CauseObject_V_HEM_B_STAFF_APPLY_NPOI CauseObject_Where_Npoi()
        {
            CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause = new CauseObject_V_HEM_B_STAFF_APPLY_NPOI();
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);

            if (parameters.Count != 0)
            {
                string STATUS = parameters["STATUS"].ToString();
                string POSTER_ID = parameters["POSTER_ID"].ToString();
                cause.POSTER_ID = POSTER_ID;
                if (STATUS == "4")
                {
                    cause.SetINValue("STATUS", (decimal)APPLY_STATUS.已完成);
                    cause.SetINValue("STATUS", (decimal)APPLY_STATUS.传输成功);
                }
                else if (STATUS != "10")
                {
                    cause.STATUS = decimal.Parse(STATUS);
                }

                string sqlWhere = "";
                EntityObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as EntityObject_V_USER_LOGIN_INFO;
                if (UserInfo.ACCOUNT.ToUpper() != "ADMIN")
                {
                    sqlWhere = "  AND ( V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID = '" + UserInfo.USER_ID + "' OR V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC = 1 )";
                }

                string sql = strQuery("V_HEM_B_STAFF_APPLY_NPOI.");
                if (!string.IsNullOrEmpty(sql))
                {
                    if (sql != "0")
                    {
                        sqlWhere = sqlWhere + sql;
                    }
                    else
                    {
                        sqlWhere = sqlWhere + " AND 1=2";
                    }
                }

                string Is_Send = ddlInputIsSend.SelectedValue;

                if (!string.IsNullOrEmpty(Is_Send))
                {

                    if (Is_Send == "-1")
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY_NPOI.MSSAGE_ID IS NULL";
                    }
                    else if (Is_Send == "100")
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY_NPOI.IS_SEND = 1 AND V_HEM_B_STAFF_APPLY_NPOI.CONTENT IS NOT NULL";
                    }
                    else if (Is_Send == "1000")
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY_NPOI.IS_SEND = 1 AND V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR IS NOT NULL";
                    }
                    else
                    {
                        sqlWhere = sqlWhere + " AND V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR IS NULL AND V_HEM_B_STAFF_APPLY_NPOI.IS_SEND = " + Is_Send;
                    }
                }

                EntityObject_HEM_B_RECRUIT_POSTER entity = ViewState["CUR_OBJ"] as EntityObject_HEM_B_RECRUIT_POSTER;
                if (entity.IS_NURSE == 1)
                {
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
                }

                if (!string.IsNullOrEmpty(sqlWhere))
                {
                    cause.SetCustomCondition(sqlWhere);
                }


            }
            else
            {
                cause.SetCustomCondition(" AND 1=2");
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

        protected void btn_All_Npoi_Click(object sender, EventArgs e)
        {
            string val = ddlInputTYPE_ID.SelectedValue;
            CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause = CauseObject_Where_Npoi();
            DataSet ds = new DataSet();
            CauseObject_V_HEM_STAFF_NPOI_ALL causeHeade = new CauseObject_V_HEM_STAFF_NPOI_ALL();

            bool IsOk = true;
            if (ck_ISALL.Checked == false)
            {
                cause = ckInNpoi(cause, ref IsOk);
            }

            if (IsOk)
            {
                string xlsStr = DateTime.Now.ToString() + ".xls";

                if (val == "All")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, false);
                    if (ds.Tables.Count == 4)
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
                else if (val == "PQZ")
                {
                    ds = BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI.Proxy.Query_Npoi(cause, val, false);
                    if (ds.Tables.Count == 1)
                    {
                        causeHeade.NUM = 6;
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemDisplay = BizLogicObject_V_HEM_STAFF_NPOI_ALL.Proxy.Query(causeHeade);
                        if (itemDisplay.Length > 0)
                        {
                            NPOIHelper.GridToExcelByNPOI(ds.Tables[0], itemDisplay, xlsStr);
                        }
                    }
                }
            }
        }
        protected void btn_All_fj_Click(object sender, EventArgs e)
        {
            string dName = DateTime.Now.ToString("yyMMddHHmmssfff");
            string pSaveFilePath = Server.MapPath("~/temp/" + dName); //指定存储的路径
            DisplayObject_V_HEM_B_STAFF_APPLY[] disQuery = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(CauseObject_Where());
            foreach (DisplayObject_V_HEM_B_STAFF_APPLY dv in disQuery)
            {
                string pLocalFilePath = Server.MapPath("~/" + dv.FILE_PATH);//要复制的文件路径
                if (Directory.Exists(pSaveFilePath) == false)//如果不存在就创建文件夹
                {
                    Directory.CreateDirectory(pSaveFilePath);
                   
                }
                if (File.Exists(pLocalFilePath))//必须判断要复制的文件是否存在
                {
                    File.Copy(pLocalFilePath, pSaveFilePath + "\\" + Path.GetFileName(pLocalFilePath), true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                }
            }
            ZipDir(pSaveFilePath + "\\", Server.MapPath("~/temp/") + "\\" + dName + ".zip", 5, "");
            ResponseFile(Server.MapPath("~/temp/") + "\\" + dName + ".zip");
            
        }
        protected void ResponseFile(string filename)
        {

            FileInfo file = new FileInfo(filename);//创建一个文件对象  
            Response.Clear();//清除所有缓存区的内容  
            Response.Charset = "GB2312";//定义输出字符集  
            Response.ContentEncoding = Encoding.Default;//输出内容的编码为默认编码  
            Response.AddHeader("Content-Disposition", "attachment;filename=" + file.Name);
            //添加头信息。为“文件下载/另存为”指定默认文件名称  
            Response.AddHeader("Content-Length", file.Length.ToString());
            //添加头文件，指定文件的大小，让浏览器显示文件下载的速度   
            Response.WriteFile(file.FullName);// 把文件流发送到客户端  
            Response.End();
        }  
         /// <summary>
  /// 压缩多个文件目录
  /// </summary>
  /// <param name="dirname">需要压缩的目录</param>
  /// <param name="zipFile">压缩后的文件名</param>
  /// <param name="level">压缩等级</param>
  /// <param name="password">密码</param>
  public static void ZipDir(string dirname, string zipFile, int level, string password)
  {
   ZipOutputStream zos = new ZipOutputStream(File.Create(zipFile));
   //zos.Password = md5(password);
   zos.SetLevel(level);
   addZipEntry(dirname, zos, dirname);
   zos.Finish();
   zos.Close();
  }
        /// <summary>
  /// 往压缩文件里面添加Entry
  /// </summary>
  /// <param name="PathStr">文件路径</param>
  /// <param name="zos">ZipOutputStream</param>
  /// <param name="BaseDirName">基础目录</param>
  private static void addZipEntry(string PathStr, ZipOutputStream zos, string BaseDirName)
  {
   DirectoryInfo dir = new DirectoryInfo(PathStr);
   foreach (FileSystemInfo item in dir.GetFileSystemInfos())
   {
    if ((item.Attributes & FileAttributes.Directory) == FileAttributes.Directory)//如果是文件夹继续递归
    {
     addZipEntry(item.FullName, zos, BaseDirName);
    }
    else
    {
     FileInfo f_item = (FileInfo)item;
     using (FileStream fs = f_item.OpenRead())
     {
      byte[] buffer = new byte[(int)fs.Length];
      fs.Position = 0;
      fs.Read(buffer, 0, buffer.Length);
      fs.Close();
      ZipEntry z_entry = new ZipEntry(item.FullName.Replace(BaseDirName, ""));
      zos.PutNextEntry(z_entry);
      zos.Write(buffer, 0, buffer.Length);
     }
    }
   }
  }
    }
}
