//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.selection
namespace Ext.selection
{
    #region CheckboxModel
    /// <summary>
    /// A selection model that renders a column of checkboxes that can be toggled to
    /// select or deselect rows. The default mode for this selection model is MULTI. The selection model will inject a header for the checkboxes in the first view
    /// and according to the &#39;injectCheckbox&#39; configuration.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class CheckboxModel : RowModel
    {
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public new object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public new object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public new object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public new object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public new object clearManagedListeners(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public new object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public new bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Retrieve a configuration to be used in a HeaderContainer. ...
        /// </summary>
        public object getHeaderConfig(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public new bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public new object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public new object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public new object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Toggle between selecting all and deselecting all when clicking on
        /// a checkbox header. ...
        /// </summary>
        public object onHeaderClick(object headerCt, object header, object e){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public new object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public new object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public new object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Generates the HTML to be rendered in the injected checkbox column for each row. ...
        /// </summary>
        public object renderer(object value, object metaData, object record, object rowIndex, object colIndex, object store, object view){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public new object resumeEvents(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public new object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public new object un(JsString eventName, JsAction handler, object scope=null){return null;}
        public CheckboxModel(CheckboxModelConfig config){}
        public CheckboxModel(){}
    }
    #endregion
    #region CheckboxModelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckboxModelConfig : RowModelConfig
    {
        public bool checkOnly{get;set;}
        /// <summary>
        /// Instructs the SelectionModel whether or not to inject the checkbox header
        /// automatically or not. ...
        /// </summary>
        public object injectCheckbox{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public new object listeners{get;set;}
        /// <summary>
        /// Modes of selection. ...
        /// </summary>
        public new JsString mode{get;set;}
    }
    #endregion
    #region CheckboxModelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckboxModelEvents : RowModelEvents
    {
    }
    #endregion
}
#endregion
