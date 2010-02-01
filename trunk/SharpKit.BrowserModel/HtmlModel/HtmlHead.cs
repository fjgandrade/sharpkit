using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents the HEAD element of a HTML document
	/// </summary>
	public class HtmlHead : HtmlElement
	{
		internal HtmlHead()
			: base()
		{
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string profile
		{
			get;
			set;
		}
	}
}
