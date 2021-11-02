<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true"
    CodeBehind="RECRUIT_POSTER_EDIT.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.RECRUIT_POSTER_EDIT"
    Title="招聘启事编辑" ValidateRequest="false" %>

<%--<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="<%=ResolveClientUrl("~/scripts/My97DatePicker/WdatePicker.js") %>" type="text/javascript"></script>
    <link rel="stylesheet" href="<%=ResolveClientUrl("~/scripts/kindeditor/themes/default/default.css") %>" />
    <link rel="stylesheet" href="<%=ResolveClientUrl("~/scripts/kindeditor/plugins/code/prettify.css") %>" />

    <script charset="utf-8" src="<%=ResolveClientUrl("~/scripts/kindeditor/kindeditor.js") %>"></script>

    <script charset="utf-8" src="<%=ResolveClientUrl("~/scripts/kindeditor/lang/zh_CN.js") %>"></script>

    <script charset="utf-8" src="<%=ResolveClientUrl("~/scripts/kindeditor/plugins/code/prettify.js") %>"></script>
    <script type="text/javascript">
        KindEditor.ready(function(K) {
			var editor1 = K.create('#ctl00_ContentPlaceHolder1_txtInputCONTENT', {
				cssPath : '../scripts/kindeditor/plugins/code/prettify.css',
				uploadJson : '../scripts/kindeditor/asp.net/upload_json.ashx',
				fileManagerJson : '../scripts/kindeditor/asp.net/file_manager_json.ashx',
				allowFileManager : true,
				afterCreate : function() {
					var self = this;
					K.ctrl(document, 13, function() {
						self.sync();
						K('form[name=example]')[0].submit();
					});
					K.ctrl(self.edit.doc, 13, function() {
						self.sync();
						K('form[name=example]')[0].submit();
					});
				}
			});
			prettyPrint();
		});
		$(function(){
            var $el = $(".navBox .nav >li:eq(0)");
            var $els = $el.children("ul").find("li").eq(0).children("a");
            bigNav($el,"RECRUIT_POSTER_LIST_PCD.aspx");
            secondNav($els);
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group row">
        <label for="regName" class="col-sm-2 control-label" style="text-align:center">
            <font color="#ff0000">*</font>招聘标题：</label>
        <div class="col-sm-8">
            <asp:TextBox ID="txtInputTITLE" runat="server" class="form-control" MaxLength="60"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_txtInputTITLE" runat="server" ControlToValidate="txtInputTITLE"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入招聘标题！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group row">
        <label for="regName" class="col-sm-2 control-label" style="text-align:center">
            <font color="#ff0000">*</font>招聘职位：</label>
        <div class="col-sm-8">
            <asp:TextBox ID="txtInputRECRUIT_POSITION" runat="server" class="form-control" MaxLength="60"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_txtInputRECRUIT_POSITION" runat="server" ControlToValidate="txtInputRECRUIT_POSITION"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入招聘职位！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group row">
        <label for="regName" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>内　　容：</label>
        <div class="col-sm-10">
            <asp:TextBox ID="txtInputCONTENT" runat="server" class="form-control" Height="400px" Width="750px"></asp:TextBox>
            <%--<FCKeditorV2:FCKeditor runat="server" ID="txtInputCONTENT" DefaultLanguage="zh-cn" Height="400px" Width="750px">
            </FCKeditorV2:FCKeditor>--%>
            <asp:Label ID="lbl_CONTENT" runat="server" Visible="false" style="color: red;" Text="">
                <br />
                <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入内容！
            </asp:Label>
        </div>
    </div>
    <div class="form-group row">
        <label for="regName" class="col-sm-2 control-label" style="text-align:center;display:none;">
            护理人员：</label>
        <div class="col-sm-3" style="display:none;">
            是<asp:RadioButton ID="rbInputISNURSE1" GroupName="ISNURSE"  runat="server" />&nbsp;&nbsp;
            否<asp:RadioButton ID="rbInputISNURSE2" Checked="true" GroupName="ISNURSE"  runat="server" />
        </div>
        <label for="regName" class="col-sm-2 control-label" style="text-align:center">
            招聘类型：</label>
        <div class="col-sm-3">
            <asp:DropDownList ID="ddlISNURSE" runat="server">
            <asp:ListItem Text="护理" Value="1"></asp:ListItem>
            <asp:ListItem Text="非护理" Value="2" Selected="true"></asp:ListItem>
            <asp:ListItem Text="派遣制" Value="3"></asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <label for="regName" class="col-sm-2 control-label" style="text-align:center">
            是否公开：</label>
        <div class="col-sm-3">
            是<asp:RadioButton ID="rbInputISPUBLIC1" GroupName="ISPUBLIC"  runat="server" />&nbsp;&nbsp;
            否<asp:RadioButton ID="rbInputISPUBLIC2" Checked="true" GroupName="ISPUBLIC"  runat="server" />
        </div>
    </div>
    <div class="form-group row" style="display:none;">
        <label for="regName" class="col-sm-2 control-label" style="text-align:center">
            是否派遣制：</label>
        <div class="col-sm-3">
            是<asp:RadioButton ID="rbInputISSEND1" GroupName="ISSEND"  runat="server" />&nbsp;&nbsp;
            否<asp:RadioButton ID="rbInputISSEND2" Checked="true" GroupName="ISSEND"  runat="server" />
        </div>
        
    </div>
    <div class="form-group row">
        <label for="regSkill" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>发布人：</label>
        <div class="col-sm-3">
            <asp:TextBox ID="txtInputPUBLISHER" runat="server" class="form-control" Text="XXX" MaxLength="40"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_txtInputPUBLISHER" runat="server" ControlToValidate="txtInputPUBLISHER"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入发布人！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
        </div>
        <label for="regHobby" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>资料来源：</label>
        <div class="col-sm-3">
            <asp:TextBox ID="txtInputDATA_SOURCE" runat="server" class="form-control" Text="人事处" MaxLength="40"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_txtInputDATA_SOURCE" runat="server" ControlToValidate="txtInputDATA_SOURCE"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入资料来源！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group row">
        <label for="regSkill" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>发布日期：</label>
        <div class="col-sm-3">
            <asp:TextBox ID="txtInputPUBLISH_DATE" runat="server" class="Wdate form-control"
                onClick="WdatePicker()"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_InputPUBLISH_DATE" runat="server" ControlToValidate="txtInputPUBLISH_DATE"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择发布日期！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revtxtInputPUBLISH_DATE" runat="server" ControlToValidate="txtInputPUBLISH_DATE"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的发布日期！"
                ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
        </div>
        <label for="regHobby" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>截止日期：</label>
        <div class="col-sm-3">
            <asp:TextBox ID="txtInputEND_DATE" runat="server" class="Wdate form-control" onClick="WdatePicker()"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_InputEND_DATE" runat="server" ControlToValidate="txtInputEND_DATE"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择截止日期！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revtxtInputEND_DATE" runat="server" ControlToValidate="txtInputEND_DATE"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的截止日期！"
                ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="form-group row">
        <div class="7" style="text-align: center">
            <asp:Button ID="btn_Save" runat="server" class="btn btn-primary btn-sm" Text="保存" OnClick="btn_Save_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_Issue" runat="server" class="btn btn-primary btn-sm" Text="发布" CausesValidation="false" OnClientClick="return confirm('确定要发布吗？')"
                OnClick="btn_Issue_Click" />
            <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
        </div>
    </div>
</asp:Content>
