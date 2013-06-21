// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.progressive.renderer.table
{
    /// <summary>
	/// <para>Table Row renderer for Progressive.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.progressive.renderer.table.Row", OmitOptionalParameters = true, Export = false)]
    public partial class Row : qx.ui.progressive.renderer.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>The default height of a row, if not altered by a cell renderer.</para>
		/// </summary>
		[JsProperty(Name = "defaultRowHeight", NativeField = true)]
		public object DefaultRowHeight { get; set; }

		#endregion Properties

		#region Methods

		public Row() { throw new NotImplementedException(); }

		/// <param name="columnWidths">Information that indicates how to resize each of the column widths</param>
		public Row(qx.ui.progressive.renderer.table.Widths columnWidths) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a cell renderer for use within a row rendered by this row
		/// renderer.</para>
		/// </summary>
		/// <param name="column">The column number for which the cell renderer applies</param>
		/// <param name="renderer">The cell renderer for the specified column.</param>
		[JsMethod(Name = "addRenderer")]
		public void AddRenderer(double column, qx.ui.progressive.renderer.table.cell.Abstract renderer) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property defaultRowHeight.</para>
		/// </summary>
		[JsMethod(Name = "getDefaultRowHeight")]
		public object GetDefaultRowHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is required by the box layout. If returns an array of items
		/// to relayout.</para>
		/// </summary>
		/// <returns>Array of column data.</returns>
		[JsMethod(Name = "getLayoutChildren")]
		public JsArray GetLayoutChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property defaultRowHeight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property defaultRowHeight.</param>
		[JsMethod(Name = "initDefaultRowHeight")]
		public void InitDefaultRowHeight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Join this renderer to its <see cref="qx.ui.progressive.Progressive"/>.</para>
		/// </summary>
		/// <param name="progressive">The Progressive object to which we are being joined.</param>
		/// <param name="name">The name by which the data model will reference this renderer.  This is important to know in order to access the appropriate member of the qx.ui.progressive.State&#8216;s renderer array.  That array is accessed from the renderer by state.getRendererData()[element.renderer] where element.renderer will be the name provided here.</param>
		[JsMethod(Name = "join")]
		public void Join(qx.ui.progressive.Progressive progressive, string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove a cell renderer previously added with <see cref="AddRenderer"/>.</para>
		/// </summary>
		/// <param name="column">The column for which the cell renderer is to be removed.</param>
		[JsMethod(Name = "removeRenderer")]
		public void RemoveRenderer(double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Render the provided element in the renderer&#8217;s unique way.</para>
		/// </summary>
		/// <param name="state">Data relevant to the current rendering session.</param>
		/// <param name="element">An object containing at least the following members:   renderer  The name of a renderer.  That name is used by qx.ui.progressive.Progressive to select the renderer to be used to render this element.  The name should match one provided to qx.ui.progressive.Progressive#addRenderer.    data   The data to be passed to the renderer.  The data may be of any type that the renderer knows how to render.  </param>
		[JsMethod(Name = "render")]
		public void Render(qx.ui.progressive.State state, object element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property defaultRowHeight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDefaultRowHeight")]
		public void ResetDefaultRowHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property defaultRowHeight.</para>
		/// </summary>
		/// <param name="value">New value for property defaultRowHeight.</param>
		[JsMethod(Name = "setDefaultRowHeight")]
		public void SetDefaultRowHeight(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}