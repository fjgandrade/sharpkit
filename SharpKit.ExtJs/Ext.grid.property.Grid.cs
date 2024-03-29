//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.property
{
    #region Grid
    /// <inheritdocs />
    /// <summary>
    /// <p>A specialized grid implementation intended to mimic the traditional property grid as typically seen in
    /// development IDEs.  Each row in the grid represents a property of some object, and the data is stored
    /// as a set of name/value pairs in <see cref="Ext.grid.property.Property">Properties</see>.  Example usage:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.property.Grid">Ext.grid.property.Grid</see>', {
    /// title: 'Properties Grid',
    /// width: 300,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// source: {
    /// "(name)": "My Object",
    /// "Created": <see cref="Ext.Date.parse">Ext.Date.parse</see>('10/15/2006', 'm/d/Y'),
    /// "Available": false,
    /// "Version": 0.01,
    /// "Description": "A test object"
    /// }
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Grid : Ext.grid.Panel
    {
        /// <summary>
        /// An object containing name/value pairs of custom editor type definitions that allow
        /// the grid to support additional types of editable fields.  By default, the grid supports strongly-typed editing
        /// of strings, dates, numbers and booleans using built-in form editors, but any custom type can be supported and
        /// associated with a custom input control by specifying a custom editor.  The name of the editor
        /// type should correspond with the name of the property that will use the editor.  Example usage:
        /// <code>var grid = new <see cref="Ext.grid.property.Grid">Ext.grid.property.Grid</see>({
        /// // Custom editors for certain property names
        /// customEditors: {
        /// evtStart: <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.field.Time">Ext.form.TimeField</see>', {selectOnFocus: true})
        /// },
        /// // Displayed name for property names in the source
        /// propertyNames: {
        /// evtStart: 'Start Time'
        /// },
        /// // Data object containing properties to edit
        /// source: {
        /// evtStart: '10:00 AM'
        /// }
        /// });
        /// </code>
        /// </summary>
        public JsObject customEditors;
        /// <summary>
        /// An object containing name/value pairs of custom renderer type definitions that allow
        /// the grid to support custom rendering of fields.  By default, the grid supports strongly-typed rendering
        /// of strings, dates, numbers and booleans using built-in form editors, but any custom type can be supported and
        /// associated with the type of the value.  The name of the renderer type should correspond with the name of the property
        /// that it will render.  Example usage:
        /// <code>var grid = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.property.Grid">Ext.grid.property.Grid</see>', {
        /// customRenderers: {
        /// Available: function(v){
        /// if (v) {
        /// return '&lt;span style="color: green;"&gt;Yes&lt;/span&gt;';
        /// } else {
        /// return '&lt;span style="color: red;"&gt;No&lt;/span&gt;';
        /// }
        /// }
        /// },
        /// source: {
        /// Available: true
        /// }
        /// });
        /// </code>
        /// </summary>
        public JsObject customRenderers;
        /// <summary>
        /// Specify the width for the name column. The value column will take any remaining space.
        /// Defaults to: <c>115</c>
        /// </summary>
        public JsNumber nameColumnWidth;
        /// <summary>
        /// The name of the field from the property store to use as the property field name.
        /// This may be useful if you do not configure the property Grid from an object, but use your own store configuration.
        /// Defaults to: <c>&quot;name&quot;</c>
        /// </summary>
        public JsString nameField;
        /// <summary>
        /// An object containing custom property name/display name pairs.
        /// If specified, the display name will be shown in the name column instead of the property name.
        /// </summary>
        public JsObject propertyNames;
        /// <summary>
        /// A data object to use as the data source of the grid (see setSource for details).
        /// </summary>
        public JsObject source;
        /// <summary>
        /// The name of the field from the property store to use as the value field name.
        /// This may be useful if you do not configure the property Grid from an object, but use your own store configuration.
        /// Defaults to: <c>&quot;value&quot;</c>
        /// </summary>
        public JsString valueField;
        /// <summary>
        /// Gets the source data object containing the property data.  See setSource for details regarding the
        /// format of the data object.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The data object</p>
        /// </div>
        /// </returns>
        public object getSource(){return null;}
        /// <summary>
        /// Removes a property from the grid.
        /// </summary>
        /// <param name="prop"><p>The name of the property to remove</p>
        /// </param>
        public void removeProperty(JsString prop){}
        /// <summary>
        /// Sets the value of a property.
        /// </summary>
        /// <param name="prop"><p>The name of the property to set</p>
        /// </param>
        /// <param name="value"><p>The value to test</p>
        /// </param>
        /// <param name="create"><p>True to create the property if it doesn't already exist.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        public void setProperty(JsString prop, object value, object create=null){}
        /// <summary>
        /// Sets the source data object containing the property data.  The data object can contain one or more name/value
        /// pairs representing all of the properties of an object to display in the grid, and this data will automatically
        /// be loaded into the grid's store.  The values should be supplied in the proper data type if needed,
        /// otherwise string type will be assumed.  If the grid already contains data, this method will replace any
        /// existing data.  See also the source config value.  Example usage:
        /// <code>grid.setSource({
        /// "(name)": "My Object",
        /// "Created": <see cref="Ext.Date.parse">Ext.Date.parse</see>('10/15/2006', 'm/d/Y'),  // date type
        /// "Available": false,  // boolean type
        /// "Version": .01,      // decimal type
        /// "Description": "A test object"
        /// });
        /// </code>
        /// </summary>
        /// <param name="source"><p>The data object</p>
        /// </param>
        public void setSource(object source){}
        public Grid(GridConfig config){}
        public Grid(){}
        public Grid(params object[] args){}
    }
    #endregion
    #region GridConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class GridConfig : Ext.grid.PanelConfig
    {
        /// <summary>
        /// An object containing name/value pairs of custom editor type definitions that allow
        /// the grid to support additional types of editable fields.  By default, the grid supports strongly-typed editing
        /// of strings, dates, numbers and booleans using built-in form editors, but any custom type can be supported and
        /// associated with a custom input control by specifying a custom editor.  The name of the editor
        /// type should correspond with the name of the property that will use the editor.  Example usage:
        /// <code>var grid = new <see cref="Ext.grid.property.Grid">Ext.grid.property.Grid</see>({
        /// // Custom editors for certain property names
        /// customEditors: {
        /// evtStart: <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.field.Time">Ext.form.TimeField</see>', {selectOnFocus: true})
        /// },
        /// // Displayed name for property names in the source
        /// propertyNames: {
        /// evtStart: 'Start Time'
        /// },
        /// // Data object containing properties to edit
        /// source: {
        /// evtStart: '10:00 AM'
        /// }
        /// });
        /// </code>
        /// </summary>
        public JsObject customEditors;
        /// <summary>
        /// An object containing name/value pairs of custom renderer type definitions that allow
        /// the grid to support custom rendering of fields.  By default, the grid supports strongly-typed rendering
        /// of strings, dates, numbers and booleans using built-in form editors, but any custom type can be supported and
        /// associated with the type of the value.  The name of the renderer type should correspond with the name of the property
        /// that it will render.  Example usage:
        /// <code>var grid = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.property.Grid">Ext.grid.property.Grid</see>', {
        /// customRenderers: {
        /// Available: function(v){
        /// if (v) {
        /// return '&lt;span style="color: green;"&gt;Yes&lt;/span&gt;';
        /// } else {
        /// return '&lt;span style="color: red;"&gt;No&lt;/span&gt;';
        /// }
        /// }
        /// },
        /// source: {
        /// Available: true
        /// }
        /// });
        /// </code>
        /// </summary>
        public JsObject customRenderers;
        /// <summary>
        /// Specify the width for the name column. The value column will take any remaining space.
        /// Defaults to: <c>115</c>
        /// </summary>
        public JsNumber nameColumnWidth;
        /// <summary>
        /// The name of the field from the property store to use as the property field name.
        /// This may be useful if you do not configure the property Grid from an object, but use your own store configuration.
        /// Defaults to: <c>&quot;name&quot;</c>
        /// </summary>
        public JsString nameField;
        /// <summary>
        /// An object containing custom property name/display name pairs.
        /// If specified, the display name will be shown in the name column instead of the property name.
        /// </summary>
        public JsObject propertyNames;
        /// <summary>
        /// A data object to use as the data source of the grid (see setSource for details).
        /// </summary>
        public JsObject source;
        /// <summary>
        /// The name of the field from the property store to use as the value field name.
        /// This may be useful if you do not configure the property Grid from an object, but use your own store configuration.
        /// Defaults to: <c>&quot;value&quot;</c>
        /// </summary>
        public JsString valueField;
        public GridConfig(params object[] args){}
    }
    #endregion
    #region GridEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class GridEvents : Ext.grid.PanelEvents
    {
        /// <summary>
        /// Fires before a property value changes.  Handlers can return false to cancel the property change
        /// (this will internally call Ext.data.Model.reject on the property's record).
        /// </summary>
        /// <param name="source"><p>The source data object for the grid (corresponds to the same object passed in
        /// as the <see cref="Ext.grid.GridConfig.source">source</see> config property).</p>
        /// </param>
        /// <param name="recordId"><p>The record's id in the data store</p>
        /// </param>
        /// <param name="value"><p>The current edited property value</p>
        /// </param>
        /// <param name="oldValue"><p>The original property value prior to editing</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforepropertychange(object source, JsString recordId, object value, object oldValue, object eOpts){}
        /// <summary>
        /// Fires after a property value has changed.
        /// </summary>
        /// <param name="source"><p>The source data object for the grid (corresponds to the same object passed in
        /// as the <see cref="Ext.grid.GridConfig.source">source</see> config property).</p>
        /// </param>
        /// <param name="recordId"><p>The record's id in the data store</p>
        /// </param>
        /// <param name="value"><p>The current edited property value</p>
        /// </param>
        /// <param name="oldValue"><p>The original property value prior to editing</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void propertychange(object source, JsString recordId, object value, object oldValue, object eOpts){}
        public GridEvents(params object[] args){}
    }
    #endregion
}
