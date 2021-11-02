<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POSTER_DETAIL.aspx.cs"
    Inherits="Ipedf.Hrp.Hem.Sap.Web.POSTER_DETAIL" %>
  

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>招聘启事</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link href="<%=ResolveClientUrl("~/css/bootstrap.css") %>" rel="stylesheet">
<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
      <script src="<%=ResolveClientUrl("~/scripts/html5shiv.min.js") %>"></script>
      <script src="<%=ResolveClientUrl("~/scripts/respond.min.js") %>"></script>
    <![endif]-->
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/main.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/modaldiv2.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/modaldiv3.css") %>">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/jquery.dialog.css") %>">
    <style>
		#mainbg .row {
			margin-left:8%;margin-top:0.5%;
		}
		.wrapper {
			margin:15px auto;width: 80%;
		}
		.loginbg {
			background: #d9e8f2;
			margin: 0 10px;
			padding: 4px;
		}
		.container {
			width:100%;
		}
		#light .form-group >div 
        {
            text-align:left;	
        }
        .white_content 
        {
        	min-height:64%;
        }
    </style>
    <script src="<%=ResolveClientUrl("~/scripts/jquery.min.js") %>"></script>
    <script src="<%=ResolveClientUrl("~/scripts/bootstrap.min.js") %>"></script>
    <script src="<%=ResolveClientUrl("~/scripts/jquery.dialog.js") %>"></script>
    <script type="text/javascript">
        function showDiv() {
            //debugger
            CloseDiv1();     
            document.getElementById('light').style.display='block';
            document.getElementById('fade').style.display='block';
        }
        function showDiv1() {
            CloseDiv();
            //debugger     
            document.getElementById('light1').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
        }
        function CloseDiv() {       
            document.getElementById('light').style.display='none';
            document.getElementById('fade').style.display='none';
        }
        function CloseDiv1() {
            document.getElementById('light1').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
        }
        
        function showDivLg() {  
        //debugger     
            //$("#light").show();
            //$("#fade").show(); 
            document.getElementById('lightLg').style.display='block';
            document.getElementById('fade').style.display='block';
        }
        function CloseDivLg() {      
            //$("#light").hide();
            //$("#fade").hide(); 
            document.getElementById('light').style.display='none';
            document.getElementById('lightLg').style.display='none';
            document.getElementById('fade').style.display='none';
        }
        
        function msg_Click() {
            var num = 60;
            var strID = "#btn_Msg";//btn_Msg
            var str = $(strID).val();
            var time1 = setInterval(function(){
                num:$(strID).val(num+"s");;
                 --num;
              },1000);
            $(strID).attr("disabled",true);
            setTimeout(function(){
              $(strID).attr("disabled",false);
              clearInterval(time1);
              $(strID).val(str);
            },60000);
        }
        
        $(function(){        	
            var showdlg = '<%=Request["showdlg"]%>'
	        var _height = document.documentElement.clientHeight - 300+"px";
	        $(".tb-wrapper").height(_height);
	        
	        $("#btn_Apply").click(function () {
                var obj = '<div style="font-size:14px">是否有注册登录账户?</div>';
                $(obj).dialog({
		            title : "提示",
                    modal: true,  
                    autoOpen: false,
		            buttons: {
			            "是":function(){
			                showDivLg();
			            },
			            "否" : function(){
				            showDiv();
			            },
			            "取消" : function(){
			            }
		            },
	            });
            });
            
            if (showdlg != 'false'){
            
	        $("#btn_Apply").click();
	        }
        });

    </script>
</head>
<body>
    <div class="header">
        <div class="headerImg">
            <img src="images/header.png" alt="">
        </div>
        <div class="headerMenu">
            <ol class="breadcrumb text-right">
                <marquee width="50%" scrollamount="2" direction="left" onmouseout="this.start()"
                    onmouseover="this.stop()">
                    <span class="whiteTxt headerTxt">欢迎登录华中科技大学同济医学院附属协和医院人才招聘系统!</span></marquee>
                <li><a href="<%=ResolveClientUrl("~/UserLogin.aspx") %>">登录</a></li>
                <%--<li><a href="#" onclick="showDiv()">注册</a></li>--%>
            </ol>
        </div>
    </div>
    <div class="container">
        <div class="row loginbg" id="mainbg">
            <%--			<div class="col-md-3 loginLeft" id="leftBg">
				<img src="images/u29.jpg" alt="">
			</div>--%>
            <div class="row btnGroup" style="display: block;margin-bottom:5px;">
                <div class="col-md-2">
                    <span class="glyphicon glyphicon-home"></span><a id="navOne" href="#">招聘启事详情</a>
                </div>
                 
                <div class="col-md-offset-11">
                    <span class="glyphicon glyphicon-share-alt" id="applyPos"><a href="<%=ResolveClientUrl("~/POSTER_HOME.aspx") %>">返回</a></span>
                </div>
            </div>
            <div class="loginRight" id="rightBg">
                <div class="wrapper">
                    <form id="form1" runat="server" accept-charset="utf-8">
                    <div id="appPosOver">
                        <div class='page-header' style="display: block;margin-top:10px;margin-bottom:2px;">
                            <h4 style="text-align: center;margin-bottom:1px">
                                <asp:Label ID="lbl_TITLE" runat="server" Text=""></asp:Label>
                                <input id="btn_Apply" type="button" value="申请"  style="padding:1px 10px;margin-bottom:4px;" class="btn btn-primary btn-lg"/>
                                <br>
                                <small><asp:Label ID="lbl_DATA_SOURCE" runat="server" Text=""></asp:Label></small>
                                <small><asp:Label ID="lbl_PUBLISHER" runat="server" Text=""></asp:Label></small>
                                <small><asp:Label ID="lbl_PUBLISH_DATE" runat="server" Text=""></asp:Label></small></h4>
                        </div>
                        <div style="height:340px;overflow:auto;">
                            <asp:Label ID="lbl_CONTENT" Style="font-family: 'Arial Negreta', 'Arial'; font-weight: 400;
                                font-size: 12px;" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    
                    <div id="light" class="white_content alert" style="border: 1px solid #ccc;">
                        <asp:Panel ID="Panel1" runat="server" DefaultButton="btn_Save">
                        <div style="width: 100%; text-align: right; position: absolute;">
                            <a href="javascript:void(0)" class='close' aria-hidden='true'
                                style="border: 1px; margin: 5px 14px 10px 0;" onclick="CloseDiv()">&times;</a>&nbsp;
                        </div>
                        <div style="min-height: 98%; min-width: 93.5%;text-align: center; position: absolute; left: 0.8%;">
                            <div style=" width: 95%; margin-top: -15px; position: absolute">
                                <div class="form-group">
                                    <label for="regName" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 姓 名:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputNAME" runat="server" class="form-control" MaxLength="50"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_InputNAME" runat="server" ControlToValidate="txtInputNAME" ValidationGroup="VgZc"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入姓名！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regTell" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 手机号码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputACCOUNT" runat="server" MaxLength="11" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_InputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT" ValidationGroup="VgZc"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入手机号码！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="rev_InputACCOUNT" runat="server" ControlToValidate="txtInputACCOUNT" ValidationGroup="VgZc"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的手机号码！"
                                            SetFocusOnError="True" ValidationExpression="1\d{10}"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regTell" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 验证码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txt_YZM" runat="server" style="width:70%" class="form-control"></asp:TextBox>
                                        <asp:Button ID="btn_Msg" runat="server" CausesValidation="false" Text="发送" class="btn btn-primary btn-sm btn-white"
                                            onclick="btn_Msg_Click" />
                                        <asp:RequiredFieldValidator ID="rfv_txt_YZM" runat="server" ControlToValidate="txt_YZM" ValidationGroup="VgZc"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入验证码！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regEmail" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 电子邮箱:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputEMAIL" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_InputEMAIL" runat="server" ControlToValidate="txtInputEMAIL" ValidationGroup="VgZc"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入邮件地址！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="rev_InputEMAIL" runat="server" ControlToValidate="txtInputEMAIL" ValidationGroup="VgZc"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的邮件地址！"
                                            SetFocusOnError="True" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPass" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 设置密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD" runat="server" MaxLength="50" class="form-control" 
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_InputPASSWORD" ValidationGroup="VgZc"
                                            ControlToValidate="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入密码！"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator SetFocusOnError="True" runat="server" ID="rev_InputPASSWORD" ValidationGroup="VgZc"
                                            ControlToValidate="txtInputPASSWORD" ValidationExpression="[a-zA-z0-9]{6,20}"
                                            Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 可由6-20位英文字母、数字或下划线组成！"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPassAgain" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 重复密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD1" runat="server" MaxLength="50" class="form-control" 
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_PASSWORD1" ValidationGroup="VgZc"
                                            ControlToValidate="txtInputPASSWORD1" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入确认密码！"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ID="cov_PASSWORD1" ControlToValidate="txtInputPASSWORD1" ValidationGroup="VgZc"
                                            ControlToCompare="txtInputPASSWORD" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 密码与确认密码不一致！"></asp:CompareValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                <a onclick="showDiv1()">海外用户注册</a>
                                </div>
                            </div>
                        </div>
                        <div id="btnDIV" style="width: 100; height: 5%; left: 37%; border: 1px; position: absolute;bottom: 14%;">
                            <asp:Button ID="btn_Save" runat="server" Text="注册" ValidationGroup="VgZc" class="btn btn-primary" OnClick="btn_Save_Click" />　
                            <input id="btnClose" class="btn btn-default" type="button" onclick="CloseDiv()" value="关闭" />
                            <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                        </div>
                        </asp:Panel>
                    </div>
                    
                    <div id="light1" class="white_content alert" style="border: 1px solid #ccc;">
					    <asp:Panel ID="Panel3" runat="server" DefaultButton="btn_Save">
                        <div style="width: 100%; text-align: right; position: absolute;">
                            <a href="javascript:void(0)" class='close' aria-hidden='true' style="border: 1px; margin: 5px 14px 10px 0;" onclick="CloseDiv1()">&times;</a>&nbsp;
                        </div>
                        <div style="min-height: 98%; min-width: 93.5%;text-align: center; position: absolute; left: 0.8%;">
                            <div style=" width: 95%; margin-top: -15px; position: absolute">
                                <div class="form-group">
                                    <label for="regName" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 姓 名:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputNAME_1" runat="server" ValidationGroup="R" class="form-control" MaxLength="50"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="R" runat="server" ControlToValidate="txtInputNAME_1"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入姓名！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label for="regEmail" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 电子邮箱:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputEMAIL_1" ValidationGroup="R" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="R" runat="server" ControlToValidate="txtInputEMAIL_1"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入邮件地址！"
                                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationGroup="R" runat="server" ControlToValidate="txtInputEMAIL_1"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的邮件地址！"
                                            SetFocusOnError="True" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPass" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 设置密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD_1" ValidationGroup="R" runat="server" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" ValidationGroup="R" runat="server" ID="RequiredFieldValidator5"
                                            ControlToValidate="txtInputPASSWORD_1" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入密码！"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator SetFocusOnError="True" ValidationGroup="R" runat="server" ID="RegularExpressionValidator3"
                                            ControlToValidate="txtInputPASSWORD_1" ValidationExpression="[a-zA-z0-9]{6,20}"
                                            Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 可由6-20位英文字母、数字或下划线组成！"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPassAgain" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 重复密码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtInputPASSWORD1_1" runat="server" ValidationGroup="R" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" runat="server" ID="rfv_PASSWORD1_1"
                                            ControlToValidate="txtInputPASSWORD1_1" ValidationGroup="R" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入确认密码！"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ID="cov_PASSWORD1_1" ValidationGroup="R" ControlToValidate="txtInputPASSWORD1_1"
                                            ControlToCompare="txtInputPASSWORD_1" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 密码与确认密码不一致！"></asp:CompareValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                <a onclick="showDiv()">普通用户注册</a>
                                </div>
                            </div>
                        </div>
                        <div id="Div1" style="width: 100; height: 5%; left: 37%; border: 1px; position: absolute;
                            bottom: 14%;">
                            <asp:Button ID="btn_Save_1" ValidationGroup="R" runat="server" Text="注册" class="btn btn-primary" OnClick="btn_Save_Click1" />
                            <input id="btnClose_1" class="btn btn-default" type="button" onclick="CloseDiv1()" value="关闭" />
                            <asp:Label ID="lbl_Error_1" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                        </div>
                        </asp:Panel>
                    </div>
                    
                    <div id="lightLg" class="white_contentLg alert" style="border: 1px solid #ccc;">
                        <asp:Panel ID="Panel2" runat="server" DefaultButton="btn_Login">
                        <div style="width: 100%; text-align: right; position: absolute;">
                            <a href="javascript:void(0)" class='close' aria-hidden='true'
                                style="border: 1px; margin: 5px 14px 10px 0;" onclick="CloseDivLg()">&times;</a>&nbsp;
                        </div>
                        <div style="min-height: 98%; min-width: 93.5%;text-align: center; position: absolute; left: 0.8%;">
                            <div style=" width: 95%; margin-top: 5px; position: absolute">
                                <div class="form-group">
                                    <label for="regTell" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 手机号码或邮箱:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txt_AccountLg" runat="server" MaxLength="255" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfv_txt_AccountLg" runat="server" ControlToValidate="txt_AccountLg"
                                            Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=Images/Public/Icon1.gif align=absbottom&gt; 请输入手机号码或邮箱！"
                                            SetFocusOnError="True" ValidationGroup="VgLG"></asp:RequiredFieldValidator>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="regPass" class="col-sm-5 control-label">
                                        <font color="#ff0000">*</font> 密　　码:</label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txt_PasswordLg" runat="server" MaxLength="50" class="form-control"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator SetFocusOnError="True" ValidationGroup="VgLG" runat="server" ID="rfv_txt_PasswordLg"
                                            ControlToValidate="txt_PasswordLg" Display="Dynamic" ErrorMessage="<br><img src=Images/Public/Icon1.gif align=absbottom> 请输入密码！"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div id="Div2" style="width: 100; height: 5%; left: 37%; border: 1px; position: absolute;bottom: 22%;">
                            <asp:Button ID="btn_Login" runat="server" Text="登录" class="btn btn-primary" ValidationGroup="VgLG" OnClick="btn_Login_Click" />　
                            <input id="Button3" class="btn btn-default" type="button" onclick="CloseDivLg()" value="关闭" />
                            <asp:Label ID="lbl_ErrorLg" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                        </div>
                        </asp:Panel>
                    </div>
                    <div id="fade" class="black_overlay">
                    </div>
                    </form>
                </div>
            </div>
        </div>
        
        
    </div>
    <div class="footer">
        <ol class="breadcrumb text-center whiteTxt">
            <li>
                <h6>
                    华中科技大学同济医学院附属协和医院人才招聘系统 COPYRIGHT 2015</h6>
            </li>
        </ol>
    </div>

    <script>
        $(function(){
	        setHeightRep("appPosOver",210);
        });
        function setHeightRep(el,ht){
	        var minHeight = document.documentElement.clientHeight - ht+"px";
	        document.getElementById(el).style.minHeight = minHeight;
	        document.getElementById(el).minHeight = minHeight;
        }
    </script>

</body>
</html>
