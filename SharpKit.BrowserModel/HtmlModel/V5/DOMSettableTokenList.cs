using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The DOMSettableTokenList interface is the same as the DOMTokenList interface, except that it allows the underlying string to be directly changed.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "DOMSettableTokenList", NativeConstructors = true, NativeEnumerator = true)]
public abstract class DOMSettableTokenList: DOMTokenList
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string value
	{
		get;
		set;
	}
}

}
