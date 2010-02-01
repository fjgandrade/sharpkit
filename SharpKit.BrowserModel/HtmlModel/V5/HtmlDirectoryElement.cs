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

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLDirectoryElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlDirectoryElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string compact
	{
		get;
		set;
	}
}

}
