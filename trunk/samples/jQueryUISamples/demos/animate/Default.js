/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#button").toggle(function(e)
    {
        $("#effect").animate({backgroundColor:"#aa0000",color:"#fff",width:"500"},1000);
    },function(e)
    {
        $("#effect").animate({backgroundColor:"#fff",color:"#000",width:"240"},1000);
    });
};
