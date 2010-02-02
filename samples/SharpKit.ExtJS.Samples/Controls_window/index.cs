using System;
using SharpKit.JavaScriptModel;
using SharpKit.HtmlModel;

using Ext;
namespace Samples.examples.window
{


	[JsType(JsMode.Global, "index.js")]
	public class index : HtmlContext
	{
		/*!
 * Ext JS Library 3.1.0
 * Copyright(c) 2006-2009 Ext JS, LLC
 * licensing@extjs.com
 * http=//www.extjs.com/license
 */

		static index()
		{
			ExtClass.onReady(delegate()
			{
				Window win = null;
				var button = ExtClass.get("show-btn");

				button.on("click", delegate()
				{
					// create the window on the first click and reuse on subsequent clicks
					if (!win.As<bool>())
					{
						win = new Window(new WindowConfig
						{
							applyTo = "hello-win",
							layout = "fit",
							width = 500,
							height = 300,
							closeAction = "hide",
							plain = true,

							items = new TabPanel(new TabPanelConfig
							{
								applyTo = "hello-tabs",
								autoTabs = true,
								activeTab = 0,
								deferredRender = false,
								border = false
							}),

							buttons = new[]
							{
								new ButtonConfig
								{
                  text="Submit",
                  disabled=true
								},
								new ButtonConfig
								{
									text= "Close",
									handler = delegate()
									{
										win.hide();
									}
								}
							}
						});
					}
					win.show(@this.As<Ext.Element>());
				});
			});
		}
	}
}
