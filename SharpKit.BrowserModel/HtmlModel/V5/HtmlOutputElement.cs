using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// The output element represents the result of a calculation.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLOutputElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlOutputElement: HtmlElement
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string htmlFor
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlForm form
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string name
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string type
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string defaultValue
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string value
	{
		get;
		set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool willValidate
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ValidityState validity
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public string validationMessage
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public bool checkValidity()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void setCustomValidity(string error)
	{
		throw new NotImplementedException();
	}
}

}
