//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux
{
    #region TreePicker
    /// <inheritdocs />
    /// <summary>
    /// <p>A Picker field that contains a tree panel on its popup, enabling selection of tree nodes.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class TreePicker : Ext.form.field.Picker
    {
        /// <summary>
        /// An optional array of columns for multi-column trees
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsArray columns;
        /// <summary>
        /// The field inside the model that will be used as the node's text.
        /// Defaults to the default value of Ext.tree.Panel's displayField configuration.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString displayField;
        /// <summary>
        /// The maximum height of the tree dropdown. Defaults to 300.
        /// Defaults to: <c>300</c>
        /// </summary>
        public JsNumber maxPickerHeight;
        /// <summary>
        /// The minimum height of the tree dropdown. Defaults to 100.
        /// Defaults to: <c>100</c>
        /// </summary>
        public JsNumber minPickerHeight;
        /// <summary>
        /// Whether the Tab key should select the currently highlighted item. Defaults to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool selectOnTab;
        /// <summary>
        /// A tree store that the tree picker will be bound to
        /// Defaults to: <c>null</c>
        /// </summary>
        public Ext.data.TreeStore store;
        /// <summary>
        /// Runs when the picker is expanded.  Selects the appropriate tree node based on the value of the input element,
        /// and focuses the picker so that keyboard navigation will work.
        /// </summary>
        private void onExpand(){}
        /// <summary>
        /// Handles a click even on a tree node
        /// </summary>
        /// <param name="view">
        /// </param>
        /// <param name="record">
        /// </param>
        /// <param name="node">
        /// </param>
        /// <param name="rowIndex">
        /// </param>
        /// <param name="e">
        /// </param>
        private void onItemClick(Ext.tree.View view, Ext.data.Model record, object node, JsNumber rowIndex, EventObject e){}
        /// <summary>
        /// Handles the store's load event.
        /// </summary>
        private void onLoad(){}
        /// <summary>
        /// Handles a keypress event on the picker element
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <param name="el">
        /// </param>
        private void onPickerKeypress(EventObject e, object el){}
        /// <summary>
        /// repaints the tree view
        /// </summary>
        public void repaintPickerView(){}
        /// <summary>
        /// Changes the selection to a given record and closes the picker
        /// </summary>
        /// <param name="record">
        /// </param>
        private void selectItem(Ext.data.Model record){}
        /// <summary>
        /// Sets min/max height styles on the tree picker's view element after it is rendered.
        /// </summary>
        /// <param name="view">
        /// </param>
        private void setPickerViewStyles(Ext.tree.View view){}
        public TreePicker(TreePickerConfig config){}
        public TreePicker(){}
        public TreePicker(params object[] args){}
    }
    #endregion
    #region TreePickerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TreePickerConfig : Ext.form.field.PickerConfig
    {
        /// <summary>
        /// An optional array of columns for multi-column trees
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsArray columns;
        /// <summary>
        /// The field inside the model that will be used as the node's text.
        /// Defaults to the default value of Ext.tree.Panel's displayField configuration.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString displayField;
        /// <summary>
        /// The maximum height of the tree dropdown. Defaults to 300.
        /// Defaults to: <c>300</c>
        /// </summary>
        public JsNumber maxPickerHeight;
        /// <summary>
        /// The minimum height of the tree dropdown. Defaults to 100.
        /// Defaults to: <c>100</c>
        /// </summary>
        public JsNumber minPickerHeight;
        /// <summary>
        /// Whether the Tab key should select the currently highlighted item. Defaults to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool selectOnTab;
        /// <summary>
        /// A tree store that the tree picker will be bound to
        /// Defaults to: <c>null</c>
        /// </summary>
        public Ext.data.TreeStore store;
        public TreePickerConfig(params object[] args){}
    }
    #endregion
    #region TreePickerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TreePickerEvents : Ext.form.field.PickerEvents
    {
        public TreePickerEvents(params object[] args){}
    }
    #endregion
}
