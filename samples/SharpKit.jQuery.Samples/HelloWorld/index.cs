using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.jQuery;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : jQueryContext
	{
		public static void btn_click()
		{
			jQuery("#div1").fadeIn(1000, onAnimationEnded);
		}
		static void onAnimationEnded()
		{
			jQuery("#div1").fadeOut(1000);
		}
	}
}
