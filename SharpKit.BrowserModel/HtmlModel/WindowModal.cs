using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// 6.5.6.1 Event handlers
/// </summary>
[JsType(Export = false,Name = "WindowModal", NativeConstructors = true, NativeEnumerator = true)]
public interface WindowModal
{
	
	[JsProperty(NativeField=true)]
	object dialogArguments
	{
		get;
	}
	
	[JsProperty(NativeField=true)]
	string returnValue
	{
		get;
		set;
	}
}

}
