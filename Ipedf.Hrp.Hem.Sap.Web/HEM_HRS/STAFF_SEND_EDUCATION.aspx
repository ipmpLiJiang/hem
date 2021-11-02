<%@ Page Language="C#" MasterPageFile="~/Controls/User.Master" AutoEventWireup="true"
    CodeBehind="STAFF_SEND_EDUCATION.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.STAFF_SEND_EDUCATION"
    Title="教育信息" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=ResolveClientUrl("~/css/person.css") %>">

    <script src="<%=ResolveClientUrl("~/scripts/My97DatePicker/WdatePicker.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/personsend.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>

    <script type="text/javascript" language="javascript">
    $(function(){
        $("#mainNav li:eq(1)").addClass("active").siblings().removeClass("active");
        $(".tabelList span:eq(0)").children("a").addClass("tableActive").parent("span").siblings().children("a").removeClass("tableActive");
    });
    function onChangClick(objId,ActID)
    {
        var value = $("#"+objId).val();
        if(value!="10" && value!="11")
        {
            $("#"+ActID).get(0).selectedIndex=0;
            $("#"+ActID).attr("disabled","disabled");
            
        }else{
            $("#"+ActID).get(0).selectedIndex=0;
            $("#"+ActID).removeAttr("disabled");
        }
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-10 col-sm-9 loginRight" id="rightBg">
        <div class="row titleTable">
            <div class="tableL tabelList">
                <h4>
                    <a class="atip" href="<%=ResolveClientUrl("~/HEM_HRS/STAFF_SEND_BASIC.aspx") %>">派遣基本信息</a></h4>
            </div>
            <div class="tableR">
            </div>
        </div>
        <div class="mainTable">
            <table border="0" style="width: 100%">
                <tr>
                    <td>
                        <div class="col-md-3">
                            <asp:Label ID="lbl_PageNo" runat="server"></asp:Label>
                        </div>
                        <div class="col-md-offset-9">
                            <asp:LinkButton ID="lbt_home" runat="server" CausesValidation="False" OnClick="lbt_home_Click">首页</asp:LinkButton>
                            <asp:LinkButton ID="lbt_back" runat="server" CausesValidation="False" OnClick="lbt_back_Click">前页</asp:LinkButton>
                            <asp:LinkButton ID="lbt_next" runat="server" CausesValidation="False" OnClick="lbt_next_Click">后页</asp:LinkButton>
                            <asp:LinkButton ID="lbt_last" runat="server" CausesValidation="False" OnClick="lbt_last_Click">尾页</asp:LinkButton>
                            |
                            <asp:TextBox ID="txt_PageNo" runat="server" Width="30">1</asp:TextBox>
                            <asp:Button ID="btn_GoPage" runat="server" class="btn btn-primary btn-sm btn-white"
                                Style="padding: 1px 10px;" CausesValidation="False" OnClick="btn_GoPage_Click"
                                Text="GO" />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Repeater ID="rpt_List" runat="server" OnItemCommand="rpt_List_ItemCommand" OnItemDataBound="rpt_List_ItemDataBound">
                            <HeaderTemplate>
                                <table width="100%" cellspacing="1" cellpadding="4" id="tab_List" class="tablePos table table-bordered">
                                    <tr>
                                        <td width="29%">
                                            <strong>学校名称</strong>
                                        </td>
                                        <td width="10%" align="center">
                                            <strong>开始日期</strong>
                                        </td>
                                        <td width="10%" align="center">
                                            <strong>结束日期</strong>
                                        </td>
                                        <td width="10%" align="center">
                                            <strong>学历</strong>
                                        </td>
                                        <td width="16%" align="center">
                                            <strong>学科专业1</strong>
                                        </td>
                                        <%--<td width="12%" align="center">
                                            <strong>研究方向</strong>
                                        </td>--%>
                                        <td width="4%" align="center">
                                            <strong>导师</strong>
                                        </td>
                                        <td width="10%" align="center">
                                            <strong>学科类型</strong>
                                        </td>
                                        <td width="11" align="center">
                                            <strong>操作</strong>
                                        </td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td style="width: 29%; text-align: center; word-break: break-all;">
                                        <%# DataBinder.Eval(Container.DataItem, "INSTI")%>
                                    </td>
                                    <td width="10%" align="center">
                                        <%# DataBinder.Eval(Container.DataItem, "BEGDA", "{0:d}")%>
                                    </td>
                                    <td width="10%" align="center">
                                        <%# DataBinder.Eval(Container.DataItem, "ENDDA", "{0:d}")%>
                                    </td>
                                    <td width="10%" align="center">
                                        <asp:Label ID="lbl_SLART" runat="server" Text=''></asp:Label>
                                    </td>
                                    <td width="16%" align="center">
                                        <asp:Label ID="lbl_ZHRXKZY1" runat="server" Text=''></asp:Label>
                                    </td>
                                    <%--<td width="10%" align="center">
                                        <asp:Label ID="lbl_ZHRXYJFX" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ZHRXYJFX")%>'></asp:Label>
                                    </td>--%>
                                    <td width="4%" align="center">
                                        <%# DataBinder.Eval(Container.DataItem, "ZHRDSXM")%>
                                    </td>
                                    <td width="10%" align="center">
                                        <asp:Label ID="lbl_TYPE_ID" runat="server" Text=''></asp:Label>
                                    </td>
                                    <td width="11%" align="center">
                                        <asp:LinkButton runat="server" ID="lbn_Edit" CausesValidation="False" CommandArgument='<%# Eval("ID") %>'
                                            CommandName="Edit">修改</asp:LinkButton>|
                                        <asp:LinkButton runat="server" ID="lbn_Delete" CausesValidation="False" CommandArgument='<%# Eval("ID") %>'
                                            CommandName="Delete" OnClientClick="return confirm('确定删除吗？')">删除</asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </td>
                </tr>
            </table>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>学校名称：</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtInputINSTI" runat="server" class="form-control" MaxLength="100"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputINSTI" runat="server" ControlToValidate="txtInputINSTI"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入学校名称！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
                <div class="col-sm-2">
                    <asp:CheckBox ID="ckInputIS_HIGHEST" runat="server" />&nbsp;最高学历
                </div>
            </div>
            <div class="form-group row">
                <label for="regSkill" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>开始日期：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputBEGDA" runat="server" MaxLength="10" class="Wdate form-control"
                        onClick="WdatePicker()" Width="200"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputBEGDA" runat="server" ControlToValidate="txtInputBEGDA"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择开始日期！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_txtInputBEGDA" runat="server" ControlToValidate="txtInputBEGDA"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的开始日期！"
                        ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>结束日期：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputENDDA" runat="server" MaxLength="10" class="Wdate form-control"
                        onClick="WdatePicker()" Width="200"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputENDDA" runat="server" ControlToValidate="txtInputENDDA"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择结束日期！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_txtInputENDDA" runat="server" ControlToValidate="txtInputENDDA"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入正确的结束日期！"
                        ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="name" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>学 历：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputSLART" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfv_ddlInputSLART" runat="server" ControlToValidate="ddlInputSLART"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请选择学历！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
                <label for="regHobby" class="col-sm-2 control-label">
                    导 师：</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInputZHRDSXM" runat="server" class="form-control" MaxLength="40"></asp:TextBox>
                    <asp:Label ID="lbl_ZHRDSXM" runat="server" Visible="false" Style="color: red;" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入导师！
                    </asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <label for="name" class="col-sm-2 control-label">
                    学科类型：</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlInputTYPE_ID" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:Label ID="lbl_TYPE_ID" runat="server" Visible="false" Style="color: red;" Text="">
                        <br />
                        <img align="absbottom" src="../Images/Public/Icon1.gif"/> 请输入学科类型！
                    </asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <label for="name" class="col-sm-2 control-label">
                    &nbsp;</label>
                <label for="name" class="col-sm-10 control-label" style="text-align: left">
                    <font color="#ff0000">（备注：请从高中起填写各学历阶段教育经历，保存之后可继续填写下一条教育信息）</font></label>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    <font color="#ff0000">*</font>学科专业1：</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtInputZHRXKZY1" runat="server" class="form-control" MaxLength="100"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfv_txtInputZHRXKZY1" runat="server" ControlToValidate="txtInputZHRXKZY1"
                        Display="Dynamic" ErrorMessage="&lt;br&gt;&lt;img src=../Images/Public/Icon1.gif align=absbottom&gt; 请输入学科专业1！"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    学科专业2：</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtInputZHRXKZY2" runat="server" class="form-control" MaxLength="100"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="regName" class="col-sm-2 control-label">
                    研究方向：</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtInputZHRXYJFX" runat="server" class="form-control" MaxLength="100"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <div class="7" style="text-align: center">
                    <asp:Button ID="btn_Save" runat="server" class="btn btn-primary btn-sm btn-white"
                        Text="保存" OnClick="btn_Save_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_SaveNext" runat="server" Text="下一步" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_SaveNext_Click" CausesValidation="false" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btn_SubmitCheck" runat="server" Text="提交简历" class="btn btn-primary btn-sm btn-white"
                        OnClick="btn_SubmitCheck_Click" CausesValidation="false" />
                    <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
