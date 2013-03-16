// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.pane
{
    /// <summary>
	/// <para>The focus indicator widget</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.pane.FocusIndicator", OmitOptionalParameters = true, Export = false)]
    public partial class FocusIndicator : qx.ui.container.Composite
    {
		#region Properties

		/// <summary>
		/// <para>Table column, where the indicator is placed.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "column", NativeField = true)]
		public double Column { get; set; }

		/// <summary>
		/// <para>Table row, where the indicator is placed.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "row", NativeField = true)]
		public double Row { get; set; }

		[JsProperty(Name = "visibility", NativeField = true)]
		public object Visibility { get; set; }

		#endregion Properties

		#region Methods

		public FocusIndicator() { throw new NotImplementedException(); }

		/// <param name="scroller">The scroller, which contains this focus indicator</param>
		public FocusIndicator(Scroller scroller) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property column.</para>
		/// </summary>
		[JsMethod(Name = "getColumn")]
		public double GetColumn() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property row.</para>
		/// </summary>
		[JsMethod(Name = "getRow")]
		public double GetRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property column
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property column.</param>
		[JsMethod(Name = "initColumn")]
		public void InitColumn(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property row
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property row.</param>
		[JsMethod(Name = "initRow")]
		public void InitRow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Move the focus indicator to the given table cell.</para>
		/// </summary>
		/// <param name="col">The table column</param>
		/// <param name="row">The table row</param>
		[JsMethod(Name = "moveToCell")]
		public void MoveToCell(double? col = null, double? row = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property column.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetColumn")]
		public void ResetColumn() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property row.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRow")]
		public void ResetRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property column.</para>
		/// </summary>
		/// <param name="value">New value for property column.</param>
		[JsMethod(Name = "setColumn")]
		public void SetColumn(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property row.</para>
		/// </summary>
		/// <param name="value">New value for property row.</param>
		[JsMethod(Name = "setRow")]
		public void SetRow(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}