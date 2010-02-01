using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The source element allows authors to specify multiple media resources for media elements . It does not represent anything on its own.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLSourceElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlSourceElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string src
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string type
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string media
	{
		get;
		set;
	}
}

}
