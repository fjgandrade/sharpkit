//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dd
{
    #region DragSource
    /// <inheritdocs />
    /// <summary>
    /// <p>A simple class that provides the basic implementation needed to make any element draggable.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DragSource : DDProxy
    {
        /// <summary>
        /// If true, animates the proxy element back to the position of the handle element used to trigger the drag.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool animRepair;
        /// <summary>
        /// A named drag drop group to which this object belongs.  If a group is specified, then this object will only
        /// interact with other drag drop objects in the same group.
        /// </summary>
        public JsString ddGroup;
        /// <summary>
        /// The CSS class returned to the drag source when drop is allowed.
        /// Defaults to: <c>&quot;x-dd-drop-ok&quot;</c>
        /// </summary>
        public JsString dropAllowed;
        /// <summary>
        /// The CSS class returned to the drag source when drop is not allowed.
        /// Defaults to: <c>&quot;x-dd-drop-nodrop&quot;</c>
        /// </summary>
        public JsString dropNotAllowed;
        /// <summary>
        /// The color to use when visually highlighting the drag source in the afterRepair
        /// method after a failed drop (defaults to light blue). The color must be a 6 digit hex value, without
        /// a preceding '#'.
        /// Defaults to: <c>&quot;c3daf9&quot;</c>
        /// </summary>
        public JsString repairHighlightColor;
        /// <summary>
        /// Creates new drag-source.
        /// </summary>
        /// <param name="el"><p>The container element or ID of it.</p>
        /// </param>
        /// <param name="config"><p>Config object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public DragSource(object el, object config=null){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// after a valid drag drop has occurred by providing an implementation.
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dropped element</p>
        /// </param>
        public void afterDragDrop(Ext.dd.DragDrop target, object e, JsString id){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// when the dragged item enters the drop target by providing an implementation.
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        public void afterDragEnter(Ext.dd.DragDrop target, object e, JsString id){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// after the dragged item is dragged out of the target without dropping.
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        public void afterDragOut(Ext.dd.DragDrop target, object e, JsString id){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// while the dragged item is over the drop target by providing an implementation.
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        public void afterDragOver(Ext.dd.DragDrop target, object e, JsString id){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// after an invalid drop has occurred by providing an implementation.
        /// </summary>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dropped element</p>
        /// </param>
        public void afterInvalidDrop(object e, JsString id){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// after a valid drop has occurred by providing an implementation.
        /// </summary>
        /// <param name="target"><p>The target DD</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dropped element</p>
        /// </param>
        public void afterValidDrop(object target, object e, JsString id){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the dragged
        /// item is dropped onto the target and optionally cancel the onDragDrop.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>isValid True if the drag drop event is valid, else false to cancel</p>
        /// </div>
        /// </returns>
        public virtual bool beforeDragDrop(Ext.dd.DragDrop target, object e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// before the dragged item enters the drop target and optionally cancel the onDragEnter.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>isValid True if the drag event is valid, else false to cancel</p>
        /// </div>
        /// </returns>
        public virtual bool beforeDragEnter(Ext.dd.DragDrop target, object e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the dragged
        /// item is dragged out of the target without dropping, and optionally cancel the onDragOut.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>isValid True if the drag event is valid, else false to cancel</p>
        /// </div>
        /// </returns>
        public virtual bool beforeDragOut(Ext.dd.DragDrop target, object e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// while the dragged item is over the drop target and optionally cancel the onDragOver.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>isValid True if the drag event is valid, else false to cancel</p>
        /// </div>
        /// </returns>
        public virtual bool beforeDragOver(Ext.dd.DragDrop target, object e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action after an invalid
        /// drop has occurred.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="target"><p>The drop target</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <param name="id"><p>The id of the dragged element</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>isValid True if the invalid drop should proceed, else false to cancel</p>
        /// </div>
        /// </returns>
        public virtual bool beforeInvalidDrop(Ext.dd.DragDrop target, object e, JsString id){return false;}
        /// <summary>
        /// Returns the data object associated with this drag source
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>data An object containing arbitrary data</p>
        /// </div>
        /// </returns>
        public object getDragData(object e){return null;}
        /// <summary>
        /// Returns the drag source's underlying Ext.dd.StatusProxy
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.dd.StatusProxy">Ext.dd.StatusProxy</see></span><div><p>proxy The StatusProxy</p>
        /// </div>
        /// </returns>
        public StatusProxy getProxy(){return null;}
        /// <summary>
        /// Hides the drag source's Ext.dd.StatusProxy
        /// </summary>
        public void hideProxy(){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the initial
        /// drag event begins and optionally cancel it.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="data"><p>An object containing arbitrary data to be shared with drop targets</p>
        /// </param>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>isValid True if the drag event is valid, else false to cancel</p>
        /// </div>
        /// </returns>
        public virtual bool onBeforeDrag(object data, object e){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action once the initial
        /// drag event has begun.  The drag cannot be canceled from this function.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="x"><p>The x position of the click on the dragged object</p>
        /// </param>
        /// <param name="y"><p>The y position of the click on the dragged object</p>
        /// </param>
        public virtual void onStartDrag(JsNumber x, JsNumber y){}
        public DragSource(DragSourceConfig config){}
        public DragSource(){}
        public DragSource(params object[] args){}
    }
    #endregion
    #region DragSourceConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DragSourceConfig : DDProxyConfig
    {
        /// <summary>
        /// If true, animates the proxy element back to the position of the handle element used to trigger the drag.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool animRepair;
        /// <summary>
        /// A named drag drop group to which this object belongs.  If a group is specified, then this object will only
        /// interact with other drag drop objects in the same group.
        /// </summary>
        public JsString ddGroup;
        /// <summary>
        /// The CSS class returned to the drag source when drop is allowed.
        /// Defaults to: <c>&quot;x-dd-drop-ok&quot;</c>
        /// </summary>
        public JsString dropAllowed;
        /// <summary>
        /// The CSS class returned to the drag source when drop is not allowed.
        /// Defaults to: <c>&quot;x-dd-drop-nodrop&quot;</c>
        /// </summary>
        public JsString dropNotAllowed;
        /// <summary>
        /// The color to use when visually highlighting the drag source in the afterRepair
        /// method after a failed drop (defaults to light blue). The color must be a 6 digit hex value, without
        /// a preceding '#'.
        /// Defaults to: <c>&quot;c3daf9&quot;</c>
        /// </summary>
        public JsString repairHighlightColor;
        public DragSourceConfig(params object[] args){}
    }
    #endregion
    #region DragSourceEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DragSourceEvents : DDProxyEvents
    {
        public DragSourceEvents(params object[] args){}
    }
    #endregion
}
