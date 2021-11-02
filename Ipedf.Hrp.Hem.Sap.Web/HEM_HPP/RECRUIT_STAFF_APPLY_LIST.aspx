<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true" CodeBehind="RECRUIT_STAFF_APPLY_LIST.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.RECRUIT_STAFF_APPLY_LIST" Title="招聘启事-申请列表" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(function(){
            $("#mainNav li:eq(0)").addClass("active").siblings().removeClass("active");
            setHeightRep("appPosOver",315);
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
	        var _height = document.documentElement.clientHeight - 295+"px";
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
			<h4><a href="#">招聘信息</a></h4>
		</div>
		<div class="tableR">
			
		</div>
	</div>
	<div class="mainTable">
	    <div id="appPosOver">
	    <table class="table table-bordered table-header">
                            <tr>
					            <td><strong>招聘启事</strong></td>
					            <td align="center"><strong>招聘职位</strong></td>
					            <td align="center">
                                    <strong>护理人员</strong>
                                </td>
					            <td align="center"><strong>发布日期</strong></td>
					            <td align="center"><strong>结束日期</strong></td>
				            </tr>
                        </table>
	    <asp:Repeater ID="rpt_List" runat="server" onitemcommand="rpt_List_ItemCommand" >
                    <HeaderTemplate>
                    <div class="tb-wrapper">
			            <table width="100%" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
				            
		            </HeaderTemplate>
		            <ItemTemplate>
				            <tr>
					            <td style="width:40%;text-align:center">
					                <asp:LinkButton ID="lbn_Apply" CommandName="APPLY" CommandArgument='<%# Eval("ID") %>' runat="server"><%# Eval("TITLE") %></asp:LinkButton>
					            </td>
					            <td width="30%" align="center">
					                <%# DataBinder.Eval(Container.DataItem, "RECRUIT_POSITION")%>
					            </td>
					            <td width="10%" align="center">
                                        <%# Eval("IS_NURSE_NAME")%>
                                    </td>
					            <td width="10%" align="center">
					                <%# DataBinder.Eval(Container.DataItem, "PUBLISH_DATE", "{0:d}")%>
					            </td>
					            <td width="10%" align="center">
                                    <%# DataBinder.Eval(Container.DataItem, "END_DATE", "{0:d}")%>
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
            
	</div>  	
</div>
</asp:Content>
