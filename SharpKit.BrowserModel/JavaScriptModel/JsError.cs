using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel
{
	[JsType(Export = false,Name = "Error", NativeConstructors = true)]
	public class JsError : JsObject
	{
		public JsError()
		{
		}

		public JsError(string s)
		{
		}
		/// <summary>
		/// Returns or sets the descriptive string associated with a specific error.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string description { get; set; }

		/// <summary>
		/// Returns an error message string.
		/// </summary>
		[JsProperty(NativeField=true)]
		public string message { get; set; }

		/// <summary>
		/// Returns the name of an error.
		/// When a runtime error occurs, the name property is set to one of the following native exception types:
		/// ConversionError		This error occurs whenever there is an attempt to convert an object into something to which it cannot be converted.
		/// RangeError				This error occurs when a function is supplied with an argument that has exceeded its allowable range. For example, this error occurs if you attempt to construct an Array object with a length that is not a valid positive integer.
		/// ReferenceError		This error occurs when an invalid reference has been detected. This error will occur, for example, if an expected reference is null.
		/// RegExpError				This error occurs when a compilation error occurs with a regular expression. Once the regular expression is compiled, however, this error cannot occur. This example will occur, for example, when a regular expression is declared with a pattern that has an invalid syntax, or flags other than i, g, or m, or if it contains the same flag more than once.
		///	SyntaxError				This error occurs when source text is parsed and that source text does not follow correct syntax. This error will occur, for example, if the eval function is called with an argument that is not valid program text.
		///	TypeError					This error occurs whenever the actual type of an operand does not match the expected type. An example of when this error occurs is a function call made on something that is not an object or does not support the call.
		///	URIError					This error occurs when an illegal Uniform Resource Indicator (URI) is detected. For example, this is error occurs when an illegal character is found in a string being encoded or decoded.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string name { get; set; }

		/// <summary>
		/// Returns or sets the numeric value associated with a specific error. The Error object's default property is number.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string number { get; set; }


		


		
	}

}
