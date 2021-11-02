<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FORGET_PASSWORD1.aspx.cs"
    Inherits="Ipedf.Hrp.Hem.Sap.Web.FORGET_PASSWORD1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>找回密码</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link href="<%=ResolveClientUrl("~/css/bootstrap.css") %>" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/main.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/login.css") %>">

    <script src="<%=ResolveClientUrl("~/scripts/jquery.min.js") %>"></script>

    <script src="<%=ResolveClientUrl("~/scripts/bootstrap.min.js") %>"></script>

    <style>
        .header 
       {
       	    min-width:1166px;
       	}
        #mainbg .row
        {
            margin-left: 8%;
            margin-top: 0.5%;
        }
        .wrapper
        {
            margin: 50px auto;
            width: 80%;
        }
        .loginbg
        {
            background: #d9e8f2;
            margin: 0 10px;
            padding: 10px;
        }
        #light .form-group > div
        {
            text-align: left;
        }
        .white_content
        {
            min-height: 64%;
        }
        #mainbg
        {
            min-width: 1124px;
        }
        #leftBg
        {
            float: left;
            width: 30%;
        }
        #rightBg
        {
            float: left;
            width: 65%;
        }
        .pass-wrap 
        {
        	margin: 3px 25px 10px;
        }
        .pass-wrap label 
        {
        	float:left;
        	width:22%;
        }
        .pass-right
        {
        	float:left;
        }
        .pass-right input.form-control 
        {
        	display:inline-block;
        }
        .wrapper .loginBox .loginSub 
        {
        	padding:10px 20px;
        }
    </style>

    <script type="text/javascript">
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
            </ol>
        </div>
    </div>
    <div class="container">
        <div class="row loginbg" id="mainbg">
            <div class="loginLeft" id="leftBg">
                <img src="images/u29.jpg" alt="" style="padding-top: 30px;">
            </div>
            <!--<div class="row">
				<span class="glyphicon glyphicon-home"></span>
				<a id="navOne" href="#">找回密码</a>
			</div>-->
            <div class="loginRight" id="rightBg">
                <div class="wrapper">
                    <form id="form1" runat="server" accept-charset="utf-8">
                    <asp:Panel ID="Panel1" runat="server" DefaultButton="btn_Save">
                    <div class="loginBox fontNormal">
                        <div class="loginCenter">
                            <div class="pass-wrap clearfix">
                                <label>电子邮箱</label>
                                <div class="pass-right">
                                   <asp:TextBox ID="txtInputACCOUNT" runat="server" MaxLength="11" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtInputACCOUNT"
                                    Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入邮箱地址！"
                                    SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtInputACCOUNT"
                                    Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的邮箱地址！"
                                    SetFocusOnError="True" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator> 
                                </div>
                            </div>
                            <div class="pass-wrap clearfix">
                                <label>新密码</label>
                                <div class="pass-right">
                                    <asp:TextBox ID="txtInputPASSWORD" runat="server" MaxLength="50" class="form-control"
                                    TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_InputPASSWORD"
                                    ControlToValidate="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 请输入新密码！"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator SetFocusOnError="True" runat="server" ID="rev_InputPASSWORD"
                                    ControlToValidate="txtInputPASSWORD" ValidationExpression="[a-zA-z0-9]{6,20}"
                                    Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom>请输入6位数密码！"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="pass-wrap clearfix">
                                <label>确认密码</label>
                                <div class="pass-right">
                                    <asp:TextBox ID="txtInputPASSWORD1" runat="server" MaxLength="50" class="form-control"
                                    TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_PASSWORD1"
                                    ControlToValidate="txtInputPASSWORD1" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 请输入确认密码！"></asp:RequiredFieldValidator>
                                    <asp:CompareValidator runat="server" ID="cov_PASSWORD1" ControlToValidate="txtInputPASSWORD1"
                                    ControlToCompare="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 新密码与确认密码不一致！"></asp:CompareValidator>
                                </div>
                            </div>
                            <div class="pass-wrap clearfix">
                            <a href="FORGET_PASSWORD.aspx">普通用户密码找回</a>
                            </div>
                        </div>
                        <div class="loginSub" style="text-align: center;">
                            <asp:Button ID="btn_Save" runat="server" CssClass="loginBtn" Text="修改" OnClick="btn_Save_Click" style="float:none;"/>
                            <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                        </div>
                    </div>
                    </asp:Panel>
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
	       // setHeightRep("appPosOver",340);
        });
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
    </script>

</body>
</html>
