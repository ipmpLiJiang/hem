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
    public partial class STAFF_SEND_BASIC : User_Page
    {
        private const decimal cIS_NURSE = 3;
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
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
                                displayVstaff.TYPE_ID = "1004";
                                GetEditEntity(displayVstaff);

                                ViewState["CUR_OBJ"] = displayVstaff;
                            }
                        }
                        else
                        {
                            displayVstaff = GetDisplayStaffType(displayNurseAll[0]);
                            displayVstaff.IS_NURSE = cIS_NURSE;
                            displayVstaff.TYPE_ID = "1004";
                            displayVstaff.STAFF_TYPE_ID = "";
                            GetEditEntity(displayVstaff);
                            ViewState["CUR_OBJ"] = displayVstaff;
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
            foreach (ListItem d_item in this.ddlInputRACKY.Items)
            {
                if (d_item.Text == "汉族")
                {
                    this.ddlInputRACKY.Items.FindByText("汉族").Selected = true;
                }
            }
            this.ddlInputPRACTICE_TYPE_ID.Enabled = false;
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

            //执业类型
            cause.PARENT_ID = "HEM_1016";
            ddlInputPRACTICE_TYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPRACTICE_TYPE_ID.DataTextField = "NAME";
            ddlInputPRACTICE_TYPE_ID.DataValueField = "CODE";
            ddlInputPRACTICE_TYPE_ID.DataBind();
            ddlInputPRACTICE_TYPE_ID.Items.Insert(0, new ListItem("--请选择--", ""));
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
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('" + msg.Message + "');</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('简历,提交成功!');</script>");
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

        protected void btn_SaveNext_Click(object sender, EventArgs e)
        {
            bool bl = SaveMethod();
            if (bl)
            {
                int n = IsStaffApplyN();
                if (n == 9)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_EDUCATION.aspx';</script>");
                }
                else if (n == 1)
                {
                    ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('教育信息为必填信息,请填写教育信息资料,确保申请的招聘职位申请成功!');location.href='STAFF_EDUCATION.aspx';</script>");
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
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>location.href='STAFF_EDUCATION.aspx';</script>");
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(GetType(), "ddd", "<script>alert('教育信息为必填信息,请完善教育信息资料!');location.href='STAFF_EDUCATION.aspx';</script>");
                        }
                    }
                }
            }
        }
        private bool ValidataBool(EntityObject_V_HEM_B_STAFF entity)
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

            //第一志愿
            //if (string.IsNullOrEmpty(entity.FIRSTCHOICE))
            //{
            //    lbl_Error.Visible = true;
            //    lbl_Error.Text = "第一志愿不能为空！";
            //    //WebControlHelper.ShowAlert(null, "姓名不能为空！");
            //    return false;
            //}

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

            if (!string.IsNullOrEmpty(entity.ZHRZWJS))
            {
                if (entity.ZHRZWJS.Length > 200)
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "自我介绍输入的长度不能超过200个字！";
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

            if (this.ckInputIS_CERTIFICATE.Checked == true)
            {
                if (!string.IsNullOrEmpty(this.ddlInputPRACTICE_TYPE_ID.SelectedValue))
                {
                    lbl_PRACTICE_TYPE_ID.Visible = false;
                }
                else
                {
                    lbl_PRACTICE_TYPE_ID.Visible = true;
                    ddlInputPRACTICE_TYPE_ID.Enabled = true;
                    return false;
                }
            }
            else
            {
                lbl_PRACTICE_TYPE_ID.Visible = false;
            }

            return returnBool;
        }

        private bool SaveMethod()
        {
            //lbl_ulmsg.Text = "";
            bool IsTrturn = false;
            lbl_FGBDT.Visible = false;
            lbl_TELNR.Visible = false;
            lbl_FANAM.Visible = false;
            lbl_FASEX.Visible = false;
            EntityObject_V_USER_LOGIN_INFO UserInfo = Session["UserLogin"] as EntityObject_V_USER_LOGIN_INFO;
            EntityObject_HEM_B_STAFF_TYPE entityNurse = new EntityObject_HEM_B_STAFF_TYPE();
            lbl_Error.Text = "";
            entityNurse.TYPE_ID = "1005";
            entityNurse.USER_ID = UserInfo.USER_ID;
            entityNurse.IS_NURSE = cIS_NURSE;

            if (ViewState["CUR_OBJ"] == null)
            {
                DisplayObject_V_HEM_B_STAFF displayVstaff = new DisplayObject_V_HEM_B_STAFF();

                object[] objEntity = SetEditEntity(displayVstaff);

                EntityObject_HEM_B_STAFF entity = objEntity[0] as EntityObject_HEM_B_STAFF;
                displayVstaff = objEntity[1] as DisplayObject_V_HEM_B_STAFF;

                entity.USER_ID = UserInfo.USER_ID;

                displayVstaff.USER_ID = UserInfo.USER_ID;
                displayVstaff.IS_NURSE = entityNurse.IS_NURSE;
                displayVstaff.TYPE_ID = entityNurse.TYPE_ID;
                entityNurse.IS_CERTIFICATE = displayVstaff.IS_CERTIFICATE;
                if (displayVstaff.IS_CERTIFICATE == 2)
                {
                    entityNurse.PRACTICE_TYPE_ID = "";
                }
                else
                {
                    entityNurse.PRACTICE_TYPE_ID = displayVstaff.PRACTICE_TYPE_ID;
                }
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
                        if (displayVstaff.IS_CERTIFICATE == 2)
                        {
                            ddlInputPRACTICE_TYPE_ID.Enabled = false;
                        }
                        else
                        {
                            ddlInputPRACTICE_TYPE_ID.Enabled = true;
                        }

                        string sfile = "*.DOC||*.DOCX";
                        string extension = "";
                        string saveAsFileName = "";
                        //System.IO.FileInfo finfo = new FileInfo(fu_load.PostedFile.FileName);
                        if (fu_load.PostedFile != null)
                        {
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

                                            EntityObject_HEM_B_STAFF_TYPE entity1 = new EntityObject_HEM_B_STAFF_TYPE();
                                            entity1.ID = displayVstaff.STAFF_TYPE_ID;
                                            entity1 = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Get(entity1);
                                            if (File.Exists(Server.MapPath("~/" + entity1.FILE_PATH)))
                                            {
                                                File.Delete(Server.MapPath("~/" + entity1.FILE_PATH));
                                            }
                                            entity1.FILE_PATH = fileUrl + "/" + saveAsFileName;
                                            entity1.SetUpdate("FILE_PATH");
                                            BizLogicMsg msg1 = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(entity1);
                                            if (!msg1.Succeed)
                                            {
                                                lbl_Error.Visible = true;
                                                lbl_Error.Text = msg.Message;
                                            }
                                            else
                                            {
                                                fu_load.Visible = false;
                                                btn_delete.Visible = true;
                                                lbl_FILE_PATH.Text = "<a href='../" + entity1.FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
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
            }
            else
            {
                DisplayObject_V_HEM_B_STAFF displayVstaff = ViewState["CUR_OBJ"] as DisplayObject_V_HEM_B_STAFF;

                object[] objEntity = SetEditEntity(displayVstaff);

                EntityObject_HEM_B_STAFF curObj = objEntity[0] as EntityObject_HEM_B_STAFF;
                displayVstaff = objEntity[1] as DisplayObject_V_HEM_B_STAFF;

                displayVstaff.USER_ID = displayVstaff.USER_ID;
                displayVstaff.IS_NURSE = entityNurse.IS_NURSE;
                displayVstaff.TYPE_ID = entityNurse.TYPE_ID;

                entityNurse.ID = displayVstaff.STAFF_TYPE_ID;
                curObj.ID = displayVstaff.ID;
                entityNurse.STAFF_ID = curObj.ID;
                entityNurse.IS_CERTIFICATE = displayVstaff.IS_CERTIFICATE;
                if (displayVstaff.IS_CERTIFICATE == 2)
                {
                    entityNurse.PRACTICE_TYPE_ID = "";
                }
                else
                {
                    entityNurse.PRACTICE_TYPE_ID = displayVstaff.PRACTICE_TYPE_ID;
                }

                bool vBool = ValidataBool(displayVstaff);
                if (!vBool) { return false; }

                CauseObject_HEM_B_STAFF causeSF = new CauseObject_HEM_B_STAFF();
                causeSF.ICNUM = curObj.ICNUM;
                causeSF.SetCustomCondition(" AND HEM_B_STAFF.ID !='" + curObj.ID + "'");
                if (IsExistICNUM(causeSF))
                {
                    curObj.USER_ID = displayVstaff.USER_ID;
                    curObj.SetNotUpdate("USER_ID", "NACHN", "USRID_TEL", "USRID_MAIL", "ZHRSLJZ", "ZHRTZGG", "ZHRTC", "ZHRHJJL", "ZHRBZ", "ZHRGZNX", "ZHRSXXX");
                    BizLogicMsg msg = BizLogicObject_HEM_B_STAFF.Proxy.Update(curObj, entityNurse);
                    IsTrturn = msg.Succeed;
                    if (!msg.Succeed)
                    {
                        lbl_Error.Visible = true;
                        lbl_Error.Text = msg.Message;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(displayVstaff.STAFF_TYPE_ID))
                        {
                            displayVstaff.STAFF_TYPE_ID = entityNurse.ID;
                        }
                        ViewState["CUR_OBJ"] = displayVstaff;
                        //WebControlHelper.ShowAlert(null, "保存成功！");
                        lbl_Error.Visible = false;
                        lbl_Error.Text = "";
                        if (displayVstaff.IS_CERTIFICATE == 2)
                        {
                            ddlInputPRACTICE_TYPE_ID.Enabled = false;
                        }
                        else
                        {
                            ddlInputPRACTICE_TYPE_ID.Enabled = true;
                        }

                        string sfile = "*.DOC||*.DOCX";
                        string extension = "";
                        string saveAsFileName = "";
                        //System.IO.FileInfo finfo = new FileInfo(fu_load.PostedFile.FileName);
                        if (fu_load.PostedFile != null)
                        {
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

                                            EntityObject_HEM_B_STAFF_TYPE entity1 = new EntityObject_HEM_B_STAFF_TYPE();
                                            entity1.ID = displayVstaff.STAFF_TYPE_ID;
                                            entity1 = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Get(entity1);
                                            if (File.Exists(Server.MapPath("~/" + entity1.FILE_PATH)))
                                            {
                                                File.Delete(Server.MapPath("~/" + entity1.FILE_PATH));
                                            }
                                            entity1.FILE_PATH = fileUrl + "/" + saveAsFileName;
                                            entity1.SetUpdate("FILE_PATH");
                                            BizLogicMsg msg1 = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(entity1);
                                            if (!msg1.Succeed)
                                            {
                                                lbl_Error.Visible = true;
                                                lbl_Error.Text = msg.Message;
                                            }
                                            else
                                            {
                                                fu_load.Visible = false;
                                                btn_delete.Visible = true;
                                                lbl_FILE_PATH.Text = "<a href='../" + entity1.FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
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
            }

            return IsTrturn;
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

        public bool IsExistICNUM(CauseObject_HEM_B_STAFF cuase)
        {
            DisplayObject_HEM_B_STAFF[] itemStaff = BizLogicObject_HEM_B_STAFF.Proxy.Query(cuase);
            return itemStaff.Length > 0 ? false : true;
        }

        protected object[] SetEditEntity(DisplayObject_V_HEM_B_STAFF displayStaff)
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

            displayStaff.NACHN = entity.NACHN;

            //性别
            if (!string.IsNullOrEmpty(this.ddlInputGESCH.SelectedValue))
            {
                entity.GESCH = this.ddlInputGESCH.SelectedValue;
            }
            else
            {
                entity.GESCH = "";
            }

            displayStaff.GESCH = entity.GESCH;

            //出生日期
            if (!string.IsNullOrEmpty(this.txtInputGBDAT.Text))
            {
                entity.GBDAT = DateTime.Parse(this.txtInputGBDAT.Text);
            }
            else
            {
                entity.GBDAT = Ipedf.Common.Template.UndefineDatetime;
            }

            displayStaff.GBDAT = entity.GBDAT;

            //身份证号
            if (!string.IsNullOrEmpty(this.txtInputICNUM.Text))
            {
                entity.ICNUM = this.txtInputICNUM.Text.Trim();
            }
            else
            {
                entity.ICNUM = "";
            }

            displayStaff.ICNUM = entity.ICNUM;

            //籍贯
            if (!string.IsNullOrEmpty(this.txtInputZHRJG.Text))
            {
                entity.ZHRJG = this.txtInputZHRJG.Text.Trim();
            }
            else
            {
                entity.ZHRJG = "";
            }

            displayStaff.ZHRJG = entity.ZHRJG;

            //身高(CM)
            if (!string.IsNullOrEmpty(this.txtInputZHRGRSG.Text))
            {
                entity.ZHRGRSG = this.txtInputZHRGRSG.Text.Trim();
            }
            else
            {
                entity.ZHRGRSG = "";
            }

            displayStaff.ZHRGRSG = entity.ZHRGRSG;

            //体重(斤)
            if (!string.IsNullOrEmpty(this.txtInputZHRGRTZ.Text))
            {
                entity.ZHRGRTZ = this.txtInputZHRGRTZ.Text.Trim();
            }
            else
            {
                entity.ZHRGRTZ = "";
            }

            displayStaff.ZHRGRTZ = entity.ZHRGRTZ;

            //健康状况
            if (!string.IsNullOrEmpty(this.txtInputZHRJKZK.Text))
            {
                entity.ZHRJKZK = this.txtInputZHRJKZK.Text.Trim();
            }
            else
            {
                entity.ZHRJKZK = "";
            }

            displayStaff.ZHRJKZK = entity.ZHRJKZK;

            //血型
            if (!string.IsNullOrEmpty(this.ddlInputZHRYRXX.SelectedValue))
            {
                entity.ZHRYRXX = this.ddlInputZHRYRXX.SelectedValue;
            }
            else
            {
                entity.ZHRYRXX = "";
            }

            displayStaff.ZHRYRXX = entity.ZHRYRXX;

            //民族
            if (!string.IsNullOrEmpty(this.ddlInputRACKY.SelectedValue))
            {
                entity.RACKY = this.ddlInputRACKY.SelectedValue;
            }
            else
            {
                entity.RACKY = "";
            }

            displayStaff.RACKY = entity.RACKY;

            //是否服从调剂
            if (!string.IsNullOrEmpty(this.ddlInputZHRFZDJ.SelectedValue))
            {
                entity.ZHRFZDJ = this.ddlInputZHRFZDJ.SelectedValue;
            }
            else
            {
                entity.ZHRFZDJ = "";
            }

            displayStaff.ZHRFZDJ = entity.ZHRFZDJ;

            //政治面貌
            if (!string.IsNullOrEmpty(this.ddlInputPCODE.SelectedValue))
            {
                entity.PCODE = this.ddlInputPCODE.SelectedValue;
            }
            else
            {
                entity.PCODE = "";
            }

            displayStaff.PCODE = entity.PCODE;

            //婚姻状况
            if (!string.IsNullOrEmpty(this.ddlInputFAMST.SelectedValue))
            {
                entity.FAMST = this.ddlInputFAMST.SelectedValue;
            }
            else
            {
                entity.FAMST = "";
            }

            displayStaff.FAMST = entity.FAMST;

            //子女个数
            if (!string.IsNullOrEmpty(this.txtInputANZKD.Text))
            {
                entity.ANZKD = decimal.Parse(this.txtInputANZKD.Text.Trim());
            }
            else
            {
                entity.ANZKD = 0;
            }

            displayStaff.ANZKD = entity.ANZKD;

            //外语水平
            if (!string.IsNullOrEmpty(this.ddlInputZHRWYSP.SelectedValue))
            {
                entity.ZHRWYSP = this.ddlInputZHRWYSP.SelectedValue;
            }
            else
            {
                entity.ZHRWYSP = "";
            }

            displayStaff.ZHRWYSP = entity.ZHRWYSP;

            //外语水平分数
            if (!string.IsNullOrEmpty(this.txtInputZHRWYFS.Text))
            {
                entity.ZHRWYFS = this.txtInputZHRWYFS.Text.Trim();
            }
            else
            {
                entity.ZHRWYFS = "";
            }

            displayStaff.ZHRWYFS = entity.ZHRWYFS;

            //计算机水平
            if (!string.IsNullOrEmpty(this.ddlInputZHRJSJSP.SelectedValue))
            {
                entity.ZHRJSJSP = this.ddlInputZHRJSJSP.SelectedValue;
            }
            else
            {
                entity.ZHRJSJSP = "";
            }

            displayStaff.ZHRJSJSP = entity.ZHRJSJSP;

            //手机号码
            if (!string.IsNullOrEmpty(this.txtInputUSRID_TEL.Text))
            {
                entity.USRID_TEL = this.txtInputUSRID_TEL.Text.Trim();
            }
            else
            {
                entity.USRID_TEL = "";
            }

            displayStaff.USRID_TEL = entity.USRID_TEL;

            //家庭住址
            if (!string.IsNullOrEmpty(this.txtInputLOCAT_JT.Text))
            {
                entity.LOCAT_JT = this.txtInputLOCAT_JT.Text.Trim();
            }
            else
            {
                entity.LOCAT_JT = "";
            }

            displayStaff.LOCAT_JT = entity.LOCAT_JT;

            //户籍地址
            if (!string.IsNullOrEmpty(this.txtInputLOCAT_HJ.Text))
            {
                entity.LOCAT_HJ = this.txtInputLOCAT_HJ.Text.Trim();
            }
            else
            {
                entity.LOCAT_HJ = "";
            }

            displayStaff.LOCAT_HJ = entity.LOCAT_HJ;

            //现居住地
            if (!string.IsNullOrEmpty(this.txtInputLOCAT_XJ.Text))
            {
                entity.LOCAT_XJ = this.txtInputLOCAT_XJ.Text.Trim();
            }
            else
            {
                entity.LOCAT_XJ = "";
            }

            displayStaff.LOCAT_XJ = entity.LOCAT_XJ;

            //紧急联络人
            if (!string.IsNullOrEmpty(this.txtInputFANAM.Text))
            {
                entity.FANAM = this.txtInputFANAM.Text.Trim();
            }
            else
            {
                entity.FANAM = "";
            }

            displayStaff.FANAM = entity.FANAM;

            //紧急联络人性别
            if (!string.IsNullOrEmpty(this.ddlInputFASEX.SelectedValue))
            {
                entity.FASEX = this.ddlInputFASEX.SelectedValue;
            }
            else
            {
                entity.FASEX = "";
            }

            displayStaff.FASEX = entity.FASEX;

            //紧急联络人出生日期
            if (!string.IsNullOrEmpty(this.txtInputFGBDT.Text))
            {
                entity.FGBDT = DateTime.Parse(this.txtInputFGBDT.Text);
            }
            else
            {
                entity.FGBDT = Ipedf.Common.Template.UndefineDatetime;
            }

            displayStaff.FGBDT = entity.FGBDT;

            //紧急联络人联系方式
            if (!string.IsNullOrEmpty(this.txtInputTELNR.Text))
            {
                entity.TELNR = this.txtInputTELNR.Text.Trim();
            }
            else
            {
                entity.TELNR = "";
            }

            displayStaff.TELNR = entity.TELNR;

            //电子信箱
            if (!string.IsNullOrEmpty(this.txtInputUSRID_MAIL.Text))
            {
                entity.USRID_MAIL = this.txtInputUSRID_MAIL.Text.Trim();
            }
            else
            {
                entity.USRID_MAIL = "";
            }

            displayStaff.USRID_MAIL = entity.USRID_MAIL;

            //自我介绍
            if (!string.IsNullOrEmpty(this.txtInputZHRZWJS.Text))
            {
                entity.ZHRZWJS = this.txtInputZHRZWJS.Text.Trim();
            }
            else
            {
                entity.ZHRZWJS = "";
            }

            displayStaff.ZHRZWJS = entity.ZHRZWJS;

            //是否证书
            if (this.ckInputIS_CERTIFICATE.Checked == true)
            {
                displayStaff.IS_CERTIFICATE = 1;
            }
            else
            {
                displayStaff.IS_CERTIFICATE = 2;
            }

            //是否证书
            if (!string.IsNullOrEmpty(this.ddlInputPRACTICE_TYPE_ID.SelectedValue))
            {
                displayStaff.PRACTICE_TYPE_ID = this.ddlInputPRACTICE_TYPE_ID.SelectedValue;
            }

            //第一志愿
            if (!string.IsNullOrEmpty(this.txtInputFIRSTCHOICE.Text))
            {
                entity.FIRSTCHOICE = this.txtInputFIRSTCHOICE.Text.Trim();
            }
            else
            {
                entity.FIRSTCHOICE = "";
            }

            displayStaff.FIRSTCHOICE = entity.FIRSTCHOICE;

            //第二志愿
            if (!string.IsNullOrEmpty(this.txtInputSECONDCHOICE.Text))
            {
                entity.SECONDCHOICE = this.txtInputSECONDCHOICE.Text.Trim();
            }
            else
            {
                entity.SECONDCHOICE = "";
            }

            displayStaff.SECONDCHOICE = entity.SECONDCHOICE;

            arrEntity[0] = entity;
            arrEntity[1] = displayStaff;
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

            if (!string.IsNullOrEmpty(entity.ZHRZWJS))
            {
                //自我介绍
                this.txtInputZHRZWJS.Text = entity.ZHRZWJS.Trim();
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
                    this.ddlInputPRACTICE_TYPE_ID.Enabled = false;
                    this.ckInputIS_CERTIFICATE.Checked = false;
                }
            }
            else
            {
                this.ckInputIS_CERTIFICATE.Checked = false;
            }

            //第一志愿
            if (!string.IsNullOrEmpty(entity.FIRSTCHOICE))
            {
                this.txtInputFIRSTCHOICE.Text = entity.FIRSTCHOICE.Trim();
            }

            //第二志愿
            if (!string.IsNullOrEmpty(entity.SECONDCHOICE))
            {
                this.txtInputSECONDCHOICE.Text = entity.SECONDCHOICE.Trim();
            }

            //执业类型
            if (!string.IsNullOrEmpty(entity.PRACTICE_TYPE_ID))
            {
                this.ddlInputPRACTICE_TYPE_ID.Items.FindByValue(entity.PRACTICE_TYPE_ID.Trim()).Selected = true;
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

        protected void lb_Nurse_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='STAFF_NURSE_BASIC.aspx';</script>");
        }

        protected void lb_Phy_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='STAFF_BASIC.aspx';</script>");
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            if (ViewState["CUR_OBJ"] != null)
            {
                try
                {
                    DisplayObject_V_HEM_B_STAFF displayVstaff = ViewState["CUR_OBJ"] as DisplayObject_V_HEM_B_STAFF;

                    //displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;

                    //object[] arrEntity1 = SetEditTypeEntity(displayVstaff);
                    //EntityObject_HEM_B_STAFF_TYPE entityNurse = arrEntity1[0] as EntityObject_HEM_B_STAFF_TYPE;
                    //displayVstaff = arrEntity[1] as DisplayObject_V_HEM_B_STAFF;
                    EntityObject_HEM_B_STAFF_TYPE entity1 = new EntityObject_HEM_B_STAFF_TYPE();
                    entity1.ID = displayVstaff.STAFF_TYPE_ID;
                    if (File.Exists(Server.MapPath("~/" + entity1.FILE_PATH)))
                    {
                        File.Delete(Server.MapPath("~/" + entity1.FILE_PATH));
                    }
                    entity1.FILE_PATH = "";
                    entity1.SetUpdate("FILE_PATH");
                    BizLogicMsg msg = BizLogicObject_HEM_B_STAFF_TYPE.Proxy.Update(entity1);
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