using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The time element represents either a time on a 24 hour clock, or a precise date in the proleptic Gregorian calendar, optionally with a time and a time-zone offset. [GREGORIAN]
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLTimeElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlTimeElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string dateTime
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool pubDate
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public Date valueAsDate
	{
		get;
		private set;
	}
}

}
