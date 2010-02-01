using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// [ Constructor ] interface MessageChannel { readonly attribute MessagePort port1 ; readonly attribute MessagePort port2 ; };
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "MessageChannel", NativeConstructors = true, NativeEnumerator = true)]
public abstract class MessageChannel
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public MessagePort port1
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public MessagePort port2
	{
		get;
		private set;
	}
}

}
