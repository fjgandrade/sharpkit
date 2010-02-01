using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies a row in a table.
	/// </summary>
	//[DisplayName("tr")]
	//[PossibleChildControls("td,th")]
	public class HtmlTableRow : HtmlElement
	{
		internal HtmlTableRow()
			: base()
		{
		}

		[JsProperty(NativeField=true)]
		public HtmlNodeCollection<HtmlTableCell> cells { get; private set; }
		
		/// <summary>
		/// Creates a new cell in the table row (tr), and adds the cell to the cells collection. 
		/// </summary>
		/// <param name="index">Integer that specifies where to insert the cell in the tr. The default value is -1, which appends the new cell to the end of the cells collection.</param>
		/// <returns>Returns the td element object if successful, or null otherwise.</returns>		
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlTableCell insertCell(int index)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new cell in the table row (tr), and adds the cell to the cells collection. 
		/// </summary>
		/// <returns>Returns the td element object if successful, or null otherwise.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlTableCell insertCell()
		{
			throw new NotImplementedException();
		}

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


		/// <summary>
		/// Removes the specified cell (td) from the table row, as well as from the cells collection.
		/// </summary>
		/// <param name="iIndex">Integer that specifies the zero-based position of the cell to remove from the table row. If no value is provided, the last cell in the cells collection is deleted.</param>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads=true)]
		public void deleteCell(int iIndex)
		{
		}

		/// <summary>
		/// Removes the last cell (td) from the table row, as well as from the cells collection.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void deleteCell()
		{
		}

		/// <summary>
		/// Retrieves the position of the object in the rows collection for the table.
		/// </summary>
		[JsProperty(NativeField=true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"Opera keeps to the source code order (where the <tfoot> precedes the <tbody>.)")]
		public int rowIndex { get; private set; }

		/// <summary>
		/// Retrieves the position of the object in the tBody, tHead, tFoot, or rows collection.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int sectionRowIndex { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string align
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string bgColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string ch
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string chOff
		{
			get;
			set;
		}
	}
}
