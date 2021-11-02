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
using Ipedf.Common;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class RECRUIT_POSTER_DETAIL : Manage_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            try
            {
                System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);

                if (parameters.Count != 0)
                {
                    string id = parameters["ID"].ToString();
                    EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                    entity.ID = id;
                    EntityObject_HEM_B_RECRUIT_POSTER obj = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Get(entity);
                    lbl_TITLE.Text = obj.TITLE;
                    lbl_DATA_SOURCE.Text = "资料来源：" + obj.DATA_SOURCE;
                    lbl_PUBLISHER.Text = "发布者：" + obj.PUBLISHER;
                    lbl_PUBLISH_DATE.Text = "日期：" + obj.PUBLISH_DATE.ToString("yyyy-MM-dd");

                    lbl_CONTENT.Text = obj.CONTENT;

                }
                else
                {
                    throw new Exception("参数出错!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
