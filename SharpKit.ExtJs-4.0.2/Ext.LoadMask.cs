//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region LoadMask
    /// <summary>
    /// A simple utility class for generically masking elements while loading data.  If the store
    /// config option is specified, the masking will be automatically synchronized with the store&#39;s loading
    /// process and the mask element will be cached for reuse. Example usage: // Basic mask:
    /// var myMask = new Ext.LoadMask(Ext.getBody(), {msg:&quot;Please wait...&quot;});
    /// myMask.show();
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class LoadMask : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Creates new LoadMask. ...
        /// </summary>
        public object constructor(object el, object config=null){return null;}
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
        /// Disables the mask to prevent it from being displayed ...
        /// </summary>
        public object disable(){return null;}
        /// <summary>
        /// Enables the mask so that it can be displayed ...
        /// </summary>
        public object enable(){return null;}
        /// <summary>
        /// Hide this LoadMask. ...
        /// </summary>
        public object hide(){return null;}
        /// <summary>
        /// Method to determine whether this LoadMask is currently disabled. ...
        /// </summary>
        public bool isDisabled(){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Show this LoadMask over the configured Element. ...
        /// </summary>
        public object show(){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Read-only. ...
        /// </summary>
        public bool disabled{get;set;}
    }
    #endregion
    #region LoadMaskConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class LoadMaskConfig
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        public JsString msg{get;set;}
        public JsString msgCls{get;set;}
        /// <summary>
        /// Optional Store to which the mask is bound. ...
        /// </summary>
        public Ext.data.Store store{get;set;}
        public bool useMsg{get;set;}
    }
    #endregion
    #region LoadMaskEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class LoadMaskEvents
    {
    }
    #endregion
}
#endregion
