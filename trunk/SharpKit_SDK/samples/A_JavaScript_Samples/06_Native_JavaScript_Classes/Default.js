/*@Generated by SharpKit v4.23.5000*/
var SharpKitSamples={};
function btn_onclick()
{
    var num1=parseInt(document.getElementById("textbox1").value);
    var num2=parseInt(document.getElementById("textbox2").value);
    if(isNaN(num1) || isNaN(num2))
    {
        alert("Please enter two valid numbers");
        return;
    }
    var biggerNum=Math.max(num1,num2);
    alert("The bigger number is " + biggerNum);
}
