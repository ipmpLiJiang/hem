<%@ Page Language="C#" MasterPageFile="~/Controls/Manage.Master" AutoEventWireup="true"
    CodeBehind="RECRUIT_STAFF_LIST_Q.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.RECRUIT_STAFF_LIST_Q"
    Title="招聘广告-申请人员" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="<%=ResolveClientUrl("~/css/modaldiv.css") %>" rel="stylesheet">
    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("~/scripts/json2.js") %>"></script>
    <script src="<%=ResolveClientUrl("~/scripts/checkData.js") %>"></script>
    <style>
        .white_content_second
        {
            left: 25%;
            top: 15%;
            min-width: 50%;
            min-height: 55%;
        }
        .white_textarea
        {
            width: 85%;
            height: 70%;
            position: absolute;
            top: 13%;
            left: 10%;
        }
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
        
        .window_sx
        {
            width: 500px;
            position: absolute;
        }
        .pew_sx
        {
            width: 100%;
            height: 20px;
            text-align: center;
            line-height: 20px;
            font-weight:bolder;
            
            background: #33A695;
            cursor: default;
        }
        .divtn_sx
        {
        	text-align:left;
        	}
        .container_sx
        {
            width: 100%;
            height: calc(100% - 30px);
            text-align: left;
            background:#FFF;
            border:1px solid #33A695;
        }
        
        .btnPadding
        {
        	padding:2px 8px;
        }
        
        #at-table{
			border-collapse: collapse;
			width:100%;
		}
		#at-table th,td{
			border: 1px solid #B5D6E6;padding:3px 8px;
			text-align:left;
		}
		#at-table thead{
			background: #CDEAFB;
		}
		#at-table th{
			font-weight: normal;
			font-size: 15px;
		}
		#at-table select{
			border: 1px solid #ccc;
			width:100%;
		}
		#at-table input{
			border: 1px solid #ccc;
			border-radius: 5px;
			padding:3px 0 2px 5px;
			width:100%;
		}
		#at-table a{
			cursor: pointer;
		}
		.modal_sel{
			position: relative;
			width:120px;
		}
		.modal_sel>strong
		{
		    position:absolute;
		    width:0;
		    height:0;
		    border-top:6px solid #333;
		    border-left:3px solid transparent;
		    border-right:3px solid transparent;
		    right:5px;
		    top:50%;
		    margin-top:-3px
		}
		.modal_sel input{
			vertical-align:middle;
			height:20px;
			width:100%;
			cursor:default;
			border-radius:0!important
		}
		.sel_cli{
			position:absolute;
			left:0;
			top:19px;
			width:100%;
			display:none;
			z-index:99
		}
		.sel_cli select{
			width:100%;
		}
		.sel_cli select option:hover
		{
		    background:#1e90ff;
		    color:white
		}
		
    </style>

    <script language="javascript" type="text/javascript"> 
        $(document).ready(function(){
		   

	    });
	    $(document).on("click",".sel_open",function(event){
	        $(".sel_cli").css("display","none");
		    $(this).next().css('display', 'block');
		    event.stopPropagation();
	    });
	    $(document).on("change",".sel_cli .sel",function(){
	        $(this).parent().css("display", "none").prev().val($(this).find("option:selected").html())
		    //$(this).parents(".sel_cli").css("display","none").prev().val($(this).html())
	    });
	    $(document).click(function() {
		    $(".sel_cli").css("display","none")
	    });  
        $(function(){
            setHeightRep("appPosOver",320);
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
        function showDiv_second() {  
        //debugger     
            var ck = document.getElementById('ctl00_ContentPlaceHolder1_ck_ISALL');
            if(ck.checked)
            {
                if (confirm("已勾选全部,您确定要发送短信给当前状态的所有应聘人员吗？")) {  
                    document.getElementById('light-second').style.display='block';
                    document.getElementById('fade').style.display='block';
                }  
            }else
            {
                document.getElementById('light-second').style.display='block';
                document.getElementById('fade').style.display='block';
            }
            
        }
        
        function execAllUpdateStatus(status)
        {
            var ck = document.getElementById('ctl00_ContentPlaceHolder1_ck_ISALL');
            var msg= "";
            if(ck.checked)
            {
                msg= "已勾选全部,您确定要全部更新为";
                if(status=="0")
                {
                    msg= msg + "未处理状态吗？";
                }else if(status=="1"){
                    msg= msg + "简历通过状态吗？";
                }else if(status=="2"){
                    msg= msg + "安排面试状态吗？";
                }else if(status=="3"){
                    msg= msg + "已拒绝状态吗？";
                }else if(status=="4"){
                    msg= msg + "已完成状态吗？";
                }
            }else{
                if(status=="0")
                {
                    msg= "确定更改为未处理状态吗？";
                }else if(status=="1"){
                    msg= "确定更改为简历通过状态吗？";
                }else if(status=="2"){
                    msg= "确定更改为安排面试状态吗？";
                }else if(status=="3"){
                    msg= "确定更改为已拒绝状态吗？";
                }else if(status=="4"){
                    msg= "确定更改为已完成状态吗？";
                }
            }
            
            if(msg != "")
            {
                if (confirm(msg)) {  
                    return true; 
                }else
                {
                    return false;
                }
            }
        }
        
        function CloseDiv_second() {       
            document.getElementById('light-second').style.display='none';
            document.getElementById('fade').style.display='none';
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
	        $("#a_divsx").click(function(){
	            $('#divSx').css("left",$("#ctl00_ContentPlaceHolder1_ddlInputTYPE_ID").offset().left);
	            $('#divSx').css("top",$(this).offset().top + 28);
	            initSXData();
	            $('#divSx').show();
	        });
        });
    </script>
    
    <script type="text/javascript">
        $(function () {
            $("#sel-hidden").hide();
            changSelectHandle();
            console.log($("#ctl00_ContentPlaceHolder1_hf").val());
            $("#sel-hidden select").change(function () {
                changSelectHandle();
            });
            $("#add-btn").click(function () {
                var _index = $("#at-table tbody tr").length;
                var _sid = "ls" + _index;
                var div = '<tr>'
				    + '<td class="' + _sid + '"></td>'
//				    + '<td><select name="L">'
//				        + '<option value="0">无</option>'
//					    + '<option value="(">(</option>'
//					    + '<option value="((">((</option>'
//					    + '<option value="(((">(((</option>'
//				    + '</select></td>'
				    + '<td><select name="Y">'
					    + '<option value="=">=</option>'
					    + '<option value=">">&gt;</option>'
					    + '<option value="<">&lt;</option>'
					    + '<option value=">=">&ge;</option>'
					    + '<option value="<=">&le;</option>'
					    + '<option value="LIKE">包含</option>'
				    + '</select></td>'
				    + '<td class="changetxt"><input type="text" name="V" value="" placeholder="文本标题"></td>'
//				    + '<td><select name="R">'
//				        + '<option value="0">无</option>'
//					    + '<option value=")">)</option>'
//					    + '<option value="))">))</option>'
//					    + '<option value=")))">)))</option>'
//				    + '</select></td>'
//				    + '<td><select name="W">'
//					    + '<option value="AND">AND</option>'
//					    + '<option value="OR">OR</option>'
//				    + '</select></td>'
                    + '<td><span name="L"><a herf="#" onclick="deletetabletr(this)"><span class="glyphicon glyphicon-remove" style="color:#a94442;"></span></a></span></td>'
				    + '</tr>';
                $("#at-table tbody").append(div);
                
                $("#lselect").empty();
                $("#hd_select option").clone(false).appendTo($("#lselect"));
                $("#lselect").first().parent().parent().clone(false).appendTo("." + _sid);
            });
            $("#at-btn").click(function () {
                queryStringSql();
            });
        });

        function ReplaceControl(el, _value) {
            var _opt = "<option value='' selected='selected'></option>";
            el.parent("td").siblings(".changetxt").children().replaceWith($("#sel-hidden").find("#" + _value).clone().attr("id", "").attr("name", "V").children("option").eq(0).before(_opt).parent());
        }
        function queryStringSql(isNul) {
            var subarry = []; //提交按钮获取值
            $("#at-table tbody tr").each(function () {
                var el = $(this), _id = el.attr("id");
                var obj = {};
                el.find("select,input").each(function () {
                    var cl = $(this), _cid = cl.attr("name"), _cval = cl.val() ? cl.val() : cl.text();
                    obj[_cid] = _cval;
                });
                subarry.push(obj);
            });
            
            var _data = subarry;
            
            for(y = 0;y<_data.length;y++){    
                if(_data[y].S=="0" || _data[y].V=="")
                {
                    _data.splice(y--,1);
                }
            }
            
            if(_data[0]!=undefined)
            {
                var isBool = true;
                for(p = 0;p<_data.length;p++){    
                    if(_data[p].S!="0")
                    {
                        var arr = _data[p].S.split('|');
                        if(arr[1] == "D")
                        {
                            if(checkDate(_data[p].V)==false)
                            {
                                isBool = false;
                                break;
                            }
                        }
                        if(arr[1] == "I")
                        {
                            if(checkZNumber(_data[p].V)==false)
                            {
                                isBool = false;
                                break;
                            }
                        }
                    }
                
                }
                if(isBool){
                    console.log(_data);
                    $("#ctl00_ContentPlaceHolder1_hf").val(JSON.stringify(_data));
                }else
                {
                    $("#ctl00_ContentPlaceHolder1_hf").val("");
                }
            }else
            {
                if(isNul=="Y")
                {
                    $("#ctl00_ContentPlaceHolder1_hf").val("");
                }else
                {
                    var divDisplay = $('#divSx').css("display");
                    if(divDisplay == "block")
                    {
                        $("#ctl00_ContentPlaceHolder1_hf").val("");
                    }
                }
            }
        }
        
        
        function changSelectHandle() {
            var $td = $("#at-table tbody tr td:nth-child(1)");
            $td.empty();
            $("#lselect").empty();
            $("#hd_select option").clone(false).appendTo($("#lselect"));
            $("#lselect").parent().parent().clone(false).appendTo($td);
            
        }   
        
        function queryEmpty(){
			$("#at-table").find("tbody").find("tr").each(function(i,v){
				var _el =$(this);
				if(i<=1){
				    _el.find("input[name=M]").val("选择");
					_el.find("select[name=S]").val("0");
					_el.find("select[name=Y]").val("=");
					_el.find("input[name=V]").val("");
					_el.find("input[name=M]").val("");
				}else{
					_el.remove();
				}
			});
			document.getElementById("ctl00_ContentPlaceHolder1_hf").value = "";
		}
        
        function deletetabletr(obj) {  
            $(obj).closest('tr').remove(); 
        }  
        
        function initSXData(){
            var divDisplay = $('#divSx').css("display");
            if(divDisplay == "none")
            {
                var strJson = $("#ctl00_ContentPlaceHolder1_hf").val();
                if(strJson!="")
	            {  
			        var _data = $.parseJSON(strJson);
                    
			        var _rows = $("#at-table").find("tbody").find("tr");
			        var _count = _data.length - _rows.length;
			        if(_count > 0){
				        for(var i=0;i<_count;i++){
					        $("#at-table").find("tbody").append($(_rows[0]).clone(true));
				        }
			        }
			        $("#at-table").find("tbody").find("tr").each(function(i,v){
				        if(i<_data.length)
				        {
				            var _el = $(this);
				            _el.find("input[name=M]").val(_data[i].M);
				            if(!_data[i].M){
				               _el.find("input[name=M]").val("选择")
				            }
				            _el.find("select[name=S]").val(_data[i].S);
				            _el.find("select[name=Y]").val(_data[i].Y);
				            _el.find("input[name=V]").val(_data[i].V);
				            if(i>1){
				                _el.find("span[name=L]").html("<a herf=\"#\" onclick=\"deletetabletr(this)\"><span class=\"glyphicon glyphicon-remove\" style=\"color:#a94442;\"></span></a>");
				            }
				        }else if(_data.length <=2 && i>=2){
					        _el.remove();
				        }

			        });
			    }
			}
		}
	</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel runat="server" DefaultButton="btn_query">
    <asp:Button ID="btn_WCL" class="Content2-btn btn btn-primary btn-sm" runat="server" Visible="false"
        OnClientClick="return execAllUpdateStatus('0');" Text="未处理" OnClick="btn_WCL_Click" />
        
    <asp:Button ID="btn_YTG" class="Content2-btn btn btn-primary btn-sm" runat="server" 
        OnClientClick="return execAllUpdateStatus('1');" Text="简历通过" OnClick="btn_YTG_Click" />

    <asp:Button ID="btn_YMS" class="Content2-btn btn btn-primary btn-sm" runat="server" 
        OnClientClick="return execAllUpdateStatus('2');" Text="安排面试" OnClick="btn_YMS_Click" />

    <asp:Button ID="btn_YJJ" class="Content2-btn btn btn-primary btn-sm" runat="server" 
        OnClientClick="return execAllUpdateStatus('3');" Text="拒绝简历" OnClick="btn_YJJ_Click" />

    <asp:Button ID="btn_YWC" class="Content2-btn btn btn-primary btn-sm" runat="server" 
        OnClientClick="return execAllUpdateStatus('4');" Text="已完成" OnClick="btn_YWC_Click" />

    <button type="button" runat="server" id="btn_dxx" class="Content2-btn btn btn-primary btn-sm Content2-btn" 
        onclick="showDiv_second()"> 短信提醒</button>
    全部<asp:CheckBox ID="ck_ISALL" runat="server" />&nbsp;
    导出模板：<asp:DropDownList ID="ddlInputTYPE_ID" runat="server" Width="80px" class="form-control1"></asp:DropDownList>
    
    回复状态：<asp:DropDownList ID="ddlInputIsSend" runat="server" Width="80px" class="form-control1">
                <asp:ListItem Value="">全部</asp:ListItem>
                <asp:ListItem Value="-1">未发送</asp:ListItem>
                <asp:ListItem Value="0">待发送</asp:ListItem>
                <asp:ListItem Value="1">已发送</asp:ListItem>
                <asp:ListItem Value="100">已回复</asp:ListItem>
                <asp:ListItem Value="1000">发送失败</asp:ListItem>
              </asp:DropDownList>&nbsp;
              <asp:Button ID="btn_All_Npoi" runat="server" class="Content2-btn btn btn-primary btn-sm"  
        Text="导出" OnClick="btn_All_Npoi_Click" />
              <asp:Button ID="btn_All_fj" runat="server" class="Content2-btn btn btn-primary btn-sm" 
        Text="导出附件" OnClick="btn_All_fj_Click" />
              <button id="a_divsx" type="button" class="Content2-btn btn btn-primary btn-sm">筛选</button>
<asp:Button ID="btn_query" runat="server" class="Content2-btn btn btn-primary btn-sm"  Text="查询" OnClientClick="queryStringSql('N');" OnClick="btn_query_Click" />

</asp:Panel>  
    <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
    <div id="appPosOver">
        <table class="table table-bordered table-header">
            <tr>
                <td align="center">
                    <input id="chkSelItem" type="checkbox" onclick="selectAll('tab_List');" />
                </td>
                <td>
                    <strong>姓名</strong>
                </td>
                <td align="center">
                    <strong>出生日期</strong>
                </td>
                <td align="center">
                    <strong>性别</strong>
                </td>
                <td align="center">
                    <strong>籍贯</strong>
                </td>
                <td align="center">
                    <strong>学校</strong>
                </td>
                <td align="center">
                    <strong>学历</strong>
                </td>
                <td align="center">
                    <strong>申请职位</strong>
                </td>
                <td align="center">
                    <strong>应聘类型</strong>
                </td>
                <td align="center">
                    <strong>手机号码</strong>
                </td>
                <td align="center">
                    <strong>回复状态</strong>
                </td>
                <td style="display: none">
                    <strong>操作</strong>
                </td>
                <td align="center">
                    <strong>状态</strong>
                </td>
                
            </tr>
        </table>
        <asp:Repeater ID="rpt_List" runat="server" OnItemDataBound="rpt_List_ItemDataBound" >
            <HeaderTemplate>
                <div class="tb-wrapper">
                    <table width="100%" id="tab_List" cellspacing="1" cellpadding="4" class="tablePos table table-bordered">
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="width: 1%; text-align: center">
                        <asp:CheckBox ID="cbSelect" runat="server" />
                    </td>
                    <td style="width: 6%; text-align: center">
                        <a href="javascript:void(0)" onclick="showDiv('<%#Eval("ID")%>','<%#UrlDetail(Eval("STAFF_TYPE_ID"),Eval("ID"))%>')">
                            <%# Eval("NACHN")%></a>
                    </td>
                    <td width="7%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "GBDAT", "{0:d}")%>
                    </td>
                    <td width="1%" align="center">
                        <%# Eval("SEX")%>
                    </td>
                    <td width="12%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "ZHRJG")%>
                    </td>
                    <td width="17%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "INSTI")%>
                    </td>
                    <td width="6%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "DT_HH_EDUCATION_NAME")%>
                    </td>
                    <td width="20%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "RECRUIT_POSITION")%>
                    </td>
                    <td width="7%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "TYPE_NAME")%>
                    </td>
                    <td width="8%" align="center">
                        <%# DataBinder.Eval(Container.DataItem, "USRID_TEL")%>
                    </td>
                    <td width="7%" align="center">
                        <asp:Label ID="lbl_IS_SEND" runat="server" Text=''></asp:Label>
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
                </table></div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    <div class="col-md-3">
        <asp:Label ID="lbl_PageNo" runat="server"></asp:Label>
        <asp:DropDownList ID="ddlInputPageSize" runat="server" Width="50px" AutoPostBack="true"
            OnSelectedIndexChanged="ddlInputPageSize_SelectedIndexChanged">
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
            Text="GO" class="btn btn-primary btn-sm btn-white" Style="padding: 1px 10px;" />
    </div>
    <div id="light" class="white_content alert">
        <div class="alert-wrapper">
            <div style="width: 100%; text-align: right; position: absolute;">
                <a href="javascript:void(0)" class='close' aria-hidden='true' style="border: 1px;
                    margin: 10px 20px 10px 0;" onclick="CloseDiv()">&times;</a>&nbsp;
            </div>
            <div style="min-height: 98%; min-width: 95.5%; padding: 4px; text-align: center;
                position: absolute; left: 0.8%;">
                <iframe id="iframe1" style="height: 87%; width: 99%; margin-top: 30px;position:absolute;left:15px;"
                    src="" frameborder="0" scrolling="yes"></iframe>
            </div>
            <div id="btnDIV" style="width: 50%; height: 5%; left: 25%; border: 1px; position: absolute;
                bottom: 2%;">
                <input id="txt_hd_retid" runat="server" type="hidden" />
                <asp:Button ID="btnPass" runat="server" Text="通过" class="light_btn btn btn-primary btn-sm"
                    OnClick="btnPass_Click" OnClientClick="return confirm('确定要通过简历吗？')"  />
                <asp:Button ID="btnNotAllow" runat="server" Text="拒绝" class="light_btn btn btn-primary btn-sm"
                    OnClick="btnNotAllow_Click" OnClientClick="return confirm('确定要拒绝简历吗？')"  />
                <input id="btnClose" type="button" onclick="CloseDiv()" class="light_btn btn btn-primary btn-sm btn-white"
                    value="关闭" />
            </div>
        </div>
    </div>
    <div id="fade" class="black_overlay">
    </div>
    <div id="light-second" class="white_content alert white_content_second">
        <div class="alert-wrapper">
            <div style="width: 100%; text-align: right; position: absolute;">
                <a href="javascript:void(0)" class='close' aria-hidden='true' style="border: 1px;
                    margin: 10px 1% 10px 0;" onclick="CloseDiv_second()">&times;</a>&nbsp;
            </div>
            <div style="min-height: 98%; min-width: 95.5%; padding: 4px; text-align: center;
                position: absolute; left: 0.8%;">
                <asp:TextBox ID="txt_Content" CssClass="white_textarea" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>
            <div id="btnDIV-second" style="width: 50%; height: 5%; left: 25%; border: 1px; position: absolute;
                bottom: 8.5%;">
                <asp:Button ID="btn_duanxin" runat="server" Text="发送" class="light_btn btn btn-primary btn-sm"
                    OnClick="btn_duanxin_Click" />
                <input id="Button5" type="button" onclick="CloseDiv_second()" class="light_btn btn btn-primary btn-sm btn-white"
                    value="关闭" />
            </div>
        </div>
    </div>
    
    <div class="window_sx" id="divSx" style="display:none">
        <div class="pew_sx">
            筛选条件
        </div>
        <div class="container_sx">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
		    <tr>
	            <td height="20" >
	                        <div class="divtn_sx">
	                        <asp:Button ID="btnQuertJson" runat="server" class="Content2-btn btn btn-primary btnPadding" Text="查询" OnClientClick="queryStringSql('Y');" OnClick="btnQuertJson_Click" />
	                        <button id="add-btn" type="button" class="Content2-btn btn btn-primary btnPadding">添加</button>
				            <button id="empty_ben" onclick="queryEmpty();" class="Content2-btn btn btn-primary btnPadding" type="button">清空</button>
				            <button id="close_ben" onclick="$('#divSx').hide();" class="Content2-btn btn btn-primary btnPadding" type="button">关闭</button>
				            <span id="sel-hidden">
				            <asp:HiddenField ID="hf" runat="server" />
				            <div class="modal_sel">
				                <strong></strong>
				                <input type="text" class="sel_open"   name="M" readonly="readonly" value="选择" />
				                <div class="sel_cli">
		                            <select size="8" class="sel" name="S" id="lselect">
	　　                            </select>
　　                            </div>
				            </div>
				            <!--<select id="lselect" name="S"></select>-->
				            <div id="hd_select">
				            
				            <asp:DropDownList ID="lselect" runat="server" name="S"></asp:DropDownList>
				            </div>
                            </span></div>
	            </td>	               
	        </tr>
	        <tr>
	            <td>
	                <table id="at-table" border="0">
		            <thead>
			            <tr>
				            <th>字段选项</th>
				            <th>运算符</th>
				            <th>值</th>
				            <th>操作</th>
			            </tr>
		            </thead>
		            <tbody>
			            <tr>
				            <td>
				                <div class="modal_sel">
				                    <strong>&nu;</strong>
	                                <input type="text" class="sel_open" name="M"  readonly="readonly"  />
　　                                <div class="sel_cli">
		                                <select size="8" class="sel" name="S">
		　　                                <option value="1">初始值</option>
	　　                                </select>
　　                                </div>
                                </div>
				            </td>
				            <td><select name="Y">
					            <option value="=">=</option>
					            <option value=">">></option>
					            <option value="<"><</option>
					            <option value=">=">>=</option>
					            <option value="<="><=</option>
					            <option value="LIKE">包含</option>
				            </select></td>
				            <td class="changetxt"><input type="text" name="V" value="" placeholder="文本标题"></td>
				            <td><span name="L">&nbsp;</span></td>
			            </tr>
			            <tr>
				            <td><select name="S">
					            <option value="1">初始值1</option>
				            </select></td>
				            <td><select name="Y">
					            <option value="=">=</option>
					            <option value=">">></option>
					            <option value="<"><</option>
					            <option value=">=">>=</option>
					            <option value="<="><=</option>
					            <option value="LIKE">包含</option>
				            </select></td>
				            <td class="changetxt"><input type="text" name="V" value="" placeholder="文本标题"></td>
				            <td><span name="L">&nbsp;</span></td>
			            </tr>
		            </tbody>
	            </table>
	            
	            </td>
	        </tr>	
		</table>
        </div>
    </div>
</asp:Content>
