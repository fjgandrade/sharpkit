// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>History manager implementation for IE greater 7. IE reloads iframe
	/// content on history actions even just hash value changed. This
	/// implementation forwards history states (hashes) to a helper iframe.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.HashHistory", OmitOptionalParameters = true, Export = false)]
    public partial class HashHistory : qx.bom.History
    {
		#region Methods

		public HashHistory() { throw new NotImplementedException(); }

		[JsMethod(Name = "addToHistory")]
		public void AddToHistory(object state, object newTitle) { throw new NotImplementedException(); }

		#endregion Methods
    }
}