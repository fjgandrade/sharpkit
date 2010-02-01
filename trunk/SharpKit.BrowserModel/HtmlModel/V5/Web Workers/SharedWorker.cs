using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[HtmlSpecificationVersion(5)]
	[JsType(NativeConstructors = true, Name = "SharedWorker")]
	public class SharedWorker : AbstractWorker
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public SharedWorker(string scriptURL)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public SharedWorker(string scriptURL, string name)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public MessagePort port { get; set; }
	}
}
