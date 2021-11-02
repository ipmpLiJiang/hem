<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true"
    CodeBehind="Manage_Error.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.Manage_Error"
    Title="错误页面" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
		.tb-wrapper {
			margin-left:40%;
		}
    </style>
     <script language="javascript" type="text/javascript">   
        $(function(){
            setHeightRep("appPosOver",300);
//            var $el = $(".navBox .nav >li:eq(1)");
//            var $els = $el.children("ul").find("li").eq(6).children("a");
//            bigNav($el,"RECRUIT_POSTER_LIST_PCD.aspx");
//            secondNav($els);
        });
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
        
        $(function(){        	
	        var _height = document.documentElement.clientHeight - 215+"px";
	        $(".tb-wrapper").height(_height);
	        $(".row A").text("错误页面");
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="appPosOver">
<div class="tb-wrapper">
            <img src="../Images/Public/Error.PNG" style="margin-top:6%;"/><br />
            <asp:Label ID="lbl_Error" runat="server" Text=""></asp:Label>
</div>
</div>
</asp:Content>
