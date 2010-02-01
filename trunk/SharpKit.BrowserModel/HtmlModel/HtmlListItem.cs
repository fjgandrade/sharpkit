using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents an HTML list item
	/// </summary>
	public class HtmlListItem : HtmlElement
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public long value
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string type
		{
			get;
			set;
		}
	}
}
