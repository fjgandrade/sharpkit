using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies a script for the page that is interpreted by a script engine.
	/// </summary>
	public class HtmlScriptElement : HtmlElement
	{
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
		public bool async
		{
			get;
			set;
		}
	}
}
