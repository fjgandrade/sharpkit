using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents a LINK html node
	/// </summary>
	public class HtmlLink : HtmlElement
	{
		internal HtmlLink()
			: base()
		{
		}

		/// <summary>
		/// Sets or retrieves the destination URL or anchor point.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string href { get; set; }

		/// <summary>
		/// Sets or retrieves the relationship between the object and the destination of the link. e.g. 'stylesheet'
		/// </summary>
		[JsProperty(NativeField = true)]
		public string rel { get; set; }

		/// <summary>
		/// Sets or retrieves the MIME type of the object. e.g. 'text/css'
		/// </summary>
		[JsProperty(NativeField = true)]
		public string type { get; set; }

		/// <summary>
		/// Fires when an error occurs during object loading.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
		public HtmlDomEventHandler onerror;

		/// <summary>
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public DOMTokenList relList
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string media
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string hreflang
		{
			get;
			set;
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string sizes
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string charset
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string rev
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
		
	}
}
