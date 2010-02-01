using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The html element represents the root of an HTML document.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
/// </summary>


[JsType(Export = false,Name = "HTMLHtmlElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlHtmlElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string version
	{
		get;
		set;
	}
}

}
