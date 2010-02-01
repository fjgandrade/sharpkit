using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Represents a STYLE html node
	/// </summary>
	public class HtmlStyleElement : HtmlElement
	{
		internal HtmlStyleElement()
			: base()
		{
		}

		/// <summary>
		/// Sets or retrieves the MIME type of the object. e.g. 'text/css'
		/// </summary>
		[JsProperty(NativeField = true)]
		public string type { get; set; }

		/// <summary>
		/// Sets or retrieves the media type.
		/// </summary>
		/// <remarks>Possible values:
		/// screen - Output is intended for computer screens.
		/// print - Output is intended for printed material and for on-screen documents viewed in Print Preview mode.
		/// all - Default. Applies to all devices.</remarks>
		[JsProperty(NativeField = true)]
		public string media { get; set; }

		/// <summary>
		/// Retrieves the next object in the HTML hierarchy.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlElement owningElement { get; private set; }

		/// <summary>
		/// Retrieves the style sheet that imported the current style sheets.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlStyleElement parentStyleSheet { get; private set; }

		/// <summary>
		/// Retrieves whether the rule or style sheet is defined on the page or is imported.
		/// </summary>
		[JsProperty(NativeField = true)]
		public bool readOnly { get; private set; }

		/// <summary>
		/// Sets or retrieves the title of the style sheet.
		/// </summary>
		[JsProperty(NativeField = true)]
		public new string title { get; set; }

		/// <summary>
		/// Retrieves a collection of all the imported style sheets defined for the respective styleSheet object.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		public HtmlNodeCollection<HtmlStyleElement> imports { get; private set; }

		/// <summary>
		/// Retrieves a collection of page objects, which represent @page rules in a styleSheet.
		/// </summary>
		[JsProperty(NativeField = true)]
		public HtmlGenericCollection<HtmlStyleSheetPage> pages { get; private set; }

		/// <summary>
		/// Retrieves a collection of rules defined in a style sheet.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9,"Use cssRules in non-IE browsers.", PartiallySupportedRemark = "IE doesn't count @imports as rules, but splits up selectors like p#test, ul into two rules.")]
		public HtmlGenericCollection<HtmlCssRule> rules { get; private set; }

		/// <summary>
		/// Retrieves a collection of rules defined in a style sheet.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use rules in IE")]
		public HtmlGenericCollection<HtmlCssRule> cssRules { get; private set; }


		/// <summary>
		/// Creates a new rule for a style sheet.
		/// </summary>
		/// <param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
		/// <param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
		/// <param name="iIndex">Integer that specifies the zero-based position in the rules collection where the new style rule should be placed.
		/// -1 by Default. The rule is added to the end of the collection.</param>
		/// <returns>-1 (Reserved value)</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
		public int addRule(string cSelector, string cStyle, int iIndex)
		{
			return -1; //Reseved return value
		}

		/// <summary>
		/// Creates a new rule for a style sheet.
		/// </summary>
		/// <param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
		/// <param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
		/// <returns>-1 (Reserved value)</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
		public int addRule(string cSelector, string cStyle)
		{
			return -1; //Reseved return value
		}

		/// <summary>
		/// Inserts a new style rule into the current style sheet.
		/// </summary>
		/// <param name="rule">a string containing the rule to be inserted (selector and declaration).</param>
		/// <param name="index">a number representing the position to be inserted.</param>
		/// <returns>The index within the style sheet's rule collection of the newly inserted rule.</returns>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]		
		public ulong insertRule(string rule, int index)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Used to delete a rule from the style sheet.
		/// </summary>
		/// <param name="index">The index within the style sheet's rule list of the rule to remove.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public void deleteRule(ulong index)
		{
		}

		/// <summary>
		/// Deletes an existing style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
		/// </summary>
		/// <param name="iIndex">Integer that specifies the index value of the rule to be deleted from the style sheet.</param>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
		public void removeRule(int iIndex)
		{
		}

		/// <summary>
		/// Deletes the first style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
		public void removeRule()
		{
		}


		/// <summary>
		/// Sets or retrieves the persisted representation of the style rule.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
		[JsProperty(NativeField=true)]
		public string cssText { get; set; }


		/// <summary>
		/// Sets or retrieves a value that indicates whether the user can interact with the object.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		[JsProperty(NativeField = true)]
		public new bool disabled { get; set; }

		/// <summary>
		/// The URL of the linked style sheet.
		/// </summary>
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]		
		public string href 
		{ 
			get;
			[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]		
			set; 
		}

		/// <summary>
		/// Returns the node that associates this style sheet with the document. Usually a &lt;link&gt; or a &lt;style&gt; tag.
		/// </summary>
		[JsProperty(NativeField = true)]
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public HtmlNode ownerNode { get; private set; }

		/// <summary>
		/// Fires when an error occurs during object loading.
		/// </summary>		
		[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
		public HtmlDomEventHandler onerror;

		/// <summary>
		/// Fires immediately after the browser loads the object.
		/// </summary>		
		public HtmlDomEventHandler onload;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public bool scoped
		{
			get;
			set;
		}
	}
}
