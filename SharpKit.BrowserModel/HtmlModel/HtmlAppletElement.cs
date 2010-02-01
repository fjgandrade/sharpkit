using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The applet element is a Java-specific variant of the embed element. The applet element is now obsoleted so that all extension frameworks (Java, .NET, Flash, etc) are handled in a consistent manner.
/// </summary>
[JsType(Export = false,Name = "HTMLAppletElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlAppletElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string align
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string alt
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string archive
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string code
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string codeBase
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string height
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public ulong hspace
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string name
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string _object
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public ulong vspace
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string width
	{
		get;
		set;
	}
}

}
