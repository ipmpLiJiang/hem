<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true"
    CodeBehind="RECRUIT_STAFF_LIST.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.RECRUIT_STAFF_LIST"
    Title="招聘广告-申请人员" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="<%=ResolveClientUrl("~/css/modaldiv.css") %>" rel="stylesheet">
    <style>
        .light_btn 
        {
        	margin-right:10%;
        }
        .Content2-btn 
        {
        	margin-right:1.2%;margin-bottom:0.2%;line-height:1.2;
        }
        </style>
    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">   
        $(function(){
            setHeightRep("appPosOver",320);
            var $el = $(".navBox .nav >li:eq(1)");
            bigNav($el,"RECRUIT_STAFF_LIST.aspx");
        });
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        } 
        function showDiv(ret,url) {  
        //debugger     
            document.getElementById('light').style.display='block';
            document.getElementById('fade').style.display='block';
            document.getElementById('ctl00_ContentPlaceHolder1_txt_hd_retid').value = ret;
            document.getElementById("iframe1").src = url;
        }
        function CloseDiv() {       
            document.getElementById('light').style.display='none';
            document.getElementById('fade').style.display='none';
            document.getElementById("iframe1").src = "";
            document.getElementById('ctl00_ContentPlaceHolder1_txt_hd_retid').value = "";
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
    <asp:Button ID="btn_YTG" runat="server" class="Content2-btn btn btn-primary btn-sm" OnClientClick="return confirm('确定要简历通过吗？')"
        Text="简历通过" OnClick="btn_YTG_Click" />
    &nbsp;
    <asp:Button ID="btn_YMS" runat="server" class="Content2-btn btn btn-primary btn-sm" OnClientClick="return confirm('确定要安排面试吗？')"
        Text="安排面试" OnClick="btn_YMS_Click" />
    &nbsp;
    <asp:Button ID="btn_YJJ" runat="server" class="Content2-btn btn btn-primary btn-sm" OnClientClick="return confirm('确定要拒绝简历吗？')"
        Text="拒绝简历" OnClick="btn_YJJ_Click" />
    &nbsp;
    <asp:Button ID="btn_YWC" runat="server" class="Content2-btn btn btn-primary btn-sm" OnClientClick="return confirm('确定已完成？')"
        Text="已完成" OnClick="btn_YWC_Click" />
    <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
    <div id="appPosOver">
        <table class="table table-bordered table-header">
                            <tr>
                        <td align="center">
                            <input id="chkSelItem" type="checkbox" onclick="selectAll('tab_List');" />
                        </td>
                        <td >
                            <strong>姓名</strong>
                        </td>
                        <td  align="center">
                            <strong>出生日期</strong>
                        </td>
                        <td align="center">
                            <strong>性别</strong>
                        </td>
                        <td  align="center">
                            <strong>籍贯</strong>
                        </td>
                        <td  align="center">
                            <strong>学校</strong>
                        </td>
                        <td  align="center">
                            <strong>学历</strong>
                        </td>
                        <td  align="center">
                            <strong>申请职位</strong>
                        </td>
                        <td align="center">
                            <strong>应聘类型</strong>
                        </td>
                        <td  align="center">
                            <strong>手机号码</strong>
                        </td>
                        <td style="display:none"><strong>操作</strong></td>
                        <td  align="center">
                            <strong>状态</strong>
                        </td>
                        
                    </tr>
                        </table>
        <asp:Repeater ID="rpt_List" runat="server">
            <HeaderTemplate>
            <div class="tb-wrapper">
                <table width="100%" id="tab_List" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
                    
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="width: 2%; text-align: center">
                        <asp:CheckBox ID="cbSelect" runat="server" />
                    </td>
                    <td style="width: 7%; text-align: center">
                        <a href="javascript:void(0)" onclick="showDiv('<%#Eval("ID")%>','<%#UrlDetail(Eval("STAFF_TYPE_ID"), Eval("ID"))%>')">
                            <%# Eval("NACHN")%></a>  
                    </td>
                    <td width="8%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "GBDAT", "{0:d}")%>
                    </td>
                    <td width="2%" align="center">
                        <%# Eval("SEX")%>
                    </td>
                    <td width="12%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "ZHRJG")%>
                    </td>
                    <td width="18%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "INSTI")%>
                    </td>
                    <td width="7%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "DT_HH_EDUCATION_NAME")%>
                    </td>
                    <td width="20%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "RECRUIT_POSITION")%>
                    </td>
                    <td width="8%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "TYPE_NAME")%>
                    </td>
                    <td width="8%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "USRID_TEL")%>
                    </td>
                    <td style="display: none">
                        <asp:Label ID="lbl_ID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ID")%>'></asp:Label>
                    </td>
                    <td width="8%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "STATUS_NAME")%>
                    </td>
                    
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
                </div>
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
        <asp:Button ID="btn_GoPage" runat="server" CausesValidation="False" OnClick="btn_GoPage_Click"
            class="btn btn-primary btn-sm btn-white" Text="GO" style="padding:1px 10px;" />
    </div>
    <div id="light" class="white_content alert"><div class="alert-wrapper">
        <div style="width: 100%; text-align: right; position: absolute;">
            <a href="javascript:void(0)" class='close' aria-hidden='true' style="border: 1px;margin:10px 20px 10px 0;" onclick="CloseDiv()">&times;</a>&nbsp;
        </div>
        <div style="min-height: 98%;min-width: 95.5%;padding: 4px;text-align: center;position:absolute;left:0.8%;">
            <iframe id="iframe1" style="height: 87%; width: 99%; margin-top: 30px;position:absolute;left:15px;" src="" frameborder="0"
                scrolling="yes"></iframe>
            
        </div>
        <div id="btnDIV" style="width: 50%; height: 5%;left:25%; border: 1px;position:absolute;bottom:2%;">
                <input id="txt_hd_retid" runat="server" type="hidden" />
                <asp:Button ID="btnPass" runat="server" Text="通过" class="light_btn btn btn-primary btn-sm" OnClick="btnPass_Click" OnClientClick="return confirm('确定要通过简历吗？')" />
                <asp:Button ID="btnNotAllow" runat="server" Text="拒绝" class="light_btn btn btn-primary btn-sm" OnClick="btnNotAllow_Click" OnClientClick="return confirm('确定要拒绝简历吗？')" />
                <input id="btnClose" type="button" onclick="CloseDiv()" class="light_btn btn btn-primary btn-sm btn-white" value="关闭" />
            </div>
    </div></div>
    <div id="fade" class="black_overlay"></div>
</asp:Content>
