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

namespace Ipedf.Hrp.Hem.Sap.Web
{
	public partial class NullSession : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            try
            {
                System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);

                if (parameters.Count != 0)
                {
                    string er = parameters["Error"].ToString();
                    if (er == "1")
                    {
                        lbt_Session.PostBackUrl = "~/ManageLogin.aspx";

                    }
                    else if (er == "0")
                    {
                        lbt_Session.PostBackUrl = "~/UserLogin.aspx";
                    }
                    else
                    {
                        Response.Redirect("~/public/Error.aspx");
                    }

                }
                else
                {
                    Response.Redirect("~/public/Error.aspx");
                }
            }
            catch
            {
                Response.Redirect("~/public/Error.aspx");
            }
		}
	}
}
