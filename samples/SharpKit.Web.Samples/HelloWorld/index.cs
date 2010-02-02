using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.Extensions;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static void btn_click(HtmlElement sender, HtmlDomEventArgs e)
		{
			var c = index_Server.GetSomeData();
			alert(c.Text + c.Date.ToString());
		}
	}

	[Remotable]
	public class index_Server
	{
		public static index_Data GetSomeData()
		{
			return new index_Data { Text = "Hello from the server! ", Date = DateTime.Now };
		}
	}

	[JsType(JsMode.Clr)]
	public class index_Data
	{
		public string Text { get; set; }
		public DateTime Date { get; set; }
	}
}
