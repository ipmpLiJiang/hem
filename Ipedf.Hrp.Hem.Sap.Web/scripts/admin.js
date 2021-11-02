$(function(){
	setHeight("mainbg");
	// setHeight("leftBg");
	// setHeight("rightBg");

	$("#mainNav li").click(function(e,index){
		var index =index || -1 ;
		$(this).addClass("active").siblings().removeClass("active");
		var _index=(index == -1)?$("#mainNav li").index($(this)):index;
		$($(".tableL h4")[_index]).show().siblings().hide();
		if($(e.currentTarget).parent().hasClass("dropdown-menu")){
			e.stopPropagation();
		}

		switch(_index){
			case 0:
				self.location='home.html';
				break;
			case 2:
				self.location='resume.html';
				break;
			case 6:
				self.location='person.html';
				break;
			default:
				break;
		}
	});
});
function setHeight(el,ht){
	var ht = ht || 170;
	var minHeight = document.documentElement.clientHeight - ht+"px";
	document.getElementById(el).style.minHeight = minHeight;
	document.getElementById(el).minHeight = minHeight;
	/*document.getElementById(el).style.height = minHeight;
	document.getElementById(el).height = minHeight;*/
}