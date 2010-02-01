
using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{

	/// <summary>
	/// Specifies a container that renders HTML.
	/// </summary>
	public class HtmlDiv : HtmlElement
	{
		protected HtmlDiv()
		{
		}

		/// <summary>
		/// Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFld { get; set; }

		/// <summary>
		/// Sets or retrieves the rendering format for the data supplied to the object.
		/// Possible values:
		///	text						Default. Data is rendered as text.
		/// html						Data is rendered as HTML.
		/// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFormatAs { get; set; }

		/// <summary>
		/// Sets or retrieves the source of the data for data binding.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataSrc { get; set; }

		/// <summary>
		/// Sets or retrieves whether the browser automatically performs wordwrap.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool noWrap { get; set; }

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
	}

	public class HtmlScript : HtmlElement
	{

		/// <summary>
		/// Retrieves the URL to an external file that contains the source code or data.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string src { get; set; }

		/// <summary>
		/// Sets or retrieves the MIME type for the associated scripting engine.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string type { get; set; }

		[JsProperty(NativeField = true)]
		public string language { get; set; }

		/// <summary>
		/// Sets or retrieves the character set used to encode the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string charset { get; set; }

		/// <summary>
		/// Sets or retrieves the status of the script.
		/// Possible values:
		///	false		Default. Inline executable function is not deferred.
		/// true		Inline executable function is deferred.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool defer { get; set; }


		/// <summary>
		/// Sets or retrieves the event for which the script is written.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string @event { get; set; }

		/// <summary>
		/// Sets or retrieves the object that is bound to the event script.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string htmlFor { get; set; }

		/// <summary>
		/// Retrieves or sets the text of the object as a string.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string text { get; set; }
	}
}
