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
    public partial class Error_403 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            lbl_Error.Text = "该页面目前不能访问 Error 403!";
		}
	}
}
