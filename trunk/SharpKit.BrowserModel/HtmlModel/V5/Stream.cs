using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// Categories Flow content. Phrasing content. Interactive content. Contexts in which this element may be used: Where phrasing content is expected. Content model: Empty. Content attributes: Global attributes type DOM interface: interface HTMLDeviceElement : HTMLElement { attribute DOMString type; readonly attribute any data; };
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "Stream", NativeConstructors = true, NativeEnumerator = true)]
public abstract class Stream
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string URL
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public StreamRecorder record()
	{
		throw new NotImplementedException();
	}
}

}
