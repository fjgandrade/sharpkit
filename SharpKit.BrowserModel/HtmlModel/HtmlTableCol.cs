using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies column-based defaults for the table properties.
	/// </summary>
	public class HtmlTableCol : HtmlElement
	{
		internal HtmlTableCol()
			: base()
		{
		}

		/// <summary>
		/// Sets or retrieves the width of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string width { get; set; }

		/// <summary>
		/// Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string chOff { get; set; }


		/// <summary>
		/// Sets or retrieves how text and other content are vertically aligned within the object that contains them.
		/// </summary>
		/// <remarks>
		/// <list type="table">
		/// <item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
		/// <item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
		/// <item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
		/// <item><term>top</term><description>Aligns the text at the top of the object.</description></item>
		/// </list>
		/// </remarks>
		[JsProperty(NativeField = true)]
		public string valign { get; set; }

		/// <summary>
		/// Sets or retrieves the number of columns in the group. 
		/// </summary>
		/// <remarks>
		/// Integer that specifies or receives the number of spanned columns. The default value is 1.
		/// </remarks>
		[JsProperty(NativeField = true)]
		public int span { get; set; }

		/// <summary>
		/// Sets or retrieves a value that you can use to implement your own ch functionality for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string ch { get; set; }


		/// <summary>
		/// Sets or retrieves the alignment of the object relative to the display or table.
		/// Possible Values:
		/// center	Aligns to the center.
		/// justify	Aligns to the left and right edge.
		///	left		Default. Aligns to the left edge.
		///	right		Aligns to the right edge.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string align { get; set; }

		[JsProperty(NativeField = true)]
		public string vAlign
		{
			get;
			set;
		}
	}
}
