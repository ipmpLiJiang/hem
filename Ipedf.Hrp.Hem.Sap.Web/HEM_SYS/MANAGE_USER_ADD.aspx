<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true" CodeBehind="MANAGE_USER_ADD.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.MANAGE_USER_ADD" Title="新建用户" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
		$(function(){
		    setHeightRep("appPosOver",194);
            var $el = $(".navBox .nav >li:eq(2)");
            var $els = $el.children("ul").find("li").eq(3).children("a");
            bigNav($el,"MANAGE_USER_ADD.aspx");
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
            <asp:TextBox ID="txtInputACCOUNT" runat="server" class="form-control" Text=""></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_txtInputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT"
                Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入账户！"
                SetFocusOnError="True"></asp:RequiredFieldValidator>
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
        <label for="regSkill" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>设置密码：</label>
        <div class="col-sm-5">
            <asp:TextBox ID="txtInputPASSWORD" runat="server" MaxLength="50" class="form-control"
                TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_InputPASSWORD"
                ControlToValidate="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 请输入密码！"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator SetFocusOnError="True" runat="server" ID="rev_InputPASSWORD"
                ControlToValidate="txtInputPASSWORD" ValidationExpression="[a-zA-z0-9]{6,20}"
                Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 可由6-20位英文字母、数字或下划线组成！"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="form-group row">
        <label for="regHobby" class="col-sm-2 control-label" style="text-align: center">
            <font color="#ff0000">*</font>重复密码：</label>
        <div class="col-sm-5">
            <asp:TextBox ID="txtInputPASSWORD1" runat="server" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_PASSWORD1"
                                            ControlToValidate="txtInputPASSWORD1" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 请输入确认密码！"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ID="cov_PASSWORD1" ControlToValidate="txtInputPASSWORD1"
                                            ControlToCompare="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 密码与确认密码不一致！"></asp:CompareValidator>
        </div>
    </div>
    <div class="form-group row">
        <label for="regHobby" class="col-sm-2 control-label" style="text-align: center"></label>
        <div class="col-sm-5">
            <asp:Button ID="btn_Save" runat="server" class="btn btn-primary btn-sm" Text="保存" OnClick="btn_Save_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
        </div>
    </div>
</div>    
</asp:Content>
