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
    public partial class FORGET_PASSWORD1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            string act = this.txtInputACCOUNT.Text.Trim();
            string pwd = this.txtInputPASSWORD.Text.Trim();
            string pwd1 = this.txtInputPASSWORD1.Text.Trim();

            lbl_Error.Visible = true;
            if (string.IsNullOrEmpty(act))
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "邮箱地址不能为空";
                //WebControlHelper.ShowAlert(null, "手机号码不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(pwd))
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "新密码不能为空";
                //WebControlHelper.ShowAlert(null, "新密码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(pwd1))
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "确认密码不能为空";
                //WebControlHelper.ShowAlert(null, "确认密码不能为空！");
                return;
            }
            if (pwd == pwd1)
            {
                pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "md5");
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "密码不一致！";
                return;
            }
            if (VerifyPhone(act))
            {
                CauseObject_HEM_B_USER_LOGIN causeUL = new CauseObject_HEM_B_USER_LOGIN();
                causeUL.ACCOUNT = act;
                EntityObject_HEM_B_USER_LOGIN obj = GetEntity(causeUL);
                if (!string.IsNullOrEmpty(obj.ID))
                {
                    if (obj.IS_USABL == 1)
                    {
                        EntityObject_HEM_B_USER_LOGIN entityLogin = new EntityObject_HEM_B_USER_LOGIN();
                        entityLogin.ID = obj.ID;
                        entityLogin.PASSWORD = pwd;
                        entityLogin.SetUpdate("PASSWORD");
                        BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Update(entityLogin);
                        if (!msg.Succeed)
                        {
                            lbl_Error.Visible = true;
                            lbl_Error.Text = msg.Message;
                        }
                        else
                        {
                            Response.Write("<script>window.alert('密码修改成功!');location.href='UserLogin.aspx';</script>");
                        }
                    }
                    else
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = "当前用户账户不可用！";
                    }
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "账户不存在！";
                }
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "邮箱地址格式不正确！";
            }
            
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
                    EntityObject_HEM_B_USER_LOGIN obj = GetEntity(causeLg);
                    if (!string.IsNullOrEmpty(obj.ID))
                    {
                        if (obj.IS_USABL == 1)
                        {
                            CauseObject_HEM_B_PHONE_MSSAGE causePm = new CauseObject_HEM_B_PHONE_MSSAGE();
                            causePm.STATUS = 2;
                            causePm.SEND_PHONE = causeLg.ACCOUNT;
                            causePm.IS_SEND = 1;
                            //EntityObject_HEM_B_PHONE_MSSAGE[] itemPM = bizPm.Query(causePm);
                            EntityObject_HEM_B_PHONE_MSSAGE entity = new EntityObject_HEM_B_PHONE_MSSAGE();
                            string exl = "";
                            BizLogicMsg msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.Delete(causePm);
                            //if (itemPM.Length == 0)
                            //{
                            if (msg.Succeed)
                            {
                                exl = StrRandom();

                                entity.STATUS = 2;
                                entity.SEND_PHONE = causeLg.ACCOUNT;
                                entity.MAC = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.GetMac();
                                entity.SEND_TIME = DateTime.Now;
                                entity.OVERDUE_TIME = entity.SEND_TIME.AddMinutes(5);
                                entity.REPLY_STATUS = exl;
                                entity.IS_SEND = 1;
                                entity.CONTENT = "验证码:" + exl;
                                msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.Save(entity);
                                if (msg.Succeed)
                                {
                                    SendMsg(entity.SEND_PHONE, entity.MAC, entity.CONTENT);
                                    return;
                                }
                            }
                            else
                            {
                                lbl_Error.Visible = true;
                                lbl_Error.Text = "错误请联系管理员！";
                            }
                            //}
                            //else
                            //{
                            //    entity = itemPM[0];
                            //    if (entity.OVERDUE_TIME >= DateTime.Now)
                            //    {
                            //        lbl_Error.Visible = true;
                            //        lbl_Error.Text = "手机号码已发送验证码,如果未接收到请等待五分钟后重新发送！";
                            //    }
                            //    else
                            //    {
                            //        exl = StrRandom();
                            //        entity.SEND_TIME = DateTime.Now;
                            //        entity.OVERDUE_TIME = entity.SEND_TIME.AddMinutes(5);
                            //        entity.REPLY_STATUS = exl;
                            //        entity.MAC = bizPm.GetMac();
                            //        entity.CONTENT = "验证码:"+exl;
                            //        entity.SetUpdate("SEND_TIME", "OVERDUE_TIME", "MAC", "REPLY_STATUS", "CONTENT");
                            //        BizLogicMsg msg = bizPm.Update(entity);
                            //        if (msg.Succeed)
                            //        {
                            //            SendMsg(bizPm, entity.SEND_PHONE, entity.MAC, entity.CONTENT);

                            //            return;
                            //        }
                            //    }
                            //}
                        }
                        else
                        {
                            lbl_Error.Visible = true;
                            lbl_Error.Text = "当前用户账户不可用！";
                        }
                    }
                    else
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = "账户不存在！";
                    }

                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "手机号码格式不正确！";
                }
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "手机号码不能为空！";

            }
        }

        public EntityObject_HEM_B_USER_LOGIN GetEntity(CauseObject_HEM_B_USER_LOGIN cuase)
        {
            //找回密码 确认手机号码是否存在
            EntityObject_HEM_B_USER_LOGIN entity = new EntityObject_HEM_B_USER_LOGIN();
            EntityObject_HEM_B_USER_LOGIN[] itemLg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Query(cuase);
            if (itemLg.Length == 1)
            {
                entity = itemLg[0];
            }
            return entity;
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
                DisabledBtn();
            }
        }

        public bool VerifyPhone(string strPhone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(strPhone, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public void DisabledBtn()
        {
            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>msg_Click();</script>");
        }
    }
}
