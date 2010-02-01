using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

	///// <summary>
	///// 6.5.6.1 Event handlers
	///// </summary>
	[JsType(Export = false,Name = "WindowTimers", NativeConstructors = true, NativeEnumerator = true)]
	public interface WindowTimers
	{
		/// <summary>
		/// Invokes a method after a specified number of milliseconds has elapsed. 
		/// </summary>
		/// <param name="action">a JsFunction to invoke</param>
		/// <param name="ms">Delay, in milliseconds, before invoking the method</param>
		/// <returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		int setTimeout(JsFunction action, int ms);
		
		/// <summary>
		/// Invokes a method after a specified number of milliseconds has elapsed. 
		/// </summary>
		/// <param name="action">a JsFunction to invoke</param>
		/// <param name="ms">Delay, in milliseconds, before invoking the method</param>
		/// <returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		int setTimeout(Action action, int ms);

		/// <summary>
		/// Cancels a time-out that was set with the setTimeout method. 
		/// </summary>
		/// <param name="id">Required. Integer that specifies the time-out setting returned by a previous call to the setTimeout method.</param>
		[JsMethod(NativeOverloads = true)]
		void clearTimeout(int id);

		[JsMethod(NativeOverloads = true)]
		int setInterval(JsFunction func, int ms);

		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		int setInterval(Action func, int ms);

		[JsMethod(NativeOverloads = true)]
		int clearInterval(int ms);
	}

}
