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
    public partial class MANAGE_USER_ADD : Manage_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                DisplayObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as DisplayObject_V_USER_LOGIN_INFO;
                if (UserInfo.ACCOUNT != "admin")
                {
                    Response.Write("<script>location.href='USER_LIST.aspx';</script>");
                }
            }

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
            string mobile = this.txtInputMOBILE.Text.Trim();

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
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('账户不能为空！');</script>");
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

            //if (!string.IsNullOrEmpty(email))
            //{
            //    entityUser.EMAIL = email;
            //}
            //else
            //{
            //    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('电子邮箱不能为空！');</script>");
            //    //WebControlHelper.ShowAlert(null, "电子邮箱不能为空！");
            //    return;
            //}

            CauseObject_HEM_B_USER_LOGIN causeLg = new CauseObject_HEM_B_USER_LOGIN();
            causeLg.ACCOUNT = entityLogin.ACCOUNT;

            if (IsExistAccount(causeLg))
            {
                entityUser.CREATE_DATE = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                entityLogin.IS_USABL = 1;
                entityLogin.FLAG = 1;
                entityUser.MOBILE = mobile;
                entityUser.EMAIL = email;
                BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.RegisterSave(entityLogin, entityUser);
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
                else
                {
                    Response.Write("<script>alert('保存成功!');location.href='MANAGE_USER_LIST.aspx';</script>");
                }
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "该账户已存在！";
            }
        }

        public bool IsExistAccount(CauseObject_HEM_B_USER_LOGIN cuase)
        {
            DisplayObject_HEM_B_USER_LOGIN[] itemLg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.Query(cuase);
            return itemLg.Length > 0 ? false : true;
        }
    }
}
