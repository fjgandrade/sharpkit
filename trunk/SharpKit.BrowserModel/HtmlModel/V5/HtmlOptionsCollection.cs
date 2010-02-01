using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The HTMLCollection , HTMLAllCollection , HTMLFormControlsCollection , HTMLOptionsCollection , and HTMLPropertiesCollection interfaces represent various lists of DOM nodes. Collectively, objects implementing these interfaces are called collections.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLOptionsCollection", NativeConstructors = true, NativeEnumerator = true)]
	public abstract class HtmlOptionsCollection : HtmlElementCollection
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong length
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public object namedItem(string name)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void add(HtmlElement element, HtmlElement before)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void add(HtmlElement element, long before)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void remove(long index)
	{
		throw new NotImplementedException();
	}
}

}
