/*@Generated by SharpKit v4.23.4000*/
function btn_onclick()
{
    var prmValue=$("#textbox1").val();
    $.getJSON("MyHandler.ashx",{prm:prmValue},function(data,status,req)
    {
        alert("Server returned: " + data.NewValue);
    });
};
