/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#numerictextbox").kendoNumericTextBox();
    var numerictextbox=$("#numerictextbox").data("kendoNumericTextBox");
    var setValue=function()
    {
        numerictextbox.value($("#value").val());
    };
    $("#enable").click(function()
    {
        numerictextbox.enable();
    });
    $("#disable").click(function()
    {
        numerictextbox.enable(false);
    });
    $("#value").kendoNumericTextBox({change:setValue});
    $("#set").click(setValue);
    $("#get").click(function()
    {
        window.alert(numerictextbox.value());
    });
};
