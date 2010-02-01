using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The details element represents a disclosure widget from which the user can obtain additional information or controls.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLDetailsElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlDetailsElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool open
	{
		get;
		set;
	}
}

}
