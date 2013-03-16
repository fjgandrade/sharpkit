// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.util
{
    /// <summary>
	/// <para>Utilities for working with character codes and key identifiers</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.util.Keyboard", OmitOptionalParameters = true, Export = false)]
    public partial class Keyboard 
    {
		#region Methods

		public Keyboard() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>converts a character code to the corresponding identifier</para>
		/// </summary>
		/// <param name="charCode">character code</param>
		/// <returns>key identifier</returns>
		[JsMethod(Name = "charCodeToIdentifier")]
		public static string CharCodeToIdentifier(string charCode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the keycode can be reliably detected in keyup/keydown events</para>
		/// </summary>
		/// <param name="keyCode">key code to check.</param>
		/// <returns>Whether the keycode can be reliably detected in keyup/keydown events.</returns>
		[JsMethod(Name = "isIdentifiableKeyCode")]
		public static bool IsIdentifiableKeyCode(string keyCode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks whether the keyCode represents a non printable key</para>
		/// </summary>
		/// <param name="keyCode">key code to check.</param>
		/// <returns>Whether the keyCode represents a non printable key.</returns>
		[JsMethod(Name = "isNonPrintableKeyCode")]
		public static bool IsNonPrintableKeyCode(string keyCode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks whether a given string is a printable keyIdentifier.</para>
		/// </summary>
		/// <param name="keyIdentifier">The key identifier.</param>
		/// <returns>whether the given string is a printable keyIdentifier.</returns>
		[JsMethod(Name = "isPrintableKeyIdentifier")]
		public static bool IsPrintableKeyIdentifier(string keyIdentifier) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks whether a given string is a valid keyIdentifier</para>
		/// </summary>
		/// <param name="keyIdentifier">The key identifier.</param>
		/// <returns>whether the given string is a valid keyIdentifier</returns>
		[JsMethod(Name = "isValidKeyIdentifier")]
		public static bool IsValidKeyIdentifier(string keyIdentifier) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>converts a keyboard code to the corresponding identifier</para>
		/// </summary>
		/// <param name="keyCode">key code</param>
		/// <returns>key identifier</returns>
		[JsMethod(Name = "keyCodeToIdentifier")]
		public static string KeyCodeToIdentifier(double keyCode) { throw new NotImplementedException(); }

		#endregion Methods
    }
}