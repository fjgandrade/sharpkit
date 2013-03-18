// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.basic
{
    /// <summary>
	/// <para>The label widget displays a text or HTML content.
	/// Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var label = new qx.ui.mobile.basic.Label("Hello World");
	/// this.getRoot().add(label);
	/// </code>
	/// <para>This example create a widget to display the label.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.basic.Label", OmitOptionalParameters = true, Export = false)]
    public partial class Label : qx.ui.mobile.core.Widget
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Value"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Whether the widget should be the target of an event. Set this property
		/// to false when the widget is a child of another widget and
		/// shouldn&#8217;t react on events.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "anonymous", NativeField = true)]
		public bool Anonymous { get; set; }

		/// <summary>
		/// <para>The default CSS class used for this widget. The default CSS class
		/// should contain the common appearance of the widget.
		/// It is set to the container element of the widget. Use <see cref="AddCssClass"/>
		/// to enhance the default appearance of the widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public string DefaultCssClass { get; set; }

		/// <summary>
		/// <para>Text or HTML content to display</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "value", NativeField = true)]
		public string Value { get; set; }

		/// <summary>
		/// <para>Controls whether text wrap is activated or not.</para>
		/// </summary>
		[JsProperty(Name = "wrap", NativeField = true)]
		public bool Wrap { get; set; }

		#endregion Properties

		#region Methods

		public Label() { throw new NotImplementedException(); }

		/// <param name="value">Text or HTML content to display</param>
		public Label(string value = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property value.</para>
		/// </summary>
		[JsMethod(Name = "getValue")]
		public string GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property wrap.</para>
		/// </summary>
		[JsMethod(Name = "getWrap")]
		public bool GetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property value
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property value.</param>
		[JsMethod(Name = "initValue")]
		public void InitValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property wrap
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property wrap.</param>
		[JsMethod(Name = "initWrap")]
		public void InitWrap(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property wrap equals true.</para>
		/// </summary>
		[JsMethod(Name = "isWrap")]
		public void IsWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property value.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property wrap.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetWrap")]
		public void ResetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property value.</para>
		/// </summary>
		/// <param name="value">New value for property value.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property wrap.</para>
		/// </summary>
		/// <param name="value">New value for property wrap.</param>
		[JsMethod(Name = "setWrap")]
		public void SetWrap(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property wrap.</para>
		/// </summary>
		[JsMethod(Name = "toggleWrap")]
		public void ToggleWrap() { throw new NotImplementedException(); }

		#endregion Methods
    }
}