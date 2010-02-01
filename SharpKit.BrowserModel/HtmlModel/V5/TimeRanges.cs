using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// This section is non-normative.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "TimeRanges", NativeConstructors = true, NativeEnumerator = true)]
public abstract class TimeRanges
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong length
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public float start(ulong index)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public float end(ulong index)
	{
		throw new NotImplementedException();
	}
}

}
