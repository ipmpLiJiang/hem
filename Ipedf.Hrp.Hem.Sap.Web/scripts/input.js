//整数输入
function checkIntegerField()
{
	var key = String.fromCharCode(event.keyCode);
	if(key>"9" || key<"0")
	{
		return false;
	}
	else 
		return true;
}
//小数输入
function checkDecimalField()
{
	var key = String.fromCharCode(event.keyCode);
	if(key>"9" && key != "."|| key<"0" && key != ".")
	{
		return false;
	}
	else 
		return true;
}	
//邮件地址
function isEmail(strA)
{
	//return /^[^@^\s]+@[^@^\s]+$/gi.test(strA);
	var emailReg = /^([a-zA-Z0-9_\-\.\+]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/
	return emailReg.test(strA);
}
//日期输入
function checkDateField(dateValue)
{
	var re = /\d{4}-\d{2}-\d{2}/;
	var result = re.test(dateValue);
	return result;
}
//去除空格函数
function Trim(strInput)
{
	var strOutput,re
	strOutput = new String(strInput);		
	return strOutput.trim(); 
}
//lTrim函数
String.prototype.lTrim = function () 
{
	return this.replace(/^\s*/, "");
}
//rTrim函数
String.prototype.rTrim = function () 
{
	return this.replace(/\s*$/, "");
}
//trim函数
String.prototype.trim = function ()
{
	return this.rTrim().lTrim();
}
//
function $()
{ 
    var elements = new Array();   
    for (var i = 0; i < arguments.length; i++) 
    { 
		var element = arguments[i]; 
		if (typeof element == 'string') 
			element = document.getElementById(element);   
		if (arguments.length == 1)return element;   
		elements.push(element); 
    }   
    return elements; 
} 
//验证定义表单是否为空;
function checkform(frmObject)
{
      try
      {
            var input_array = document.getElementsByTagName("input"); 
            var select_array = document.getElementsByTagName("select");      
            var check_array = new Array();
            for(var i =0; i <input_array.length; i ++)
            {
                if(input_array[i].getAttribute('type') == 'text')
                {
                    check_array.push(input_array[i]);
                }
            }
            for(var i=0;i<check_array.length;i++)
            { 
                if(trim(check_array[i].value) == "")
                {
                    check_array[i].setAttribute("bgColor","#FF873E");
                    check_array[i].focus();
                    return false;
                }
            }
            for(var i=0;i<select_array.length;i++)
            {
                if(select_array[i].value == -1)
                {
                    alert(select_array[i]);
                    select_array[i].focus();
                    return false;
                }	
            }
            return true;
      }
      catch(e)
      {
        alert(e);
      }
}
//自动设置光标到输入控件最后一个字符后面
function setIndexLastWord(inputId) 
{   
        var tar = document.getElementById(inputId);   
        if(tar.setSelectionRange) {   
            tar.setSelectionRange(tar.value.length , tar.value.length);   
        } else {   
            var range = tar.createTextRange();   
            range.moveStart("character",tar.value.length);   
            range.moveEnd("character",tar.value.length);   
            range.select();   
        }   
        tar.focus();  
}
//自动设置光标到输入控件最后一个字符后面
function setIndexLastWord() 
{   
        var tar = event.srcElement;
        if(tar.setSelectionRange) {   
            tar.setSelectionRange(tar.value.length , tar.value.length);   
        } else {   
            var range = tar.createTextRange();   
            range.moveStart("character",tar.value.length);   
            range.moveEnd("character",tar.value.length);   
            range.select();   
        }   
        tar.focus();  
}
function round(num,length)
{  
    num = Math.round(num*Math.pow(10,length))/Math.pow(10,length);  
    return num;  
} 
var SelItemAry = null;
function SearchValue(vObj,sObj,postback)
{
    var curVal = vObj.value;
    if(curVal==vObj.oldValue)return;
    else vObj.oldValue = curVal;
	
    var selectObj = sObj;
    var bFind = false;
    if(SelItemAry==null)
    {
        SelItemAry = new Array();
        for(index = 0;index<selectObj.options.length;index++)
        {
            SelItemAry[index] = selectObj.options[index];
        }
    }
    if(curVal=="")
    {
        selectObj.options.length = 0;
        for(i = 0; i < SelItemAry.length; i ++)
        {
            var sText = SelItemAry[i].text;
            var sValue = SelItemAry[i].value;
            var oOption = document.createElement("OPTION");
            oOption.text= sText;
            oOption.value= sValue;
            selectObj.options.add(oOption);
        }
    }
    else
    {
        for(i=0; i<SelItemAry.length;i++)
        {
            var sText = SelItemAry[i].text;
            var sValue = SelItemAry[i].value;
            if(sText.indexOf(curVal)>=0)
            {
	            if(!bFind)
	            {
		            selectObj.options.length = 0;
	            }
	            var oOption = document.createElement("OPTION");
	            oOption.text= sText;
	            oOption.value= sValue;
	            selectObj.options.add(oOption);
	            bFind = true;
            }
        }
    }
    if(postback && bFind)
        setTimeout('__doPostBack(\''+ sObj.id +'\',\'\')', 0);
}
