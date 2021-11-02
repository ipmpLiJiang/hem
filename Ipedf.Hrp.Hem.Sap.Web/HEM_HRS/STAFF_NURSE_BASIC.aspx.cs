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
using System.IO;
using System.Text.RegularExpressions;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class STAFF_NURSE_BASIC : User_Page
    {
        private const decimal cIS_NURSE = 1;
        private bool IsMaster = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            //判断是否为硕士及以上学历
            txtIsMaster.Value = IsMaster.ToString();
            EntityObject_V_USER_LOGIN_INFO UserInfo1 = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
            DisplayObject_HEM_B_STAFF_TYPE[] displayNurse1 = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Query(new CauseObject_HEM_B_STAFF_TYPE() { USER_ID = UserInfo1.USER_ID });
            if (displayNurse1.Length > 0)
            {
                CauseObject_HEM_B_STAFF_EDUCATION cause = new CauseObject_HEM_B_STAFF_EDUCATION();
                cause.STAFF_ID = displayNurse1[0].STAFF_ID;
                DisplayObject_HEM_B_STAFF_EDUCATION[] hbe = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Query(cause);
                foreach (DisplayObject_HEM_B_STAFF_EDUCATION he in hbe)
                {
                    if (he.SLART == "10" || he.SLART == "11")
                    {
                        IsMaster = true;
                        txtIsMaster.Value = IsMaster.ToString();
                        break;
                    }
                }
            }

            if (ViewState["CUR_OBJ"] == null)
            {
                try
                {
                    if (!IsPostBack)
                    {
                        DdlBindData();
                    }
                    EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                    DisplayObject_HEM_B_STAFF_TYPE[] displayNurseAll = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Query(new CauseObject_HEM_B_STAFF_TYPE() { USER_ID = UserInfo.USER_ID });
                    if (displayNurseAll.Length > 0)
                    {
                        DisplayObject_HEM_B_STAFF_TYPE[] displayNurse = displayNurseAll.Where(p => p.IS_NURSE == cIS_NURSE).ToArray();
                        DisplayObject_V_HEM_B_STAFF displayVstaff = new DisplayObject_V_HEM_B_STAFF();
                        if (displayNurse.Length > 0)
                        {
                            displayVstaff = GetDisplayStaffType(displayNurse[0]);
                            if (displayVstaff != null)
                            {
                                lb_Look.Text = "<a href=\"" + UrlDetail(displayVstaff.STAFF_TYPE_ID) + "\" target=\"_blank\">浏览简历</a>";
                                GetEditEntity(displayVstaff);
                                ViewState["CUR_OBJ"] = displayVstaff;
                            }
                            else
                            {
                                displayVstaff = GetDisplayStaffType(displayNurseAll[0]);
                                displayVstaff.IS_NURSE = cIS_NURSE;
                                displayVstaff.TYPE_ID = "1003";
                                GetEditEntity(displayVstaff);

                                ViewState["CUR_OBJ"] = displayVstaff;
                            }
                        }
                        else
                        {
                            displayVstaff = GetDisplayStaffType(displayNurseAll[0]);
                            displayVstaff.IS_NURSE = cIS_NURSE;
                            displayVstaff.TYPE_ID = "1003";
                            displayVstaff.STAFF_TYPE_ID = "";
                            GetEditEntity(displayVstaff);
                            ViewState["CUR_OBJ"] = displayVstaff;
                        }

                        if (displayVstaff.TYPE_ID == "1003")
                        {
                            this.labZHRGZNX.Text = "三级甲等医院工作年限";
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").hide();</script>");
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml1", "<script>$(\"#divYJSSXXX\").hide();</script>");
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#spanZHRSXXX\").text(\"实习医院：\");</script>");
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml1", "<script>$(\"#divYJSSXXX\").hide();</script>");
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml2", "<script>$(\"#divZHRSXXX\").show();</script>");
                            this.labZHRGZNX.Text = "实习时长";
                            if (displayVstaff.TYPE_ID == "1002" && IsMaster)
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml3", "<script>$(\"#spanZHRSXXX\").text(\"本科实习医院：\");</script>");
                                ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml4", "<script>$(\"#divYJSSXXX\").show();</script>");
                            }
                        }
                    }
                    else
                    {
                        if (!IsPostBack)
                        {
                            LoadInit(UserInfo);
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public string UrlDetail(string ID)
        {
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
            parameters.Add("ID", ID);
            string url = WebControlHelper.EncodeUrl("RESUME_PREVIEW.aspx", parameters);
            return url;
        }

        private DisplayObject_V_HEM_B_STAFF GetDisplayStaffType(DisplayObject_HEM_B_STAFF_TYPE displayStaffType)
        {
            CauseObject_V_HEM_B_STAFF cause = new CauseObject_V_HEM_B_STAFF();
            cause.STAFF_TYPE_ID = displayStaffType.ID;
            DisplayObject_V_HEM_B_STAFF[] displayVstaff = BizLogicObject_V_HEM_B_STAFF.Proxy.Query(cause);
            if (displayVstaff.Length > 0)
            {
                return displayVstaff[0];
            }
            else
            {
                return new DisplayObject_V_HEM_B_STAFF();
            }
        }

        private void LoadInit(EntityObject_V_USER_LOGIN_INFO UserInfo)
        {
            this.txtInputNACHN.Text = UserInfo.NAME;
            this.txtInputUSRID_TEL.Text = UserInfo.MOBILE;
            this.txtInputUSRID_MAIL.Text = UserInfo.EMAIL;
            this.labZHRGZNX.Text = "三级甲等医院工作年限";
            this.txtInputZHRTZGG.Text = "0";

            foreach (ListItem d_item in this.ddlInputRACKY.Items)
            {
                if (d_item.Text == "汉族")
                {
                    this.ddlInputRACKY.Items.FindByText("汉族").Selected = true;
                }
            }

            foreach (ListItem d_item in this.ddlInputTYPE_ID.Items)
            {
                if (d_item.Text == "往届生")
                {
                    this.ddlInputTYPE_ID.Items.FindByText("往届生").Selected = true;
                }
            }

            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").hide();</script>");
            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml1", "<script>$(\"#divYJSSXXX\").hide();</script>");
        }

        public void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1001";
            //血型
            ddlInputZHRYRXX.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRYRXX.DataTextField = "NAME";
            ddlInputZHRYRXX.DataValueField = "CODE";
            ddlInputZHRYRXX.DataBind();
            ddlInputZHRYRXX.Items.Insert(0, new ListItem("--请选择--", ""));
            //民族 
            cause.PARENT_ID = "HEM_1008";
            ddlInputRACKY.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputRACKY.DataTextField = "NAME";
            ddlInputRACKY.DataValueField = "CODE";
            ddlInputRACKY.DataBind();
            ddlInputRACKY.Items.Insert(0, new ListItem("--请选择--", ""));
            //政治面貌
            cause.PARENT_ID = "HEM_1002";
            ddlInputPCODE.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPCODE.DataTextField = "NAME";
            ddlInputPCODE.DataValueField = "CODE";
            ddlInputPCODE.DataBind();
            ddlInputPCODE.Items.Insert(0, new ListItem("--请选择--", ""));

            //婚姻状况
            cause.PARENT_ID = "HEM_1009";
            ddlInputFAMST.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputFAMST.DataTextField = "NAME";
            ddlInputFAMST.DataValueField = "CODE";
            ddlInputFAMST.DataBind();
            ddlInputFAMST.Items.Insert(0, new ListItem("--请选择--", ""));

            //外语水平
            cause.PARENT_ID = "HEM_1003";
            ddlInputZHRWYSP.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRWYSP.DataTextField = "NAME";
            ddlInputZHRWYSP.DataValueField = "CODE";
            ddlInputZHRWYSP.DataBind();
            ddlInputZHRWYSP.Items.Insert(0, new ListItem("--请选择--", ""));

            //计算机水平
            cause.PARENT_ID = "HEM_1004";
            ddlInputZHRJSJSP.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRJSJSP.DataTextField = "NAME";
            ddlInputZHRJSJSP.DataValueField = "CODE";
            ddlInputZHRJSJSP.DataBind();
            ddlInputZHRJSJSP.Items.Insert(0, new ListItem("--请选择--", "0"));

            cause.PARENT_ID = "HEM_1012";
            cause.SetCustomCondition(" AND SYS_DATA_TYPE.CODE != '1004'");
            //护理类型
            ddlInputTYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputTYPE_ID.DataTextField = "NAME";
            ddlInputTYPE_ID.DataValueField = "CODE";
            ddlInputTYPE_ID.DataBind();
            ddlInputTYPE_ID.Items.Insert(0, new ListItem("--请选择--", ""));
        }

        private int IsStaffApplyN()
        {
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
            CauseObject_V_HEM_B_STAFF_APPLY_N cause = new CauseObject_V_HEM_B_STAFF_APPLY_N();
            cause.USER_ID = UserInfo.USER_ID;
            cause.IS_NURSE = cIS_NURSE;
            DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplay = BizLogicObject_V_HEM_B_STAFF_APPLY_N.Proxy.Query(cause);

            if (itemDisplay.Length > 0)
            {
                if (itemDisplay[0].EDUCATION_COUNT > 0)
                {
                    return 9;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

        protected void btn_SubmitCheck_Click(object sender, EventArgs e)
        {
            if (Session["UserLogin"] != null)
            {
                EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                BizLogicMsg msg = BizLogicObject_HEM_B_STAFF.Proxy.StaffSubmitOrCheck(UserInfo.USER_ID, cIS_NURSE);
                if (!string.IsNullOrEmpty(msg.Message))
                {
                    IsZhrSxxxShowOrHide();
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + msg.Message + "');</script>");
                }
                else
                {
                    IsZhrSxxxShowOrHide();
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('护理简历,提交成功!');</script>");
                }
            }
        }

        public void IsZhrSxxxShowOrHide()
        {
            if (this.ddlInputTYPE_ID.SelectedValue == "1003")
            {
                this.labZHRGZNX.Text = "三级甲等医院工作年限";
                ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").hide();</script>");
            }
            else
            {
                this.labZHRGZNX.Text = "实习时长";
                ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").show();</script>");
            }
        }

        protected void btn_SaveNext_Click(object sender, EventArgs e)
        {
            bool bl = SaveMethod();
            if (bl)
            {
                int n = IsStaffApplyN();
                if (n == 9)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_NURSE_EDUCATION.aspx';</script>");
                }
                else if (n == 1)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('教育信息为必填信息,请填写教育信息资料,确保申请的招聘职位申请成功!');location.href='STAFF_NURSE_EDUCATION.aspx';</script>");
                }
                else
                {
                    if (ViewState["CUR_OBJ"] != null)
                    {
                        DisplayObject_V_HEM_B_STAFF displayVstaff = ViewState["CUR_OBJ"] as DisplayObject_V_HEM_B_STAFF;
                        DisplayObject_HEM_B_STAFF_EDUCATION[] itemStaffEducation = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Query(
                            new CauseObject_HEM_B_STAFF_EDUCATION() { STAFF_ID = displayVstaff.ID }
                        );
                        if (itemStaffEducation.Length > 0)
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_NURSE_EDUCATION.aspx';</script>");
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功!(教育信息为必填信息,请完善教育信息资料!)');location.href='STAFF_NURSE_EDUCATION.aspx';</script>");
                        }
                    }
                }
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            bool bl = SaveMethod();
            if (bl)
            {
                int n = IsStaffApplyN();
                if (n == 9)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!');</script>");
                }
                else if (n == 1)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!(教育信息为必填信息,请填写教育信息资料,确保申请的招聘职位申请成功!)');</script>");
                }
                else
                {
                    if (ViewState["CUR_OBJ"] != null)
                    {
                        DisplayObject_V_HEM_B_STAFF displayVstaff = ViewState["CUR_OBJ"] as DisplayObject_V_HEM_B_STAFF;
                        DisplayObject_HEM_B_STAFF_EDUCATION[] itemStaffEducation = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Query(
                            new CauseObject_HEM_B_STAFF_EDUCATION() { STAFF_ID = displayVstaff.ID }
                        );
                        if (itemStaffEducation.Length > 0)
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!');</script>");
                           
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('保存成功,完善/修改简历后请提交简历!(教育信息为必填信息,请完善教育信息资料!)');</script>");
                         
                        }
                    }
                }
                EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
                BizLogicMsg msg1 = BizLogicObject_HEM_B_STAFF.Proxy.StaffSubmitOrCheckNoMessage(UserInfo.USER_ID, cIS_NURSE);
            }
        }

        private bool ValidataBool(DisplayObject_V_HEM_B_STAFF entity)
        {
            bool returnBool = true;
            //姓名
            if (string.IsNullOrEmpty(entity.NACHN))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "姓名不能为空！";
                //WebControlHelper.ShowAlert(null, "姓名不能为空！");
                return false;
            }

            //性别
            if (string.IsNullOrEmpty(entity.GESCH))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "未选择性别！";
                //WebControlHelper.ShowAlert(null, "未选择性别！");
                return false;
            }

            //出生日期
            if (string.IsNullOrEmpty(entity.GBDAT.ToString()))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "出生日期不能为空！";
                //WebControlHelper.ShowAlert(null, "出生日期不能为空！");
                return false;
            }
            else
            {
                if (entity.GBDAT > DateTime.Now)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "出生日期无效！";
                    return false;
                }
            }

            if (entity.FGBDT > DateTime.Now)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "紧急联系人出生日期无效！";
                return false;
            }

            //身份证号
            if (string.IsNullOrEmpty(entity.ICNUM))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "身份证号不能为空！";
                //WebControlHelper.ShowAlert(null, "身份证号不能为空！");
                return false;
            }

            //籍贯
            if (string.IsNullOrEmpty(entity.ZHRJG))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "籍贯不能为空！";
                //WebControlHelper.ShowAlert(null, "籍贯不能为空！");
                return false;
            }

            //健康状况
            if (string.IsNullOrEmpty(entity.ZHRJKZK))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "健康状况不能为空！";
                //WebControlHelper.ShowAlert(null, "健康状况不能为空！");
                return false;
            }

            //民族
            if (string.IsNullOrEmpty(entity.RACKY))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "未选择民族！";
                //WebControlHelper.ShowAlert(null, "未选择民族！");
                return false;
            }

            //政治面貌
            if (string.IsNullOrEmpty(entity.PCODE))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "未选择政治面貌！";
                //WebControlHelper.ShowAlert(null, "未选择政治面貌！");
                return false;
            }

            //婚姻状况
            if (string.IsNullOrEmpty(entity.FAMST))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "未选择婚姻状况！";
                //WebControlHelper.ShowAlert(null, "未选择婚姻状况！");
                return false;
            }

            //统招高考成绩
            if (string.IsNullOrEmpty(entity.ZHRTZGG))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "未输入统招高考成绩！";
                //WebControlHelper.ShowAlert(null, "未输入统招高考成绩！");
                return false;
            }

            //子女个数
            //if (string.IsNullOrEmpty(entity.ANZKD.ToString()))
            //{
            //    lbl_Error.Visible = true;
            //    lbl_Error.Text = "子女个数不能为空！";
            //    //WebControlHelper.ShowAlert(null, "子女个数不能为空！");
            //    return false;
            //}

            //手机号码
            //if (string.IsNullOrEmpty(entity.USRID_TEL))
            //{
            //    lbl_Error.Visible = true;
            //    lbl_Error.Text = "手机号码不能为空！";
            //    //WebControlHelper.ShowAlert(null, "手机号码不能为空！");
            //    return false;
            //}

            //电子信箱
            if (string.IsNullOrEmpty(entity.USRID_MAIL))
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "电子信箱不能为空！";
                //WebControlHelper.ShowAlert(null, "电子信箱不能为空！");
                return false;
            }

            //实习时长或三级甲等工作年限
            if (string.IsNullOrEmpty(entity.ZHRGZNX))
            {
                lbl_Error.Visible = true;
                if (this.ddlInputTYPE_ID.SelectedValue == "1003")
                {
                    lbl_Error.Text = "请输入三级甲等工作年限！";
                }
                else
                {
                    lbl_Error.Text = "请输入实习时长！";
                }
                return false;
            }

            if (!string.IsNullOrEmpty(entity.ZHRHJJL))
            {
                if (entity.ZHRHJJL.Length > 200)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "获奖经历输入的长度不能超过200个字！";
                    return false;
                }
            }


            if (!string.IsNullOrEmpty(entity.ZHRTC))
            {
                if (entity.ZHRTC.Length > 200)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "特长输入的长度不能超过200个字！";
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(entity.ZHRBZ))
            {
                if (entity.ZHRBZ.Length > 200)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "备注输入的长度不能超过200个字！";
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(entity.ZHRZWJS))
            {
                if (entity.ZHRZWJS.Length > 400)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "自我介绍输入的长度不能超过400个字！";
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(entity.FANAM))
            {
                if (entity.FGBDT == Ipedf.Common.Template.UndefineDatetime || string.IsNullOrEmpty(entity.FGBDT.ToString()))
                {
                    lbl_FGBDT.Visible = true;
                    returnBool = false;
                }

                if (string.IsNullOrEmpty(entity.TELNR))
                {
                    lbl_TELNR.Visible = true;
                    returnBool = false;
                }

                if (string.IsNullOrEmpty(entity.FASEX))
                {
                    lbl_FASEX.Visible = true;
                    returnBool = false;
                }
            }
            else
            {
                if (entity.FGBDT != Ipedf.Common.Template.UndefineDatetime && !string.IsNullOrEmpty(entity.FGBDT.ToString()))
                {
                    lbl_FANAM.Visible = true;

                    if (string.IsNullOrEmpty(entity.TELNR))
                    {
                        lbl_TELNR.Visible = true;
                    }

                    if (string.IsNullOrEmpty(entity.FASEX))
                    {
                        lbl_FASEX.Visible = true;
                    }
                    returnBool = false;
                }

                if (!string.IsNullOrEmpty(entity.TELNR))
                {
                    lbl_FANAM.Visible = true;
                    if (entity.FGBDT == Ipedf.Common.Template.UndefineDatetime || string.IsNullOrEmpty(entity.FGBDT.ToString()))
                    {
                        lbl_FGBDT.Visible = true;
                    }

                    if (string.IsNullOrEmpty(entity.FASEX))
                    {
                        lbl_FASEX.Visible = true;
                    }
                    returnBool = false;
                }

                if (!string.IsNullOrEmpty(entity.FASEX))
                {
                    lbl_FANAM.Visible = true;
                    if (entity.FGBDT == Ipedf.Common.Template.UndefineDatetime || string.IsNullOrEmpty(entity.FGBDT.ToString()))
                    {
                        lbl_FGBDT.Visible = true;
                    }

                    if (string.IsNullOrEmpty(entity.TELNR))
                    {
                        lbl_TELNR.Visible = true;
                    }
                    returnBool = false;
                }
            }

            if (entity.TYPE_ID == "1001" || entity.TYPE_ID == "1002")
            {
                this.labZHRGZNX.Text = "实习时长";

                if (string.IsNullOrEmpty(entity.ZHRSXXX))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#ctl00_ContentPlaceHolder1_lbl_ZHRSXXX\").show();</script>");
                    if (entity.TYPE_ID == "1002" && IsMaster)
                    {
                        if (string.IsNullOrEmpty(entity.YJSSXXX))
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml5", "<script>$(\"#ctl00_ContentPlaceHolder1_lbl_YJSSXXX\").show();</script>");
                            return false;
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml5", "<script>$(\"#ctl00_ContentPlaceHolder1_lbl_YJSSXXX\").hide();</script>");
                        }
                    }
                    return false;
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#ctl00_ContentPlaceHolder1_lbl_ZHRSXXX\").hide();</script>");
                }
                if (entity.TYPE_ID == "1002" && IsMaster)
                {
                    if (string.IsNullOrEmpty(entity.YJSSXXX))
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml5", "<script>$(\"#ctl00_ContentPlaceHolder1_lbl_YJSSXXX\").show();</script>");
                        return false;
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml5", "<script>$(\"#ctl00_ContentPlaceHolder1_lbl_YJSSXXX\").hide();</script>");
                    }
                }
            }
            else
            {
                this.labZHRGZNX.Text = "三级甲等医院工作年限";
            }

            if (!string.IsNullOrEmpty(entity.ZHRGRSG))
            {
                bool bl = CheckZHRGRSG(entity.ZHRGRSG);
                if (!bl)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "身 高(CM)输入格式有误,请输入正确的正整数!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(entity.ZHRGRTZ))
            {
                bool bl = CheckZHRGRTZ_Or_SLJZ(entity.ZHRGRTZ);
                if (!bl)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "体重(KG)输入格式有误,请输入正确的小数!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(entity.ZHRSLJZ))
            {
                bool bl = CheckZHRGRTZ_Or_SLJZ(entity.ZHRSLJZ);
                if (!bl)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "视力(1.0)输入格式有误,请输入正确的小数!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(entity.ZHRTZGG))
            {
                bool bl = CheckZHRTZGG(entity.ZHRTZGG);
                if (!bl)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "统招高考成绩输入格式有误,请输入正确的数字(零或正整数)!";
                    return false;
                }
            }

            return returnBool;
        }

        public bool CheckZHRGRSG(string str)
        {
            bool bl = Regex.IsMatch(str, @"^\+?[1-9][0-9]*$");
            return bl;
        }

        public bool CheckZHRGRTZ_Or_SLJZ(string str)
        {
            bool bl = Regex.IsMatch(str, @"^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$");
            return bl;
        }

        public bool CheckZHRTZGG(string str)
        {
            bool bl = Regex.IsMatch(str, @"^(0|[1-9]\d*)$");
            return bl;
        }

        private bool SaveMethod()
        {
            //lbl_ulmsg.Text = "";
            bool IsTrturn = false;
            lbl_FGBDT.Visible = false;
            lbl_TELNR.Visible = false;
            lbl_FANAM.Visible = false;
            lbl_FASEX.Visible = false;
            lbl_Error.Text = "";
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;

            if (ViewState["CUR_OBJ"] == null)
            {
                DisplayObject_V_HEM_B_STAFF displayVstaff = new DisplayObject_V_HEM_B_STAFF();

                object[] arrEntity = SetEditEntity(displayVstaff);
                EntityObject_HEM_B_STAFF entity = arrEntity[0] as EntityObject_HEM_B_STAFF;
                displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;

                object[] arrEntity1 = SetEditTypeEntity(displayVstaff);
                EntityObject_HEM_B_STAFF_TYPE entityNurse = arrEntity1[0] as EntityObject_HEM_B_STAFF_TYPE;
                displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;

                entity.USER_ID = UserInfo.USER_ID;
                displayVstaff.USER_ID = UserInfo.USER_ID;
                entityNurse.USER_ID = entity.USER_ID;
                entityNurse.IS_CERTIFICATE = displayVstaff.IS_CERTIFICATE;

                bool vBool = ValidataBool(displayVstaff);

                if (!vBool) { return false; }

                CauseObject_HEM_B_STAFF causeSF = new CauseObject_HEM_B_STAFF();
                causeSF.ICNUM = entity.ICNUM;

                if (IsExistICNUM(causeSF))
                {
                    entityNurse.IS_ACTION = 1;
                    BizLogicMsg msg = BizLogicObject_HEM_B_STAFF.Proxy.Save(entity, entityNurse);
                    IsTrturn = msg.Succeed;

                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        displayVstaff.STAFF_TYPE_ID = entityNurse.ID;
                        displayVstaff.ID = entity.ID;
                        ViewState["CUR_OBJ"] = displayVstaff;
                        //WebControlHelper.ShowAlert(null, "保存成功！");
                        lbl_Error.Visible = false;
                        lbl_Error.Text = "";

                        string sfile = "*.DOC||*.DOCX";
                        string extension = "";
                        string saveAsFileName = "";
                        //System.IO.FileInfo finfo = new FileInfo(fu_load.PostedFile.FileName);
                        if (fu_load.PostedFile != null)
                        {
                            if (!string.IsNullOrEmpty(fu_load.PostedFile.FileName))
                            {
                                EntityObject_HEM_B_STAFF_TYPE entityNurse1 = new EntityObject_HEM_B_STAFF_TYPE();
                                entityNurse1.ID = displayVstaff.STAFF_TYPE_ID;
                                string filelastname = fu_load.FileName.Substring(fu_load.FileName.LastIndexOf("."));
                                extension = System.IO.Path.GetExtension(fu_load.FileName).ToLower();
                                if (!sfile.Contains(filelastname.ToUpper()))
                                {
                                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('请上传Word文件!');</script>");
                                }
                                else
                                {
                                    if (fu_load.PostedFile.ContentLength > 5120000)
                                    {
                                        ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('文件仅限5M以下');</script>");
                                        //WebControlHelper.ShowAlert(this, "文件仅限5M以下！");
                                    }
                                    else
                                    {
                                        //上传文件到本地服务器
                                        string fileUrl = "doc/attached";
                                        string strDate = DateTime.Now.ToString("yyMMddHHmmss");
                                        string strFileName = this.fu_load.FileName.Substring(0, (fu_load.FileName.Length - extension.Length));

                                        saveAsFileName = strFileName.Trim() + strDate + extension;
                                        try
                                        {
                                            if (Directory.Exists(Server.MapPath("~/" + fileUrl)) == false)//如果不存在就创建文件夹
                                            {
                                                Directory.CreateDirectory(Server.MapPath("~/" + fileUrl));
                                            }

                                            if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                            {
                                                File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                                //Msg("文件名重复，请修改后再上传！");
                                                //return ;
                                            }

                                            string excelServerURL = MapPath("~/" + fileUrl + "/") + saveAsFileName;
                                            fu_load.SaveAs(excelServerURL);


                                            if (File.Exists(Server.MapPath("~/" + entityNurse1.FILE_PATH)))
                                            {
                                                File.Delete(Server.MapPath("~/" + entityNurse1.FILE_PATH));
                                            }
                                            entityNurse1.FILE_PATH = fileUrl + "/" + saveAsFileName;
                                            entityNurse1.SetUpdate("FILE_PATH");
                                            BizLogicMsg msg1 = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(entityNurse1);
                                            if (!msg1.Succeed)
                                            {
                                                lbl_Error.Visible = true;
                                                lbl_Error.Text = msg.Message;
                                            }
                                            else
                                            {
                                                fu_load.Visible = false;
                                                btn_delete.Visible = true;
                                                //lbl_ulmsg.Text = "上传成功！";
                                                lbl_FILE_PATH.Text = "<a href='../" + entityNurse.FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
                                                //ViewState["CUR_OBJ"] = curObj;
                                                //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('上传成功,完善/修改简历后请提交简历!');</script>");
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                            {
                                                File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                            }
                                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('上传的Word文件异常错误,请联系管理员！');</script>");
                                            //WebControlHelper.ShowAlert(this, "上传的Word文件异常错误,请联系管理员！");
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "身份证号已存在，请确认是否已注册过账户!";
                }

                if (entityNurse.TYPE_ID.Trim() == "1003")
                {
                    this.labZHRGZNX.Text = "三级甲等医院工作年限";
                    ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").hide();</script>");
                }
                else
                {
                    this.labZHRGZNX.Text = "实习时长";
                    ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").show();</script>");
                }
            }
            else
            {
                DisplayObject_V_HEM_B_STAFF displayVstaff = ViewState["CUR_OBJ"] as DisplayObject_V_HEM_B_STAFF;

                object[] arrEntity = SetEditEntity(displayVstaff);
                EntityObject_HEM_B_STAFF curObj = arrEntity[0] as EntityObject_HEM_B_STAFF;
                displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;

                object[] arrEntity1 = SetEditTypeEntity(displayVstaff);
                EntityObject_HEM_B_STAFF_TYPE entityNurse = arrEntity1[0] as EntityObject_HEM_B_STAFF_TYPE;
                displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;

                curObj.USER_ID = UserInfo.USER_ID;
                displayVstaff.USER_ID = UserInfo.USER_ID;
                entityNurse.USER_ID = curObj.USER_ID;
                entityNurse.ID = displayVstaff.STAFF_TYPE_ID;
                entityNurse.IS_CERTIFICATE = displayVstaff.IS_CERTIFICATE;
                curObj.ID = displayVstaff.ID;
                entityNurse.STAFF_ID = curObj.ID;

                bool vBool = ValidataBool(displayVstaff);
                if (!vBool) { return false; }

                CauseObject_HEM_B_STAFF causeSF = new CauseObject_HEM_B_STAFF();
                causeSF.ICNUM = curObj.ICNUM;
                causeSF.SetCustomCondition(" AND HEM_B_STAFF.ID !='" + curObj.ID + "'");
                if (IsExistICNUM(causeSF))
                {
                    curObj.USER_ID = displayVstaff.USER_ID;
                    //ZHRSXXX
                    curObj.SetNotUpdate("USER_ID", "NACHN", "SECONDCHOICE", "FIRSTCHOICE", "USRID_TEL", "USRID_MAIL");
                    BizLogicMsg msg = BizLogicObject_HEM_B_STAFF.Proxy.Update(curObj, entityNurse);
                    IsTrturn = msg.Succeed;
                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        string sfile = "*.DOC||*.DOCX";
                        string extension = "";
                        string saveAsFileName = "";
                        //System.IO.FileInfo finfo = new FileInfo(fu_load.PostedFile.FileName);
                        if (fu_load.PostedFile != null)
                        {
                            if (!string.IsNullOrEmpty(fu_load.PostedFile.FileName))
                            {
                                EntityObject_HEM_B_STAFF_TYPE entityNurse1 = new EntityObject_HEM_B_STAFF_TYPE();
                                entityNurse1.ID = displayVstaff.STAFF_TYPE_ID;
                                string filelastname = fu_load.FileName.Substring(fu_load.FileName.LastIndexOf("."));
                                extension = System.IO.Path.GetExtension(fu_load.FileName).ToLower();
                                if (!sfile.Contains(filelastname.ToUpper()))
                                {
                                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('请上传Word文件!');</script>");
                                }
                                else
                                {
                                    if (fu_load.PostedFile.ContentLength > 5120000)
                                    {
                                        ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('文件仅限5M以下');</script>");
                                        //WebControlHelper.ShowAlert(this, "文件仅限5M以下！");
                                    }
                                    else
                                    {
                                        //上传文件到本地服务器
                                        string fileUrl = "doc/attached";
                                        string strDate = DateTime.Now.ToString("yyMMddHHmmss");
                                        string strFileName = this.fu_load.FileName.Substring(0, (fu_load.FileName.Length - extension.Length));

                                        saveAsFileName = strFileName.Trim() + strDate + extension;
                                        try
                                        {
                                            if (Directory.Exists(Server.MapPath("~/" + fileUrl)) == false)//如果不存在就创建文件夹
                                            {
                                                Directory.CreateDirectory(Server.MapPath("~/" + fileUrl));
                                            }

                                            if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                            {
                                                File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                                //Msg("文件名重复，请修改后再上传！");
                                                //return ;
                                            }

                                            string excelServerURL = MapPath("~/" + fileUrl + "/") + saveAsFileName;
                                            fu_load.SaveAs(excelServerURL);


                                            if (File.Exists(Server.MapPath("~/" + entityNurse1.FILE_PATH)))
                                            {
                                                File.Delete(Server.MapPath("~/" + entityNurse1.FILE_PATH));
                                            }
                                            entityNurse1.FILE_PATH = fileUrl + "/" + saveAsFileName;
                                            entityNurse1.SetUpdate("FILE_PATH");
                                            BizLogicMsg msg1 = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(entityNurse1);
                                            if (!msg1.Succeed)
                                            {
                                                lbl_Error.Visible = true;
                                                lbl_Error.Text = msg.Message;
                                            }
                                            else
                                            {
                                                fu_load.Visible = false;
                                                btn_delete.Visible = true;
                                                //lbl_ulmsg.Text = "上传成功！";
                                                lbl_FILE_PATH.Text = "<a href='../" + entityNurse1.FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
                                                //ViewState["CUR_OBJ"] = curObj;
                                                //ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('上传成功,完善/修改简历后请提交简历!');</script>");
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                            {
                                                File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                            }
                                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('上传的Word文件异常错误,请联系管理员！');</script>");
                                            //WebControlHelper.ShowAlert(this, "上传的Word文件异常错误,请联系管理员！");
                                        }

                                    }
                                }
                            }
                        }
                        if (string.IsNullOrEmpty(displayVstaff.STAFF_TYPE_ID))
                        {
                            displayVstaff.STAFF_TYPE_ID = entityNurse.ID;
                        }
                        ViewState["CUR_OBJ"] = displayVstaff;

                        //WebControlHelper.ShowAlert(null, "保存成功！");
                        lbl_Error.Visible = false;
                        lbl_Error.Text = "";
                    }
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "身份证号已存在，请确认是否已注册过账户!";
                }

                if (entityNurse.TYPE_ID.Trim() == "1003")
                {
                    this.labZHRGZNX.Text = "三级甲等医院工作年限";
                    ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").hide();</script>");
                }
                else
                {
                    this.labZHRGZNX.Text = "实习时长";
                    ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\"#divZHRSXXX\").show();</script>");
                }

            }

            return IsTrturn;
        }

        public bool IsExistICNUM(CauseObject_HEM_B_STAFF cuase)
        {
            DisplayObject_HEM_B_STAFF[] itemStaff = BizLogicObject_HEM_B_STAFF.Proxy.Query(cuase);
            return itemStaff.Length > 0 ? false : true;
        }

        protected object[] SetEditTypeEntity(DisplayObject_V_HEM_B_STAFF displayVstaff)
        {
            object[] arrEntity = new object[2];
            EntityObject_HEM_B_STAFF_TYPE entity = new EntityObject_HEM_B_STAFF_TYPE();
            //护理类型
            if (!string.IsNullOrEmpty(this.ddlInputTYPE_ID.SelectedValue))
            {
                entity.TYPE_ID = this.ddlInputTYPE_ID.SelectedValue;
            }
            else
            {
                entity.TYPE_ID = "";
            }

            displayVstaff.TYPE_ID = entity.TYPE_ID;
            displayVstaff.IS_NURSE = cIS_NURSE;
            entity.IS_NURSE = cIS_NURSE;

            arrEntity[0] = entity;
            arrEntity[1] = displayVstaff;
            return arrEntity;
        }

        protected object[] SetEditEntity(DisplayObject_V_HEM_B_STAFF displayVstaff)
        {
            object[] arrEntity = new object[2];
            EntityObject_HEM_B_STAFF entity = new EntityObject_HEM_B_STAFF();
            //姓名
            if (!string.IsNullOrEmpty(this.txtInputNACHN.Text))
            {
                entity.NACHN = this.txtInputNACHN.Text.Trim();
            }
            else
            {
                entity.NACHN = "";
            }

            displayVstaff.NACHN = entity.NACHN;

            //性别
            if (!string.IsNullOrEmpty(this.ddlInputGESCH.SelectedValue))
            {
                entity.GESCH = this.ddlInputGESCH.SelectedValue;
            }
            else
            {
                entity.GESCH = "";
            }

            displayVstaff.GESCH = entity.GESCH;

            //出生日期
            if (!string.IsNullOrEmpty(this.txtInputGBDAT.Text))
            {
                entity.GBDAT = DateTime.Parse(this.txtInputGBDAT.Text);
            }
            else
            {
                entity.GBDAT = Ipedf.Common.Template.UndefineDatetime;
            }

            displayVstaff.GBDAT = entity.GBDAT;

            //身份证号
            if (!string.IsNullOrEmpty(this.txtInputICNUM.Text))
            {
                entity.ICNUM = this.txtInputICNUM.Text.Trim();
            }
            else
            {
                entity.ICNUM = "";
            }

            displayVstaff.ICNUM = entity.ICNUM;

            //籍贯
            if (!string.IsNullOrEmpty(this.txtInputZHRJG.Text))
            {
                entity.ZHRJG = this.txtInputZHRJG.Text.Trim();
            }
            else
            {
                entity.ZHRJG = "";
            }

            displayVstaff.ZHRJG = entity.ZHRJG;

            //身高(CM)
            if (!string.IsNullOrEmpty(this.txtInputZHRGRSG.Text))
            {
                entity.ZHRGRSG = this.txtInputZHRGRSG.Text.Trim();
            }
            else
            {
                entity.ZHRGRSG = "";
            }

            displayVstaff.ZHRGRSG = entity.ZHRGRSG;

            //体重(斤)
            if (!string.IsNullOrEmpty(this.txtInputZHRGRTZ.Text))
            {
                entity.ZHRGRTZ = this.txtInputZHRGRTZ.Text.Trim();
            }
            else
            {
                entity.ZHRGRTZ = "";
            }

            displayVstaff.ZHRGRTZ = entity.ZHRGRTZ;

            //健康状况
            if (!string.IsNullOrEmpty(this.txtInputZHRJKZK.Text))
            {
                entity.ZHRJKZK = this.txtInputZHRJKZK.Text.Trim();
            }
            else
            {
                entity.ZHRJKZK = "";
            }

            displayVstaff.ZHRJKZK = entity.ZHRJKZK;

            //血型
            if (!string.IsNullOrEmpty(this.ddlInputZHRYRXX.SelectedValue))
            {
                entity.ZHRYRXX = this.ddlInputZHRYRXX.SelectedValue;
            }
            else
            {
                entity.ZHRYRXX = "";
            }

            displayVstaff.ZHRYRXX = entity.ZHRYRXX;

            //民族
            if (!string.IsNullOrEmpty(this.ddlInputRACKY.SelectedValue))
            {
                entity.RACKY = this.ddlInputRACKY.SelectedValue;
            }
            else
            {
                entity.RACKY = "";
            }

            displayVstaff.RACKY = entity.RACKY;

            //是否服从调剂
            if (!string.IsNullOrEmpty(this.ddlInputZHRFZDJ.SelectedValue))
            {
                entity.ZHRFZDJ = this.ddlInputZHRFZDJ.SelectedValue;
            }
            else
            {
                entity.ZHRFZDJ = "";
            }

            displayVstaff.ZHRFZDJ = entity.ZHRFZDJ;

            //政治面貌
            if (!string.IsNullOrEmpty(this.ddlInputPCODE.SelectedValue))
            {
                entity.PCODE = this.ddlInputPCODE.SelectedValue;
            }
            else
            {
                entity.PCODE = "";
            }

            displayVstaff.PCODE = entity.PCODE;

            //婚姻状况
            if (!string.IsNullOrEmpty(this.ddlInputFAMST.SelectedValue))
            {
                entity.FAMST = this.ddlInputFAMST.SelectedValue;
            }
            else
            {
                entity.FAMST = "";
            }

            displayVstaff.FAMST = entity.FAMST;

            //子女个数
            if (!string.IsNullOrEmpty(this.txtInputANZKD.Text))
            {
                entity.ANZKD = decimal.Parse(this.txtInputANZKD.Text.Trim());
            }
            else
            {
                entity.ANZKD = 0;
            }

            displayVstaff.ANZKD = entity.ANZKD;

            //外语水平
            if (!string.IsNullOrEmpty(this.ddlInputZHRWYSP.SelectedValue))
            {
                entity.ZHRWYSP = this.ddlInputZHRWYSP.SelectedValue;
            }
            else
            {
                entity.ZHRWYSP = "";
            }

            displayVstaff.ZHRWYSP = entity.ZHRWYSP;

            //外语水平分数
            if (!string.IsNullOrEmpty(this.txtInputZHRWYFS.Text))
            {
                entity.ZHRWYFS = this.txtInputZHRWYFS.Text.Trim();
            }
            else
            {
                entity.ZHRWYFS = "";
            }

            displayVstaff.ZHRWYFS = entity.ZHRWYFS;

            //计算机水平
            if (!string.IsNullOrEmpty(this.ddlInputZHRJSJSP.SelectedValue))
            {
                entity.ZHRJSJSP = this.ddlInputZHRJSJSP.SelectedValue;
            }
            else
            {
                entity.ZHRJSJSP = "";
            }

            displayVstaff.ZHRJSJSP = entity.ZHRJSJSP;

            //手机号码
            if (!string.IsNullOrEmpty(this.txtInputUSRID_TEL.Text))
            {
                entity.USRID_TEL = this.txtInputUSRID_TEL.Text.Trim();
            }
            else
            {
                entity.USRID_TEL = "";
            }

            displayVstaff.USRID_TEL = entity.USRID_TEL;

            //家庭住址
            if (!string.IsNullOrEmpty(this.txtInputLOCAT_JT.Text))
            {
                entity.LOCAT_JT = this.txtInputLOCAT_JT.Text.Trim();
            }
            else
            {
                entity.LOCAT_JT = "";
            }

            displayVstaff.LOCAT_JT = entity.LOCAT_JT;

            //户籍地址
            if (!string.IsNullOrEmpty(this.txtInputLOCAT_HJ.Text))
            {
                entity.LOCAT_HJ = this.txtInputLOCAT_HJ.Text.Trim();
            }
            else
            {
                entity.LOCAT_HJ = "";
            }

            displayVstaff.LOCAT_HJ = entity.LOCAT_HJ;

            //现居住地
            if (!string.IsNullOrEmpty(this.txtInputLOCAT_XJ.Text))
            {
                entity.LOCAT_XJ = this.txtInputLOCAT_XJ.Text.Trim();
            }
            else
            {
                entity.LOCAT_XJ = "";
            }

            displayVstaff.LOCAT_XJ = entity.LOCAT_XJ;

            //紧急联络人
            if (!string.IsNullOrEmpty(this.txtInputFANAM.Text))
            {
                entity.FANAM = this.txtInputFANAM.Text.Trim();
            }
            else
            {
                entity.FANAM = "";
            }

            displayVstaff.FANAM = entity.FANAM;

            //紧急联络人性别
            if (!string.IsNullOrEmpty(this.ddlInputFASEX.SelectedValue))
            {
                entity.FASEX = this.ddlInputFASEX.SelectedValue;
            }
            else
            {
                entity.FASEX = "";
            }

            displayVstaff.FASEX = entity.FASEX;

            //紧急联络人出生日期
            if (!string.IsNullOrEmpty(this.txtInputFGBDT.Text))
            {
                entity.FGBDT = DateTime.Parse(this.txtInputFGBDT.Text);
            }
            else
            {
                entity.FGBDT = Ipedf.Common.Template.UndefineDatetime;
            }

            displayVstaff.FGBDT = entity.FGBDT;

            //紧急联络人联系方式
            if (!string.IsNullOrEmpty(this.txtInputTELNR.Text))
            {
                entity.TELNR = this.txtInputTELNR.Text.Trim();
            }
            else
            {
                entity.TELNR = "";
            }

            displayVstaff.TELNR = entity.TELNR;

            //电子信箱
            if (!string.IsNullOrEmpty(this.txtInputUSRID_MAIL.Text))
            {
                entity.USRID_MAIL = this.txtInputUSRID_MAIL.Text.Trim();
            }
            else
            {
                entity.USRID_MAIL = "";
            }

            displayVstaff.USRID_MAIL = entity.USRID_MAIL;
            //电子信箱
            if (!string.IsNullOrEmpty(this.txtInputJWBS.Text))
            {
                entity.JWBS = this.txtInputJWBS.Text.Trim();
            }
            else
            {
                entity.JWBS = "";
            }

            displayVstaff.JWBS = entity.JWBS;

            //自我介绍
            if (!string.IsNullOrEmpty(this.txtInputZHRZWJS.Text))
            {
                entity.ZHRZWJS = this.txtInputZHRZWJS.Text.Trim();
            }
            else
            {
                entity.ZHRZWJS = "";
            }

            displayVstaff.ZHRZWJS = entity.ZHRZWJS;

            //视力/矫正视力
            if (!string.IsNullOrEmpty(this.txtInputZHRSLJZ.Text))
            {
                entity.ZHRSLJZ = this.txtInputZHRSLJZ.Text.Trim();
            }
            else
            {
                entity.ZHRSLJZ = "";
            }

            displayVstaff.ZHRSLJZ = entity.ZHRSLJZ;

            //统招高考成绩
            if (!string.IsNullOrEmpty(this.txtInputZHRTZGG.Text))
            {

                entity.ZHRTZGG = this.txtInputZHRTZGG.Text.Trim();
            }
            else
            {
                entity.ZHRTZGG = "";
            }

            displayVstaff.ZHRTZGG = entity.ZHRTZGG;

            //特长
            if (!string.IsNullOrEmpty(this.txtInputZHRTC.Text))
            {
                entity.ZHRTC = this.txtInputZHRTC.Text.Trim();
            }
            else
            {
                entity.ZHRTC = "";
            }

            displayVstaff.ZHRTC = entity.ZHRTC;

            //获奖经历
            if (!string.IsNullOrEmpty(this.txtInputZHRHJJL.Text))
            {
                entity.ZHRHJJL = this.txtInputZHRHJJL.Text.Trim();
            }
            else
            {
                entity.ZHRHJJL = "";
            }

            displayVstaff.ZHRHJJL = entity.ZHRHJJL;

            //备注
            if (!string.IsNullOrEmpty(this.txtInputZHRBZ.Text))
            {

                entity.ZHRBZ = this.txtInputZHRBZ.Text.Trim();
            }
            else
            {
                entity.ZHRBZ = "";
            }

            displayVstaff.ZHRBZ = entity.ZHRBZ;

            //三级甲等医院工作年限、实习时长
            if (!string.IsNullOrEmpty(this.txtInputZHRGZNX.Text))
            {

                entity.ZHRGZNX = this.txtInputZHRGZNX.Text.Trim();
            }
            else
            {
                entity.ZHRGZNX = "";
            }

            displayVstaff.ZHRGZNX = entity.ZHRGZNX;

            if (this.ckInputIS_CERTIFICATE.Checked == true)
            {
                displayVstaff.IS_CERTIFICATE = 1;
            }
            else
            {
                displayVstaff.IS_CERTIFICATE = 2;
            }

            ////实习学校
            if (!string.IsNullOrEmpty(this.txtInputZHRSXXX.Text))
            {
                entity.ZHRSXXX = this.txtInputZHRSXXX.Text.Trim();
            }
            else
            {
                entity.ZHRSXXX = "";
            }

            displayVstaff.ZHRSXXX = entity.ZHRSXXX;

            ////研究生实习学校
            if (!string.IsNullOrEmpty(this.txtInputYJSSXXX.Text))
            {
                entity.YJSSXXX = this.txtInputYJSSXXX.Text.Trim();
            }
            else
            {
                entity.YJSSXXX = "";
            }
            displayVstaff.YJSSXXX = entity.YJSSXXX;

            arrEntity[0] = entity;
            arrEntity[1] = displayVstaff;
            return arrEntity;
        }

        protected void GetEditEntity(DisplayObject_V_HEM_B_STAFF entity)
        {
            //姓名
            if (!string.IsNullOrEmpty(entity.NACHN))
            {
                this.txtInputNACHN.Text = entity.NACHN.Trim();
            }
            //性别
            if (!string.IsNullOrEmpty(entity.GESCH))
            {
                this.ddlInputGESCH.Items.FindByValue(entity.GESCH.Trim()).Selected = true;
            }
            //出生日期
            if (entity.GBDAT != null)
            {
                if (!string.IsNullOrEmpty(entity.GBDAT.ToString()))
                {
                    this.txtInputGBDAT.Text = entity.GBDAT == null ? string.Empty : entity.GBDAT.ToString("yyyy-MM-dd").Trim();
                    if (this.txtInputGBDAT.Text == "0001-01-01")
                    {
                        this.txtInputGBDAT.Text = "";
                    }
                }
            }
            //身份证号
            if (!string.IsNullOrEmpty(entity.ICNUM))
            {
                this.txtInputICNUM.Text = entity.ICNUM.Trim();
            }
            //籍贯
            if (!string.IsNullOrEmpty(entity.ZHRJG))
            {
                this.txtInputZHRJG.Text = entity.ZHRJG.Trim();
            }
            //身高(CM)
            if (!string.IsNullOrEmpty(entity.ZHRGRSG))
            {
                this.txtInputZHRGRSG.Text = entity.ZHRGRSG.Trim();
            }
            //体重(斤)
            if (!string.IsNullOrEmpty(entity.ZHRGRTZ))
            {
                this.txtInputZHRGRTZ.Text = entity.ZHRGRTZ.Trim();
            }
            //健康状况
            if (!string.IsNullOrEmpty(entity.ZHRJKZK))
            {
                this.txtInputZHRJKZK.Text = entity.ZHRJKZK.Trim();
            }
            //血型
            if (!string.IsNullOrEmpty(entity.ZHRYRXX))
            {
                this.ddlInputZHRYRXX.Items.FindByValue(entity.ZHRYRXX.Trim()).Selected = true;
            }
            //民族
            if (!string.IsNullOrEmpty(entity.RACKY))
            {
                this.ddlInputRACKY.Items.FindByValue(entity.RACKY.Trim()).Selected = true;
            }
            //是否服从调剂
            if (!string.IsNullOrEmpty(entity.ZHRFZDJ))
            {
                this.ddlInputZHRFZDJ.Items.FindByValue(entity.ZHRFZDJ.Trim()).Selected = true;
            }
            //政治面貌
            if (!string.IsNullOrEmpty(entity.PCODE))
            {
                this.ddlInputPCODE.Items.FindByValue(entity.PCODE.Trim()).Selected = true;
            }
            //婚姻状况
            if (!string.IsNullOrEmpty(entity.FAMST))
            {
                this.ddlInputFAMST.Items.FindByValue(entity.FAMST.Trim()).Selected = true;
            }

            //子女个数
            if (!string.IsNullOrEmpty(entity.FAMST.ToString()))
            {
                this.txtInputANZKD.Text = entity.ANZKD.ToString().Trim();
            }
            //外语水平
            if (!string.IsNullOrEmpty(entity.ZHRWYSP))
            {
                this.ddlInputZHRWYSP.Items.FindByValue(entity.ZHRWYSP.Trim()).Selected = true;
            }

            //外语水平分数
            if (!string.IsNullOrEmpty(entity.ZHRWYFS))
            {
                this.txtInputZHRWYFS.Text = entity.ZHRWYFS.Trim();
            }
            //计算机水平
            if (!string.IsNullOrEmpty(entity.ZHRJSJSP))
            {
                this.ddlInputZHRJSJSP.Items.FindByValue(entity.ZHRJSJSP.Trim()).Selected = true;
            }

            //手机号码
            if (!string.IsNullOrEmpty(entity.USRID_TEL))
            {
                this.txtInputUSRID_TEL.Text = entity.USRID_TEL.Trim();
            }

            //家庭住址
            if (!string.IsNullOrEmpty(entity.LOCAT_JT))
            {
                this.txtInputLOCAT_JT.Text = entity.LOCAT_JT.Trim();
            }

            //户籍地址
            if (!string.IsNullOrEmpty(entity.LOCAT_HJ))
            {
                this.txtInputLOCAT_HJ.Text = entity.LOCAT_HJ.Trim();
            }

            //现居住地
            if (!string.IsNullOrEmpty(entity.LOCAT_XJ))
            {
                this.txtInputLOCAT_XJ.Text = entity.LOCAT_XJ.Trim();
            }

            //紧急联络人
            if (!string.IsNullOrEmpty(entity.FANAM))
            {
                this.txtInputFANAM.Text = entity.FANAM.Trim();
            }

            //紧急联络人性别
            if (!string.IsNullOrEmpty(entity.FASEX))
            {
                this.ddlInputFASEX.Items.FindByValue(entity.FASEX.Trim()).Selected = true;
            }

            //紧急联络人出生日期
            if (entity.FGBDT != null)
            {
                if (!string.IsNullOrEmpty(entity.FGBDT.ToString()))
                {
                    this.txtInputFGBDT.Text = entity.FGBDT == null ? string.Empty : entity.FGBDT.ToString("yyyy-MM-dd").Trim();

                    if (this.txtInputFGBDT.Text == "0001-01-01")
                    {
                        this.txtInputFGBDT.Text = "";
                    }
                }
                else
                {
                    this.txtInputFGBDT.Text = "";
                }
            }
            //紧急联络人联系方式
            if (!string.IsNullOrEmpty(entity.TELNR))
            {
                this.txtInputTELNR.Text = entity.TELNR.Trim();
            }

            //电子信箱
            if (!string.IsNullOrEmpty(entity.USRID_MAIL))
            {
                this.txtInputUSRID_MAIL.Text = entity.USRID_MAIL.Trim();
            }
            //bs
            if (!string.IsNullOrEmpty(entity.JWBS))
            {
                this.txtInputJWBS.Text = entity.JWBS.Trim();
            }

            if (!string.IsNullOrEmpty(entity.ZHRZWJS))
            {
                //自我介绍
                this.txtInputZHRZWJS.Text = entity.ZHRZWJS.Trim();
            }

            if (!string.IsNullOrEmpty(entity.ZHRSLJZ))
            {
                //视力/矫正视力
                this.txtInputZHRSLJZ.Text = entity.ZHRSLJZ.Trim();
            }
            if (!string.IsNullOrEmpty(entity.ZHRTZGG))
            {
                //统招高考成绩
                this.txtInputZHRTZGG.Text = entity.ZHRTZGG.Trim();
            }
            if (!string.IsNullOrEmpty(entity.ZHRTC))
            {
                //特长
                this.txtInputZHRTC.Text = entity.ZHRTC.Trim();
            }
            if (!string.IsNullOrEmpty(entity.ZHRHJJL))
            {
                //获奖经历
                this.txtInputZHRHJJL.Text = entity.ZHRHJJL.Trim();
            }
            if (!string.IsNullOrEmpty(entity.ZHRBZ))
            {
                //备注
                this.txtInputZHRBZ.Text = entity.ZHRBZ.Trim();
            }

            if (!string.IsNullOrEmpty(entity.TYPE_ID))
            {
                //护理类型
                this.ddlInputTYPE_ID.Items.FindByValue(entity.TYPE_ID.Trim()).Selected = true;
                if (entity.TYPE_ID != "1003")
                {
                    if (!string.IsNullOrEmpty(entity.ZHRSXXX))
                    {
                        //实习医院
                        this.txtInputZHRSXXX.Text = entity.ZHRSXXX.Trim();
                    }
                    else
                    {
                        this.txtInputZHRSXXX.Text = "";
                    }
                    if (entity.TYPE_ID == "1002" && IsMaster)
                    {
                        if (!string.IsNullOrEmpty(entity.YJSSXXX))
                        {
                            //研究生实习医院
                            this.txtInputYJSSXXX.Text = entity.YJSSXXX.Trim();
                        }
                        else
                        {
                            this.txtInputYJSSXXX.Text = "";
                        }
                    }
                }
            }
            else
            {
                //实习医院
                this.txtInputZHRSXXX.Text = "";
                this.txtInputYJSSXXX.Text = "";
            }

            if (!string.IsNullOrEmpty(entity.ZHRGZNX))
            {
                //三级甲等医院工作年限
                this.txtInputZHRGZNX.Text = entity.ZHRGZNX.Trim();
            }

            if (!string.IsNullOrEmpty(entity.IS_CERTIFICATE.ToString()))
            {
                //是否证书
                if (entity.IS_CERTIFICATE == 1)
                {
                    this.ckInputIS_CERTIFICATE.Checked = true;
                }
                else
                {
                    this.ckInputIS_CERTIFICATE.Checked = false;
                }
            }
            else
            {
                this.ckInputIS_CERTIFICATE.Checked = false;
            }
            //简历上传
            if (!string.IsNullOrEmpty(entity.FILE_PATH))
            {
                lbl_ulmsg.Text = "Word简历已上传";
                fu_load.Visible = false;
                btn_delete.Visible = true;

                lbl_FILE_PATH.Text = "<a href='../" + entity.FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
            }
        }


        protected void btn_delete_Click(object sender, EventArgs e)
        {
            if (ViewState["CUR_OBJ"] != null)
            {
                try
                {
                    DisplayObject_V_HEM_B_STAFF displayVstaff = ViewState["CUR_OBJ"] as DisplayObject_V_HEM_B_STAFF;

                    object[] arrEntity = SetEditEntity(displayVstaff);
                    EntityObject_HEM_B_STAFF curObj = arrEntity[0] as EntityObject_HEM_B_STAFF;
                    //displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;

                    //object[] arrEntity1 = SetEditTypeEntity(displayVstaff);
                    //EntityObject_HEM_B_STAFF_TYPE entityNurse = arrEntity1[0] as EntityObject_HEM_B_STAFF_TYPE;
                    //displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;
                    EntityObject_HEM_B_STAFF_TYPE entityNurse = new EntityObject_HEM_B_STAFF_TYPE();
                    entityNurse.ID = displayVstaff.STAFF_TYPE_ID;

                    if (File.Exists(Server.MapPath("~/" + entityNurse.FILE_PATH)))
                    {
                        File.Delete(Server.MapPath("~/" + entityNurse.FILE_PATH));
                    }

                    entityNurse.FILE_PATH = "";
                    entityNurse.SetUpdate("FILE_PATH");
                    BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(entityNurse);
                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        fu_load.Visible = true;
                        btn_delete.Visible = false;
                        lbl_ulmsg.Text = "";
                        lbl_FILE_PATH.Text = "";
                        //ViewState["CUR_OBJ"] = curObj;
                        ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('删除成功！');</script>");
                    }
                }
                catch
                {
                    lbl_ulmsg.Text = "删除时发生错误！";
                }
            }
        }

        protected void lb_Phy_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='STAFF_BASIC.aspx';</script>");
        }
        protected void lb_Send_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='STAFF_SEND_BASIC.aspx';</script>");
        }
        /*
        protected void btn_upload_Click(object sender, EventArgs e)
        {
            if (ViewState["CUR_OBJ"] != null)
            {
                string sfile = "*.DOC||*.DOCX";
                string extension = "";
                string saveAsFileName = "";
                //System.IO.FileInfo finfo = new FileInfo(fu_load.PostedFile.FileName);
                if (!string.IsNullOrEmpty(fu_load.PostedFile.FileName))
                {
                    string filelastname = fu_load.FileName.Substring(fu_load.FileName.LastIndexOf("."));
                    extension = System.IO.Path.GetExtension(fu_load.FileName).ToLower();
                    if (!sfile.Contains(filelastname.ToUpper()))
                    {
                        ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('请上传Word文件!');</script>");
                    }
                    else
                    {
                        if (fu_load.PostedFile.ContentLength > 5120000)
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('文件仅限5M以下');</script>");
                            //WebControlHelper.ShowAlert(this, "文件仅限5M以下！");
                        }
                        else
                        {
                            //上传文件到本地服务器
                            string fileUrl = "doc/attached";
                            string strDate = DateTime.Now.ToString("yyMMddHHmmss");
                            string strFileName = this.fu_load.FileName.Substring(0, (fu_load.FileName.Length - extension.Length));

                            saveAsFileName = strFileName.Trim() + strDate + extension;
                            try
                            {
                                if (Directory.Exists(Server.MapPath("~/" + fileUrl)) == false)//如果不存在就创建文件夹
                                {
                                    Directory.CreateDirectory(Server.MapPath("~/" + fileUrl));
                                }

                                if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                {
                                    File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                    //Msg("文件名重复，请修改后再上传！");
                                    //return ;
                                }

                                string excelServerURL = MapPath("~/" + fileUrl + "/") + saveAsFileName;
                                fu_load.SaveAs(excelServerURL);

                                BizLogicObject_HEM_B_STAFF biz = new BizLogicObject_HEM_B_STAFF();
                                EntityObject_HEM_B_STAFF curObj = ViewState["CUR_OBJ"] as EntityObject_HEM_B_STAFF;
                                curObj = biz.Get(curObj);
                                if (File.Exists(Server.MapPath("~/" + curObj.FILE_PATH)))
                                {
                                    File.Delete(Server.MapPath("~/" + curObj.FILE_PATH));
                                }
                                curObj.FILE_PATH = fileUrl + "/" + saveAsFileName;
                                curObj.SetUpdate("FILE_PATH");
                                BizLogicMsg msg = biz.Update(curObj);
                                if (!msg.Succeed)
                                {
                                    lbl_Error.Visible = true;
                                    lbl_Error.Text = msg.Message;
                                }
                                else
                                {
                                    btn_upload.Visible = false;
                                    fu_load.Visible = false;
                                    btn_delete.Visible = true;
                                    lbl_ulmsg.Text = "上传成功！";
                                    ViewState["CUR_OBJ"] = curObj;

                                }
                            }
                            catch (Exception)
                            {
                                if (File.Exists(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName))
                                {
                                    File.Delete(Server.MapPath("~/" + fileUrl + "/") + saveAsFileName);
                                }
                                ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('上传的Word文件异常错误,请联系管理员！');</script>");
                                //WebControlHelper.ShowAlert(this, "上传的Word文件异常错误,请联系管理员！");
                            }

                        }
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('未选择文件！');</script>");
                    //WebControlHelper.ShowAlert(this, "未选择Word文件！");
                }
            }
            else {
                lbl_ulmsg.Text = "请先保存简历信息！";
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            if (ViewState["CUR_OBJ"] != null)
            {
                try
                {
                    EntityObject_HEM_B_STAFF curObj = ViewState["CUR_OBJ"] as EntityObject_HEM_B_STAFF;
                    if (File.Exists(Server.MapPath("~/" + curObj.FILE_PATH)))
                    {
                        File.Delete(Server.MapPath("~/" + curObj.FILE_PATH));
                    }
                    BizLogicObject_HEM_B_STAFF biz = new BizLogicObject_HEM_B_STAFF();
                    curObj.FILE_PATH = "";
                    curObj.SetUpdate("FILE_PATH");
                    BizLogicMsg msg = biz.Update(curObj);
                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        btn_upload.Visible = true;
                        fu_load.Visible = true;
                        btn_delete.Visible = false;
                        lbl_ulmsg.Text = "删除成功！";
                        ViewState["CUR_OBJ"] = curObj;
                    }
                }
                catch
                {
                    lbl_ulmsg.Text = "删除时发生错误！";
                }
            }
        }*/

    }
}