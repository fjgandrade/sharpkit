using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The label represents a caption in a user interface. The caption can be associated with a specific form control , known as the labelelement's labeled control , either using for attribute, or by putting the form control inside the label element itself.
/// </summary>
[JsType(Export = false,Name = "HTMLLabelElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlLabelElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public HtmlForm form
	{
		get;
		private set;
	}
	
	[JsProperty(NativeField=true)]
	public string htmlFor
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public HtmlElement control
	{
		get;
		private set;
	}
}

}
