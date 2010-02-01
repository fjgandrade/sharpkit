using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// Media elements implement the following interface:
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "MediaError", NativeConstructors = true, NativeEnumerator = true)]
public abstract class MediaError
{
	 const ushort MEDIA_ERR_ABORTED = 1;
	 const ushort MEDIA_ERR_NETWORK = 2;
	 const ushort MEDIA_ERR_DECODE = 3;
	 const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ushort code
	{
		get;
		private set;
	}
}

}
