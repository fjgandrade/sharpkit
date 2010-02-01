using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using System.Collections;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/*
	ACCESSKEY	accessKey	 Sets or retrieves the access key for the object.
	canHaveHTML	canHaveHTML	 Retrieves the value indicating whether the object can contain rich HTML markup.
	HIDEFOCUS	hideFocus	 Sets or gets the value that indicates whether the object visibly shows that it has focus.
						isContentEditable	 Gets the value that indicates whether the user can edit the contents of the object.
						isDisabled	 Gets the value that indicates whether the user can interact with the object.
						isMultiLine	 Retrieves the value indicating whether the content of the object contains one or more lines.
						isTextEdit	 Retrieves whether a TextRange object can be created using the object.

	*/
	/*
	 LANGUAGE	language Sets or retrieves the language in which the current script is written.	 
						nextSibling	 Retrieves a reference to the next child of the parent for the object.
						nodeValue	 Sets or retrieves the value of a node.
						ownerDocument	 Retrieves the document object associated with the node.
						parentTextEdit	 Retrieves the container object in the document hierarchy that can be used to create a TextRange containing the original object.
						previousSibling	 Retrieves a reference to the previous child of the parent for the object.
						readyState	 Retrieves a value that indicates the current state of the object.
						recordNumber	 Retrieves the ordinal record from the data set that generated the object.
	 */

	/*
		role	role	 Sets or retrieves the role for this element.
		scopeName	 Gets the namespace defined for the element.
	*/



	/// <summary>
	/// Retrieves the type of the requested node.
	/// </summary>
	public class HtmlElement : HtmlNode
	{

		protected HtmlElement()
		{
			nodeType = 1;
		}


		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, "IE incorrectly counts comment nodes, too.")]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection children
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		//[JsMethod(UseNativeOverloads = true)]
		//public HtmlNode replaceChild(HtmlNode newNode, HtmlNode childNode)
		//{
		//  throw new NotImplementedException();
		//}

		/// <summary>
		/// Removes the given attribute from the object.
		/// </summary>
		/// <param name="attName">String that specifies the attribute name. </param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, @"IE5-7 and Opera don't remove event handlers.
Konqueror doesn't remove the align attribute.")]
		public void removeAttribute(string attName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes the given attribute from the object.
		/// </summary>
		/// <param name="attName">String that specifies the attribute name. </param>
		/// <param name="caseSensitive"> Integer that specifies whether to use a case-sensitive search to locate the attribute. By default, this value is set to 1 to indicate that the uppercase and lowercase letters in the specified sName parameter must exactly match those in the attribute name. If there are multiple attributes specified with different case sensitivity, the attribute returned might vary across platforms. </param>
		[JsMethod(NativeOverloads = true)]
		public void removeAttribute(string attName, int caseSensitive)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Inserts the given HTML text into the element at the location
		/// </summary>
		/// <param name="where">
		/// String that specifies where to insert the HTML text, using one of the following values: 
		/// beforeBegin Inserts sText immediately before the object. 
		/// afterBegin Inserts sText after the start of the object but before all other content in the object. 
		/// beforeEnd Inserts sText immediately before the end of the object but after all other content in the object. 
		/// afterEnd Inserts sText immediately after the end of the object. 
		/// </param>
		/// <param name="html">String that specifies the HTML text to insert. The string can be a combination of text and HTML tags. This must be well-formed, valid HTML or this method will fail. </param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9,
			NotSupportedRemark="Use innerHTML and insertBefore()")]
		public void insertAdjacentHTML(string where, string html)
		{
			throw new NotImplementedException();// TODO: write
		}



		/// <summary>
		/// Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
		/// </summary>
		/// <param name="eventName"></param>
		/// <param name="handler"></param>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
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
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
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
		/// Fires a specified event on the object.
		/// </summary>
		/// <param name="sEvent">String that specifies the name of the event to fire.</param>
		/// <param name="oEventObject">Object that specifies the event object from which to obtain event object properties.</param>
		[JsMethod(NativeOverloads = true)]
		public void fireEvent(string sEvent, HtmlDomEventArgs oEventObject)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Fires a specified event on the object.
		/// </summary>
		/// <param name="sEvent">String that specifies the name of the event to fire.</param>
		[JsMethod(NativeOverloads = true)]
		public void fireEvent(string sEvent)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Retrieves a collection of rectangles that describes the layout of the contents of an object or range within the client. Each rectangle describes a single line. 
		/// </summary>
		/// <returns>Returns the TextRectangle collection. Each rectangle has four integer properties (top, left, right, and bottom) that each represent a coordinate of the rectangle, in pixels.</returns>
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE5-7 returns far too many rectangles for the first test paragraphs. The correct number is 5 (for 5 lines), but IE5.5 returns 9 and IE6/7 14. IE8b2 gets this right.
Furthermore, IE5-7 also split up a block-level element such as a <p> into one rectangle per line. This is incorrect: a block-level element should be reported as one rectangle.
Finally, in IE 5-7 the rectangles are off by about two pixels.", PartiallySupportedRemark = @"Firefox doesn't round the top/bottom coordinates.")]
		public HtmlTextRectangleCollection getClientRects()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Specifies that an element cannot be selected.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string unselectable { get; set; }

		/// <summary>
		/// Sets or retrieves the string identifying the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public string id { get; set; }


		/// <summary>
		/// Retrieves an autogenerated, unique identifier for the object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string uniqueID { get; set; }

		/// <summary>
		/// Sets or retrieves the string that indicates whether the user can edit the content of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string contentEditable { get; set; }

		/// <summary>
		/// Retrieves a reference to the last child in the childNodes collection of an object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
		public HtmlNode lastChild { get; set; }


		/// <summary>
		/// Retrieves a reference to the container object that defines the offsetTop and offsetLeft properties of the object.
		/// </summary>
		[JsProperty(NativeField=true)]
		public HtmlElement offsetParent { get; private set; }

		/// <summary>
		/// Sets or retrieves the distance between the left edge of the object and the leftmost portion of the content currently visible in the window. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int scrollLeft { get; set; }

		/// <summary>
		/// Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int scrollTop { get; set; }
		/// <summary>
		/// Retrieves the calculated left position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int offsetLeft { get; set; }

		/// <summary>
		/// Retrieves the calculated top position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"When calculating offsetTop, IE5-7 does not count elements with position: relative as offsetParents, and moves on to the next offsetParent in the chain. offsetLeft is calculated correctly.")]
		public int offsetTop { get; set; }

		/// <summary>
		/// Retrieves the width of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int offsetWidth { get; set; }

		/// <summary>
		/// Retrieves the height of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
		/// </summary>
		/// <remarks>When overflowY is Scroll, this is the physical height of the control, which is clientHeight + Vscrollbar size</remarks>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int offsetHeight { get; set; }

		/// <summary>
		/// Retrieves the distance between the offsetTop property and the true top of the client area.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public int clientTop { get; set; }
		/// <summary>
		/// Retrieves the distance between the offsetLeft property and the true left side of the client area.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public int clientLeft { get; set; }
		/// <summary>
		/// Retrieves the width of the object including padding, but not including margin, border, or scroll bar.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int clientWidth { get; set; }

		/// <summary>
		/// Retrieves the height of the object including padding, but not including margin, border, or scroll bar.
		/// </summary>
		/// <remarks>When overflowY is Scroll, this is the physical displayed height of the children w/o the scrollbar</remarks>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int clientHeight { get; set; }

		/// <summary>
		/// Retrieves the scrolling width of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"When the element has no scrollbars IE makes the scrollHeight equal to the actual height of the content; and not the height of the element. scrollWidth is correct, except in IE8, where it’s 5 pixels off.
Opera gives odd, incorrect values.")]
		public int scrollWidth { get; set; }

		/// <summary>
		/// Gets the namespace defined for the element.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string scopeName { get; set; }

		/// <summary>
		/// Retrieves the ordinal position of the object, in source order, as the object appears in the document's all collection.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int sourceIndex { get; set; }

		/// <summary>
		/// Retrieves the scrolling height of the object. 
		/// </summary>
		/// <remarks>When overflowY is Scroll, this is the virtual height of the scrollable region (without scrolling, this would be the physical height of the element)</remarks>
		[JsProperty(NativeField = true)]
		public int scrollHeight { get; set; }
		/// <summary>
		/// Retrieves the document object associated with the node.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlDocument document { get; internal set; }

		/// <summary>
		/// Retrieves a collection of HTML Elements and TextNode objects that are direct descendants of the specified object.
		/// </summary>		
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
		public HtmlNodeCollection childNodes { get; private set; }



		/// <summary>
		/// Sets or retrieves advisory information (a ToolTip) for the object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Safari 3.0 does’t show the title of an element in any way, so its compatibility is mostly untestable. However, the title property gets its value from the title attribute, so it works to some extent.")]
		public string title { get; set; }


		/// <summary>
		/// Sets or retrieves the HTML between the start and end tags of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"In IE and Konqueror innerHTML does not work correctly when you update tables. Solve this by using pure DOM methods instead. 
If you remove elements through innerHTML in IE, their content is wiped and only the element itself (i.e. opening and closing tags) remain. If you want to remove nodes that you may want to reinsert at a later time, use DOM methods such as removeChild().")]
		public string innerHTML { get; set; }

		/// <summary>
		/// Sets or retrieves the text between the start and end tags of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, 
@"Use document.createTextNode() and appendChild() in any browser, or textContent in FireFox")]
		public string innerText { get; set; }

		/// <summary>
		/// Sets or retrieves the text between the start and end tags of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57,@"Use innerText in IE")]
		public string textContent { get; set; }

		/// <summary>
		/// Sets or retrieves the index that defines the tab order for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int tabIndex { get; set; }

		/// <summary>
		/// Sets or gets the Uniform Resource Name (URN) specified in the namespace declaration.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string tagUrn { get; set; }


		/// <summary>
		/// Sets an inline style for the element.
		/// </summary>		
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElementStyle style { get; set; }

		/// <summary>
		/// Returns the current (calculated) style of the element
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"Use getComputedStyle()")]
		public HtmlElementStyle currentStyle { get; set; }


		[JsProperty(NativeIndexer = true)]
		public object this[string name]
		{
			get { throw new NotImplementedException(); }
			set { }
		}

		/// <summary>
		/// Sets or retrieves the class of the object.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsProperty(NativeField = true)]
		public string className { get; set; }

		/// <summary>
		/// Sets or retrieves a value that indicates whether the user can interact with the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool disabled { get; set; }
		/// <summary>
		/// Sets or retrieves a value that indicates the reading order of the object.
		/// Possible values:
		/// ltr		Default. Content flows from left to right.
		/// rtl		Content flows from right to left.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"If the last character on a line is an interpunction character, IE, Safari, Chrome and Konqueror move it to the start of the line.")]
		public string dir { get; set; }

		/// <summary>
		/// Sets or retrieves the language to use.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string lang { get; set; }

		/// <summary>
		/// Retrieves the tag name of the object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"In IE (all versions) the tagName of a comment node is !. 
Use nodeName instead.")]
		public string tagName { get; private set; }

		/// <summary>
		/// Retrieves the parent object in the document hierarchy.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use parentNode")]
		public HtmlElement parentElement { get; private set; }

		/// <summary>
		/// Appends an element as a child to the object.
		/// </summary>
		/// <param name="child"></param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void appendChild(HtmlNode child)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes a child node from the object.
		/// </summary>
		/// <param name="oNode">Object that specifies the element to be removed from the document.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void removeChild(HtmlNode oNode)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the mouse capture to the object that belongs to the current document. 
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public void setCapture()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the mouse capture to the object that belongs to the current document. 
		/// </summary>
		/// <param name="containerCapture">A Boolean that specifies one of the following values. true Default. Events originating in a container are captured by the container. 
		///false Events originating in a container are not captured by the container 
		///</param>
		[JsMethod(NativeOverloads = true)]
		public void setCapture(bool containerCapture)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes mouse capture from the object in the current document.
		/// </summary>
		public void releaseCapture()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Inserts an element at the specified location.
		/// </summary>
		/// <param name="sWhere">A String that specifies where to insert the HTML element, using one of the following values. 
		///		<list type="table">
		///		<item><term>beforeBegin</term><description>Inserts oElement immediately before the object.</description></item>
		///		<item><term>afterBegin</term><description></description>Inserts oElement after the start of the object, but before all other content in the object.</item>
		///		<item><term>beforeEnd</term><description>Inserts oElement immediately before the end of the object, but after all other content in the object.</description></item>
		///		<item><term>afterEnd</term><description>Inserts oElement immediately after the end of the object.</description></item>
		///		</list>
		/// </param>
		/// <param name="oElement">Object that specifies the element to be inserted adjacent to the object that invoked the insertAdjacentElement method.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9,
			NotSupportedRemark="Use insertBefore() or appendChild()")]
		public void insertAdjacentElement(string sWhere, HtmlElement oElement)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void insertBefore(HtmlNode newNode)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public void insertBefore(HtmlNode newNode, HtmlNode child)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves a reference to the first child in the childNodes collection of the object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
		public HtmlNode firstChild
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Sets or retrieves the text of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public string outerText { get; set; }


		/// <summary>
		/// Sets or retrieves the object and its content in HTML.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		[JsProperty(NativeField=true)]
		public string outerHTML { get; set; }

		/// <summary>
		/// Inserts the given text into the element at the specified location.
		/// </summary>
		/// <param name="sWhere">A String that specifies where to insert the HTML element, using one of the following values. 
		///		<list type="table">
		///		<item><term>beforeBegin</term><description>Inserts oElement immediately before the object.</description></item>
		///		<item><term>afterBegin</term><description></description>Inserts oElement after the start of the object, but before all other content in the object.</item>
		///		<item><term>beforeEnd</term><description>Inserts oElement immediately before the end of the object, but after all other content in the object.</description></item>
		///		<item><term>afterEnd</term><description>Inserts oElement immediately after the end of the object.</description></item>
		///		</list>
		/// </param>
		/// <param name="sText">String that specifies the text to insert.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9,
			NotSupportedRemark="Use document.createTextNode() and insertBefore()")]
		public void insertAdjacentText(string sWhere, string sText)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes the object from the document hierarchy.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public void removeNode()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes the object from the document hierarchy.
		/// </summary>
		/// <param name="bRemoveChildren">A Boolean that specifies one of the following values. </param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public void removeNode(bool bRemoveChildren)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Causes the element to lose focus and fires the onblur event.
		/// </summary>
		public void blur()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves a collection of attributes of the object.
		/// </summary>
		[JsProperty(NativeField = true)]		
		public HtmlAttributeCollection attributes { get; private set; }

		/// <summary>
		/// Sets the value of the specified attribute 
		/// </summary>
		/// <param name="name">String that specifies the name of the attribute.</param>
		/// <param name="value">Variant that specifies the string, number, or Boolean to assign to the attribute.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE5-7 doesn't set styles and removes events when you try to set them.")]
		public void setAttribute(string name, object value)
		{
		}

		/// <summary>
		/// Copies a reference to the object from the document hierarchy. 
		/// </summary>
		/// <param name="includeChildren">Boolean that specifies one of the following values:
		/// FALSE Cloned objects do not include childNodes. 
		/// TRUE Cloned objects include childNodes. </param>
		/// <returns>Returns a reference to the newly created node.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement cloneNode(bool includeChildren)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Copies a reference to the object from the document hierarchy. 
		/// </summary>
		/// <returns>Returns a reference to the newly created node.</returns>
		[JsMethod(NativeOverloads = true)]
		public HtmlElement cloneNode()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Causes the element to receive the focus and executes the code specified by the onfocus event. 
		/// </summary>
		public void focus()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Causes the object to scroll into view, aligning it either at the top or bottom of the window. 
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public void scrollIntoView()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Causes the object to scroll into view, aligning it either at the top or bottom of the window. 
		/// </summary>
		/// <param name="alignToTop">Boolean that specifies one of the following values: 
		/// true Default. Scrolls the object so that top of the object is visible at the top of the window. 
		/// false Scrolls the object so that the bottom of the object is visible at the bottom of the window </param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari iPhone handles the Y-coordinate correctly, but it also scrolls to the left edge of the page, which can make this method hard to use when the user has zoomed in.")]
		public void scrollIntoView(bool alignToTop)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the object as active without setting focus to the object.
		/// </summary>
		public void setActive()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Puts the specified node and all of its subtree into a "normalized" form. In a normalized subtree, no text nodes in the subtree are empty and there are no adjacent text nodes.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void normalize()
		{
		}

		/// <summary>
		/// Creates an attribute object with a specified name.
		/// </summary>
		/// <param name="sName">A String that sets the attribute object's name.</param>
		[JsMethod(NativeOverloads=true)]
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlAttribute createAttribute(string sName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets an attribute object node as part of the object.
		/// </summary>
		/// <param name="oSrcAttribute">attribute object to be assigned.</param>
		/// <returns>
		/// Returns a reference to the removed attribute object.
		/// </returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, "IE6-7 gives null for style values.")]
		public HtmlAttribute setAttributeNode(HtmlAttribute oSrcAttribute)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves the value of the specified attribute.
		/// </summary>
		/// <param name="sAttrName">String that specifies the name of the attribute.</param>
		/// <param name="iFlags">Integer that specifies one or more of the following flags:
		/// 0 - Default. Performs a property search that is not case-sensitive, and returns an interpolated value if the property is found.
		/// 1 - Performs a case-sensitive property search. To find a match, the uppercase and lowercase letters in sAttrName must exactly match those in the attribute name.
		/// 2 - Returns attribute value as a String. This flag does not work for event properties.
		/// 4 - Returns attribute value as a fully expanded URL. Only works for URL attributes.</param>
		/// <returns>Variant that returns a String, Integer, or Boolean value as defined by the attribute. If the attribute is not present, this method returns null.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"In IE5-7, accessing the style attribute gives an object, and accessing the onclick attribute gives an anonymous function wrapped around the actual content.")]
		public object getAttribute(string sAttrName, int iFlags)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves the value of the specified attribute.
		/// </summary>
		/// <param name="sAttrName">String that specifies the name of the attribute.</param>
		/// <returns>Variant that returns a String, Integer, or Boolean value as defined by the attribute. If the attribute is not present, this method returns null.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"In IE5-7, accessing the style attribute gives an object, and accessing the onclick attribute gives an anonymous function wrapped around the actual content.")]
		public object getAttribute(string sAttrName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves an attribute object referenced by the attribute.name property.
		/// </summary>
		/// <param name="sName">String that specifies the name property of the requested attribute object.</param>
		/// <returns>Returns a reference to an attribute object.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE 6/7 don't allow you to access the value of x.getAttributeNode('style').")]
		public HtmlAttribute getAttributeNode(string sName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Determines whether an attribute with the specified name exists.
		/// </summary>
		/// <param name="sAttrName">String that specifies the name of the attribute.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public bool hasAttribute(string sAttrName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// returns a boolean value of true or false, indicating if the current element has any attributes or not.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public bool hasAttributes()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes an attribute object from the object.
		/// </summary>
		/// <param name="oSrcAttribute">attribute object to be removed.</param>
		/// <remarks>Returns a reference to the removed attribute object.</remarks>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE 6 does't remove anything, but doesn't give an error message either.
IE 7 doesn't remove styles and event handlers.
Opera doesn't remove event handlers.
Konqueror doesn't remove the align attribute.")]
		public HtmlAttribute removeAttributeNode(string oSrcAttribute)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Makes the element either a child or parent of another element.
		/// </summary>
		/// <param name="oNewElement">An object that becomes the child or parent of the current element.</param>
		/// <param name="oWhere">A String that specifies one of the following values.
		/// outside - Default. Specified element becomes a parent of the current element.
		/// inside - Specified element becomes a child of the current element, but contains all the child elements of the current element.
		/// </param>
		/// <returns>Returns a reference to the applied element.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlElement applyElement(HtmlElement oNewElement, string oWhere)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Makes the element either a child or parent of another element.
		/// </summary>
		/// <param name="oNewElement">An object that becomes the child or parent of the current element.</param>
		/// <returns>Returns a reference to the applied element.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlElement applyElement(HtmlElement oNewElement)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes all attributes and values from the object.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.None, NotSupportedRemark = @"IE doesn't clear event handlers and inline styles.")]
		public void clearAttributes()
		{
		}

		/// <summary>
		/// Copies all read/write attributes to the specified element.
		/// </summary>
		/// <param name="oSource">Pointer to an Object that specifies the attributes copied to the object that invokes mergeAttributes.</param>
		/// <param name="bPreserve">Available as of Microsoft Internet Explorer 5.5. Pointer to a Boolean that specifies one of the following values:
		/// true - Default. Preserve the identity of the object to which attributes are being merged.
		/// false - Do not preserve the identity of the object to which attributes are being merged.
		/// </param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public void mergeAttributes(string oSource, bool bPreserve)
		{
		}

		/// <summary>
		/// Copies all read/write attributes to the specified element.
		/// </summary>
		/// <param name="oSource">Pointer to an Object that specifies the attributes copied to the object that invokes mergeAttributes.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public void mergeAttributes(string oSource)
		{
		}

		/// <summary>
		/// Replaces the object with another element.
		/// </summary>
		/// <param name="oNewNode">An Object that specifies the new element to replace the object.</param>
		/// <returns>Returns a reference to the object that is replaced.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlNode replaceNode(HtmlNode oNewNode)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Exchanges the location of two objects in the document hierarchy.
		/// </summary>
		/// <param name="oNode">Object that specifies the existing element.</param>
		/// <returns>Returns a reference to the object that invoked the method.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlNode swapNode(HtmlNode oNode)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the number of element children
		/// </summary>
		[JsProperty(NativeField=true)]
		[SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public int childElementCount { get; private set; }

		/// <summary>
		/// Returns the first child that is an element node
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement firstElementChild { get; private set; }

		/// <summary>
		/// Returns the last child that is an element node
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement lastElementChild { get; private set; }

		/// <summary>
		/// Returns the next element node sibling
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement nextElementSibling { get; private set; }

		/// <summary>
		/// Returns the previous  element node sibling
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement previousElementSibling { get; private set; }

		/// <summary>
		/// Returns an object that contains the top, left, right, and bottom (all relative to the top left of the viewport) of the combined rectangle of element x. Essentially, the browser calculates all rectangles (see below getClientRects()), and getBoundingClientRect() returns the lowest (top, left) or highest (bottom, right) values found.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads=true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark="Firefox doesn't round the top/bottom coordinates.")]
		public HtmlTextRectangle getBoundingClientRect()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Fires on a databound object after successfully updating the associated data in the data source object.
		/// </summary>		
		public HtmlDomEventHandler onafterupdate;

		/// <summary>
		/// Fires immediately before the object is set as the active element.
		/// </summary>		
		public HtmlDomEventHandler onbeforeactivate;
	 
		

		/// <summary>
		/// Fires immediately before the activeElement is changed from the current object to another object in the parent document.
		/// </summary>		
		public HtmlDomEventHandler onbeforedeactivate;
		 
		/// <summary>
		/// Fires before an object contained in an editable element enters a UI-activated state or when an editable container object is control selected.
		/// </summary>		
		public HtmlDomEventHandler onbeforeeditfocus;


		/// <summary>
		/// Fires on a databound object before updating the associated data in the data source object.
		/// </summary>		
		public HtmlDomEventHandler onbeforeupdate;
	 
		/// <summary>
		/// Fires when the object loses the input focus.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.
Safari iPhone does not fire the event when the window loses the focus. ")]
		public HtmlDomEventHandler onblur;

		/// <summary>
		/// Fires when data changes in the data provider.
		/// </summary>		
		public HtmlDomEventHandler oncellchange;

		/// <summary>
		/// Fires when the user clicks the left mouse button on the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onclick;

		/// <summary>
		/// Fires when the user clicks the right mouse button in the client area, opening the context menu.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"To prevent the default in Firefox 3 you have to cancel the event bubbling.")]
		public HtmlDomEventHandler oncontextmenu;

		/// <summary>
		/// Fires when the user is about to make a control selection of the object.
		/// </summary>		
		public HtmlDomEventHandler oncontrolselect;

		/// <summary>
		/// Fires on the source element when the user copies the object or selection, adding it to the system clipboard.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"Firefox 3 has a lazy implementation.")]
		public HtmlDomEventHandler oncopy;
			 
		/// <summary>
		/// Fires on the source element when the object or selection is removed from the document and added to the system clipboard.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"Firefox 3 has a lazy implementation.")]
		public HtmlDomEventHandler oncut;

		/// <summary>
		/// Fires periodically as data arrives from data source objects that asynchronously transmit their data.
		/// </summary>		
		public HtmlDomEventHandler ondataavailable;

		/// <summary>
		/// Fires when the data set exposed by a data source object changes.
		/// </summary>		
		public HtmlDomEventHandler ondatasetchanged;
	 
		/// <summary>
		/// Fires to indicate that all data is available from the data source object.
		/// </summary>		
		public HtmlDomEventHandler ondatasetcomplete;

		/// <summary>
		/// Fires when the user double-clicks the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public HtmlDomEventHandler ondblclick;

		
	 
		/// <summary>
		/// Fires on the source object continuously during a drag operation.
		/// </summary>		
		public HtmlDomEventHandler ondrag;

		/// <summary>
		/// Fires on the source object when the user releases the mouse at the close of a drag operation.
		/// </summary>		
		public HtmlDomEventHandler ondragend;

		/// <summary>
		/// Fires on the target element when the user drags the object to a valid drop target.
		/// </summary>		
		public HtmlDomEventHandler ondragenter;
			 
		/// <summary>
		/// Fires on the target object when the user moves the mouse out of a valid drop target during a drag operation.
		/// </summary>		
		public HtmlDomEventHandler ondragleave;

		/// <summary>
		/// Fires on the target element continuously while the user drags the object over a valid drop target.
		/// </summary>		
		public HtmlDomEventHandler ondragover;

		/// <summary>
		/// Fires on the source object when the user starts to drag a text selection or selected object.
		/// </summary>		
		public HtmlDomEventHandler ondragstart;
			 
		/// <summary>
		/// Fires on the target object when the mouse button is released during a drag-and-drop operation.
		/// </summary>		
		public HtmlDomEventHandler ondrop;

		/// <summary>
		/// Fires on a databound object when an error occurs while updating the associated data in the data source object.
		/// </summary>		
		public HtmlDomEventHandler onerrorupdate;

		/// <summary>
		/// Fires when a visual filter changes state or completes a transition.
		/// </summary>		
		public HtmlDomEventHandler onfilterchange;
	 
		/// <summary>
		/// Fires when the object receives focus.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Firefox fires a focus event whenever you click on the document.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.")]
		public HtmlDomEventHandler onfocus;

		/// <summary>
		/// Fires when the user presses the F1 key while the browser is the active window.
		/// </summary>		
		public HtmlDomEventHandler onhelp;

		/// <summary>
		/// Fires when the user presses a key.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"The keydown event does not repeat in Opera and Konqueror.
You cannot prevent the default onkeydown in Opera.")]
		public HtmlDomEventHandler onkeydown;

		/// <summary>
		/// Fires when the user presses an alphanumeric key.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = "Firefox, Safari 3.0, Opera and Konqueror fire keypress events on any key. (The specification requires this event to be fired only if a keystroe leads to a character actually being added to an HTML element such as a text input.)")]
		public HtmlDomEventHandler onkeypress;
		 
		/// <summary>
		/// Fires when the user releases a key.
		/// </summary>		
		public HtmlDomEventHandler onkeyup;

		/// <summary>
		/// Fires when the print or print preview layout process finishes filling the current LayoutRect object with content from the source document.
		/// </summary>		
		public HtmlDomEventHandler onlayoutcomplete;

		/// <summary>
		/// Fires when the object loses the mouse capture.
		/// </summary>		
		public HtmlDomEventHandler onlosecapture;
		 
		/// <summary>
		/// Fires when the user clicks the object with either mouse button.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onmousedown;
	 
		/// <summary>
		/// Fires when the user moves the mouse over the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onmousemove;

		/// <summary>
		/// Fires when the user moves the mouse pointer outside the boundaries of the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onmouseout;

		/// <summary>
		/// Fires when the user moves the mouse pointer into the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onmouseover;
	 
		/// <summary>
		/// Fires when the user releases a mouse button while the mouse is over the object.
		/// </summary>		
		public HtmlDomEventHandler onmouseup;

		/// <summary>
		/// Fires when the wheel button is rotated.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public HtmlDomEventHandler onmousewheel;

		/// <summary>
		/// Fires when the object moves.
		/// </summary>		
		public HtmlDomEventHandler onmove;
	 
		/// <summary>
		/// Fires when the object stops moving.
		/// </summary>		
		public HtmlDomEventHandler onmoveend;

		/// <summary>
		/// Fires when the object starts to move.
		/// </summary>		
		public HtmlDomEventHandler onmovestart;

		/// <summary>
		/// Fires on the target object when the user pastes data, transferring the data from the system clipboard to the document.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, @"Firefox 3 has a lazy implementation.")]
		public HtmlDomEventHandler onpaste;
	 
		/// <summary>
		/// Fires when a property changes on the object.
		/// </summary>		
		public HtmlDomEventHandler onpropertychange;

		/// <summary>
		/// Fires when the state of the object has changed.
		/// </summary>		
		public HtmlDomEventHandler onreadystatechange;

		/// <summary>
		/// Fires when the size of the object is about to change.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlDomEventHandler onresize;
		 
		/// <summary>
		/// Fires when the user finishes changing the dimensions of the object in a control selection.
		/// </summary>		
		public HtmlDomEventHandler onresizeend;

		/// <summary>
		/// Fires when the user begins to change the dimensions of the object in a control selection.
		/// </summary>		
		public HtmlDomEventHandler onresizestart;

		/// <summary>
		/// Fires to indicate that the current row has changed in the data source and new data values are available on the object.
		/// </summary>		
		public HtmlDomEventHandler onrowenter;
	 
		/// <summary>
		/// Fires just before the data source control changes the current row in the object.
		/// </summary>		
		public HtmlDomEventHandler onrowexit;

		/// <summary>
		/// Fires when rows are about to be deleted from the recordset.
		/// </summary>		
		public HtmlDomEventHandler onrowsdelete;

		/// <summary>
		/// Fires just after new rows are inserted in the current recordset.
		/// </summary>		
		public HtmlDomEventHandler onrowsinserted;

		/// <summary>
		/// Fires when the user repositions the scroll box in the scroll bar on the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari probably monitors scrollTop access in order to determine whether the user has scrolled an element with overflow: auto.")]
		public HtmlDomEventHandler onscroll;

		/// <summary>
		/// Fires when the object is being selected.
		/// </summary>		
		public HtmlDomEventHandler onselectstart;

		#region DOM events - these do not work from markup style registration, but rather addEventListener only. They are all prefixed with "on", and are all private.
		/// <summary>
		/// Should fire when an element is activated.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4, @"Safari, Chrome and Konqueror incorrectly treat this event as an equivalent of the click event. For instance, when you click on a text input or even on the document in general the event fires. It shouldn’t: clicking on a text input does not activate the text box. Firefox correctly fires a click event only.
Safari and Chrome do not fire this event on radios and checkboxes.")]
		private HtmlDomEventHandler onDOMActivate;

		/// <summary>
		/// An attribute in the DOM tree of the element has been changed.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Firefox and Opera 9 also fire this event when you scroll a page, even though no DOM attribute is modified.")]
		private HtmlDomEventHandler onDOMAttrModified;

		/// <summary>
		/// Text in the DOM tree of the element has been changed.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, @"Firefox, Safari 3.0, Opera and Konqueror do not fire the event when you change character data through innerHTML.")]
		private HtmlDomEventHandler onDOMCharacterDataModified;



		/// <summary>
		/// As focus, but bubbles.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Safari doesn’t fire the event when you use the mouse to focus on links or elements with tabindex.", PartiallySupportedRemark = @"Chrome doesn’t fire the event when you use the mouse to focus on links.")]
		private HtmlDomEventHandler onDOMFocusIn;

		/// <summary>
		/// As blur, but bubbles.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Safari doesn’t fire the event when you focus on links or elements with tabindex.", PartiallySupportedRemark = @"Chrome doesn’t fire the event when you focus on links.")]
		private HtmlDomEventHandler onDOMFocusOut;

		/// <summary>
		/// When the user uses the mouse wheel.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4)]
		private HtmlDomEventHandler onDOMMouseScroll;

		/// <summary>
		/// A new node has been inserted into the DOM tree of the element.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Konqueror does not fire these events when you use innerHTML.")]
		private HtmlDomEventHandler onDOMNodeInserted;

		/// <summary>
		/// A node has been removed from the DOM tree of the element.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Safari fires two events when you remove one node.
Firefox and Opera also fire this event when you change the node’s content by innerHTML. Safari doesn’t. This is probably caused by the innerHTML implementations, and it is not considered a bug.
Konqueror does not fire these events when you use innerHTML.")]
		private HtmlDomEventHandler onDOMNodeRemoved;

		/// <summary>
		/// The most generic event: something in the DOM tree of the element has changed.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
		private HtmlDomEventHandler onDOMSubtreeModified;

		/// <summary>
		/// Equivalent of keypress.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5)]
		private HtmlDomEventHandler ontextInput;
		#endregion

		#region Microsoft specific
		/// <summary>
		/// Fires when the object is set as the active element.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlDomEventHandler onactivate;

		/// <summary>
		/// Fires on the source object before the selection is copied to the system clipboard.		
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3_1Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5)]
		public HtmlDomEventHandler onbeforecopy;

		/// <summary>
		/// Fires on the source object before the selection is deleted from the document.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3_1Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5)]
		public HtmlDomEventHandler onbeforecut;

		/// <summary>
		/// Fires on the target object before the selection is pasted from the system clipboard to the document.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3_1Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"Safari 3.1 and Chrome do not fire this event before an actual paste action. It works fine on context menus.")]
		public HtmlDomEventHandler onbeforepaste;

		/// <summary>
		/// Fires when the activeElement is changed from the current object to another object in the parent document.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlDomEventHandler ondeactivate;

		/// <summary>
		/// Fires for an element just prior to setting focus on that element.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlDomEventHandler onfocusin;

		/// <summary>
		/// Fires for the current element with focus immediately after moving focus to another element.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlDomEventHandler onfocusout;

		/// <summary>
		/// Raised when there are changes to the portion of a URL that follows the number sign (#).
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlDomEventHandler onhashchange;

		/// <summary>
		/// Fires when the user moves the mouse pointer into the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlDomEventHandler onmouseenter;

		/// <summary>
		/// Fires when the user moves the mouse pointer outside the boundaries of the object.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlDomEventHandler onmouseleave;
		#endregion

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public NodeList getElementsByClassName(string classNames)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public DOMTokenList classList
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public DOMStringMap dataset
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool itemScope
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string itemType
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string itemId
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string itemRef
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public DOMSettableTokenList itemProp
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlPropertiesCollection properties
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public object itemValue
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool hidden
		{
			get;
			set;
		}
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void click()
		{
			throw new NotImplementedException();
		}
		
		[JsProperty(NativeField = true)]
		public string accessKey
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string accessKeyLabel
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool draggable
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool isContentEditable
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlMenuElement contextMenu
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string spellcheck
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string commandType
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string label
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string icon
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool @checked
		{
			get;
			private set;
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
	}
}