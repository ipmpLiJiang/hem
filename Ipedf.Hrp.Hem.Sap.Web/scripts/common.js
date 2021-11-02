/*find client id in gridview */


var dialogWindowParam = "dialogWidth:600px;dialogHeight:500px;status:Yes;help:yes;resizable=yes";

function ___ContentLoad()
{
    if(document.getElementById('DialogContent') != null)
    {
        
        var oDialogContent = document.getElementById('DialogContent');
        var DivHeight = document.documentElement.clientHeight - 54;
	if(DivHeight<0) DivHeight=0;
        oDialogContent.style.height = DivHeight+"px";
   		oDialogContent.focus();
	}

}

window.onload = function()
{
    ___ContentLoad()
}

function ModeDialog(url, width, height)
{
    var args = new Object();
    args.document = document;
    if(width == null && height == null)
    {
        var ret = window.showModalDialog(url, args, 'dialogWidth:800px; dialogHeight:500px; scroll: no; status: no; resizable: no; help: no;');
    }
    else
    {
        var ret = window.showModalDialog(url, args, 'dialogWidth: '+ width + 'px; dialogHeight:'+ height + 'px; scroll: no; status: no; resizable: no; help: no;');
    }
    
    return ret;
}

function ModeDialog2(url, width, height)
{
    var args = new Object();
    args.document = document;
    if(width == null) width = 800;
    if(height == null) height = 500;
    var frameUrl = 'ModalDialogFrame.aspx?width=' + width;
    frameUrl = frameUrl +'&height=' + height;
    frameUrl = frameUrl +'&src=';
    //var url2 = url.split('&').join(':');
    var url2 = encodeURIComponent(url);
    return window.showModalDialog(frameUrl + url2, args, 'dialogWidth: '+ width + 'px; dialogHeight:'+ height + 'px; scroll: no; status: no; resizable: no; help: no;');
}

function ModeDialog3(url, width, height)
{
    var args = new Object();
    args.document = document;
    if(width == null) width = 800;
    if(height == null) height = 500;
    var frameUrl = 'ModalDialogFrame.aspx?width=' + width;
    frameUrl = frameUrl +'&height=' + height;
    frameUrl = frameUrl +'&src=';
    //var url2 = url.split('&').join(':');
    var url2 = encodeURIComponent(url);
    var ret;
    ret = window.showModalDialog(frameUrl + url2, args, 'dialogWidth: '+ width + 'px; dialogHeight:'+ height + 'px; scroll: no; status: no; resizable: no; help: no;');
    
    if (ret == "refresh")
    {
        //window.location.reload(true);
        return true;
    }
    return false;
}



function ShowTab(content_id,item_id)
{   
    var i = 1;
	while(true)
	{
		
		if(document.getElementById('TabContent_' + i) != null && document.getElementById('TabItem_' + i) != null)
		{
			document.getElementById('TabContent_' + i).className = 'TabContent_Hide';
			document.getElementById('TabItem_' + i).className = 'Item';	
		}
		else
		{
			break;
		}
		i++;
	}
	document.getElementById(content_id).className = 'TabContent';	
	document.getElementById(item_id).className = 'Selected';	
}

function openModalDialog(url, width, height)
{
    var args = new Object();
    args.document = document;
    var ret;
    if(width == null && height == null)
    {
        ret = window.showModalDialog(url, args, 'dialogWidth:800px; dialogHeight:500px; scroll: no; status: no; resizable: no; help: no;');
    }
    else
    {
        ret = window.showModalDialog(url, args, 'dialogWidth: '+ width + 'px; dialogHeight:'+ height + 'px; scroll: no; status: no; resizable: no; help: no;');
    }
    if (ret == "refresh")
    {
        //window.location.reload(true);
        return true;
    }
    return false;
}


function __ShowHideSearch()
{
    var divSearch = document.getElementById("SearchDiv");
    if(divSearch.style.display == "none")
    {
        divSearch.style.display = "";
        document.getElementById("UE_showSearch_Link").title = "隐藏搜索区";
        document.getElementById("UE_showSearch_Text").innerText = "隐藏搜索区";
        
    }
    else
    {
        divSearch.style.display = "none";
        document.getElementById("UE_showSearch_Link").title = "显示搜索区";
        document.getElementById("UE_showSearch_Text").innerText = "显示搜索区";
    }
    
    return false;
}

function  setTextAreaMax(obj,maxLength)
{
      
    
    obj.onkeydown=function()
    {
        validateStr(obj,maxLength);
    } 
    
    obj.onkeyup=function()
    {
      
        validateStr(obj,maxLength);
    
    }
    
    obj.onblur=function()
    {
      
        validateStr(obj,maxLength);
    
    }
 

}


function validateStr(obj,maxlength)
{  
       
     var value=obj.value;
    
     var max=maxlength;
      
      
    if(value.length>max)
    {
  
     
       obj.value=value.substr(0,max);
    }

}
function selectAll(grid)
{
	var event = window.event|| arguments.callee.caller.arguments[0];
	var target = event.srcElement || event.target;
	var control = 'cbSelect';
    //alert(grid);
	var bSel = target.checked;
	var objs = document.getElementById(grid).getElementsByTagName("input");
	var index;
	//alert();
	//debugger;
	for(index = 0; index<objs.length; index++)
	{
	    var obj=objs.item(index);
	    if(obj.type == 'checkbox'&&obj.id.indexOf(control)>-1)
		{
		if(obj.disabled==null||!obj.disabled)
		objs.item(index).checked = bSel;
		}
	}
}
function selectAllByControl(grid,control)
{
    //alert(grid);
	var bSel = event.srcElement.checked;
	var objs = document.getElementById(grid).getElementsByTagName("input");
	var index;
	//alert();
	//debugger;
	for(index = 0; index<objs.length; index++)
	{
	    var obj=objs.item(index);
	    if(obj.type == 'checkbox'&&obj.id.indexOf(control)>-1)
		{
		if(obj.disabled==null||!obj.disabled)
		objs.item(index).checked = bSel;
		}
	}
}
var prevselitem = null;
function selectx(row) {
    if (prevselitem != null) {
        prevselitem.style.backgroundColor = '#ffffff';
    }
    row.style.backgroundColor = 'PeachPuff';
    prevselitem = row;
}
function openeditx(gridId,rowId,rowIndex) {   
    var editcmdId = 'Cmd_Edit$' + rowIndex;
    try{
        __doPostBack(gridId,editcmdId);
        }catch(e){}
}
function keypressx(gridId,rowId,rowIndex) { 
    if(event.keyCode == '100')
    { 
        var nodes = event.srcElement.parentNode.getElementsByTagName('a');
	    for (var i = 0; i<nodes.length; i++ )
	    {
		    if(nodes[i].innerText == '删除')
			    if(!nodes[i].getAttribute('disabled'))
			    {
				    if(confirm('确定要【删除】吗？'))
                    {
            		   var deletecmdId = 'Cmd_Delete$' + rowIndex;
                        __doPostBack(gridId,deletecmdId);
                        break;
                        
                    }
				    
                }
	    }       
    }
    if(event.keyCode == '101')
    {
        var editcmdId = 'Cmd_Edit$' + rowIndex;
        try{
        __doPostBack(gridId,editcmdId);
        }
        catch(e){}
    }    
    if(event.keyCode == '118')
    {
        var viewcmdId = 'Cmd_View$' + rowIndex;
        try{
        __doPostBack(gridId,viewcmdId);
        }
        catch(e){}
    } 
}