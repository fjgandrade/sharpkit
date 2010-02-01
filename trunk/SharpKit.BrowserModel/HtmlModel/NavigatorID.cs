using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

[JsType(Export = false,Name = "NavigatorID", NativeConstructors = true, NativeEnumerator = true)]
public interface NavigatorID
{
	
	[JsProperty(NativeField=true)]
	string appVersion
	{
		get;
	}
	
	[JsProperty(NativeField=true)]
	string platform
	{
		get;
	}
	
	[JsProperty(NativeField=true)]
	string userAgent
	{
		get;
	}
}

}
