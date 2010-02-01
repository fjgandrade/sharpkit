using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{


[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "ImageData", NativeConstructors = true, NativeEnumerator = true)]
public abstract class ImageData
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong width
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong height
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public CanvasPixelArray data
	{
		get;
		private set;
	}
}

}
