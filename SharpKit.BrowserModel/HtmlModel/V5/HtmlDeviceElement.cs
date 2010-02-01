using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The device element represents a device selector, to allow the user to give the page access to a device, for example a video camera.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLDeviceElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlDeviceElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string type
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public object data
	{
		get;
		private set;
	}
}

}
