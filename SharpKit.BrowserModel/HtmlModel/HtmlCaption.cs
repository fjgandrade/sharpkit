using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Specifies a brief description for a table.
	/// </summary>
	public class HtmlCaption : HtmlElement
	{
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
