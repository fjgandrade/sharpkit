using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// To allow Web pages to integrate with Web browsers, certain Web browser interface elements are exposed in a limited way to scripts in Web pages.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "BarProp", NativeConstructors = true, NativeEnumerator = true)]
public abstract class BarProp
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool visible
	{
		get;
		set;
	}
}

}
