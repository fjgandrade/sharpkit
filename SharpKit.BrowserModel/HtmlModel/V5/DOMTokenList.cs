using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The DOMTokenList interface represents an interface to an underlying string that consists of a set of space-separated tokens .
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "DOMTokenList", NativeConstructors = true, NativeEnumerator = true)]
public abstract class DOMTokenList
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ulong length
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	public string this[ulong index]
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
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public bool contains(string token)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void add(string token)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void remove(string token)
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public bool toggle(string token)
	{
		throw new NotImplementedException();
	}
}

}
