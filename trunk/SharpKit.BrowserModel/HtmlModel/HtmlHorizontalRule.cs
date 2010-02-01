using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Draws a horizontal rule.
	/// </summary>
	public class HtmlHorizontalRule : HtmlElement
	{
		internal HtmlHorizontalRule()
			: base()
		{
		}

		[JsProperty(NativeField = true)]
		public string align
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public string color
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public bool noShade
		{
			get;
			set;
		}
		[JsProperty(NativeField = true)]
		public string size
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string width
		{
			get;
			set;
		}
	}
}
