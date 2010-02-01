using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{


[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "NavigatorOnLine", NativeConstructors = true, NativeEnumerator = true)]
public interface NavigatorOnLine
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	bool onLine
	{
		get;
	}
}

}
