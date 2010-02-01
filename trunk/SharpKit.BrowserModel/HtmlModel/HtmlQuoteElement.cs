using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The blockquote element represents a section that is quoted from another source.
/// </summary>
[JsType(Export = false,Name = "HTMLQuoteElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlQuoteElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string cite
	{
		get;
		set;
	}
}

}
