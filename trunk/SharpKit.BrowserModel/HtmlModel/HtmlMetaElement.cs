using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The meta element represents various kinds of metadata that cannot be expressed using the title , base , link , style , and script elements.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
/// </summary>
[JsType(Export = false,Name = "HTMLMetaElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlMetaElement: HtmlElement
{
	
	[JsProperty(NativeField=true)]
	public string name
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string httpEquiv
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string content
	{
		get;
		set;
	}
	
	[JsProperty(NativeField=true)]
	public string scheme
	{
		get;
		set;
	}
}

}
