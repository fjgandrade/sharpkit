using System;
using SharpKit.JavaScriptModel;
using SharpKit.HtmlModel;
using Ext;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : ExtContext
	{
		static Window win = null;
		static index()
		{
			ExtClass.onReady(delegate()
			{
				var btn = ExtClass.get("btn");
				btn.on("click", delegate()
				{
					if (win == null)
					{
						win = new Window(new WindowConfig
						{
							applyTo = "win",
							width = 300,
							height = 200,
							closeAction = "hide",
						});
					}
					win.show(btn);
				});
			});
		}
	}
}
