/*Generated by SharpKit 5 v4.28.4000*/
Y = YUI();
Y.use(["editor","node","event"],OnLoad);
function OnLoad()
{
    var x=new Y.EditorBase({content:"asdfadsf"});
    x.render("#editor");
    Y.one("#close-button").on("click",function()
    {
        alert("Hello");
    });
};
