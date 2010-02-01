using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using System.Collections;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// A collection of attributes of an object.
	/// </summary>
	[JsType(NativeEnumerator=true)]
	public class HtmlAttributeCollection : IEnumerable, IEnumerable<HtmlAttribute>
	{
		public HtmlAttributeCollection()
		{
		}

		/// <summary>
		/// Sets or retrieves the number of objects in a collection.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int length
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		internal void Add(HtmlAttribute attribute)
		{
		}

		/// <summary>
		/// Gets an attribute for an element from the attributes collection.
		/// </summary>
		/// <param name="index">Integer that specifies the attribute. It is the zero-based index of the attribute to be retrieved from the attributes collection.</param>
		/// <returns>Returns an attribute for an element from the attributes collection</returns>
		[JsProperty(NativeIndexer = true)]
		[SupportedBrowsers(BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Firefox and IE8 try to create a list in source code order, but the order is off.
IE5-7 takes the second possible attribute of node x (dataFld in the test), whether it's defined or not. Therefore it consists of all attributes that can possibly be defined on the node (84 all in all).
IE 5.5 initially gives the value of the attribute; not the attribute object.")]
		public HtmlAttribute this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
			internal set
			{				
			}
		}

		/// <summary>
		/// Gets an attribute for an element from the attributes collection.
		/// </summary>
		/// <param name="name">String that specifies the attribute. The attribute whose name matches the string is retrieved.</param>
		/// <returns>Returns an attribute for an element from the attributes collection</returns>
		[JsProperty(NativeIndexer = true)]
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE5-7 doesn't return the value of a style attribute.
IE 5.5 doesn't return custom attributes, and initially gives the attribute value instead of an attribute object.")]
		public HtmlAttribute this[string name]
		{
			get
			{
				throw new NotImplementedException();
			}
			internal set
			{						
			}
		}

		public IEnumerator<HtmlAttribute> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
