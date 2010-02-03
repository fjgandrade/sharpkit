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
			var c = new TextEditor { Syntax = "javascript", Border="solid 1px #cccccc", Height="300px", Width = "400px"};
			c.Text = @"
function foo()
{
  //Type some code here...
}
";
			document.body.appendChild(c.Element);
		}
	}
}
