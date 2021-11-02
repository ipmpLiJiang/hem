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
    public partial class ManageLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string Account = txtInputACCOUNT.Text.Trim();
            string Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtInputPASSWORD.Text.Trim(), "md5");

            CauseObject_V_USER_LOGIN_INFO cause = new CauseObject_V_USER_LOGIN_INFO();
            cause.ACCOUNT = Account;
            cause.PASSWORD = Password;
            cause.FLAG = 1;
            try
            {
                DisplayObject_V_USER_LOGIN_INFO loginEntity = BizLogicObject_V_USER_LOGIN_INFO.Proxy.Login(cause);
                if (loginEntity != null && loginEntity.ID != null && loginEntity.IS_USABL == 1)
                {
                    string guid = Guid.NewGuid().ToString();
                    Session["Token"] = guid;
                    Response.Cookies.Add(new HttpCookie("Token", guid));
                    Session["SysLogin"] = loginEntity;
                    //WebControlHelper.ShowAlert(null, "登录成功！");
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('登录成功！');location.href='HEM_HPP/RECRUIT_POSTER_LIST_PCD.aspx';</script>");
                    //Response.Redirect("~/HEM_HPP/RECRUIT_POSTER_LIST_PCD.aspx");
                }
                else
                {
                    lbl_Error.Visible = true;
                    if (loginEntity != null && loginEntity.IS_USABL != 1)
                    {
                        lbl_Error.Text = "当前用户账户不可用！";
                        return;
                    }
                        lbl_Error.Text = "账号或密码错误！";
                    
                }
            }
            catch(Exception ex) {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }
    }
}
