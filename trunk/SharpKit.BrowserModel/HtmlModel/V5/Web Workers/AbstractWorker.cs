using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "AbstractWorker")]
	[HtmlSpecificationVersion(5)]
	public abstract class AbstractWorker : EventTarget
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		JsFunction onerror { get; set; }

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
