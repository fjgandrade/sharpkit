using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace SharpKitSamples.BrowserCompatibility
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void btn_click(object sender, HtmlDomEventArgs e)
		{
			//innerText is not supported on FireFox
			document.getElementById("div1").innerText = "Hello world";
			
			//cross-browser solution: use appendChild() and createTextNode()
			//document.getElementById("div1").appendChild(document.createTextNode("Hello world"));
		}
	}
}
