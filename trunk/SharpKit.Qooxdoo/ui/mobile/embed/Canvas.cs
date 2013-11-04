// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.embed
{
    /// <summary>
	/// <para>Creates a HTML canvas widget in your mobile application.</para>
	/// <para>Example</para>
	/// <para>Here is an example of how to use the canvas widget.</para>
	/// <code>
	/// var canvas = new qx.ui.mobile.embed.Canvas();
	/// canvas.setWidth(100);
	/// canvas.setHeight(100);
	/// this.getContent().add(canvas);
	/// var ctx= canvas.getContext2d();
	/// ctx.fillStyle="#FF0000";
	/// ctx.fillRect(0,0,150,75);
	/// ctx.beginPath();
	/// ctx.arc(75,75,50,0,Math.PI*2,true); // Outer circle
	/// ctx.moveTo(110,75);
	/// ctx.arc(75,75,35,0,Math.PI,false);   // Mouth (clockwise)
	/// ctx.moveTo(65,65);
	/// ctx.arc(60,65,5,0,Math.PI*2,true);  // Left eye
	/// ctx.moveTo(95,65);
	/// ctx.arc(90,65,5,0,Math.PI*2,true);  // Right eye
	/// ctx.stroke();
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.embed.Canvas", OmitOptionalParameters = true, Export = false)]
    public partial class Canvas : qx.ui.mobile.core.Widget
    {
		#region Methods

		public Canvas() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the canvas element [W3C-HMTL5]</para>
		/// </summary>
		/// <returns>The canvas DOM element.</returns>
		[JsMethod(Name = "getCanvas")]
		public qx.html.Element GetCanvas() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the canvas&#8217; 2D rendering context
		/// [W3C-HTML5].
		/// All drawing operations are performed on this context.</para>
		/// </summary>
		/// <returns>The 2D rendering context.</returns>
		[JsMethod(Name = "getContext2d")]
		public CanvasRenderingContext2D GetContext2d() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the height attribute of the canvas element</para>
		/// </summary>
		/// <returns>canvas height</returns>
		[JsMethod(Name = "getHeight")]
		public double GetHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the width attribute of the canvas element</para>
		/// </summary>
		/// <returns>canvas width</returns>
		[JsMethod(Name = "getWidth")]
		public double GetWidth() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the height attribute of the canvas element. This property controls the
		/// size of the canvas coordinate space.</para>
		/// </summary>
		/// <param name="height">canvas height</param>
		[JsMethod(Name = "setHeight")]
		public void SetHeight(double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the width attribute of the canvas element. This property controls the
		/// size of the canvas coordinate space.</para>
		/// </summary>
		/// <param name="width">canvas width</param>
		[JsMethod(Name = "setWidth")]
		public void SetWidth(double width) { throw new NotImplementedException(); }

		#endregion Methods
    }
}