using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Embeds an image or a video clip in the document.
	/// </summary>
	//[DisplayName("img")]
	//[PossibleChildControls("")]
	public class HtmlImage : HtmlElement
	{

		public void main()
		{
		}

		/*
NAME	name	 Sets or retrieves the name of the object.
		*/



		/// <summary>
		/// Sets or retrieves how the object is aligned with adjacent text.
		/// </summary>
		//[PossibleControlAttributeValues("absbottom,absmiddle,baseline,bottom,left,middle,right,texttop,top")]
		[JsProperty(NativeField = true)]
		public string align { get; set; }

		/// <summary>
		/// Sets or retrieves a text alternative to the graphic.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string alt { get; set; }

		/// <summary>
		/// Sets the properties to draw around the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string border { get; set; }

		/// <summary>
		/// Sets the height of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string height { get; set; }

		/// <summary>
		/// Sets the horizontal margin for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int hspace { get; set; }

		/// <summary>
		/// Sets a URL to be loaded by the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string src { get; set; }

		/// <summary>
		/// Sets the URL, often with a bookmark extension (#name), to use as a client-side image map.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string usemap { get; set; }

		/// <summary>
		/// Sets the vertical margin for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int vspace { get; set; }
		/// <summary>
		/// Sets the width of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string width { get; set; }

		/// <summary>
		/// Retrieves whether the object is fully loaded.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string complete { get; set; }

		/// <summary>
		/// Retrieves the date the file was created.
		/// </summary>
		[JsProperty(NativeField = true)]
		public DateTime fileCreatedDate { get; set; }

		/// <summary>
		/// Retrieves the date the file was last modified.
		/// </summary>
		[JsProperty(NativeField = true)]
		public DateTime fileModifiedDate { get; set; }

		/// <summary>
		/// Retrieves the file size.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int fileSize { get; set; }

		/// <summary>
		/// Retrieves the date the file was last updated.
		/// </summary>
		[JsProperty(NativeField = true)]
		public DateTime fileUpdatedDate { get; set; }

		/// <summary>
		/// Sets or retrieves a destination URL or an anchor point.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string href { get; set; }

		/// <summary>
		/// Sets or retrieves whether the image is a server-side image map.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string isMap { get; set; }

		/// <summary>
		/// Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string longDesc { get; set; }

		/// <summary>
		/// Sets or retrieves the number of times a sound or video clip will loop when activated.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string loop { get; set; }

		/// <summary>
		/// Sets or retrieves a lower resolution image to display.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string lowsrc { get; set; }

		/// <summary>
		/// Retrieves the file name specified in the href or src property of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string nameProp { get; set; }


		/// <summary>
		/// Sets or retrieves the protocol portion of a URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string protocol { get; set; }

		/// <summary>
		/// Sets or retrieves when a video clip file should begin playing.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string start { get; set; }

		/// <summary>
		/// Sets or retrieves the URL of the virtual reality modeling language (VRML) world to be displayed in the window.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string vrml { get; set; }

		/// <summary>
		/// Fires when the user aborts the download of an image.
		/// </summary>		
		public HtmlDomEventHandler onabort;

		/// <summary>
		/// Fires when an error occurs during object loading.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
		public HtmlDomEventHandler onerror;

		/// <summary>
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string useMap
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong naturalWidth
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong naturalHeight
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string name
		{
			get;
			set;
		}


	}
}
