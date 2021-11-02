<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true" CodeBehind="STAFF_APPLY_DETAIL.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_APPLY_DETAIL" Title="应聘详情" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css" rel="stylesheet">
.page-header {
	margin-bottom: 0;margin-top:0;padding-bottom:0;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-10 col-sm-9 loginRight" id="rightBg">
	<div class="row titleTable">
		<div class="tableL tabelList">
			<h4><a href="#">应聘详情</a></h4>
		</div>
		<div class="tableR">
			
		</div>
	</div>
	<div class="mainTable">
	    <div class='page-header'><h4><asp:Label ID="lbl_TITLE" runat="server" Text=""></asp:Label><br>
            <small><asp:Label ID="lbl_DATA_SOURCE" runat="server" Text=""></asp:Label></small>
            <small><asp:Label ID="lbl_PUBLISHER" runat="server" Text=""></asp:Label></small>
            <small><asp:Label ID="lbl_PUBLISH_DATE" runat="server" Text=""></asp:Label></small></h4>
        </div>
        <div class="row btnGroup" style="display: block;">
                <div class="col-md-2">
                    <span class="glyphicon glyphicon-home" id="applyPos"><a href="<%=ResolveClientUrl("~/HEM_HPP/STAFF_APPLY_LIST.aspx") %>">返回</a></span>
                </div>
            </div><br />
        <div style="height:325px;overflow:auto;">
              <asp:Label ID="lbl_CONTENT" style="font-family:'Arial Negreta', 'Arial';font-weight:400;font-size:12px;" runat="server" Text=""></asp:Label>
        </div>
	</div>  	
</div>
</asp:Content>
