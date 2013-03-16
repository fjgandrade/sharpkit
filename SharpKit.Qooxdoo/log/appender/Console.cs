// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.log.appender
{
    /// <summary>
	/// <para>Feature-rich console appender for the qooxdoo logging system.</para>
	/// <para>Creates a small inline element which is placed in the top-right corner
	/// of the window. Prints all messages with a nice color highlighting.</para>
	/// <list type="bullet">
	/// <item>Allows user command inputs.</item>
	/// <item>Command history enabled by default (Keyboard up/down arrows).</item>
	/// <item>Lazy creation on first open.</item>
	/// <item>Clearing the console using a button.</item>
	/// <item>Display of offset (time after loading) of each message</item>
	/// <item>Supports keyboard shortcuts F7 or Ctrl+D to toggle the visibility</item>
	/// </list
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.log.appender.Console", OmitOptionalParameters = true, Export = false)]
    public partial class Console 
    {
		#region Methods

		public Console() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the current console output.</para>
		/// </summary>
		[JsMethod(Name = "clear")]
		public static void Clear() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Used by the object registry to dispose this instance e.g. remove listeners etc.</para>
		/// </summary>
		[JsMethod(Name = "dispose")]
		public static void Dispose() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes the currently given command</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public static void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Initializes the console, building HTML and pushing last
		/// log messages to the output window.</para>
		/// </summary>
		[JsMethod(Name = "init")]
		public static void Init() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Processes a single log entry</para>
		/// </summary>
		/// <param name="entry">The entry to process</param>
		[JsMethod(Name = "process")]
		public static void Process(object entry) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Shows the console.</para>
		/// </summary>
		[JsMethod(Name = "show")]
		public static void Show() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the visibility of the console between visible and hidden.</para>
		/// </summary>
		[JsMethod(Name = "toggle")]
		public static void Toggle() { throw new NotImplementedException(); }

		#endregion Methods
    }
}