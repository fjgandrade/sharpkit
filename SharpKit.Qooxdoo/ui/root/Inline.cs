// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.root
{
    /// <summary>
	/// <para>This classes could be used to insert qooxdoo islands into existing
	/// web pages. You can use the isles to place any qooxdoo powered widgets
	/// inside a layout made using traditional HTML markup and CSS.</para>
	/// <para>The size of the widget in each dimension can either be determined by the
	/// size hint of the inline&#8217;s children or by the size of the root DOM element. If
	/// dynamicX/dynamicY is true the width/height of the DOM
	/// element is used.</para>
	/// <para>This class uses <see cref="qx.ui.layout.Basic"/> as default layout. The layout
	/// can be changed using the <see cref="SetLayout"/> method.</para>
	/// <para>To position popups and tooltips please have a look at <see cref="qx.ui.root.Page"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.root.Inline", OmitOptionalParameters = true, Export = false)]
    public partial class Inline : qx.ui.root.Abstract
    {
		#region Methods

		public Inline() { throw new NotImplementedException(); }

		/// <param name="el">DOM element to use as isle for qooxdoo content. Please note that existing content gets removed on the first layout flush.</param>
		/// <param name="dynamicX">If true the widget&#8217;s width is determined by the DOM element&#8217;s width. Otherwise the children&#8217;s size hint is used.</param>
		/// <param name="dynamicY">If true the widget&#8217;s height is determined by the DOM element&#8217;s height. Otherwise the children&#8217;s size hint is used.</param>
		public Inline(qx.html.Element el, bool dynamicX, bool dynamicY) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget&#8217;s layout manager.</para>
		/// </summary>
		/// <returns>The widget&#8217;s layout manager</returns>
		[JsMethod(Name = "getLayout")]
		public qx.ui.layout.Abstract GetLayout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set a layout manager for the widget. A a layout manager can only be connected
		/// with one widget. Reset the connection with a previous widget first, if you
		/// like to use it in another widget instead.</para>
		/// </summary>
		/// <param name="layout">The new layout or null to reset the layout.</param>
		[JsMethod(Name = "setLayout")]
		public void SetLayout(qx.ui.layout.Abstract layout) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mapping of protected methods to public.
		/// This omits an additional function call when using these methods. Call
		/// this methods in the defer block of the including class.</para>
		/// </summary>
		/// <param name="members">The including classes members map</param>
		[JsMethod(Name = "remap")]
		public static void Remap(object members) { throw new NotImplementedException(); }

		#endregion Methods
    }
}