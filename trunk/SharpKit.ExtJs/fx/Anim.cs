//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.fx
namespace Ext.fx
{
    #region Anim
    /// <summary>
    /// This class manages animation for a specific target. The animation allows
    /// animation of various properties on the target, such as size, position, color and others. Starting Conditions The starting conditions for the animation are provided by the from configuration.
    /// Any/all of the properties in the from configuration can be specified. If a particular
    /// property is not defined, the starting value for that property will be read directly from the target. End Conditions The ending conditions for the animation are provided by the to configuration. These mark
    /// the final values once the animations has finished. The values in the from can mirror
    /// those in the to configuration to provide a starting point. Other Options  duration: Specifies the time period of the animation. easing: Specifies the easing of the animation. iterations: Allows the animation to repeat a number of times. alternate: Used in conjunction with iterations, reverses the direction every second iteration.  Example Code var myComponent = Ext.create(&#39;Ext.Component&#39;, {
    /// renderTo: document.body,
    /// width: 200,
    /// height: 200,
    /// style: &#39;border: 1px solid red;&#39;
    /// });
    /// new Ext.fx.Anim({
    /// target: myComponent,
    /// duration: 1000,
    /// from: {
    /// width: 400 //starting width 400
    /// },
    /// to: {
    /// width: 300, //end width 300
    /// height: 300 // end width 300
    /// }
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Anim : Ext.Base, Ext.util.Observable
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
        public JsNumber currentIteration{get;set;}
        /// <summary>
        /// Flag to determine if the animation is paused. ...
        /// </summary>
        public bool paused{get;set;}
        public bool running{get;set;}
        public JsDate startTime{get;set;}
        public Anim(AnimConfig config){}
        public Anim(){}
    }
    #endregion
    #region AnimConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AnimConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Used in conjunction with iterations to reverse the animation each time an iteration completes. ...
        /// </summary>
        public bool alternate{get;set;}
        /// <summary>
        /// Time to delay before starting the animation. ...
        /// </summary>
        public JsNumber delay{get;set;}
        /// <summary>
        /// Time in milliseconds for a single animation to last. ...
        /// </summary>
        public JsNumber duration{get;set;}
        /// <summary>
        /// Currently only for Component Animation: Only set a component's outer element size bypassing layouts. ...
        /// </summary>
        public bool dynamic{get;set;}
        /// <summary>
        /// This describes how the intermediate values used during a transition will be calculated. ...
        /// </summary>
        public JsString easing{get;set;}
        /// <summary>
        /// An object containing property/value pairs for the beginning of the animation. ...
        /// </summary>
        public object from{get;set;}
        /// <summary>
        /// Number of times to execute the animation. ...
        /// </summary>
        public JsNumber iterations{get;set;}
        /// <summary>
        /// Animation keyframes follow the CSS3 Animation configuration pattern. ...
        /// </summary>
        public object keyframes{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        public bool reverse{get;set;}
        /// <summary>
        /// The Ext.fx.target.Target to apply the animation to. ...
        /// </summary>
        public object target{get;set;}
        /// <summary>
        /// An object containing property/value pairs for the end of the animation. ...
        /// </summary>
        public object to{get;set;}
    }
    #endregion
    #region AnimEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AnimEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when the animation is complete. ...
        /// </summary>
        public static JsString afteranimate="afteranimate";
        /// <summary>
        /// Fires before the animation starts. ...
        /// </summary>
        public static JsString beforeanimate="beforeanimate";
        /// <summary>
        /// Fires when the animation's last frame has been set. ...
        /// </summary>
        public static JsString lastframe="lastframe";
    }
    #endregion
}
#endregion
