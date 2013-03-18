// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.splitpane
{
    /// <summary>
	/// <para>The splitter is the element between the two panes.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.splitpane.Splitter", OmitOptionalParameters = true, Export = false)]
    public partial class Splitter : qx.ui.core.Widget
    {
		#region Properties

		/// <summary>
		/// <para>Whether the item can shrink horizontally.</para>
		/// </summary>
		[JsProperty(Name = "allowShrinkX", NativeField = true)]
		public bool AllowShrinkX { get; set; }

		/// <summary>
		/// <para>Whether the item can shrink vertically.</para>
		/// </summary>
		[JsProperty(Name = "allowShrinkY", NativeField = true)]
		public bool AllowShrinkY { get; set; }

		#endregion Properties

		#region Methods

		public Splitter() { throw new NotImplementedException(); }

		/// <param name="parentWidget">The underlaying split pane.</param>
		public Splitter(qx.ui.splitpane.Pane parentWidget) { throw new NotImplementedException(); }

		#endregion Methods
    }
}