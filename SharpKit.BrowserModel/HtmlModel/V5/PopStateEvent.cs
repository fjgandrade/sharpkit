using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// When an entry in the session history is activated (which happens during session history traversal), the user agent must run the following steps: If the entry is a state object entry, let statebe a structured clone of that state object. Otherwise, let statebe null. Run the appropriate steps according to the conditions described:If the current document readiness is set to the string "complete"Synchronously fire a popstate event on the Windowobject of the Document, using the PopStateEventinterface, with the stateattribute set to the value of state. This event must bubble but not be cancelable and has no default action.OtherwiseLet the Document's pending state object be state. (If there was already a pending state object, the previous one is discarded.)The event will then be fired just after the load event.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "PopStateEvent", NativeConstructors = true, NativeEnumerator = true)]
public abstract class PopStateEvent: EventArgs
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public object state
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void initPopStateEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object stateArg)
	{
		throw new NotImplementedException();
	}
}

}
