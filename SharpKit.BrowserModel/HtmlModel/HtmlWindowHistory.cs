using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// interface History { readonly attribute long length ; void go (in optional long delta); void back (); void forward (); void pushState (in any data, in DOMString title, in optional DOMString url); void replaceState (in any data, in DOMString title, in optional DOMString url); };
/// </summary>
[JsType(Export = false,Name = "History", NativeConstructors = true, NativeEnumerator = true)]
public abstract class History
{
	
	[JsProperty(NativeField=true)]
	public long length
	{
		get;
		private set;
	}
	
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void go(long delta)
	{
		throw new NotImplementedException();
	}
	
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void back()
	{
		throw new NotImplementedException();
	}
	
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void forward()
	{
		throw new NotImplementedException();
	}
	
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void pushState(object data, string title, string url)
	{
		throw new NotImplementedException();
	}
	
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void replaceState(object data, string title, string url)
	{
		throw new NotImplementedException();
	}
}

}
