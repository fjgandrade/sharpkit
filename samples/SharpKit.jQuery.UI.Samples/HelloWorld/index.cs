using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.jQuery;
using SharpKit.jQuery.UI;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : jQueryContext
	{
		static index()
		{
			jQuery(delegate()
			{
				jQuery("#div1").dialog(new DialogOptions { title = "HelloWorld"});
			});
		}
	}
}
