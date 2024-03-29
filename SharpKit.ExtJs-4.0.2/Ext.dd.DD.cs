//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.Unknown;
#region Ext.dd
namespace Ext.dd
{
    #region DD
    /// <summary>
    /// A DragDrop implementation where the linked element follows the
    /// mouse cursor during a drag.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DD : Ext.dd.DragDrop
    {
        /// <summary>
        /// Creates new DD instance. ...
        /// </summary>
        public DD(JsString id, JsString sGroup, object config){}
        /// <summary>
        /// Sets the element to the location of the mousedown or click event,
        /// maintaining the cursor location relative to the loc...
        /// </summary>
        public object alignElWithMouse(HTMLElement el, JsNumber iPageX, JsNumber iPageY){return null;}
        /// <summary>
        /// Sets up config options specific to this class. ...
        /// </summary>
        public new object applyConfig(){return null;}
        /// <summary>
        /// Sets the pointer offset to the distance between the linked element's top
        /// left corner and the location the element was...
        /// </summary>
        public object autoOffset(JsNumber iPageX, JsNumber iPageY){return null;}
        /// <summary>
        /// Event that fires prior to the onDrag event. ...
        /// </summary>
        public object b4Drag(object e){return null;}
        /// <summary>
        /// Event that fires prior to the onMouseDown event. ...
        /// </summary>
        public object b4MouseDown(object e){return null;}
        /// <summary>
        /// Saves the most recent position so that we can reset the constraints and
        /// tick marks on-demand. ...
        /// </summary>
        public object cachePosition(object iPageX, object iPageY){return null;}
        /// <summary>
        /// Sets the pointer offset. ...
        /// </summary>
        public object setDelta(JsNumber iDeltaX, JsNumber iDeltaY){return null;}
        /// <summary>
        /// Sets the drag element to the location of the mousedown or click event,
        /// maintaining the cursor location relative to th...
        /// </summary>
        public object setDragElPos(JsNumber iPageX, JsNumber iPageY){return null;}
        /// <summary>
        /// When set to true, the utility automatically tries to scroll the browser
        /// window when a drag and drop element is dragge...
        /// </summary>
        public bool scroll{get;set;}
        public DD(DDConfig config){}
        public DD(){}
    }
    #endregion
    #region DDConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DDConfig : Ext.dd.DragDropConfig
    {
    }
    #endregion
    #region DDEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DDEvents : Ext.dd.DragDropEvents
    {
    }
    #endregion
}
#endregion
