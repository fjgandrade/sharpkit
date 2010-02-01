using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{


[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "CanvasPixelArray", NativeConstructors = true, NativeEnumerator = true)]
public abstract class CanvasPixelArray
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong length
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	public ushort this[ulong index]
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}
}

}
