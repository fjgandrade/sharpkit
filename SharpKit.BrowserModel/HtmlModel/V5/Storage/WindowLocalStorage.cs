using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	[HtmlSpecificationVersion(5)]
	[JsType(Export = false, Name = "WindowLocalStorage")]
	public interface WindowLocalStorage
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		Storage localStorage { get; }
	}
}
