using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	public class HtmlFieldSet : HtmlElement
	{
		/// <summary>
		/// Sets or retrieves how the object is aligned with adjacent text.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string align { get; set; }

		/// <summary>
		/// Retrieves a reference to the form that the object is embedded in.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string form { get; set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string name
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string type
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlFormControlsCollection elements
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool willValidate
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ValidityState validity
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string validationMessage
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool checkValidity()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void setCustomValidity(string error)
		{
			throw new NotImplementedException();
		}
	}
}
