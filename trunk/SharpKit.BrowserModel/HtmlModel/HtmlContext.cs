using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	[JsType(GlobalObject = true, Export = false)]
	public class HtmlContext : JsContext
	{

		public static void alert(object o)
		{
		}

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
		[JsProperty(NativeField = true)]
		public static HtmlWindow window { get; private set; }

		/// <summary>
		/// Retrieves the HTML document
		/// </summary>
		[JsProperty(NativeField = true)]
		public static HtmlDocument document { get; private set; }
	}

}
