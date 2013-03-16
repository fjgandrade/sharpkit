// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.form
{
    /// <summary>
	/// <para>Representation of a form. A form widget can contain one or more <see cref="Row"/> widgets.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var title = new qx.ui.mobile.form.Title("Group");
	/// var form = new qx.ui.mobile.form.Form();
	/// form.add(new qx.ui.mobile.form.TextField(), "Username: ");
	/// this.getRoot.add(title);
	/// this.getRoot.add(new qx.ui.mobile.form.renderer.Single(form));
	/// </code>
	/// <para>This example creates a form and adds a row with a text field in it.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.form.Form", OmitOptionalParameters = true, Export = false)]
    public partial class Form : qx.ui.form.Form
    {
		#region Methods

		public Form() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid items of the form, which were determined by <see cref="qx.ui.mobile.form.Form.Validate"/> before.
		/// It returns an empty array if no items are invalid.</para>
		/// </summary>
		/// <returns>The invalid items of the form.</returns>
		[JsMethod(Name = "getInvalidItems")]
		public qx.ui.mobile.core.Widget GetInvalidItems() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Makes a row invisible, identified by its group and row index.</para>
		/// </summary>
		/// <param name="groupIndex">the index of the group to which the row belongs to</param>
		/// <param name="rowIndex">the index of the row inside the target group</param>
		[JsMethod(Name = "hideRow")]
		public void HideRow(double groupIndex, double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>setter for the renderer private variable</para>
		/// </summary>
		/// <param name="renderer">the renderer</param>
		[JsMethod(Name = "setRenderer")]
		public void SetRenderer(qx.ui.mobile.form.renderer.AbstractRenderer renderer) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Makes a row visible, identified by its group and row index.</para>
		/// </summary>
		/// <param name="groupIndex">the index of the group to which the row belongs to</param>
		/// <param name="rowIndex">the index of the row inside the target group</param>
		[JsMethod(Name = "showRow")]
		public void ShowRow(double groupIndex, double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Validates the form using the
		/// <see cref="qx.ui.form.validation.Manager.Validate"/> method.</para>
		/// </summary>
		/// <returns>The validation result.</returns>
		[JsMethod(Name = "validate")]
		public bool Validate() { throw new NotImplementedException(); }

		#endregion Methods
    }
}