<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true" CodeBehind="STAFF_REAL_LIST.aspx.cs" 
Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_REAL_LIST" Title="人员面试结果导入" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="<%=ResolveClientUrl("~/css/modaldiv.css") %>" rel="stylesheet">
<style>
        .light_btn
        {
            margin-right: 10%;
        }
        .Content2-btn
        {
            margin-right: 1.2%;
            margin-bottom: 0.2%;
            line-height: 1.2;
        }
    </style>
    <script language="javascript" type="text/javascript">   
        $(function(){
            setHeightRep("appPosOver",310);
            var $el = $(".navBox .nav >li:eq(0)");
            var $els = $el.children("ul").find("li").eq(5).children("a");
            bigNav($el,"RECRUIT_POSTER_LIST_PCD.aspx");
            secondNav($els);
        });
        
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
        function showDiv(url) {  
        //debugger     
            document.getElementById('light').style.display='block';
            document.getElementById('fade').style.display='block';
            document.getElementById("iframe1").src = url;
        }
        function CloseDiv() {       
            document.getElementById('light').style.display='none';
            document.getElementById('fade').style.display='none';
            document.getElementById("iframe1").src = "";
        }
        function resizeTable(){
	        var _last = $(".table-header tr:eq(0)").children("td").last().index();
	        var _sclWid = $(".tb-wrapper").outerWidth()-$(".tablePos").outerWidth();
	        $(".tablePos tr:eq(0)").children("td").each(function(i){
		        var el = $(this);
		        _width = el.outerWidth();
		        if(i==_last&&_sclWid){
			        return false;
		        }
		        $(".table-header tr:eq(0)").children("td").eq(i).outerWidth(_width+"px");
	        });	
        }
        
        $(function(){        	
	        var _height = document.documentElement.clientHeight - 290+"px";
	        $(".tb-wrapper").height(_height);
	        resizeTable();
	        $(window).resize(function(){ resizeTable(); });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="form-group row">
 <asp:FileUpload ID="upfile" runat="server" style="display: inline-block" />
 <asp:Button ID="btnup" class="Content2-btn btn btn-primary btn-sm" runat="server" OnClientClick="return confirm('确定要将Excel数据导入系统吗？')"
        Text="导入" OnClick="btnup_Click" />
 <asp:Button ID="btn_update" class="Content2-btn btn btn-primary btn-sm" runat="server" OnClientClick="return confirm('确定要将数据更新系统吗？')"
        Text="更新" OnClick="btn_update_Click" />
        
 <asp:Button ID="btn_download" class="Content2-btn btn btn-primary btn-sm" runat="server"
        Text="下载模板" OnClick="btn_download_Click" />
 <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
 </div>
<div id="appPosOver">
        <table class="table table-bordered table-header">
                      <tr>
                        <td>
                            <strong>错误信息</strong>
                        </td>
                        <td>
                            <strong>手机号码</strong>
                        </td>
                        <td align="center">
                            <strong>姓名</strong>
                        </td>
                        <td align="center">
                            <strong>身高(CM)</strong>
                        </td>
                        <td align="center">
                            <strong>体重(KG)</strong>
                        </td>
                        <td align="center">
                            <strong>视力(1.0)</strong>
                        </td>
                        <td align="center">
                            <strong>笔试英语</strong>
                        </td>
                        <td align="center">
                            <strong>笔试理论</strong>
                        </td>
                        <td align="center">
                            <strong>操作能力</strong>
                        </td>
                        <td align="center">
                            <strong>创建日期</strong>
                        </td>
                    </tr>
                        </table>
        <asp:Repeater ID="rpt_List" runat="server">
            <HeaderTemplate><div class="tb-wrapper">
                <table width="100%" id="tab_List" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
                    
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="width: 20%; text-align: center">
                        <%# Eval("ERRORMESSAGE")%>
                    </td>
                    <td style="width: 10%; text-align: center">
                        <%# Eval("REAL_PHONE")%>
                    </td>
                    <td width="7%" align="center">
                        <%# Eval("REAL_NAME")%>
                    </td>
                    <td width="8%" align="center">
                        <%# Eval("REAL_ZHRGRSG")%>
                    </td>
                    <td width="8%" align="center">
                        <%# Eval("REAL_ZHRGRTZ")%>
                    </td>
                    <td width="8%" align="center">
                        <%# Eval("REAL_ZHRSLJZ")%>
                    </td>
                    <td width="8%" align="center">
                        <%# Eval("WRITTEN_ENGLISH")%>
                    </td>
                    <td width="8%" align="center">
                        <%# Eval("WRITTEN_THEORY")%>
                    </td>
                    <td width="8%" align="center">
                        <%# Eval("OPERATOR_ONE")%>
                    </td>
                    <td width="15%" align="center">
                        <%# Eval("CREATE_TIME")%>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table></div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    <div class="col-md-3">
        <asp:Label ID="lbl_PageNo" runat="server"></asp:Label>
        <asp:DropDownList ID="ddlInputPageSize" runat="server" Width="50px" AutoPostBack="true"
            onselectedindexchanged="ddlInputPageSize_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    <div class="col-md-offset-9">
        <asp:LinkButton ID="lbt_home" runat="server" CausesValidation="False" OnClick="lbt_home_Click">首页</asp:LinkButton>
        <asp:LinkButton ID="lbt_back" runat="server" CausesValidation="False" OnClick="lbt_back_Click">前页</asp:LinkButton>
        <asp:LinkButton ID="lbt_next" runat="server" CausesValidation="False" OnClick="lbt_next_Click">后页</asp:LinkButton>
        <asp:LinkButton ID="lbt_last" runat="server" CausesValidation="False" OnClick="lbt_last_Click">尾页</asp:LinkButton>
        |
        <asp:TextBox ID="txt_PageNo" runat="server" Width="30">1</asp:TextBox>
        <asp:Button ID="btn_GoPage" runat="server" CausesValidation="False" OnClick="btn_GoPage_Click" class="btn btn-primary btn-sm btn-white"
            Text="GO" style="padding:1px 10px;" />
    </div>
</asp:Content>
