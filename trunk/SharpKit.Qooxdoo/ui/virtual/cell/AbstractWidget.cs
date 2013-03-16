// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.cell
{
    /// <summary>
	/// <para>Abstract base class for widget based cell renderer.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.cell.AbstractWidget", OmitOptionalParameters = true, Export = false)]
    public partial class AbstractWidget : qx.core.Object, qx.ui.virtualx.cell.IWidgetCell
    {
		#region Events

		/// <summary>
		/// <para>Fired when a new LayoutItem is created.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> CreatedEvent;

		#endregion Events

		#region Methods

		public AbstractWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a widget instance to render the cell</para>
		/// </summary>
		/// <param name="data">Data needed for the cell to render.</param>
		/// <param name="states">The states set on the cell (e.g. selected, focused, editable).</param>
		/// <returns>The cell widget</returns>
		[JsMethod(Name = "getCellWidget")]
		public qx.ui.core.LayoutItem GetCellWidget(object data, object states) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Release the given widget instance.</para>
		/// <para>Either pool or dispose the widget.</para>
		/// </summary>
		/// <param name="widget">The cell widget to pool</param>
		[JsMethod(Name = "pool")]
		public void Pool(qx.ui.core.LayoutItem widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Update the data the cell widget should display</para>
		/// </summary>
		/// <param name="widget">The cell widget to update</param>
		/// <param name="data">The data to display</param>
		[JsMethod(Name = "updateData")]
		public void UpdateData(qx.ui.core.LayoutItem widget, object data) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Update the states of the given widget.</para>
		/// </summary>
		/// <param name="widget">The cell widget to update</param>
		/// <param name="states">The cell widget&#8217;s states</param>
		[JsMethod(Name = "updateStates")]
		public void UpdateStates(qx.ui.core.LayoutItem widget, object states) { throw new NotImplementedException(); }

		#endregion Methods
    }
}