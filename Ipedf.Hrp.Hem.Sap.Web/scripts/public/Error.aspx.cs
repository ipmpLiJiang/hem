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
	public partial class Error : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);

            if (parameters.Count != 0)
            {
                string er = parameters["msg"].ToString();
                lbl_Error.Text = er;
            }
            else
            {
                lbl_Error.Text = "页面出错,请联系管理员!";
            }
		}
	}
}
