//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.resizer
namespace Ext.resizer
{
    #region Resizer
    /// <summary>
    /// Applies drag handles to an element or component to make it resizable. The
    /// drag handles are inserted into the element (or component&#39;s element) and
    /// positioned absolute. Textarea and img elements will be wrapped with an additional div because
    /// these elements do not support child nodes. The original element can be accessed
    /// through the originalTarget property. Here is the list of valid resize handles: Value   Description
    /// ------  -------------------
    /// &#39;n&#39;     north
    /// &#39;s&#39;     south
    /// &#39;e&#39;     east
    /// &#39;w&#39;     west
    /// &#39;nw&#39;    northwest
    /// &#39;sw&#39;    southwest
    /// &#39;se&#39;    southeast
    /// &#39;ne&#39;    northeast
    /// &#39;all&#39;   all
    /// Here&#39;s an example showing the creation of a typical Resizer:
    /// Ext.create(&#39;Ext.resizer.Resizer&#39;, {
    /// el: &#39;elToResize&#39;,
    /// handles: &#39;all&#39;,
    /// minWidth: 200,
    /// minHeight: 100,
    /// maxWidth: 500,
    /// maxHeight: 400,
    /// pinned: true
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Resizer : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Returns the element that was configured with the el or target config property. ...
        /// </summary>
        public Ext.Element getEl(){return null;}
        /// <summary>
        /// Returns the element or component that was configured with the target config property. ...
        /// </summary>
        public object getTarget(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Perform a manual resize and fires the 'resize' event. ...
        /// </summary>
        public object resizeTo(JsNumber width, JsNumber height){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        public Ext.core.Element el{get;set;}
        /// <summary>
        /// Reference to the original resize target if the element of the original
        /// resize target was an IMG or a TEXTAREA which m...
        /// </summary>
        public object originalTarget{get;set;}
        public ResizeTracker resizeTracker{get;set;}
        public Resizer(ResizerConfig config){}
        public Resizer(){}
    }
    #endregion
    #region ResizerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ResizerConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Optional. ...
        /// </summary>
        public object constrainTo{get;set;}
        /// <summary>
        /// Specify as true to update the target (Element or Component) dynamically during dragging. ...
        /// </summary>
        public bool dynamic{get;set;}
        /// <summary>
        /// String consisting of the resize handles to display. ...
        /// </summary>
        public JsString handles{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public JsNumber height{get;set;}
        /// <summary>
        /// The increment to snap the height resize in pixels. ...
        /// </summary>
        public JsNumber heightIncrement{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        public JsNumber maxHeight{get;set;}
        public JsNumber maxWidth{get;set;}
        public JsNumber minHeight{get;set;}
        public JsNumber minWidth{get;set;}
        /// <summary>
        /// True to ensure that the resize handles are always
        /// visible, false indicates resizing by cursor changes only (defaults ...
        /// </summary>
        public bool pinned{get;set;}
        public bool preserveRatio{get;set;}
        public object target{get;set;}
        /// <summary>
        /// True for transparent handles. ...
        /// </summary>
        public bool transparent{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public JsNumber width{get;set;}
        public JsNumber widthIncrement{get;set;}
    }
    #endregion
    #region ResizerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ResizerEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fired before resize is allowed. ...
        /// </summary>
        public static JsString beforeresize="beforeresize";
        /// <summary>
        /// Fired after a resize. ...
        /// </summary>
        public static JsString resize="resize";
        /// <summary>
        /// Fires during resizing. ...
        /// </summary>
        public static JsString resizedrag="resizedrag";
    }
    #endregion
}
#endregion
