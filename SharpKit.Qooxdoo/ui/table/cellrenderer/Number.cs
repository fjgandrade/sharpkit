// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.cellrenderer
{
    /// <summary>
	/// <para>Specific data cell renderer for numbers.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.cellrenderer.Number", OmitOptionalParameters = true, Export = false)]
    public partial class Number : qx.ui.table.cellrenderer.Conditional
    {
		#region Properties

		/// <summary>
		/// <para>NumberFormat used to format data. If the numberFormat contains a
		/// prefix and/or postfix containing characters which needs to be escaped,
		/// those need to be given to the numberFormat in their escaped form
		/// because no escaping happens at the cellrenderer level.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "numberFormat", NativeField = true)]
		public qx.util.format.NumberFormat NumberFormat { get; set; }

		#endregion Properties

		#region Methods

		public Number() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property numberFormat.</para>
		/// </summary>
		[JsMethod(Name = "getNumberFormat")]
		public qx.util.format.NumberFormat GetNumberFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property numberFormat
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property numberFormat.</param>
		[JsMethod(Name = "initNumberFormat")]
		public void InitNumberFormat(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property numberFormat.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetNumberFormat")]
		public void ResetNumberFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property numberFormat.</para>
		/// </summary>
		/// <param name="value">New value for property numberFormat.</param>
		[JsMethod(Name = "setNumberFormat")]
		public void SetNumberFormat(qx.util.format.NumberFormat value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}