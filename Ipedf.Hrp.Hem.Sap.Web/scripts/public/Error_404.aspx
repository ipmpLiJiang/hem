<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error_404.aspx.cs"
    Inherits="Ipedf.Hrp.Hem.Sap.Web.Error_404" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>错误页面404</title>
    <link href="<%=ResolveClientUrl("~/css/bootstrap.css") %>" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/main.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/login.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/modaldiv2.css") %>">
    <script src="<%=ResolveClientUrl("~/scripts/jquery.min.js") %>"></script>
    <script src="<%=ResolveClientUrl("~/scripts/bootstrap.min.js") %>"></script>
    <style>
		#mainbg .row {
			margin-left:8%;margin-top:0.5%;
		}
		.wrapper {
			margin:15px auto;width: 80%;
		}
		.loginbg {
			background: #d9e8f2;
			margin: 0 10px;
			padding: 4px;
		}
		.container {
			width:100%;
		}
		.headerImg 
		{
			background-image:url("../images/headerbg.png");
		}
    </style>
</head>
<body>
    <div class="header">
        <div class="headerImg">
            <img src="../images/header.png" alt="标题">
        </div>
        <div class="headerMenu">
            <ol class="breadcrumb text-right">
                <marquee width="50%" scrollamount="2" direction="left" onmouseout="this.start()"
                    onmouseover="this.stop()">
                    <span class="whiteTxt headerTxt">欢迎登录华中科技大学同济医学院附属协和医院人才招聘系统!</span></marquee>
                    <li>&nbsp;</li>
            </ol>
        </div>
    </div>
    <div class="container">
        <div class="row loginbg" id="mainbg" style="text-align:center;">
            <form id="form1" runat="server">
            <img src="../Images/Public/Error.PNG" style="margin-top:6%;"/><br />
            <asp:Label ID="lbl_Error" runat="server" Text=""></asp:Label>
            </form>
        </div>
    </div>
    <div class="footer">
        <ol class="breadcrumb text-center whiteTxt">
            <li>
                <h6>
                    华中科技大学同济医学院附属协和医院人才招聘系统 COPYRIGHT 2015</h6>
            </li>
        </ol>
    </div>

    <script>
        $(function(){
	        setHeightRep("mainbg",150);
        });
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
    </script>

</body>
</html>
