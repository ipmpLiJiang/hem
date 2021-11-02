using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Ipedf.Web.Control;
using Ipedf.Core;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public class User_Page : MyPage
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLogin"] != null && Session["Token"] != null
           && Request.Cookies["Token"] != null)
            {
                if (!Session["Token"].ToString().Equals(
                   Request.Cookies["Token"].Value))
                {
                    throw new Exception("会话过期！");
                }
            }
            else
            {
                throw new Exception("会话过期！");
            }
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Exception expt = Server.GetLastError();
            Context.ClearError();
            BizLogicBase blb = new BizLogicBase();
            blb.Error(expt);

            if (Session["UserLogin"] == null)
            {
                //会话过期               
                System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                parameters.Add("Error", "0");
                Response.Redirect(WebControlHelper.EncodeUrl("~/public/NullSession.aspx", parameters));
            }
            else
            {
                System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                //其它异常
                if (expt.InnerException == null)
                {
                    parameters.Add("msg", expt.Message);
                }
                else
                {
                    parameters.Add("msg", expt.InnerException.Message);
                }
                Response.Redirect(WebControlHelper.EncodeUrl("~/public/User_Error.aspx", parameters));
            }
        }
	}
}
