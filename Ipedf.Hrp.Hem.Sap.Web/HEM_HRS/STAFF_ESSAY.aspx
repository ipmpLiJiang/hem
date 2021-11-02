<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true" CodeBehind="STAFF_ESSAY.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_ESSAY" Title="文章信息" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/person.css") %>">
<script src="<%=ResolveClientUrl("~/scripts/My97DatePicker/WdatePicker.js") %>" type="text/javascript"></script>
<script src="<%=ResolveClientUrl("~/scripts/person.js") %>" type="text/javascript"></script>
<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
<script type="text/javascript" language="javascript">
    $(function(){
        $("#mainNav li:eq(1)").addClass("active").siblings().removeClass("active");
        $(".tabelList span:eq(3)").children("a").addClass("tableActive").parent("span").siblings().children("a").removeClass("tableActive");
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
			            <table width="100%"  cellspacing="1" cellpadding="4" id="tab_List" class="tablePos table table-bordered">
				            <tr>
					            <td width="26%"><strong>文章名称</strong></td>
					            <td width="9%" align="center"><strong>出版时间</strong></td>
					            <td width="11%" align="center"><strong>出版刊物</strong></td>
					            <td width="10%" align="center"><strong>刊物级别</strong></td>
					            <td width="10%" align="center"><strong>发布状态</strong></td>
					            <td width="12%" align="center"><strong>刊号</strong></td>
					            <td width="12%" align="center"><strong>本人排名</strong></td>
					            <td width="10%" align="center"><strong>操作</strong></td>
				            </tr>
		            </HeaderTemplate>
		            <ItemTemplate>
				            <tr>
					            <td width="26%" style="word-break:break-all;">
					                <%# DataBinder.Eval(Container.DataItem, "ZHRWZMC")%>
					            </td>
					            <td width="9%" align="center">
					                <%# DataBinder.Eval(Container.DataItem, "BEGDA", "{0:d}")%>	
					            </td>
					            <td width="11%" align="center">
					                <asp:Label ID="lbl_ZHRCBKW" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="10%" align="center">
                                    <asp:Label ID="lbl_ZHRKWJB" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="10%" align="center">
					                <asp:Label ID="lbl_ZHRFBZT" runat="server" Text=''></asp:Label>
					                <%--<%# DataBinder.Eval(Container.DataItem, "ZHRYXYZ")%>	--%>
					            </td>
					            <td width="12%" align="center">
					                <asp:Label ID="lab_ZHRCBKH" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="11%" align="center">
					                <asp:Label ID="lbl_ZHRBRMP" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="10%" align="center">
					                <asp:LinkButton runat=server ID="lbn_Edit" CausesValidation="False" CommandArgument='<%# Eval("ID") %>' CommandName="Edit" >修改</asp:LinkButton>|
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
					<label for="regName" class="col-sm-2 control-label"><font color="#ff0000">*</font>文章名称：</label>
					<div class="col-sm-10">
					    <asp:TextBox ID="txtInputZHRWZMC" runat="server" class="form-control"  MaxLength = "100" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_txtInputZHRWZMC" runat="server" ControlToValidate="txtInputZHRWZMC"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入文章名称！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
					</div>
				</div>
				<div class="form-group row">
					<label for="regSkill" class="col-sm-2 control-label"><font color="#ff0000">*</font>刊物级别：</label>
					<div class="col-sm-3">
						<asp:DropDownList ID="ddlInputZHRKWJB" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfv_ddlInputZHRKWJB" runat="server" ControlToValidate="ddlInputZHRKWJB"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择刊物级别！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
					</div>
					<label for="regHobby" class="col-sm-2 control-label"><font color="#ff0000">*</font>本人排名：</label>
					<div class="col-sm-3">
						<asp:DropDownList ID="ddlInputZHRBRMP" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfv_ddlInputZHRBRMP" runat="server" ControlToValidate="ddlInputZHRBRMP"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择本人排名！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
					</div>
				</div>
				<div class="form-group row">
					<label for="regSkill" class="col-sm-2 control-label"><font color="#ff0000">*</font>出版时间：</label>
					<div class="col-sm-3">
						<asp:TextBox ID="txtInputBEGDA" runat="server" MaxLength="10" class="Wdate form-control" onClick="WdatePicker()" Width="200"></asp:TextBox>
			            <asp:RequiredFieldValidator ID="rfv_txtInputBEGDA" runat="server" ControlToValidate="txtInputBEGDA"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择出版时间！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
			            <asp:RegularExpressionValidator ID="rev_txtInputBEGDA" runat="server" ControlToValidate="txtInputBEGDA" 
			            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的出版时间！" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
					</div>
					<label for="regSkill" class="col-sm-2 control-label">发布状态：</label>
					<div class="col-sm-3">
						<asp:DropDownList ID="ddlInputZHRFBZT" runat="server" CssClass="form-control">
                        </asp:DropDownList>
					</div>
				</div>
				<div class="form-group row">
					<label for="regName" class="col-sm-2 control-label"><font color="#ff0000">*</font>出版刊物：</label>
					<div class="col-sm-10">
						<asp:TextBox ID="txtInputZHRCBKW" runat="server" MaxLength="100" class="form-control"></asp:TextBox>
			            <asp:RequiredFieldValidator ID="rfv_txtInputZHRCBKW" runat="server" ControlToValidate="txtInputZHRCBKW"
                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入出版刊物！"
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
					</div>
				</div>
				<div class="form-group row">
					<label for="regName" class="col-sm-2 control-label">刊　　号：</label>
					<div class="col-sm-10">
					    <asp:TextBox ID="txtInputZHRCBKH" runat="server" class="form-control"  MaxLength = "100" ></asp:TextBox>
					</div>

				</div>
				<div class="form-group row">
					<label for="regName" class="col-sm-2 control-label">影响因子：</label>
					<div class="col-sm-10">
						<asp:TextBox ID="txtInputZHRYXYZ" runat="server" class="form-control"   MaxLength = "100" ></asp:TextBox>
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
