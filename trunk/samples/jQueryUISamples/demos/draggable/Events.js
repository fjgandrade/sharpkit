/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    var start_counter=$("#event-start");
    var drag_counter=$("#event-drag");
    var stop_counter=$("#event-stop");
    var counts=[0,0,0];
    $("#draggable").draggable(
    {
        start:function(e,ui)
        {
            counts[0]++;
            updateCounterStatus(drag_counter,counts[0]);
        },
        drag:function(e,ui)
        {
            counts[1]++;
            updateCounterStatus(drag_counter,counts[1]);
        },
        stop:function(e,ui)
        {
            counts[2]++;
            updateCounterStatus(drag_counter,counts[2]);
        }
    });
};
function updateCounterStatus(event_counter,new_count)
{
    if(!event_counter.hasClass("ui-state-hover"))
    {
        event_counter.addClass("ui-state-hover").siblings().removeclass("ui-state-hover");
    }
};
