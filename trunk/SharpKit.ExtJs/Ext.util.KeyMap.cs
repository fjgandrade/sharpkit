//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region KeyMap
    /// <inheritdocs />
    /// <summary>
    /// <p>Handles mapping key events to handling functions for an element or a Component. One KeyMap can be used for multiple
    /// actions.</p>
    /// <p>A KeyMap must be configured with a <see cref="Ext.util.KeyMapConfig.target">target</see> as an event source which may be an Element or a Component.</p>
    /// <p>If the target is an element, then the <c>keydown</c> event will trigger the invocation of <see cref="Ext.util.KeyMapConfig.binding">binding</see>s.</p>
    /// <p>It is possible to configure the KeyMap with a custom <see cref="Ext.util.KeyMapConfig.eventName">eventName</see> to listen for. This may be useful when the
    /// <see cref="Ext.util.KeyMapConfig.target">target</see> is a Component.</p>
    /// <p>The KeyMap's event handling requires that the first parameter passed is a key event. So if the Component's event
    /// signature is different, specify a <see cref="Ext.util.KeyMapConfig.processEvent">processEvent</see> configuration which accepts the event's parameters and
    /// returns a key event.</p>
    /// <p>Functions specified in <see cref="Ext.util.KeyMapConfig.binding">binding</see>s are called with this signature : <c>(String key, <see cref="Ext.EventObject">Ext.EventObject</see> e)</c> (if the
    /// match is a multi-key combination the callback will still be called only once). A KeyMap can also handle a string
    /// representation of keys. By default KeyMap starts enabled.</p>
    /// <p>Usage:</p>
    /// <pre><code>// map one key by key code
    /// var map = new <see cref="Ext.util.KeyMap">Ext.util.KeyMap</see>({
    /// target: "my-element",
    /// key: 13, // or <see cref="Ext.EventObject.ENTER">Ext.EventObject.ENTER</see>
    /// fn: myHandler,
    /// scope: myObject
    /// });
    /// // map multiple keys to one action by string
    /// var map = new <see cref="Ext.util.KeyMap">Ext.util.KeyMap</see>({
    /// target: "my-element",
    /// key: "a\r\n\t",
    /// fn: myHandler,
    /// scope: myObject
    /// });
    /// // map multiple keys to multiple actions by strings and array of codes
    /// var map = new <see cref="Ext.util.KeyMap">Ext.util.KeyMap</see>({
    /// target: "my-element",
    /// binding: [{
    /// key: [10,13],
    /// fn: function(){ alert("Return was pressed"); }
    /// }, {
    /// key: "abc",
    /// fn: function(){ alert('a, b or c was pressed'); }
    /// }, {
    /// key: "\t",
    /// ctrl:true,
    /// shift:true,
    /// fn: function(){ alert('Control + shift + tab was pressed.'); }
    /// }]
    /// });
    /// </code></pre>
    /// <p>Since 4.1.0, KeyMaps can bind to Components and process key-based events fired by Components.</p>
    /// <p>To bind to a Component, use the single parameter form of constructor and include the Component event name
    /// to listen for, and a <c>processEvent</c> implementation which returns the key event for further processing by
    /// the KeyMap:</p>
    /// <pre><code>var map = new <see cref="Ext.util.KeyMap">Ext.util.KeyMap</see>({
    /// target: myGridView,
    /// eventName: 'itemkeydown',
    /// processEvent: function(view, record, node, index, event) {
    /// // Load the event with the extra information needed by the mappings
    /// event.view = view;
    /// event.store = view.getStore();
    /// event.record = record;
    /// event.index = index;
    /// return event;
    /// },
    /// binding: {
    /// key: <see cref="Ext.EventObject.DELETE">Ext.EventObject.DELETE</see>,
    /// fn: function(keyCode, e) {
    /// e.store.remove(e.record);
    /// // Attempt to select the record that's now in its place
    /// e.view.getSelectionModel().select(e.index);
    /// e.view.el.focus();
    /// }
    /// }
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class KeyMap : Ext.Base
    {
        /// <summary>
        /// Either a single object describing a handling function for s specified key (or set of keys), or
        /// an array of such objects.
        /// <li><span>key</span> : <see cref="String">String</see>/<see cref="String">String</see>[]<div><p>A single keycode or an array of keycodes to handle</p>
        /// </div></li><li><span>shift</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when shift is pressed, False to handle the
        /// key only when shift is not pressed (defaults to undefined)</p>
        /// </div></li><li><span>ctrl</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when ctrl is pressed, False to handle the
        /// key only when ctrl is not pressed (defaults to undefined)</p>
        /// </div></li><li><span>alt</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when alt is pressed, False to handle the key
        /// only when alt is not pressed (defaults to undefined)</p>
        /// </div></li><li><span>handler</span> : <see cref="Function">Function</see><div><p>The function to call when KeyMap finds the expected key combination</p>
        /// </div></li><li><span>fn</span> : <see cref="Function">Function</see><div><p>Alias of handler (for backwards-compatibility)</p>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div><p>The scope of the callback function</p>
        /// </div></li><li><span>defaultEventAction</span> : <see cref="String">String</see><div><p>A default action to apply to the event. Possible values
        /// are: stopEvent, stopPropagation, preventDefault. If no value is set no action is performed.</p>
        /// </div></li>
        /// </summary>
        public object binding;
        /// <summary>
        /// The event to listen for to pick up key events.
        /// Defaults to: <c>&quot;keydown&quot;</c>
        /// </summary>
        public JsString eventName;
        /// <summary>
        /// Configure this as true if there are any input fields within the target, and this KeyNav
        /// should not process events from input fields, (&amp;lt;input&gt;, &amp;lt;textarea&gt; and elements withcontentEditable="true"`)
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool ignoreInputFields;
        /// <summary>
        /// An optional event processor function which accepts the argument list provided by the
        /// configured event of the target, and returns a keyEvent for processing by the KeyMap.
        /// This may be useful when the <see cref="Ext.util.KeyMapConfig.target">target</see> is a Component with s complex event signature, where the event is not
        /// the first parameter. Extra information from the event arguments may be injected into the event for use by the handler
        /// functions before returning it.
        /// </summary>
        public System.Delegate processEvent;
        /// <summary>
        /// The scope (this context) in which the processEvent method is executed.
        /// Defaults to: <c>this</c>
        /// </summary>
        public JsObject processEventScope;
        /// <summary>
        /// The object on which to listen for the event specified by the eventName config option.
        /// </summary>
        public object target;
        /// <summary>
        /// Add a new binding to this KeyMap.
        /// Usage:
        /// <code>// Create a KeyMap
        /// var map = new <see cref="Ext.util.KeyMap">Ext.util.KeyMap</see>(document, {
        /// key: <see cref="Ext.EventObject.ENTER">Ext.EventObject.ENTER</see>,
        /// fn: handleKey,
        /// scope: this
        /// });
        /// //Add a new binding to the existing KeyMap later
        /// map.addBinding({
        /// key: 'abc',
        /// shift: true,
        /// fn: handleKey,
        /// scope: this
        /// });
        /// </code>
        /// </summary>
        /// <param name="binding"><p>A single KeyMap config or an array of configs.
        /// The following config object properties are supported:</p>
        /// <ul><li><span>key</span> : <see cref="String">String</see>/<see cref="Array">Array</see><div><p>A single keycode or an array of keycodes to handle.</p>
        /// </div></li><li><span>shift</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when shift is pressed,
        /// False to handle the keyonly when shift is not pressed (defaults to undefined).</p>
        /// </div></li><li><span>ctrl</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when ctrl is pressed,
        /// False to handle the key only when ctrl is not pressed (defaults to undefined).</p>
        /// </div></li><li><span>alt</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when alt is pressed,
        /// False to handle the key only when alt is not pressed (defaults to undefined).</p>
        /// </div></li><li><span>handler</span> : <see cref="Function">Function</see><div><p>The function to call when KeyMap finds the
        /// expected key combination.</p>
        /// </div></li><li><span>fn</span> : <see cref="Function">Function</see><div><p>Alias of handler (for backwards-compatibility).</p>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div><p>The scope of the callback function.</p>
        /// </div></li><li><span>defaultEventAction</span> : <see cref="String">String</see><div><p>A default action to apply to the event.
        /// Possible values are: stopEvent, stopPropagation, preventDefault. If no value is
        /// set no action is performed..</p>
        /// </div></li></ul></param>
        public void addBinding(object binding=null){}
        /// <summary>
        /// Check if the modifiers on the event match those on the binding
        /// </summary>
        /// <param name="binding">
        /// </param>
        /// <param name="event">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the event matches the binding</p>
        /// </div>
        /// </returns>
        private bool checkModifiers(object binding, EventObject @event){return false;}
        /// <summary>
        /// Destroys the KeyMap instance and removes all handlers.
        /// </summary>
        /// <param name="removeTarget"><p>True to also remove the <see cref="Ext.util.KeyMapConfig.target">target</see></p>
        /// </param>
        public void destroy(bool removeTarget){}
        /// <summary>
        /// Disable this KeyMap
        /// </summary>
        public void disable(){}
        /// <summary>
        /// Enables this KeyMap
        /// </summary>
        public void enable(){}
        /// <summary>
        /// Process the event from the target.
        /// </summary>
        /// <param name="event">
        /// </param>
        private void handleTargetEvent(EventObject @event){}
        /// <summary>
        /// Returns true if this KeyMap is enabled
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isEnabled(){return false;}
        /// <summary>
        /// Old constructor signature
        /// </summary>
        /// <param name="el"><p>The element or its ID, or Component to bind to</p>
        /// </param>
        /// <param name="binding"><p>The binding (see <see cref="Ext.util.KeyMap.addBinding">addBinding</see>)</p>
        /// </param>
        /// <param name="eventName"><p>The event to bind to</p>
        /// <p>Defaults to: <c>&quot;keydown&quot;</c></p></param>
        private void legacyConstructor(object el, object binding, object eventName=null){}
        /// <summary>
        /// Shorthand for adding a single key listener.
        /// </summary>
        /// <param name="key"><p>Either the numeric key code, array of key codes or an object with the
        /// following options: <c>{key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}</c></p>
        /// </param>
        /// <param name="fn"><p>The function to call</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the function is executed.
        /// Defaults to the browser window.</p>
        /// </param>
        public void on(object key, System.Delegate fn, object scope=null){}
        /// <summary>
        /// Process a particular binding and fire the handler if necessary.
        /// </summary>
        /// <param name="binding"><p>The binding information</p>
        /// </param>
        /// <param name="event">
        /// </param>
        private void processBinding(object binding, EventObject @event){}
        /// <summary>
        /// Convenience function for setting disabled/enabled by boolean.
        /// </summary>
        /// <param name="disabled">
        /// </param>
        public void setDisabled(bool disabled){}
        public KeyMap(KeyMapConfig config){}
        public KeyMap(){}
        public KeyMap(params object[] args){}
    }
    #endregion
    #region KeyMapConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class KeyMapConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Either a single object describing a handling function for s specified key (or set of keys), or
        /// an array of such objects.
        /// <li><span>key</span> : <see cref="String">String</see>/<see cref="String">String</see>[]<div><p>A single keycode or an array of keycodes to handle</p>
        /// </div></li><li><span>shift</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when shift is pressed, False to handle the
        /// key only when shift is not pressed (defaults to undefined)</p>
        /// </div></li><li><span>ctrl</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when ctrl is pressed, False to handle the
        /// key only when ctrl is not pressed (defaults to undefined)</p>
        /// </div></li><li><span>alt</span> : <see cref="bool">Boolean</see><div><p>True to handle key only when alt is pressed, False to handle the key
        /// only when alt is not pressed (defaults to undefined)</p>
        /// </div></li><li><span>handler</span> : <see cref="Function">Function</see><div><p>The function to call when KeyMap finds the expected key combination</p>
        /// </div></li><li><span>fn</span> : <see cref="Function">Function</see><div><p>Alias of handler (for backwards-compatibility)</p>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div><p>The scope of the callback function</p>
        /// </div></li><li><span>defaultEventAction</span> : <see cref="String">String</see><div><p>A default action to apply to the event. Possible values
        /// are: stopEvent, stopPropagation, preventDefault. If no value is set no action is performed.</p>
        /// </div></li>
        /// </summary>
        public object binding;
        /// <summary>
        /// The event to listen for to pick up key events.
        /// Defaults to: <c>&quot;keydown&quot;</c>
        /// </summary>
        public JsString eventName;
        /// <summary>
        /// Configure this as true if there are any input fields within the target, and this KeyNav
        /// should not process events from input fields, (&amp;lt;input&gt;, &amp;lt;textarea&gt; and elements withcontentEditable="true"`)
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool ignoreInputFields;
        /// <summary>
        /// An optional event processor function which accepts the argument list provided by the
        /// configured event of the target, and returns a keyEvent for processing by the KeyMap.
        /// This may be useful when the <see cref="Ext.util.KeyMapConfig.target">target</see> is a Component with s complex event signature, where the event is not
        /// the first parameter. Extra information from the event arguments may be injected into the event for use by the handler
        /// functions before returning it.
        /// </summary>
        public System.Delegate processEvent;
        /// <summary>
        /// The scope (this context) in which the processEvent method is executed.
        /// Defaults to: <c>this</c>
        /// </summary>
        public JsObject processEventScope;
        /// <summary>
        /// The object on which to listen for the event specified by the eventName config option.
        /// </summary>
        public object target;
        public KeyMapConfig(params object[] args){}
    }
    #endregion
    #region KeyMapEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class KeyMapEvents : Ext.BaseEvents
    {
        public KeyMapEvents(params object[] args){}
    }
    #endregion
}
#endregion
