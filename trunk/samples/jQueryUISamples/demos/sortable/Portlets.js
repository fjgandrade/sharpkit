/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $(".column").sortable({connectWith:".column"});
    $(".portlet").addClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all").find(".portlet-header").addClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all").prepend("<span class=\'ui-icon ui-icon-minusthick\'></span>").end().find(".portlet-content");
    $(".portlet-header .ui-icon").click(function(e)
    {
        $(e.currentTarget).toggleClass("ui-icon-minusthick").toggleClass("ui-icon-plusthick");
        $(e.currentTarget).parents(".portlet:first").find(".portlet-content").toggle();
    });
    $(".column").disableSelection();
};
