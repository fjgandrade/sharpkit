//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.panel
namespace Ext.panel
{
    #region Table
    /// <summary>
    /// TablePanel is the basis of both TreePanel and GridPanel. TablePanel aggregates:  a Selection Model a View a Store Scrollers Ext.grid.header.Container
    /// </summary>
    [JsType(JsMode.Prototype, Export=false,OmitOptionalParameters = true)]
    public partial class Table : Ext.panel.Panel, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Request a recalculation of scrollbars and put them in if they are needed. ...
        /// </summary>
        public object determineScrollbars(){return null;}
        /// <summary>
        /// Returns the selection model being used and creates it via the configuration
        /// if it has not been created already. ...
        /// </summary>
        public Ext.selection.Model getSelectionModel(){return null;}
        /// <summary>
        /// Returns the store associated with this Panel. ...
        /// </summary>
        public Ext.data.Store getStore(){return null;}
        /// <summary>
        /// Gets the view for this panel. ...
        /// </summary>
        public Ext.view.Table getView(){return null;}
        /// <summary>
        /// Hide the verticalScroller and remove the horizontalScrollerPresentCls. ...
        /// </summary>
        public object hideHorizontalScroller(){return null;}
        /// <summary>
        /// Hide the verticalScroller and remove the verticalScrollerPresentCls. ...
        /// </summary>
        public object hideVerticalScroller(){return null;}
        /// <summary>
        /// Returns the horizontal scroller config. ...
        /// </summary>
        public object initHorizontalScroller(){return null;}
        /// <summary>
        /// Returns the vertical scroller config. ...
        /// </summary>
        public object initVerticalScroller(){return null;}
        /// <summary>
        /// Invalides scrollers that are present and forces a recalculation. ...
        /// </summary>
        public object invalidateScroller(){return null;}
        /// <summary>
        /// Reconfigure the table with a new store/column. ...
        /// </summary>
        public object reconfigure(Ext.data.Store store, JsArray columns=null){return null;}
        /// <summary>
        /// Scrolls the TablePanel by deltaX ...
        /// </summary>
        public object scrollByDeltaX(JsNumber deltaY){return null;}
        /// <summary>
        /// Scrolls the TablePanel by deltaY ...
        /// </summary>
        public object scrollByDeltaY(JsNumber deltaY){return null;}
        /// <summary>
        /// Sets the scrollTop of the TablePanel. ...
        /// </summary>
        public object setScrollTop(JsNumber deltaY){return null;}
        /// <summary>
        /// Show the horizontalScroller and add the horizontalScrollerPresentCls. ...
        /// </summary>
        public object showHorizontalScroller(){return null;}
        /// <summary>
        /// Show the verticalScroller and add the verticalScrollerPresentCls. ...
        /// </summary>
        public object showVerticalScroller(){return null;}
        public bool hasView{get;set;}
        public Table(Ext.panel.TableConfig config){}
        public Table(){}
    }
    #endregion
    #region TableConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TableConfig : Ext.panel.PanelConfig
    {
        /// <summary>
        /// An array of column definition objects which define all columns that appear in this grid. ...
        /// </summary>
        public JsArray columns{get;set;}
        /// <summary>
        /// Defaults to true to enable deferred row rendering. ...
        /// </summary>
        public bool deferRowRender{get;set;}
        /// <summary>
        /// Defaults to true. ...
        /// </summary>
        public bool enableColumnHide{get;set;}
        /// <summary>
        /// Defaults to true. ...
        /// </summary>
        public bool enableColumnMove{get;set;}
        /// <summary>
        /// Defaults to true. ...
        /// </summary>
        public bool enableColumnResize{get;set;}
        /// <summary>
        /// Specify as true to force the columns to fit into the available width. ...
        /// </summary>
        public bool forceFit{get;set;}
        public bool hideHeaders{get;set;}
        /// <summary>
        /// Valid values are 'both', 'horizontal' or 'vertical'. ...
        /// </summary>
        public object scroll{get;set;}
        /// <summary>
        /// Number of pixels to scroll when scrolling with mousewheel. ...
        /// </summary>
        public JsNumber scrollDelta{get;set;}
        /// <summary>
        /// Defaults to true. ...
        /// </summary>
        public bool sortableColumns{get;set;}
    }
    #endregion
    #region TableEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TableEvents : Ext.panel.PanelEvents
    {
        /// <summary>
        /// Fires before the click event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainerclick="beforecontainerclick";
        /// <summary>
        /// Fires before the contextmenu event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainercontextmenu="beforecontainercontextmenu";
        /// <summary>
        /// Fires before the dblclick event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainerdblclick="beforecontainerdblclick";
        /// <summary>
        /// Fires before the mousedown event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermousedown="beforecontainermousedown";
        /// <summary>
        /// Fires before the mouseout event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermouseout="beforecontainermouseout";
        /// <summary>
        /// Fires before the mouseover event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermouseover="beforecontainermouseover";
        /// <summary>
        /// Fires before the mouseup event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermouseup="beforecontainermouseup";
        /// <summary>
        /// Fires before the click event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemclick="beforeitemclick";
        /// <summary>
        /// Fires before the contextmenu event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemcontextmenu="beforeitemcontextmenu";
        /// <summary>
        /// Fires before the dblclick event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemdblclick="beforeitemdblclick";
        /// <summary>
        /// Fires before the mousedown event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmousedown="beforeitemmousedown";
        /// <summary>
        /// Fires before the mouseenter event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmouseenter="beforeitemmouseenter";
        /// <summary>
        /// Fires before the mouseleave event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmouseleave="beforeitemmouseleave";
        /// <summary>
        /// Fires before the mouseup event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmouseup="beforeitemmouseup";
        /// <summary>
        /// Fires before a selection is made. ...
        /// </summary>
        public static JsString beforeselect="beforeselect";
        /// <summary>
        /// Fires when the container is clicked. ...
        /// </summary>
        public static JsString containerclick="containerclick";
        /// <summary>
        /// Fires when the container is right clicked. ...
        /// </summary>
        public static JsString containercontextmenu="containercontextmenu";
        /// <summary>
        /// Fires when the container is double clicked. ...
        /// </summary>
        public static JsString containerdblclick="containerdblclick";
        /// <summary>
        /// Fires when you move the mouse out of the container. ...
        /// </summary>
        public static JsString containermouseout="containermouseout";
        /// <summary>
        /// Fires when you move the mouse over the container. ...
        /// </summary>
        public static JsString containermouseover="containermouseover";
        /// <summary>
        /// Fires when there is a mouse up on the container ...
        /// </summary>
        public static JsString containermouseup="containermouseup";
        /// <summary>
        /// Fires when an item is clicked. ...
        /// </summary>
        public static JsString itemclick="itemclick";
        /// <summary>
        /// Fires when an item is right clicked. ...
        /// </summary>
        public static JsString itemcontextmenu="itemcontextmenu";
        /// <summary>
        /// Fires when an item is double clicked. ...
        /// </summary>
        public static JsString itemdblclick="itemdblclick";
        /// <summary>
        /// Fires when there is a mouse down on an item ...
        /// </summary>
        public static JsString itemmousedown="itemmousedown";
        /// <summary>
        /// Fires when the mouse enters an item. ...
        /// </summary>
        public static JsString itemmouseenter="itemmouseenter";
        /// <summary>
        /// Fires when the mouse leaves an item. ...
        /// </summary>
        public static JsString itemmouseleave="itemmouseleave";
        /// <summary>
        /// Fires when there is a mouse up on an item ...
        /// </summary>
        public static JsString itemmouseup="itemmouseup";
        /// <summary>
        /// Fires after a reconfigure ...
        /// </summary>
        public static JsString reconfigure="reconfigure";
        /// <summary>
        /// Fires when a scroller is hidden ...
        /// </summary>
        public static JsString scrollerhide="scrollerhide";
        /// <summary>
        /// Fires when a scroller is shown ...
        /// </summary>
        public static JsString scrollershow="scrollershow";
        /// <summary>
        /// Fires when the selected nodes change. ...
        /// </summary>
        public static JsString selectionchange="selectionchange";
    }
    #endregion
}
#endregion
