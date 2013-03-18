// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.progressive
{
    /// <summary>
	/// Progressive.
	/// <para>Follow progressive instructions provided by a data model.  A variable
	/// number of instructions are executed at one time, after which control is
	/// returned briefly to the browser.  This allows browser rendering between
	/// batches of instructions, improving the visual experience.</para>
	/// Progressive may be used for various purposes.  Two predefined
	/// purposes for which "renderers" are provided, are a progressively-rendered
	/// table which allows variable row height, and a program load/initialization
	/// renderer with progress bar.  (Note that the term "renderer" is interpreted
	/// quite broadly.  A renderer needn't actually render; rather it is just some
	/// set of activities that takes place at one time, e.g a row of table data or
	/// a single widget added to the document or a sending a request to a server,
	/// etc.)
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.progressive.Progressive", OmitOptionalParameters = true, Export = false)]
    public partial class Progressive : qx.ui.container.Composite
    {
		#region Events

		/// <summary>
		/// <para>This event is fired after each batch of elements is rendered, and
		/// control is about to be yielded to the browser.  This is an appropriate
		/// event to listen for, to implement a progress bar.</para>
		/// <para>The event data is an object with the following members:
		/// 
		/// initial
		/// 
		/// The number of elements that were available at the start of this
		/// rendering request.
		/// </para>
		/// remaining
		/// 
		/// The number of elements still remaining to be rendered.
		/// 
		/// 
		/// </summary>
		public event Action<qx.eventx.type.Data> OnProgress;

		/// <summary>
		/// <para>This event is fired after each element is rendered.</para>
		/// <para>The event data is an object with the following members:
		/// 
		/// initial
		/// 
		/// The number of elements that were available at the start of this
		/// rendering request.
		/// </para>
		/// remaining
		/// 
		/// The number of elements still remaining to be rendered.
		/// 
		/// element
		/// 
		/// The object, returned by the data model's getNextElement() method,
		/// that was just rendered.
		/// 
		/// 
		/// <para>Note: Unless batchSize is set to 1 or we happen to be at the end of a
		/// batch, widgets will not be rendered at this time.  Use this event
		/// for programmatically processing rendered elements, but not for
		/// such things as progress bars.  Instead, where only user-visible
		/// changes such as progress bars are being updated, use the
		/// &#8220;progress&#8221; event.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnProgressDetail;

		/// <summary>
		/// <para>Event fired when rendering ends.  The data is the state object.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnRenderEnd;

		/// <summary>
		/// <para>Event fired when rendering begins.</para>
		/// <para>The event data is an object with the following members:
		/// 
		/// state
		/// 
		/// The state object.
		/// </para>
		/// initial
		/// The number of elements that are available to be rendered
		/// 
		/// 
		/// 
		/// </summary>
		public event Action<qx.eventx.type.Data> OnRenderStart;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Number of elements to render at one time.  After this number of
		/// elements has been rendered, control will be yielded to the browser
		/// allowing the elements to actually be displayed.  A short-interval timer
		/// will be set, to regain control to render the next batch of elements.</para>
		/// </summary>
		[JsProperty(Name = "batchSize", NativeField = true)]
		public double BatchSize { get; set; }

		/// <summary>
		/// <para>The data model.</para>
		/// </summary>
		[JsProperty(Name = "dataModel", NativeField = true)]
		public qx.ui.progressive.model.Abstract DataModel { get; set; }

		/// <summary>
		/// <para>Flush the widget queue after each batch is rendered.  This is
		/// particularly relevant for such things as progressive loading, where
		/// the whole purpose is to be able to see the loading progressing.</para>
		/// </summary>
		[JsProperty(Name = "flushWidgetQueueAfterBatch", NativeField = true)]
		public bool FlushWidgetQueueAfterBatch { get; set; }

		/// <summary>
		/// <para>Delay between rendering elements. Zero is normally adequate, but
		/// there are times that the user wants more time between rendering
		/// some elements.</para>
		/// </summary>
		[JsProperty(Name = "interElementTimeout", NativeField = true)]
		public double InterElementTimeout { get; set; }

		#endregion Properties

		#region Methods

		public Progressive() { throw new NotImplementedException(); }

		/// <param name="structure">The structure of the Progressive pane.</param>
		public Progressive(qx.ui.progressive.structure.Abstract structure) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a renderer that can be referenced by the data model.</para>
		/// </summary>
		/// <param name="name">Name referenced in the data model when this renderer is to be used.</param>
		/// <param name="renderer">Renderer object used if the data model references the specified name.</param>
		[JsMethod(Name = "addRenderer")]
		public void AddRenderer(string name, qx.ui.progressive.renderer.Abstract renderer) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property batchSize.</para>
		/// </summary>
		[JsMethod(Name = "getBatchSize")]
		public double GetBatchSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property dataModel.</para>
		/// </summary>
		[JsMethod(Name = "getDataModel")]
		public qx.ui.progressive.model.Abstract GetDataModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property flushWidgetQueueAfterBatch.</para>
		/// </summary>
		[JsMethod(Name = "getFlushWidgetQueueAfterBatch")]
		public bool GetFlushWidgetQueueAfterBatch() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property interElementTimeout.</para>
		/// </summary>
		[JsMethod(Name = "getInterElementTimeout")]
		public double GetInterElementTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the structure object</para>
		/// </summary>
		/// <returns>The structure object</returns>
		[JsMethod(Name = "getStructure")]
		public qx.ui.progressive.structure.Abstract GetStructure() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property batchSize
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property batchSize.</param>
		[JsMethod(Name = "initBatchSize")]
		public void InitBatchSize(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property dataModel
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property dataModel.</param>
		[JsMethod(Name = "initDataModel")]
		public void InitDataModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property flushWidgetQueueAfterBatch
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property flushWidgetQueueAfterBatch.</param>
		[JsMethod(Name = "initFlushWidgetQueueAfterBatch")]
		public void InitFlushWidgetQueueAfterBatch(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property interElementTimeout
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property interElementTimeout.</param>
		[JsMethod(Name = "initInterElementTimeout")]
		public void InitInterElementTimeout(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property flushWidgetQueueAfterBatch equals true.</para>
		/// </summary>
		[JsMethod(Name = "isFlushWidgetQueueAfterBatch")]
		public void IsFlushWidgetQueueAfterBatch() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove a previosly added renderer.</para>
		/// </summary>
		/// <param name="name">Remove the renderer which was assigned this name.</param>
		[JsMethod(Name = "removeRenderer")]
		public void RemoveRenderer(string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Render the elements available from the data model.  Elements are
		/// rendered in batches of size <see cref="BatchSize"/>.  After each batch of
		/// elements are rendered, control is returned temporarily to the
		/// browser, so that actual screen updates can take place.  A timer is
		/// used to regain control a short while later, in order to render the
		/// next batch of element.</para>
		/// </summary>
		[JsMethod(Name = "render")]
		public void Render() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property batchSize.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBatchSize")]
		public void ResetBatchSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property dataModel.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDataModel")]
		public void ResetDataModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property flushWidgetQueueAfterBatch.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFlushWidgetQueueAfterBatch")]
		public void ResetFlushWidgetQueueAfterBatch() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property interElementTimeout.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInterElementTimeout")]
		public void ResetInterElementTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property batchSize.</para>
		/// </summary>
		/// <param name="value">New value for property batchSize.</param>
		[JsMethod(Name = "setBatchSize")]
		public void SetBatchSize(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property dataModel.</para>
		/// </summary>
		/// <param name="value">New value for property dataModel.</param>
		[JsMethod(Name = "setDataModel")]
		public void SetDataModel(qx.ui.progressive.model.Abstract value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property flushWidgetQueueAfterBatch.</para>
		/// </summary>
		/// <param name="value">New value for property flushWidgetQueueAfterBatch.</param>
		[JsMethod(Name = "setFlushWidgetQueueAfterBatch")]
		public void SetFlushWidgetQueueAfterBatch(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property interElementTimeout.</para>
		/// </summary>
		/// <param name="value">New value for property interElementTimeout.</param>
		[JsMethod(Name = "setInterElementTimeout")]
		public void SetInterElementTimeout(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property flushWidgetQueueAfterBatch.</para>
		/// </summary>
		[JsMethod(Name = "toggleFlushWidgetQueueAfterBatch")]
		public void ToggleFlushWidgetQueueAfterBatch() { throw new NotImplementedException(); }

		#endregion Methods
    }
}