using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents an @page rule within a styleSheet.
	/// </summary>
	public class HtmlStyleSheetPage
	{
		/// <summary>
		/// Retrieves a string that identifies the pseudo class of the page or pages an @page rule applies to.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string pseudoClass { get; private set; }

		/// <summary>
		/// Retrieves a string that identifies which page or pages an @page rule applies to.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string selector { get; private set; }
	}
}
