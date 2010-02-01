using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The optgroup element represents a group of option elements with a common label.
/// </summary>
[JsType(Export = false,Name = "HTMLOptGroupElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlOptGroupElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public new bool disabled
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string label
	{
		get;
		set;
	}
}

}
