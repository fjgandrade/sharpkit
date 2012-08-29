//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.column
namespace Ext.grid.column
{
    #region Boolean
    /// <inheritdocs />
    /// <summary>
    /// <p>A Column definition class which renders boolean data fields.  See the <see cref="Ext.grid.column.ColumnConfig.xtype">xtype</see>
    /// config option of <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see> for more details.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// storeId:'sampleStore',
    /// fields:[
    /// {name: 'framework', type: 'string'},
    /// {name: 'rocks', type: 'boolean'}
    /// ],
    /// data:{'items':[
    /// { 'framework': "Ext JS 4",     'rocks': true  },
    /// { 'framework': "Sencha Touch", 'rocks': true  },
    /// { 'framework': "Ext GWT",      'rocks': true  },
    /// { 'framework': "Other Guys",   'rocks': false }
    /// ]},
    /// proxy: {
    /// type: 'memory',
    /// reader: {
    /// type: 'json',
    /// root: 'items'
    /// }
    /// }
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// title: 'Boolean Column Demo',
    /// store: <see cref="Ext.data.StoreManager.lookup">Ext.data.StoreManager.lookup</see>('sampleStore'),
    /// columns: [
    /// { text: 'Framework',  dataIndex: 'framework', flex: 1 },
    /// {
    /// xtype: 'booleancolumn',
    /// text: 'Rocks',
    /// trueText: 'Yes',
    /// falseText: 'No',
    /// dataIndex: 'rocks'
    /// }
    /// ],
    /// height: 200,
    /// width: 400,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Boolean : Ext.grid.column.Column
    {
        /// <summary>
        /// The string returned by the renderer when the column value is falsey (but not undefined).
        /// Defaults to: <c>&quot;false&quot;</c>
        /// </summary>
        public JsString falseText;
        /// <summary>
        /// The string returned by the renderer when the column value is not falsey.
        /// Defaults to: <c>&quot;true&quot;</c>
        /// </summary>
        public JsString trueText;
        /// <summary>
        /// The string returned by the renderer when the column value is undefined.
        /// Defaults to: <c>&quot;&amp;#160;&quot;</c>
        /// </summary>
        public JsString undefinedText;
        public Boolean(BooleanConfig config){}
        public Boolean(){}
        public Boolean(params object[] args){}
    }
    #endregion
    #region BooleanConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class BooleanConfig : Ext.grid.column.ColumnConfig
    {
        /// <summary>
        /// The string returned by the renderer when the column value is falsey (but not undefined).
        /// Defaults to: <c>&quot;false&quot;</c>
        /// </summary>
        public JsString falseText;
        /// <summary>
        /// The string returned by the renderer when the column value is not falsey.
        /// Defaults to: <c>&quot;true&quot;</c>
        /// </summary>
        public JsString trueText;
        /// <summary>
        /// The string returned by the renderer when the column value is undefined.
        /// Defaults to: <c>&quot;&amp;#160;&quot;</c>
        /// </summary>
        public JsString undefinedText;
        public BooleanConfig(params object[] args){}
    }
    #endregion
    #region BooleanEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class BooleanEvents : Ext.grid.column.ColumnEvents
    {
        public BooleanEvents(params object[] args){}
    }
    #endregion
}
#endregion
