<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true"
    CodeBehind="FIND_PASSWORD.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.FIND_PASSWORD"
    Title="修改密码" %>
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
                    <a href="#">修改密码</a></h4>
            </div>
            <div class="tableR">
            </div>
        </div>
        <div class="mainTable">
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>手机号码：</label>
                <div class="col-sm-6">
                    <asp:Label ID="lbl_ACCOUNT" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>原始密码：</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInputOldPASSWORD" runat="server" MaxLength="50" class="form-control" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_txtInputOldPASSWORD"
                        ControlToValidate="txtInputOldPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 请输入原始密码！"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>新密码：</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInputPASSWORD" runat="server" MaxLength="50" class="form-control" TextMode="Password"></asp:TextBox>
                    <font color="#777777">可由6-20位英文字母、数字或下划线组成</font>
                    <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_InputPASSWORD"
                        ControlToValidate="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 请输入新密码！"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator SetFocusOnError="True" runat="server" ID="rev_InputPASSWORD"
                        ControlToValidate="txtInputPASSWORD" ValidationExpression="[a-zA-z0-9]{6,20}"
                        Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 密码格式不正确！"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>确认密码：</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInputPASSWORD1" runat="server" MaxLength="50" class="form-control" TextMode="Password"></asp:TextBox>
                    <font color="#777777">请输入确认密码</font>
                    <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_PASSWORD1"
                        ControlToValidate="txtInputPASSWORD1" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 请输入确认密码！"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ID="cov_PASSWORD1" ControlToValidate="txtInputPASSWORD1"
                        ControlToCompare="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=../Images/Public/Icon1.gif align=absbottom> 新密码与确认密码不一致！"></asp:CompareValidator>
                </div>
            </div>
            <div class="form-group row" style="text-align:center">
                <asp:Button ID="btn_Save" runat="server" class="btn btn-primary btn-sm btn-white" Text="保存" OnClick="btn_Save_Click" />
                <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
