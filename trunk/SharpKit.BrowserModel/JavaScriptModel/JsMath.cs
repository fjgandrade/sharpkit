using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel
{
	[JsType(Export = false,Name = "Math")]
	public static class JsMath
	{
		
		/// <summary>
		/// Returns the mathematical constant e, the base of natural logarithms. The E property is approximately equal to 2.718.
		/// </summary>
		public static readonly JsNumber E;
		
		/// <summary>
		/// Returns the natural logarithm of 2.
		/// </summary>
		/// 
		public static readonly JsNumber LN2;

		/// <summary>
		/// Returns the natural logarithm of 10.
		/// </summary>
		public static readonly JsNumber LN10;

		/// <summary>
		/// Returns the base-2 logarithm of e, Euler's number.
		/// </summary>
		public static readonly JsNumber LOG2E;

		/// <summary>
		/// Returns the base-10 logarithm of e, Euler's number.
		/// </summary>
		public static readonly JsNumber LOG10E;

		/// <summary>
		/// Returns the ratio of the circumference of a circle to its diameter, approximately 3.141592653589793.
		/// </summary>
		public static readonly JsNumber PI;

		/// <summary>
		/// Returns the square root of 0.5, or one divided by the square root of 2.
		/// </summary>
		public static readonly JsNumber SQRT1_2;

		/// <summary>
		/// Returns the square root of 2.
		/// </summary>
		public static readonly JsNumber SQRT2;

		/// <summary>
		/// Returns the absolute value of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the absolute value is needed</param>
		/// <returns>The absolute value of the number argument</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber abs(JsNumber number)
		{
			return new JsNumber(Math.Abs((double)number));
		}

		/// <summary>
		/// Returns the arccosine of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the arccosine is needed.</param>
		/// <returns>the arccosine of the number argument.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber acos(JsNumber number)
		{
			throw new NotImplementedException();
		}

		
		/// <summary>
		/// Returns the arcsine of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the arcsine is needed.</param>
		/// <returns>The arcsine of its numeric argument.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber asin(JsNumber number)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Returns the arctangent of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the arctangent is needed.</param>
		/// <returns>The return value is the arctangent of its numeric argument.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber atan(JsNumber number)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the angle (in radians) from the X axis to a point (y,x).
		/// </summary>
		/// <param name="y">A numeric expression representing the cartesian x-coordinate.</param>
		/// <param name="x">A numeric expression representing the cartesian y-coordinate.</param>
		/// <returns>The return value is between -pi and pi, representing the angle of the supplied (y,x) point.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber atan2(JsNumber y, JsNumber x)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the smallest integer greater than or equal to its numeric argument.
		/// </summary>
		/// <param name="number">A numeric expression.</param>
		/// <returns>An integer value equal to the smallest integer greater than or equal to its numeric argument.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber ceil(JsNumber number)
		{
			return new JsNumber(Math.Ceiling((double)number));
		}


		/// <summary>
		/// Returns the cosine of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the cosine is needed.</param>
		/// <returns>The return value is the cosine of its numeric argument.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber cos(JsNumber number)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns e (the base of natural logarithms) raised to a power.
		/// </summary>
		/// <param name="number">A numeric expression representing the power of e.</param>
		/// <returns>The return value is a number. The constant e is Euler's number, approximately equal to 2.71828 and number is the supplied argument.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber exp(JsNumber number)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the greatest integer less than or equal to its numeric argument.
		/// </summary>
		/// <param name="number">A numeric expression.</param>
		/// <returns>An integer value equal to the greatest integer less than or equal to its numeric argument.</returns>
		[JsMethod(NativeOverloads=true)]
		public static JsNumber floor(JsNumber number)
		{
			return new JsNumber(Math.Floor((double)number));
		}

		/// <summary>
		/// Returns the natural logarithm of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the natural logarithm is sought.</param>
		/// <returns>The return value is the natural logarithm of number. The base is e.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber log(JsNumber number)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the greater of zero or more supplied numeric expressions.
		/// </summary>
		/// <param name="numbers">Numeric expressions to be evaluated</param>
		/// <returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber max(params JsNumber[] numbers)
		{
			throw new NotImplementedException();
			//return new JsNumber(Math.Max((decimal)x, (decimal)y));
		}

		/// <summary>
		/// Returns the lesser of zero or more supplied numeric expressions.
		/// </summary>
		/// <param name="numbers">Numeric expressions to be evaluated</param>
		/// <returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber min(params JsNumber[] numbers)
		{
			throw new NotImplementedException();
			//return new JsNumber(Math.Min((decimal)x, (decimal)y));
		}
		
		/// <summary>
		/// Returns the value of a base expression taken to a specified power.
		/// </summary>
		/// <param name="base">The base value of the expression.</param>
		/// <param name="exponent">The exponent value of the expression.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber pow(JsNumber @base, JsNumber exponent)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Returns a pseudorandom number between 0 and 1.
		/// </summary>
		/// <returns>The pseudorandom number generated is from 0 (inclusive) to 1 (exclusive), that is, the returned number can be zero, but it will always be less than one.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber random()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a supplied numeric expression rounded to the nearest integer.
		/// </summary>
		/// <param name="number">The value to be rounded to the nearest integer.</param>
		/// <returns>For positive numbers, if the decimal portion of number is 0.5 or greater, 
		/// the return value is equal to the smallest integer greater than number. If the 
		/// decimal portion is less than 0.5, the return value is the largest integer less than 
		/// or equal to number. For negative numbers, if the decimal portion is exactly -0.5, 
		/// the return value is the smallest integer that is greater than the number.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber round(JsNumber number)
		{
			return new JsNumber(Math.Round((double)number));
		}

		/// <summary>
		/// Returns the sine of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the sine is needed</param>
		/// <returns>The sine of the numeric argument</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber sin(JsNumber number)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the square root of a number.
		/// </summary>
		/// <param name="number">A numeric expression.</param>
		/// <returns>If number is negative, the return value is NaN.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber sqrt(JsNumber number)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the tangent of a number.
		/// </summary>
		/// <param name="number">A numeric expression for which the tangent is sought.</param>
		/// <returns>The tangent of number.</returns>
		[JsMethod(NativeOverloads = true)]
		public static JsNumber tan(JsNumber number)
		{
			throw new NotImplementedException();
		}
	}
}
