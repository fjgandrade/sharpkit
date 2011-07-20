//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.panel
namespace Ext.panel
{
    #region AbstractPanel
    /// <summary>
    /// A base class which provides methods common to Panel classes across the Sencha product range. Please refer to sub class&#39;s documentation
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class AbstractPanel : Ext.container.Container, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Adds docked item(s) to the panel. ...
        /// </summary>
        public object addDocked(object component, JsNumber pos=null){return null;}
        /// <summary>
        /// Attempts a default component lookup (see Ext.container.Container.getComponent). ...
        /// </summary>
        public new Ext.Component getComponent(object comp){return null;}
        /// <summary>
        /// Finds a docked component by id, itemId or position. ...
        /// </summary>
        public Ext.Component getDockedComponent(object comp){return null;}
        /// <summary>
        /// Retrieve an array of all currently docked Components. ...
        /// </summary>
        public JsArray getDockedItems(JsString cqSelector){return null;}
        /// <summary>
        /// Inserts docked item(s) to the panel at the indicated position. ...
        /// </summary>
        public object insertDocked(JsNumber pos, object component){return null;}
        /// <summary>
        /// Removes the docked item from the panel. ...
        /// </summary>
        public object removeDocked(Ext.Component item, bool autoDestroy=false){return null;}
    }
    #endregion
    #region AbstractPanelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractPanelConfig
    {
        public JsString baseCls{get;set;}
        /// <summary>
        /// A shortcut to add or remove the border on the body of a panel. ...
        /// </summary>
        public bool bodyBorder{get;set;}
        /// <summary>
        /// A CSS class, space-delimited string of classes, or array of classes to be applied to the panel's body element. ...
        /// </summary>
        public object bodyCls{get;set;}
        /// <summary>
        /// A shortcut for setting a padding style on the body element. ...
        /// </summary>
        public object bodyPadding{get;set;}
        /// <summary>
        /// Custom CSS styles to be applied to the panel's body element, which can be supplied as a valid CSS style string,
        /// an ob...
        /// </summary>
        public object bodyStyle{get;set;}
        /// <summary>
        /// This object holds the default weights applied to dockedItems that have no weight. ...
        /// </summary>
        public object defaultDockWeights{get;set;}
        /// <summary>
        /// A component or series of components to be added as docked items to this panel. ...
        /// </summary>
        public object dockedItems{get;set;}
    }
    #endregion
    #region AbstractPanelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractPanelEvents
    {
        /// <summary>
        /// Fires after the Panel has been resized. ...
        /// </summary>
        public static JsString bodyresize="bodyresize";
    }
    #endregion
}
#endregion
