<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MsgTest.aspx.cs" Inherits="Ipedf.Hrp.Hem.Sap.Web.MsgTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    select '序号' HeaderName,0 RowStart,2 RowEnd,0 CellStart,0 CellEnd ,5 Num from DUAL UNION ALL
select '姓名' HeaderName,0 RowStart,2 RowEnd,1 CellStart,1 CellEnd ,5 Num from DUAL UNION ALL
select '性别' HeaderName,0 RowStart,2 RowEnd,2 CellStart,2 CellEnd ,5 Num from DUAL UNION ALL
select '出生年月' HeaderName,0 RowStart,2 RowEnd,3 CellStart,3 CellEnd ,5 Num from DUAL UNION ALL
select '身份证号' HeaderName,0 RowStart,2 RowEnd,4 CellStart,4 CellEnd ,5 Num from DUAL UNION ALL
select '婚姻状况' HeaderName,0 RowStart,2 RowEnd,5 CellStart,5 CellEnd ,5 Num from DUAL UNION ALL
select '籍贯' HeaderName,0 RowStart,2 RowEnd,6 CellStart,6 CellEnd ,5 Num from DUAL UNION ALL
select '民族' HeaderName,0 RowStart,2 RowEnd,7 CellStart,7 CellEnd ,5 Num from DUAL UNION ALL
select '政治面貌' HeaderName,0 RowStart,2 RowEnd,8 CellStart,8 CellEnd ,5 Num from DUAL UNION ALL
select '学历' HeaderName,0 RowStart,2 RowEnd,9 CellStart,9 CellEnd ,5 Num from DUAL UNION ALL
select '学科类型' HeaderName,0 RowStart,2 RowEnd,10 CellStart,10 CellEnd ,5 Num from DUAL UNION ALL

select '学科' HeaderName,0 RowStart,2 RowEnd,11 CellStart,11 CellEnd ,5 Num from DUAL UNION ALL
select '导师' HeaderName,0 RowStart,2 RowEnd,12 CellStart,12 CellEnd ,5 Num from DUAL UNION ALL
select '外语' HeaderName,0 RowStart,2 RowEnd,13 CellStart,13 CellEnd ,5 Num from DUAL UNION ALL
select '博士毕业学校' HeaderName,0 RowStart,2 RowEnd,14 CellStart,14 CellEnd ,5 Num from DUAL UNION ALL
select '博士毕业时间' HeaderName,0 RowStart,2 RowEnd,15 CellStart,15 CellEnd ,5 Num from DUAL UNION ALL
select '硕士毕业学校(含所学专业、起止日期)' HeaderName,0 RowStart,2 RowEnd,16 CellStart,16 CellEnd ,5 Num from DUAL UNION ALL
select '本科毕业学校(含所学专业、起止日期)' HeaderName,0 RowStart,2 RowEnd,17 CellStart,17 CellEnd ,5 Num from DUAL UNION ALL
select '本部计划' HeaderName,0 RowStart,2 RowEnd,18 CellStart,18 CellEnd ,5 Num from DUAL UNION ALL
select '西院计划' HeaderName,0 RowStart,2 RowEnd,19 CellStart,19 CellEnd ,5 Num from DUAL UNION ALL
select '第一志愿' HeaderName,0 RowStart,2 RowEnd,20 CellStart,20 CellEnd ,5 Num from DUAL UNION ALL
select '第二志愿' HeaderName,0 RowStart,2 RowEnd,21 CellStart,21 CellEnd ,5 Num from DUAL UNION ALL
select '执业类型' HeaderName,0 RowStart,2 RowEnd,22 CellStart,22 CellEnd ,5 Num from DUAL UNION ALL
select '毕业时是否取得住院医师规范化培训合格证' HeaderName,0 RowStart,2 RowEnd,23 CellStart,23 CellEnd ,5 Num from DUAL UNION ALL
select '论文情况' HeaderName,0 RowStart,0 RowEnd,24 CellStart,29 CellEnd ,5 Num from DUAL UNION ALL
select '待发表论文数' HeaderName,0 RowStart,0 RowEnd,30 CellStart,31 CellEnd ,5 Num from DUAL UNION ALL
select '科研情况' HeaderName,0 RowStart,2 RowEnd,32 CellStart,32 CellEnd ,5 Num from DUAL UNION ALL
select '其他相关成果' HeaderName,0 RowStart,2 RowEnd,33 CellStart,33 CellEnd ,5 Num from DUAL UNION ALL
select '备注' HeaderName,0 RowStart,2 RowEnd,34 CellStart,34 CellEnd ,5 Num from DUAL UNION ALL
select '选留意见' HeaderName,0 RowStart,2 RowEnd,35 CellStart,35 CellEnd ,5 Num from DUAL UNION ALL
select '最终结果' HeaderName,0 RowStart,2 RowEnd,36 CellStart,36 CellEnd ,5 Num from DUAL UNION ALL
select '是否签约' HeaderName,0 RowStart,2 RowEnd,37 CellStart,37 CellEnd ,5 Num from DUAL UNION ALL
select '电话' HeaderName,0 RowStart,2 RowEnd,38 CellStart,38 CellEnd ,5 Num from DUAL UNION ALL
select '本人签字确认' HeaderName,0 RowStart,2 RowEnd,39 CellStart,39 CellEnd ,5 Num from DUAL UNION ALL
select '备注1' HeaderName,0 RowStart,2 RowEnd,40 CellStart,40 CellEnd ,5 Num from DUAL UNION ALL
select '真实身高' HeaderName,0 RowStart,2 RowEnd,41 CellStart,41 CellEnd ,5 Num from DUAL UNION ALL
select '真实体重' HeaderName,0 RowStart,2 RowEnd,42 CellStart,42 CellEnd ,5 Num from DUAL UNION ALL
select '真实视力' HeaderName,0 RowStart,2 RowEnd,43 CellStart,43 CellEnd ,5 Num from DUAL UNION ALL
select '笔试理论成绩' HeaderName,0 RowStart,2 RowEnd,44 CellStart,44 CellEnd ,5 Num from DUAL UNION ALL
select '笔试英语成绩' HeaderName,0 RowStart,2 RowEnd,45 CellStart,45 CellEnd ,5 Num from DUAL UNION ALL
select '笔试总分' HeaderName,0 RowStart,2 RowEnd,46 CellStart,46 CellEnd ,5 Num from DUAL UNION ALL
select '操作成绩' HeaderName,0 RowStart,2 RowEnd,47 CellStart,47 CellEnd ,5 Num from DUAL UNION ALL
select '邮箱' HeaderName,0 RowStart,2 RowEnd,48 CellStart,48 CellEnd ,5 Num from DUAL UNION ALL
select '用户类型' HeaderName,0 RowStart,2 RowEnd,49 CellStart,49 CellEnd ,5 Num from DUAL UNION ALL
select 'SCI' HeaderName,1 RowStart,1 RowEnd,24 CellStart,26 CellEnd ,5 Num from DUAL UNION ALL
select '权威' HeaderName,1 RowStart,2 RowEnd,27 CellStart,27 CellEnd ,5 Num from DUAL UNION ALL
select '核心' HeaderName,1 RowStart,2 RowEnd,28 CellStart,28 CellEnd ,5 Num from DUAL UNION ALL
select '一般' HeaderName,1 RowStart,2 RowEnd,29 CellStart,29 CellEnd ,5 Num from DUAL UNION ALL
select 'SCI' HeaderName,1 RowStart,2 RowEnd,30 CellStart,30 CellEnd ,5 Num from DUAL UNION ALL
select '其他' HeaderName,1 RowStart,2 RowEnd,31 CellStart,31 CellEnd ,5 Num from DUAL UNION ALL
select 'A类' HeaderName,2 RowStart,2 RowEnd,24 CellStart,24 CellEnd ,5 Num from DUAL UNION ALL
select 'B类' HeaderName,2 RowStart,2 RowEnd,25 CellStart,25 CellEnd ,5 Num from DUAL UNION ALL
select 'C类' HeaderName,2 RowStart,2 RowEnd,26 CellStart,26 CellEnd ,5 Num from DUAL UNION ALL
    </div>
    </form>
</body>
</html>
