// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx
{
    /// <summary>
	/// <para>Wrapper for browser DOM event handling for each browser window/frame.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : object
    {
		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a new instance of the event handler.</para>
		/// </summary>
		/// <param name="win">The DOM window this manager handles the events for</param>
		/// <param name="registration">The event registration to use</param>
		public Manager(Window win, qx.eventx.Registration registration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an unique ID which may be used in combination with a target and
		/// a type to identify an event entry.</para>
		/// </summary>
		/// <returns>The next free identifier (auto-incremented)</returns>
		[JsMethod(Name = "getNextUniqueId")]
		public static string GetNextUniqueId() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add an event listener to any valid target. The event listener is passed an
		/// instance of <see cref="qx.event.type.Event"/> containing all relevant information
		/// about the event as parameter.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">Name of the event e.g. &#8220;click&#8221;, &#8220;keydown&#8221;, ...</param>
		/// <param name="listener">Event listener function</param>
		/// <param name="self">Reference to the &#8216;this&#8217; variable inside the event listener. When not given, the corresponding dispatcher usually falls back to a default, which is the target by convention. Note this is not a strict requirement, i.e. custom dispatchers can follow a different strategy.</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event. The default is to attach the event handler to the bubbling phase.</param>
		/// <returns>An opaque ID, which can be used to remove the event listener using the #removeListenerById method.</returns>
		[JsMethod(Name = "addListener")]
		public string AddListener(object target, string type, Action<object> listener, object self = null, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Dispatches an event object using the qooxdoo event handler system. The
		/// event will only be visible in event listeners attached using
		/// <see cref="AddListener"/>. After dispatching the event object will be pooled
		/// for later reuse or disposed.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="eventx">The event object to dispatch. The event object must be obtained using qx.event.Registration#createEvent and initialized using qx.event.type.Event#init.</param>
		/// <returns>whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "dispatchEvent")]
		public bool DispatchEvent(object target, qx.eventx.type.Event eventx) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Dispose the event manager</para>
		/// </summary>
		[JsMethod(Name = "dispose")]
		public void Dispose() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the event handler class matching the given event target and type</para>
		/// </summary>
		/// <param name="target">The event target</param>
		/// <param name="type">The event type</param>
		/// <returns>The best matching event handler or null.</returns>
		[JsMethod(Name = "findHandler")]
		public qx.eventx.IEventHandler FindHandler(object target, string type) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an instance of the given dispatcher class for this manager(window).</para>
		/// </summary>
		/// <param name="clazz">Any class which implements qx.event.IEventHandler</param>
		/// <returns>The instance used by this manager</returns>
		[JsMethod(Name = "getDispatcher")]
		public object GetDispatcher(Class clazz) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an instance of the given handler class for this manager(window).</para>
		/// </summary>
		/// <param name="clazz">Any class which implements qx.event.IEventHandler</param>
		/// <returns>The instance used by this manager</returns>
		[JsMethod(Name = "getHandler")]
		public object GetHandler(Class clazz) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a copy of all event listeners for the given combination
		/// of target, event type and phase.</para>
		/// <para>This method is especially useful and for event handlers to
		/// to query the listeners registered in the manager.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">Event type</param>
		/// <param name="capture">Whether the listener is for the capturing phase of the bubbling phase.</param>
		/// <returns>Array of registered event handlers. May return null when no listener were found.</returns>
		[JsMethod(Name = "getListeners")]
		public JsArray GetListeners(object target, string type, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the window instance the event manager is responsible for</para>
		/// </summary>
		/// <returns>DOM window instance</returns>
		[JsMethod(Name = "getWindow")]
		public Window GetWindow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the hashcode of the manager&#8217;s window</para>
		/// </summary>
		/// <returns>The window&#8217;s hashcode</returns>
		[JsMethod(Name = "getWindowId")]
		public string GetWindowId() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether there are one or more listeners for an event type
		/// registered at the target.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">The event type</param>
		/// <param name="capture">Whether to check for listeners of the bubbling or of the capturing phase.</param>
		/// <returns>Whether the target has event listeners of the given type.</returns>
		[JsMethod(Name = "hasListener")]
		public bool HasListener(object target, string type, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Imports a list of event listeners at once. This only
		/// works for newly created elements as it replaces
		/// all existing data structures.</para>
		/// <para>Works with a map of data. Each entry in this map should be a
		/// map again with the keys type, listener,
		/// self, capture and an optional unique.</para>
		/// <para>The values are identical to the parameters of <see cref="AddListener"/>.
		/// For details please have a look there.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="list">A map where every listener has an unique key.</param>
		[JsMethod(Name = "importListeners")]
		public void ImportListeners(object target, object list) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all event listeners, which are attached to the given event target.</para>
		/// </summary>
		/// <param name="target">The event target to remove all event listeners from.</param>
		/// <returns>Whether the events were existend and were removed successfully.</returns>
		[JsMethod(Name = "removeAllListeners")]
		public bool RemoveAllListeners(object target) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove an event listener from an event target.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">Name of the event</param>
		/// <param name="listener">The pointer to the event listener</param>
		/// <param name="self">Reference to the &#8216;this&#8217; variable inside the event listener.</param>
		/// <param name="capture">Whether to remove the event listener of the bubbling or of the capturing phase.</param>
		/// <returns>Whether the event was removed successfully (was existend)</returns>
		[JsMethod(Name = "removeListener")]
		public bool RemoveListener(object target, string type, Action<object> listener, object self = null, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes an event listener from an event target by an ID returned by
		/// <see cref="AddListener"/>.</para>
		/// </summary>
		/// <param name="target">The event target</param>
		/// <param name="id">The ID returned by #addListener</param>
		/// <returns>true if the handler was removed</returns>
		[JsMethod(Name = "removeListenerById")]
		public bool RemoveListenerById(object target, string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a serialized array of all events attached on the given target.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <returns>Array of maps where everyone contains the keys: handler, self, type and capture.</returns>
		[JsMethod(Name = "serializeListeners")]
		public object SerializeListeners(object target) { throw new NotImplementedException(); }

		#endregion Methods
    }
}