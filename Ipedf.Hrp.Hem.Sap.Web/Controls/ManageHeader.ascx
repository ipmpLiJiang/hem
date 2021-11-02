<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageHeader.ascx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.Controls.ManageHeader" %>
<div class="header">
		<div class="headerImg">
			<img src="../images/header.png" alt="">
		</div>
	</div>
	<div class="navBox">
		<ul class="nav nav-pills text-center">
		   <li class="dropdown active">
		      <a class="dropdown-toggle" data-toggle="dropdown" href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_POSTER_LIST_PCD.aspx") %>">
		         招聘启事 <span class="caret"></span>
		      </a>
		      <ul class="dropdown-menu pull-right">
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_POSTER_EDIT.aspx") %>">新建启事</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_POSTER_LIST.aspx") %>">未发布启事</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_POSTER_LIST_PCD.aspx") %>">已发布启事</a></li>
		         <li class="divider"></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_POSTER_LIST_DUE.aspx") %>">已过期启事</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/STAFF_REAL_LIST.aspx") %>">人员面试结果</a></li>
		      </ul>
		   </li>
		   <li class="dropdown">
		      <a class="dropdown-toggle" data-toggle="dropdown" href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_STAFF_LIST.aspx") %>">
		         应聘人员 <span class="caret"></span>
		      </a>
		      <ul class="dropdown-menu pull-right">
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_STAFF_LIST_PANDING.aspx") %>">未处理</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_STAFF_LIST_PASS.aspx") %>">简历通过</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_STAFF_LIST_REVIEW.aspx") %>">安排面试</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_STAFF_LIST_FINISH.aspx") %>">已完成</a></li>
		         <li class="divider"></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_STAFF_LIST_REJECT.aspx") %>">已拒绝</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/PHONE_CALLBARK_LIST.aspx") %>">短信回复</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/APPLY_PHONE_MSSAGE_LIST.aspx") %>">历史信息</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_HPP/USER_STAFF_LIST.aspx") %>">用户简历</a></li>
		      </ul>
		   </li>
		   <li class="dropdown">
		      <a class="dropdown-toggle" data-toggle="dropdown" href="<%=ResolveClientUrl("~/HEM_SYS/USER_LIST.aspx") %>">
		         用户 <span class="caret"></span>
		      </a>
		      <ul class="dropdown-menu pull-right">
		         <li><a href="<%=ResolveClientUrl("~/HEM_SYS/MANAGE_USER_LIST.aspx") %>">管理用户</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_SYS/USER_LIST.aspx") %>">用户信息</a></li>
		         <li class="divider"></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_SYS/MANAGE_USER_ADD.aspx") %>">新建用户</a></li>
		         <li style="display:none"><a href="<%=ResolveClientUrl("~/HEM_SYS/MANAGE_USER_EDIT.aspx") %>">编辑用户</a></li>
		         <li><a href="<%=ResolveClientUrl("~/HEM_SYS/MANAGE_USER_PWD_EDIT.aspx") %>">修改密码</a></li>
		      </ul>
		   </li>
		    </ul>
		    <div style="text-align:right;padding-top:6px;padding-right:18px;">
		        <asp:LinkButton ID="lbt_Exit" style="color:#3300b7" runat="server" OnClientClick="return confirm('确定要退出吗？')" onclick="lbt_Exit_Click" CausesValidation="false">退出</asp:LinkButton>
		    </div>
	</div>	