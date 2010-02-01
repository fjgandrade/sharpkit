using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents the TITLE element of a HTML document
	/// </summary>
	public class HtmlTitle : HtmlElement
	{
		internal HtmlTitle()
			: base()
		{
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string text
		{
			get;
			set;
		}
	}
}
