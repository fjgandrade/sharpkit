using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.jQTouch;
using SharpKit.jQuery;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	public class index : jQueryContext
	{
		static index()
		{
			var jQT = new jQTouch(new jQTouchSettings
			{
				icon = "icon.png",
				addGlossToIcon = false,
				startupScreen = "startup_screen.png",
				statusBar = "black",
			});
		}
	}
}

