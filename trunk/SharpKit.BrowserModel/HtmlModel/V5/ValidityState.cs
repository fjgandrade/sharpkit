using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// Categories Flow content. Phrasing content. If the typeattribute is not in the Hidden state: Interactive content. Listed, labelable, submittable, and resettableform-associated element. Contexts in which this element may be used: Where phrasing content is expected. Content model: Empty. Content attributes: Global attributes accept alt autocomplete autofocus checked disabled form formaction formenctype formmethod formnovalidate formtarget height list max maxlength min multiple name pattern placeholder readonly required size src step type value width DOM interface: interface HTMLInputElement : HTMLElement { attribute DOMString accept; attribute DOMString alt; attribute boolean autocomplete; attribute boolean autofocus; attribute boolean defaultChecked; attribute boolean checked; attribute boolean disabled; readonly attribute HTMLFormElement form; readonly attribute FileListfiles; attribute DOMString formAction; attribute DOMString formEnctype; attribute DOMString formMethod; attribute boolean formNoValidate; attribute DOMString formTarget; attribute DOMString height; attribute boolean indeterminate; readonly attribute HTMLElement list; attribute DOMString max; attribute long maxLength; attribute DOMString min; attribute boolean multiple; attribute DOMString name; attribute DOMString pattern; attribute DOMString placeholder; attribute boolean readOnly; attribute boolean required; attribute unsigned long size; attribute DOMString src; attribute DOMString step; attribute DOMString type; attribute DOMString defaultValue; attribute DOMString value; attribute DatevalueAsDate; attribute float valueAsNumber; readonly attribute HTMLOptionElement selectedOption; attribute DOMString width; void stepUp(in optional long n); void stepDown(in optional long n); readonly attribute boolean willValidate; readonly attribute ValidityState validity; readonly attribute DOMString validationMessage; boolean checkValidity(); void setCustomValidity(in DOMString error); readonly attribute NodeListlabels; void select(); attribute unsigned long selectionStart; attribute unsigned long selectionEnd; void setSelectionRange(in unsigned long start, in unsigned long end); };
/// </summary>
[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "ValidityState", NativeConstructors = true, NativeEnumerator = true)]
public abstract class ValidityState
{
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool valueMissing
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool typeMismatch
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool patternMismatch
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool tooLong
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool rangeUnderflow
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool rangeOverflow
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool stepMismatch
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool customError
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public bool valid
	{
		get;
		private set;
	}
}

}
