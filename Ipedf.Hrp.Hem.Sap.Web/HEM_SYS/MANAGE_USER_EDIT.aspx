<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true" CodeBehind="MANAGE_USER_EDIT.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.MANAGE_USER_EDIT" Title="编辑用户" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
		$(function(){
		    setHeightRep("appPosOver",194);
            var $el = $(".navBox .nav >li:eq(2)");
            var $els = $el.children("ul").find("li").eq(4).children("a");
            bigNav($el,"MANAGE_USER_EDIT.aspx");
            secondNav($els);
        });
        
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="appPosOver">
    <div class="form-group row">
        <label for="regSkill" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>账户：</label>
        <div class="col-sm-5">
            <asp:Label ID="lbl_ACCOUNT" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="form-group row">
        <label for="regHobby" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>姓名：</label>
        <div class="col-sm-5">
            <asp:TextBox ID="txtInputNAME" runat="server" class="form-control" Text=""></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_txtInputNAME" runat="server" ControlToValidate="txtInputNAME"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入姓名！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group row">
        <label for="regSkill" class="col-sm-2 control-label" style="text-align: center">
            手机号码：</label>
        <div class="col-sm-5">
        <asp:TextBox ID="txtInputMOBILE" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="regSkill" class="col-sm-2 control-label" style="text-align: center">
            电子邮箱：</label>
        <div class="col-sm-5">
        <asp:TextBox ID="txtInputEMAIL" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="regHobby" class="col-sm-2 control-label" style="text-align: center"></label>
        <div class="col-sm-5">
            <asp:Button ID="btn_Save" runat="server" class="btn btn-primary btn-sm" Text="保存" OnClick="btn_Save_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_Error" runat="server" Visible="False"></asp:Label>
        </div>
    </div>
 </div>
</asp:Content>
