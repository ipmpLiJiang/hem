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
    public partial class MsgTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SendMsg("13476256651", "00:0C:29:ED:5B:EB", "test");
        }
        private void SendMsg(string SEND_PHONE, string MAC, string CONTENT)
        {
            string Msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.SendMessage(SEND_PHONE, MAC, CONTENT);
            Response.Write(Msg);
        }
    }
}
