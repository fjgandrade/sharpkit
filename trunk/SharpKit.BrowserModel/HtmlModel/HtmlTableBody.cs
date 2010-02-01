using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Designates rows as the body of the table.
	/// </summary>
	//[DisplayName("tbody")]
	//[PossibleChildControls("tr")]
	public class HtmlTableBody : HtmlElement
	{
		/// <summary>
		/// Creates a new row (tr) in the table, and adds the row to the rows collection. 
		/// </summary>
		/// <param name="rowIndex">Integer that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
		/// <returns>Returns the tr element object if successful, or null otherwise. </returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlTableRow insertRow(int rowIndex)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Creates a new row (tr) in the table, and adds the row to the rows collection. 
		/// </summary>
		/// <returns>Returns the tr element object if successful, or null otherwise. </returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlTableRow insertRow()
		{
			throw new NotImplementedException();
		}

		public HtmlNodeCollection<HtmlTableRow> rows;

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
		/// Removes the specified row (tr) from the element and from the rows collection.
		/// </summary>
		/// <param name="iRowIndex">Integer that specifies the zero-based position in the rows collection of the row to remove.</param>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void deleteRow(int iRowIndex)
		{
		}

		/// <summary>
		/// Removes the last row (tr) from the element and from the rows collection.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void deleteRow()
		{
		}

		/// <summary>
		/// Deletes the tFoot element and its contents from the table.
		/// </summary>
		/// <remarks>If only one tFoot element exists in the source, the deleteTFoot method deletes the table footer. If multiple tFoot elements have been defined, the next tFoot element in the source order is promoted as the table footer.</remarks>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void deleteTFoot()
		{
		}

		/// <summary>
		/// Deletes the tHead element and its contents from the table.
		/// </summary>
		/// <remarks>If only one tHead element exists in the source, the deleteTHead method deletes the table header. If multiple tHead elements have been defined, the next tHead element in the source order is promoted as the table header.</remarks>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void deleteTHead()
		{
		}

		/// <summary>
		/// Moves a table row to a new position.
		/// </summary>
		/// <param name="iSource">Integer that specifies the index in the rows collection of the table row that is moved.</param>
		/// <param name="iTarget">Integer that specifies where the row is moved within the rows collection.</param>
		/// <returns>Object. Returns a reference to the table row that is moved.</returns>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		[JsMethod(NativeOverloads = true)]
		public HtmlTableRow moveRow(int iSource, int iTarget)
		{
			throw new NotImplementedException();
		}
	}
}
