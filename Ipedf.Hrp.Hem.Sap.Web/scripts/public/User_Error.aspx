<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true"
    CodeBehind="User_Error.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.User_Error" Title="错误页面" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
		#mainbg .row {
			margin-left:8%;margin-top:0.5%;
		}
		.loginbg {
			background: #d9e8f2;
			margin: 0 10px;
			padding: 4px;
		}
    </style>
<script type="text/javascript" language="javascript">
    $(function(){
        $("#mainNav li:eq(8)").addClass("active").siblings().removeClass("active");
         var _height = document.documentElement.clientHeight - 162+"px";
	        $(".tb-wrapper").height(_height);
    });
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-10 col-sm-9 loginRight" id="rightBg">
    <div class="tb-wrapper">
        <div class="row loginbg" id="mainbg" style="text-align:center;">
            <img src="../Images/Public/Error.PNG" style="margin-top:6%;"/><br />
            <asp:Label ID="lbl_Error" runat="server" Text=""></asp:Label>
        </div>
    </div>   
</div>

    
</asp:Content>
