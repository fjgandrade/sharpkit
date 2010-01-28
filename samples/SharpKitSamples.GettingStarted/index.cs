using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace SharpKitSamples.GettingStarted
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void btn_click(object sender, HtmlDomEventArgs e)
		{
			alert("Hello World!!!!!!!!!!!!");
		}
	}
}
