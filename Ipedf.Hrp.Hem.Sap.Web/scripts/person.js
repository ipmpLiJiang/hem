$(function(){
	$("#mainNav li").eq(6).addClass("active").children(".dropdown-toggle").dropdown('toggle').parent("li").siblings().removeClass("active");
	$($(".tableL h4")[6]).show().siblings().hide();
	var tableDiv1 = "<span class='tableSq'><a href='STAFF_EDUCATION.aspx'>教育信息</a></span>";
	var tableDiv2 = "<span class='tableSq'><a href='STAFF_WORK.aspx'>工作经历</a></span>";
	var tableDiv3 = "<span class='tableSq'><a href='STAFF_PROJECT.aspx'>项目信息</a></span>";
	var tableDiv4 = "<span class='tableSq'><a href='STAFF_ESSAY.aspx'>文章信息</a></span>";
	var tableDiv5 = "<span class='tableSq'><a href='STAFF_MEMBER.aspx'>家庭成员及社会关系</a></span>";
	var tableDiv6 = "<span class='tableSq'><a href='STAFF_REWARD.aspx'>获奖情况</a></span>";
	var tableDiv7 = "<span class='tableSq' style='display:none;'><a href='STAFF_FILEUPLOAD.aspx'>简历上传</a></span>";
	$(".tableL").append(tableDiv1).append(tableDiv2).append(tableDiv3).append(tableDiv4).append(tableDiv5).append(tableDiv6).append(tableDiv7);

	//自定义弹窗事件
	$("#btnAlert").click(function(){
		var mask = "<div class='mask'></div>";
		$("body > div").is(".mask") || $("body").append(mask);
		$(".mask").show();
		var alertDiv = "<div id='myAlert' class='alert maskContainer'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><div class='alertContainer'></div></div>";
		$(".mask div").is(".alert") || $(".mask").after(alertDiv);
		var myDetail = "<h4>1111</h4>";
		$(".alertContainer").empty().append(myDetail);

		$("#myAlert").bind('closed.bs.alert',function(){
			$(".mask").hide();
		});
	});
	
	$(".tabelList span").click(function(){
		$(this).children("a").addClass("tableActive").parent("span").siblings().children("a").removeClass("tableActive");
	});
});