//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.tree
{
    #region View
    /// <inheritdocs />
    /// <summary>
    /// <p>Used as a view by <see cref="Ext.tree.Panel">TreePanel</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class View : Ext.view.Table
    {
        /// <summary>
        /// False to hide the root node.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool rootVisible;
        /// <summary>
        /// Collapses a record that is loaded in the view.
        /// </summary>
        /// <param name="record"><p>The record to collapse</p>
        /// </param>
        /// <param name="deep"><p>True to collapse nodes all the way up the tree hierarchy.</p>
        /// </param>
        /// <param name="callback"><p>The function to run after the collapse is completed</p>
        /// </param>
        /// <param name="scope"><p>The scope of the callback function.</p>
        /// </param>
        public void collapse(Ext.data.Model record, object deep=null, object callback=null, object scope=null){}
        /// <summary>
        /// Parameters<li><span>record</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>index</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="record">
        /// </param>
        /// <param name="index">
        /// </param>
        private void createAnimWrap(object record, object index){}
        /// <summary>
        /// Expands a record that is loaded in the view.
        /// </summary>
        /// <param name="record"><p>The record to expand</p>
        /// </param>
        /// <param name="deep"><p>True to expand nodes all the way down the tree hierarchy.</p>
        /// </param>
        /// <param name="callback"><p>The function to run after the expand is completed</p>
        /// </param>
        /// <param name="scope"><p>The scope of the callback function.</p>
        /// </param>
        public void expand(Ext.data.Model record, object deep=null, object callback=null, object scope=null){}
        /// <summary>
        /// Returns the animation wrapper element for the specified parent node, used to wrap the child nodes as
        /// they slide up or down during expand/collapse.
        /// </summary>
        /// <param name="parent"><p>The parent node to be expanded or collapsed</p>
        /// </param>
        /// <param name="bubble"><p>If the passed parent node does not already have a wrap element created, by default
        /// this function will bubble up to each parent node looking for a valid wrap element to reuse, returning
        /// the first one it finds. This is the appropriate behavior, e.g., for the collapse direction, so that the
        /// entire expanded set of branch nodes can collapse as a single unit.</p>
        /// <p>However for expanding each parent node should instead always create its own animation wrap if one
        /// doesn't exist, so that its children can expand independently of any other nodes -- this is crucial
        /// when executing the "expand all" behavior. If multiple nodes attempt to reuse the same ancestor wrap
        /// element concurrently during expansion it will lead to problems as the first animation to complete will
        /// delete the wrap el out from under other running animations. For that reason, when expanding you should
        /// always pass <c>bubble: false</c> to be on the safe side.</p>
        /// <p>If the passed parent has no wrap (or there is no valid ancestor wrap after bubbling), this function
        /// will return null and the calling code should then call <see cref="Ext.tree.View">createAnimWrap</see> if needed.</p>
        /// <p>Defaults to: <c>true</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The wrapping element as created in <see cref="Ext.tree.View">createAnimWrap</see>, or null</p>
        /// </div>
        /// </returns>
        private Ext.dom.Element getAnimWrap(object parent, object bubble=null){return null;}
        /// <summary>
        /// Gets the base TreeStore from the bound TreePanel.
        /// </summary>
        public void getTreeStore(){}
        /// <summary>
        /// Checks if a node is currently undergoing animation
        /// </summary>
        /// <param name="node"><p>The node</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the node is animating</p>
        /// </div>
        /// </returns>
        private bool isAnimating(Ext.data.Model node){return false;}
        /// <summary>
        /// Re-fires the NodeStore's "datachanged" event as a TreeStore event
        /// </summary>
        /// <param name="store">
        /// </param>
        /// <param name="operation">
        /// </param>
        private void onStoreDataChanged(Ext.data.NodeStore store, Ext.data.Operation operation){}
        /// <summary>
        /// Re-fires the NodeStore's "write" event as a TreeStore event
        /// </summary>
        /// <param name="store">
        /// </param>
        /// <param name="operation">
        /// </param>
        private void onStoreWrite(Ext.data.NodeStore store, Ext.data.Operation operation){}
        /// <summary>
        /// Toggles a record between expanded and collapsed.
        /// </summary>
        /// <param name="record">
        /// </param>
        /// <param name="deep"><p>True to collapse nodes all the way up the tree hierarchy.</p>
        /// </param>
        /// <param name="callback"><p>The function to run after the expand/collapse is completed</p>
        /// </param>
        /// <param name="scope"><p>The scope of the callback function.</p>
        /// </param>
        public void toggle(Ext.data.Model record, object deep=null, object callback=null, object scope=null){}
        public View(Ext.tree.ViewConfig config){}
        public View(){}
        public View(params object[] args){}
    }
    #endregion
    #region ViewConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ViewConfig : Ext.view.TableConfig
    {
        /// <summary>
        /// True to enable animated expand/collapse (defaults to the value of Ext.enableFx)
        /// </summary>
        public bool animate;
        /// <summary>
        /// False to hide the root node.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool rootVisible;
        public ViewConfig(params object[] args){}
    }
    #endregion
    #region ViewEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ViewEvents : Ext.view.TableEvents
    {
        /// <summary>
        /// Fires after an item has been visually collapsed and is no longer visible in the tree.
        /// </summary>
        /// <param name="node"><p>The node that was collapsed</p>
        /// </param>
        /// <param name="index"><p>The index of the node</p>
        /// </param>
        /// <param name="item"><p>The HTML element for the node that was collapsed</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void afteritemcollapse(Ext.data.NodeInterface node, JsNumber index, object item, object eOpts){}
        /// <summary>
        /// Fires after an item has been visually expanded and is visible in the tree.
        /// </summary>
        /// <param name="node"><p>The node that was expanded</p>
        /// </param>
        /// <param name="index"><p>The index of the node</p>
        /// </param>
        /// <param name="item"><p>The HTML element for the node that was expanded</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void afteritemexpand(Ext.data.NodeInterface node, JsNumber index, object item, object eOpts){}
        public ViewEvents(params object[] args){}
    }
    #endregion
}
