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
		static void WriteLine(string s)
		{
			doc.body.appendChild(doc.createTextNode(s));
			doc.body.appendChild(doc.createElement("br"));
		}

		static HtmlDocument doc;
		public static void Test(HtmlDocument document)
		{
			doc = document;
			//Example: using .NET API in JavaScript
			WriteLine("Working with DateTime...<br/>");
			WriteLine("Local time is: " + DateTime.Now.ToString());
			WriteLine("<br/>");

			WriteLine("Working with String...<br/>");
			var str = String.Format("Here is a {0} string", "formatted");
			WriteLine(str);
			WriteLine("<br/>");

			WriteLine("Working with Path...<br/>");
			WriteLine("The extensions of 'index.htm' is " + System.IO.Path.GetExtension("index.htm"));
			WriteLine("<br/>");
		}
	}
}
