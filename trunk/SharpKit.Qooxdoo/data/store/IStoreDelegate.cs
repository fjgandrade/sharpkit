// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.store
{
    /// <summary>
	/// <para>Objects, which are used as delegates for a data binding store may
	/// implement any of the methods described in this interface. The delegate does
	/// not need implement all of the methods of this interface. If a method is not
	/// implemented the store provides a default implementation.</para>
	/// <para>Note: This interface is meant to document the delegate but should not be
	/// listed in the implement key of a class unless all methods are
	/// really implemented.</para>
	/// </summary>
	public interface IStoreDelegate
    {
		#region Methods

		/// <summary>
		/// <para>This method can change the settings on the used request by the store.</para>
		/// </summary>
		/// <param name="request">The created request, depending on the implementation of the data store.</param>
		void ConfigureRequest(object request);

		/// <summary>
		/// <para>This method manipulates the data from the request and returns the
		/// manipulated data.</para>
		/// </summary>
		/// <param name="data">The data received by the request.</param>
		/// <returns>The manipulated data.</returns>
		object ManipulateData(object data);

		#endregion Methods
    }
}