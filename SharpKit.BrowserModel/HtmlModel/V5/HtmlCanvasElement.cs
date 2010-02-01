using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The canvas element provides scripts with a resolution-dependent bitmap canvas, which can be used for rendering graphs, game graphics, or other visual images on the fly.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLCanvasElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlCanvasElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong width
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong height
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public string toDataURL(string type, params object[] args)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public object getContext(string contextId)
	{
		throw new NotImplementedException();
	}
}

}
