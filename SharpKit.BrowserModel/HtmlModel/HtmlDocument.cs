using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using System.Reflection;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents an HTML document
	/// </summary>
	public class HtmlDocument
	{
		/// <summary>
		/// Gets a collection of objects based on the value of the NAME or ID attribute.
		/// </summary>
		/// <param name="sNameValue"></param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5,@"IE5-7 ignores the <p> and custom tags with name='test', but counts the <div> with id='test'
IE8 and Konqueror ignore the custom tag.
Opera counts the <div> with id='test'")]
		public HtmlElementCollection getElementsByName(string sNameValue)
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
		/// Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
		/// </summary>
		/// <param name="eventName"></param>
		/// <param name="handler"></param>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		public void detachEvent(string eventName, HtmlDomEventHandler handler)
		{
		}

		/// <summary>
		/// Retrieves a value that indicates the current state of the object.
		/// uninitializedObject is not initialized with data.
		/// loadingObject is loading its data.
		/// loadedObject has finished loading its data.
		/// interactiveUser can interact with the object even though it is not fully loaded.
		/// completeObject is completely initialized.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string readyState
		{
			get
			{
				throw new NotImplementedException();
			}
		}
		private const string UNIQUE_ID_PREFIX = "cr_";
		//private static int _uniqueIdCounter = 0;

		/// <summary>
		/// Retrieves a collection of HTML Elements and TextNode objects that are descendants of the specified object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlElementCollection all { get; private set; }

		/// <summary>
		/// Gets the object that has the focus when the parent document has focus.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlElement activeElement { get; private set; }
		/// <summary>
		/// Gets or sets the HtmlWindow object that contains this HtmlDocument
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlWindow parentWindow { get; private set; }

		/// <summary>
		/// Returns the root node for this HtmlDocument
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlDocumentElement documentElement { get; internal set; }

		[JsMethod(NativeOverloads = true)]
		public void appendChild(HtmlElement child)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new TextNode
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlTextNode createTextNode(string text)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new HtmlElement
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement createElement(string name)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new HtmlElement
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public T createElement<T>(string name) where T:HtmlElement
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Retrieves a collection of objects based on the specified element name.
		/// </summary>
		/// <param name="sTagName">String that specifies the name of an element.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"The * argument, which ought to select all elements in the document, doesn't work in IE 5.5. 
Custom tags are not returned in Konqueror.")]
		public HtmlElementCollection getElementsByTagName(string sTagName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new Stylesheet node
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlStyleElement createStyleSheet()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new Stylesheet node
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlStyleElement createStyleSheet(string url)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new Stylesheet node
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public HtmlStyleElement createStyleSheet(int index)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new Stylesheet node.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public HtmlStyleElement createStyleSheet(string url, int index)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the HtmlSelection object of this HtmlDocument
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlSelection selection
		{
			get
			{
				throw new NotImplementedException("TODO: Implement");
			}
		}

		/// <summary>
		/// Gets the HtmlBody root element of this HtmlDocument
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlBody body { get; set; }

		/// <summary>
		/// Gets the title of this HtmlDocument
		/// </summary>
		[JsProperty(NativeField = true)]
		public string title { get; set; }

		public void open()
		{
			throw new NotImplementedException();
		}

		public void close()
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public void write(string p)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
		/// </summary>
		/// <param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement getElementById(string sIDValue)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
		/// </summary>
		/// <param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>		
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public T getElementById<T>(string sIDValue) where T : HtmlElement
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new document.
		/// </summary>
		/// <returns>Returns the newly created document.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDocumentFragment createDocumentFragment()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Generates an event object to pass event context information when you use the fireEvent method.
		/// </summary>
		/// <returns>Returns an event object.</returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlDomEventArgs createEventObject()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Generates an event object to pass event context information when you use the fireEvent method.
		/// </summary>
		/// <param name="existingEvent">A object that specifies an existing event object on which to base the new object. </param>
		/// <returns>Returns an event object.</returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlDomEventArgs createEventObject(HtmlDomEventArgs existingEvent)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Sets or gets the string value of a cookie.
		/// </summary>
		[JsProperty(NativeField=true)]
		public string cookie { get; set; }

		/// <summary>
		/// Gets a value that indicates whether standards-compliant mode is switched on for the object.
		/// </summary>
		/// <remarks>
		/// Possible Values
		/// BackCompat - Standards-compliant mode is not switched on.
		/// CSS1Compat Standards-compliant mode is switched on.
		/// </remarks>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE 5.5 doesn't support this property, but it doesn't need to. It's permanently locked in Quirks Mode.")]
		public string compatMode { get; private set; }

		/// <summary>
		/// Returns a reference to the default AbstractView for the document, or null if none available
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsProperty(NativeField=true)]
		public HtmlDocument defaultView { get; private set; }


		/// <summary>
		/// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		[JsProperty(NativeField = true)]
		public HtmlNodeCollection<HtmlStyleElement> styleSheets { get; set; }





		/****************** Not supported on IE ******************/
		[SupportedBrowsers(BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		[JsMethod(NativeOverloads = true)]
		public HtmlElementCollection getElementsByClassName(string sClassName)
		{
		  throw new NotImplementedException();
		}

		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera10)]
		[JsMethod(NativeOverloads=true)]
		public HtmlElementCollection querySelectorAll(string selector)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the element for the specified x coordinate and the specified y coordinate.
		/// </summary>
		/// <param name="iX">A Integer that specifies the X-offset, in pixels.</param>
		/// <param name="iY">A Integer that specifies the Y-offset, in pixels.</param>
		/// <returns>Returns an element object.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"IE and Firefox need clientX/Y, while Opera, Chrome and Safari need pageX/Y. Opera 9 reports a text node whenever possible, while this method should report the containing element node.")]		
		public HtmlElement elementFromPoint(int iX, int iY)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlWindowLocation location
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string URL
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string domain
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string referrer
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string lastModified
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string charset
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string characterSet
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string defaultCharset
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string dir
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlHead head
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection images
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection embeds
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection plugins
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection links
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection forms
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection scripts
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public NodeList getItems(string typeNames)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		public object this[string name]
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
		public string innerHTML
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void writeln(params string[] text)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public Selection getSelection()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool hasFocus()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string designMode
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool execCommand(string commandId)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool execCommand(string commandId, bool showUI)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool execCommand(string commandId, bool showUI, string value)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool queryCommandEnabled(string commandId)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool queryCommandIndeterm(string commandId)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool queryCommandState(string commandId)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool queryCommandSupported(string commandId)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public string queryCommandValue(string commandId)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection commands
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onabort { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onblur { get; set; }
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
		public HtmlDomEventHandler onerror { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onfocus { get; set; }
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
		public HtmlDomEventHandler onload { get; set; }
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
		public HtmlDomEventHandler onpause { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onplay { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onplaying { get; set; }
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
		public HtmlDomEventHandler onscroll { get; set; }
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
		public HtmlDomEventHandler onsubmit { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onsuspend { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler ontimeupdate { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onvolumechange { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlDomEventHandler onwaiting { get; set; }
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string fgColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string bgColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string linkColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string vlinkColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string alinkColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection anchors
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection applets
		{
			get;
			private set;
		}

		/// <summary>
		/// Creates a new comment node, and returns it.
		/// </summary>
		/// <param name="data">a string containing the data to be added to the Comment.</param>
		public HtmlNode createComment(string data)
		{
			throw new NotImplementedException();
		}
	}
}
