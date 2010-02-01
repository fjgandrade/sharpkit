using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The map element, in conjunction with any area element descendants, defines an image map . The element represents its children.
/// </summary>
[JsType(Export = false,Name = "HTMLMapElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlMapElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string name
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public HtmlElementCollection areas
	{
		get;
		private set;
	}
	
	[JsProperty(NativeField=true)]
	public HtmlElementCollection images
	{
		get;
		private set;
	}
}

}
