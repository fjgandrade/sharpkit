using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel
{

	[JsType(JsMode.Prototype, Export = false, Name = "Function")]
	public class JsFunction : JsObject
	{
		public JsFunction(params string[] prmsAndBody)
		{
		}

		//public JsObject prototype;

		/// <summary>
		/// Calls a method of an object, substituting another object for the current object.
		/// </summary>
		/// <param name="thisArg">The object to be used as the current object.</param>
		/// <param name="args">List of arguments to be passed to the method.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public object call(object thisArg, params object[] args)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Calls a method of an object, substituting another object for the current object.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public object call()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Calls a method of an object, substituting another object for the current object.
		/// </summary>
		/// <param name="thisArg">The object to be used as the current object.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public object call(object thisArg)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Applies a method of an object, substituting another object for the current object.
		/// </summary>
		/// <param name="thisArg">The object to be used as the current object.</param>
		/// <param name="args">Array of arguments to be passed to the function.</param>
		/// <returns>The return value of the function</returns>
		[JsMethod(NativeOverloads = true)]
		public object apply(object thisArg, object[] args)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Applies a method of an object, substituting another object for the current object.
		/// </summary>
		/// <param name="obj">The object to be used as the current object.</param>
		/// <returns>The return value of the function</returns>
		[JsMethod(NativeOverloads = true)]
		public object apply(object obj)
		{
			throw new NotImplementedException();
		}

		//[JsMethod(Name = "", NativeOverloads = true)]
		//public object Invoke(params object[] prms)
		//{
		//  throw new NotImplementedException();
		//}
	}


	[JsDelegate(NativeFunction=true)]
	public delegate void JsAction();
	[JsDelegate(NativeFunction = true)]
	public delegate void JsAction<T>(T arg);
	[JsDelegate(NativeFunction = true)]
	public delegate void JsAction<T1, T2>(T1 arg1, T2 arg2);
	[JsDelegate(NativeFunction = true)]
	public delegate void JsAction<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
	[JsDelegate(NativeFunction = true)]
	public delegate void JsAction<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
	[JsDelegate(NativeFunction = true)]
	public delegate TResult JsFunc<TResult>();
	[JsDelegate(NativeFunction = true)]
	public delegate TResult JsFunc<T, TResult>(T arg);
	[JsDelegate(NativeFunction = true)]
	public delegate TResult JsFunc<T1, T2, TResult>(T1 arg1, T2 arg2);
	[JsDelegate(NativeFunction = true)]
	public delegate TResult JsFunc<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);
	[JsDelegate(NativeFunction = true)]
	public delegate TResult JsFunc<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

}
