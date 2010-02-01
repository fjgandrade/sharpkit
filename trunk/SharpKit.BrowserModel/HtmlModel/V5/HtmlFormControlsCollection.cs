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
[JsType(Export = false,Name = "HTMLFormControlsCollection", NativeConstructors = true, NativeEnumerator = true)]
	public abstract class HtmlFormControlsCollection : HtmlElementCollection
{
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public object namedItem(string name)
	{
		throw new NotImplementedException();
	}
}

}
