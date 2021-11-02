<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true"
    CodeBehind="UserModify.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.UserModify" Title="修改个人信息" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" language="javascript">
    $(function(){
        $("#mainNav li:eq(3)").addClass("active").siblings().removeClass("active");
    });
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-10 col-sm-9 loginRight" id="rightBg">
        <div class="row titleTable">
            <div class="tableL tabelList">
                <h4>
                    <a href="#">修改个人信息</a></h4>
            </div>
            <div class="tableR">
            </div>
        </div>
        <div class="mainTable" style="height:380px;">
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>姓 名：</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInputNAME" runat="server" class="form-control" MaxLength="40"></asp:TextBox>
                    &nbsp;<font color="#777777">请填写真实的姓名</font>
                    <asp:RequiredFieldValidator ID="rfv_InputNAME" runat="server" ControlToValidate="txtInputNAME"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入姓名！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>手机号码/登录账户：</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInputACCOUNT" runat="server" MaxLength="11" class="form-control"></asp:TextBox>
                    <asp:Label ID="lab_IsExistACCOUNT" runat="server"></asp:Label>
                    &nbsp;<font color="#777777">请填写有效的手机号码/登录账户</font>
                    <asp:RequiredFieldValidator ID="rfv_InputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入手机号码/登录账户！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_InputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的手机号码/登录账户！"
                        SetFocusOnError="True" ValidationExpression="1\d{10}"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>重复手机号码/登录账户：</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInputACCOUNT1" runat="server" MaxLength="11" class="form-control"></asp:TextBox>
                    &nbsp;<font color="#777777">请重复填写手机号码/登录账户并保持一致</font>
                    <asp:RequiredFieldValidator ID="rfv_InputACCOUNT1" runat="server" ControlToValidate="txtInputACCOUNT1"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入重复手机号码/登录账户！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ID="cov_ACCOUNT1" ControlToValidate="txtInputACCOUNT1"
                        ControlToCompare="txtInputACCOUNT" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 两次输入的手机号码/登录账户必须一致！"></asp:CompareValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>电子邮箱：</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInputEMAIL" runat="server" MaxLength="100" class="form-control"></asp:TextBox>
                    <asp:Label ID="lab_IsExistEmail" runat="server"></asp:Label>
                    &nbsp;<font color="#777777">请填写有效且常用的E-mail地址</font>
                    <asp:RequiredFieldValidator ID="rfv_InputEMAIL" runat="server" ControlToValidate="txtInputEMAIL"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入邮件地址！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_InputEMAIL" runat="server" ControlToValidate="txtInputEMAIL"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的邮件地址！"
                        SetFocusOnError="True" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row" style="text-align:center">
                <asp:Button ID="btn_Save" runat="server" class="btn btn-primary btn-sm btn-white" Text="保存" OnClick="btn_Save_Click" />
                <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
