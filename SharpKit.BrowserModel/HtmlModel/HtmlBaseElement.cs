using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The base element allows authors to specify the document base URL for the purposes of resolving relative URLs , and the name of the default browsing context for the purposes of following hyperlinks . The element does not represent any content beyond this information.
/// </summary>
[JsType(Export = false,Name = "HTMLBaseElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlBaseElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string href
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string target
	{
		get;
		set;
	}
}

}
