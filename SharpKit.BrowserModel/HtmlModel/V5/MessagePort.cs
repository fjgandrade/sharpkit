using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// Each channel has two message ports. Data sent through one port is received by the other port, and vice versa.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "MessagePort", NativeConstructors = true, NativeEnumerator = true)]
public abstract class MessagePort:EventTarget
{
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void postMessage(object message, MessagePortArray ports)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void start()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void close()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler onmessage {get;set;}

	#region EventTarget Members

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates = true, NativeOverloads = true)]
	public void addEventListener(string type, HtmlDomEventHandler listener, bool useCapture)
	{
		throw new NotImplementedException();
	}

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates = true, NativeOverloads = true)]
	public void removeEventListener(string type, HtmlDomEventHandler listener, bool useCapture)
	{
		throw new NotImplementedException();
	}

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates = true, NativeOverloads = true)]
	public bool dispatchEvent(HtmlDomEventArgs evt)
	{
		throw new NotImplementedException();
	}

	#endregion
}

}
