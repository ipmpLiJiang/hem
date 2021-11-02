<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECRUIT_RESUME_PREVIEW.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.RECRUIT_RESUME_PREVIEW" ValidateRequest="false" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>浏览简历</title>
    <style type="text/css">
        td[bgcolor="#eaeaea"] {
	        padding:0;
	        height: 0;
        }
        table {
	        color:#222;
        }
        table > tbody > tr > td > table {
	        font-size:13.5px;
        }
        table strong {
	        font-size:15px;
        }
    </style>
    <script language="javascript" src="../scripts/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--简历------------------------------------------------------------------>
        <asp:Panel runat="server" ID="v_Resume">
            <table style="width:860px;border:1px solid #000" align="center" cellpadding="10" cellspacing="1">
                <tr>
                    <td bgcolor="#ffffff">
                        <asp:DataList runat="server" ID="lit_Staff" RepeatColumns="1" Width="100%"
                            CellPadding="0" CellSpacing="0">
                            <ItemTemplate>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr valign="top">
                                        <td width="170" align="left">
                                            <!--网站LOGO-->
                                            <%--<a href='<%= pub_WebUrl %>' target="_blank" title='<%= pub_WebName %>'>--%>
                                                <img src="../Images/Public/Logo_Resume.png" width="160" height="50" border="0"></a>
                                        </td>
                                    </tr>
                                </table>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td height="1">&nbsp;</td>
                                    </tr>
                                </table>
                                <!--基本信息-->
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td style="BORDER-BOTTOM: 2px solid #226995;padding-top:5px; " height="28">
                                            <font ><strong>基本信息</strong></font>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td >
                                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                <tr valign="top">
                                                    <td>
                                                        <table width="100%" border="0" cellspacing="0" cellpadding="4">
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    姓　　名：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("NACHN")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    性　　别：
                                                                </td>
                                                                <td width="21%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("GESCH").ToString() == "1" ? "男" : "女"%>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    民　　族：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lbl_RACKY" runat="server" Text='<%# Eval("RACKY")%>'></asp:Label>
                                                                </td>
                                                                <td rowspan="11">
                                                                    <asp:Label ID="lbl_FILE_PATH" runat="server" Text=''></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="6" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    出生日期：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# DataBinder.Eval(Container.DataItem, "GBDAT", "{0:d}")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    身份证号：
                                                                </td>
                                                                <td width="21%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("ICNUM")%>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    婚姻状况：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lbl_FAMST" runat="server" Text='<%# Eval("FAMST")%>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="6" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    籍　　贯：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("ZHRJG")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    政治面貌：
                                                                </td>
                                                                <td width="21%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lbl_PCODE" runat="server" Text='<%# Eval("PCODE")%>'></asp:Label>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    子女个数：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("ANZKD")%>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="6" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    身高(CM)：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("ZHRGRSG")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    体重(KG)：
                                                                </td>
                                                                <td width="21%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("ZHRGRTZ")%>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    血　　型：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lbl_ZHRYRXX" runat="server" Text='<%# Eval("ZHRYRXX")%>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="6" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    外语水平分数：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("ZHRWYFS")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    外语水平：
                                                                </td>
                                                                <td width="21%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lbl_ZHRWYSP" runat="server" Text='<%# Eval("ZHRWYSP")%>'></asp:Label>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    是否服从调剂：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lab_ZHRFZDJ" runat="server" Text='<%# Eval("ZHRFZDJ")%>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="6" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    计算机水平：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lbl_ZHRJSJSP" runat="server" Text='<%# Eval("ZHRJSJSP")%>'></asp:Label>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    健康状况：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" width="21%">
                                                                    <%# Eval("ZHRJKZK")%>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lab_CZ" runat="server" Text='视　　力'></asp:Label>：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lab_lab_CZVal" runat="server" Text=''></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    真实身高：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("REAL_ZHRGRSG")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    真实体重：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" width="21%">
                                                                    <%# Eval("REAL_ZHRGRTZ")%>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    真实视力
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;" >
                                                                    <%# Eval("REAL_ZHRSLJZ")%>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    笔试英语：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("WRITTEN_ENGLISH")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    笔试理论：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" width="21%">
                                                                    <%# Eval("WRITTEN_THEORY")%>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    操作能力
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("OPERATOR_ONE")%>
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtmlZY">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left"  class="displayHtmlZY">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    第一志愿：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("FIRSTCHOICE")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    第二志愿：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" width="21%">
                                                                    <%# Eval("SECONDCHOICE")%>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    执业类型：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lab_PRACTICE_TYPE_ID" runat="server" Text='<%# Eval("PRACTICE_TYPE_ID")%>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                             <tr class="displayHtmlHG">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left" class="displayHtmlHG">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    毕业时是否取得住院医师规范化培训合格证：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;" colspan="3">
                                                                    <%# Eval("IS_STANDARD")%>
                                                                </td>
                                                                 <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    硕士阶段是否四证合一：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;" colspan="3">
                                                                    <%# Eval("IS_SZHY")%>
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left" class="displayHtml">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    统招高考成绩：
                                                                </td>
                                                                <td width="15%" style="padding: 5px 0px 5px 1px;">
                                                                    <%# Eval("ZHRTZGG")%>
                                                                </td>
                                                                <td width="10%" style="padding: 5px 0px 5px 1px;">
                                                                    应聘类型：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" width="21%">
                                                                    <asp:Label ID="lbl_TYPE_ID" runat="server" Text='<%# Eval("TYPE_ID")%>'></asp:Label>
                                                                </td>
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lab_NURSETXT" runat="server" Text=''></asp:Label>：
                                                                </td>
                                                                <td width="11%" style="padding: 5px 0px 5px 1px;" >
                                                                    <%# Eval("ZHRGZNX")%>
                                                                </td>
                                                            </tr>
                                                            
                                                            <tr class="displayHtmlSxxx">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtmlSxxx" align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    实习医院：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" colspan="6">
                                                                    <asp:Label ID="lbl_ZHRSXXX" runat="server" Text='<%# Eval("ZHRSXXX")%>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>

                                                            <tr class="displayHtmlyjsSxxx" align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    研究生实习医院：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" colspan="6">
                                                                    <asp:Label ID="lbl_YJSSXXX" runat="server" Text='<%# Eval("YJSSXXX")%>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml" align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    <asp:Label ID="lab_IS_CERTIFICATE" runat="server" Text='是否医师资格证'></asp:Label>：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" colspan="6">
                                                                    <asp:Label ID="lab_IS_CERTIFICATE_VAL" runat="server" Text=""></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml" align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    特　　长：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" colspan="6">
                                                                    <%# Eval("ZHRTC")%>
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left" class="displayHtml">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    获奖经历：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" colspan="6">
                                                                    <%# Eval("ZHRHJJL")%>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    自我介绍：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" colspan="6">
                                                                    <%# Eval("ZHRZWJS")%>
                                                                </td>
                                                            </tr>
                                                            <tr class="displayHtml">
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                            <tr align="left" class="displayHtml">
                                                                <td width="16%" style="padding: 5px 0px 5px 1px;">
                                                                    备　　注：
                                                                </td>
                                                                <td style="padding: 5px 0px 5px 1px;" colspan="6">
                                                                    <%# Eval("ZHRBZ")%>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="7" style="height: 1px" bgcolor="#eaeaea">
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td style="BORDER-BOTTOM: 2px solid #226995;padding-top:5px;" height="28">
                                        <font ><strong>联系方式/地址</strong></font>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table width="100%" border="0" cellspacing="0" cellpadding="4">
                                                <tr align="left">
                                                    <td width="17%" style="padding: 5px 0px 5px 1px;">
                                                        手机号码：
                                                    </td>
                                                    <td width="28%" style="padding: 5px 0px 5px 1px;">
                                                        <%# Eval("USRID_TEL")%>
                                                    </td>
                                                    <td width="18%" style="padding: 5px 0px 5px 1px;">
                                                        电子信箱：
                                                    </td>
                                                    <td width="37%" style="padding: 5px 0px 5px 1px;">
                                                        <%# Eval("USRID_MAIL")%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                    </td>
                                                </tr>
                                                <tr align="left">
                                                    <td width="17%" style="padding: 5px 0px 5px 1px;">
                                                        户籍地址：
                                                    </td>
                                                    <td width="28%" style="padding: 5px 0px 5px 1px;">
                                                        <%# Eval("LOCAT_HJ")%>
                                                    </td>
                                                    <td width="18%" style="padding: 5px 0px 5px 1px;">
                                                        家庭住址：
                                                    </td>
                                                    <td width="37%" style="padding: 5px 0px 5px 1px;">
                                                        <%# Eval("LOCAT_JT")%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                    </td>
                                                </tr>
                                                <tr align="left">
                                                    <td width="17%" style="padding: 5px 0px 5px 1px;">
                                                        现居住地：
                                                    </td>
                                                    <td colspan="3" style="padding: 5px 0px 5px 1px;">
                                                        <%# Eval("LOCAT_XJ")%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                    </td>
                                                </tr>
                                            </table>
                                    </td>
                                </tr>
                                </table>
                            </ItemTemplate>
                        </asp:DataList>
                        <!--教育信息-->
                        <asp:Panel runat="server" ID="v_Eudcation" Visible="false">
                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td style="BORDER-BOTTOM: 2px solid #226995;padding-top:5px;" height="28">
                                        <font ><strong>教育信息</strong></font>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 2px">
                                        <asp:DataList runat="server" ID="lit_Eudcation" RepeatColumns="1" Width="100%" CellPadding="0"
                                            CellSpacing="0">
                                            <ItemTemplate>
                                                <table cellspacing="0" cellpadding="4" width="100%" bgcolor="#eaeaea" border="0">
                                                    <tr bgcolor="#f5f5f5" >
                                                        <td width="14%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            学校名称：
                                                        </td>
                                                        <td bgcolor="#f5f5f5" colspan="3" style="padding: 5px 0px 5px 0px;">
                                                            <b>
                                                                <%# DataBinder.Eval(Container.DataItem, "INSTI")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            开始日期：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "BEGDA", "{0:d}")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            结束日期：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "ENDDA", "{0:d}")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            学　　历：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_SLART" runat="server" Text='<%# Eval("SLART")%>'></asp:Label>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            导　　师：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRDSXM")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            学科专业1：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRXKZY1")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            学科类型：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_TYPE_ID" runat="server" Text='<%# Eval("TYPE_ID")%>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            研究方向：
                                                        </td>
                                                        <td colspan="3" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRXYJFX")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <!--工作经验-->
                        <asp:Panel runat="server" ID="v_Work" Visible="false">
                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td style="BORDER-BOTTOM: 2px solid #226995;padding-top:5px;" height="28">
                                        <font ><strong>工作经验</strong></font>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 2px">
                                        <asp:DataList runat="server" ID="lit_Work" RepeatColumns="1" Width="100%" CellPadding="0"
                                            CellSpacing="0">
                                            <ItemTemplate>
                                                <table cellspacing="0" cellpadding="4" width="100%" bgcolor="#eaeaea" border="0">
                                                    <tr bgcolor="#f5f5f5" >
                                                        <td width="14%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            工作单位：
                                                        </td>
                                                        <td bgcolor="#f5f5f5" colspan="3" style="padding: 5px 0px 5px 0px;">
                                                            <b>
                                                                <%# DataBinder.Eval(Container.DataItem, "ZHRXXDW")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            开始日期：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "BEGDA", "{0:d}")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            结束日期：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "ENDDA", "{0:d}")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            工作部门：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRZYBM")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            职　　务：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRGZZW")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            学历/学位：
                                                        </td>
                                                        <td colspan="3" style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_SLART_Work" runat="server" Text='<%# Eval("SLART")%>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <!--项目经验-->
                        <asp:Panel runat="server" ID="v_Project" Visible="false">
                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td style="BORDER-BOTTOM: 2px solid #226995;padding-top:5px;" height="28">
                                        <font ><strong>项目经验</strong></font>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 2px">
                                        <asp:DataList runat="server" ID="lit_Project" RepeatColumns="1" Width="100%" CellPadding="0"
                                            CellSpacing="0">
                                            <ItemTemplate>
                                                <table cellspacing="0" cellpadding="4" width="100%" bgcolor="#eaeaea" border="0">
                                                    <tr bgcolor="#f5f5f5" >
                                                        <td width="14%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            项目名称：
                                                        </td>
                                                        <td bgcolor="#f5f5f5" colspan="3" style="padding: 5px 0px 5px 0px;">
                                                            <b>
                                                                <%# DataBinder.Eval(Container.DataItem, "ZHRXMMC")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            开始日期：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "BEGDA", "{0:d}")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            结束日期：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "ENDDA", "{0:d}")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            项目类别_来源：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRXMLBLY")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            经费(万)：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRXMJF")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            本人排名：
                                                        </td>
                                                        <td colspan="3" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRXMPM")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        
                        <!--文章信息-->
                        <asp:Panel runat="server" ID="v_Essay" Visible="false">
                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td style="BORDER-BOTTOM: 2px solid #226995;padding-top:5px;" height="28">
                                        <font ><strong>文章信息</strong></font>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 2px">
                                        <asp:DataList runat="server" ID="lit_Essay" RepeatColumns="1" Width="100%" CellPadding="0"
                                            CellSpacing="0">
                                            <ItemTemplate>
                                                <table cellspacing="0" cellpadding="4" width="100%" bgcolor="#eaeaea" border="0">
                                                    <tr bgcolor="#f5f5f5" >
                                                        <td width="14%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            文章名称：
                                                        </td>
                                                        <td bgcolor="#f5f5f5" colspan="3" style="padding: 5px 0px 5px 0px;">
                                                            <b>
                                                                <%# DataBinder.Eval(Container.DataItem, "ZHRWZMC")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            出版时间：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "BEGDA", "{0:d}")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            出版刊物：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRCBKW")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            刊　　号：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRCBKH")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            刊物级别：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_ZHRKWJB" runat="server" Text='<%# Eval("ZHRKWJB")%>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            本人排名：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_ZHRBRMP" runat="server" Text='<%# Eval("ZHRBRMP")%>'></asp:Label>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            发布状态：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_ZHRFBZT" runat="server" Text='<%# Eval("ZHRFBZT")%>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            影响因子：
                                                        </td>
                                                        <td colspan="3" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("ZHRYXYZ")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <!--家庭成员及社会关系-->
                        <asp:Panel runat="server" ID="v_Member" Visible="false">
                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td style="border-bottom: 2px solid #226995; padding-top: 5px;" height="28">
                                        <font><strong>家庭成员及社会关系</strong></font>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 2px">
                                        <asp:DataList runat="server" ID="lit_Member" RepeatColumns="1" Width="100%" CellPadding="0"
                                            CellSpacing="0">
                                            <ItemTemplate>
                                                <table cellspacing="0" cellpadding="4" width="100%" bgcolor="#eaeaea" border="0">
                                                    <tr bgcolor="#f5f5f5">
                                                        <td width="14%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            姓名：
                                                        </td>
                                                        <td width="36%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            <b>
                                                                <%# DataBinder.Eval(Container.DataItem, "MINGC")%>
                                                        </td>
                                                        <td width="14%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            称谓：
                                                        </td>
                                                        <td bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            <b>
                                                                <%# DataBinder.Eval(Container.DataItem, "WEIC")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            出生年月：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_MGBDAT" runat="server" Text='<%# Eval("MGBDAT")%>'></asp:Label>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            政治面貌：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <asp:Label ID="lbl_MPCODE" runat="server" Text='<%# Eval("MPCODE")%>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            工作单位及职务：
                                                        </td>
                                                        <td colspan="3" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("GZDWJZW")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <!--获奖情况-->
                        <asp:Panel runat="server" ID="v_Reward" Visible="false">
                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tr>
                                    <td style="border-bottom: 2px solid #226995; padding-top: 5px;" height="28">
                                        <font><strong>获奖情况</strong></font>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 2px">
                                        <asp:DataList runat="server" ID="lit_Reward" RepeatColumns="1" Width="100%" CellPadding="0"
                                            CellSpacing="0">
                                            <ItemTemplate>
                                                <table cellspacing="0" cellpadding="4" width="100%" bgcolor="#eaeaea" border="0">
                                                    <tr bgcolor="#f5f5f5">
                                                        <td width="14%" bgcolor="#f5f5f5" style="padding: 5px 0px 5px 0px;">
                                                            奖项名称：
                                                        </td>
                                                        <td bgcolor="#f5f5f5" colspan="3" style="padding: 5px 0px 5px 0px;">
                                                            <b>
                                                                <%# DataBinder.Eval(Container.DataItem, "JXNAME")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            获奖时间：
                                                        </td>
                                                        <td width="36%" style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "HJSJ", "{0:d}")%>
                                                        </td>
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            名次：
                                                        </td>
                                                        <td style="padding: 5px 0px 5px 1px;">
                                                            <%# DataBinder.Eval(Container.DataItem, "MINGCI")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                    <tr bgcolor="#ffffff">
                                                        <td width="14%" style="padding: 5px 0px 5px 1px;">
                                                            备注：
                                                        </td>
                                                        <td colspan="3" style="padding: 5px 0px 5px 1px;">
                                                            <%# Eval("COMMENTS")%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4" style="height: 1px" bgcolor="#eaeaea">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
            <Com:ComDropDownList ID="ddlInputZHRFBZT" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputZHRYRXX" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputRACKY" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputPCODE" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputFAMST" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputZHRWYSP" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputZHRJSJSP" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputSLART" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputZHRBRMP" Visible="false" runat="server" Width="200"></Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputZHRKWJB" Visible="false" runat="server" Width="200"> </Com:ComDropDownList> 
            <Com:ComDropDownList ID="ddlInputTYPE_ID" Visible="false" runat="server" Width="200"> </Com:ComDropDownList> 
            <Com:ComDropDownList ID="ddlInputPRACTICE_TYPE_ID" Visible="false" runat="server" Width="200">
            </Com:ComDropDownList>
            <Com:ComDropDownList ID="ddlInputED_TYPE_ID" Visible="false" runat="server" Width="200">
            </Com:ComDropDownList>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
