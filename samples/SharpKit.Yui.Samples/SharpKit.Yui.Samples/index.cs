using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace SharpKit.Yui.Samples
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void btn_click(HtmlElement sender, HtmlDomEventArgs e)
		{
			alert("Hello World");
		}
	}
}
