using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQuerySelectorsSample : jQueryContext
{

    static jQuerySelectorsSample()
    {
        J().ready(() =>
        {
            J(".MyExpander > #Header").mousedown(e =>
            {
                J(@this).siblings(".MyExpander > #Content").toggle();
            });
        });
    }

}

