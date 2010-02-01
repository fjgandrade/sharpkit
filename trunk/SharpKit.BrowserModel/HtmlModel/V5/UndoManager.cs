using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// To manage undo object entries in the undo transaction history , the UndoManager interface can be used:
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "UndoManager", NativeConstructors = true, NativeEnumerator = true)]
public abstract class UndoManager
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong length
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	public object this[ulong index]
	{
		get
		{
			throw new NotImplementedException();
		}
		private set
		{
			throw new NotImplementedException();
		}
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong position
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public ulong add(object data, string title)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void remove(ulong index)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void clearUndo()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void clearRedo()
	{
		throw new NotImplementedException();
	}
}

}
