using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Denotes a paragraph.
	/// </summary>
	//[DisplayName("p")]
	//[PossibleChildControls("div,span,button,img,p,a,table,h1,h2,h3,br,hr")]
	public class HtmlParagraph : HtmlDiv
	{
		internal HtmlParagraph()
			: base()
		{
		}

		///// <summary>
		///// Sets or retrieves the alignment of the object relative to the display or table.
		///// Possible Values:
		///// center	Aligns to the center.
		///// justify	Aligns to the left and right edge.
		/////	left		Default. Aligns to the left edge.
		/////	right		Aligns to the right edge.
		///// </summary>
		//[JsProperty(TreatAsNativeJsField = true)]
		//public string align { get; set; }

		/// <summary>
		/// Sets or retrieves the side on which floating objects are not to be positioned when any IHTMLBlockElement is inserted into the document.
		/// Possible Values:
		/// all		Object is moved below any floating object.
		/// left	Object is moved below any floating object on the left side.
		///	right Object is moved below any floating object on the right side.
		///	none	Floating objects are allowed on all sides.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string clear { get; set; }
		

	}
}
