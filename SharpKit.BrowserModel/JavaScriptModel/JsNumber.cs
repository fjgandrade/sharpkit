using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using System.ComponentModel;

namespace SharpKit.JavaScriptModel
{
	//TODO: this doesn't work with static methods
	/// <summary>
	/// An object representation of the number data type and placeholder for numeric constants.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false,Name = "Number")]
	public class JsNumber : JsObject, IConvertible, IComparable, IComparable<JsNumber>, IEquatable<JsNumber>, IFormattable
	{

		public JsNumber(double d)
		{
			value = d;
		}
		double value;

		public static implicit operator double(JsNumber number)
		{
			return ((IConvertible)number).ToDouble(null);
		}
		public static explicit operator decimal(JsNumber number)
		{
			return ((IConvertible)number).ToDecimal(null);
		}

		public static explicit operator int(JsNumber number)
		{
			return ((IConvertible)number).ToInt32(null);
		}
		public static explicit operator float(JsNumber number)
		{
			throw new NotImplementedException();
		}

		public static implicit operator JsNumber(decimal d)
		{
			return new JsNumber((double)d);
		}

		public static implicit operator JsNumber(double d)
		{
			return new JsNumber(d);
		}

		public static implicit operator JsNumber(int d)
		{
			return new JsNumber(d);
		}

		public static bool operator ==(JsNumber x, JsNumber y)
		{
			return x.value == y.value;
		}

		public static bool operator !=(JsNumber x, JsNumber y)
		{
			return x.value != y.value;
		}

		public static JsNumber operator ++(JsNumber x)
		{
			return new JsNumber(x.value++);
		}

		public static JsNumber operator --(JsNumber x)
		{
			return new JsNumber(x.value--);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			if (obj is JsNumber)
				return Compare(this, (JsNumber)obj) == 0;
			return false;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return value.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return value.ToString();
		}

		#region IComparable Members

		int IComparable.CompareTo(object obj)
		{
			if (obj == null)
				return 1;
			if (obj is JsNumber)
			{
				return Compare(this, (JsNumber)obj);
			}
			throw new ArgumentException("Argument must be JSNumber");

		}

		static int Compare(JsNumber x, JsNumber y)
		{
			return x.value.CompareTo(y.value);
		}

		#endregion

		#region IConvertible Members

		TypeCode IConvertible.GetTypeCode()
		{
			throw new Exception("The method or operation is not implemented.");
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)value;
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)value;
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)value;
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)value;
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return (long)value;
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		string IConvertible.ToString(IFormatProvider provider)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return ((IConvertible)value).ToType(type, provider);
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)value;
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)value;
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)value;
		}

		#endregion

		#region IComparable<JsNumber> Members

		int IComparable<JsNumber>.CompareTo(JsNumber other)
		{
			return Compare(this, other);
		}

		#endregion

		#region IEquatable<JsNumber> Members

		bool IEquatable<JsNumber>.Equals(JsNumber other)
		{
			return Compare(this, other) == 0;
		}

		#endregion

		#region IFormattable Members

		string IFormattable.ToString(string format, IFormatProvider formatProvider)
		{
			return value.ToString(format, formatProvider);
		}

		#endregion



		/// <summary>
		/// Returns the largest number representable in JScript. Equal to approximately 1.79E+308.
		/// </summary>
		public static readonly JsNumber MAX_VALUE;


		/// <summary>
		/// Returns the number closest to zero representable in JScript. Equal to approximately 5.00E-324.
		/// </summary>
		public static readonly JsNumber MIN_VALUE;

		/// <summary>
		/// A special value that indicates an arithmetic expression returned a value that was not a number.
		/// </summary>
		public static readonly JsNumber NaN;

		/// <summary>
		/// Returns a value more negative than the largest negative number.
		/// </summary>
		public static readonly JsNumber NEGATIVE_INFINITY;

		/// <summary>
		/// Returns a value larger than the largest number.
		/// </summary>
		public static readonly JsNumber POSITIVE_INFINITY;

		[JsMethod(NativeOverloads = true)]
		public JsFunction constructor()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string containing a number represented in exponential notation.
		/// </summary>
		/// <param name="fractionDigits">Number of digits after the decimal point. Must be in the range 0 – 20, inclusive.</param>
		/// <returns>A string representation of a number in exponential notation. The string contains one digit before the significand's decimal point, and may contain fractionDigits digits after it. If fractionDigits is not supplied, the toExponential method returns as many digits necessary to uniquely specify the number.</returns>
		public string toExponential(int fractionDigits)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string containing a number represented in exponential notation.
		/// </summary>
		/// <returns>A string representation of a number in exponential notation. The string contains one digit before the significand's decimal point, and may contain fractionDigits digits after it. If fractionDigits is not supplied, the toExponential method returns as many digits necessary to uniquely specify the number.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toExponential()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string containing a number represented either in exponential or fixed-point notation with a specified number of digits.
		/// </summary>
		/// <param name="precision">Number of significant digits. Must be in the range 1 – 21, inclusive.</param>
		/// <returns>For numbers in exponential notation, precision - 1 digits are returned after the decimal point. For numbers in fixed notation, precision significant digits are returned.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toPrecision (int precision)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string containing a number represented either in exponential or fixed-point notation with a specified number of digits.
		/// </summary>
		/// <returns>For numbers in exponential notation, precision - 1 digits are returned after the decimal point. For numbers in fixed notation, precision significant digits are returned.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toPrecision()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string representation of an object.
		/// </summary>
		/// <returns>Returns the textual representation of the number.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toString()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string representation of an object.
		/// </summary>
		/// <param name="radix">Specifies a radix for converting numeric values to strings. This value is only used for numbers.</param>
		/// <returns>Returns the textual representation of the number.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toString(int radix)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the primitive value of the specified object.
		/// </summary>
		/// <returns>The numeric value.</returns>
		[JsMethod(NativeOverloads = true)]
		public double valueOf()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// The toFixed() method formats a number to use a specified number of trailing decimals.
		/// The number is rounded up, and nulls are added after the decimal point (if needed), to create the desired decimal length.
		/// </summary>
		/// <returns></returns>
		public string toFixed()
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// The toFixed() method formats a number to use a specified number of trailing decimals.
		/// The number is rounded up, and nulls are added after the decimal point (if needed), to create the desired decimal length.
		/// </summary>
		/// <param name="x">The number of digits after the decimal point. Default is 0 (no digits after the decimal point)</param>
		/// <returns></returns>
		public string toFixed(int x)
		{
			throw new NotImplementedException();
		}

		
	}
}
