using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.jQuery.UI;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryUIDialogSample : jQueryContext
{

    static jQueryUIDialogSample()
    {
        J().ready(() => { J("#dialog").dialog(); });
    }

}

