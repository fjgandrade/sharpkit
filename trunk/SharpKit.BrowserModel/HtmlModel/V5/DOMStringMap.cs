using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The DOMStringMap interface represents a set of name-value pairs. It exposes these using the scripting language's native mechanisms for property access.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "DOMStringMap", NativeConstructors = true, NativeEnumerator = true)]
public abstract class DOMStringMap
{
	[HtmlSpecificationVersion(5)]
	public string this[string name]
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}
}

}
