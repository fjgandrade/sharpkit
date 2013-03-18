// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.mobile.core;

namespace qx.ui.mobile.page
{
    /// <summary>
	/// <para>A page is a widget which provides a screen with which users
	/// can interact in order to do something. Most times a page provides a single task
	/// or a group of related tasks.</para>
	/// <para>A qooxdoo mobile application is usually composed of one or more loosely bound
	/// pages. Typically there is one page that presents the &#8220;main&#8221; view.</para>
	/// <para>Pages can have one or more child widgets from the <see cref="qx.ui.mobile"/>
	/// namespace. Normally a page provides a <see cref="qx.ui.mobile.navigationbar.NavigationBar"/>
	/// for the navigation between pages.</para>
	/// <para>To navigate between two pages, just call the <see cref="Show"/> method of the page
	/// that should be shown. Depending on the used page manager a page transition will be animated.
	/// There are several animations available. Have
	/// a look at the <see cref="qx.ui.mobile.page.Manager"/> manager or <see cref="qx.ui.mobile.layout.Card"/> card layout for more information.</para>
	/// <para>A page has predefined lifecycle methods that get called by the used page manager
	/// when a page gets shown. Each time another page is requested to be shown the currently shown page
	/// is stopped. The other page, will be, if shown for the first time, initialized and started
	/// afterwards. For all called lifecycle methods an event is fired.</para>
	/// <para>Call of the <see cref="Show"/> method triggers the following lifecycle methods:</para>
	/// <list type="bullet">
	/// <item>initialize: Initializes the page to show</item>
	/// <item>start: Gets called when the page to show is started</item>
	/// <item>stop:  Stops the current page</item>
	/// </list
	/// <para>IMPORTANT: Define all child widgets of a page when the <see cref="Initialize"/> lifecycle
	/// method is called, either by listening to the <see cref="Initialize"/> event or overriding
	/// the <see cref="#_initialize"/> method. This is because a page can be instanced during
	/// application startup and would then decrease performance when the widgets would be
	/// added during constructor call. The initialize event and the
	/// <see cref="#_initialize"/> lifecycle method are only called when the page is shown
	/// for the first time.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.page.Page", OmitOptionalParameters = true, Export = false)]
    public partial class Page : qx.ui.mobile.container.Composite
    {
		#region Events

		/// <summary>
		/// <para>Fired when the method <see cref="Back"/> is called. Data indicating
		/// whether the action was triggered by a key event or not.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnBack;

		/// <summary>
		/// <para>Fired when the lifecycle method <see cref="Initialize"/> is called</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnInitialize;

		/// <summary>
		/// <para>Fired when the method <see cref="Menu"/> is called</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnMenu;

		/// <summary>
		/// <para>Fired when the lifecycle method <see cref="Pause"/> is called</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnPause;

		/// <summary>
		/// <para>Fired when the lifecycle method <see cref="Resume"/> is called</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnResume;

		/// <summary>
		/// <para>Fired when the lifecycle method <see cref="Start"/> is called</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnStart;

		/// <summary>
		/// <para>Fired when the lifecycle method <see cref="Stop"/> is called</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnStop;

		#endregion Events

		#region Properties

		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public object DefaultCssClass { get; set; }

		/// <summary>
		/// <para>Whether the resize should fire the &#8220;domupdated&#8221; event. Set this to &#8220;true&#8221;
		/// whenever other elements should react on this size change (e.g. when the size
		/// change does not infect the size of the application, but other widgets should
		/// react).</para>
		/// </summary>
		[JsProperty(Name = "fireDomUpdatedOnResize", NativeField = true)]
		public bool FireDomUpdatedOnResize { get; set; }

		#endregion Properties

		#region Methods

		public Page() { throw new NotImplementedException(); }

		public Page(object layout) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Fires the back event. Call this method if you want to request
		/// a back action. For Android PhoneGap applications this method gets called
		/// by the used page manager when the back button was pressed. Return true
		/// to exit the application.</para>
		/// </summary>
		/// <param name="triggeredByKeyEvent">Whether the back action was triggered by a key event.</param>
		/// <returns>Whether the exit should be exit or not. Return true</returns>
		[JsMethod(Name = "back")]
		public bool Back(bool triggeredByKeyEvent) { throw new NotImplementedException(); }

		[JsMethod(Name = "exclude")]
		public void Exclude(object properties) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Lifecycle method. Called by the page manager when the page is shown.
		/// Fires the initialize event. You should create and add all your
		/// child widgets of the view,  either by listening to the <see cref="Initialize"/> event or overriding
		/// the <see cref="#_initialize"/> method. This is because a page can be instanced during
		/// application startup and would then decrease performance when the widgets would be
		/// added during constructor call. The <see cref="#_initialize"/> lifecycle method and the
		/// initialize are only called once when the page is shown for the first time.</para>
		/// </summary>
		[JsMethod(Name = "initialize")]
		public void Initialize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the status of the initialization of the page.</para>
		/// </summary>
		/// <returns>Whether the page is already initialized or not</returns>
		[JsMethod(Name = "isInitialized")]
		public bool IsInitialized() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Only used by Android PhoneGap applications. Called by the used page manager
		/// when the menu button was pressed. Fires the menu event.</para>
		/// </summary>
		[JsMethod(Name = "menu")]
		public void Menu() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Lifecycle method. Not used right now. Should be called when the current page
		/// is interrupted, e.g. by a dialog, so that page view updates can be interrupted.
		/// Fires the pause event.</para>
		/// </summary>
		[JsMethod(Name = "pause")]
		public void Pause() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Lifecycle method. Not used right now. Should be called when the current page
		/// is resuming from a interruption, e.g. when a dialog is closed, so that page
		/// can resume updating the view.
		/// Fires the resume event.</para>
		/// </summary>
		[JsMethod(Name = "resume")]
		public void Resume() { throw new NotImplementedException(); }

		[JsMethod(Name = "show")]
		public void Show(object properties) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Lifecycle method. Called by the page manager after the <see cref="Initialize"/>
		/// method when the page is shown. Fires the start event. You should
		/// register all your event listener when this event occurs, so that no page
		/// updates are down when page is not shown.</para>
		/// </summary>
		[JsMethod(Name = "start")]
		public void Start() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Lifecycle method. Called by the page manager when another page is shown.
		/// Fires the stop event. You should unregister all your event
		/// listener when this event occurs, so that no page updates are down when page is not shown.</para>
		/// </summary>
		[JsMethod(Name = "stop")]
		public void Stop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resizes the container element to the height of the parent element.</para>
		/// </summary>
		[JsMethod(Name = "fixSize")]
		public void FixSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property fireDomUpdatedOnResize.</para>
		/// </summary>
		[JsMethod(Name = "getFireDomUpdatedOnResize")]
		public bool GetFireDomUpdatedOnResize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property fireDomUpdatedOnResize
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property fireDomUpdatedOnResize.</param>
		[JsMethod(Name = "initFireDomUpdatedOnResize")]
		public void InitFireDomUpdatedOnResize(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property fireDomUpdatedOnResize equals true.</para>
		/// </summary>
		[JsMethod(Name = "isFireDomUpdatedOnResize")]
		public void IsFireDomUpdatedOnResize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes fixed size from container.</para>
		/// </summary>
		[JsMethod(Name = "releaseFixedSize")]
		public void ReleaseFixedSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property fireDomUpdatedOnResize.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFireDomUpdatedOnResize")]
		public void ResetFireDomUpdatedOnResize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property fireDomUpdatedOnResize.</para>
		/// </summary>
		/// <param name="value">New value for property fireDomUpdatedOnResize.</param>
		[JsMethod(Name = "setFireDomUpdatedOnResize")]
		public void SetFireDomUpdatedOnResize(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property fireDomUpdatedOnResize.</para>
		/// </summary>
		[JsMethod(Name = "toggleFireDomUpdatedOnResize")]
		public void ToggleFireDomUpdatedOnResize() { throw new NotImplementedException(); }

		#endregion Methods
    }
}