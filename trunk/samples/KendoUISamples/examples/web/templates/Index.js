/*Generated by SharpKit 5 v5.00.0000*/
var template = null;
$(OnReady);
function OnReady()
{
    template = kendo.template($("#template").html());
    preview();
    $("#preview").click(preview);
};
function preview()
{
    $("#blog-preview").html(template( [ {title: $("#blog-title").val()}, {twitter: $("#blog-twitter").val()}, {content: $("#blog-content").val()}]));
};