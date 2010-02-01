using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Denotes one choice in a SELECT element.
	/// </summary>
	public class HtmlOption : HtmlElement
	{
		/// <summary>
		/// Sets or retrieves the value which is returned to the server when the form control is submitted.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string value { get; set; }

		/// <summary>
		/// Sets or retrieves the text string specified by the option tag. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string text { get; set; }

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
		/// Sets or retrieves the status of an option.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool defaultSelected { get; set; }

		/// <summary>
		/// Retrieves a reference to the form that the object is embedded in.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string form { get; set; }

		/// <summary>
		/// Sets or retrieves the ordinal position of an option in a list box.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string label { get; set; }

		/// <summary>
		/// Sets or retrieves whether the option in the list box is the default item.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool selected { get; set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public long index
		{
			get;
			private set;
		}
	}
}
