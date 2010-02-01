using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	public class HtmlScreen
	{
		/// <summary>
		/// Retrieves the height of the working area of the system's screen, excluding the Microsoft Windows taskbar.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int availHeight { get; private set; }

		/// <summary>
		/// Retrieves the width of the working area of the system's screen, excluding the Windows taskbar.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int availWidth { get; private set; }

		/// <summary>
		/// Sets or retrieves the update interval for the screen.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public int updateInterval { get; set; }

		/// <summary>
		/// Retrieves whether the user has enabled font smoothing in the Display control panel.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public bool fontSmoothingEnabled { get; private set; }

		/// <summary>
		/// Sets or retrieves the number of bits per pixel used for colors in the off-screen bitmap buffer.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public int bufferDepth { get; private set; }

		/// <summary>
		/// The color depth (in bits) of the screen
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int colorDepth { get; private set; }

		/// <summary>
		/// The color depth (in bits) of the screen. (Same as colorDepth)
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use colorDepth.")]
		public int pixelDepth { get; private set; }

		/// <summary>
		/// The width of the screen
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int width { get; private set; }

		/// <summary>
		/// The height of the screen
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int height { get; private set; }



		//deviceXDPI	 Retrieves the actual number of horizontal dots per inch (DPI) of the system's screen.
		//deviceYDPI	 Retrieves the actual number of vertical dots per inch (DPI) of the system's screen.
		//logicalXDPI	 Retrieves the normal number of horizontal dots per inch (DPI) of the system's screen.
		//logicalYDPI	 Retrieves the normal number of vertical dots per inch (DPI) of the system's screen.
		//systemXDPI  	 Retrieves the number of horizontal dots per inch (dpi) of display resolution at normal zoom level.
		//systemYDPI  	 Retrieves the number of vertical dpi of display resolution at normal zoom level.
	}
}
