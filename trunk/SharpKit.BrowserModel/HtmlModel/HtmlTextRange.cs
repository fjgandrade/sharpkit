using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents the active selection, which is a highlighted block of text or other elements in the document that a user or a script can carry out some action on.
	/// </summary>
	public class HtmlSelection
	{

		/// <summary>
		/// Creates a TextRange object from the current text selection, or a controlRange collection from a control selection. 
		/// </summary>
		/// <returns>Returns the created TextRange object.</returns>
		[JsMethod(NativeOverloads=true)]
		public HtmlTextRange createRange()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Clears the contents of the selection. 
		/// </summary>
		public void clear()
		{
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// Represents text in an HTML element. 
	/// </summary>
	public class HtmlTextRange
	{

		/// <summary>
		/// Searches for text in the document and positions the start and end points of the range to encompass the search string.
		/// </summary>
		/// <param name="text">String that specifies the text to find.</param>
		/// <returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
		[JsMethod(NativeOverloads = true)]
		public bool findText(string text)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Searches for text in the document and positions the start and end points of the range to encompass the search string.
		/// </summary>
		/// <param name="text">String that specifies the text to find.</param>
		/// <param name="searchScope">Integer that specifies the number of characters to search from the starting point of the range. A positive integer indicates a forward search; a negative integer indicates a backward search. </param>
		/// <returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
		[JsMethod(NativeOverloads = true)]
		public bool findText(string text, int searchScope)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Searches for text in the document and positions the start and end points of the range to encompass the search string.
		/// </summary>
		/// <param name="text">String that specifies the text to find.</param>
		/// <param name="searchScope">Integer that specifies the number of characters to search from the starting point of the range. A positive integer indicates a forward search; a negative integer indicates a backward search. </param>
		/// <param name="flags">Integer that specifies one or more of the following flags to indicate the type of search: 0 Default. Match partial words. 
		/// 1 Match backwards. 
		/// 2 Match whole words only. 
		/// 4 Match case. 
		/// 131072 Match bytes. 
		/// 536870912 Match diacritical marks. 
		/// 1073741824 Match Kashida character. 
		/// 2147483648 Match AlefHamza character. 
		/// </param>
		/// <returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
		[JsMethod(NativeOverloads = true)]
		public bool findText(string text, int searchScope, int flags)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves the parent element for the given text range.
		/// </summary>
		/// <returns>Returns the parent element object if successful, or null otherwise.</returns>
		public HtmlElement parentElement()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Retrieves the distance between the left edge of the rectangle that bounds the TextRange object and the left side of the object that contains the TextRange.
		/// </summary>
		[JsProperty(NativeField=true)]
		public int boundingLeft
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Retrieves the width of the rectangle that bounds the TextRange object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int boundingWidth
		{
			get
			{
				throw new NotImplementedException();
			}
		}


		/// <summary>
		/// Retrieves the distance between the top edge of the rectangle that bounds the TextRange object and the top side of the object that contains the TextRange. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int boundingTop
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Retrieves the height of the rectangle that bounds the TextRange object. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int boundingHeight
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Retrieves the calculated top position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int offsetTop
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Retrieves the calculated left position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int offsetLeft
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int scrollTop
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Makes the selection equal to the current object. 
		/// </summary>
		public void select()
		{
		}

		/// <summary>
		/// Moves the text range so that the start and end positions of the range encompass the text in the given element.
		/// </summary>
		/// <param name="p"></param>
		[JsMethod(NativeOverloads = true)]
		public void moveToElementText(HtmlElement p)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Causes the object to scroll into view, aligning it either at the top or bottom of the window.
		/// </summary>
		/// <param name="bAlignToTop">Boolean that specifies one of the following values:
    ///
		///														true - Default. Scrolls the object so that top of the object is visible at the top of the window.
    ///														false - Scrolls the object so that the bottom of the object is visible at the bottom of the window</param>
		[JsMethod(NativeOverloads = true)]
		public void scrollIntoView(bool bAlignToTop)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets or retrieves the text contained within the range. 
		/// </summary>
		[JsProperty(NativeField=true)]
		public string text
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

		/// <summary>
		/// Retrieves the HTML source as a valid HTML fragment. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string htmlText
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Collapses the given text range and moves the empty range by the given number of units
		/// </summary>
		/// <param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit.</param>
		/// <param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
		[JsMethod(NativeOverloads = true)]
		public int move(string sUnit, int iCount)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Returns a duplicate of the TextRange.
		/// </summary>
		/// <returns>Returns a TextRange object.</returns>
		public HtmlTextRange duplicate()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the endpoint of one range based on the endpoint of another range.
		/// </summary>
		/// <param name="sType">Required. String that specifies the endpoint to transfer using one of the following values: startToEnd, startToStart, endToStart, endToEnd</param>
		/// <param name="oTextRange">Required. TextRange object from which the source endpoint is to be taken.</param>
		[JsMethod(NativeOverloads = true)]
		public void setEndPoint(string sType, HtmlTextRange oTextRange)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Pastes HTML text into the given text range, replacing any previous text and HTML elements in the range.
		/// </summary>
		/// <param name="sHTMLText">Required. String that specifies the HTML text to paste. The string can contain text and any combination of the HTML tags described in HTML Elements.</param>
		[JsMethod(NativeOverloads = true)]
		public void pasteHTML(string sHTMLText)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Moves the start and end positions of the text range to the given point.
		/// </summary>
		/// <param name="x">Required. Integer that specifies the horizontal offset relative to the upper-left corner of the window, in pixels.</param>
		/// <param name="y">Required. Integer that specifies the vertical offset relative to the upper-left corner of the window, in pixels.</param>
		[JsMethod(NativeOverloads = true)]
		public void moveToPoint(int x, int y)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a value indicating whether the specified range is equal to the current range.
		/// </summary>
		/// <param name="oCompareRange">Required. TextRange object to compare with the current TextRange object. </param>
		/// <returns>Boolean that returns true if oCompareRange is equal to the parent object, otherwise false.</returns>
		[JsMethod(NativeOverloads = true)]
		public bool isEqual(HtmlTextRange oCompareRange)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Changes the start position of the range.
		/// </summary>
		/// <param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
		/// <param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public int moveEnd(string sUnit, int iCount)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Changes the end position of the range.
		/// </summary>
		/// <param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
		/// <param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public int moveStart(string sUnit, int iCount)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Moves the insertion point to the beginning or end of the current range. 
		/// </summary>
		/// <param name="bStart">Optional. Boolean that specifies one of the following values: 
		/// <list type="table">
		/// <item>
		///		<term>true</term>
		///		<description>Default. Moves the insertion point to the beginning of the text range.</description>
		/// </item>
		/// <item>
		///		<term>false</term>
		///		<description>Moves the insertion point to the end of the text range.</description>
		/// </item>
		/// </list>
		/// </param>
		[JsMethod(NativeOverloads=true)]
		public void collapse(bool bStart)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Moves the insertion point to the beginning or end of the current range. 
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public void collapse()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a value indicating whether one range is contained within another.
		/// </summary>
		/// <param name="range2">TextRange object that might be contained</param>
		/// <returns>Boolean that returns one of the following possible values.
		/// true oRange is contained within or is equal to the TextRange object on which the method is called. 
		/// false oRange is not contained within the TextRange object on which the method is called. 
		/// </returns>
		[JsMethod(NativeOverloads = true)]
		public bool inRange(HtmlTextRange range2)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Compares an end point of a TextRange object with an end point of another range. 
		/// </summary>
		/// <param name="type">String that specifies one of the following values: 
		/// StartToEnd Compare the start of the TextRange object with the end of the oRange parameter. 
		/// StartToStart Compare the start of the TextRange object with the start of the oRange parameter. 
		/// EndToStart Compare the end of the TextRange object with the start of the oRange parameter. 
		/// EndToEnd Compare the end of the TextRange object with the end of the oRange parameter 
		/// </param>
		/// <param name="range">TextRange object that specifies the range to compare with the object</param>
		/// <returns>Returns one of the following possible values:
		/// -1 The end point of the object is further to the left than the end point of oRange. 
		/// 0 The end point of the object is at the same location as the end point of oRange. 
		/// 1 The end point of the object is further to the right than the end point of oRange.</returns>
		[JsMethod(NativeOverloads = true)]
		public int compareEndPoints(string type, HtmlTextRange range)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves a bookmark (opaque string) that can be used with moveToBookmark to return to the same range. 
		/// </summary>
		/// <returns>String. Returns the bookmark if successfully retrieved, or null otherwise. </returns>
		public string getBookmark()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Moves to a bookmark.
		/// </summary>
		/// <param name="bookmark">String that specifies the bookmark to move to. </param>
		/// <returns>Boolean that returns one of the following possible values:
		/// true Successfully moved to the bookmark. 
		/// false Move to the bookmark failed. </returns>
		[JsMethod(NativeOverloads = true)]
		public bool moveToBookmark(string bookmark)
		{
			throw new NotImplementedException();
		}
	}
}
