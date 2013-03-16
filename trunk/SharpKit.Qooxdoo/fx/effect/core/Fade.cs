// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.fx.effect.core
{
    /// <summary>
	/// <para>Core effect &#8220;Fade&#8221;</para>
	/// <para>Fades in the specified element: it changes to opacity from a given value to
	/// another. If target value is 0, it will hide the element, if value is 1, it
	/// will show it using the &#8220;display&#8221; property.
	/// You can toggle this behavior using the &#8220;modifyDisplay&#8221; property:
	/// <see cref="qx.fx.effect.core.Fade.ModifyDisplay"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.fx.effect.core.Fade", OmitOptionalParameters = true, Export = false)]
    public partial class Fade : qx.fx.Base
    {
		#region Properties

		/// <summary>
		/// <para>Initial opacity value.</para>
		/// </summary>
		[JsProperty(Name = "from", NativeField = true)]
		public object From { get; set; }

		/// <summary>
		/// <para>Flag indicating if the CSS attribute &#8220;display&#8221;
		/// should be modified by effect</para>
		/// </summary>
		[JsProperty(Name = "modifyDisplay", NativeField = true)]
		public bool ModifyDisplay { get; set; }

		/// <summary>
		/// <para>Final opacity value.</para>
		/// </summary>
		[JsProperty(Name = "to", NativeField = true)]
		public object To { get; set; }

		#endregion Properties

		#region Methods

		public Fade() { throw new NotImplementedException(); }

		[JsMethod(Name = "afterFinishInternal")]
		public void AfterFinishInternal() { throw new NotImplementedException(); }

		[JsMethod(Name = "beforeSetup")]
		public void BeforeSetup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "getModifyDisplay")]
		public bool GetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property modifyDisplay
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property modifyDisplay.</param>
		[JsMethod(Name = "initModifyDisplay")]
		public void InitModifyDisplay(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property modifyDisplay equals true.</para>
		/// </summary>
		[JsMethod(Name = "isModifyDisplay")]
		public void IsModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property modifyDisplay.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModifyDisplay")]
		public void ResetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property modifyDisplay.</para>
		/// </summary>
		/// <param name="value">New value for property modifyDisplay.</param>
		[JsMethod(Name = "setModifyDisplay")]
		public void SetModifyDisplay(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "toggleModifyDisplay")]
		public void ToggleModifyDisplay() { throw new NotImplementedException(); }

		[JsMethod(Name = "update")]
		public void Update(object position) { throw new NotImplementedException(); }

		#endregion Methods
    }
}