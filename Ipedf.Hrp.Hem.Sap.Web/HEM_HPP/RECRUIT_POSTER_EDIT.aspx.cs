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
    public partial class RECRUIT_POSTER_EDIT : Manage_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (ViewState["CUR_OBJ"] == null)
            {
                try
                {
                    System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
                    DisplayObject_V_USER_LOGIN_INFO userLogin = Session["SysLogin"] as DisplayObject_V_USER_LOGIN_INFO;
                    if (parameters.Count != 0)
                    {
                        string id = parameters["ID"].ToString();
                        EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                        entity.ID = id;
                        entity = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Get(entity);

                        if (entity.USER_ID != userLogin.USER_ID)
                        {
                            this.txtInputPUBLISHER.Enabled = false;
                            this.txtInputDATA_SOURCE.Enabled = false;
                            this.rbInputISNURSE1.Enabled = false;
                            this.rbInputISNURSE2.Enabled = false;
                            this.rbInputISPUBLIC1.Enabled = false;
                            this.rbInputISPUBLIC2.Enabled = false;
                        }
                        else
                        {
                            if (entity.STATUS == (decimal)POSTER_STATUS.已发布 || entity.STATUS != (decimal)POSTER_STATUS.已过期)
                            {
                                this.rbInputISNURSE1.Enabled = false;
                                this.rbInputISNURSE2.Enabled = false;
                            }
                        }
                        GetEditEntity(entity);
                        ViewState["CUR_OBJ"] = entity;
                    }
                    else
                    {
                        this.txtInputPUBLISHER.Text = userLogin.NAME;
                        this.txtInputEND_DATE.Text = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");
                        this.txtInputPUBLISH_DATE.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            DisplayObject_V_USER_LOGIN_INFO userLogin = Session["SysLogin"] as DisplayObject_V_USER_LOGIN_INFO;
            if (ViewState["CUR_OBJ"] == null)
            {
                EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                SetEditEntity(entity);

                if (string.IsNullOrEmpty(entity.TITLE))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "招聘标题不能为空！";
                    //WebControlHelper.ShowAlert(null, "广告标题不能为空！");
                    return;
                }

                lbl_CONTENT.Visible = false;
                //内容
                if (string.IsNullOrEmpty(entity.CONTENT))
                {
                    lbl_CONTENT.Visible = true;
                    return;
                }

                //报名截止时间
                if (string.IsNullOrEmpty(entity.END_DATE.ToString()))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "截止日期不能为空！";
                    //WebControlHelper.ShowAlert(null, "截止日期不能为空！");
                    return;
                }

                //报名截止时间
                if (string.IsNullOrEmpty(entity.PUBLISH_DATE.ToString()))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "发布日期不能为空！";
                    //WebControlHelper.ShowAlert(null, "发布日期不能为空！");
                    return;
                }

                //发布人
                if (string.IsNullOrEmpty(entity.PUBLISHER))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "发布人不能为空！";
                    //WebControlHelper.ShowAlert(null, "发布人不能为空！");
                    return;
                }

                //资料来源
                if (string.IsNullOrEmpty(entity.DATA_SOURCE))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "资料来源不能为空！";
                    //WebControlHelper.ShowAlert(null, "资料来源不能为空！");
                    return;
                }

                //招聘职位
                if (string.IsNullOrEmpty(entity.RECRUIT_POSITION))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "招聘职位不能为空！";
                    //WebControlHelper.ShowAlert(null, "招聘职位不能为空！");
                    return;
                }

                //decimal STATUS = 0;//状态
                entity.STATUS = (decimal)POSTER_STATUS.未发布;

                //string CREATE_DATE = "";//创建日期
                entity.CREATE_DATE = DateTime.Now;//创建日期
                //发布账号
                entity.USER_ID = userLogin.USER_ID;
                entity.MODIFY_USER_ID = userLogin.USER_ID;
                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Save(entity);
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
                else
                {
                    ViewState["CUR_OBJ"] = entity;
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功！');</script>");
                    //WebControlHelper.ShowAlert(null, "保存成功！");
                    lbl_Error.Visible = false;
                    lbl_Error.Text = "";
                }
            }
            else
            {
                EntityObject_HEM_B_RECRUIT_POSTER curObj = ViewState["CUR_OBJ"] as EntityObject_HEM_B_RECRUIT_POSTER;
                SetEditEntity(curObj);

                if (string.IsNullOrEmpty(curObj.TITLE))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "招聘标题不能为空！";
                    //WebControlHelper.ShowAlert(null, "广告标题不能为空！");
                    return;
                }

                //内容
                lbl_CONTENT.Visible = false;
                //内容
                if (string.IsNullOrEmpty(curObj.CONTENT))
                {
                    lbl_CONTENT.Visible = true;
                    return;
                }

                //报名截止时间
                if (string.IsNullOrEmpty(curObj.END_DATE.ToString()))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "截止日期不能为空！";
                    //WebControlHelper.ShowAlert(null, "截止日期不能为空！");
                    return;
                }

                //报名截止时间
                if (string.IsNullOrEmpty(curObj.PUBLISH_DATE.ToString()))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "发布日期不能为空！";
                    //WebControlHelper.ShowAlert(null, "发布日期不能为空！");
                    return;
                }

                //发布人
                if (string.IsNullOrEmpty(curObj.PUBLISHER))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "发布人不能为空！";
                    //WebControlHelper.ShowAlert(null, "发布人不能为空！");
                    return;
                }

                //资料来源
                if (string.IsNullOrEmpty(curObj.DATA_SOURCE))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "资料来源不能为空！";
                    //WebControlHelper.ShowAlert(null, "资料来源不能为空！");
                    return;
                }

                //招聘职位
                if (string.IsNullOrEmpty(curObj.RECRUIT_POSITION))
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "招聘职位不能为空！";
                    //WebControlHelper.ShowAlert(null, "招聘职位不能为空！");
                    return;
                }
                curObj.MODIFY_USER_ID = userLogin.USER_ID;
                if (curObj.USER_ID != userLogin.USER_ID)
                {
                    curObj.SetNotUpdate("STATUS", "CREATE_DATE", "USER_ID", "IS_NURSE", "IS_PUBLIC", "PUBLISHER", "DATA_SOURCE");
                }
                else
                {
                    curObj.SetNotUpdate("STATUS", "CREATE_DATE", "USER_ID");
                }
                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Update(curObj);
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
                else
                {
                    ViewState["CUR_OBJ"] = curObj;
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功！');</script>");
                    //WebControlHelper.ShowAlert(null, "保存成功！");
                    lbl_Error.Visible = false;
                    lbl_Error.Text = "";
                }
            }
        }

        //发布招聘广告
        protected void btn_Issue_Click(object sender, EventArgs e)
        {
            if (ViewState["CUR_OBJ"] == null)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "请先保存数据！";
                //WebControlHelper.ShowAlert(null, "请先保存数据！");
                return;
            }
            else
            {
                EntityObject_HEM_B_RECRUIT_POSTER curObj = ViewState["CUR_OBJ"] as EntityObject_HEM_B_RECRUIT_POSTER;
                //EditEntity(curObj);
                curObj.STATUS = (decimal)POSTER_STATUS.已发布;
                curObj.SetUpdate("STATUS");
                BizLogicMsg msg = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Update(curObj);
                if (!msg.Succeed)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = msg.Message;
                }
                else
                {
                    //ViewState["CUR_OBJ"] = null;
                    //lbl_Error.Visible = false;
                    //lbl_Error.Text = "";
                    Response.Write("<script>window.alert('发布成功!');location.href='RECRUIT_POSTER_LIST_PCD.aspx';</script>");
                }
            }
        }

        protected EntityObject_HEM_B_RECRUIT_POSTER SetEditEntity(EntityObject_HEM_B_RECRUIT_POSTER entity)
        {
            lbl_Error.Visible = false;
            lbl_Error.Text = "";
            //广告标题
            if (!string.IsNullOrEmpty(this.txtInputTITLE.Text))
            {
                entity.TITLE = this.txtInputTITLE.Text;
            }
            else
            {
                entity.TITLE = "";
            }

            //内容
            if (!string.IsNullOrEmpty(this.txtInputCONTENT.Text))
            {
                entity.CONTENT = this.txtInputCONTENT.Text;
            }
            else
            {
                entity.CONTENT = "";
            }

            //发布日期
            if (!string.IsNullOrEmpty(this.txtInputEND_DATE.Text))
            {
                entity.PUBLISH_DATE = DateTime.Parse(this.txtInputPUBLISH_DATE.Text);
            }
            else
            {
                entity.PUBLISH_DATE = Ipedf.Common.Template.UndefineDatetime;
            }

            //结束日期
            if (!string.IsNullOrEmpty(this.txtInputEND_DATE.Text))
            {
                entity.END_DATE = DateTime.Parse(this.txtInputEND_DATE.Text);
            }
            else
            {
                entity.END_DATE = Ipedf.Common.Template.UndefineDatetime;
            }

            //内容
            if (!string.IsNullOrEmpty(this.txtInputPUBLISHER.Text))
            {
                entity.PUBLISHER = this.txtInputPUBLISHER.Text;
            }
            else
            {
                entity.PUBLISHER = "";
            }

            //资料来源
            if (!string.IsNullOrEmpty(this.txtInputDATA_SOURCE.Text))
            {
                entity.DATA_SOURCE = this.txtInputDATA_SOURCE.Text;
            }
            else
            {
                entity.DATA_SOURCE = "";
            }

            //招聘职位
            if (!string.IsNullOrEmpty(this.txtInputRECRUIT_POSITION.Text))
            {
                entity.RECRUIT_POSITION = this.txtInputRECRUIT_POSITION.Text;
            }
            else
            {
                entity.RECRUIT_POSITION = "";
            }

            //if (this.rbInputISNURSE1.Checked == true)
            //{
            //    entity.IS_NURSE = 1;
            //}
            //else
            //{
            //    entity.IS_NURSE = 2;
            //}
            entity.IS_NURSE = Convert.ToDecimal(ddlISNURSE.SelectedValue);
            if (this.rbInputISSEND1.Checked == true)
            {
                entity.IS_SEND = 1;
            }
            else
            {
                entity.IS_SEND = 2;
            }

            if (this.rbInputISPUBLIC1.Checked == true)
            {
                entity.IS_PUBLIC = 1;
            }
            else
            {
                entity.IS_PUBLIC = 2;
            }

            return entity;
        }

        protected void GetEditEntity(EntityObject_HEM_B_RECRUIT_POSTER entity)
        {
            //广告标题
            this.txtInputTITLE.Text = entity.TITLE;

            //内容
            this.txtInputCONTENT.Text = entity.CONTENT;

            //发布日期
            this.txtInputPUBLISH_DATE.Text = entity.PUBLISH_DATE.ToString("yyyy-MM-dd");

            //结束日期
            this.txtInputEND_DATE.Text = entity.END_DATE.ToString("yyyy-MM-dd");

            //发布人
            this.txtInputPUBLISHER.Text = entity.PUBLISHER;

            //资料来源
            this.txtInputDATA_SOURCE.Text = entity.DATA_SOURCE;

            //招聘职位
            this.txtInputRECRUIT_POSITION.Text = entity.RECRUIT_POSITION;

            //if (entity.IS_NURSE == 1)
            //{
            //    this.rbInputISNURSE1.Checked = true;
            //    this.rbInputISNURSE2.Checked = false;
            //}
            //else
            //{
            //    this.rbInputISNURSE1.Checked = false;
            //    this.rbInputISNURSE2.Checked = true;
            //}
            ddlISNURSE.SelectedValue = entity.IS_NURSE.ToString();
            if (entity.IS_SEND == 1)
            {
                this.rbInputISSEND1.Checked = true;
                this.rbInputISSEND2.Checked = false;
            }
            else
            {
                this.rbInputISSEND1.Checked = false;
                this.rbInputISSEND2.Checked = true;
            }

            if (entity.IS_PUBLIC == 1)
            {
                this.rbInputISPUBLIC1.Checked = true;
                this.rbInputISPUBLIC2.Checked = false;
            }
            else
            {
                this.rbInputISPUBLIC1.Checked = false;
                this.rbInputISPUBLIC2.Checked = true;
            }

        }
    }
}
