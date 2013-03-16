// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.html
{
    /// <summary>
	/// <para>This is a simple image class using the low level image features of
	/// qooxdoo and wraps it for the qx.html layer.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.html.Image", OmitOptionalParameters = true, Export = false)]
    public partial class Image : qx.html.Element
    {
		#region Methods

		public Image() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the image is scaled or not.</para>
		/// </summary>
		/// <returns>Whether the image is scaled</returns>
		[JsMethod(Name = "getScale")]
		public bool GetScale() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the image source.</para>
		/// </summary>
		/// <returns>Current image source.</returns>
		[JsMethod(Name = "getSource")]
		public string GetSource() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the current source to null which means that no image
		/// is shown anymore.</para>
		/// </summary>
		/// <returns>The current instance for chaining</returns>
		[JsMethod(Name = "resetSource")]
		public qx.html.Image ResetSource() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the image should be scaled or not.</para>
		/// </summary>
		/// <param name="value">Scale the image</param>
		/// <returns>This instance for for chaining support.</returns>
		[JsMethod(Name = "setScale")]
		public qx.html.Label SetScale(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Configures the image source</para>
		/// </summary>
		/// <param name="value">Whether the HTML mode should be used.</param>
		/// <returns>This instance for for chaining support.</returns>
		[JsMethod(Name = "setSource")]
		public qx.html.Label SetSource(bool value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}