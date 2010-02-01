using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using System.ComponentModel;

namespace SharpKit.JavaScriptModel
{
	public static class JsExtensions
	{
		/// <summary>
		/// Allows converting an object to a different type without affecting the generated javascript code.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj"></param>
		/// <returns></returns>
		[JsMethod(OmitCalls = true)]
		public static T As<T>(this object obj)
		{
			return (T)obj;
		}
	}
}
