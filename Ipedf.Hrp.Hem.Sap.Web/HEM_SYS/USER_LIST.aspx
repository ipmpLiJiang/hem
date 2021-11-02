<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true" CodeBehind="USER_LIST.aspx.cs" 
Inherits="Ipedf.Hrp.Hem.Sap.Web.USER_LIST" Title="用户信息" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" type="text/javascript">   
        $(function(){
            setHeightRep("appPosOver",320);
            var $el = $(".navBox .nav >li:eq(2)");
            var $els = $el.children("ul").find("li").eq(1).children("a");
            bigNav($el,"USER_LIST.aspx");
            secondNav($els);
        });
        
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
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
	        var _height = document.documentElement.clientHeight - 280+"px";
	        $(".tb-wrapper").height(_height);
	        resizeTable();
	        $(window).resize(function(){ resizeTable(); });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
姓名：<asp:TextBox ID="txt_NACHN" class="form-control" style="display:inline-block;"  Width="120px" runat="server"></asp:TextBox>&nbsp;手机号码：<asp:TextBox ID="txt_MOBILE" style="display:inline-block;" Width="120px"  class="form-control"
    runat="server"></asp:TextBox>&nbsp;
    应聘类型：<asp:DropDownList ID="ddlInputTYPE_ID" runat="server" Width="120px" class="form-control1"></asp:DropDownList>&nbsp;
    <asp:Button ID="btn_query" runat="server" class="Content2-btn btn btn-primary btn-sm" Text="查询" OnClick="btn_query_Click" />
<div id="appPosOver">
        <table class="table table-bordered table-header">
                      <tr>
                        <td >
                            <strong>姓名</strong>
                        </td>
                        <td>
                            <strong>手机号码</strong>
                        </td>
                        <td >
                            <strong>电子邮箱</strong>
                        </td>
                        <td >
                            <strong>简历类型</strong>
                        </td>
                        <td align="center">
                            <strong>状态</strong>
                        </td>
                        <td align="center">
                            <strong>创建日期</strong>
                        </td>
                        <td align="center">
                            <strong>操作</strong>
                        </td>
                    </tr>
                        </table>
        <asp:Repeater ID="rpt_List" runat="server" onitemcommand="rpt_List_ItemCommand">
            <HeaderTemplate><div class="tb-wrapper">
                <table width="100%" id="tab_List" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
                    
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="width: 10%; text-align: center">
                            <%#Eval("NAME")%>
                    </td>
                    <td style="width: 15%; text-align: center">
                            <%#Eval("ACCOUNT")%>
                    </td>
                    <td width="20%">
                        <%#Eval("EMAIL")%>
                    </td>
                    <td style="width: 20%; text-align: center">
                            <%#Eval("TYPE_ID_NAME")%>
                    </td>
                    <td width="10%">
                        <%# Eval("IS_USABL_NAME")%>
                    </td>
                    <td width="10%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "CREATE_DATE", "{0:d}")%>
                    </td>
                    <td width="15%" align="center">
                        <asp:LinkButton runat="server" CommandName="UPDATE1" CommandArgument='<%#Eval("ID")%>'>可用</asp:LinkButton>|
                        <asp:LinkButton runat="server" CommandName="UPDATE2" CommandArgument='<%#Eval("ID")%>'>不可用</asp:LinkButton>
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
     <input id="txt_hd_id" runat="server" type="hidden" />
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
