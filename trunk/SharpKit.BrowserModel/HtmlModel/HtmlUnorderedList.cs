using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents an unordered list
	/// </summary>
	public class HtmlUnorderedList : HtmlElement
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string compact
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
