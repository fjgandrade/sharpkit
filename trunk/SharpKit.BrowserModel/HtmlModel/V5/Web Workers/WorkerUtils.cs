using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "WorkerUtils")]
	[HtmlSpecificationVersion(5)]
	public partial class WorkerUtils : WindowTimers
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public void importScripts(params string[] urls)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public WorkerNavigator navigator { get; private set; }

		#region WindowTimers Members

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int setTimeout(JsFunction action, int ms)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int setTimeout(Action action, int ms)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public void clearTimeout(int id)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int setInterval(JsFunction func, int ms)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int setInterval(Action func, int ms)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int clearInterval(int ms)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
