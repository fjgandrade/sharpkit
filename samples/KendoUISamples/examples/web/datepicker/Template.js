/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    var today = new Date();
    var birthdays =  [new Date(today.getFullYear(), today.getMonth(), 11).valueOf(), new Date(today.getFullYear(), today.getMonth() + 1, 6).valueOf(), new Date(today.getFullYear(), today.getMonth() + 1, 27).valueOf(), new Date(today.getFullYear(), today.getMonth() - 1, 3).valueOf(), new Date(today.getFullYear(), today.getMonth() - 2, 22).valueOf()];
    $("#datepicker").kendoDatePicker(
    {
        value: today,
        month: {content: "# if ($.inArray(+data.date, [" + birthdays + "]) != -1) { #" + "<div class=\'birthday\'></div>" + "# } #" + "#= data.value #"},
        footer: "Today - #=kendo.toString(data, \'d\') #"
    });
    $("#datepicker").data("kendoDatePicker");
};
