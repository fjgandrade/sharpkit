using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel
{
	[JsType(Export = false,Name = "Date", NativeConstructors = true)]
	public class JsDate : JsObject
	{
		public static int operator -(JsDate date1, JsDate date2)
		{
			throw new NotImplementedException(" ");
		}
		//TODO: Support native ctors
		public JsDate(params object[] prms)
		{
		}

		/// <summary>
		/// Returns the year value in the Date object using local time.
		/// </summary>
		/// <returns>the year as an absolute number. For example, the year 1976 is returned as 1976.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getFullYear()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the month value in the Date object using local time.
		/// </summary>
		/// <returns>integer between 0 and 11 indicating the month value in the Date object. The integer returned is not the traditional number used to indicate the month. It is one less. If "Jan 5, 1996 08:47:00" is stored in a Date object, getMonth returns 0.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getMonth()
		{
			throw new NotImplementedException("TODO: Implement");
		}
		
		/// <summary>
		/// Returns the day-of-the-month value in a Date object using local time.
		/// </summary>
		/// <returns> an integer between 1 and 31 that represents the day-of-the-month value in the Date object.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getDate()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the hours value in a Date object using local time.
		/// </summary>
		/// <returns>an integer between 0 and 23, indicating the number of hours since midnight. A zero occurs in two situations: the time is before 1:00:00 am, or the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getHours()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the minutes value in a Date object using local time.
		/// </summary>
		/// <returns>integer between 0 and 59 equal to the minutes value stored in the Date object. A zero is returned in two situations: when the time is less than one minute after the hour, or when the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getMinutes()
		{
			throw new NotImplementedException("TODO: Implement");
		}
		
		/// <summary>
		/// Returns the seconds value in a Date object using local time.
		/// </summary>
		/// <returns> integer between 0 and 59 indicating the seconds value of the indicated Date object. A zero is returned in two situations. One occurs when the time is less than one second into the current minute. The other occurs when the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and minutes for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getSeconds()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns the milliseconds value in a Date object using local time.
		/// </summary>
		/// <returns>The millisecond value returned can range from 0-999.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getMilliseconds()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Sets the month value in the Date object using local time.
		/// </summary>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		[JsMethod(NativeOverloads = true)]
		public void setMonth(int numMonth)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the month value in the Date object using local time.
		/// </summary>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		/// <param name="dateVal">A numeric value representing the day of the month. If this value is not supplied, the value from a call to the getDate method is used.</param>
		[JsMethod(NativeOverloads = true)]
		public void setMonth(int numMonth, int dateVal) 
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hour value in the Date object using local time.
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setHours(int numHours)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hour value in the Date object using local time.
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		/// <param name="numMin">A numeric value equal to the minutes value. </param>
		[JsMethod(NativeOverloads = true)]
		public void setHours(int numHours, int numMin)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hour value in the Date object using local time.
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		/// <param name="numMin">A numeric value equal to the minutes value. </param>
		/// <param name="numSec">A numeric value equal to the seconds value. </param>
		[JsMethod(NativeOverloads = true)]
		public void setHours(int numHours, int numMin, int numSec)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hour value in the Date object using local time.
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		/// <param name="numMin">A numeric value equal to the minutes value. </param>
		/// <param name="numSec">A numeric value equal to the seconds value. </param>
		/// <param name="numMilli">A numeric value equal to the milliseconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setHours(int numHours, int numMin, int numSec, int numMilli)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Sets the minutes value in the Date object using local time.
		/// </summary>
		/// <param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
		[JsMethod(NativeOverloads = true)]
		public void setMinutes(int numMinutes)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the minutes value in the Date object using local time.
		/// </summary>
		/// <param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
		/// <param name="numSeconds">A numeric value equal to the seconds value. Must be supplied if the numMilli argument is used.</param>
		[JsMethod(NativeOverloads = true)]
		public void setMinutes(int numMinutes, int numSeconds)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the minutes value in the Date object using local time.
		/// </summary>
		/// <param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
		/// <param name="numSeconds">A numeric value equal to the seconds value. Must be supplied if the numMilli argument is used.</param>
		/// <param name="numMilli">A numeric value equal to the milliseconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setMinutes(int numMinutes, int numSeconds, int numMilli)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the seconds value in the Date object using local time.
		/// </summary>
		/// <param name="numSeconds">A numeric value equal to the seconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setSeconds(int numSeconds) 
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the seconds value in the Date object using local time.
		/// </summary>
		/// <param name="numSeconds">A numeric value equal to the seconds value.</param>
		/// <param name="numMilli">A numeric value equal to the milliseconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setSeconds(int numSeconds, int numMilli)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the milliseconds value in the Date object using local time.
		/// </summary>
		/// <param name="value">A numeric value equal to the millisecond value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setMilliseconds(int value)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the date and time value in the Date object.
		/// </summary>
		/// <param name="milliseconds">A numeric value representing the number of elapsed milliseconds since midnight, January 1, 1970 GMT.</param>
		[JsMethod(NativeOverloads = true)]
		public void setTime(int milliseconds) 
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the numeric day of the month in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numDate">A numeric value equal to the day of the month.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCDate(int numDate) 
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the year value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numYear">A numeric value equal to the year.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCFullYear(int numYear)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the year value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numYear">A numeric value equal to the year.</param>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCFullYear(int numYear, int numMonth)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the year value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numYear">A numeric value equal to the year.</param>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		/// <param name="numDate">A numeric value equal to the day of the month.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCFullYear(int numYear, int numMonth, int numDate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCHours(int numHours)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		/// <param name="numMin">A numeric value equal to the minutes value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCHours(int numHours, int numMin)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		/// <param name="numMin">A numeric value equal to the minutes value.</param>
		/// <param name="numSec">A numeric value equal to the seconds value</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCHours(int numHours, int numMin, int numSec)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numHours">A numeric value equal to the hours value.</param>
		/// <param name="numMin">A numeric value equal to the minutes value.</param>
		/// <param name="numSec">A numeric value equal to the seconds value</param>
		/// <param name="numMilli">A numeric value equal to the milliseconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCHours(int numHours, int numMin, int numSec, int numMilli)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the milliseconds value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numMilli">A numeric value equal to the millisecond value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCMilliseconds(int numMilli) 
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numMinutes">A numeric value equal to the minutes value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCMinutes(int numMinutes)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numMinutes">A numeric value equal to the minutes value.</param>
		/// <param name="numSeconds">A numeric value equal to the seconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCMinutes(int numMinutes, int numSeconds)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numMinutes">A numeric value equal to the minutes value.</param>
		/// <param name="numSeconds">A numeric value equal to the seconds value.</param>
		/// <param name="numMilli">A numeric value equal to the milliseconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCMinutes(int numMinutes, int numSeconds, int numMilli)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the month value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCMonth(int numMonth)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the month value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		/// <param name="dateVal">A numeric value representing the day of the month. If it is not supplied, the value from a call to the getUTCDate method is used.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCMonth(int numMonth, int dateVal)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the seconds value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numSeconds">A numeric value equal to the seconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCSeconds(int numSeconds)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the seconds value in the Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <param name="numSeconds">A numeric value equal to the seconds value.</param>
		/// <param name="numMilli">A numeric value equal to the milliseconds value.</param>
		[JsMethod(NativeOverloads = true)]
		public void setUTCSeconds(int numSeconds, int numMilli)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the year value in the Date object.
		/// </summary>
		/// <param name="numYear">This method is obsolete, and is maintained for backwards compatibility only. Use the setFullYear method instead. For the years 1900 through 1999, this is a numeric value equal to the year minus 1900. For dates outside that range, this is a 4-digit numeric value.</param>
		[JsMethod(NativeOverloads = true)]
		[Obsolete]
		public void setYear(int numYear)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a date as a string value.
		/// </summary>
		/// <returns>A string value containing the date, in the current time zone, in a convenient, easily read format.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toDateString()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a date converted to a string using Greenwich Mean Time(GMT).
		/// Obsolete, and is provided for backwards compatibility only. It is recommended that you use the toUTCString method instead.
		/// </summary>setyear
		/// <returns>A String object that contains the date formatted using GMT convention. The format of the return value is as follows: "05 Jan 1996 00:00:00 GMT."</returns>
		[Obsolete]
		[JsMethod(NativeOverloads = true)]
		public string toGMTString()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Used by the JSON.stringify method to enable the transformation of an object's data of before the JSON serialization.
		/// </summary>
		/// <returns>Returns an ISO-formatted date string for the UTC time zone (denoted by the suffix Z).</returns>
		[JsMethod(NativeOverloads = true)]
		public string toJSON()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a date as a string value appropriate to the host environment's current locale.
		/// </summary>
		/// <returns>A string value that contains a date, in the current time zone, in an easily read format. The date is in the default format of the host environment's current locale. The return value of this method cannot be relied upon in scripting, as it will vary from computer to computer. The toLocaleDateString method should only be used to format display – never as part of a computation.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toLocaleDateString()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a time as a string value appropriate to the host environment's current locale.
		/// </summary>
		/// <returns>A string value that contains a time, in the current time zone, in an easily read format. The time is in the default format of the host environment's current locale. The return value of this method cannot be relied upon in scripting, as it will vary from computer to computer. The toLocaleTimeString method should only be used to format display – never as part of a computation.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toLocaleTimeString()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a time as a string value.
		/// </summary>
		/// <returns>A string value containing the time, in the current time zone, in a convenient, easily read format.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toTimeString()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a date converted to a string using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>A String object that contains the date formatted using UTC convention in a convenient, easily read form.</returns>
		[JsMethod(NativeOverloads = true)]
		public string toUTCString()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
		/// </summary>
		/// <param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
		/// <param name="month">The month as an integer between 0 and 11 (January to December).</param>
		/// <param name="day"> The date as an integer between 1 and 31.</param>
		/// <returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
		[JsMethod(NativeOverloads = true)]
		public static string UTC(int year, int month, int day)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
		/// </summary>
		/// <param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
		/// <param name="month">The month as an integer between 0 and 11 (January to December).</param>
		/// <param name="day"> The date as an integer between 1 and 31.</param>
		/// <param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
		/// <returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
		[JsMethod(NativeOverloads = true)]
		public static string UTC(int year, int month, int day, int hours)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
		/// </summary>
		/// <param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
		/// <param name="month">The month as an integer between 0 and 11 (January to December).</param>
		/// <param name="day"> The date as an integer between 1 and 31.</param>
		/// <param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
		/// <param name="minutes"> An integer from 0 to 59 that specifies the minutes.</param>
		/// <returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
		[JsMethod(NativeOverloads = true)]
		public static string UTC(int year, int month, int day, int hours, int minutes)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
		/// </summary>
		/// <param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
		/// <param name="month">The month as an integer between 0 and 11 (January to December).</param>
		/// <param name="day"> The date as an integer between 1 and 31.</param>
		/// <param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
		/// <param name="minutes"> An integer from 0 to 59 that specifies the minutes.</param>
		/// <param name="seconds">An integer from 0 to 59 that specifies the seconds.</param>
		/// <returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
		[JsMethod(NativeOverloads = true)]
		public static string UTC(int year, int month, int day, int hours, int minutes, int seconds)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
		/// </summary>
		/// <param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
		/// <param name="month">The month as an integer between 0 and 11 (January to December).</param>
		/// <param name="day"> The date as an integer between 1 and 31.</param>
		/// <param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
		/// <param name="minutes"> An integer from 0 to 59 that specifies the minutes.</param>
		/// <param name="seconds">An integer from 0 to 59 that specifies the seconds.</param>
		/// <param name="ms">An integer from 0 to 999 that specifies the milliseconds.</param>
		/// <returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
		[JsMethod(NativeOverloads = true)]
		public static string UTC(int year, int month, int day, int hours, int minutes, int seconds, int ms)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the primitive value of the specified object.
		/// </summary>
		/// <returns>The stored time value in milliseconds since midnight, January 1, 1970 UTC.</returns>
		[JsMethod(NativeOverloads = true)]
		public new int valueOf()
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public JsDate addDays(int days)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public JsDate addMonths(int months)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public JsDate removeTime()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the time value in a Date object. 
		/// </summary>
		/// <returns>
		/// An integer value representing the number of milliseconds between midnight, January 1, 1970 and the time value in the Date object. 
		/// The range of dates is approximately 285,616 years from either side of midnight, January 1, 1970. 
		/// Negative numbers indicate dates prior to 1970. </returns>
		[JsMethod(NativeOverloads = true)]
		public int getTime()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the day of the week value in a Date object using local time.
		/// </summary>
		/// <returns>an integer between 0 and 6 representing the day of the week and corresponds to a day of the week as follows: 
		/// 0 Sunday 1 Monday 2 Tuesday 3 Wednesday 4 Thursday 5 Friday 6 Saturday</returns>
		[JsMethod(NativeOverloads = true)]
		public int getDay()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the difference in minutes between the time on the host computer and Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>An integer value representing the number of minutes between the time on the current machine and UTC. These values are appropriate to the computer the script is executed on. If it is called from a server script, the return value is appropriate to the server. If it is called from a client script, the return value is appropriate to the client.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getTimezoneOffset()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the day-of-the-month value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>an integer between 1 and 31 that represents the day-of-the-month value in the Date object.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCDate()
		{
			throw new NotImplementedException();
		}

		
			/// <summary>
		/// Returns the day of the week value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>an integer between 0 and 6 representing the day of the week and corresponds to a day of the week as follows: 
		/// 0 Sunday 1 Monday 2 Tuesday 3 Wednesday 4 Thursday 5 Friday 6 Saturday</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCDay()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the year value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>The year as an absolute number. This avoids the year 2000 problem where dates beginning with January 1, 2000 are confused with those beginning with January 1, 1900.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCFullYear()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the hours value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>An integer between 0 and 23 indicating the number of hours since midnight. A zero occurs in two situations: the time is before 1:00:00 A.M., or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCHours()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the milliseconds value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>The millisecond value returned can range from 0-999.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCMilliseconds()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the minutes value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>An integer between 0 and 59 equal to the number of minutes value in the Date object. A zero occurs in two situations: the time is less than one minute after the hour, or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCMinutes()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the month value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>An integer between 0 and 11 indicating the month value in the Date object. The integer returned is not the traditional number used to indicate the month. It is one less. If "Jan 5, 1996 08:47:00.0" is stored in a Date object, getUTCMonth returns 0.</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCMonth()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the seconds value in a Date object using Universal Coordinated Time (UTC).
		/// </summary>
		/// <returns>An integer between 0 and 59 indicating the seconds value of the indicated Date object. A zero occurs in two situations: the time is less than one second into the current minute, or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and hours for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object..</returns>
		[JsMethod(NativeOverloads = true)]
		public int getUTCSeconds()
		{
			throw new NotImplementedException();
		}

		///// <summary>
		///// Returns the VT_DATE value in a Date object.
		///// </summary>
		//public int getVarDate()
		//{
		//  throw new NotImplementedException();
		//}


		/// <summary>
		/// Returns the year value in a Date object. This method is obsolete, and is provided for backwards compatibility only. Use the getFullYear method instead. For the years 1900 though 1999, the year is a 2-digit integer value returned as the difference between the stored year and 1900. For dates outside that period, the 4-digit year is returned. For example, 1996 is returned as 96, but 1825 and 2025 are returned as-is.
		/// </summary>
		[Obsolete]
		[JsMethod(NativeOverloads = true)]
		public int getYear()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Parses a string containing a date, and returns the number of milliseconds between that date and midnight, January 1, 1970.
		/// </summary>
		/// <param name="dateVal">Either a string containing a date in a format such as "Jan 5, 1996 08:47:00" or a VT_DATE value retrieved from an ActiveX® object or other object.</param>
		/// <returns>An integer value representing the number of milliseconds between midnight, January 1, 1970 and the date supplied in dateVal.</returns>
		[JsMethod(NativeOverloads = true)]
		public static int Parse(string dateVal)
		{
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// Sets the numeric day-of-the-month value of the Date object using local time.
		/// </summary>
		/// <param name="numDate">A numeric value equal to the day of the month.</param>
		[JsMethod(NativeOverloads = true)]
		public void setDate(int numDate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the year value in the Date object using local time.
		/// </summary>
		/// <param name="numYear">A numeric value equal to the year.</param>
		[JsMethod(NativeOverloads = true)]
		public void setFullYear(int numYear)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the year value in the Date object using local time.
		/// </summary>
		/// <param name="numYear">A numeric value equal to the year.</param>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		[JsMethod(NativeOverloads = true)]
		public void setFullYear(int numYear, int numMonth)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the year value in the Date object using local time.
		/// </summary>
		/// <param name="numYear">A numeric value equal to the year.</param>
		/// <param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		/// <param name="numdate">A numeric value equal to the day of the month.</param>
		[JsMethod(NativeOverloads = true)]
		public void setFullYear(int numYear, int numMonth, int numdate)
		{
			throw new NotImplementedException();
		}


	}


	

}
