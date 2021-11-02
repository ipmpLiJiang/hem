<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageLogin.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.ManageLogin" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>管理登录</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link href="<%=ResolveClientUrl("~/css/bootstrap.css") %>" rel="stylesheet">
      <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
      <script src="<%=ResolveClientUrl("~/scripts/html5shiv.min.js") %>"></script>
      <script src="<%=ResolveClientUrl("~/scripts/respond.min.js") %>"></script>
    <![endif]-->
	<link href="<%=ResolveClientUrl("~/css/bootstrap.css") %>" type="text/css"  rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/admin.css") %>">
    <script src="<%=ResolveClientUrl("~/scripts/jquery.min.js") %>"></script>
    <script src="<%=ResolveClientUrl("~/scripts/admin.js") %>"></script>
</head>
<body>
    <div class="header">
		<div class="headerImg">
			<img src="images/header.png" alt="">
		</div>
		<div class="headerMenu">
			<ol class="breadcrumb text-left"><marquee width="50%" scrollamount="2" direction="left" onmouseout="this.start()" onmouseover="this.stop()"><span class="whiteTxt headerTxt">欢迎登录华中科技大学同济医学院附属协和医院人才招聘系统!</span></marquee>
			</ol>
		</div>
		
	</div>
	<div class="container">
		<div class="row loginbg" style="margin-bottom:9px" id="mainbg">
		    <form id="form1" runat="server" class="form-horizontal" style="margin:100px auto;">
			   <div class="form-group">
			      <label for="firstname" class="col-sm-2 col-sm-offset-3 control-label">用户名</label>
			      <div class="col-sm-2">
			        <asp:TextBox ID="txtInputACCOUNT" runat="server" class="form-control"   MaxLength = "50" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_InputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入账号！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
			      </div>
			   </div>
			   <div class="form-group row">
			      <label for="lastname" class="col-sm-2 col-sm-offset-3 control-label">密码</label>
			      <div class="col-sm-2">
			         <asp:TextBox ID="txtInputPASSWORD" runat="server" MaxLength = "50" class="form-control" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_InputPASSWORD"
                ControlToValidate="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入密码！"></asp:RequiredFieldValidator>
			      </div>
			   </div>
			   <div class="form-group row">
			      <div class="col-sm-2 col-sm-offset-5">
			         <div class="checkbox">
			            <label>
			               &nbsp;
			            </label>
			         </div>
			      </div>
			   </div>
			   <div class="form-group row">
			      <div class="col-sm-2 col-sm-offset-5">
			        <asp:Button ID="btn_Login" runat="server" Text="登录" class="btn btn-primary" style="width: 100%;" onclick="btn_Login_Click" />
                    <asp:Label ID="lbl_Error" runat="server" Visible="false" ForeColor="#ff0000"></asp:Label>
			      </div>
			   </div>
			</form>

		</div>
	</div>
	<div class="footer">
		<ol class="breadcrumb text-center whiteTxt">
			<li><h6>华中科技大学同济医学院附属协和医院人才招聘系统 COPYRIGHT 2015</h6></li>
		</ol>
	</div>
	
    <script src="<%=ResolveClientUrl("~/scripts/bootstrap.min.js") %>"></script>
</body>
</html>
