$(function(){
	createTable(6);
	creatPosDetail();
	//setHeight("appPosOver",320);
});

/*****
**@INT rowCount 表格行数
*****/
function createTable(rowCount) {
	var table = "<table class='tablePos table table-bordered'><caption></caption><thead><tr><th>招聘广告</th><th>招聘职位</th><th>专业要求</th><th>招聘人数</th><th>截止日期</th><th>发布日期</th></tr></thead><tbody></tbody></table>";
	$(".mainTable").addClass("table-responsive");
	$(".mainTable").append(table);

	var el = $(".mainTable .tablePos tbody");
	for(var i=0 ; i<rowCount;i++){
		el.append("<tr><td><a href='#' title=''>体检中心劳务派遣制岗位招聘</a></td><td>分诊员</td><td>护理专业</td><td>7名</td><td>2015/12/30</td><td>2015/12/20</td></tr>");
	}
	if(rowCount > 4) {
		var pag = "<ul class='pagination'><li><a href='#'>&laquo;</a></li><li class='active'><a href='#'>1</a></li><li><a href='#'>&raquo;</a></li></ul>";
		$(".mainTable").append(pag);
		var onePag = "<li class='disabled'><a href='#'>2</a></li>";
		for(i = 1;i<Math.ceil(rowCount/4);i++){
			$(".mainTable .pagination li:last").before("<li><a href='#'>"+(i+1)+"</a></li>");
		}
  
	}
	$(".mainTable a").click(function(){
		togglePosDetail();	
	});
}
//招聘明细
function creatPosDetail() {
	var table = "<div class='page-header'><h4>协和医院体检中心劳务派遣制岗位招聘<br><small>资料来源:人事处</small><small>发布者：xxx</small><small> 时间：2015/12/20</small></h4></div>";
	var btnGroup = "<div class='row btnGroup'><div class='col-md-2'><span id='applyPos' class='glyphicon glyphicon-home'><a href='#'>返回</a></span></div><div class='col-md-offset-11'><button type='button' class='btn btn-primary btn-sm'>申请</button></div></div>";
	var detailOne = '<div class="panel panel-default"><div class="panel-heading"><h3 class="panel-title">一、岗位要求</h3></div><div class="panel-body"><ol><li>身体健康、吃苦耐劳、责任心强；</li><li>学历要求：大专及以上</li><li>要求：不大于28岁；</li><li>岗位及专业要求</li><li>分诊员7名：护理专业</li></ol> </div></div>';
	var detailTwo = '<div class="panel panel-default"><div class="panel-heading"><h3 class="panel-title">二、待遇</h3></div><div class="panel-body"><ol><li>以上招聘人员为我院体检中心劳务派遣制职工，签订劳务派遣制劳动合同，为其办理养老、医疗、失业、工伤、生育等社会保险。</li></ol></div></div>';
	var detaileThree = '<div class="panel panel-default"><div class="panel-heading"><h3 class="panel-title">三、岗位要求</h3></div><div class="panel-body"><ol><li>报名截止时间：2015年12月  31  日</li><li>报名地点：xxxxxxxxxxxxxxxxxxxxxxxxxx</li><li>报名时需提交：个人简历、毕业证及相关证书的原件及复印件。</li></ol></div></div>';
	$(".mainTable").append(table).append(btnGroup).append(detailOne).append(detailTwo).append(detaileThree);
	$(".mainTable .page-header").hide();
	$(".mainTable .btnGroup").hide();
	$(".mainTable .panel").hide();

	$("#applyPos").click(function(){
		togglePosDetail();
	});
}

function togglePosDetail(){
	$(".mainTable .tablePos").toggle();
	$(".mainTable .pagination").toggle();
	$(".mainTable").toggleClass("table-responsive");

	$(".mainTable .page-header").toggle();
	$(".mainTable .btnGroup").toggle();
	$(".mainTable .panel").toggle();
}

//function setHeight(el,ht){
	//ht = ht || 190;
	//var minHeight = document.documentElement.clientHeight - ht+"px";
	//document.getElementById(el).style.minHeight = minHeight;
	//document.getElementById(el).minHeight = minHeight;

/*	document.getElementById(el).style.height = minHeight;
	document.getElementById(el).height = minHeight;*/
}