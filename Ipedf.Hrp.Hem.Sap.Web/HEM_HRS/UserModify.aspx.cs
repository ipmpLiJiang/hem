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
    public partial class UserModify : User_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                try
                {
                    EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                    this.txtInputNAME.Text = UserInfo.NAME;
                    this.txtInputACCOUNT.Text = UserInfo.ACCOUNT;
                    this.txtInputACCOUNT1.Text = UserInfo.ACCOUNT;
                    this.txtInputEMAIL.Text = UserInfo.EMAIL;

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            EntityObject_HEM_B_USER_LOGIN entityLogin = new EntityObject_HEM_B_USER_LOGIN();
            EntityObject_HEM_B_USER entityUser = new EntityObject_HEM_B_USER();
            string name = this.txtInputNAME.Text.Trim();
            string act = this.txtInputACCOUNT.Text.Trim();
            string act1 = this.txtInputACCOUNT1.Text.Trim();
            string email = this.txtInputEMAIL.Text.Trim();
            lbl_Error.Visible = true;
            if (!string.IsNullOrEmpty(name))
            {
                entityUser.NAME = name;
            }
            else
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "名称不能为空";
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
                lbl_Error.Visible = false;
                lbl_Error.Text = "手机号码/登录账户不能为空";
                return;
            }

            if (string.IsNullOrEmpty(act1))
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "重复手机号码/登录账户不能为空";
                return;
            }
            else
            {
                if (act1 != act)
                {
                    lbl_Error.Visible = false;
                    lbl_Error.Text = "两次输入的手机号码/登录账户必须一致";
                    return;
                }
            }

            if (!string.IsNullOrEmpty(email))
            {
                entityUser.EMAIL = email;
            }
            else
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "电子邮箱不能为空";
                //WebControlHelper.ShowAlert(null, "电子邮箱不能为空！");
                return;
            }


            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
            CauseObject_HEM_B_USER causeUser = new CauseObject_HEM_B_USER();
            causeUser.MOBILE = entityLogin.ACCOUNT;
            if (IsExistPhone(causeUser, UserInfo.USER_ID))
            {
                causeUser = new CauseObject_HEM_B_USER();
                causeUser.EMAIL = entityUser.EMAIL;
                if (IsExistPhone(causeUser, UserInfo.USER_ID))
                {
                    entityLogin.ID = UserInfo.ID;
                    entityUser.ID = UserInfo.USER_ID;
                    entityLogin.SetUpdate("ACCOUNT");
                    entityUser.SetUpdate("NAME", "MOBILE", "EMAIL");

                    CauseObject_HEM_B_STAFF causeStaff = new CauseObject_HEM_B_STAFF();
                    causeStaff.USER_ID = UserInfo.USER_ID;
                    EntityObject_HEM_B_STAFF entityStaff = new EntityObject_HEM_B_STAFF();
                    DisplayObject_HEM_B_STAFF[] itemStaff = BizLogicObject_HEM_B_STAFF.Proxy.Query(causeStaff);
                    if (itemStaff.Length > 0)
                    {
                        entityStaff.USER_ID = itemStaff[0].USER_ID;
                        entityStaff.USRID_TEL = entityLogin.ACCOUNT;
                        entityStaff.USRID_MAIL = entityUser.EMAIL;
                        entityStaff.NACHN = entityUser.NAME;
                    }
                    BizLogicMsg msg = BizLogicObject_HEM_B_USER_LOGIN.Proxy.RegisterUpdate(entityLogin, entityUser, entityStaff);
                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        UserInfo.NAME = entityUser.NAME;
                        UserInfo.MOBILE = entityUser.MOBILE;
                        UserInfo.EMAIL = entityUser.EMAIL;
                        UserInfo.ACCOUNT = entityLogin.ACCOUNT;
                        Session["UserLogin"] = UserInfo;
                        //Response.Write("<script>window.alert('保存成功!');location.href='UserModify.aspx';</script>"); 
                        lbl_Error.Visible = true;
                        lbl_Error.Text = "保存成功!";
                        //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功！');</script>");
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
                lbl_Error.Text = "该手机号码已被注册！";
            }
        }

        public bool IsExistPhone(CauseObject_HEM_B_USER cuase, string ID)
        {
            cuase.SetCustomCondition(" AND HEM_B_USER.ID !='" + ID + "'");
            DisplayObject_HEM_B_USER[] itemLg = BizLogicObject_HEM_B_USER.Proxy.Query(cuase);
            return itemLg.Length > 0 ? false : true;
        }

    }
}
