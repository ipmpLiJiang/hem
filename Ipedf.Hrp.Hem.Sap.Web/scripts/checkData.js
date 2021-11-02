function checkDate(txt) {
    var re = /^(\d{4}(\/|\-)\d{1,2}(\/|\-)\d{1,2})*$/
    if (!re.test(txt)) { 
    alert("日期格式不正确!") 
        return false 
    } 
    else {
        return true 
    }
} 

function checkZNumber(txt) {
    var re = /^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*)|(0))$/
    if (!re.test(txt)) { 
    alert("数字格式不正确!") 
        return false 
    } 
    else {
        return true 
    }
} 