using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

	/// <summary>
	/// Inserts a line break.
	/// </summary>
	public class HtmlBr : HtmlElement
	{
		internal HtmlBr()
			: base()
		{
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string clear
		{
			get;
			set;
		}
	}
}
