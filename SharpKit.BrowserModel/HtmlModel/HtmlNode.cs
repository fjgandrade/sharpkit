using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{	
	/// <summary>
	/// Represents an HtmlNode
	/// </summary>
	//[ParseChildrenAsProperties(false)]
	//[RunAtClient]
	[JsType(OmitCasts = true, Export = false, NativeOverloads=true)]
	//[JsType(Name="Node")] for FireFox
	public abstract class HtmlNode
	{
		/// <summary>
		/// Replaces an existing child element with a new child element.
		/// </summary>
		/// <param name="newNode"></param>
		/// <param name="existingChild"></param>
		/// <returns>Returns a reference to the object that is replaced.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlNode replaceChild(HtmlNode newNode, HtmlNode existingChild)
		{
			throw new NotImplementedException(" ");
		}

		/// <summary>
		/// Returns the node type
		/// </summary>
		/// <remarks>
		/// <list type="table">
		///		<item>
		///			<term>1</term>
		///			<description>Element node.</description>
		///		</item>
		///		<item>
		///			<term>2</term>
		///			<description>Attribute node.</description>
		///		</item>
		///		<item>
		///			<term>3</term>
		///			<description>Text node.</description>
		///		</item>
		///		<item>
		///			<term>4</term>
		///			<description>CDATA node.</description>
		///		</item>
		///		<item>
		///			<term>5</term>
		///			<description>Entity Reference node.</description>
		///		</item>
		///		<item>
		///			<term>6</term>
		///			<description>Entity node.</description>
		///		</item>
		///		<item>
		///			<term>7</term>
		///			<description>Processing instruction node.</description>
		///		</item>
		///		<item>
		///			<term>8</term>
		///			<description>Comment node.</description>
		///		</item>
		///		<item>
		///			<term>9</term>
		///			<description>HtmlDocument node.</description>
		///		</item>
		///		<item>
		///			<term>10</term>
		///			<description>Document type (DOCTYPE) node.</description>
		///		</item>
		///		<item>
		///			<term>11</term>
		///			<description>Document fragment node.</description>
		///		</item>
		///		<item>
		///			<term>12</term>
		///			<description>Notation node.</description>
		///		</item>
		/// </list>
		/// </remarks>
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE 5.5: attributes and document not defined; comment has nodeType 1.
		Konqueror doesn't see comment nodes.")]
		public int nodeType;

		/// <summary>
		/// Retrieves a reference to the previous child of the parent for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
		public HtmlNode previousSibling {get; internal set;}
		
		/// <summary>
		/// Retrieves a reference to the next child of the parent for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
		public HtmlNode nextSibling {get; internal set;}

		/// <summary>
		/// Retrieves the name of a particular type of node. 
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE 5.5 doesn't support a nodeName for attributes and the document. 
IE 5.5 reports the nodeName of a comment as !. 
Konqueror doesn't see comment nodes.")]
		public string nodeName { get; private set; }

		/// <summary>
		/// Sets or retrieves the value of a node.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE 5.5 doesn't support nodeValue for attributes
		Konqueror doesn't see comment nodes.")]
		[JsProperty(NativeField=true)]
		public string nodeValue { get; private set; }

		/// <summary>
		/// Retrieves the parent object in the document hierarchy.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlElement parentNode { get; internal set; }



		/// <summary>
		/// Compares the position of the current node against another node in any other document.
		/// </summary>
		/// <param name="otherNode ">the node that's being compared against.</param>
		/// <returns>a bitmask:
		/// 1: Position disconnected
		/// 2: Precedes
		/// 4: Follows
		/// 8: Contains
		/// 16: Is contained by
		/// </returns>
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public int compareDocumentPosition(HtmlNode otherNode)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a value that indicates whether the object has children.
		/// </summary>
		/// <returns>Returns true if the object contains HTML Elements or TextNode objects, or false if the object does not contain HTML Elements or TextNodes.</returns>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public bool hasChildNodes()		
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves the document object associated with the node.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsProperty(NativeField=true)]
		public HtmlDocument ownerDocument {get; private set;}


		public const int DOCUMENT_POSITION_DISCONNECTED = 0x01;
		public const int DOCUMENT_POSITION_PRECEDING = 0x02;
		public const int DOCUMENT_POSITION_FOLLOWING = 0x04;
		public const int DOCUMENT_POSITION_CONTAINS = 0x08;
		public const int DOCUMENT_POSITION_CONTAINED_BY = 0x10;
	}
}
		