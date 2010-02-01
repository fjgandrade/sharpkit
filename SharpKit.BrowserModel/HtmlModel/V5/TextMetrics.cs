using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{


[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "TextMetrics", NativeConstructors = true, NativeEnumerator = true)]
public abstract class TextMetrics
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public float width
	{
		get;
		private set;
	}
}

}
