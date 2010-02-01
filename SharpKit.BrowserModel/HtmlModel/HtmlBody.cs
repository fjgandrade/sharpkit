using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents the root Body element of a HTML document
	/// </summary>
	public class HtmlBody : HtmlElement
	{
		internal HtmlBody()
			: base()
		{
		}

		/// <summary>
		/// Creates a TextRange object for the element
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlTextRange createTextRange()
		{
			throw new NotImplementedException();
		}





		/// <summary>
		/// Fires on the object immediately after its associated document prints or previews for printing.
		/// </summary>		
		public HtmlDomEventHandler onafterprint;

		/// <summary>
		/// Fires on the object before its associated document prints or previews for printing.
		/// </summary>		
		public HtmlDomEventHandler onbeforeprint;

		/// <summary>
		/// Fires prior to a page being unloaded.
		/// </summary>		
		public HtmlDomEventHandler onbeforeunload;

		/// <summary>
		/// Raised when there are changes to the portion of a URL that follows the number sign (#).
		/// </summary>		
		public HtmlDomEventHandler onhashchange;

		/// <summary>
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;

		/// <summary>
		/// Raised when Internet Explorer is working offline.
		/// </summary>		
		public HtmlDomEventHandler onoffline;

		/// <summary>
		/// Raised when Internet Explorer is working online.
		/// </summary>		
		public HtmlDomEventHandler ononline;

		/// <summary>
		/// Fires when the current selection changes.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public HtmlDomEventHandler onselect;

		/// <summary>
		/// Fires immediately before the object is unloaded.
		/// </summary>		
		public HtmlDomEventHandler onunload;



		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onerror { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmessage { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpopstate { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpagehide { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpageshow { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onredo { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onstorage { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onundo { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string text
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string bgColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string background
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string link
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string vLink
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string aLink
		{
			get;
			set;
		}
	}
}

