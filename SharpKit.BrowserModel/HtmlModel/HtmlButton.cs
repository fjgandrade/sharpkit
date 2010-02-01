using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies a container for rich HTML that is rendered as a button.
	/// </summary>
	//[DisplayName("button")]
	//[PossibleChildControls("div,span,button,img,p,a,table,h1,h2,h3,br,hr")]
	public class HtmlButton : HtmlElement
	{
		/// <summary>
		/// Sets the access key for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string accessKey { get; set; }

		/// <summary>
		/// Gets the classification and default behavior of the button.
		/// Possible values:
		///	button	Default. Creates a Command button.
		/// reset	Creates a Reset button. If the button is in a form, it resets the fields in the form to their initial values.
		/// submit	Creates a Submit button. If the button is in a form, it submits the form.
		/// </summary>
		//[DisplayName("type")]
		//[PossibleControlAttributeValues("button,reset,submit")]
		[JsProperty(NativeField = true)]
		public string type { get; set; }

		/// <summary>
		/// Sets or retrieves the name of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string name { get; set; }

		/// <summary>
		/// Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFld { get; set; }

		/// <summary>
		/// Sets or retrieves the rendering format for the data supplied to the object.
		/// Possible values:
		///	text						Default. Data is rendered as text.
		/// html						Data is rendered as HTML.
		/// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFormatAs { get; set; }

		/// <summary>
		/// Sets or retrieves the source of the data for data binding.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataSrc { get; set; }

		/// <summary>
		/// Retrieves a reference to the form that the object is embedded in.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string form { get; set; }

		/// <summary>
		/// Sets or retrieves the value indicating whether the control is selected.
		/// Possible values:
		///	false	Default. Control is not selected.
		/// true	Control is selected.
		/// null	Control is not initialized.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool status { get; set; }

		/// <summary>
		/// Sets or retrieves the default or selected value of the control.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string value { get; set; }



		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool autofocus
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string formAction
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string formEnctype
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string formMethod
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string formNoValidate
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string formTarget
		{
			get;
			set;
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
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public NodeList labels
		{
			get;
			private set;
		}
	}
}
