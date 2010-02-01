using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The tbody element represents a block of rows that consist of a body of data for the parent table element, if the tbody element has a parent and it is a table .The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLTableSectionElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlTableSectionElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlElementCollection rows
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public HtmlElement insertRow(long index)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void deleteRow(long index)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string align
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string ch
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string chOff
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string vAlign
	{
		get;
		set;
	}
}

}
