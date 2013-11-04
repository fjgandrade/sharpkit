// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.webfonts
{
    /// <summary>
	/// <para>Manages font-face definitions, making sure that each rule is only applied
	/// once.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.webfonts.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : qx.core.Object
    {
		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the preferred font format(s) for the currently used browser. Some
		/// browsers support multiple formats, e.g. WOFF and TTF or WOFF and EOT. In
		/// those cases, WOFF is considered the preferred format.</para>
		/// </summary>
		/// <returns>List of supported font formats ordered by preference or empty Array if none could be determined</returns>
		[JsMethod(Name = "getPreferredFormats")]
		public string GetPreferredFormats() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes a font&#8217;s font-face definition from the style sheet. This means
		/// the font will no longer be available and any elements using it will
		/// fall back to the their regular font-families.</para>
		/// </summary>
		/// <param name="familyName">font-family name</param>
		[JsMethod(Name = "remove")]
		public void Remove(string familyName) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the styleSheet element used for all web font definitions from the
		/// document. This means all web fonts declared by the manager will no longer
		/// be available and elements using them will fall back to their regular
		/// font-families</para>
		/// </summary>
		[JsMethod(Name = "removeStyleSheet")]
		public void RemoveStyleSheet() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds the necessary font-face rule for a web font to the document. Also
		/// creates a web font Validator (<see cref="qx.bom.webfonts.Validator"/>) that
		/// checks if the webFont was applied correctly.</para>
		/// </summary>
		/// <param name="familyName">Name of the web font</param>
		/// <param name="sourcesList">List of source URLs. For maximum compatibility, this should include EOT, WOFF and TTF versions of the font.</param>
		/// <param name="callback">Optional event listener callback that will be executed once the validator has determined whether the webFont was applied correctly. See qx.bom.webfonts.Validator#changeStatus</param>
		/// <param name="context">Optional context for the callback function</param>
		[JsMethod(Name = "require")]
		public void Require(string familyName, string sourcesList, Action<object> callback, object context) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.bom.webfonts.Manager GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}