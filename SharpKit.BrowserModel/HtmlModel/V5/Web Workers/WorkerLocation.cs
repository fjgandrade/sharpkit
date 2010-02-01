using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "WorkerLocation")]
	[HtmlSpecificationVersion(5)]
	public interface WorkerLocation
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string href { get; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string protocol { get; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string host { get; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string hostname { get; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string port { get; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string pathname { get; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string search { get; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string hash { get; }
	}
}
