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
[JsType(Export = false,Name = "UndoManagerEvent", NativeConstructors = true, NativeEnumerator = true)]
public abstract class UndoManagerEvent: EventArgs
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public object data
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void initUndoManagerEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object dataArg)
	{
		throw new NotImplementedException();
	}
}

}
