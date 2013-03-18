// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION</para>
	/// <para>GeoLocation provides access to geographical location information
	/// associated with the hosting device.</para>
	/// <para>For more information see:
	/// http://www.w3.org/TR/geolocation-API</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.GeoLocation", OmitOptionalParameters = true, Export = false)]
    public partial class GeoLocation : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired when an error occurs</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnError;

		/// <summary>
		/// <para>Fired when the position is updated</para>
		/// </summary>
		public event Action<qx.eventx.type.GeoPosition> OnPosition;

		#endregion Events

		#region Methods

		public GeoLocation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Retrieves the current position and calls the &#8220;position&#8221; event.</para>
		/// </summary>
		/// <param name="enableHighAccuracy">provide the best possible results</param>
		/// <param name="timeout">maximum time in ms that is allowed to pass from the call to getCurrentPosition() or watchPosition() until the corresponding callback is invoked.</param>
		/// <param name="maximumAge">cache the position for a specified time.</param>
		[JsMethod(Name = "getCurrentPosition")]
		public void GetCurrentPosition(Action<object> enableHighAccuracy, Action<object> timeout, Action<object> maximumAge) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Starts to watch the position. Calls the &#8220;position&#8221; event, when the position changed.</para>
		/// </summary>
		/// <param name="enableHighAccuracy">provide the best possible results</param>
		/// <param name="timeout">maximum time in ms that is allowed to pass from the call to getCurrentPosition() or watchPosition() until the corresponding callback is invoked.</param>
		/// <param name="maximumAge">cache the position for a specified time.</param>
		[JsMethod(Name = "startWatchPosition")]
		public void StartWatchPosition(Action<object> enableHighAccuracy, Action<object> timeout, Action<object> maximumAge) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stops watching the position.</para>
		/// </summary>
		[JsMethod(Name = "stopWatchPosition")]
		public void StopWatchPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.bom.GeoLocation GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}