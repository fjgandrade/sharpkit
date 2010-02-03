using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using Yui;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : YuiContext
	{
		static index()
		{
			YUI(new { combine = true, timeout = 10000 }).use("node", Yui =>
			{
				Action helloWorld = delegate
				{
					alert("Hello World!");
				};
				Yui.on("click", helloWorld, "#btn");
			});

		}
	}
}
