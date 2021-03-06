using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Ipedf.Web.Control;
using Ipedf.Core;
using Ipedf.Hrp.Hem.Sap.BizLogic;
using Ipedf.Hrp.Hem.Sap.Entity;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class POSTER_DETAIL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
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
                    else
                    {
                        BackUrl();
                    }
                }
                catch (Exception ex)
                {
                    BackUrl();
                }
        }

        public void BackUrl()
        {
            Response.Redirect("~/POSTER_HOME.aspx");
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            EntityObject_HEM_B_USER_LOGIN entityLogin = new EntityObject_HEM_B_USER_LOGIN();
            EntityObject_HEM_B_USER entityUser = new EntityObject_HEM_B_USER();
            string name = this.txtInputNAME.Text.Trim();
            string act = this.txtInputACCOUNT.Text.Trim();
            string pwd = this.txtInputPASSWORD.Text.Trim();
            string pwd1 = this.txtInputPASSWORD1.Text.Trim();
            string email = this.txtInputEMAIL.Text.Trim();
            string yzm = txt_YZM.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                entityUser.NAME = name;
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('名称不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "名称不能为空！");
                return;
            }

            if (!string.IsNullOrEmpty(act))
            {
                entityLogin.ACCOUNT = act;
                entityUser.MOBILE = act;
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('手机号码不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "手机号码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('设置密码不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "设置密码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(pwd1))
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('重复密码不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "重复密码不能为空！");
                return;
            }

            if (pwd == pwd1)
            {
                entityLogin.PASSWORD = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "md5");
            }

            if (!string.IsNullOrEmpty(email))
            {
                entityUser.EMAIL = email;
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('电子邮箱不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "电子邮箱不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(yzm))
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('验证码不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "验证码不能为空！");
                return;
            }

            CauseObject_HEM_B_USER_LOGIN causeLg = new CauseObject_HEM_B_USER_LOGIN();
            causeLg.ACCOUNT = entityLogin.ACCOUNT;

            if (IsExistPhone(causeLg))
            {
                CauseObject_HEM_B_PHONE_MSSAGE causePm = new CauseObject_HEM_B_PHONE_MSSAGE();
                causePm.IS_SEND = 1;
                causePm.STATUS = 1;
                causePm.SEND_PHONE = entityLogin.ACCOUNT;
                causePm.OVERDUE_TIME = new DateSpan();
                causePm.OVERDUE_TIME.Begin = DateTime.Now;
                causePm.REPLY_STATUS = yzm;
                EntityObject_HEM_B_PHONE_MSSAGE[] itemPM = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.Query(causePm);

                if (itemPM.Length > 0)
                {
                    CauseObject_HEM_B_USER causeUser = new CauseObject_HEM_B_USER();
                    causeUser.EMAIL = entityUser.EMAIL;
                    EntityObject_HEM_B_USER[] itemUser = BizLogicObject_HEM_B_USER.Proxy.Query(causeUser);
                    if (itemUser.Length == 0)
                    {
                        entityUser.CREATE_DATE = DateTime.Now;
                        entityLogin.IS_USABL = 1;
                        entityLogin.FLAG = 0;

                        System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                        EntityObject_HEM_B_RECRUIT_POSTER entityRp = (ViewState["CUR_OBJ"]) as EntityObject_HEM_B_RECRUIT_POSTER;
                        EntityObject_HEM_B_STAFF_APPLY_N entityN = new EntityObject_HEM_B_STAFF_APPLY_N();
                        entityN.POSTER_ID = entityRp.ID;

                        BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.RegisterSave(entityLogin, entityUser, entityN);
                        if (!msg.Succeed)
                        {
                            lbl_Error.Visible = true;
                            lbl_Error.Text = msg.Message;
                        }
                        else
                        {
                            EntityObject_V_USER_LOGIN_INFO loginEntity = new EntityObject_V_USER_LOGIN_INFO();
                            loginEntity.ID = entityLogin.ID;
                            loginEntity.ACCOUNT = entityLogin.ACCOUNT;
                            loginEntity.PASSWORD = entityLogin.PASSWORD;
                            loginEntity.FLAG = entityLogin.FLAG;
                            loginEntity.IS_USABL = entityLogin.IS_USABL;
                            loginEntity.USER_ID = entityUser.ID;
                            loginEntity.EMAIL = entityUser.EMAIL;
                            loginEntity.MOBILE = entityUser.MOBILE;
                            loginEntity.NAME = entityUser.NAME;
                            loginEntity.CREATE_DATE = entityUser.CREATE_DATE;

                            string guid = Guid.NewGuid().ToString();
                            Session["Token"] = guid;
                            Response.Cookies.Add(new HttpCookie("Token", guid));
                            Session["UserLogin"] = loginEntity;
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('注册成功！');</script>");
                            //WebControlHelper.ShowAlert(null, "注册成功！");
                            if (entityRp.IS_NURSE == 1)
                            {
                                Response.Redirect("~/HEM_HRS/STAFF_NURSE_BASIC.aspx");
                            }
                            else
                            {
                                Response.Redirect("~/HEM_HRS/STAFF_BASIC.aspx");
                            }
                        }
                    }
                    else
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = "该邮箱已被注册！";

                    }
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "填写的验证码错误或已过期！";
                }
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "该手机号码已被注册！";
            }

            DivShow();
        }
        protected void btn_Save_Click1(object sender, EventArgs e)
        {
            EntityObject_HEM_B_USER_LOGIN entityLogin = new EntityObject_HEM_B_USER_LOGIN();
            EntityObject_HEM_B_USER entityUser = new EntityObject_HEM_B_USER();
            string name = this.txtInputNAME_1.Text.Trim();
            string pwd = this.txtInputPASSWORD_1.Text.Trim();
            string pwd1 = this.txtInputPASSWORD1_1.Text.Trim();
            string email = this.txtInputEMAIL_1.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                entityUser.NAME = name;
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('名称不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "名称不能为空！");
                return;
            }
            if (!string.IsNullOrEmpty(email))
            {
                entityLogin.ACCOUNT = email;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('设置密码不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "设置密码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(pwd1))
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('重复密码不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "重复密码不能为空！");
                return;
            }

            if (pwd == pwd1)
            {
                entityLogin.PASSWORD = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "md5");
            }

            if (!string.IsNullOrEmpty(email))
            {
                entityUser.EMAIL = email;
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('电子邮箱不能为空！');</script>");
                //WebControlHelper.ShowAlert(null, "电子邮箱不能为空！");
                return;
            }

            CauseObject_HEM_B_USER_LOGIN causeLg = new CauseObject_HEM_B_USER_LOGIN();
            causeLg.ACCOUNT = entityLogin.ACCOUNT;

            CauseObject_HEM_B_USER causeUser = new CauseObject_HEM_B_USER();
            causeUser.EMAIL = entityUser.EMAIL;
            EntityObject_HEM_B_USER[] itemUser = BizLogicObject_HEM_B_USER.Proxy.Query(causeUser);
            if (itemUser.Length == 0)
            {
                entityUser.CREATE_DATE = DateTime.Now;
                entityUser.OUTOCEAN = 1;
                entityLogin.IS_USABL = 1;
                entityLogin.FLAG = 0;

                BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.RegisterSave(entityLogin, entityUser);
                if (!msg.Succeed)
                {
                    lbl_Error_1.Visible = true;
                    lbl_Error_1.Text = msg.Message;
                }
                else
                {
                    EntityObject_V_USER_LOGIN_INFO loginEntity = new EntityObject_V_USER_LOGIN_INFO();
                    loginEntity.ID = entityLogin.ID;
                    loginEntity.ACCOUNT = entityLogin.ACCOUNT;
                    loginEntity.PASSWORD = entityLogin.PASSWORD;
                    loginEntity.FLAG = entityLogin.FLAG;
                    loginEntity.IS_USABL = entityLogin.IS_USABL;
                    loginEntity.USER_ID = entityUser.ID;
                    loginEntity.EMAIL = entityUser.EMAIL;
                    loginEntity.MOBILE = entityUser.MOBILE;
                    loginEntity.NAME = entityUser.NAME;
                    loginEntity.CREATE_DATE = entityUser.CREATE_DATE;

                    string guid = Guid.NewGuid().ToString();
                    Session["Token"] = guid;
                    Response.Cookies.Add(new HttpCookie("Token", guid));
                    Session["UserLogin"] = loginEntity;
                    //WebControlHelper.ShowAlert(null, "注册成功！");
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('注册成功！');location.href='HEM_HPP/RECRUIT_STAFF_APPLY_LIST.aspx';</script>");
                    //Response.Redirect("~/HEM_HPP/RECRUIT_STAFF_APPLY_LIST.aspx");
                }
            }
            else
            {
                lbl_Error_1.Visible = true;
                lbl_Error_1.Text = "该邮箱已被注册！";
            }

            DivShow1();
        }

        public bool IsExistPhone(CauseObject_HEM_B_USER_LOGIN cuase)
        {
            EntityObject_HEM_B_USER_LOGIN[] itemLg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Query(cuase);
            return itemLg.Length > 0 ? false : true;
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string Account = txt_AccountLg.Text.Trim();
            //if (VerifyPhone(Account))
            //{
                string Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_PasswordLg.Text.Trim(), "md5");
                CauseObject_V_USER_LOGIN_INFO cause = new CauseObject_V_USER_LOGIN_INFO();
                cause.ACCOUNT = Account;
                cause.PASSWORD = Password;
                cause.FLAG = 0;
                try
                {
                    System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                    EntityObject_HEM_B_RECRUIT_POSTER entityRp = (ViewState["CUR_OBJ"]) as EntityObject_HEM_B_RECRUIT_POSTER;

                    EntityObject_V_USER_LOGIN_INFO loginEntity = new EntityObject_V_USER_LOGIN_INFO();
                    BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Login(cause, ref entityRp, ref loginEntity);
                    if (msg.Succeed)
                    {
                        string strMessage = "";

                        string guid = Guid.NewGuid().ToString();
                        Session["Token"] = guid;
                        Response.Cookies.Add(new HttpCookie("Token", guid));
                        Session["UserLogin"] = loginEntity;
                        if (msg.Message == "A0")
                        {
                            strMessage = "申请失败,请登录后完善简历后重新申请!";
                            if (entityRp.IS_NURSE == 1)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_NURSE_BASIC.aspx';</script>");
                            }
                            else if (entityRp.IS_NURSE == 2)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_BASIC.aspx';</script>");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_SEND_BASIC.aspx';</script>");
                            }
                        }
                        else if (msg.Message == "A1")
                        {
                            strMessage = "申请失败,请登录后完善简历!";
                            if (entityRp.IS_NURSE == 1)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_NURSE_BASIC.aspx';</script>");
                            }
                            else if (entityRp.IS_NURSE == 2)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_BASIC.aspx';</script>");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_SEND_BASIC.aspx';</script>");
                            }
                        }
                        else if (msg.Message == "B0")
                        {
                            strMessage = "申请失败,请登录后完善【教育信息】后重新申请,教育信息请从高中填起!";
                            if (entityRp.IS_NURSE == 1)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_NURSE_EDUCATION.aspx';</script>");
                            }
                            else if (entityRp.IS_NURSE == 2)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_EDUCATION.aspx';</script>");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_SEND_EDUCATION.aspx';</script>");
                            }
                        }
                        else if (msg.Message == "B1" || msg.Message == "B2")
                        {
                            if (msg.Message == "B1")
                            {
                                strMessage = "申请失败,请登录后完善【教育信息】,教育信息请从高中填起!";
                            }
                            else
                            {
                                strMessage = "申请失败,【教育信息】不存在高中学历,教育信息请从高中填起!";
                            }

                            if (entityRp.IS_NURSE == 1)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_NURSE_EDUCATION.aspx';</script>");
                            }
                            else if (entityRp.IS_NURSE == 2)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_EDUCATION.aspx';</script>");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_SEND_EDUCATION.aspx';</script>");
                            }
                        }
                        else if (msg.Message == "B3")
                        { 
                            strMessage = "申请失败,请上传简历附件!";
                            if (entityRp.IS_NURSE == 1)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_NURSE_BASIC.aspx';</script>");
                            }
                            else if (entityRp.IS_NURSE == 2)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_BASIC.aspx';</script>");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_SEND_BASIC.aspx';</script>");
                            }
                        }
                        else if (msg.Message == "C1")
                        {
                            strMessage = "申请失败,护理简历-往届生,必须填写【工作经历】!";
                            if (entityRp.IS_NURSE == 1)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_NURSE_WORK.aspx';</script>");
                            }
                            else if(entityRp.IS_NURSE == 2)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_WORK.aspx';</script>");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + strMessage + "');location.href='HEM_HRS/STAFF_SEND_WORK.aspx';</script>");
                            }
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + msg.Message + "');location.href='HEM_HPP/RECRUIT_STAFF_APPLY_LIST.aspx';</script>");
                        }
                    }
                    else
                    {
                        lbl_ErrorLg.Visible = true;
                        lbl_ErrorLg.Text = msg.Message;
                    }
                }
                catch (Exception ex)
                {
                    lbl_ErrorLg.Visible = true;
                    lbl_ErrorLg.Text = ex.Message;
                }
                DivShowLg();
            //}
            //else
            //{
            //    lbl_ErrorLg.Text = "手机号码格式不正确！";
            //    DivShowLg();
            //}
        }

        protected void btn_Msg_Click(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            string txt_Phone = this.txtInputACCOUNT.Text.Trim();
            if (!string.IsNullOrEmpty(txt_Phone))
            {
                if (VerifyPhone(txt_Phone))
                {
                    CauseObject_HEM_B_USER_LOGIN causeLg = new CauseObject_HEM_B_USER_LOGIN();
                    causeLg.ACCOUNT = txt_Phone;

                    if (IsExistPhone(causeLg))
                    {
                        CauseObject_HEM_B_PHONE_MSSAGE causePm = new CauseObject_HEM_B_PHONE_MSSAGE();
                        causePm.STATUS = 1;
                        causePm.SEND_PHONE = causeLg.ACCOUNT;
                        EntityObject_HEM_B_PHONE_MSSAGE[] itemPM = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.Query(causePm);
                        EntityObject_HEM_B_PHONE_MSSAGE entity = new EntityObject_HEM_B_PHONE_MSSAGE();
                        string exl = "";
                        if (itemPM.Length == 0)
                        {
                            exl = StrRandom();

                            entity.STATUS = 1;
                            entity.SEND_PHONE = causeLg.ACCOUNT;
                            entity.MAC = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.GetMac();
                            entity.SEND_TIME = DateTime.Now;
                            entity.OVERDUE_TIME = entity.SEND_TIME.AddMinutes(5);
                            entity.REPLY_STATUS = exl;
                            entity.IS_SEND = 1;
                            entity.CONTENT = "验证码:" + exl;
                            BizLogicMsg msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.Save(entity);
                            if (msg.Succeed)
                            {
                                SendMsg(entity.SEND_PHONE, entity.MAC, entity.CONTENT);
                                return;
                            }
                        }
                        else
                        {
                            entity = itemPM[0];
                            if (entity.OVERDUE_TIME >= DateTime.Now)
                            {
                                lbl_Error.Visible = true;
                                lbl_Error.Text = "该手机号码已发送验证码,如果未接收到请等待五分钟后重新发送！";
                            }
                            else
                            {
                                exl = StrRandom();
                                entity.SEND_TIME = DateTime.Now;
                                entity.OVERDUE_TIME = entity.SEND_TIME.AddMinutes(5);
                                entity.REPLY_STATUS = exl;
                                entity.MAC = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.GetMac();
                                entity.CONTENT = "验证码:" + exl;
                                entity.SetUpdate("SEND_TIME", "OVERDUE_TIME", "MAC", "REPLY_STATUS", "CONTENT");
                                BizLogicMsg msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.Update(entity);
                                if (msg.Succeed)
                                {
                                    SendMsg(entity.SEND_PHONE, entity.MAC, entity.CONTENT);
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = "该手机号码已被注册！";
                    }

                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "该手机号码格式不正确！";
                }
                DivShow();
            }
            else
            {

                lbl_Error.Visible = true;
                lbl_Error.Text = "手机号码不能为空！";
                DivShow();
            }
        }

        private string StrRandom()
        {
            Random example = new Random();
            string exl = "";
            for (int i = 1; i <= 6; i++)
            {
                exl = exl + example.Next(1, 9).ToString();
            }
            return exl;
        }

        private void SendMsg(string SEND_PHONE, string MAC, string CONTENT)
        {
            string Msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.SendMessage(SEND_PHONE, MAC, CONTENT);
            lbl_Error.Visible = true;
            lbl_Error.Text = Msg;
            if (Msg == "发送成功")
            {
                DivShowBtn();
            }
        }

        public bool VerifyPhone(string strPhone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(strPhone, @"^[1]+\d{10}");
        }

        public void DivShow()
        {
            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block';</script>");
        }

        public void DivShow1()
        {
            ClientScript.RegisterStartupScript(GetType(), "dddd", "<script>document.getElementById('light1').style.display='block';document.getElementById('fade').style.display='block';</script>");
        }

        public void DivShowBtn()
        {
            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>msg_Click();document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block';</script>");
        }

        public void DivShowLg()
        {
            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>document.getElementById('lightLg').style.display='block';document.getElementById('fade').style.display='block';</script>");
        }

    }
}
