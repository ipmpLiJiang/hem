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
//using Ipedf.Hrp.Hem.Sap.BizLogic;
//using Ipedf.Hrp.Hem.Sap.Entity;

namespace Ipedf.Hrp.Hem.Sap.Web.Controls
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (Session["UserLogin"] != null)
            //    {
            //        EntityObject_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_USER_LOGIN_INFO;
            //        DisplayObject_USER_LOGIN_INFO[] disQuery = BizLogicObject_USER_LOGIN_INFO.Proxy.Query(
            //            new CauseObject_USER_LOGIN_INFO(){USER_ID = UserInfo.USER_ID});

            //        if (disQuery.Length == 0)
            //        {
            //            Page.ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('无效用户！');location.href='~/UserLogin.aspx';</script>");
            //        }
            //    }
            //}
        }
    }
}
