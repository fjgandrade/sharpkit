// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.controller.website
{
    /// <summary>
	/// website List Controller
	/// <para>General idea
	/// The list controller is responsible for synchronizing data given as model
	/// to a DOM element. As definition for a single item, tempaltes are used. More
	/// details on tempaltes can be found in <see cref="qx.bom.Template"/>.</para>
	/// <para>Features</para>
	/// <list type="bullet">
	/// <item>Synchronize the model and the target</item>
	/// <item>Filtering</item>
	/// </list
	/// <para>Usage</para>
	/// <para>As model, <see cref="qx.data.Array"/>s and plain JavaScript Arrays work. As a
	/// Target, you have to use a DOM element e.g. a plain DIV element. Make sure
	/// you have the template you are referencing in the DOM.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.controller.website.List", OmitOptionalParameters = true, Export = false)]
    public partial class List : qx.core.Object
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Delegate"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeDelegate;

		/// <summary>
		/// Fired on change of the property <see cref="Model"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		/// <summary>
		/// Fired on change of the property <see cref="Target"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeTarget;

		/// <summary>
		/// Fired on change of the property <see cref="TemplateId"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeTemplateId;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The delegate for the list conotroller which supports almost all methods
		/// documented in <see cref="qx.data.controller.IControllerDelegate"/> except
		/// bindItem.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "delegate", NativeField = true)]
		public object Delegate { get; set; }

		/// <summary>
		/// <para>Array containing the data which should be shown in the list.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public JsArray Model { get; set; }

		/// <summary>
		/// <para>The target DOM node which should show the data.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "target", NativeField = true)]
		public qx.html.Element Target { get; set; }

		/// <summary>
		/// <para>The id of the template which should be use. Check out
		/// <see cref="qx.bom.Template"/> for details on templating.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "templateId", NativeField = true)]
		public object TemplateId { get; set; }

		#endregion Properties

		#region Methods

		public List() { throw new NotImplementedException(); }

		/// <param name="model">The mode which can either be a native array or a qooxdoo data list. Maps to the model property.</param>
		/// <param name="target">A DOM element which should is the target for the generation.</param>
		/// <param name="templateId">The id of the template.</param>
		public List(object model, qx.html.Element target, string templateId) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property delegate.</para>
		/// </summary>
		[JsMethod(Name = "getDelegate")]
		public object GetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property model.</para>
		/// </summary>
		[JsMethod(Name = "getModel")]
		public JsArray GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property target.</para>
		/// </summary>
		[JsMethod(Name = "getTarget")]
		public qx.html.Element GetTarget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property templateId.</para>
		/// </summary>
		[JsMethod(Name = "getTemplateId")]
		public object GetTemplateId() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property delegate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property delegate.</param>
		[JsMethod(Name = "initDelegate")]
		public void InitDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property target
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property target.</param>
		[JsMethod(Name = "initTarget")]
		public void InitTarget(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property templateId
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property templateId.</param>
		[JsMethod(Name = "initTemplateId")]
		public void InitTemplateId(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property delegate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDelegate")]
		public void ResetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property model.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property target.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTarget")]
		public void ResetTarget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property templateId.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTemplateId")]
		public void ResetTemplateId() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property delegate.</para>
		/// </summary>
		/// <param name="value">New value for property delegate.</param>
		[JsMethod(Name = "setDelegate")]
		public void SetDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property model.</para>
		/// </summary>
		/// <param name="value">New value for property model.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(JsArray value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property target.</para>
		/// </summary>
		/// <param name="value">New value for property target.</param>
		[JsMethod(Name = "setTarget")]
		public void SetTarget(qx.html.Element value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property templateId.</para>
		/// </summary>
		/// <param name="value">New value for property templateId.</param>
		[JsMethod(Name = "setTemplateId")]
		public void SetTemplateId(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This is the main method which will take the data from the model and
		/// push it to the target view. If you are using a plain Array as model,
		/// you need to call that method every time you want to see the changed model
		/// in the view while using <see cref="qx.data.Array"/>s will do that
		/// automatically for you.
		/// This method also attaches to every created DOM element the model object
		/// which was used to create it at .$model.</para>
		/// </summary>
		[JsMethod(Name = "update")]
		public void Update() { throw new NotImplementedException(); }

		#endregion Methods
    }
}