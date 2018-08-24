var firstname = "Yos",
	lastname = "Nigga",
	now = new Date(),

	result = "it is now " + now;
document.getElementById("time").innerText = result;

function timerFunc() {
	var now = new Date();
	var hour = now.getHours();
	var min = now.getMinutes();
	var sec = now.getSeconds();
	document.getElementById("clock").value = "" + hour + ":" + min + ":" + sec;
}
setInterval(timerFunc, 1000);


function animate_string(id) 
{
    var element = document.getElementById(id);
    var textNode = element.childNodes[0]; // assuming no other children
    var text = textNode.data;

setInterval(function () 
{
 text = text[text.length - 1] + text.substring(0, text.length - 1);
  textNode.data = text;
}, 100);
}