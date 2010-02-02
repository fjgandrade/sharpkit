using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace JavaScriptAPI
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		static index()
		{
			//Example: using native JavaScript API in C#
			document.writeln("using JsDate...<br/>");
			var date = new JsDate();
			document.writeln("Local time is: " + date.toString());
			document.writeln("<br/>");

			document.writeln("using JsString...<br/>");
			var str = "Invoking JsString.italics()".As<JsString>().italics();
			document.writeln(str);
			document.writeln("<br/>");

			document.writeln("using JsMath...<br/>");
			document.writeln("Invoking JsMath.random() -> " + JsMath.random().toString());
			document.writeln("<br/>");
		}
	}
}
