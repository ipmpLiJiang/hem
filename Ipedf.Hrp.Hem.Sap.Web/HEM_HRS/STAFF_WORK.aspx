<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true" CodeBehind="STAFF_WORK.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_WORK" Title="工作经历" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/person.css") %>">
<script src="<%=ResolveClientUrl("~/scripts/My97DatePicker/WdatePicker.js") %>" type="text/javascript"></script>
<script src="<%=ResolveClientUrl("~/scripts/person.js") %>" type="text/javascript"></script>
<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
<script type="text/javascript" language="javascript">
    $(function(){
        $("#mainNav li:eq(1)").addClass("active").siblings().removeClass("active");
        $(".tabelList span:eq(1)").children("a").addClass("tableActive").parent("span").siblings().children("a").removeClass("tableActive");
    });
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-10 col-sm-9 loginRight" id="rightBg">
	<div class="row titleTable">
		<div class="tableL tabelList">
			<h4><a class="atip" href="<%=ResolveClientUrl("~/HEM_HRS/STAFF_BASIC.aspx") %>">基本信息</a></h4>
		</div>
		<div class="tableR">
			
		</div>
	</div>
	<div class="mainTable">
	    <table border="0" style="width:100%">
        <tr>
            <td>
                <div class="col-md-3">
                    <asp:Label ID="lbl_PageNo" Runat="server"></asp:Label>
                </div>
                    <div class="col-md-offset-9">
                <asp:LinkButton ID="lbt_home" runat="server" CausesValidation="False" 
                                onclick="lbt_home_Click">首页</asp:LinkButton>
                            <asp:LinkButton ID="lbt_back" runat="server" CausesValidation="False" 
                                onclick="lbt_back_Click">前页</asp:LinkButton>
                            <asp:LinkButton ID="lbt_next" runat="server" CausesValidation="False" 
                                onclick="lbt_next_Click">后页</asp:LinkButton>
                            <asp:LinkButton ID="lbt_last" runat="server" CausesValidation="False" 
                                onclick="lbt_last_Click">尾页</asp:LinkButton>
                            |
                            <asp:TextBox ID="txt_PageNo" Runat="server" Width="30">1</asp:TextBox>
                            <asp:Button ID="btn_GoPage" class="btn btn-primary btn-sm btn-white" Runat="server" CausesValidation="False" 
                                OnClick="btn_GoPage_Click" Text="GO" style="padding:1px 10px;" />
                </div>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Repeater ID="rpt_List" runat="server" onitemcommand="rpt_List_ItemCommand" 
                    onitemdatabound="rpt_List_ItemDataBound">
		            <HeaderTemplate>
			            <table width="100%" id="tab_List" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
				            <tr>
					            <td width="30%"><strong>工作单位</strong></td>
					            <td width="10%" align="center"><strong>开始日期</strong></td>
					            <td width="10%" align="center"><strong>结束日期</strong></td>
					            <td width="15%" align="center"><strong>工作部门</strong></td>
					            <td width="15%" align="center"><strong>职务</strong></td>
					            <td width="10%" align="center"><strong>学历/学位</strong></td>
					            <td width="10%" align="center"><strong>操作</strong></td>
				            </tr>
		            </HeaderTemplate>
		            <ItemTemplate>
				            <tr>
					            <td width="30%" style="word-break:break-all;">
					                <%# DataBinder.Eval(Container.DataItem, "ZHRXXDW")%>
					            </td>
					            <td width="10%" align="center">
					                <%# DataBinder.Eval(Container.DataItem, "BEGDA", "{0:d}")%>	
					            </td>
					            <td width="10%" align="center">
					                <%# DataBinder.Eval(Container.DataItem, "ENDDA", "{0:d}")%>
					            </td>
					            <td width="15%" align="center">
					                <asp:Label ID="lab_ZHRZYBM" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="15%" align="center">
					                <asp:Label ID="lab_ZHRGZZW" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="10%" align="center">
                                    <asp:Label ID="lbl_SLART" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="10%" align="center">
					                <asp:LinkButton runat=server ID="lbn_Edit" CausesValidation="False" CommandArgument='<%# Eval("ID") %>' CommandName="Edit" >修改</asp:LinkButton> | 
					                <asp:LinkButton runat=server ID="lbn_Delete" CausesValidation="False" CommandArgument='<%# Eval("ID") %>' CommandName="Delete" OnClientClick="return confirm('确定删除吗？')">删除</asp:LinkButton>
					            </td>
				            </tr>
			            
		            </ItemTemplate>
		            <FooterTemplate></table></FooterTemplate>
	            </asp:Repeater>
            </td>
        </tr>
        </table>
        <div class="form-group row">
					<label for="regName" class="col-sm-2 control-label"><font color="#ff0000">*</font>工作单位：</label>
					<div class="col-sm-10">
					    <asp:TextBox ID="txtInputZHRXXDW" runat="server" class="form-control"  MaxLength = "100" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_txtInputZHRXXDW" runat="server" ControlToValidate="txtInputZHRXXDW"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入工作单位！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
					</div>
				</div>
				<div class="form-group row">
					<label for="regSkill" class="col-sm-2 control-label"><font color="#ff0000">*</font>开始日期：</label>
					<div class="col-sm-3">
						<asp:TextBox ID="txtInputBEGDA" runat="server" MaxLength="10" class="Wdate form-control" onClick="WdatePicker()" Width="200"></asp:TextBox>
			            <asp:RequiredFieldValidator ID="rfv_txtInputBEGDA" runat="server" ControlToValidate="txtInputBEGDA"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择开始日期！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
			            <asp:RegularExpressionValidator ID="rev_txtInputBEGDA" runat="server" ControlToValidate="txtInputBEGDA" 
			                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的开始日期！" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
					</div>
					<label for="regHobby" class="col-sm-2 control-label"><font color="#ff0000">*</font>结束日期：</label>
					<div class="col-sm-3">
						<asp:TextBox ID="txtInputENDDA" runat="server" MaxLength="10" class="Wdate form-control" onClick="WdatePicker()" Width="200"></asp:TextBox>
			            <asp:RequiredFieldValidator ID="rfv_txtInputENDDA" runat="server" ControlToValidate="txtInputENDDA"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择结束日期！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
			            <asp:RegularExpressionValidator ID="rev_txtInputENDDA" runat="server" ControlToValidate="txtInputENDDA" 
			            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的结束日期！" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
					</div>
				</div>
				
				<div class="form-group row">
					<label for="regName" class="col-sm-2 control-label"><font color="#ff0000">*</font>工作部门：</label>
					<div class="col-sm-10">
						 <asp:TextBox ID="txtInputZHRZYBM" runat="server" class="form-control" MaxLength = "100" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_txtInputZHRZYBM" runat="server" ControlToValidate="txtInputZHRZYBM"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入工作部门！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
					</div>
				</div>
				<div class="form-group row">
					<label for="regName" class="col-sm-2 control-label"><font color="#ff0000">*</font>职　　务：</label>
					<div class="col-sm-10">
					    <asp:TextBox ID="txtInputZHRGZZW" runat="server" class="form-control"  MaxLength = "100" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_txtInputZHRGZZW" runat="server" ControlToValidate="txtInputZHRGZZW"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入职务！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
					</div>
				</div>
				<div class="form-group row">
				     <label for="name" class="col-sm-2 control-label">学　　历：</label>
				     <div class="col-sm-3">
				        <asp:DropDownList ID="ddlInputSLART" runat="server" CssClass="form-control"> 
                        </asp:DropDownList>
				     </div>
				</div>
				<div class="form-group row">
				    <div class="7"  style="text-align:center">
					    <asp:Button ID="btn_Save" runat="server" class="btn btn-primary btn-sm btn-white" Text="保存" onclick="btn_Save_Click"/>
                        &nbsp;&nbsp;
                     <asp:Button ID="btn_SaveNext" runat="server" Text="下一步" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_SaveNext_Click" CausesValidation="false" />   &nbsp;&nbsp;
                    <asp:Button ID="btn_SubmitCheck" runat="server" Text="提交简历" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_SubmitCheck_Click" CausesValidation="false" />
                        <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                    </div>
				</div>
    
    </div>  	
</div>
</asp:Content>
