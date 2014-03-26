// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.log.appender
{
    /// <summary>
	/// <para>Processes the incoming log entry and displays it by means of the native
	/// logging capabilities of the client.</para>
	/// <para>Supported browsers:
	/// * Firefox <4 using FireBug (if available).
	/// * Firefox >=4 using the Web Console.
	/// * WebKit browsers using the Web Inspector/Developer Tools.
	/// * Internet Explorer 8+ using the F12 Developer Tools.
	/// * Opera >=10.60 using either the Error Console or Dragonfly</para>
	/// <para>Currently unsupported browsers:
	/// * Opera 
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.log.appender.Native", OmitOptionalParameters = true, Export = false)]
    public partial class Native 
    {
		#region Methods

		public Native() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Processes a single log entry</para>
		/// </summary>
		/// <param name="entry">The entry to process</param>
		[JsMethod(Name = "process")]
		public static void Process(object entry) { throw new NotImplementedException(); }

		#endregion Methods
    }
}