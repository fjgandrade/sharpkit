using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[HtmlSpecificationVersion(5)]
	[JsType(Export = false, Name = "WindowSessionStorage")]
	public interface WindowSessionStorage
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		Storage sessionStorage { get; }
	}
}
