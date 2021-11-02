<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true" CodeBehind="RECRUIT_STAFF_APPLY.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.RECRUIT_STAFF_APPLY" Title="招聘启事详情" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css" rel="stylesheet">
.mainTable .page-header {
	margin-bottom: 0;margin-top:0;padding-bottom:0;
}
.mainTable .page-header h4 {
	text-align: center;
}
.mainTable .page-header h4 small {
	margin: 0 1.5em;
}
.btnGroup {
	margin-bottom: 5px;
}
.mainTable .panel {
	margin-bottom: 5px;
}
.mainTable .btnGroup 
{
	margin-bottom:0;
}
.pagination {
	margin: 0;
}
</style>
<script type="text/javascript">
        $(function(){
            $("#mainNav li:eq(0)").addClass("active").siblings().removeClass("active");
        });
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-10 col-sm-9 loginRight" id="rightBg">
	<div class="row titleTable">
		<div class="tableL tabelList">
			<h4><a href="#">招聘信息</a></h4>
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
                    <span class="glyphicon glyphicon-home" id="applyPos"><a href="<%=ResolveClientUrl("~/HEM_HPP/RECRUIT_STAFF_APPLY_LIST.aspx") %>">返回</a></span>
                </div>
                    <div class="col-md-offset-11">
                <asp:Button ID="btn_Apply" runat="server" style="padding:1px 10px;margin-bottom:4px;" CssClass="btn btn-primary btn-sm" Text="申请" OnClientClick="return confirm('确定要申请吗？')"
                    onclick="btn_Apply_Click" />
                </div>
            </div>
            <div style="height:335px;overflow:auto;">
                  <asp:Label ID="lbl_CONTENT" style="font-family:'Arial Negreta', 'Arial';font-weight:400;font-size:12px;" runat="server" Text=""></asp:Label>
            </div>
    </div>  	
</div>
</asp:Content>
