<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.Controls.Header" %>
<div class="header">
	<div class="headerImg">
		<img src="../images/header.png" alt="">
	</div>
	<div class="headerMenu">
		<ol class="breadcrumb text-right"><marquee width="50%" scrollamount="2" direction="left" onmouseout="this.start()" onmouseover="this.stop()"><span class="whiteTxt headerTxt">欢迎登录华中科技大学同济医学院附属协和医院人才招聘系统!</span></marquee>
		  <%--<li><a href="<%=ResolveClientUrl("~/UserLogin.aspx") %>">登录</a></li>--%>
		  <%--<li><a href="#" data-toggle="modal" data-target="#regModal">注册</a></li>--%>
		  <%--<a href="#" data-toggle="modal" data-target="#regModal">注册</a>--%>
		  <li>
              <asp:LinkButton ID="lbt_Exit" runat="server" OnClientClick="return confirm('确定要退出吗？')" onclick="lbt_Exit_Click" CausesValidation="false">退出</asp:LinkButton>
              </li>
		</ol>
	</div>
</div>