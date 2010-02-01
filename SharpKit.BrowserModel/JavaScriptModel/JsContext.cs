using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScriptModel
{
	[JsType(GlobalObject = true, Export = false)]
	public class JsContext
	{
		public static JsArguments arguments;

		/// <summary>
		/// indicates that a variable has not been assigned a value.
		/// </summary>
		[JsProperty(NativeField = true)]
		public static object undefined { get; private set; }

		public static string @typeof(object obj)
		{
			throw new NotImplementedException();
		}

		public static object @this;

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

		public static void @throw(JsError error)
		{
			throw new NotImplementedException();
		}
		public static void delete(object obj)
		{
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


	}
}
