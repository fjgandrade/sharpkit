using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "DedicatedWorkerGlobalScope")]
	[HtmlSpecificationVersion(5)]
	public interface DedicatedWorkerGlobalScope
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void postMessage(object message);
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void postMessage(object message, MessagePortArray ports);
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		JsFunction onmessage { get; set; }
	}
}
