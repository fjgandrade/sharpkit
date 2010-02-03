using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.Extensions;
using SharpKit.Web.UI.Controls;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void init()
		{
			var c = new TextEditor();
			document.body.appendChild(c.Element);
		}
	}
}
