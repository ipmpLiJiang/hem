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
    public partial class MANAGE_USER_EDIT : Manage_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (!IsPostBack)
            {
                DisplayObject_V_USER_LOGIN_INFO UserInfo = Session["SysLogin"] as DisplayObject_V_USER_LOGIN_INFO;
                if (UserInfo.ACCOUNT != "admin")
                {
                    Response.Write("<script>location.href='MANAGE_USER_LIST.aspx';</script>");
                }
                else
                {
                    try
                    {
                        System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                        if (parameters.Count != 0)
                        {
                            string id = parameters["ID"].ToString();

                            DisplayObject_V_USER_LOGIN_INFO[] disULI = BizLogicObject_V_USER_LOGIN_INFO.Proxy.Query(new CauseObject_V_USER_LOGIN_INFO() { ID = id });
                            if (disULI.Length > 0)
                            {
                                GetEditEntity(disULI[0]);
                                ViewState["CUR_OBJ"] = disULI[0];
                            }
                        }
                        else
                        {
                            Response.Write("<script>location.href='MANAGE_USER_LIST.aspx';</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            EntityObject_HEM_B_USER entityUser = new EntityObject_HEM_B_USER();
            string name = this.txtInputNAME.Text.Trim();
            string email = this.txtInputEMAIL.Text.Trim();
            string mobile = txtInputMOBILE.Text.Trim();
            DisplayObject_V_USER_LOGIN_INFO disUserLoginInfo = (DisplayObject_V_USER_LOGIN_INFO)ViewState["CUR_OBJ"];
            if (!string.IsNullOrEmpty(name))
            {
                entityUser.NAME = name;
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('姓名不能为空！');</script>");
                return;
            }
            entityUser.MOBILE = mobile;
            entityUser.EMAIL = email;
            entityUser.ID = disUserLoginInfo.USER_ID;
            entityUser.SetUpdate("NAME", "MOBILE", "EMAIL");
            BizLogicMsg msg = BizLogicObject_HEM_B_USER.Proxy.Update(entityUser);
            if (!msg.Succeed)
            {
                lbl_Error.Visible = true;
                lbl_Error.ForeColor = System.Drawing.Color.Red;
                lbl_Error.Text = msg.Message;
            }
            else
            {
                disUserLoginInfo.MOBILE = mobile;
                disUserLoginInfo.EMAIL = email;
                disUserLoginInfo.NAME = name;
                ViewState["CUR_OBJ"] = disUserLoginInfo;

                lbl_Error.Visible = true;
                lbl_Error.ForeColor = System.Drawing.Color.Green;
                lbl_Error.Text = "保存成功!";
            }
        }

        public void GetEditEntity(DisplayObject_V_USER_LOGIN_INFO disUserLoginInfo)
        {
            this.txtInputNAME.Text = disUserLoginInfo.NAME;
            this.txtInputEMAIL.Text = disUserLoginInfo.EMAIL;
            this.txtInputMOBILE.Text = disUserLoginInfo.MOBILE;
            this.lbl_ACCOUNT.Text = disUserLoginInfo.ACCOUNT;
        }
    }
}
