using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Inserts an object into the HTML page.
	/// </summary>
	public class HtmlObjectElement : HtmlElement
	{
		/// <summary>
		/// Fires when an error occurs during object loading.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
		public HtmlDomEventHandler onerror;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string data
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string type
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
		public string useMap
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlForm form
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string width
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string height
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public Document contentDocument
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public WindowProxy contentWindow
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
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string align
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string archive
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string border
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string code
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string codeBase
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string codeType
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool declare
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong hspace
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string standby
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong vspace
		{
			get;
			set;
		}
	}
}
