$(function(){
	//setHeight("mainbg");
	setHeight("leftBg");
	//setHeight("rightBg");
	$("#mainNav li").click(function(e,index){
		index = index || -1;
		$(this).addClass("active").siblings().removeClass("active");
		var _index=(index == -1)?$("#mainNav li").index($(this)):index;
		$($(".tableL > h4")[_index]).show().siblings().hide();
		if($(e.currentTarget).parent().hasClass("dropdown-menu")){
			e.stopPropagation();
		}
	});
});
function setHeight(el){
	var minHeight = document.documentElement.clientHeight - 170+"px";
	document.getElementById(el).style.minHeight = minHeight;
	document.getElementById(el).minHeight = minHeight;

	document.getElementById(el).style.Height = minHeight;
	document.getElementById(el).Height = minHeight;
}