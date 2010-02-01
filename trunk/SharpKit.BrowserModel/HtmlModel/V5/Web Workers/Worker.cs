using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "Worker")]
	[HtmlSpecificationVersion(5)]
	public abstract class Worker : AbstractWorker
	{
		[HtmlSpecificationVersion(5)]
		public void terminate()
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public void postMessage(object message)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public void postMessage(object message, MessagePortArray ports)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public JsFunction onmessage { get; set; }
	}
}
