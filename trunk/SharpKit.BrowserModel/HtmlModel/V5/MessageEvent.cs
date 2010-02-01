using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// interface UndoManagerEvent : Event { readonly attribute any data ; void initUndoManagerEvent (in DOMString typeArg, in boolean canBubbleArg, in boolean cancelableArg, in any dataArg); };
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "MessageEvent", NativeConstructors = true, NativeEnumerator = true)]
public abstract class MessageEvent: EventArgs
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public object data
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string origin
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string lastEventId
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public WindowProxy source
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public MessagePortArray ports
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void initMessageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object dataArg, string originArg, string lastEventIdArg, WindowProxy sourceArg, MessagePortArray portsArg)
	{
		throw new NotImplementedException();
	}
}

}
