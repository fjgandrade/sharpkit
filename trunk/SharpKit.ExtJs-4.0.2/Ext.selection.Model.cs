//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.selection
namespace Ext.selection
{
    #region Model
    /// <summary>
    /// Tracks what records are currently selected in a databound widget. This is an abstract class and is not meant to be directly used. DataBound UI widgets such as GridPanel, TreePanel, and ListView
    /// should subclass AbstractStoreSelectionModel and provide a way
    /// to binding to the component. The abstract methods onSelectChange and onLastFocusChanged should
    /// be implemented in these subclasses to update the UI widget.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Model : Ext.util.Observable
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
        /// Deselects a record instance by record instance or index. ...
        /// </summary>
        public object deselect(object records, bool suppressEvent){return null;}
        /// <summary>
        /// Deselect all records in the view. ...
        /// </summary>
        public object deselectAll(bool suppressEvent){return null;}
        /// <summary>
        /// Deselect all records in the view. ...
        /// </summary>
        public void deselectAll() { }
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
        /// Gets the count of selected records. ...
        /// </summary>
        public JsNumber getCount(){return null;}
        /// <summary>
        /// Returns the last selected record. ...
        /// </summary>
        public object getLastSelected(){return null;}
        /// <summary>
        /// Returns an array of the currently selected records. ...
        /// </summary>
        public JsArray getSelection(){return null;}
        /// <summary>
        /// Returns the current selectionMode. ...
        /// </summary>
        public JsString getSelectionMode(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Returns true if there are any a selected records. ...
        /// </summary>
        public bool hasSelection(){return false;}
        /// <summary>
        /// Determines if this record is currently focused. ...
        /// </summary>
        public object isFocused(object Ext){return null;}
        /// <summary>
        /// Returns true if the selections are locked. ...
        /// </summary>
        public bool isLocked(){return false;}
        /// <summary>
        /// Returns true if the specified row is selected. ...
        /// </summary>
        public bool isSelected(object record){return false;}
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
        /// Selects a record instance by record instance or index. ...
        /// </summary>
        public object select(object records, bool keepExisting, bool suppressEvent){return null;}
        /// <summary>
        /// Select all records in the view. ...
        /// </summary>
        public object selectAll(bool suppressEvent){return null;}
        /// <summary>
        /// ...
        /// </summary>
        public object setLastFocused(Ext.data.Model record, object supressFocus){return null;}
        /// <summary>
        /// Locks the current selection and disables any changes from
        /// happening to the selection. ...
        /// </summary>
        public object setLocked(bool locked){return null;}
        /// <summary>
        /// Sets the current selectionMode. ...
        /// </summary>
        public object setSelectionMode(object selMode){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        public object selected{get;set;}
        public Model(Ext.selection.ModelConfig config){}
        public Model(){}
    }
    #endregion
    #region ModelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ModelConfig : Ext.util.ObservableConfig
    {
        /// <summary>
        /// Allow users to deselect a record in a DataView, List or Grid. ...
        /// </summary>
        public bool allowDeselect{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public new object listeners{get;set;}
        /// <summary>
        /// Modes of selection. ...
        /// </summary>
        public JsString mode{get;set;}
    }
    #endregion
    #region ModelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ModelEvents : Ext.util.ObservableEvents
    {
        /// <summary>
        /// Fired after a selection change has occurred ...
        /// </summary>
        public static JsString selectionchange="selectionchange";
    }
    #endregion
}
#endregion
