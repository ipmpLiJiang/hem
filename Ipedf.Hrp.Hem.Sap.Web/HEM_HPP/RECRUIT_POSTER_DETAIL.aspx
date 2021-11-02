<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECRUIT_POSTER_DETAIL.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.RECRUIT_POSTER_DETAIL" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>招聘启事详情</title>
    <link href="<%=ResolveClientUrl("~/css/bootstrap.css") %>" rel="stylesheet">
    <style type="text/css" rel="stylesheet">
.page-header {
	margin-bottom: 5px;margin-top:25px;padding-bottom:0;
}
.page-header h4 {
	text-align: center;
}
.page-header h4 small {
	margin: 0 1.5em;
}
.btnGroup {
	margin-bottom: 5px;
}
.panel {
	margin-bottom: 5px;
}
.btnGroup 
{
	margin-bottom:0;
}
.pagination {
	margin: 0;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class='page-header'><h4><asp:Label ID="lbl_TITLE" runat="server" Text=""></asp:Label><br>
                <small><asp:Label ID="lbl_DATA_SOURCE" runat="server" Text=""></asp:Label></small>
                <small><asp:Label ID="lbl_PUBLISHER" runat="server" Text=""></asp:Label></small>
                <small><asp:Label ID="lbl_PUBLISH_DATE" runat="server" Text=""></asp:Label></small></h4>
            </div><br />
            <div>
                  <asp:Label ID="lbl_CONTENT" style="font-family:'Arial Negreta', 'Arial';font-weight:400;font-size:12px;" runat="server" Text=""></asp:Label>
            </div>
    </form>
</body>
</html>
