using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// window. getSelection() document. getSelection() Returns the Selectionobject for the window, which stringifies to the text of the current selection.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "Selection", NativeConstructors = true, NativeEnumerator = true)]
public abstract class Selection
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public Node anchorNode
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public long anchorOffset
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public Node focusNode
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public long focusOffset
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool isCollapsed
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void collapse(Node parentNode, long offset)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void collapseToStart()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void collapseToEnd()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void selectAllChildren(Node parentNode)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void deleteFromDocument()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public long rangeCount
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public Range getRangeAt(long index)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void addRange(Range range)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void removeRange(Range range)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void removeAllRanges()
	{
		throw new NotImplementedException();
	}
}

}
