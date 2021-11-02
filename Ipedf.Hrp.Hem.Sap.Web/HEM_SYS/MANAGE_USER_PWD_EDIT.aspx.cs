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
    public partial class MANAGE_USER_PWD_EDIT : Manage_Page
    {
        bool IsBool = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                try
                {
                    System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                    if (parameters.Count != 0)
                    {
                        DisplayObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as DisplayObject_V_USER_LOGIN_INFO;
                        if (UserInfo.ACCOUNT != "admin")
                        {
                            Response.Write("<script>location.href='MANAGE_USER_LIST.aspx';</script>");
                        }
                        else
                        {
                            IsBool = false;
                            div_old.Visible = false;
                            string id = parameters["ID"].ToString();
                            DisplayObject_V_USER_LOGIN_INFO[] disULI = BizLogicObject_V_USER_LOGIN_INFO.Proxy.Query(new CauseObject_V_USER_LOGIN_INFO() { ID = id });
                            if (disULI.Length > 0)
                            {
                                GetEditEntity(disULI[0]);
                                ViewState["CUR_OBJ"] = disULI[0];
                            }
                        }
                    }
                    else
                    {
                        IsBool = true;
                        DisplayObject_V_USER_LOGIN_INFO disUserLoginInfo = (DisplayObject_V_USER_LOGIN_INFO)Session["SysLogin"];
                        GetEditEntity(disUserLoginInfo);
                        ViewState["CUR_OBJ"] = disUserLoginInfo;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                if (parameters.Count != 0)
                {
                    IsBool = false;
                }
                else
                {
                    IsBool = true;
                }
            }

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            lbl_Error.Text = "";
            EntityObject_HEM_B_USER_LOGIN entityUserLogin = new EntityObject_HEM_B_USER_LOGIN();
            string oldpassword = this.txtInputOLDPASSWORD.Text.Trim();
            string password = this.txtInputPASSWORD.Text.Trim();
            string password1 = this.txtInputPASSWORD1.Text.Trim();
            DisplayObject_V_USER_LOGIN_INFO disUserLoginInfo = (DisplayObject_V_USER_LOGIN_INFO)ViewState["CUR_OBJ"];

            if (string.IsNullOrEmpty(password))
            {
                //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('新密码不能为空！');</script>");
                lbl_Error.Visible = true;
                lbl_Error.ForeColor = System.Drawing.Color.Red;
                lbl_Error.Text = "新密码不能为空";
                return;
            }
            if (string.IsNullOrEmpty(password1))
            {
                //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('重复密码不能为空！');</script>");
                lbl_Error.Visible = true;
                lbl_Error.ForeColor = System.Drawing.Color.Red;
                lbl_Error.Text = "重复密码不能为空";
                return;
            }

            if (IsBool)
            {
                if (string.IsNullOrEmpty(oldpassword))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('原始密码不能为空！');</script>");
                    lbl_Error.Visible = true;
                    lbl_Error.ForeColor = System.Drawing.Color.Red;
                    lbl_Error.Text = "原始密码不能为空";
                    return;
                }
            }

            if (password != password1)
            {
                //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('新密码和重复密码不一致！');</script>");
                lbl_Error.Visible = true;
                lbl_Error.ForeColor = System.Drawing.Color.Red;
                lbl_Error.Text = "新密码和重复密码不一致";
                return;
            }

            if (IsBool)
            {
                if (password != oldpassword)
                {
                    if (OldPassword(oldpassword, disUserLoginInfo.ID))
                    {
                        password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "md5");
                        entityUserLogin.ID = disUserLoginInfo.ID;
                        entityUserLogin.PASSWORD = password;
                        entityUserLogin.SetUpdate("PASSWORD");
                        BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Update(entityUserLogin);
                        if (!msg.Succeed)
                        {
                            lbl_Error.Visible = true;
                            lbl_Error.ForeColor = System.Drawing.Color.Red;
                            lbl_Error.Text = msg.Message;
                        }
                        else
                        {
                            this.txtInputOLDPASSWORD.Text = "";
                            this.txtInputPASSWORD.Text = "";
                            this.txtInputPASSWORD1.Text = "";

                            lbl_Error.Visible = true;
                            lbl_Error.ForeColor = System.Drawing.Color.Green;
                            lbl_Error.Text = "密码修改成功!";
                        }
                    }
                    else
                    {
                        //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('原始密码错误！');</script>");
                        lbl_Error.Visible = true;
                        lbl_Error.ForeColor = System.Drawing.Color.Red;
                        lbl_Error.Text = "原始密码错误";
                        return;
                    }
                }
                else
                {
                    //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('输入的原始密码与新密码一致！');</script>");
                    lbl_Error.Visible = true;
                    lbl_Error.ForeColor = System.Drawing.Color.Red;
                    lbl_Error.Text = "输入的原始密码与新密码一致";
                    return;
                }
            }
            else
            {
                password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "md5");
                entityUserLogin.ID = disUserLoginInfo.ID;
                entityUserLogin.PASSWORD = password;
                entityUserLogin.SetUpdate("PASSWORD");
                BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Update(entityUserLogin);
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.ForeColor = System.Drawing.Color.Red;
                    lbl_Error.Text = msg.Message;
                }
                else
                {
                    this.txtInputOLDPASSWORD.Text = "";
                    this.txtInputPASSWORD.Text = "";
                    this.txtInputPASSWORD1.Text = "";

                    lbl_Error.Visible = true;
                    lbl_Error.ForeColor = System.Drawing.Color.Green;
                    lbl_Error.Text = "密码修改成功!";
                }
            }
        }

        public void GetEditEntity(DisplayObject_V_USER_LOGIN_INFO disUserLoginInfo)
        {
            this.lbl_NAME.Text = disUserLoginInfo.NAME;
            this.lbl_ACCOUNT.Text = disUserLoginInfo.ACCOUNT;
        }

        private bool OldPassword(string pwdOld, string Id)
        {
            bool IsTrue = false;
            CauseObject_HEM_B_USER_LOGIN cause = new CauseObject_HEM_B_USER_LOGIN();
            pwdOld = FormsAuthentication.HashPasswordForStoringInConfigFile(pwdOld, "md5");
            cause.PASSWORD = pwdOld;
            cause.ID = Id;
            cause.FLAG = 1;
            DisplayObject_HEM_B_USER_LOGIN[] displayUl = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Query(cause);
            if (displayUl.Length > 0)
            {
                IsTrue = true;
            }

            return IsTrue;
        }
    }
}
