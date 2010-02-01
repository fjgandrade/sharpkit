using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents a collection of HtmlNode objects
	/// </summary>
	public class HtmlNodeCollection : HtmlNodeCollection<HtmlNode>
	{
	}
	/// <summary>
	/// Represents a collection of HtmlElement objects
	/// </summary>
	public class HtmlElementCollection : HtmlNodeCollection<HtmlElement>
	{		
	}
	/// <summary>
	/// Represents a generic collection of HtmlNode objects
	/// </summary>
	public class HtmlNodeCollection<T> : IEnumerable, IEnumerable<T> where T : HtmlNode
	{
		public HtmlNodeCollection()
		{
		}

		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		internal void Append(T node)
		{
		}

		[JsMethod(IgnoreGenericArguments=true,NativeOverloads=true)]
		internal void InsertBefore(T newNode, T beforeNode)
		{
		}

		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		internal void AddFirstNode(T node)
		{
		}

		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		internal void Remove(T node)
		{
		}

		[JsProperty(NativeIndexer=true)]
		public T this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		[JsProperty(NativeIndexer = true)]
		public T this[string name]
		{
			get
			{
				throw new NotImplementedException();
			}		
		}

		#region IEnumerable<HtmlElement> Members

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion

		[JsProperty(NativeField=true)]
		public int length
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Access an item in an array
		/// </summary>
		/// <returns></returns>
		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public T item(int index)
		{
			throw new NotImplementedException();
		}
	}


	/// <summary>
	/// Represents a generic collection of HtmlNode objects
	/// </summary>
	public class HtmlGenericCollection<T> : IEnumerable, IEnumerable<T>
	{
		public HtmlGenericCollection()
		{
		}

		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		internal void Append(T node)
		{
		}

		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		internal void InsertBefore(T newNode, T beforeNode)
		{
		}

		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		internal void AddFirstNode(T node)
		{
		}

		[JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
		internal void Remove(T node)
		{
		}

		[JsProperty(NativeIndexer = true)]
		public T this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		[JsProperty(NativeIndexer = true)]
		public T this[string name]
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		#region IEnumerable<HtmlElement> Members

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion

		[JsProperty(NativeField = true)]
		public int length
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
