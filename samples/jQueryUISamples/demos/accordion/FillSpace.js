/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    $("#accordion").accordion( {fillSpace: true});
    $("#accordionResizer").resizable(
    {
        minHeight: 140,
        resize: function (e, ui)
        {
            $("#accordion").accordion("resize");
        }
    });
};
