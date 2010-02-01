using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies a frameset, which is used to organize multiple frames and nested framesets.
	/// </summary>
	public class HtmlFrameSetElement : HtmlElement
	{
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
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;

		/// <summary>
		/// Fires immediately before the object is unloaded.
		/// </summary>		
		public HtmlDomEventHandler onunload;


		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string cols
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string rows
		{
			get;
			set;
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmessage { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onoffline { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ononline { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpagehide { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpageshow { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpopstate { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onredo { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onstorage { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onundo { get; set; }
	}
}
