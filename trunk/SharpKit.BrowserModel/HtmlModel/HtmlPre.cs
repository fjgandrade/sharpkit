using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Renders text in a fixed-width font.
	/// </summary>
	public class HtmlPre : HtmlElement
	{
		internal HtmlPre()
			: base()
		{
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong width
		{
			get;
			set;
		}
	}
}
