using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryEventsSample : jQueryContext
{
    static jQueryEventsSample()
    {
        J().ready(() => 
        { 
            alert("DOM is ready");
            J("#button1").click(e => 
            { 
                J(@this).text("I have been clicked!"); 
            });
        });

       
    }
}

