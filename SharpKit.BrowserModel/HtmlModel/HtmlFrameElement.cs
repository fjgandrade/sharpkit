using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies an individual frame within a frameSet element.
	/// </summary>
	public class HtmlFrameElement : HtmlElement
	{
		/// <summary>
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;

		[JsProperty(NativeField = true)]
		public string frameBorder
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string longDesc
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string marginHeight
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string marginWidth
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public string name
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public bool noResize
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public string scrolling
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public string src
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public Document contentDocument
		{
			get;
			private set;
		}
	}
}
