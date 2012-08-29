//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.view
namespace Ext.view
{
    #region Table
    /// <summary>
    /// This class encapsulates the user interface for a tabular data set.
    /// It acts as a centralized manager for controlling the various interface
    /// elements of the view. This includes handling events, such as row and cell
    /// level based DOM events. It also reacts to events from the underlying Ext.selection.Model
    /// to provide visual feedback to the user. This class does not provide ways to manipulate the underlying data of the configured
    /// Ext.data.Store. This is the base class for both Ext.grid.View and Ext.tree.View and is not
    /// to be used directly.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Table : Ext.view.View, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Add a CSS Class to a specific row. ...
        /// </summary>
        public object addRowCls(object rowInfo, JsString cls){return null;}
        /// <summary>
        /// Focus a particular row and bring it into view. ...
        /// </summary>
        public object focusRow(object rowIdx){return null;}
        /// <summary>
        /// Get a reference to a feature ...
        /// </summary>
        public Ext.grid.feature.Feature getFeature(JsString id){return null;}
        /// <summary>
        /// Override this function to apply custom CSS classes to rows during rendering. ...
        /// </summary>
        public JsString getRowClass(Ext.data.Model model, JsNumber index, object rowParams, Ext.data.Store store){return null;}
        /// <summary>
        /// Get the configured chunker or default of Ext.view.TableChunker ...
        /// </summary>
        public object getTableChunker(){return null;}
        /// <summary>
        /// Refresh the grid view. ...
        /// </summary>
        public new object refresh(){return null;}
        /// <summary>
        /// Remove a CSS Class from a specific row. ...
        /// </summary>
        public object removeRowCls(object rowInfo, JsString cls){return null;}
        /// <summary>
        /// Save the scrollState in a private variable. ...
        /// </summary>
        public object saveScrollState(){return null;}
        public Table(Ext.view.TableConfig config){}
        public Table(){}
    }
    #endregion
    #region TableConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TableConfig : Ext.view.ViewConfig
    {
    }
    #endregion
    #region TableEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TableEvents : Ext.view.ViewEvents
    {
    }
    #endregion
}
#endregion
