using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The datalist element represents a set of option elements that represent predefined options for other controls. The contents of the element represents fallback content for legacy user agents, intermixed with option elements that represent the predefined options. In the rendering, the datalist element represents nothing and it, along with its children, should be hidden .
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLDataListElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlDataListElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlElementCollection options
	{
		get;
		private set;
	}
}

}
