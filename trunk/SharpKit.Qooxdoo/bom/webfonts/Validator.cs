// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.webfonts
{
    /// <summary>
	/// <para>Checks whether a given font is available on the document and fires events
	/// accordingly.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.webfonts.Validator", OmitOptionalParameters = true, Export = false)]
    public partial class Validator : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired when the status of a web font has been determined. The event data
		/// is a map with the keys &#8220;family&#8221; (the font-family name) and &#8220;valid&#8221;
		/// (Boolean).</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeStatusEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The font-family this validator should check</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "fontFamily", NativeField = true)]
		public object FontFamily { get; set; }

		/// <summary>
		/// <para>Time in milliseconds from the beginning of the check until it is assumed
		/// that a font is not available</para>
		/// </summary>
		[JsProperty(Name = "timeout", NativeField = true)]
		public double Timeout { get; set; }

		#endregion Properties

		#region Methods

		public Validator() { throw new NotImplementedException(); }

		/// <param name="fontFamily">The name of the font to be verified</param>
		public Validator(string fontFamily) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the two common helper elements used for all size comparisons from
		/// the DOM</para>
		/// </summary>
		[JsMethod(Name = "removeDefaultHelperElements")]
		public static void RemoveDefaultHelperElements() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property fontFamily.</para>
		/// </summary>
		[JsMethod(Name = "getFontFamily")]
		public object GetFontFamily() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property timeout.</para>
		/// </summary>
		[JsMethod(Name = "getTimeout")]
		public double GetTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property fontFamily
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property fontFamily.</param>
		[JsMethod(Name = "initFontFamily")]
		public void InitFontFamily(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property timeout
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property timeout.</param>
		[JsMethod(Name = "initTimeout")]
		public void InitTimeout(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property fontFamily.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFontFamily")]
		public void ResetFontFamily() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property timeout.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTimeout")]
		public void ResetTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property fontFamily.</para>
		/// </summary>
		/// <param name="value">New value for property fontFamily.</param>
		[JsMethod(Name = "setFontFamily")]
		public void SetFontFamily(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property timeout.</para>
		/// </summary>
		/// <param name="value">New value for property timeout.</param>
		[JsMethod(Name = "setTimeout")]
		public void SetTimeout(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Validates the font</para>
		/// </summary>
		[JsMethod(Name = "validate")]
		public void Validate() { throw new NotImplementedException(); }

		#endregion Methods
    }
}