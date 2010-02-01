using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel
{

	/// <summary>
	/// Allows manipulation and formatting of text strings and determination and location of substrings within strings.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false,Name = "String")]
	public class JsString : JsObject
	{
		public JsString()
		{
		}

		public JsString(object obj)
		{
			value = obj.ToString();
		}

		string value;

		public static implicit operator JsString(string s)
		{
			return new JsString(s);
		}
		public static implicit operator string(JsString s)
		{
			return s.value;
		}

		public static JsString operator +(JsString x, JsString y)
		{
			return new JsString(x.value + y.value);
		}
		public static JsString operator +(JsString x, string y)
		{
			return new JsString(x.value + y);
		}
		public static JsString operator +(string x, JsString y)
		{
			return new JsString(x + y.value);
		}




		/// <summary>
		/// Returns the last occurrence of a substring within a String object.
		/// </summary>
		/// <param name="sub">The char to search for within the String object.</param>
		/// <returns> an integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned. If startindex is negative, startindex is treated as zero. If it is larger than the greatest character position index, it is treated as the largest possible index.</returns>
		[JsMethod(NativeOverloads = true)]
		public int lastIndexOf(char sub)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the last occurrence of a substring within a String object.
		/// </summary>
		/// <param name="sub">The string to search for within the String object.</param>
		/// <returns> an integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned. If startindex is negative, startindex is treated as zero. If it is larger than the greatest character position index, it is treated as the largest possible index.</returns>
		[JsMethod(NativeOverloads = true)]
		public int lastIndexOf(string sub)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the last occurrence of a substring within a String object.
		/// </summary>
		/// <param name="substring">The substring to search for within the String object.</param>
		/// <param name="startindex">Integer value specifying the index to begin searching within the String object. If omitted, searching begins at the end of the string.</param>
		/// <returns> an integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned. If startindex is negative, startindex is treated as zero. If it is larger than the greatest character position index, it is treated as the largest possible index.</returns>
		[JsMethod(NativeOverloads = true)]
		public int lastIndexOf(string substring, int startindex)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public bool startsWith(string start)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		[JsMethod(NativeOverloads = true)]
		public bool endsWith(string end)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		[JsMethod(NativeOverloads = true)]
		public string substring(int index)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		[JsMethod(NativeOverloads = true)]
		public string substring(int index, int length)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		[JsMethod(NativeOverloads = true)]
		public string substr(int start, int end)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		[JsMethod(NativeOverloads = true)]
		public string substr(int start)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		[JsMethod(NativeOverloads = true)]
		public string[] split(JsRegExp re)
		{
			throw new NotImplementedException("TODO: Implement");
		}
		[JsMethod(NativeOverloads = true)]
		public string[] split(char sep)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		[JsMethod(NativeOverloads = true)]
		public string[] split(string sep)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		[JsMethod(NativeOverloads = true)]
		public string trim()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the character position where the first occurrence of a substring occurs within a String object.
		/// </summary>
		/// <param name="subString">Substring to search for within the String object.</param>
		/// <returns>An integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned.</returns>
		[JsMethod(NativeOverloads = true)]
		public int indexOf(string subString)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the character position where the first occurrence of a substring occurs within a String object.
		/// </summary>
		/// <param name="subString">Substring to search for within the String object.</param>
		/// <param name="startIndex">Integer value specifying the index to begin searching within the String object. If omitted, searching starts at the beginning of the string.</param>
		/// <returns>An integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned.</returns>
		[JsMethod(NativeOverloads = true)]
		public int indexOf(string subString, int startIndex)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the position of the first substring match in a regular expression search.
		/// </summary>
		/// <param name="regExp">An instance of a Regular Expression object containing the regular expression pattern and applicable flags.</param>
		/// <returns>The search method indicates if a match is present or not. If a match is found, the search method returns an integer value that indicates the offset from the beginning of the string where the match occurred. If no match is found, it returns -1.</returns>
		[JsMethod(NativeOverloads = true)]
		public int search(JsRegExp regExp)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the position of the first substring match in a regular expression search.
		/// </summary>
		/// <param name="searchText">The String object or string literal on which to perform the search.</param>
		/// <returns>The search method indicates if a match is present or not. If a match is found, the search method returns an integer value that indicates the offset from the beginning of the string where the match occurred. If no match is found, it returns -1.</returns>
		[JsMethod(NativeOverloads = true)]
		public int search(string searchText)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a copy of a string with text replaced using a regular expression or search string. 
		/// </summary>
		/// <param name="regExp">An instance of a Regular Expression object containing the regular expression pattern and applicable flags. </param>
		/// <param name="replaceText">Required. A String object or string literal containing the text to replace for every successful match of rgExp in stringObj. In JScript 5.5 or later, the replaceText argument can also be a function that returns the replacement text. </param>
		/// <returns>The result of the replace method is a copy of stringObj after the specified replacements have been made. </returns>
		[JsMethod(NativeOverloads = true)]
		public string replace(JsRegExp regExp, string replaceText)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a copy of a string with text replaced using a regular expression or search string. 
		/// </summary>
		/// <param name="searchText">String object or literal that is converted to a string, and an exact search is made for the results; no attempt is made to convert the string into a regular expression. </param>
		/// <param name="replaceText">Required. A String object or string literal containing the text to replace for every successful match of rgExp in stringObj. In JScript 5.5 or later, the replaceText argument can also be a function that returns the replacement text. </param>
		/// <returns>The result of the replace method is a copy of stringObj after the specified replacements have been made. </returns>
		[JsMethod(NativeOverloads = true)]
		public string replace(string searchText, string replaceText)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the length of a String object.
		/// </summary>
		public readonly int length;


		/// <summary>
		/// Places an HTML anchor with a NAME attribute around specified text in the object.
		/// </summary>
		/// <param name="anchorString">Text you want to place in the NAME attribute of an HTML anchor.</param>
		[JsMethod(NativeOverloads = true)]
		public void anchor(string anchorString)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Places HTML &lt;BIG&gt; tags around text in a String object.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public string big()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Places HTML &lt;BLINK&gt; tags around text in a String object.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public string blink()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Places HTML &lt;B&gt; tags around text in a String object.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public string bold()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the character at the specified index.
		/// </summary>
		/// <param name="index">Zero-based index of the desired character. Valid values are between 0 and the length of the string minus 1.</param>
		[JsMethod(NativeOverloads = true)]
		public string charAt(int index)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an integer representing the Unicode encoding of the character at the specified location.
		/// </summary>
		/// <param name="index">Zero-based index of the desired character. Valid values are between 0 and the length of the string minus 1.</param>
		[JsMethod(NativeOverloads = true)]
		public int charCodeAt(int index)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Returns a string value containing the concatenation of two or more supplied strings.
		/// </summary>
		/// <param name="strings">String objects or literals to concatenate to the end of string1.</param>
		/// <returns>The result of the concat method is equivalent to: result = string1 + string2 + string3 + + stringN. A change of value in either a source or result string does not affect the value in the other string. If any of the arguments are not strings, they are first converted to strings before being concatenated to string1.</returns>
		[JsMethod(NativeOverloads = true)]
		public string concat(params string[] strings)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Places HTML &lt;TT&gt; tags around text in a String object.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public string @fixed()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Places an HTML &lt;FONT&gt; tag with the COLOR attribute around the text in a String object.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public string fontcolor()
		{
			throw new NotImplementedException();
		}

		
		/// <summary>
		/// Places an HTML &lt;FONT&gt; tag with the SIZE attribute around the text in a String object.
		/// </summary>
		/// <param name="size">Integer value that specifies the size of the text.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public string fontsize(int size)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string from a number of Unicode character values.
		/// </summary>
		/// <param name="charCodes">A series of Unicode character values to convert to a string.</param>
		/// <returns>If no arguments are supplied, the result is the empty string.</returns>
		[JsMethod(NativeOverloads = true)]
		public static string fromCharCode(params int[] charCodes) 
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Places HTML &lt;I&gt; tags around text in a String object.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public string italics()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string where all alphabetic characters have been converted to lowercase, taking into account the host environment's current locale.
		/// </summary>
		/// <returns>Converts the characters in a string, taking into account the host environment's current locale. In most cases, the results are the same as you would obtain with the toLowerCase method. Results differ if the rules for a language conflict with the regular Unicode case mappings.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toLocaleLowerCase()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string where all alphabetic characters have been converted to uppercase, taking into account the host environment's current locale.
		/// </summary>
		/// <returns>Converts the characters in a string, taking into account the host environment's current locale. In most cases, the results are the same as you would obtain with the toUpperCase method. Results differ if the rules for a language conflict with the regular Unicode case mappings.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toLocaleUpperCase()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string where all alphabetic characters have been converted to lowercase.
		/// </summary>
		/// <returns>The method has no effect on nonalphabetic characters.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toLowerCase()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string where all alphabetic characters have been converted to uppercase.
		/// </summary>
		/// <returns>The method has no effect on non-alphabetic characters.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toUpperCase()
		{
			throw new NotImplementedException();
		}

	}

	////TODO: Deprecate this. and use As<JsString> Instead
	//public static class JsStringExtensions
	//{
	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static string fromCharCode(int charCode)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static int lastIndexOf(this string s, char sub)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static int lastIndexOf(this string s, string sub)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static bool startsWith(this string s, string start)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static bool endsWith(this string s, string end)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static string substring(this string s, int index)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static string substring(this string s, int index, int length)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static string substr(this string s, int start, int end)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static string[] split(this string s, char sep)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads=true)]
	//  public static string[] split(this string s, string sep)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static string trim(this string s)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads = true)]
	//  public static int indexOf(this string s, string g)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }

	//  [JsMethod(ExtensionImplementedInInstance = true, UseNativeOverloads=true)]
	//  public static string charAt(this string s, int index)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//  }
	//}

}
