using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// These elements represent headings for their sections.User agents must treat acronym elements in a manner equivalent to abbr elements.
/// </summary>
[JsType(Export = false,Name = "HTMLHeadingElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlHeadingElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string align
	{
		get;
		set;
	}
}

}
