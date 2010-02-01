using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Contains information about the current URL. 
	/// </summary>
	public class HtmlWindowLocation
	{
		/// <summary>
		/// Sets or retrieves the entire URL as a string. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string href
		{
			get;
			private set;
		}

		/// <summary>
		/// reloads the current page.
		/// </summary>
		public void reload()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Sets or retrieves the subsection of the href property that follows the number sign (#).
		/// </summary>
		[JsProperty(NativeField = true)]
		public string hash
		{
			get;
			set;
		}

		/// <summary>
		/// Sets or retrieves the hostname and port number of the location or URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string host
		{
			get;
			set;
		}

	

		/// <summary>
		/// Sets or retrieves the host name part of the location or URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string hostname
		{
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the file name or path specified by the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string pathname
		{
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the port number associated with a URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string port
		{
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the protocol portion of a URL.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string protocol
		{
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the substring of the href property that follows the question mark.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string search
		{
			get;
			set;
		}

		/// <summary>
		/// Replaces the current document by loading another document at the specified URL.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public void assign(string url)
		{
		}

		/// <summary>
		///Replaces the current document by loading another document at the specified URL.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public void replace(string url)
		{
		}

		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public string resolveURL(string url)
		{
			throw new NotImplementedException();
		}
	}
}
