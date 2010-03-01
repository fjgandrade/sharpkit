using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.Extensions;

namespace Reflection
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void doTest(HtmlElement sender, HtmlDomEventArgs e)
		{
			var c = new Contact { FirstName = "Shooki", LastName = "Booki", Birthday = new DateTime(1976, 9, 24) };

			var type = c.GetType();
			writeLine(type.Name);
			writeLine("{");
			foreach (var prop in type.GetProperties())
			{
				writeLine(prop.Name + " : " + prop.GetValue(c, null));
			}
			writeLine("}");
		}

		static void writeLine(string s)
		{
			document.body.appendChild(document.createTextNode(s));
			document.body.appendChild(document.createElement("br"));
		}
	}

	[JsType(JsMode.Clr, "index.js")]
	public class Contact
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime Birthday { get; set; }
	}
}
