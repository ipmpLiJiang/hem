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
    public partial class FIND_PASSWORD : User_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                try
                {
                    EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                    this.lbl_ACCOUNT.Text = UserInfo.ACCOUNT.Trim();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            lbl_Error.Text = "";
            EntityObject_HEM_B_USER_LOGIN entityLogin = new EntityObject_HEM_B_USER_LOGIN();
            string pwd = this.txtInputPASSWORD.Text.Trim();
            string pwd1 = this.txtInputPASSWORD1.Text.Trim();
            string pwdOld = this.txtInputOldPASSWORD.Text.Trim();
            lbl_Error.Visible = true;

            if (string.IsNullOrEmpty(pwdOld))
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "原始密码不能为空！";
                //WebControlHelper.ShowAlert(null, "原始密码不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(pwd))
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "新密码不能为空！";
                //WebControlHelper.ShowAlert(null, "新密码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(pwd1))
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "确认密码不能为空！";
                //WebControlHelper.ShowAlert(null, "确认密码不能为空！");
                return;
            }


            if (pwd == pwd1)
            {
                entityLogin.PASSWORD = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "md5");
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "新密码和确认密码不一致！";
                return;
            }

            if (pwdOld != pwd)
            {
                EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                if (OldPassword(pwdOld, UserInfo.ACCOUNT))
                {
                    entityLogin.ID = UserInfo.ID;
                    entityLogin.SetUpdate("PASSWORD");
                    BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Update(entityLogin);
                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        UserInfo.PASSWORD = entityLogin.PASSWORD;
                        Session["UserLogin"] = UserInfo;
                        lbl_Error.Visible = true;
                        lbl_Error.Text = "保存成功!";
                        //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功！');</script>");
                    }
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "原始密码不正确!";
                }
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "输入的原始密码与新密码一致!";
            }
        }

        private bool OldPassword(string pwdOld, string Account)
        {
            bool IsTrue = false;
            CauseObject_HEM_B_USER_LOGIN cause = new CauseObject_HEM_B_USER_LOGIN();
            pwdOld = FormsAuthentication.HashPasswordForStoringInConfigFile(pwdOld, "md5");
            cause.PASSWORD = pwdOld;
            cause.ACCOUNT = Account;
            cause.FLAG = 0;
            DisplayObject_HEM_B_USER_LOGIN[] displayUl = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Query(cause);
            if (displayUl.Length > 0)
            {
                IsTrue = true;
            }

            return IsTrue;
        }

    }
}
