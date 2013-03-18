// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.tree.core;

namespace qx.ui.tree.provider
{
    /// <summary>
	/// <para>The provider implements the <see cref="qx.ui.virtual.core.IWidgetCellProvider"/>
	/// API, which can be used as delegate for the widget cell rendering and it
	/// provides a API to bind the model with the rendered item.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.tree.provider.WidgetProvider", OmitOptionalParameters = true, Export = false)]
    public partial class WidgetProvider : qx.core.Object, qx.ui.virtualx.core.IWidgetCellProvider, qx.ui.tree.provider.IVirtualTreeProvider
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Delegate"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeDelegate;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The name of the property, where the children are stored in the model.
		/// Instead of the <see cref="LabelPath"/> must the child property a direct
		/// property form the model instance.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "childProperty", NativeField = true)]
		public string ChildProperty { get; set; }

		/// <summary>
		/// <para>Delegation object, which can have one or more functions defined by the
		/// <see cref="qx.ui.tree.core.IVirtualTreeDelegate"/> interface.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "delegate", NativeField = true)]
		public object Delegate { get; set; }

		/// <summary>
		/// <para>A map containing the options for the icon binding. The possible keys
		/// can be found in the <see cref="qx.data.SingleValueBinding"/> documentation.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "iconOptions", NativeField = true)]
		public object IconOptions { get; set; }

		/// <summary>
		/// <para>The path to the property which holds the information that should be
		/// shown as an icon.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "iconPath", NativeField = true)]
		public string IconPath { get; set; }

		/// <summary>
		/// <para>A map containing the options for the label binding. The possible keys
		/// can be found in the <see cref="qx.data.SingleValueBinding"/> documentation.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "labelOptions", NativeField = true)]
		public object LabelOptions { get; set; }

		/// <summary>
		/// <para>The name of the property, where the value for the tree node/leaf label
		/// is stored in the model classes.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "labelPath", NativeField = true)]
		public string LabelPath { get; set; }

		#endregion Properties

		#region Methods

		public WidgetProvider() { throw new NotImplementedException(); }

		/// <param name="tree">tree to provide.</param>
		public WidgetProvider(qx.ui.tree.VirtualTree tree) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a layer for node and leaf rendering.</para>
		/// </summary>
		/// <returns>new layer.</returns>
		[JsMethod(Name = "createLayer")]
		public qx.ui.virtualx.layer.Abstract CreateLayer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a renderer for rendering.</para>
		/// </summary>
		/// <returns>new node renderer.</returns>
		[JsMethod(Name = "createRenderer")]
		public object CreateRenderer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method returns the configured cell for the given cell. The return
		/// value may be null to indicate that the cell should be empty.</para>
		/// </summary>
		/// <param name="row">The cell&#8217;s row index.</param>
		/// <param name="column">The cell&#8217;s column index.</param>
		/// <returns>The configured widget for the given cell.</returns>
		[JsMethod(Name = "getCellWidget")]
		public qx.ui.core.LayoutItem GetCellWidget(double row, double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns if the passed row can be selected or not.</para>
		/// </summary>
		/// <param name="row">row to select.</param>
		/// <returns>true when the row can be selected, false otherwise.</returns>
		[JsMethod(Name = "isSelectable")]
		public bool IsSelectable(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Release the given cell widget. Either pool or destroy the widget.</para>
		/// </summary>
		/// <param name="widget">The cell widget to pool.</param>
		[JsMethod(Name = "poolCellWidget")]
		public void PoolCellWidget(qx.ui.core.LayoutItem widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Styles a selected item.</para>
		/// </summary>
		/// <param name="row">row to style.</param>
		[JsMethod(Name = "styleSelectabled")]
		public void StyleSelectabled(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Styles a not selected item.</para>
		/// </summary>
		/// <param name="row">row to style.</param>
		[JsMethod(Name = "styleUnselectabled")]
		public void StyleUnselectabled(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper-Method for binding the default properties from the model to the
		/// target widget. The used default properties  depends on the passed item.</para>
		/// <para>This method should only be called in the <see cref="IVirtualTreeDelegate.BindItem"/>
		/// function implemented by the <see cref="Delegate"/> property.</para>
		/// </summary>
		/// <param name="item">The internally created and used node or leaf.</param>
		/// <param name="index">The index of the item (node or leaf).</param>
		[JsMethod(Name = "bindDefaultProperties")]
		public void BindDefaultProperties(qx.ui.core.Widget item, double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper-Method for binding a given property from the model to the target
		/// widget.</para>
		/// <para>This method should only be called in the <see cref="IVirtualTreeDelegate.BindItem"/>
		/// function implemented by the <see cref="Delegate"/> property.</para>
		/// </summary>
		/// <param name="sourcePath">The path to the property in the model. If you use an empty string, the whole model item will be bound.</param>
		/// <param name="targetProperty">The name of the property in the target widget.</param>
		/// <param name="options">The options to use for the binding.</param>
		/// <param name="targetWidget">The target widget.</param>
		/// <param name="index">The index of the current binding.</param>
		[JsMethod(Name = "bindProperty")]
		public void BindProperty(string sourcePath, string targetProperty, object options, qx.ui.core.Widget targetWidget, double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper-Method for binding a given property from the target widget to
		/// the model.
		/// This method should only be called in the
		/// <see cref="qx.ui.tree.core.IVirtualTreeDelegate.BindItem"/> function implemented by the
		/// <see cref="Delegate"/> property.</para>
		/// </summary>
		/// <param name="targetPath">The path to the property in the model.</param>
		/// <param name="sourceProperty">The name of the property in the target.</param>
		/// <param name="options">The options to use for the binding.</param>
		/// <param name="sourceWidget">The source widget.</param>
		/// <param name="index">The index of the current binding.</param>
		[JsMethod(Name = "bindPropertyReverse")]
		public void BindPropertyReverse(string targetPath, string sourceProperty, object options, qx.ui.core.Widget sourceWidget, double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property childProperty.</para>
		/// </summary>
		[JsMethod(Name = "getChildProperty")]
		public string GetChildProperty() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property delegate.</para>
		/// </summary>
		[JsMethod(Name = "getDelegate")]
		public object GetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconOptions.</para>
		/// </summary>
		[JsMethod(Name = "getIconOptions")]
		public object GetIconOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconPath.</para>
		/// </summary>
		[JsMethod(Name = "getIconPath")]
		public string GetIconPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property labelOptions.</para>
		/// </summary>
		[JsMethod(Name = "getLabelOptions")]
		public object GetLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property labelPath.</para>
		/// </summary>
		[JsMethod(Name = "getLabelPath")]
		public string GetLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property childProperty
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property childProperty.</param>
		[JsMethod(Name = "initChildProperty")]
		public void InitChildProperty(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property delegate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property delegate.</param>
		[JsMethod(Name = "initDelegate")]
		public void InitDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconOptions
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconOptions.</param>
		[JsMethod(Name = "initIconOptions")]
		public void InitIconOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconPath.</param>
		[JsMethod(Name = "initIconPath")]
		public void InitIconPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property labelOptions
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property labelOptions.</param>
		[JsMethod(Name = "initLabelOptions")]
		public void InitLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property labelPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property labelPath.</param>
		[JsMethod(Name = "initLabelPath")]
		public void InitLabelPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all bindings from all bounded items.</para>
		/// </summary>
		[JsMethod(Name = "removeBindings")]
		public void RemoveBindings() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property childProperty.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetChildProperty")]
		public void ResetChildProperty() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property delegate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDelegate")]
		public void ResetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconOptions.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconOptions")]
		public void ResetIconOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconPath")]
		public void ResetIconPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property labelOptions.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabelOptions")]
		public void ResetLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property labelPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabelPath")]
		public void ResetLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the name of the property, where the children are stored in the model.</para>
		/// </summary>
		/// <param name="value">The child property name.</param>
		[JsMethod(Name = "setChildProperty")]
		public void SetChildProperty(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property delegate.</para>
		/// </summary>
		/// <param name="value">New value for property delegate.</param>
		[JsMethod(Name = "setDelegate")]
		public void SetDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconOptions.</para>
		/// </summary>
		/// <param name="value">New value for property iconOptions.</param>
		[JsMethod(Name = "setIconOptions")]
		public void SetIconOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconPath.</para>
		/// </summary>
		/// <param name="value">New value for property iconPath.</param>
		[JsMethod(Name = "setIconPath")]
		public void SetIconPath(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property labelOptions.</para>
		/// </summary>
		/// <param name="value">New value for property labelOptions.</param>
		[JsMethod(Name = "setLabelOptions")]
		public void SetLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the name of the property, where the value for the tree folders label
		/// is stored in the model classes.</para>
		/// </summary>
		/// <param name="value">The label path.</param>
		[JsMethod(Name = "setLabelPath")]
		public void SetLabelPath(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}