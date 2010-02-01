using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// A video element is used for playing videos or movies.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLVideoElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlVideoElement: HtmlMediaElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string width
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string height
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong videoWidth
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong videoHeight
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string poster
	{
		get;
		set;
	}
}

}
