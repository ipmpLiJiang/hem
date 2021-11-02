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

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class RECRUIT_STAFF_APPLY : User_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            try
            {
                System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);

                if (parameters.Count != 0)
                {
                    if (parameters["ID"] != null)
                    {
                        string id = parameters["ID"].ToString();
                        CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause = new CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF();
                        cause.ID = id;
                        DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] dispaly = BizLogicObject_V_HEM_B_RECRUIT_POSTER_STAFF.Proxy.Query(cause);
                        if (dispaly.Length > 0)
                        {
                            lbl_TITLE.Text = dispaly[0].TITLE;
                            lbl_DATA_SOURCE.Text = "资料来源：" + dispaly[0].DATA_SOURCE;
                            lbl_PUBLISHER.Text = "发布者：" + dispaly[0].PUBLISHER;
                            lbl_PUBLISH_DATE.Text = "日期：" + dispaly[0].PUBLISH_DATE.ToString("yyyy-MM-dd");

                            lbl_CONTENT.Text = dispaly[0].CONTENT;

                            EntityObject_HEM_B_RECRUIT_POSTER obj = new EntityObject_HEM_B_RECRUIT_POSTER();
                            obj.ID = dispaly[0].ID;
                            obj.IS_NURSE = dispaly[0].IS_NURSE;
                            ViewState["CUR_OBJ"] = obj;
                        }
                        else { BackUrl(); }
                    }
                    else
                    {
                        BackUrl();
                    }
                }
                else
                {
                    BackUrl();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btn_Apply_Click(object sender, EventArgs e)
        {
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;

            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
            EntityObject_HEM_B_RECRUIT_POSTER curObj = ViewState["CUR_OBJ"] as EntityObject_HEM_B_RECRUIT_POSTER;
            string id = curObj.ID;
            EntityObject_HEM_B_STAFF_APPLY entity = new EntityObject_HEM_B_STAFF_APPLY();
            entity.POSTER_ID = id;
            entity.STATUS = (decimal)APPLY_STATUS.未处理;
            entity.CREATE_DATE = DateTime.Now;
            BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_APPLY.Proxy.Recruit_Apply(entity, UserInfo, curObj.IS_NURSE);
            string strMessage = "";
            if (!msg.Succeed)
            {
                if (msg.Message == "NoStaff3" || msg.Message == "NoStaff" || msg.Message == "NoTemplate")
                {
                    if (curObj.IS_NURSE == 2)
                    {
                        Response.Write("<script>if(confirm('不存在简历信息,是否填写简历？')){location.href='../HEM_HRS/STAFF_BASIC.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                    else if (curObj.IS_NURSE == 1)
                    {
                        Response.Write("<script>if(confirm('不存在护理简历信息,是否填写简历？')){location.href='../HEM_HRS/STAFF_NURSE_BASIC.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                    else
                    {
                        Response.Write("<script>if(confirm('不存在派遣制简历信息,是否填写简历？')){location.href='../HEM_HRS/STAFF_SEND_BASIC.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                    //}
                    //else if (msg.Message == "NoTemplate")
                    //{
                    //    if (curObj.IS_NURSE == 2)
                    //    {
                    //        Response.Write("<script>if(confirm('不存在简历信息,是否填写简历？')){location.href='../HEM_HRS/STAFF_BASIC.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    //    }
                    //    else
                    //    {
                    //        Response.Write("<script>if(confirm('不存在护理简历信息,是否填写简历？')){location.href='../HEM_HRS/STAFF_NURSE_BASIC.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    //    }
                }
                else if (msg.Message == "NoFile")
                {
                    if (curObj.IS_NURSE == 2)
                    {
                        Response.Write("<script>if(confirm('不存在简历附件,是否上传？')){location.href='../HEM_HRS/STAFF_BASIC.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                    else
                    {
                        Response.Write("<script>if(confirm('不存在简历附件,是否上传？')){location.href='../HEM_HRS/STAFF_NURSE_BASIC.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                }
                else if (msg.Message == "NoEducation" || msg.Message == "NoEducation1")
                {
                    if (msg.Message == "NoEducation1")
                    {
                        strMessage = "不存在高中学历,教育信息请从高中填起!";
                    }
                    else
                    {
                        strMessage = "不存在教育信息,是否完善简历?";
                    }

                    if (curObj.IS_NURSE == 2)
                    {
                        Response.Write("<script>if(confirm('" + strMessage + "')){location.href='../HEM_HRS/STAFF_EDUCATION.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                    else
                    {
                        Response.Write("<script>if(confirm('" + strMessage + "')){location.href='../HEM_HRS/STAFF_NURSE_EDUCATION.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                }
                else if (msg.Message == "NoWork")
                {
                    strMessage = "护理简历-往届生,必须填写工作经历!";
                    if (curObj.IS_NURSE == 1)
                    {
                        Response.Write("<script>if(confirm('" + strMessage + "')){location.href='../HEM_HRS/STAFF_NURSE_WORK.aspx';}else{location.href='RECRUIT_STAFF_APPLY_LIST.aspx';}</script>");
                    }
                }
                else
                {
                    Response.Write("<script>window.alert('" + msg.Message + "!');location.href='RECRUIT_STAFF_APPLY_LIST.aspx';</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('申请成功!');location.href='RECRUIT_STAFF_APPLY_LIST.aspx';</script>");
                //Response.Redirect("~/HEM_HPP/PageObject_HEM_B_RECRUIT_STAFF_APPLY_LIST.aspx",false);
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

        public void BackUrl()
        {
            Response.Redirect("~/HEM_HPP/RECRUIT_STAFF_APPLY_LIST.aspx");
        }
        protected void btn_Back_Click(object sender, EventArgs e)
        {
            BackUrl();
        }
    }
}
