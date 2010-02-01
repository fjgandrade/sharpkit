using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	public class HtmlAnchor : HtmlElement
	{
		/// <summary>
		/// Sets or retrieves a destination URL or an anchor point.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string href { get; set; }

		/// <summary>
		/// Sets or retrieves the window or frame at which to target content.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string target { get; set; }

		/// <summary>
		/// Sets or retrieves the character set used to encode the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string charset { get; set; }

		/// <summary>
		/// Sets or retrieves the coordinates of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string coords { get; set; }

		/// <summary>
		/// Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFld { get; set; }

		/// <summary>
		/// Sets or retrieves the source of the data for data binding.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataSrc { get; set; }

		/// <summary>
		/// Sets or retrieves the subsection of the href property that follows the number sign (#).
		/// </summary>
		[JsProperty(NativeField = true)]
		public string hash { get; set; }

		/// <summary>
		/// Sets or retrieves the hostname and port number of the location or URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string host { get; set; }

		/// <summary>
		/// Sets or retrieves the host name part of the location or URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string hostname { get; set; }

		/// <summary>
		/// Sets or retrieves the language code of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string hreflang { get; set; }

		/// <summary>
		/// Sets or gets the list of HTTP methods supported by the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string Methods { get; set; }

		/// <summary>
		/// Sets or retrieves the name of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string name { get; set; }

		/// <summary>
		/// Retrieves the file name specified in the href or src property of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string nameProp { get; set; }

		/// <summary>
		/// Sets or retrieves the file name or path specified by the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string pathname { get; set; }


		/// <summary>
		/// Sets or retrieves the port number associated with a URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string port { get; set; }


		/// <summary>
		/// Sets or retrieves the protocol portion of a URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string protocol { get; set; }

		/// <summary>
		/// Sets or retrieves the relationship between the object and the destination of the link.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string rel { get; set; }

		/// <summary>
		/// Sets or retrieves the relationship between the object and the destination of the link.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string rev { get; set; }

		/// <summary>
		/// Sets or retrieves the substring of the href property that follows the question mark.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string search { get; set; }

		/// <summary>
		/// Sets or retrieves the shape of the object.
		/// Possible values:
		///	circ		Circle
		/// circle		Circle
		/// poly		Polygon
		/// polygon		Polygon
		/// rect		Rectangle
		/// rectangle	Rectangle
		/// </summary>
		[JsProperty(NativeField = true)]
		public string shape { get; set; }

		/// <summary>
		/// Sets or retrieves the MIME type of the object. e.g. 'text/css'
		/// </summary>
		[JsProperty(NativeField = true)]
		public string type { get; set; }

		/// <summary>
		/// Sets or gets a Uniform Resource Name (URN) for a target document.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string urn { get; set; }
		
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public DOMTokenList relList
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string media
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string ping
		{
			get;
			set;
		}
	}
}
