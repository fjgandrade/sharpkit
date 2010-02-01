using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	public delegate void HtmlDomEventHandler(HtmlDomEventArgs e);

	/// <summary>
	/// Represents the state of an event, such as the element in which the event occurred, the state of the keyboard keys, the location of the mouse, and the state of the mouse buttons. 
	/// </summary>
	public class HtmlDomEventArgs
	{
		protected HtmlDomEventArgs()
		{
		}
		/// <summary>
		/// Sets or retrieves the Unicode key code associated with the key that caused the event. 
		/// </summary>
		public int keyCode;

		/// <summary>
		/// Sets or retrieves the x-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use clientX/clientY")]
		public int x { get; set; }

		/// <summary>
		/// Sets or retrieves the y-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use clientX/clientY")]
		public int y { get; set; }

		/// <summary>
		/// Sets or retrieves the state of the SHIFT key. 
		/// </summary>
		public bool shiftKey;

		/// <summary>
		/// Sets or retrieves the state of the CTRL key. 
		/// </summary>
		public bool ctrlKey;

		/// <summary>
		/// Sets or retrieves the name of the property that changes on the object.
		/// </summary>
		public string propertyName;

		/// <summary>
		/// Sets or retrieves the x-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int clientX { get; set; }

		/// <summary>
		/// Sets or retrieves the y-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int clientY { get; set; }

		/// <summary>
		/// Returns the horizontal coordinate of the event relative to whole document.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int pageX { get; set; }

		/// <summary>
		/// Returns the vertical coordinate of the event relative to the whole document.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int pageY { get; set; }

		/// <summary>
		/// Sets or retrieves the x-coordinate of the mouse pointer's position relative to the object firing the event. 
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsProperty(NativeField = true)]
		public int offsetX { get; set; }

		/// <summary>
		/// Sets or retrieves the y-coordinate of the mouse pointer's position relative to the object firing the event. 
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9, @"In IE the coordinates are calculated relative to the target element when that element is eligible to become an offsetParent. If that's not the case, the coordinates are calculated relative to the target's offsetParent.
Bug: When the element found by this rule has position: relative, IE moves on to the next offsetParent for the calculation of offsetY, but not of offsetX.")]
		[JsProperty(NativeField = true)]
		public int offsetY { get; set; }

		/// <summary>
		/// Sets or retrieves the object that fired the event. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlElement srcElement { get; set; }

		/// <summary>
		/// Sets or retrieves the return value from the event. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public object returnValue { get; set; }

		/// <summary>
		/// Sets or retrieves whether the current event should bubble up the hierarchy of event handlers. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool cancelBubble { get; set; }

		/// <summary>
		/// Sets or retrieves the event name from the event object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string type { get; set; }

		/// <summary>
		/// Sets or retrieves the mouse button pressed by the user. 
		/// Values:
		/// <list type="table">
		///		<listheader>
		///			<term>Value</term>	
		///			<description>Description</description>
		///		</listheader>
		///		<item>
		///			<term>0</term>	
		///			<description>Default. No button is pressed.</description>
		///		</item>
		///		<item>
		///			<term>1</term>	
		///			<description>Left button is pressed. </description>
		///		</item>
		///		<item>
		///			<term>2</term>	
		///			<description>Right button is pressed. </description>
		///		</item>
		///		<item>
		///			<term>3</term>	
		///			<description>Left and right buttons are both pressed. </description>
		///		</item>
		///		<item>
		///			<term>4</term>	
		///			<description>Middle button is pressed. </description>
		///		</item>
		///		<item>
		///			<term>5</term>	
		///			<description>Left and middle buttons both are pressed. </description>
		///		</item>
		///		<item>
		///			<term>6</term>	
		///			<description>Right and middle buttons are both pressed. </description>
		///		</item>
		///		<item>
		///			<term>7</term>	
		///			<description>All three buttons are pressed. </description>
		///		</item>
		/// </list>
		/// </summary>
		[JsProperty(NativeField = true)]
		public int button { get; set; }

		/// <summary>
		/// Sets or retrieves a value that indicates the state of the ALT key. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool altKey { get; set; }

		/// <summary>
		/// Retrieves the state of the left CTRL key. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool ctrlLeft { get; set; }

		/// <summary>
		/// Retrieves the state of the right CTRL key. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool ctrlRight { get; set; }

		/// <summary>
		/// Retrieves the state of the left SHIFT key. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool shiftLeft { get; set; }

		/// <summary>
		/// Retrieves the state of the right SHIFT key. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool shiftRight { get; set; }

		/// <summary>
		/// Retrieves whether the onkeydown event is being repeated. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool repeat { get; set; }

		/// <summary>
		/// Sets or retrieves the x-coordinate of the mouse pointer's position relative to the user's screen. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int screenX { get; set; }

		/// <summary>
		/// Sets or retrieves the y-coordinate of the mouse pointer's position relative to the user's screen. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int screenY { get; set; }

		/// <summary>
		/// Retrieves the distance and direction the wheel button has rolled. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int wheelDelta { get; set; }









		////////////////////////////// Drag event

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public DataTransfer dataTransfer { get; private set; }


		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void initDragEvent(string typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, long detailArg, long screenXArg, long screenYArg, long clientXArg, long clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, ushort buttonArg, EventTarget relatedTargetArg, DataTransfer dataTransferArg)
		{
			throw new NotImplementedException();
		}

		/////////////////////// Undo event 

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public object data { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void initUndoManagerEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object dataArg)
		{
			throw new NotImplementedException();
		}

		//////////////////////// Message event
		//[HtmlSpecificationVersion(5)]
		//[JsProperty(NativeField = true)]
		//public object data { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string origin { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string lastEventId { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public WindowProxy source { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public MessagePortArray ports { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public void initMessageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object dataArg, string originArg, string lastEventIdArg, WindowProxy sourceArg, MessagePortArray portsArg)
		{
			throw new NotImplementedException();
		}

		/////////////////////////// PopState

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public object state { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public void initPopStateEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object stateArg)
		{
			throw new NotImplementedException();
		}


		////////////////////////// Storage

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string key { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public object oldValue { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public object newValue { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string url { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public Storage storageArea { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public void initStorageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string keyArg, object oldValueArg, object newValueArg, string urlArg, Storage storageAreaArg)
		{
			throw new NotImplementedException();
		}

		///////////////////////// Web Workers

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string message { get; private set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string filename { get; private set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong lineno { get; private set; }

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public void initErrorEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string messageArg, string filenameArg, ulong linenoArg)
		{
			throw new NotImplementedException();
		}

	}
}
