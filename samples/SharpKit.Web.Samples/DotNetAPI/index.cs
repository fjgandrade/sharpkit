using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.Extensions;

namespace DotNetAPI
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void doTest()
		{
			//Example: using .NET API in JavaScript
			writeLine("Working with DateTime...");
			writeLine("Local time is: " + DateTime.Now.ToString());

			writeLine("Working with String...");
			writeLine(String.Format("This {0} a {1} string", "is", "formatted"));

			writeLine("Working with Path...");
			writeLine("The extensions of 'index.htm' is " + System.IO.Path.GetExtension("index.htm"));
		}

		static void writeLine(string s)
		{
			document.body.appendChild(document.createTextNode(s));
			document.body.appendChild(document.createElement("br"));
		}
	}
}
