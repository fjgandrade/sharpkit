/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    $("#draggable, #draggable-nonvalid").draggable();
    $("#droppable").droppable(
    {
        accept: "#draggable",
        activeClass: "ui-state-hover",
        hoverClass: "ui-state-active",
        drop: function (e, ui)
        {
            $(e.currentTarget).addClass("ui-state-highlight").find("p").html("dropped!");
        }
    });
};
