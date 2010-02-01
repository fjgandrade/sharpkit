using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The dl element represents an association list consisting of zero or more name-value groups (a description list). Each group must consist of one or more names ( dt elements) followed by one or more values ( dd elements). Within a single dl element, there should not be more than one dt element for each name.User agents must treat acronym elements in a manner equivalent to abbr elements.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLDListElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlDListElement: HtmlElement
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
