// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.form;

namespace qx.ui.groupbox
{
    /// <summary>
	/// <para>A group box, which has a radio button near the legend.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.groupbox.RadioGroupBox", OmitOptionalParameters = true, Export = false)]
    public partial class RadioGroupBox : qx.ui.groupbox.GroupBox, qx.ui.form.IRadioItem, qx.ui.form.IExecutable, qx.ui.form.IBooleanForm, qx.ui.form.IModel
    {
		#region Events

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		/// <summary>
		/// <para>Fired when the widget is executed. Sets the &#8220;data&#8221; property of the
		/// event to the object that issued the command.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnExecute;

		/// <summary>
		/// <para>Fired when the model data changes</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Model property for storing additional information for the including
		/// object. It can act as value property on form items for example.</para>
		/// <para>Be careful using that property as this is used for the
		/// <see cref="qx.ui.form.MModelSelection"/> it has some restrictions:</para>
		/// <list type="bullet">
		/// <item>Don&#8217;t use equal models in one widget using the
		/// <see cref="qx.ui.form.MModelSelection"/>.</item>
		/// </list
		/// <list type="bullet">
		/// <item>Avoid setting only some model properties if the widgets are added to
		/// a <see cref="qx.ui.form.MModelSelection"/> widge.</item>
		/// </list
		/// <para>Both restrictions result of the fact, that the set models are deputies
		/// for their widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public object Model { get; set; }

		#endregion Properties

		#region Methods

		public RadioGroupBox() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Fire the &#8220;execute&#8221; event on the command.</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current set command of this executable.</para>
		/// </summary>
		/// <returns>The current set command.</returns>
		[JsMethod(Name = "getCommand")]
		public qx.ui.core.Command GetCommand() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the radiogroup, which manages this item</para>
		/// </summary>
		/// <returns>The radiogroup, which manages the item.</returns>
		[JsMethod(Name = "getGroup")]
		public qx.ui.form.RadioGroup GetGroup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the configured legend. Only used for RadioManager compatibility.</para>
		/// </summary>
		/// <returns>The configured legend.</returns>
		[JsMethod(Name = "getLabel")]
		public string GetLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public bool GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the command of this executable.</para>
		/// </summary>
		/// <param name="command">The command.</param>
		[JsMethod(Name = "setCommand")]
		public void SetCommand(qx.ui.core.Command command) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the radiogroup, which manages this item</para>
		/// </summary>
		/// <param name="value">The radiogroup, which should manage the item.</param>
		[JsMethod(Name = "setGroup")]
		public void SetGroup(qx.ui.form.RadioGroup value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the representative data for the item</para>
		/// </summary>
		/// <returns>The data.</returns>
		[JsMethod(Name = "getModel")]
		public object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the representative data to null.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the representative data for the item.</para>
		/// </summary>
		/// <param name="value">The data.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}