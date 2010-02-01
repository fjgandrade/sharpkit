using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies a cell in a table.
	/// </summary>
	//[DisplayName("td")]
	//[PossibleChildControls("div,span,button,img,p,a,table,h1,h2,h3,br,hr")]
	public class HtmlTableCell : HtmlElement
	{
		internal HtmlTableCell()
			: base()
		{
		}

		/// <summary>
		/// Sets or retrieves abbreviated text for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string abbr { get; set; }

		/// <summary>
		/// Sets or retrieves a comma-delimited list of conceptual categories associated with the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string axis { get; set; }

		/// <summary>
		/// Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string borderColorDark { get; set; }


		/// <summary>
		/// Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string borderColorLight { get; set; }

		/// <summary>
		/// Sets or retrieves a value that you can use to implement your own ch functionality for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string ch { get; set; }

		/// <summary>
		/// Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string chOff { get; set; }

		/// <summary>
		/// Sets or retrieves the number columns in the table that the object should span.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int colSpan { get; set; }

		/// <summary>
		/// Sets or retrieves a list of header cells that provide information for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string headers { get; set; }

		/// <summary>
		/// Sets or retrieves how many rows in a table the cell should span.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int rowSpan { get; set; }


		/// <summary>
		/// Sets or retrieves the group of cells in a table to which the object's information applies.
		/// Possible Values:
		/// row				The current cell provides header information for its row.
		/// col				The current cell provides header information for its column.
		/// rowgroup	The header cell provides header information for its row.
		/// colgroup	The header cell provides header information for its column.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string scope { get; set; }

		/// <summary>
		/// Sets or retrieves the width of the object.
		/// Possible Values:
		/// Integer			that specifies the width of the object in pixels.
		/// percentage	String that specifies an integer value followed by a %. The value is a percentage of the width of the parent object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string width { get; set; }

		/// <summary>
		/// Sets or retrieves the alignment of the object relative to the display or table.
		/// Possible Values:
		/// center	Aligns to the center.
		/// justify	Aligns to the left and right edge.
		///	left		Default. Aligns to the left edge.
		///	right		Aligns to the right edge.
		/// </summary>
		public string align;


		/// <summary>
		/// Sets whether the browser automatically performs wordwrap.
		/// </summary>
		//[DisplayName("nowrap")]
		[JsProperty(NativeField = true)]
		public bool noWrap { get; set; }

		/// <summary>
		/// Retrieves the position of the object in the cells collection of a row. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int cellIndex { get; set; }

		/// <summary>
		/// Deprecated. Sets or retrieves the background color behind the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string bgColor { get; set; }
		/// <summary>
		/// Sets the height of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string height { get; set; }

		/// <summary>
		/// String that specifies or receives one of the following values.
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
		public string vAlign { get; set; }
	}
}
