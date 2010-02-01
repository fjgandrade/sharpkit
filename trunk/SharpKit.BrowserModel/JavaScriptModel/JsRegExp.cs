using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel
{
	/// <summary>
	/// An object that contains a regular expression pattern along with flags that identify how to apply the pattern.
	/// re = /pattern/[flags]
	/// re = new RegExp("pattern"[,"flags"]) 
	/// </summary>
	[JsType(JsMode.Prototype, Export = false,Name = "RegExp")]
	public class JsRegExp : JsObject
	{
		/// <summary>
		/// An object that contains a regular expression pattern along with flags that identify how to apply the pattern.
		/// </summary>
		/// <param name="pattern">The regular expression pattern to use. If you use Syntax 1, delimit the pattern by "/" characters. If you use Syntax 2, enclose the pattern in quotation marks.</param>
		public JsRegExp(string pattern)
		{
		}

		/// <summary>
		/// An object that contains a regular expression pattern along with flags that identify how to apply the pattern.
		/// </summary>
		/// <param name="pattern">The regular expression pattern to use. If you use Syntax 1, delimit the pattern by "/" characters. If you use Syntax 2, enclose the pattern in quotation marks.</param>
		/// <param name="flags">Optional. Enclose flag in quotation marks if you use Syntax 2. Available flags, which may be combined, are:
		/// g (global search for all occurrences of pattern)
		/// i (ignore case)
		/// m (multiline search)</param>
		public JsRegExp(string pattern, string flags)
		{
		}

		[JsMethod(NativeOverloads=true)]
		public bool test(string ch)
		{
			throw new NotImplementedException();
		}

		//TODO: add methods and properties
		/// <summary>
		/// If the exec method does not find a match, it returns null. If it finds a match, exec returns an array, and the properties of the global RegExp object are updated to reflect the results of the match. Element zero of the array contains the entire match, while elements 1 – n contain any submatches that have occurred within the match. This behavior is identical to the behavior of the match method without the global flag (g) set. 
		/// If the global flag is set for a regular expression, exec searches the string beginning at the position indicated by the value of lastIndex. If the global flag is not set, exec ignores the value of lastIndex and searches from the beginning of the string. 
		/// </summary>
		/// <param name="text">The String object or string literal on which to perform the search</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public JsRegExpResult exec(string text)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// If the exec method does not find a match, it returns null. If it finds a match, exec returns an array, and the properties of the global RegExp object are updated to reflect the results of the match. Element zero of the array contains the entire match, while elements 1 – n contain any submatches that have occurred within the match. This behavior is identical to the behavior of the match method without the global flag (g) set. 
		/// If the global flag is set for a regular expression, exec searches the string beginning at the position indicated by the value of lastIndex. If the global flag is not set, exec ignores the value of lastIndex and searches from the beginning of the string. 
		/// </summary>
		/// <param name="text">The String object or string literal on which to perform the search</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public JsRegExpResult exec(JsString text)
		{
			throw new NotImplementedException();
		}
	}


	public class JsRegExpResult : JsArray<JsString>
	{
		/// <summary>
		/// Returns the string against which a regular expression search was performed. Read-only.
		/// </summary>
		public readonly string input;
		/// <summary>
		/// Returns the character position where the first successful match begins in a searched string. Read-only.
		/// </summary>
		public readonly int index;
		/// <summary>
		/// Returns the character position where the next match begins in a searched string.
		/// </summary>
		public readonly int lastIndex;

		/// <summary>
		/// Returns the last matched characters from any regular expression search. Read-only.
		/// </summary>
		public readonly string lastMatch; 

		/// <summary>
		/// Returns the last parenthesized submatch from any regular expression search, if any. Read-only.
		/// </summary>
		public readonly string lastParen;

		
		/// <summary>
		/// Returns the characters from the beginning of a searched string up to the position before the beginning of the last match. Read-only.
		/// </summary>
		public readonly string leftContext;

		/// <summary>
		/// Returns the characters from the position following the last match to the end of the searched string. Read-only.
		/// </summary>
		public readonly string rightContext;



		

		
	}
}
