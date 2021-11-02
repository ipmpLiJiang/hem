$(function(){
	//导航事件
	$('.navBox li.dropdown').mouseover(function(){
		$(this).addClass('open').hasClass('active')||$(this).children('a').css('background','#00A895');
	}).mouseout(function(){
      $(this).removeClass('open').hasClass('active') || $(this).children('a').css('background','#33A695');
	}).click(function(e){
		if($(e.target).hasClass("dropdown-toggle")){
			$(this).addClass('active').siblings().removeClass('active').children('a').css('background','none');
			$("#navOne").text($(this).children('a').first().text());
			if($("a").is("#navTwo")) {
			$("#navTwo").remove();
		    }
		    if($("span").is("#navSpan")) {
			    $("#navSpan").remove();
		    }
			return true;
		}
		return false;
	});
	//导航子事件
	$('.navBox li.dropdown ul > li > a').click(function(e){
		var txt = $(this).text();
		var $el = $("#navOne").parent();
		var $ela = $(this).parent().parent().siblings("a");
		if($el.children('a').size() == 1) {
			$el.append("<span id='navSpan'> &gt; </span>").append("<a id='navTwo' href='#'>" + txt + "</a>");
		}else{
			$("#navTwo").text(txt);
		}
		$ela.parent().addClass('active').siblings().removeClass('active').children('.dropdown-toggle').css('background','none');
		$("#navOne").text($ela.text());

		if($(e.currentTarget).parent().parent().hasClass("dropdown-menu")){
			e.stopPropagation();
		}
	});
	//点击链接事件
	//点击链接事件
	
	$("#navOne").click(function(){
		if($("a").is("#navTwo")) {
			$("#navTwo").remove();
		}
		if($("span").is("#navSpan")) {
			$("#navSpan").remove();
		}
	});
	$(".dropdown-menu").click(function(e){
		e.stopPropagation();
	});
});
function bigNav(obj,url){
	$(obj).addClass('active').siblings().removeClass('active').children('a').css('background','none');
	//debugger
	$(obj).children('a').first().attr("href",url);
	$("#navOne").text($(obj).children('a').first().text());
	if($("a").is("#navTwo")) {
	    $("#navTwo").remove();
	}
	if($("span").is("#navSpan")) {
	    $("#navSpan").remove();
	}
}
function secondNav(obj){
	var txt = $(obj).text();
	var $el = $("#navOne").parent();
	var $ela = $(obj).parent().parent().siblings("a");
	if($el.children('a').size() == 1) {
		$el.append("<span id='navSpan'> &gt; </span>").append("<a id='navTwo' href='#'>" + txt + "</a>");
	}else{
		$("#navTwo").text(txt);
	}
	$ela.parent().addClass('active').siblings().removeClass('active').children('.dropdown-toggle').css('background','none');
	$("#navOne").text($ela.text());
}