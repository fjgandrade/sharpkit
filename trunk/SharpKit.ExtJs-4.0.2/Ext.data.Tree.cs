//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region Tree
    /// <summary>
    /// This class is used as a container for a series of nodes. The nodes themselves maintain
    /// the relationship between parent/child. The tree itself acts as a manager. It gives functionality
    /// to retrieve a node by its identifier: getNodeById. The tree also relays events from any of it&#39;s child nodes, allowing them to be handled in a
    /// centralized fashion. In general this class is not used directly, rather used internally
    /// by other parts of the framework.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Tree : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Creates new Tree object. ...
        /// </summary>
        public object constructor(Node root=null){return null;}
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
        /// Returns the root node for this tree. ...
        /// </summary>
        public NodeInterface getRootNode(){return null;}
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
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        public Node root{get;set;}
    }
    #endregion
    #region TreeConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TreeConfig
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
    }
    #endregion
    #region TreeEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TreeEvents
    {
        /// <summary>
        /// Fires when a new child node is appended to a node in this tree. ...
        /// </summary>
        public static JsString append="append";
        /// <summary>
        /// Fires before a new child is appended to a node in this tree, return false to cancel the append. ...
        /// </summary>
        public static JsString beforeappend="beforeappend";
        /// <summary>
        /// Fires before this node is collapsed. ...
        /// </summary>
        public static JsString beforecollapse="beforecollapse";
        /// <summary>
        /// Fires before this node is expanded. ...
        /// </summary>
        public static JsString beforeexpand="beforeexpand";
        /// <summary>
        /// Fires before a new child is inserted in a node in this tree, return false to cancel the insert. ...
        /// </summary>
        public static JsString beforeinsert="beforeinsert";
        /// <summary>
        /// Fires before a node is moved to a new location in the tree. ...
        /// </summary>
        public static JsString beforemove="beforemove";
        /// <summary>
        /// Fires before a child is removed from a node in this tree, return false to cancel the remove. ...
        /// </summary>
        public static JsString beforeremove="beforeremove";
        /// <summary>
        /// Fires when this node is collapsed. ...
        /// </summary>
        public static JsString collapse="collapse";
        /// <summary>
        /// Fires when this node is expanded. ...
        /// </summary>
        public static JsString expand="expand";
        /// <summary>
        /// Fires when a new child node is inserted in a node in this tree. ...
        /// </summary>
        public static JsString insert="insert";
        /// <summary>
        /// Fires when a node is moved to a new location in the tree ...
        /// </summary>
        public static JsString move="move";
        /// <summary>
        /// Fires when a child node is removed from a node in this tree. ...
        /// </summary>
        public static JsString remove="remove";
        /// <summary>
        /// Fires whenever the root node is changed in the tree. ...
        /// </summary>
        public static JsString rootchange="rootchange";
    }
    #endregion
}
#endregion
