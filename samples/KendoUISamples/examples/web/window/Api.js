/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    var wnd = $("#window");
    $("#open").click(function (e)
    {
        wnd.data("kendoWindow").open();
    });
    $("#close").click(function (e)
    {
        wnd.data("kendoWindow").close();
    });
    $("#refresh").click(function (e)
    {
        wnd.data("kendoWindow").refresh();
    });
    wnd.kendoWindow( {width: "505px", height: "315px", title: "Rams\'s Ten Principles of Good Design", actions: ["Refresh", "Maximize", "Close"], content: "../../content/web/window/ajax/ajaxContent1.html"});
};