<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true" CodeBehind="STAFF_LIST.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_LIST" Title="简历管理" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(function(){
            $("#mainNav li:eq(1)").addClass("active").siblings().removeClass("active");
            setHeightRep("appPosOver",295);
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
	        var _height = document.documentElement.clientHeight - 315+"px";
	        $(".tb-wrapper").height(_height);
	        resizeTable();
	        $(window).resize(function(){ resizeTable(); });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-10 col-sm-9 loginRight" id="rightBg">
	<div class="row titleTable">
		<div class="tableL tabelList">
			<h4><a href="#">简历管理</a></h4>
		</div>
		<div class="tableR">
			
		</div>
	</div>
	<div class="mainTable">
	    <div id="appPosOver">
	    <div style="text-align:right">
            <asp:LinkButton ID="lbl_Staff" runat="server" onclick="lbl_Staff_Click">新建非护理简历</asp:LinkButton>
            <asp:LinkButton ID="lbl_StaffNurse" runat="server" onclick="lbl_StaffNurse_Click">新建护理简历</asp:LinkButton>
           <asp:LinkButton ID="lbl_Send" runat="server" onclick="lbl_Send_Click">新建派遣制简历</asp:LinkButton>
	    </div>
	    <table class="table table-bordered table-header">
                            <tr>
					            <td ><strong>简历类型</strong></td>
					            <td  align="center"><strong>应聘类型</strong></td>
					            <td  align="center"><strong>状态</strong></td>
				            </tr>
                        </table>
	    <asp:Repeater ID="rpt_List" runat="server" onitemcommand="rpt_List_ItemCommand" OnItemDataBound="rpt_List_ItemDataBound">
                    <HeaderTemplate>
                    <div class="tb-wrapper">
			            <table width="100%"  cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
				            
		            </HeaderTemplate>
		            <ItemTemplate>
				            <tr>
					            <td style="width:45%;text-align:center">
					                <%# String_Staff(Eval("IS_NURSE").ToString()) %>
					            </td>
					            <td width="45%" align="center">
					                <asp:Label ID="lbl_Type_Id" runat="server" Text=''></asp:Label>
					            </td>
					            <td width="10%" align="center">
					                <asp:LinkButton ID="lbn_Edit" CommandName="EDIT" CommandArgument='<%# Eval("IS_NURSE") %>' runat="server">编辑</asp:LinkButton>|
					                <asp:Label ID="lb_Look" runat="server" Text=''></asp:Label>
					            </td>
				            </tr>
		            </ItemTemplate>
		            <FooterTemplate>
		                </table>  
		                </div>
		            </FooterTemplate>
                </asp:Repeater>
                
                </div>  	
	    <div class="col-md-4">
            <asp:Label ID="lbl_PageNo" Runat="server"></asp:Label>
            <asp:DropDownList ID="ddlInputPageSize" runat="server" Width="50px" AutoPostBack="true"
            onselectedindexchanged="ddlInputPageSize_SelectedIndexChanged">
        </asp:DropDownList>
        
        </div>
            <div class="col-md-offset-8">
        <asp:LinkButton ID="lbt_home" runat="server" CausesValidation="False" 
                        onclick="lbt_home_Click">首页</asp:LinkButton>
                    <asp:LinkButton ID="lbt_back" runat="server" CausesValidation="False" 
                        onclick="lbt_back_Click">前页</asp:LinkButton>
                    <asp:LinkButton ID="lbt_next" runat="server" CausesValidation="False" 
                        onclick="lbt_next_Click">后页</asp:LinkButton>
                    <asp:LinkButton ID="lbt_last" runat="server" CausesValidation="False" 
                        onclick="lbt_last_Click">尾页</asp:LinkButton>
                    |
                    <asp:TextBox ID="txt_PageNo" Runat="server" Width="30">1</asp:TextBox>
                    <asp:Button ID="btn_GoPage" class="btn btn-primary btn-sm btn-white" Runat="server" CausesValidation="False" 
                        OnClick="btn_GoPage_Click" Text="GO" style="padding:1px 10px;" />
        </div>
        
        <Com:ComDropDownList ID="ddlInputTYPE_ID" Visible="false" runat="server" Width="200">
            </Com:ComDropDownList>
            
	</div>  	
</div>
</asp:Content>
