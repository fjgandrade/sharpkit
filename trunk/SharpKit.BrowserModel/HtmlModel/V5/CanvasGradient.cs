using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{


[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "CanvasGradient", NativeConstructors = true, NativeEnumerator = true)]
public abstract class CanvasGradient
{
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void addColorStop(float offset, string color)
	{
		throw new NotImplementedException();
	}
}

}
