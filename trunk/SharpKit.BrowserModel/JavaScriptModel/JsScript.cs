using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.HtmlModel;

namespace SharpKit.JavaScriptModel
{
	[JsType(GlobalObject = true, Export = false)]
	public abstract class JsScript
	{
		public static void alert(object o)
		{
		}

		public static JsArguments arguments;

		/// <summary>
		/// Encodes String objects so they can be read on all computers.
		/// </summary>
		/// <param name="s">String object or literal to be encoded.</param>
		/// <returns>A string value (in Unicode format) that contains the contents of charstring. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with %xx encoding, where xx is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."</returns>
		public static string escape(string s)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// indicates that a variable has not been assigned a value.
		/// </summary>
		[JsProperty(NativeField=true)]
		public static object undefined { get; private set; }

		[JsMethod(Name="typeof")]
		public static string Typeof(object obj)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Evaluates JScript code and executes it.
		/// </summary>
		/// <param name="code">A string value that contains valid JScript code. This string is parsed by the JScript parser and executed.</param>
		/// <returns></returns>
		public static object eval(string code)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a floating-point number converted from a string.
		/// </summary>
		/// <param name="s">A string that contains a floating-point number.</param>
		/// <returns>A numerical value equal to the number contained in numString. If no prefix of numString can be successfully parsed into a floating-point number, NaN (not a number) is returned.</returns>
		public static float parseFloat(string s)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an integer converted from a string.
		/// </summary>
		/// <param name="s">A string to convert into a number.</param>
		/// <returns>An integer value equal to the number contained in numString. If no prefix of numString can be successfully parsed into an integer, NaN (not a number) is returned.</returns>
		public static int parseInt(string s)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an integer converted from a string.
		/// </summary>
		/// <param name="numString">A string to convert into a number.</param>
		/// <param name="radix"> A value between 2 and 36 indicating the base 
		/// of the number contained in numString. If not supplied, strings with 
		/// a prefix of '0x' are considered hexadecimal and strings with a prefix 
		/// of '0' are considered octal. All other strings are considered decimal.</param>
		/// <returns>An integer value equal to the number contained in numString. 
		/// If no prefix of numString can be successfully parsed into an integer, 
		/// NaN (not a number) is returned.</returns>
		public static int parseInt(string numString, int radix)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a Boolean value that indicates whether a value is the reserved value NaN (not a number).
		/// </summary>
		/// <param name="numValue">A value to be tested against NaN.</param>
		/// <returns>True if the value converted to the Number type is the NaN, otherwise false.</returns>
		public static bool isNaN(object numValue)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a Boolean value that indicates if a supplied number is finite.
		/// </summary>
		/// <param name="number">A numeric value.</param>
		/// <returns>True if number is any value other than NaN, negative infinity, 
		/// or positive infinity. In those three cases, it returns false.</returns>
		public static bool isFinite(double number)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Name="throw")]
		public static void Throw(JsError error)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI). 
		/// </summary>
		/// <param name="encodedURIString">A value representing an encoded URI component.</param>
		/// <returns>The required encodedURIString argument is a value representing an encoded 
		/// URI component.A URIComponent is part of a complete URI. If the encodedURIString is 
		/// not valid, a URIError occurs.</returns>
		public static string decodeURIComponent(string encodedURIString)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Encodes a text string as a valid component of a Uniform Resource Identifier (URI).
		/// </summary>
		/// <param name="encodedURIString">A value representing an encoded URI component.</param>
		/// <returns>A an encoded URI. If you pass the result to decodeURIComponent, 
		/// the original string is returned. Because the encodeURIComponent method encodes all 
		/// characters, be careful if the string represents a path such 
		/// as /folder1/folder2/default.html. The slash characters will be encoded and will 
		/// not be valid if sent as a request to a web server. Use the encodeURI method if the 
		/// string contains more than a single URI component.</returns>
		public static string encodeURIComponent(string encodedURIString)
		{
			throw new NotImplementedException();
		}

		public static void delete(object obj)
		{
		}

		/// <summary>
		/// Encodes a text string as a valid Uniform Resource Identifier (URI) 
		/// </summary>
		/// <param name="URIString">A value representing an encoded URI.</param>
		/// <returns>n encoded URI. If you pass the result to decodeURI, the original string is returned. The encodeURI method does not encode the following characters: ":", "/", ";", and "?". Use encodeURIComponent to encode these characters.</returns>
		public static string encodeURI(string URIString)
		{
			throw new NotImplementedException(" ");
		}

		/// <summary>
		/// Returns the unencoded version of an encoded Uniform Resource Identifier (URI). 
		/// </summary>
		/// <param name="URIString"></param>
		/// <returns></returns>
		public static string decodeURI(string URIString)
		{
			throw new NotImplementedException(" ");
		}

		/// <summary>
		/// Decodes String objects encoded with the escape method.
		/// </summary>
		/// <param name="charString">String object or literal to be decoded.</param>
		/// <returns>A string value that contains the contents of charstring. All characters encoded with the %xx hexadecimal form are replaced by their ASCII character set equivalents.</returns>
		public static string unescape(string charString)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves the HTML window
		/// </summary>
		[JsProperty(NativeField=true)]
		public static HtmlWindow window { get; private set; }

		/// <summary>
		/// Retrieves the HTML document
		/// </summary>
		[JsProperty(NativeField=true)]
		public static HtmlDocument document { get; private set; }
	}
}
