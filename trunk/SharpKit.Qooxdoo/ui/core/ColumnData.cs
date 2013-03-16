// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>All of the resizing information about a column.</para>
	/// <para>This is used internally by qx.ui.table and qx.ui.progressive&#8217;s table and
	/// may be used for other widgets as well.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.ColumnData", OmitOptionalParameters = true, Export = false)]
    public partial class ColumnData : qx.ui.core.LayoutItem
    {
		#region Methods

		public ColumnData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the computed width of the column.</para>
		/// </summary>
		/// <returns>Computed column width</returns>
		[JsMethod(Name = "getComputedWidth")]
		public double GetComputedWidth() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the column&#8217;s flex value</para>
		/// </summary>
		/// <returns>The column&#8217;s flex value</returns>
		[JsMethod(Name = "getFlex")]
		public double GetFlex() { throw new NotImplementedException(); }

		[JsMethod(Name = "renderLayout")]
		public void RenderLayout(object left, object top, object width, object height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the column width. The column width can be one of the following
		/// values:</para>
		/// <list type="bullet">
		/// <item>Pixels: e.g. 23</item>
		/// <item>Autosized: &#8220;auto&#8221;</item>
		/// <item>Flex: e.g. &#8220;1*&#8221;</item>
		/// <item>Percent: e.g. &#8220;33%&#8221;</item>
		/// </list
		/// </summary>
		/// <param name="width">The column width</param>
		/// <param name="flex">Optional flex value of the column</param>
		[JsMethod(Name = "setColumnWidth")]
		public void SetColumnWidth(object width, double flex = 0) { throw new NotImplementedException(); }

		#endregion Methods
    }
}