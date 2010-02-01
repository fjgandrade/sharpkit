using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

	/// <summary>
	/// Creates inline floating frames. 
	/// </summary>
	public class HtmlIFrame : HtmlElement
	{
		internal HtmlIFrame()
			: base()
		{
		}

		[JsProperty(NativeField = true)]
		public string readyState
		{
			get
			{
				throw new NotImplementedException(" ");
			}
		}


		/// <summary>
		/// Sets or retrieves whether to display a border for the frame.
		/// Possible values:
		///	1		Default. Inset border is drawn.
		/// 0		No border is drawn.
		/// no		No border is drawn.
		/// yes		Inset border is drawn.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string frameBorder { get; set; }

		/// <summary>
		/// Sets or retrieves a URL to be loaded by the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string src { get; set; }

		/// <summary>
		/// Sets or retrieves whether the object can be transparent.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool allowTransparency { get; set; }

		/// <summary>
		/// Sets or retrieves the space between the frames, including the 3-D border. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string border { get; set; }

		/// <summary>
		/// Sets or retrieves the top and bottom margin heights before displaying the text in a frame. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int marginHeight { get; set; }

		/// <summary>
		/// Sets or retrieves the left and right margin widths before displaying the text in a frame. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int marginWidth { get; set; }

		/// <summary>
		/// Sets or retrieves the height of the object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string height { get; set; }

		/// <summary>
		/// Sets or retrieves the width of the object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string width { get; set; }
		/// <summary>
		/// Sets or retrieves the vertical margin for the object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int vspace { get; set; }

		/// <summary>
		/// Sets or retrieves whether the frame can be scrolled.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string scrolling { get; set; }

		/// <summary>
		/// Sets or retrieves a value that indicates the table alignment.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string align { get; set; }

		// IE 8
		///// <summary>
		///// Retrieves the document object of the page or frame.
		///// </summary>
		//[JsProperty(TreatAsNativeJsField = true)]
		//public string contentDocument { get; set; }

		/// <summary>
		/// Retrieves the window object of the specified frame or iframe.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlWindow contentWindow { get; set; }

		/// <summary>
		/// Sets or retrieves the amount of additional space between the frames.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string frameSpacing { get; set; }

		/// <summary>
		/// Sets or retrieves the horizontal margin for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string hspace { get; set; }

		/// <summary>
		/// Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string longDesc { get; set; }

		/// <summary>
		/// Sets or retrieves the frame name.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string name { get; set; }

		/// <summary>
		/// Sets or retrieves whether the user can resize the frame.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool noResize { get; set; }

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
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string sandbox
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool seamless
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public Document contentDocument
		{
			get;
			private set;
		}
	}
}
