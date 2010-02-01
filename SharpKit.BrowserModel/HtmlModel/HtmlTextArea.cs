using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	public class HtmlTextArea: HtmlElement
	{
		/// <summary>
		/// Sets or retrieves the number of horizontal rows contained in the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int rows { get; set; }

		/// <summary>
		/// Sets or retrieves the width of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int cols { get; set; }

		/// <summary>
		/// Sets or retrieves how to handle wordwrapping in the object. 
		/// Possible values:
		///	soft	Default. Text is displayed with wordwrapping and submitted without carriage returns and line feeds. 
		/// hard	Text is displayed with wordwrapping and submitted with soft returns and line feeds. 
		/// off		Wordwrapping is disabled. The lines appear exactly as the user types them. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public string wrap { get; set; }

		/// <summary>
		/// Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataFld { get; set; }

		/// <summary>
		/// Sets or retrieves the source of the data for data binding.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string dataSrc { get; set; }











		/// <summary>
		/// Sets or retrieves a comma-separated list of content types.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string accept { get; set; }

		/// <summary>
		/// Sets or retrieves how the object is aligned with adjacent text.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string align { get; set; }

		/// <summary>
		/// Sets or retrieves a text alternative to the graphic.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string alt { get; set; }

		/// <summary>
		/// Sets or retrieves the state of the check box or radio button.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool @checked { get; set; }

		/// <summary>
		/// Retrieves whether the object is fully loaded.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string complete { get; set; }

		/// <summary>
		/// Sets or retrieves the initial contents of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string defaultValue { get; set; }

		/// <summary>
		/// Sets or retrieves the state of the check box or radio button.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string defaultChecked { get; set; }

		/// <summary>
		/// Retrieves a reference to the form that the object is embedded in.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string form { get; set; }

		/// <summary>
		/// Sets or retrieves a lower resolution image to display.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string lowsrc { get; set; }

		/// <summary>
		/// Sets or retrieves the number of times a sound or video clip will loop when activated.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string loop { get; set; }

		/// <summary>
		/// Sets or retrieves the horizontal margin for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string hspace { get; set; }

		/// <summary>
		/// Sets or retrieves the vertical margin for the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string vspace { get; set; }


		/// <summary>
		/// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string useMap { get; set; }

		/// <summary>
		/// Sets or retrieves the value indicated whether the content of the object is read-only.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string readOnly { get; set; }


		/// <summary>
		/// Sets or retrieves the size of the control.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string size { get; set; }

		/// <summary>
		/// Sets or retrieves a URL to be loaded by the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string src { get; set; }

		/// <summary>
		/// Sets or retrieves when a video clip file should begin playing.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string start { get; set; }

		/// <summary>
		/// Sets or retrieves the calculated width of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string width { get; set; }


		/// <summary>
		/// Sets or retrieves the value indicating whether the control is selected.
		/// Possible values:
		///	false	Default. Control is not selected.
		/// true	Control is selected.
		/// null	Control is not initialized.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool status { get; set; }

		/*
DATAFLD	dataFld	 Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
DATAFORMATAS	dataFormatAs	 Sets or retrieves the rendering format for the data supplied to the object.
DATASRC	dataSrc	 Sets or retrieves the source of the data for data binding.
DYNSRC	dynsrc	 Sets or retrieves the address of a video clip or VRML world to display in the window.
vrml	 Sets or retrieves the URL of the virtual reality modeling language (VRML) world to be displayed in the window.
 	indeterminate	 Sets or retrieves whether the user has changed the status of a check box.

		*/

		/// <summary>
		/// Sets or retrieves the name of the object.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string name { get; set; }

		/// <summary>
		/// Retrieves the file name of the input object after the text is set by user input.
		/// </summary>
		[JsProperty(NativeField = true)]
		public string value { get; set; }

		/// <summary>
		/// Retrieves or initially sets the type of input control represented by the object.
		/// </summary>
		//[DisplayName("type")]
		//[PossibleControlAttributeValues("button,checkbox,file,hidden,image,password,radio,reset,submit,text")]
		[JsProperty(NativeField = true)]
		public string type { get; set; }
		/// <summary>
		/// Highlights the input area of a form element.
		/// </summary>
		public void select()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a TextRange object for the element.
		/// Use a text range to examine and modify the text within an object.
		/// </summary>
		/// <returns>Returns a TextRange object if successful, or null otherwise.</returns>
		public HtmlTextRange createTextRange()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Sets or retrieves the maximum number of characters that the user can enter in a text control. 
		/// </summary>
		[JsProperty(NativeField = true)]
		public int maxLength { get; set; }

		/// <summary>
		/// Fires when the contents of the object or selection have changed.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = "IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.")]
		public HtmlDomEventHandler onchange;

		/// <summary>
		/// Fires when the current selection changes.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public HtmlDomEventHandler onselect;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool autofocus
		{
			get;
			set;
		}

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string placeholder
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool required
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong textLength
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
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong selectionStart
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong selectionEnd
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void setSelectionRange(ulong start, ulong end)
		{
			throw new NotImplementedException();
		}
	}
}
