using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace BrowserCompatibilityBuildWarnings
{
	//This csproj has the following conditional compilation symbol defined: BROWSER_ALL 
	//This means SharpKit will verify API calls against all known browser types
	//You can also test specifically for any of the SharpKit.BrowserModel.BrowserCompatibility.BrowserTypes values
	//For instance, define a BROWSER_IE5_5 symbol to test for IE 5.5 compatibility
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void btn_click(object sender, HtmlDomEventArgs e)
		{
			//innerText is not supported on FireFox
			//Build the project and review the warnings on Error List Window. You will find the following warning:
			//Warning: Browser Compatibility Error: 'innerText' is not Supported on: FireFox2, FireFox3, FireFox3_5, FireFox4. Use document.createTextNode() and appendChild() in any browser, or textContent in FireFox
			document.getElementById("div1").innerText = "Hello world";

			//cross-browser solution: use appendChild() and createTextNode()
			//document.getElementById("div1").appendChild(document.createTextNode("Hello world"));
		}
	}
}
