<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true"
    CodeBehind="STAFF_NURSE_BASIC.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_NURSE_BASIC"
    Title="护理基本信息" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/person.css") %>">

    <script src="<%=ResolveClientUrl("~/scripts/My97DatePicker/WdatePicker.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/personnurse.js") %>" type="text/javascript"></script>

    <script type="text/javascript" language="javascript">
        $(function() {
            $("#mainNav li:eq(1)").addClass("active").siblings().removeClass("active");
            $("#ctl00_ContentPlaceHolder1_ddlInputTYPE_ID").change(function() {
                var value = $(this).val();
                var labc = $("#ctl00_ContentPlaceHolder1_labZHRGZNX");
                if (value == '1003') {
                    labc.text("三级甲等医院工作年限");
                    $("#divZHRSXXX").hide();
                    $("#divYJSSXXX").hide();
                    $("#ctl00_ContentPlaceHolder1_lbl_ZHRSXXX").hide();
                    $("#ctl00_ContentPlaceHolder1_txtInputZHRSXXX").val("");
                    $("#ctl00_ContentPlaceHolder1_txtInputYJSSXXX").val("");
                } else {
                    labc.text("实习时长");
                    $("#spanZHRSXXX").text("实习医院：");
                    $("#divZHRSXXX").show();
                    if (value == '1002' && $("#ctl00_ContentPlaceHolder1_txtIsMaster").val() == "True") {
                        $("#spanZHRSXXX").text("本科实习医院：");
                        $("#divYJSSXXX").show();
                    }
                    else {
                        $("#divYJSSXXX").hide();
                        $("#ctl00_ContentPlaceHolder1_txtInputYJSSXXX").val("");
                    }
                    var val = $("#ctl00_ContentPlaceHolder1_txtInputZHRSXXX").val();
                    if (val != "") {
                        $("#ctl00_ContentPlaceHolder1_lbl_ZHRSXXX").hide();
                    } else {
                        $("#ctl00_ContentPlaceHolder1_lbl_ZHRSXXX").show();
                    }

                    var val = $("#ctl00_ContentPlaceHolder1_txtInputYJSSXXX").val();
                    if (val != "") {
                        $("#ctl00_ContentPlaceHolder1_lbl_YJSSXXX").hide();
                    } else {
                        $("#ctl00_ContentPlaceHolder1_lbl_YJSSXXX").show();
                    }
                }
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-10 col-sm-9 loginRight" id="rightBg">
        <div class="row titleTable">
            <div class="tableL tabelList">
                <h4>
                    <a class="atip" href="<%=ResolveClientUrl("~/HEM_HRS/STAFF_NURSE_BASIC.aspx") %>">护理基本信息</a></h4>
            </div>
            <div class="tableR">
            </div>
        </div>
        <div class="mainTable">
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 姓 名：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputNACHN" runat="server" class="form-control" Enabled="false"
                        MaxLength="40"></asp:TextBox>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 性 别：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputGESCH" runat="server" CssClass="form-control">
                        <asp:ListItem Value="1">男</asp:ListItem>
                        <asp:ListItem Value="2">女</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-2" style="text-align:right">
                    <asp:LinkButton ID="lb_Phy" runat="server" onclick="lb_Phy_Click" CausesValidation="false">非护理简历</asp:LinkButton>
                </div>
                <div class="col-sm-2" style="text-align:right">
                <asp:LinkButton ID="lb_Send" runat="server" onclick="lb_Send_Click" CausesValidation="false">派遣制简历</asp:LinkButton>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 出生日期：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputGBDAT" runat="server" MaxLength="10" class="Wdate form-control"
                        onClick="WdatePicker()" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputGBDAT" runat="server" ControlToValidate="txtInputGBDAT"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择出生日期！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_txtInputGBDAT" runat="server" ControlToValidate="txtInputGBDAT"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的出生日期！"
                        ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 身份证号：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputICNUM" runat="server" MaxLength="18" class="form-control"
                        Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputICNUM" runat="server" ControlToValidate="txtInputICNUM"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入身份证号！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_txtInputICNUM" runat="server" ControlToValidate="txtInputICNUM"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的身份证号！"
                        SetFocusOnError="True" ValidationExpression="^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$"></asp:RegularExpressionValidator>
                </div>
                <div class="col-sm-2" style="text-align:right">
                    <asp:Label ID="lb_Look" runat="server" Text=''></asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 籍 贯：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRJG" runat="server" MaxLength="40" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_InputZHRJG" runat="server" ControlToValidate="txtInputZHRJG"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入籍贯！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 健康状况：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRJKZK" runat="server" MaxLength="10" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputZHRJKZK" runat="server" ControlToValidate="txtInputZHRJKZK"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入健康状况！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 身 高(CM)：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRGRSG" runat="server" MaxLength="3" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputZHRGRSG" runat="server" ControlToValidate="txtInputZHRGRSG"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入身高！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_txtInputZHRGRSG" runat="server" ControlToValidate="txtInputZHRGRSG"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的正整数！"
                        SetFocusOnError="True" ValidationExpression="^\+?[1-9][0-9]*$"></asp:RegularExpressionValidator>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    体重(KG)：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRGRTZ" runat="server" MaxLength="4" class="form-control"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="rev_txtInputZHRGRTZ" runat="server" ControlToValidate="txtInputZHRGRTZ"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的小数！"
                        SetFocusOnError="True" ValidationExpression="^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$"></asp:RegularExpressionValidator>

                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    视力(1.0)：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRSLJZ" runat="server" MaxLength="3" class="form-control"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="rev_txtInputZHRSLJZ" runat="server" ControlToValidate="txtInputZHRSLJZ"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的小数！"
                        SetFocusOnError="True" ValidationExpression="^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$"></asp:RegularExpressionValidator>
                    
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>统招高考成绩：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRTZGG" runat="server" MaxLength="4" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputZHRTZGG" runat="server" ControlToValidate="txtInputZHRTZGG"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入统招高考成绩！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_txtInputZHRTZGG" runat="server" ControlToValidate="txtInputZHRTZGG"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的数字(零或正整数)！"
                        SetFocusOnError="True" ValidationExpression="^(0|[1-9]\d*)$"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>应聘类型：</label>
                <div class="col-sm-3">
                <input type="hidden" runat="server" id="txtIsMaster" />
                    <asp:DropDownList ID="ddlInputTYPE_ID" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rev_txtInputTYPE_ID" runat="server" ControlToValidate="ddlInputTYPE_ID"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择应聘类型！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font><asp:Label ID="labZHRGZNX" runat="server" Text="三级甲等工作年限"></asp:Label>：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRGZNX" runat="server" MaxLength="10" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputZHRGZNX" runat="server" ControlToValidate="txtInputZHRGZNX"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入实习时长或三级甲等工作年限！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
                
            </div>
            <div class="form-group row" id="divZHRSXXX">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font><span id="spanZHRSXXX">实习医院：</span></label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtInputZHRSXXX" runat="server" MaxLength="100" class="form-control"></asp:TextBox>
                    <asp:Label ID="lbl_ZHRSXXX" runat="server" style="color: red;display:none" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入实习医院！
                    </asp:Label>
                </div>
            </div>
            <div class="form-group row" id="divYJSSXXX">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>研究生实习医院：</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtInputYJSSXXX" runat="server" MaxLength="100" class="form-control"></asp:TextBox>
                    <asp:Label ID="lbl_YJSSXXX" runat="server" style="color: red;display:none" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入研究生实习医院！
                    </asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    血 型：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputZHRYRXX" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 民 族：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputRACKY" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfv_ddlInputRACKY" runat="server" ControlToValidate="ddlInputRACKY"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择民族！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 是否服从调剂：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputZHRFZDJ" runat="server" CssClass="form-control">
                        <asp:ListItem Value="">否</asp:ListItem>
                        <asp:ListItem Value="X">是</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>政治面貌：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputPCODE" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfv_ddlInputPCODE" runat="server" ControlToValidate="ddlInputPCODE"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择政治面貌！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 婚姻状况：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputFAMST" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfv_ddlInputFAMST" runat="server" ControlToValidate="ddlInputFAMST"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择婚姻状况！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    子女个数：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputANZKD" runat="server" MaxLength="3" Text="0" class="form-control"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="rev_txtInputANZKD" runat="server" ControlToValidate="txtInputANZKD"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的数字！"
                        SetFocusOnError="True" ValidationExpression="^\+?[0-9]*$"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    外语水平：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputZHRWYSP" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    外语水平分数：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRWYFS" runat="server" MaxLength="8" class="form-control"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="rev_txtInputZHRWYFS" runat="server" ControlToValidate="txtInputZHRWYFS"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的数字！"
                        SetFocusOnError="True" ValidationExpression="^[1-9]\d*$"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    计算机水平：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputZHRJSJSP" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    手机号码：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputUSRID_TEL" runat="server" MaxLength="11" Enabled="false"
                        class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    家庭住址：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputLOCAT_JT" runat="server" MaxLength="40" class="form-control"></asp:TextBox>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    户籍地址：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputLOCAT_HJ" runat="server" MaxLength="40" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    现居住地：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputLOCAT_XJ" runat="server" MaxLength="40" class="form-control"></asp:TextBox>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    紧急联络人：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputFANAM" runat="server" MaxLength="40" class="form-control"></asp:TextBox>
                    <asp:Label ID="lbl_FANAM" runat="server" Visible="false" style="color: red;" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入紧急联络人！
                    </asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    联络人性别：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputFASEX" runat="server" CssClass="form-control">
                        <asp:ListItem Value="">请选择</asp:ListItem>
                        <asp:ListItem Value="1">男</asp:ListItem>
                        <asp:ListItem Value="2">女</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lbl_FASEX" runat="server" Visible="false" style="color: red;" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请选择联络人性别！
                    </asp:Label>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    联络人出生日期：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputFGBDT" runat="server" MaxLength="10" class="Wdate form-control"
                        onClick="WdatePicker()"></asp:TextBox>
                    <asp:Label ID="lbl_FGBDT" runat="server" Visible="false" style="color: red;" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入联络人出生日期！
                    </asp:Label>
                    <asp:RegularExpressionValidator ID="rev_txtInputFGBDT" runat="server" ControlToValidate="txtInputFGBDT"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的出生日期！"
                        ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    联络人手机号码：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputTELNR" runat="server" MaxLength="11" class="form-control"></asp:TextBox>
                    <asp:Label ID="lbl_TELNR" runat="server" Visible="false" style="color: red;" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入联络人手机号码！
                    </asp:Label>
                    <asp:RegularExpressionValidator ID="rev_InputTELNR" runat="server" ControlToValidate="txtInputTELNR"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的手机号码！"
                        SetFocusOnError="True" ValidationExpression="1\d{10}"></asp:RegularExpressionValidator>
                </div>
                <label for="regSkill" class="col-sm-2 control-label">
                    电子信箱：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputUSRID_MAIL" runat="server" MaxLength="100" Enabled="false"
                        class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="name" class="col-sm-2 control-label">是否护士资格证：</label>
                <div class="col-sm-3">
                    <asp:CheckBox ID="ckInputIS_CERTIFICATE" runat="server" />
                 </div>
                 <label for="regHobby" class="col-sm-2 control-label">
                    有无既往病史：</label>
                <div class="col-sm-3">
                     <asp:TextBox ID="txtInputJWBS" runat="server" MaxLength="50"  class="form-control"></asp:TextBox>
                </div>
            </div>
            <%--<div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    上传简历：</label>
                <div class="col-sm-8">
                    <asp:FileUpload ID="fu_load" runat="server" Style="display: inline-block" />
                    <asp:Label ID="lbl_ulmsg" runat="server" ForeColor="Red" Text=""></asp:Label>
                    <asp:Button ID="btn_upload" runat="server" Text="上传简历" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_upload_Click" />
                    <asp:Button ID="btn_delete" runat="server" Visible="false" class="btn btn-primary btn-sm btn-white" Text="删除" OnClick="btn_delete_Click" />请选择上传Word文件！
                </div>
            </div>--%>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    获奖经历：</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtInputZHRHJJL" runat="server" MaxLength="200" TextMode="MultiLine" Height="60px"
                        class="form-control"></asp:TextBox>
                </div>
                
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    特　　长：</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtInputZHRTC" runat="server" MaxLength="200" TextMode="MultiLine" Height="60px"
                        class="form-control"></asp:TextBox>
                </div>
                
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    备　　注：</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtInputZHRBZ" runat="server" MaxLength="200" TextMode="MultiLine" Height="60px"
                        class="form-control"></asp:TextBox>
                </div>
                
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    自我介绍：</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtInputZHRZWJS" runat="server" MaxLength="400" TextMode="MultiLine"
                        class="form-control" Height="60px"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="name" class="col-sm-2 control-label">&nbsp;</label>
                <label for="name" class="col-sm-10 control-label" style="text-align:left">
                        <font color="#ff0000">应聘者填写的相关资料信息必须完全真实，若经查实弄虚作假者，医院将随时取消其录取资格。</font></label>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font> 简历上传：</label>
                <div class="col-sm-8" style="text-align: left">
                    <asp:Label ID="lbl_FILE_PATH" runat="server" Text=''></asp:Label>
	     <asp:FileUpload ID="fu_load" runat="server" Style="display: inline-block" />
                    <asp:Label ID="lbl_ulmsg" runat="server" ForeColor="Red" Text=""></asp:Label>
                    
                    <asp:Button ID="btn_delete" runat="server" Visible="false" class="btn btn-primary btn-sm btn-white" Text="删除" OnClick="btn_delete_Click" />&nbsp;&nbsp;
                    </br>
                        <span style="color:Red;font-weight:bold;">研究生需在简历附上本科及最终学历、学位证图片，本科毕业生另需在简历附上高中毕业证图片。必须上传Word文件,文件大小为5MB以下,文件命名规范 姓名_学校(如：王五_武汉大学)！</span>
                    </br><asp:Label ID="Label1" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12" style="text-align: center">
                    <asp:Button ID="btn_Save" runat="server" Text="保存" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_Save_Click" />
                        &nbsp;&nbsp;
                     <asp:Button ID="btn_SaveNext" runat="server" Text="保存下一步" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_SaveNext_Click" />  &nbsp;&nbsp;
                    <asp:Button ID="btn_SubmitCheck" runat="server" Text="提交简历" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_SubmitCheck_Click" CausesValidation="false" /> 
                    <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
