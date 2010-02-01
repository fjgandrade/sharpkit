using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies that the contained controls take part in a form.
	/// </summary>
	public class HtmlForm : HtmlElement
	{

		/*	 
ENCTYPE	encoding	 Sets or retrieves the MIME encoding for the form.
enctype	enctype	 Not currently supported.

NAME	name	 Sets or retrieves the name of the object.
TARGET	target	 Sets or retrieves the window or frame at which to target content.
		*/

		/// <summary>
		/// Sets or retrieves a list of character encodings for input data that must be accepted by the server processing the form.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string acceptCharset { get; set; }


		/// <summary>
		/// Sets or retrieves the number of objects in a collection.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int length { get; set; }

		/// <summary>
		/// Sets or retrieves the URL to which the form content is sent for processing.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string action { get; set; }

		/// <summary>
		/// Sets or retrieves how to send the form data to the server.
		/// Receives one of the following values:
		/// <list type="table">
		/// <item><term>GET</term><description>Append the arguments to the action URL and open it as if it were an anchor.</description></item>
		/// <item><term>POST</term><description>Send the data through an HTTP post transaction.</description></item>
		/// </list>
		/// </summary>
		[JsProperty(NativeField = true)]
		public string method { get; set; }


		/// <summary>
		/// Submits the form.
		/// </summary>
		public void submit()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Fires when the user resets a form.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onreset;

		/// <summary>
		/// Fires when a FORM is about to be submitted.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public HtmlDomEventHandler onsubmit;






		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool autocomplete
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string enctype
		{
			get;
			set;
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string name
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool noValidate
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string target
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlFormControlsCollection elements
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public object item(ulong index)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public object namedItem(string name)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void reset()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool checkValidity()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void dispatchFormInput()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void dispatchFormChange()
		{
			throw new NotImplementedException();
		}
	}
}
