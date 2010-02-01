using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The area element represents either a hyperlink with some text and a corresponding area on an image map , or a dead area on an image map.User agents must treat acronym elements in a manner equivalent to abbr elements.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLAreaElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlAreaElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string alt
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string coords
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string shape
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string href
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string target
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string ping
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string rel
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public DOMTokenList relList
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string media
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string hreflang
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
	public string protocol
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string host
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string hostname
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string port
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string pathname
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string search
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string hash
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool noHref
	{
		get;
		set;
	}
}

}
