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
using System.Xml.Linq;
using System.Text.RegularExpressions;
using Ipedf.Web.Control;
using Ipedf.Core;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public class MyPage : System.Web.UI.Page
    {
        public int GetPageIndex(string page, int[] arrPage, System.Web.UI.WebControls.TextBox txt_PageNo)
        {
            int npage = 0;
            if (page != "1")
            {
                if (page.Equals("home"))
                {
                    npage = 0;
                }
                else if (page.Equals("back"))
                {
                    if (arrPage[0] > 0)
                    {
                        npage = arrPage[0] - 1;
                    }
                }
                else if (page.Equals("next"))
                {
                    if (arrPage[0] < arrPage[1])
                    {
                        npage = arrPage[0] + 1;
                    }
                }
                else if (page.Equals("last"))
                {
                    npage = arrPage[2];
                }
                else 
                {
                    string txt = txt_PageNo.Text.Trim();

                    if ("" == txt || !(Regex.IsMatch(txt, "[1-9]+")))
                    {
                        npage = 0;
                    }
                    else
                    {
                        npage = int.Parse(txt);
                        if (npage < 0)
                        {
                            npage = 0;
                        }
                        else
                        {
                            npage = npage - 1;
                        }
                    }
                }
            }

            return npage;
        }

        protected void PageText(PagingParamter paging, System.Web.UI.WebControls.LinkButton next, System.Web.UI.WebControls.LinkButton back, System.Web.UI.WebControls.Label lbl_PageNo, System.Web.UI.WebControls.TextBox txt_PageNo)
        {
            paging.PageIndex = paging.PageIndex + 1;
            lbl_PageNo.Text = "共" + paging.TotalRecords + "条 分" + paging.PageCount + "页 | 当前第" + paging.PageIndex + "页";

            if (paging.PageCount <= 1)
            {
                next.Enabled = false;
                back.Enabled = false;
            }
            else
            {
                if (paging.PageIndex == 1 && paging.PageCount > 0)
                {
                    next.Enabled = false;
                    back.Enabled = true;

                }
                else
                {
                    if (paging.PageIndex == paging.PageCount)
                    {
                        back.Enabled = false;
                        next.Enabled = true;
                    }
                    else
                    {
                        back.Enabled = true;
                        next.Enabled = true;
                    }

                }
            }
            txt_PageNo.Text = paging.PageIndex.ToString();
        }
    }
}
