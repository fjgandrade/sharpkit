using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents a collection of rectangles, as returned by the <see cref="M:SharpKit.HtmlModel.HtmlElement.getClientRects"/> method.
	/// </summary>
	public class HtmlTextRectangleCollection
	{
		/// <summary>
		/// Gets or sets the rectangle at the Nth position
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		[JsProperty(NativeIndexer = true)]
		public HtmlTextRectangle this[int index]
		{
			get
			{
				throw new NotImplementedException("TODO: Implement");
			}
			set
			{
				throw new NotImplementedException("TODO: Implement");
			}
		}

		public int length;
	}

	/// <summary>
	/// Represents a rectangle, as returned by the <see cref="M:SharpKit.HtmlModel.HtmlElement.getClientRects"/> method.
	/// </summary>
	public class HtmlTextRectangle
	{
		public int top;
		public int left;
		public int bottom;
		public int right;
	}
}
