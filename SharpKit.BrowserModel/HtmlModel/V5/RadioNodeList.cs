using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{


[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "RadioNodeList", NativeConstructors = true, NativeEnumerator = true)]
public abstract class RadioNodeList: NodeList
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string value
	{
		get;
		set;
	}
}

}
