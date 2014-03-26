// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.mobile.core;

namespace qx.ui.mobile.container
{
    /// <summary>
	/// <para>The Composite is a generic container widget.</para>
	/// <para>It exposes all methods to set layouts and to manage child widgets
	/// as public methods. You must configure this widget with a layout manager to
	/// define the way the widget&#8217;s children are positioned.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// // create the composite
	/// var composite = new qx.ui.mobile.container.Composite()
	/// composite.setLayout(new qx.ui.mobile.layout.HBox());
	/// // add some children
	/// composite.add(new qx.ui.mobile.basic.Label("Name: "), {flex:1});
	/// composite.add(new qx.ui.mobile.form.TextField());
	/// this.getRoot().add(composite);
	/// </code>
	/// <para>This example horizontally groups a label and text field by using a
	/// Composite configured with a horizontal box layout as a container.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.container.Composite", OmitOptionalParameters = true, Export = false)]
    public partial class Composite : qx.ui.mobile.core.Widget
    {
		#region Methods

		public Composite() { throw new NotImplementedException(); }

		/// <param name="layout">The layout that should be used for this container</param>
		public Composite(qx.ui.mobile.layout.Abstract layout = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// </summary>
		/// <param name="child">the widget to add.</param>
		/// <param name="layoutProperties">Optional layout data for widget.</param>
		[JsMethod(Name = "add")]
		public void Add(Widget child, object layoutProperties = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget after another already inserted widget</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="after">Widget, after which the new widget will be inserted</param>
		/// <param name="layoutProperties">Optional layout data for widget.</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(Widget child, Widget after, object layoutProperties = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a child widget at the specified index</para>
		/// </summary>
		/// <param name="child">widget to add</param>
		/// <param name="index">Index, at which the widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(Widget child, double index, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget before another already inserted widget</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="before">Widget before the new widget will be inserted.</param>
		/// <param name="layoutProperties">Optional layout data for widget.</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(Widget child, Widget before, object layoutProperties = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the children list</para>
		/// </summary>
		/// <returns>The children array (Arrays are reference types, please to not modify them in-place)</returns>
		[JsMethod(Name = "getChildren")]
		public Widget GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the widget contains children.</para>
		/// </summary>
		/// <returns>Returns true when the widget has children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the index position of the given widget if it is
		/// a child widget. Otherwise it returns -1.</para>
		/// </summary>
		/// <param name="child">the widget to query for</param>
		/// <returns>The index position or -1 when the given widget is no child of this layout.</returns>
		[JsMethod(Name = "indexOf")]
		public double IndexOf(Widget child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the given child widget.</para>
		/// </summary>
		/// <param name="child">the widget to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(Widget child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all children.</para>
		/// </summary>
		[JsMethod(Name = "removeAll")]
		public void RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the widget at the specified index.</para>
		/// </summary>
		/// <param name="index">Index of the widget to remove.</param>
		[JsMethod(Name = "removeAt")]
		public void RemoveAt(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mapping of protected methods to public.
		/// This omits an additional function call when using these methods. Call
		/// this methods in the defer block of the including class.</para>
		/// </summary>
		/// <param name="members">The including classes members map</param>
		[JsMethod(Name = "remap")]
		public static void Remap(object members) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget&#8217;s layout manager.</para>
		/// </summary>
		/// <returns>The widget&#8217;s layout manager</returns>
		[JsMethod(Name = "getLayout")]
		public qx.ui.mobile.layout.Abstract GetLayout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set a layout manager for the widget. A a layout manager can only be connected
		/// with one widget. Reset the connection with a previous widget first, if you
		/// like to use it in another widget instead.</para>
		/// </summary>
		/// <param name="layout">The new layout or null to reset the layout.</param>
		[JsMethod(Name = "setLayout")]
		public void SetLayout(qx.ui.mobile.layout.Abstract layout) { throw new NotImplementedException(); }

		#endregion Methods
    }
}