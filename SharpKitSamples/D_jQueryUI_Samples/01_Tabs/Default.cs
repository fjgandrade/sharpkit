using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.jQuery.UI;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryUITabsSample : jQueryContext
{

    static jQueryUITabsSample()
    {
        J().ready(() => { J("#tabs").tabs(); });
    }

}

