using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.Extensions;

namespace DotNetAPI
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		static void startTest()
		{
			DotNetAPI.Test(document);
		}
	}

	[JsType(JsMode.Clr, "index.js")]
	class DotNetAPI
	{
		public static void Test(HtmlDocument document)
		{
			//Example: using .NET API in JavaScript
			document.writeln("Working with DateTime...<br/>");
			document.writeln("Local time is: " + DateTime.Now.ToString());
			document.writeln("<br/>");

			document.writeln("Working with String...<br/>");
			var str = String.Format("Here is a {0} string", "formatted");
			document.writeln(str);
			document.writeln("<br/>");

			document.writeln("Working with Path...<br/>");
			document.writeln("The extensions of 'index.htm' is " + System.IO.Path.GetExtension("index.htm"));
			document.writeln("<br/>");
		}
	}
}
