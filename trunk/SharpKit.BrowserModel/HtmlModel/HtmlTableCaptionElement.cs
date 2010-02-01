using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The caption element represents the title of the table that is its parent, if it has a parent and that is a table element.User agents must treat acronym elements in a manner equivalent to abbr elements.
/// </summary>
[JsType(Export = false,Name = "HTMLTableCaptionElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlTableCaptionElement: HtmlElement
{
	[JsProperty(NativeField=true)]
	public string align
	{
		get;
		set;
	}
}

}
