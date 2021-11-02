<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true" CodeBehind="STAFF_FILEUPLOAD.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_FILEUPLOAD" Title="简历上传" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/person.css") %>">
<script src="<%=ResolveClientUrl("~/scripts/My97DatePicker/WdatePicker.js") %>" type="text/javascript"></script>
<script src="<%=ResolveClientUrl("~/scripts/person.js") %>" type="text/javascript"></script>
<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
<script type="text/javascript" language="javascript">
    $(function(){
        $("#mainNav li:eq(1)").addClass("active").siblings().removeClass("active");
        $(".tabelList span:eq(6)").children("a").addClass("tableActive").parent("span").siblings().children("a").removeClass("tableActive");
    });
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-10 col-sm-9 loginRight" id="rightBg">
	<div class="row titleTable">
		<div class="tableL tabelList">
			<h4><a class="atip" href="<%=ResolveClientUrl("~/HEM_HRS/STAFF_BASIC.aspx") %>">基本信息</a></h4>
		</div>
		<div class="tableR">
			
		</div>
	</div>
	<div class="mainTable" style="height:380px;">
	    <asp:Label ID="lbl_FILE_PATH" runat="server" Text=''></asp:Label>
	     <asp:FileUpload ID="fu_load" runat="server" Style="display: inline-block" />
                    <asp:Label ID="lbl_ulmsg" runat="server" ForeColor="Red" Text=""></asp:Label>
                    <asp:Button ID="btn_upload" runat="server" Text="上传简历" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_upload_Click" />&nbsp;&nbsp;
                    <asp:Button ID="btn_delete" runat="server" Visible="false" class="btn btn-primary btn-sm btn-white" Text="删除" OnClick="btn_delete_Click" />&nbsp;&nbsp;
                    <asp:Button ID="btn_SubmitCheck" runat="server" Text="提交简历" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_SubmitCheck_Click" CausesValidation="false" /></br>
                        <span style="color:Red">请选择上传Word文件,文件大小为5MB以下,文件命名规范 姓名_学校(如：王五_武汉大学)！</span>
                    </br><asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
    </div>  	
</div>
</asp:Content>
