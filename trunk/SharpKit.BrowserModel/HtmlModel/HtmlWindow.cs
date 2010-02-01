using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export=false, NativeOverloads=true, NativeFields=true)]
	public partial class HtmlWindow : Navigator, WindowModal, WindowTimers
	{
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8 | BrowserTypes.IE8AsIE7, "Use event handler's argument")]
		public HtmlDomEventArgs @event { get; private set; }

		[JsMethod(NativeOverloads = true)]
		public void resizeBy(int x, int y)
		{
		}

		//[JsProperty(TreatAsNativeJsField = true)]
		//public HtmlDomEventArgs @event { get { throw new NotImplementedException(); } }
		/// <summary>
		/// Causes the element to lose focus and fires the onblur event.
		/// </summary>
		public void blur()
		{
		}

		/// <summary>
		/// Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
		/// </summary>
		public int scrollTop;

		/// <summary>
		/// Retrieves the x-coordinate of the upper left-hand corner of the browser's client area, relative to the upper left-hand corner of the screen. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int screenLeft
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Retrieves the y-coordinate of the top corner of the browser's client area, relative to the top corner of the screen.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int screenTop
		{
			get
			{
				throw new NotImplementedException();
			}
		}
		/// <summary>
		/// Retrieves the frame or iframe object that is hosting the window in the parent document.
		/// </summary>
		public HtmlIFrame frameElement; //TODO:  This could also be a Frame (not just IFrame)

		/// <summary>
		/// Retrieves the HtmlDocument object that is contained in this window object.
		/// </summary>
		public HtmlDocument document;

		/// <summary>
		/// Sets or retrieves a reference to the window that created the current window. 
		/// </summary>
		public HtmlWindow opener;

		/// <summary>
		/// Retrieves the topmost ancestor window.
		/// </summary>
		public HtmlWindow top;

		/// <summary>
		/// Retrieves the parent of the window in the object hierarchy. 
		/// </summary>
		public HtmlWindow parent;

		/// <summary>
		/// Displays a dialog box that prompts the user with a message and an input field.
		/// </summary>
		/// <param name="message">Optional. String that specifies the message to display in the dialog box. By default, this parameter is set to "".</param>
		/// <param name="defaultValue">Optional. String that specifies the default value of the input field. By default, this parameter is set to "undefined".</param>
		/// <returns>String or Integer. Returns the value typed in by the user.</returns>
		[JsMethod(NativeOverloads = true)]
		public string prompt(string message, string defaultValue)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Displays a dialog box that prompts the user with a message and an input field.
		/// </summary>
		/// <param name="message">Optional. String that specifies the message to display in the dialog box. By default, this parameter is set to "".</param>
		/// <returns>String or Integer. Returns the value typed in by the user.</returns>
		[JsMethod(NativeOverloads = true)]
		public string prompt(string message)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Displays a dialog box that prompts the user with a message and an input field.
		/// </summary>
		/// <returns>String or Integer. Returns the value typed in by the user.</returns>
		[JsMethod(NativeOverloads = true)]
		public string prompt()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Invokes a method after a specified number of milliseconds has elapsed. 
		/// </summary>
		/// <param name="action">a JsFunction to invoke</param>
		/// <param name="ms">Delay, in milliseconds, before invoking the method</param>
		/// <returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int setTimeout(JsFunction action, int ms)
		{
			return 0;
		}

		/// <summary>
		/// Invokes a method after a specified number of milliseconds has elapsed. 
		/// </summary>
		/// <param name="action">a JsFunction to invoke</param>
		/// <param name="ms">Delay, in milliseconds, before invoking the method</param>
		/// <returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int setTimeout(Action action, int ms)
		{
			return 0;
		}

		/// <summary>
		/// Cancels a time-out that was set with the setTimeout method. 
		/// </summary>
		/// <param name="id">Required. Integer that specifies the time-out setting returned by a previous call to the setTimeout method.</param>
		[JsMethod(NativeOverloads = true)]
		public void clearTimeout(int id)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Opens a new window and loads the document specified by a given URL.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlWindow open()
		{
			throw new NotImplementedException("TODO: Implement");
		}
		/// <summary>
		/// Opens a new window and loads the document specified by a given URL.
		/// </summary>
		/// <param name="sURL">
		/// String that specifies the URL of the document to display. 
		/// If no URL is specified, a new window with about:blank is displayed.
		/// </param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlWindow open(string sURL)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		/// <summary>
		/// Opens a new window and loads the document specified by a given URL.
		/// </summary>
		/// <param name="sURL">
		/// String that specifies the URL of the document to display. 
		/// If no URL is specified, a new window with about:blank is displayed.
		/// </param>
		/// <param name="sName">
		/// Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
		/// </param>
		/// <returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlWindow open(string sURL, string sName)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		/// <summary>
		/// Opens a new window and loads the document specified by a given URL.
		/// </summary>
		/// <param name="sURL">
		/// String that specifies the URL of the document to display. 
		/// If no URL is specified, a new window with about:blank is displayed.
		/// </param>
		/// <param name="sName">
		/// Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
		/// </param>
		/// <param name="sFeatures">
		/// Optional. String that contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes"). 
		/// </param>
		/// <returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlWindow open(string sURL, string sName, string sFeatures)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Opens a new window and loads the document specified by a given URL.
		/// </summary>
		/// <param name="sURL">
		/// String that specifies the URL of the document to display. 
		/// If no URL is specified, a new window with about:blank is displayed.
		/// </param>
		/// <param name="sName">
		/// Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
		/// </param>
		/// <param name="sFeatures">
		/// Optional. String that contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes"). 
		/// channelmode = { yes | no | 1 | 0 }Specifies whether to display the window in theater mode. The default is no. Internet Explorer 7. channelmode = { yes | 1 } overrides height, width, top, and left values. When active, the Navigation Bar is hidden and the Title Bar is visible. The Channel Band is no longer supported in Internet Explorer 7. Prior to Internet Explorer 7 channelmode = { yes | 1 } displays the Channel Band in theatre mode. 
		/// directories = { yes | no | 1 | 0 }Specifies whether to add directory buttons. The default is yes. Internet Explorer 7. This feature is no longer supported. 
		/// fullscreen = { yes | no | 1 | 0 }Specifies whether to display the browser in full-screen mode. The default is no. Use full-screen mode carefully. Because this mode hides the browser's title bar and menus, you should always provide a button or other visual clue to help the user close the window. ALT+F4 closes the new window. Internet Explorer 7. A window in full-screen mode does not need to be in theatre mode. Prior to Internet Explorer 7 a window in full-screen mode must also be in theater mode (channelmode).
		/// height = numberInternet Explorer 7. Sets the height of the window in pixels. The minimum value is 150, and specifies the minimum height of the browser content area. Prior to Internet Explorer 7 the minimum height value is 100. 
		/// left = numberSpecifies the left position, in pixels. This value is relative to the upper-left corner of the screen. The value must be greater than or equal to 0. 
		/// location = { yes | no | 1 | 0 }Internet Explorer 7. Specifies whether to display the navigation bar. The default is yes. Prior to Internet Explorer 7 this feature specifies whether to display the address bar. The Back, Forward, and Stop commands are now located in the Navigation bar. Prior to Internet Explorer 7 navigation commands were located in the toolbar.
		/// menubar = { yes | no | 1 | 0 } Specifies whether to display the menu bar. The default is yes. Internet Explorer 7. By default the menu bar is hidden unless revealed by the ALT key. menubar = { no | 0 } prohibits the menubar from appearing even when the Alt key is pressed. The combination of menubar = { no | 0 } and toolbar = { no | 0 } hides the toolbar and disables any additional third-party user interfaces. 
		/// resizable = { yes | no | 1 | 0 }Specifies whether to display resize handles at the corners of the window. The default is yes. Internet Explorer 7. resizable = { no | 0 } disables tabs in a new window.
		/// scrollbars = { yes | no | 1 | 0 }Specifies whether to display horizontal and vertical scroll bars. The default is yes.
		/// status = { yes | no | 1 | 0 }Specifies whether to add a Status Bar at the bottom of the window. The default is yes.
		/// titlebar = { yes | no | 1 | 0 }Specifies whether to display a Title Bar for the window. The default is yes. Internet Explorer 5.5 and later. This feature is no longer supported. The Title Bar remains visible unless the fullscreen sFeature is active. This parameter is ignored prior to Internet Explorer 5.5. It applies only if the calling application is an HTML Application or a trusted dialog box. 
		/// toolbar = { yes | no | 1 | 0 }Internet Explorer 7. Specifies whether to display the browser command bar, making buttons such as Favorites Center, Add to Favorites, and Tools available. The default is yes. The combination of menubar = { no | 0 } and toolbar = { no | 0 } turn off the Toolbar and any additional third-party user interfaces. Prior to Internet Explorer 7 the toolbar sFeature specifies whether to display the browser toolbar, making buttons such as Back, Forward, and Stop available. 
		/// top = numberSpecifies the top position, in pixels. This value is relative to the upper-left corner of the screen. The value must be greater than or equal to 0. 
		/// width = numberInternet Explorer 7. Sets the width of the window in pixels. The minimum value is 250, and specifies the minimum width of the browsers content area. Prior to Internet Explorer 7 the minimum height value is 100. 
		/// </param>
		/// <param name="bReplace">
		/// Optional. Boolean that specifies whether the sURL creates a new entry or replaces the current entry in the window's history list. This parameter only takes effect if the sURL is loaded into the same window. 
		/// </param>
		/// <returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlWindow open(string sURL, string sName, string sFeatures, bool bReplace)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Retrieves whether the referenced window is closed.
		/// </summary>
		public bool closed;

		/// <summary>
		/// Closes the current browser window.
		/// </summary>
		public void close()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Contains information about the current URL. 
		/// </summary>
		public HtmlWindowLocation location;

		/// <summary>
		/// Displays a dialog box containing an application-defined message. 
		/// </summary>
		/// <param name="message">Optional. String that specifies the message to display in the dialog box.</param>
		/// <remarks>You cannot change the title bar of the Alert dialog box.</remarks>
		[JsMethod(NativeOverloads = true)]
		public void alert(object message)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.
		/// </summary>
		/// <param name="message">Optional. String that specifies the message to display in the confirmation dialog box. If no value is provided, the dialog box does not contain a message.</param>
		/// <returns>Boolean. Returns one of the following possible values:
		///	<list type="table">
		///	<item>
		///		<term>true</term>
		///		<description>The user clicked the OK button.</description>
		///	</item>
		///	<item>
		///		<term>false</term>
		///		<description>The user clicked Cancel button.</description>
		/// </item>
		/// </list>
		/// </returns>
		[JsMethod(NativeOverloads = true)]
		public bool confirm(string message)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Provides access to predefined clipboard formats for use in editing operations.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlClipboardData clipboardData
		{
			get
			{
				throw new NotImplementedException("TODO: Implement");
			}
		}

		/// <summary>
		/// Scrolls the window to the specified x- and y-offset. 
		/// </summary>
		/// <param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels.</param>
		/// <param name="y">Required. Integer that specifies the vertical scroll offset, in pixels.</param>
		[JsMethod(NativeOverloads = true)]
		public void scrollTo(double x, double y)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Causes the window to scroll relative to the current scrolled position by the specified x- and y-pixel offset. 
		/// </summary>
		/// <param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels. Positive values scroll the window right, and negative values scroll it left.</param>
		/// <param name="y">Required. Integer that specifies the vertical scroll offset, in pixels. Positive values scroll the window down, and negative values scroll it up.</param>
		[JsMethod(NativeOverloads = true)]
		public void scrollBy(double x, double y)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Causes the element to receive the focus and executes the code specified by the onfocus event. 
		/// </summary>
		public void focus()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Contains information about the client's screen and rendering capabilities.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlScreen screen { get; private set; }

		[JsMethod(NativeOverloads = true)]
		public int setInterval(JsFunction func, int ms)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public int setInterval(Action func, int ms)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public int clearInterval(int ms)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
		/// </summary>
		/// <param name="eventName"></param>
		/// <param name="handler"></param>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public void attachEvent(string eventName, HtmlDomEventHandler handler)
		{
		}

		/// <summary>
		/// Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
		/// </summary>
		/// <param name="eventName"></param>
		/// <param name="handler"></param>
		/// <param name="useCapture"></param>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void addEventListener(string eventName, HtmlDomEventHandler handler, bool useCapture)
		{
		}

		/// <summary>
		/// Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
		/// </summary>
		/// <param name="eventName"></param>
		/// <param name="handler"></param>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public void detachEvent(string eventName, HtmlDomEventHandler handler)
		{
		}

		/// <summary>
		/// Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
		/// </summary>
		/// <param name="eventName"></param>
		/// <param name="handler"></param>
		/// <param name="useCapture"></param>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void removeEventListener(string eventName, HtmlDomEventHandler handler, bool useCapture)
		{
		}

		/// <summary>
		/// Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
		/// </summary>
		/// <param name="el">an element</param>
		/// <param name="pseudoElt">a string specifying the pseudo-element to match. Must be null for regular elements.</param>
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public HtmlElementStyle getComputedStyle(HtmlElement el, string pseudoElt)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
		/// </summary>
		/// <param name="el">an element</param>
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public HtmlElementStyle getComputedStyle(HtmlElement el)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// The dimensions of the viewport (interior of the browser window) 
		/// </summary>
		[JsProperty(NativeField=true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int innerWidth { get; private set; }

		/// <summary>
		/// The dimensions of the viewport (interior of the browser window) 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int innerHeight { get; private set; }

		/// <summary>
		/// The dimensions of the entire browser window (including taskbars and such) 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int outerWidth { get; private set; }

		/// <summary>
		/// The dimensions of the entire browser window (including taskbars and such) 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int outerHeight { get; private set; }

		/// <summary>
		/// The amount of pixels the entire pages has been scrolled 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int pageXOffset { get; private set; }

		/// <summary>
		/// The amount of pixels the entire pages has been scrolled 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int pageYOffset { get; private set; }

		/// <summary>
		/// The position of the browser window on the screen
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.")]
		public int screenX { get; private set; }

		/// <summary>
		/// The position of the browser window on the screen
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.")]
		public int screenY { get; private set; }

		/// <summary>
		/// Fires on the object immediately after its associated document prints or previews for printing.
		/// </summary>		
		public HtmlDomEventHandler onafterprint;

		/// <summary>
		/// Fires on the object before its associated document prints or previews for printing.
		/// </summary>		
		public HtmlDomEventHandler onbeforeprint;

		/// <summary>
		/// Fires prior to a page being unloaded.
		/// </summary>		
		public HtmlDomEventHandler onbeforeunload;
			 
		/// <summary>
		/// Fires when the object loses the input focus.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.
Safari iPhone does not fire the event when the window loses the focus. ",NotSupportedRemark="Konqueror doesn’t support these events on the browser window.")]
		public HtmlDomEventHandler onblur;

		/// <summary>
		/// Fires when an error occurs during object loading.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
		public HtmlDomEventHandler onerror;

		/// <summary>
		/// Fires when the object receives focus.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"Konqueror doesn’t support these events on the browser window.", PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Firefox fires a focus event whenever you click on the document.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.")]
		public HtmlDomEventHandler onfocus;
				
		/// <summary>
		/// Raised when there are changes to the portion of a URL that follows the number sign (#).
		/// </summary>		
		public HtmlDomEventHandler onhashchange;

		/// <summary>
		/// Fires when the user presses the F1 key while the browser is the active window.
		/// </summary>		
		public HtmlDomEventHandler onhelp;

		/// <summary>
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;
					 
		/// <summary>
		/// Fires when the size of the object is about to change.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onresize;

		/// <summary>
		/// Fires when the user repositions the scroll box in the scroll bar on the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari probably monitors scrollTop access in order to determine whether the user has scrolled an element with overflow: auto.")]
		public HtmlDomEventHandler onscroll;

		/// <summary>
		/// Fires immediately before the object is unloaded.
		/// </summary>		
		public HtmlDomEventHandler onunload;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public WindowProxy window
		{
			get;
			private set;
		}
		[JsProperty(NativeField = true)]
		public WindowProxy self
		{
			get;
			private set;
		}
		[JsProperty(NativeField = true)]
		public string name
		{
			get;
			set;
		}

		[JsProperty(NativeField = true)]
		public History history
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public UndoManager undoManager
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public Selection getSelection()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public BarProp locationbar
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public BarProp menubar
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public BarProp personalbar
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public BarProp scrollbars
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public BarProp statusbar
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public BarProp toolbar
		{
			get;
			private set;
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public WindowProxy frames
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong length
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		public WindowProxy this[ulong index]
		{
			get
			{
				throw new NotImplementedException();
			}
			private set
			{
				throw new NotImplementedException();
			}
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public Navigator navigator
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ApplicationCache applicationCache
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void print()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public object showModalDialog(string url, object argument)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void postMessage(object message, string targetOrigin)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void postMessage(object message, MessagePortArray ports, string targetOrigin)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onabort { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler oncanplay { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler oncanplaythrough { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onchange { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onclick { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler oncontextmenu { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondblclick { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondrag { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondragend { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondragenter { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondragleave { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondragover { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondragstart { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondrop { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ondurationchange { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onemptied { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onended { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onformchange { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onforminput { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler oninput { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler oninvalid { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onkeydown { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onkeypress { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onkeyup { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onloadeddata { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onloadedmetadata { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onloadstart { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmessage { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmousedown { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmousemove { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmouseout { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmouseover { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmouseup { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onmousewheel { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onoffline { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ononline { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpause { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onplay { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onplaying { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpagehide { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpageshow { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onpopstate { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onprogress { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onratechange { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onreadystatechange { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onredo { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onseeked { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onseeking { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onselect { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onshow { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onstalled { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onstorage { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onsubmit { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onsuspend { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ontimeupdate { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onundo { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onvolumechange { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onwaiting { get; set; }

		#region NavigatorID Members

		[JsProperty(NativeField = true)]
		public string appVersion
		{
			get { throw new NotImplementedException(); }
		}

		[JsProperty(NativeField = true)]
		public string platform
		{
			get { throw new NotImplementedException(); }
		}

		[JsProperty(NativeField = true)]
		public string userAgent
		{
			get { throw new NotImplementedException(); }
		}

		#endregion

		#region NavigatorOnLine Members
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField=true)]
		public bool onLine
		{
			get { throw new NotImplementedException(); }
		}

		#endregion

		#region NavigatorAbilities Members

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void registerProtocolHandler(string scheme, string url, string title)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void registerContentHandler(string mimeType, string url, string title)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void yieldForStorageUpdates()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region WindowModal Members

		[JsProperty(NativeField = true)]
		public object dialogArguments
		{
			get { throw new NotImplementedException(); }
		}

		[JsProperty(NativeField = true)]
		public string returnValue
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion
	}
}
