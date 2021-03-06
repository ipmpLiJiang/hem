<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POSTER_HOME.aspx.cs"
    Inherits="Ipedf.Hrp.Hem.Sap.Web.POSTER_HOME" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>招聘启事</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link href="<%=ResolveClientUrl("~/css/bootstrap.css") %>" rel="stylesheet">
<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
      <script src="<%=ResolveClientUrl("~/scripts/html5shiv.min.js") %>"></script>
      <script src="<%=ResolveClientUrl("~/scripts/respond.min.js") %>"></script>
    <![endif]-->
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/main.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/login.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/modaldiv2.css") %>">
    <script src="<%=ResolveClientUrl("~/scripts/jquery.min.js") %>"></script>
    <script src="<%=ResolveClientUrl("~/scripts/bootstrap.min.js") %>"></script>
    <style>
		#mainbg .row {
			margin-left:8%;margin-top:0.5%;
		}
		.wrapper {
			margin:15px auto;width: 80%;
		}
		.loginbg {
			background: #d9e8f2;
			margin: 0 10px;
			padding: 4px;
		}
		.container {
			width:100%;
		}
		#light .form-group >div 
        {
            text-align:left;	
        }
        .white_content 
        {
        	min-height:64%;
        }
        
     
        
    </style>
    
        <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/register1.css") %>" media="screen">
     <script src="<%=ResolveClientUrl("~/scripts/respond.min.js") %>"></script>
    <script type="text/javascript">
        function showDiv() {
            //debugger
            CloseDiv1();
            document.getElementById('light').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
        }
        function showDiv1() {
            CloseDiv();
            //debugger     
            document.getElementById('light1').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
        }
        function CloseDiv() {
            document.getElementById('light').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
        }
        function CloseDiv1() {
            document.getElementById('light1').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
        }
        
        function msg_Click() {
            var num = 60;
            var strID = "#btn_Msg";//btn_Msg
            var str = $(strID).val();
            var time1 = setInterval(function(){
                num:$(strID).val(num+"s");;
                 --num;
              },1000);
            $(strID).attr("disabled",true);
            setTimeout(function(){
              $(strID).attr("disabled",false);
              clearInterval(time1);
              $(strID).val(str);
            },60000);
        }
        
function resizeTable(){
	        var _last = $(".table-header tr:eq(0)").children("td").last().index();
	        var _sclWid = $(".tb-wrapper").outerWidth()-$(".tablePos").outerWidth();
	        $(".tablePos tr:eq(0)").children("td").each(function(i){
		        var el = $(this);
		        _width = el.outerWidth();
		        if(i==_last&&_sclWid){
			        return false;
		        }
		        $(".table-header tr:eq(0)").children("td").eq(i).outerWidth(_width+"px");
	        });	
        }
        
        $(function(){        	
	        var _height = document.documentElement.clientHeight - 270+"px";
	        $(".tb-wrapper").height(_height);
	        resizeTable();
	        $(window).resize(function(){ resizeTable(); });
        });


    </script>
</head>
<body>
    <div class="header">
        <div class="headerImg">
            <img src="images/header.png" alt="">
        </div>
        <div class="headerMenu">
            <ol class="breadcrumb text-right">
                <marquee width="50%" scrollamount="2" direction="left" onmouseout="this.start()"
                    onmouseover="this.stop()">
                    <span class="whiteTxt headerTxt">欢迎登录华中科技大学同济医学院附属协和医院人才招聘系统!</span></marquee>
                    <li><a href="<%=ResolveClientUrl("~/UserLogin.aspx") %>">登录</a></li>
                <li><a href="#" onclick="showDiv()">注册</a></li>
            </ol>
        </div>
    </div>
    <div class="container">
        <div class="row loginbg" id="mainbg">
            <%--			<div class="col-md-3 loginLeft" id="leftBg">
				<img src="images/u29.jpg" alt="">
			</div>--%>
			<div class="row">
				<span class="glyphicon glyphicon-home"></span>
				<a id="navOne" href="#">招聘首页</a>
			</div>
            <div class="loginRight" id="rightBg">
                <div class="wrapper">
                    <form id="form1" runat="server" accept-charset="utf-8">
                    <div id="appPosOver">
                        <table class="table table-bordered table-header">
                            <tr>
                                <td class="th-lg">
                                    <strong>招聘启事</strong>
                                </td>
                                <td align="center">
                                    <strong>招聘职位</strong>
                                </td>
                                <td align="center">
                                    <strong>护理人员</strong>
                                </td>
                                <td align="center">
                                    <strong>发布日期</strong>
                                </td>
                                <td align="center">
                                    <strong>结束日期</strong>
                                </td>
                            </tr>
                        </table>
                        <asp:Repeater ID="rpt_List" runat="server" OnItemCommand="rpt_List_ItemCommand">
                            <HeaderTemplate>
                            <div class="tb-wrapper">
                                <table width="100%" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
                                
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td class="th-lg" style="text-align: center;width:45%;">
                                        <asp:LinkButton ID="lbn_Apply" CommandName="LOOK" CommandArgument='<%# Eval("ID") %>' CausesValidation="false"
                                            runat="server"><%# Eval("TITLE") %></asp:LinkButton>
                                    </td>
                                    <td align="center" style="width:25%;">
                                        <%# DataBinder.Eval(Container.DataItem, "RECRUIT_POSITION")%>
                                    </td>
                                    <td width="10%" align="center">
                                        <%# Eval("IS_NURSE_NAME")%>
                                    </td>
                                    <td align="center" style="width:10%;">
                                        <%# DataBinder.Eval(Container.DataItem, "PUBLISH_DATE", "{0:d}")%>
                                    </td>
                                    <td align="center" style="width:10%;">
                                        <%# DataBinder.Eval(Container.DataItem, "END_DATE", "{0:d}")%>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                                </div>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="lbl_PageNo" runat="server"></asp:Label>
                        <asp:DropDownList ID="ddlInputPageSize" runat="server" Width="50px" AutoPostBack="true"
                            onselectedindexchanged="ddlInputPageSize_SelectedIndexChanged">
                            <asp:ListItem Value="10">10</asp:ListItem>
                            <asp:ListItem Value="15">15</asp:ListItem>
                            <asp:ListItem Value="30">30</asp:ListItem>
                            <asp:ListItem Value="50">50</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-offset-9">
                        <asp:LinkButton ID="lbt_home" runat="server" CausesValidation="False" OnClick="lbt_home_Click">首页</asp:LinkButton>
                        <asp:LinkButton ID="lbt_back" runat="server" CausesValidation="False" OnClick="lbt_back_Click">前页</asp:LinkButton>
                        <asp:LinkButton ID="lbt_next" runat="server" CausesValidation="False" OnClick="lbt_next_Click">后页</asp:LinkButton>
                        <asp:LinkButton ID="lbt_last" runat="server" CausesValidation="False" OnClick="lbt_last_Click">尾页</asp:LinkButton>
                        |
                        <asp:TextBox ID="txt_PageNo" runat="server" Width="30" style="vertical-align:middle;">1</asp:TextBox>
                        <asp:Button ID="btn_GoPage" runat="server" class="btn btn-primary btn-sm btn-white" CausesValidation="False" OnClick="btn_GoPage_Click"
                            Text="GO" style="padding:1px 10px;" />
                    </div>
                    <div id="light" class="white_content alert" style="border: 1px solid #ccc;">
                        <asp:Panel ID="Panel1" runat="server" DefaultButton="btn_Save">
                        <div style="width: 100%; text-align: right; position: absolute;">
                            <a href="javascript:void(0)" class='close' aria-hidden='true'
                                style="border: 1px; margin: 5px 14px 10px 0;" onclick="CloseDiv()">&times;</a>&nbsp;
                        </div>
                        <div style="min-height: 98%; min-width: 93.5%;text-align: center; position: absolute; left: 0.8%;">
                            <div style=" width: 95%; margin-top: -15px; position: absolute">
                                <div class="form-group">
                                    <label for="regName" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 姓 名:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputNAME" runat="server" class="form-control" MaxLength="50"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_InputNAME" runat="server" ControlToValidate="txtInputNAME"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入姓名！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regTell" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 手机号码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputACCOUNT" runat="server" MaxLength="11" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_InputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入手机号码！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="rev_InputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的手机号码！"
                                            SetFocusOnError="True" ValidationExpression="1\d{10}"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regTell" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 验证码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txt_YZM" runat="server" style="width:70%" class="form-control"></asp:TextBox>
                                        <asp:Button ID="btn_Msg" runat="server" CausesValidation="false" Text="发送" class="btn btn-primary btn-sm btn-white"
                                            onclick="btn_Msg_Click" />
                                        <asp:RequiredFieldValidator ID="rfv_txt_YZM" runat="server" ControlToValidate="txt_YZM"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入验证码！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regEmail" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 电子邮箱:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputEMAIL" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_InputEMAIL" runat="server" ControlToValidate="txtInputEMAIL"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入邮件地址！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="rev_InputEMAIL" runat="server" ControlToValidate="txtInputEMAIL"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的邮件地址！"
                                            SetFocusOnError="True" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPass" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 设置密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD" runat="server" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_InputPASSWORD"
                                            ControlToValidate="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入密码！"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator SetFocusOnError="True" runat="server" ID="rev_InputPASSWORD"
                                            ControlToValidate="txtInputPASSWORD" ValidationExpression="[a-zA-z0-9]{6,20}"
                                            Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 可由6-20位英文字母、数字或下划线组成！"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPassAgain" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 重复密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD1" runat="server" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_PASSWORD1"
                                            ControlToValidate="txtInputPASSWORD1" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入确认密码！"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ID="cov_PASSWORD1" ControlToValidate="txtInputPASSWORD1"
                                            ControlToCompare="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 密码与确认密码不一致！"></asp:CompareValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                <a onclick="showDiv1()">海外用户注册</a>
                                </div>
                                
                                <div class="tishi2">
                                    <p>港澳台申请人直接投简历至电子邮箱：</p>
                                    <p>zhangjx-whunion@hust.edu.cn</p>
                                    <p>njinghui@hust.edu.cn</p>
                                </div>
                                
                            </div>
                        </div>
                        <div id="btnDIV" class="btndiv">
                            <asp:Button ID="btn_Save" runat="server" Text="注册" class="btn btn-primary" OnClick="btn_Save_Click" />
                            <input id="btnClose" class="btn btn-default" type="button" onclick="CloseDiv()" value="关闭" />
                            <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                        </div>
                        </asp:Panel>
                    </div>
                    
                    <div id="light1" class="white_content alert" style="border: 1px solid #ccc;">
					    <asp:Panel ID="Panel2" runat="server" DefaultButton="btn_Save">
                        <div style="width: 100%; text-align: right; position: absolute;">
                            <a href="javascript:void(0)" class='close' aria-hidden='true' style="border: 1px; margin: 5px 14px 10px 0;" onclick="CloseDiv1()">&times;</a>&nbsp;
                        </div>
                        <div style="min-height: 98%; min-width: 93.5%;text-align: center; position: absolute; left: 0.8%;">
                            <div style=" width: 95%; margin-top: -15px; position: absolute">
                                <div class="form-group">
                                    <label for="regName" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 姓 名:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputNAME_1" runat="server" ValidationGroup="R" class="form-control" MaxLength="50"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="R" runat="server" ControlToValidate="txtInputNAME_1"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入姓名！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="regEmail" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 电子邮箱:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputEMAIL_1" ValidationGroup="R" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="R" runat="server" ControlToValidate="txtInputEMAIL_1"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入邮件地址！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationGroup="R" runat="server" ControlToValidate="txtInputEMAIL_1"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的邮件地址！"
                                            SetFocusOnError="True" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPass" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 设置密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD_1" ValidationGroup="R" runat="server" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" ValidationGroup="R" runat="server" ID="RequiredFieldValidator5"
                                            ControlToValidate="txtInputPASSWORD_1" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入密码！"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator SetFocusOnError="True" ValidationGroup="R" runat="server" ID="RegularExpressionValidator3"
                                            ControlToValidate="txtInputPASSWORD_1" ValidationExpression="[a-zA-z0-9]{6,20}"
                                            Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 可由6-20位英文字母、数字或下划线组成！"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPassAgain" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 重复密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD1_1" runat="server" ValidationGroup="R" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_PASSWORD1_1"
                                            ControlToValidate="txtInputPASSWORD1_1" ValidationGroup="R" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入确认密码！"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ID="cov_PASSWORD1_1" ValidationGroup="R" ControlToValidate="txtInputPASSWORD1_1"
                                            ControlToCompare="txtInputPASSWORD_1" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 密码与确认密码不一致！"></asp:CompareValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                <a onclick="showDiv()">普通用户注册</a>
                                </div>
                                <div class="tishi1">
                                    <p>港澳台申请人直接投简历至电子邮箱：</p>
                                    <p>zhangjx-whunion@hust.edu.cn</p>
                                    <p>njinghui@hust.edu.cn</p>
                                </div>
                            </div>
                        </div>
                        <div id="btnDIV" class="btndiv">
                            <asp:Button ID="btn_Save_1" ValidationGroup="R" runat="server" Text="注册" class="btn btn-primary" OnClick="btn_Save_Click1" />
                            <input id="btnClose_1" class="btn btn-default" type="button" onclick="CloseDiv1()" value="关闭" />
                            <asp:Label ID="lbl_Error_1" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                        </div>
                        </asp:Panel>
                    </div>
                   
                    <div id="fade" class="black_overlay">
                    </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <div class="footer">
        <ol class="breadcrumb text-center whiteTxt">
            <li>
                <h6>
                    华中科技大学同济医学院附属协和医院人才招聘系统 COPYRIGHT 2015</h6>
            </li>
        </ol>
    </div>

    <script>
        $(function(){
	        setHeightRep("mainbg",150);
	        setHeightRep("appPosOver",270);
        });
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
    </script>

</body>
</html>
