// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.page
{
    /// <summary>
	/// <para>The page manager decides automatically whether the added pages should be
	/// displayed in a master/detail view (for tablet) or as a plain card layout (for
	/// smartphones).</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the manager.</para>
	/// <code>
	/// var manager = new qx.ui.mobile.page.Manager();
	/// var page1 = new qx.ui.mobile.page.NavigationPage();
	/// var page2 = new qx.ui.mobile.page.NavigationPage();
	/// var page3 = new qx.ui.mobile.page.NavigationPage();
	/// manager.addMaster(page1);
	/// manager.addDetail([page2,page3]);
	/// page1.show();
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.page.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>The caption/label of the Master Button and Popup Title.</para>
		/// </summary>
		[JsProperty(Name = "masterTitle", NativeField = true)]
		public string MasterTitle { get; set; }

		/// <summary>
		/// <para>The PortraitMasterContainer will have the height of displayed
		/// MasterPage content + MasterPage Title + portraitMasterScrollOffset</para>
		/// </summary>
		[JsProperty(Name = "portraitMasterScrollOffset", NativeField = true)]
		public double PortraitMasterScrollOffset { get; set; }

		#endregion Properties

		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <param name="isTablet">flag which triggers the manager to layout for tablet (or big screens/displays) or mobile devices. If parameter is null, qx.core.Environment.get(&#8220;device.type&#8221;) is called for decision.</param>
		/// <param name="root">widget which should be used as root for this manager.</param>
		public Manager(bool isTablet, qx.ui.mobile.core.Widget root) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds an array of NavigationPage to the detailContainer.</para>
		/// </summary>
		/// <param name="pages">Array of NavigationPages or single NavigationPage.</param>
		[JsMethod(Name = "addDetail")]
		public void AddDetail(object pages) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds an array of NavigationPages to masterContainer, if __isTablet is true. Otherwise it will be added to detailContainer.</para>
		/// </summary>
		/// <param name="pages">Array of NavigationPages or single NavigationPage.</param>
		[JsMethod(Name = "addMaster")]
		public void AddMaster(object pages) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the detailContainer.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getDetailContainer")]
		public qx.ui.mobile.container.Navigation GetDetailContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the button for showing/hiding the masterContainer.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getMasterButton")]
		public qx.ui.mobile.navigationbar.Button GetMasterButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the masterContainer.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getMasterContainer")]
		public qx.ui.mobile.container.Navigation GetMasterContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property masterTitle.</para>
		/// </summary>
		[JsMethod(Name = "getMasterTitle")]
		public string GetMasterTitle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the masterContainer for the portrait mode.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getPortraitMasterContainer")]
		public qx.ui.mobile.dialog.Popup GetPortraitMasterContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property portraitMasterScrollOffset.</para>
		/// </summary>
		[JsMethod(Name = "getPortraitMasterScrollOffset")]
		public double GetPortraitMasterScrollOffset() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property masterTitle
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property masterTitle.</param>
		[JsMethod(Name = "initMasterTitle")]
		public void InitMasterTitle(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property portraitMasterScrollOffset
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property portraitMasterScrollOffset.</param>
		[JsMethod(Name = "initPortraitMasterScrollOffset")]
		public void InitPortraitMasterScrollOffset(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property masterTitle.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMasterTitle")]
		public void ResetMasterTitle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property portraitMasterScrollOffset.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPortraitMasterScrollOffset")]
		public void ResetPortraitMasterScrollOffset() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property masterTitle.</para>
		/// </summary>
		/// <param name="value">New value for property masterTitle.</param>
		[JsMethod(Name = "setMasterTitle")]
		public void SetMasterTitle(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property portraitMasterScrollOffset.</para>
		/// </summary>
		/// <param name="value">New value for property portraitMasterScrollOffset.</param>
		[JsMethod(Name = "setPortraitMasterScrollOffset")]
		public void SetPortraitMasterScrollOffset(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}