using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "SharedWorkerGlobalScope")]
	[HtmlSpecificationVersion(5)]
	public class SharedWorkerGlobalScope : WorkerGlobalScope
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string name { get; private set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ApplicationCache applicationCache { get; private set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public JsFunction onconnect { get; private set; }
	}
}
