using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// User agents must treat acronym elements in a manner equivalent to abbr elements.
/// </summary>
[JsType(Export = false,Name = "HTMLFontElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlFontElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string color
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string face
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string size
	{
		get;
		set;
	}
}

}
