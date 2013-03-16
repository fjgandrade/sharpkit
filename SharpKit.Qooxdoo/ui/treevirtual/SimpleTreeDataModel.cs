// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.treevirtual
{
    /// <summary>
	/// <para>A simple tree data model used as the table model</para>
	/// <para>The object structure of a single node of the tree is:</para>
	/// <code>
	/// {
	/// // USER-PROVIDED ATTRIBUTES
	/// // ------------------------
	/// type           : qx.ui.treevirtual.MTreePrimitive.Type.LEAF,
	/// parentNodeId   : 23,    // index of the parent node in _nodeArr
	/// label          : "My Documents",
	/// bSelected      : true,  // true if node is selected; false otherwise.
	/// bOpened        : true,  // true (-), false (+)
	/// bHideOpenClose : false, // whether to hide the open/close button
	/// icon           : "images/folder.gif",
	/// iconSelected   : "images/folder_selected.gif",
	/// cellStyle      : "background-color:cyan"
	/// labelStyle     : "background-color:red;color:white"
	/// // USER-PROVIDED COLUMN DATA
	/// columnData     : [
	/// null, // null at index of tree column (typically 0)
	/// "text of column 1",
	/// "text of column 2"
	/// ],
	/// // APPLICATION-, MIXIN-, and SUBCLASS-PROVIDED CUSTOM DATA
	/// data           : {
	/// application :
	/// {
	/// // application-specific user data goes in here
	/// foo: "bar",
	/// ...
	/// },
	/// MDragAndDropSupport :
	/// {
	/// // Data required for the Drag & Drop mixin.
	/// // When a mixin is included, its constructor
	/// // should create this object, named according
	/// // to the mixin or subclass name (empty or
	/// // otherwise)
	/// },
	/// ... // Additional mixins or subclasses.
	/// },
	/// // INTERNALLY-CALCULATED ATTRIBUTES
	/// // --------------------------------
	/// // The following properties need not (and should not) be set by the
	/// // caller, but are automatically calculated.  Some are used internally,
	/// // while others may be of use to event listeners.
	/// nodeId         : 42,   // The index in _nodeArr, useful to event listeners.
	/// children       : [ ],  // each value is an index into _nodeArr
	/// level          : 2,    // The indentation level of this tree node
	/// bFirstChild    : true,
	/// lastChild      : [ false ],  // Array where the index is the column of
	/// // indentation, and the value is a boolean.
	/// // These are used to locate the
	/// // appropriate "tree line" icon.
	/// }
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.treevirtual.SimpleTreeDataModel", OmitOptionalParameters = true, Export = false)]
    public partial class SimpleTreeDataModel : qx.ui.table.model.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>Gives the user the opportunity to filter the model. The filter
		/// function is called for every node in the model. It gets as an argument the
		/// node object and has to return
		/// true if the given data should be shown and
		/// false if the given data should be ignored.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "filter", NativeField = true)]
		public Action<object> Filter { get; set; }

		#endregion Properties

		#region Methods

		public SimpleTreeDataModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a branch to the tree.</para>
		/// </summary>
		/// <param name="parentNodeId">The node id of the parent of the node being added</param>
		/// <param name="label">The string to display as the label for this node</param>
		/// <param name="bOpened">True if the branch should be rendered in its opened state; false otherwise.</param>
		/// <param name="bHideOpenCloseButton">True if the open/close button should not be displayed; false if the open/close button should be displayed</param>
		/// <param name="icon">The relative (subject to alias expansion) or full path of the icon to display for this node when it is not a selected node.</param>
		/// <param name="iconSelected">The relative (subject to alias expansion) or full path of the icon to display for this node when it is a selected node.</param>
		/// <returns>The node id of the newly-added branch.</returns>
		[JsMethod(Name = "addBranch")]
		public double AddBranch(double parentNodeId, string label, bool bOpened, bool bHideOpenCloseButton, string icon, string iconSelected) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a leaf to the tree.</para>
		/// </summary>
		/// <param name="parentNodeId">The node id of the parent of the node being added</param>
		/// <param name="label">The string to display as the label for this node</param>
		/// <param name="icon">The relative (subject to alias expansion) or full path of the icon to display for this node when it is not a selected node.</param>
		/// <param name="iconSelected">The relative (subject to alias expansion) or full path of the icon to display for this node when it is a selected node.</param>
		/// <returns>The node id of the newly-added leaf.</returns>
		[JsMethod(Name = "addLeaf")]
		public double AddLeaf(double parentNodeId, string label, string icon, string iconSelected) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the tree of all nodes</para>
		/// </summary>
		[JsMethod(Name = "clearData")]
		public void ClearData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Retrieve the data from an additional column (a column other than the
		/// tree column) of the tree.</para>
		/// </summary>
		/// <param name="nodeId">A node identifier, as previously returned by #addBranch or #addLeaf.</param>
		/// <param name="columnIndex">The column number to which the provided data applies</param>
		/// <returns>The cell data for the specified column</returns>
		[JsMethod(Name = "getColumnData")]
		public object GetColumnData(double nodeId, double columnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the array of node data.</para>
		/// </summary>
		/// <returns>Array of node objects. See qx.ui.treevirtual.SimpleTreeDataModel for a description nodes in this array.</returns>
		[JsMethod(Name = "getData")]
		public JsArray GetData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property filter.</para>
		/// </summary>
		[JsMethod(Name = "getFilter")]
		public Action<object> GetFilter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the node object specific to a currently visible row. In this
		/// simple tree data model, that&#8217;s the same as retrieving the value of the
		/// tree column of the specified row.</para>
		/// </summary>
		/// <param name="rowIndex">The index of the row.</param>
		/// <returns>The node object associated with the specified row.</returns>
		[JsMethod(Name = "getNode")]
		public object GetNode(double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This operation maps rowIndexes to nodes.  It does the opposite job to <see cref="GetRowFromNodeId"/>.
		/// This function is useful to map selection (row based) to nodes.</para>
		/// </summary>
		/// <param name="rowIndex">zero-based row index.</param>
		/// <returns>node associated to rowIndex.</returns>
		[JsMethod(Name = "getNodeFromRow")]
		public object GetNodeFromRow(double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the mapping of nodes to rendered rows.  This function is intended
		/// for use by the cell renderer, not by users of this class.
		/// It is also useful to select a node.</para>
		/// </summary>
		/// <returns>The array containing mappings of nodes to rendered rows.</returns>
		[JsMethod(Name = "getNodeRowMap")]
		public JsArray GetNodeRowMap() { throw new NotImplementedException(); }

		[JsMethod(Name = "getRowCount")]
		public void GetRowCount() { throw new NotImplementedException(); }

		[JsMethod(Name = "getRowData")]
		public void GetRowData(object rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This operation maps nodes to rowIndexes.  It does the opposite job to <see cref="GetNodeFromRow"/>.</para>
		/// </summary>
		/// <param name="nodeId">The id of the node (as would have been returned by addBranch(), addLeaf(), etc.) to get the row index for.</param>
		/// <returns>row index for the given node ID</returns>
		[JsMethod(Name = "getRowFromNodeId")]
		public double GetRowFromNodeId(double nodeId) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the nodes that are currently selected.</para>
		/// </summary>
		/// <returns>An array containing the nodes that are currently selected.</returns>
		[JsMethod(Name = "getSelectedNodes")]
		public JsArray GetSelectedNodes() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the column index the model is sorted by. This model is never
		/// sorted, so -1 is returned.</para>
		/// </summary>
		/// <returns>-1, to indicate that the model is not sorted.</returns>
		[JsMethod(Name = "getSortColumnIndex")]
		public double GetSortColumnIndex() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the tree object for which this data model is used.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getTree")]
		public qx.ui.treevirtual.TreeVirtual GetTree() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the column in which the tree is to be displayed.</para>
		/// </summary>
		/// <returns>The column in which the tree is to be displayed</returns>
		[JsMethod(Name = "getTreeColumn")]
		public double GetTreeColumn() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a cell value by column index.</para>
		/// </summary>
		/// <param name="columnIndex">the index of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <returns>The value of the cell.</returns>
		[JsMethod(Name = "getValue")]
		public object GetValue(double columnIndex, double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property filter
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property filter.</param>
		[JsMethod(Name = "initFilter")]
		public void InitFilter(object value) { throw new NotImplementedException(); }

		[JsMethod(Name = "isColumnEditable")]
		public void IsColumnEditable(object columnIndex) { throw new NotImplementedException(); }

		[JsMethod(Name = "isColumnSortable")]
		public void IsColumnSortable(object columnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Move a node in the tree.</para>
		/// </summary>
		/// <param name="moveNodeReference">The node to be moved.  The node can be represented either by the node object, or the node id (as would have been returned by addBranch(), addLeaf(), etc.)</param>
		/// <param name="parentNodeReference">The new parent node, which must not be a LEAF.  The node can be represented either by the node object, or the node id (as would have been returned by addBranch(), addLeaf(), etc.)</param>
		[JsMethod(Name = "move")]
		public void Move(object moveNodeReference, object parentNodeReference) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prune the tree by removing, recursively, all of a node&#8217;s children.  If
		/// requested, also remove the node itself.</para>
		/// </summary>
		/// <param name="nodeReference">The node to be pruned from the tree.  The node can be represented either by the node object, or the node id (as would have been returned by addBranch(), addLeaf(), etc.)</param>
		/// <param name="bSelfAlso">If true then remove the node identified by nodeId as well as all of the children.</param>
		[JsMethod(Name = "prune")]
		public void Prune(object nodeReference, bool bSelfAlso) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property filter.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFilter")]
		public void ResetFilter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add data to an additional column (a column other than the tree column)
		/// of the tree.</para>
		/// </summary>
		/// <param name="nodeId">A node identifier, as previously returned by #addBranch or #addLeaf.</param>
		/// <param name="columnIndex">The column number to which the provided data applies</param>
		/// <param name="data">The cell data for the specified column</param>
		[JsMethod(Name = "setColumnData")]
		public void SetColumnData(double nodeId, double columnIndex, object data) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets whether a column is editable.</para>
		/// </summary>
		/// <param name="columnIndex">The column of which to set the editable state.</param>
		/// <param name="editable">Whether the column should be editable.</param>
		[JsMethod(Name = "setColumnEditable")]
		public void SetColumnEditable(double columnIndex, bool editable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the whole data en bulk, or notifies the data model that node
		/// modifications are complete.</para>
		/// </summary>
		/// <param name="nodeArr">Pass either an Array of node objects, or null.  If non-null, nodeArr is an array of node objects containing the entire tree to be displayed.  If loading the whole data en bulk in this way, it is assumed that the data is correct!  No error checking or validation is done.  You&#8217;d better know what you&#8217;re doing!  Caveat emptor.   If nodeArr is null, then this call is a notification that the user has completed building or modifying a tree by issuing a series of calls to #addBranch and/or #addLeaf.</param>
		[JsMethod(Name = "setData")]
		public void SetData(JsArray nodeArr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets all columns editable or not editable.</para>
		/// </summary>
		/// <param name="editable">Whether all columns are editable.</param>
		[JsMethod(Name = "setEditable")]
		public void SetEditable(bool editable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property filter.</para>
		/// </summary>
		/// <param name="value">New value for property filter.</param>
		[JsMethod(Name = "setFilter")]
		public void SetFilter(Action<object> value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set state attributes of a node.</para>
		/// </summary>
		/// <param name="nodeReference">The node to have its attributes set.  The node can be represented either by the node object, or the node id (as would have been returned by addBranch(), addLeaf(), etc.)</param>
		/// <param name="attributes">Each property name in the map may correspond to the property names of a node which are specified as USER-PROVIDED ATTRIBUTES in SimpleTreeDataModel.  Each property value will be assigned to the corresponding property of the node specified by nodeId.</param>
		[JsMethod(Name = "setState")]
		public void SetState(object nodeReference, object attributes) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the tree object for which this data model is used.</para>
		/// </summary>
		/// <param name="tree">The tree used to render the data in this model.</param>
		[JsMethod(Name = "setTree")]
		public void SetTree(qx.ui.treevirtual.TreeVirtual tree) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Specifies which column the tree is to be displayed in.  The tree is
		/// displayed using the SimpleTreeDataCellRenderer.  Other columns may be
		/// provided which use different cell renderers.</para>
		/// <para>Setting the tree column involves more than simply setting this column
		/// index; it also requires setting an appropriate cell renderer for this
		/// column, that knows how to render a tree. The expected and typical
		/// method of setting the tree column is to provide it in the &#8216;custom&#8217;
		/// parameter to the TreeVirtual constructor, which also initializes the
		/// proper cell renderers. This method does not set any cell renderers. If
		/// you wish to call this method on your own, you should also manually set
		/// the cell renderer for the specified column, and likely also set the
		/// cell renderer for column 0 (the former tree column) to something
		/// appropriate to your data.</para>
		/// </summary>
		/// <param name="columnIndex">The index of the column in which the tree should be displayed.</param>
		[JsMethod(Name = "setTreeColumn")]
		public void SetTreeColumn(double columnIndex) { throw new NotImplementedException(); }

		[JsMethod(Name = "setValue")]
		public void SetValue(object columnIndex, object rowIndex, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sorts the model by a column.</para>
		/// </summary>
		/// <param name="columnIndex">the column to sort by.</param>
		/// <param name="ascending">whether to sort ascending.</param>
		[JsMethod(Name = "sortByColumn")]
		public void SortByColumn(double columnIndex, bool ascending) { throw new NotImplementedException(); }

		#endregion Methods
    }
}