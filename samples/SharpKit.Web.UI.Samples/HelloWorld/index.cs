using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.Web.UI.Controls;
using SharpKit.Extensions;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void init()
		{
			var c = new MyControl();
			document.body.appendChild(c.Element);
		}
	}

	class MyControl : Panel
	{
		protected override void Render()
		{
			base.Render();
			var btn = new Button { Text = "Click me" };
			btn.Click += new HtmlDomEventHandler(btn_Click);
			AppendChild(btn);
		}

		void btn_Click(HtmlDomEventArgs e)
		{
			var text = "<br/> Button was clicked on " + DateTime.Now;
			AppendChild(new Label { ParseContents = true, Text = text });
		}
	}
}
