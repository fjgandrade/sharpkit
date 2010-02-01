using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Denotes a list box or drop-down list.
	/// </summary>
	public class HtmlSelect : HtmlElement
	{
		/// <summary>
		/// Fires when the contents of the object or selection have changed.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.")]
		public HtmlDomEventHandler onchange;

		[JsProperty(NativeField = true)]
		public HtmlNodeCollection<HtmlOption> options
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool multiple { get; set; }

		/// <summary>
		/// Sets or retrieves the index of the selected option in a select object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int selectedIndex { get; set; }

		/// <summary>
		/// Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFld { get; set; }

		/// <summary>
		/// Sets or retrieves the rendering format for the data supplied to the object.
		/// Possible values:
		///	text						Default. Data is rendered as text.
		/// html						Data is rendered as HTML.
		/// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFormatAs { get; set; }

		/// <summary>
		/// Sets or retrieves the source of the data for data binding.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataSrc { get; set; }

		/// <summary>
		/// Retrieves a reference to the form that the object is embedded in.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string form { get; set; }


		/// <summary>
		/// Sets or retrieves the number of objects in a collection.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int length { get; set; }

		/// <summary>
		/// Sets or retrieves the name of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string name { get; set; }

		/// <summary>
		/// Sets or retrieves the number of rows in the list box.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string size { get; set; }


		/// <summary>
		/// Retrieves the type of select control based on the value of the MULTIPLE attribute.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string type { get; set; }

		/// <summary>
		/// Sets or retrieves the value which is returned to the server when the form control is submitted.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string value { get; set; }

		/// <summary>
		/// Adds an option element to the options collection of a select object.
		/// </summary>
		/// <param name="newOption">An HTMLOptionElement to add to the options collection.</param>
		/// <param name="existingOption">An existing HTMLOptionElement within the collection used as a reference point for inserting the new element; the new element being inserted before the referenced element in the collection.  If this parameter is null, the new element is appended to the end of the collection.</param>
		[SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void add(HtmlOption newOption, HtmlOption existingOption)
		{
		}

		/// <summary>
		/// Adds an option element to the options collection of a select object.
		/// </summary>
		/// <param name="newOption">An HTMLOptionElement to add to the options collection.</param>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void add(HtmlOption newOption)
		{
		}

		/// <summary>
		/// Adds an option element to the options collection of a select object.
		/// </summary>
		/// <param name="newOption">An HTMLOptionElement to add to the options collection.</param>
		/// <param name="index">Integer that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsMethod(NativeOverloads = true)]
		public void add(HtmlOption newOption, int index)
		{
		}

		/// <summary>
		/// Removes an element from the collection.
		/// </summary>
		/// <param name="iIndex">Integer that specifies the zero-based index of the element to remove from the collection.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void remove(int iIndex)
		{
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool autofocus
		{
			get;
			set;
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public object item(ulong index)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public object namedItem(string name)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public HtmlElementCollection selectedOptions
		{
			get;
			private set;
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool willValidate
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ValidityState validity
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string validationMessage
		{
			get;
			private set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public bool checkValidity()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void setCustomValidity(string error)
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public NodeList labels
		{
			get;
			private set;
		}
	}
}
