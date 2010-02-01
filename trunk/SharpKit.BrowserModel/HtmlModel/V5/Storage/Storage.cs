using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Each Storage object provides access to a list of key/value pairs, which are sometimes called items. Keys are strings. Any string (including the empty string) is a valid key. Values can be any data type supported by the structured clone algorithm.
	/// </summary>
	[HtmlSpecificationVersion(5)]
	[JsType(Export = false, Name = "Storage")]
	public interface Storage
	{
		/// <summary>
		/// Returns the number of key/value pairs currently present in the list associated with the object.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		ulong length { get; }

		/// <summary>
		/// Returns the name of the nth key in the list. The order of keys is user-agent defined, but may change when adding or removing keys.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		[HtmlSpecificationVersion(5)]
		string key(ulong index);

		/// <summary>
		/// Returns a structured clone of the current value associated with the given key. If the given key does not exist in the list associated with the object then returns null.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		[HtmlSpecificationVersion(5)]
		object getItem(string key);

		/// <summary>
		/// This method adds a new key/value pair to the list. The data is first cloned.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="data"></param>
		[JsMethod(NativeOverloads = true)]
		[HtmlSpecificationVersion(5)]
		void setItem(string key, object data);

		/// <summary>
		/// Removes a key/value pair with the given key from the list. If no item with that key exists, the method does nothing.
		/// </summary>
		/// <param name="key"></param>
		[JsMethod(NativeOverloads = true)]
		[HtmlSpecificationVersion(5)]
		void removeItem(string key);

		/// <summary>
		/// The clear() method must atomically cause the list associated with the object to be emptied of all key/value pairs, if there are any. If there are none, then the method must do nothing.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[HtmlSpecificationVersion(5)]
		void clear();
	}
}
