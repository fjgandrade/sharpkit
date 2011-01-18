using SharpKit.JavaScript;
using SharpKit.Html4;


[JsType(JsMode.Global, Filename = "Default.js")]
class InlineJSCodeSample : HtmlContext
{
    static InlineJSCodeSample()
    {
        var SharpKitSamples = new { };

    }

    [JsMethod(Code = "alert('This is native JS code!')")]
    static void btn_onclick()
    {
    }
}



