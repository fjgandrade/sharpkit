//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.menu
{
    #region Separator
    /// <inheritdocs />
    /// <summary>
    /// <p>Adds a separator bar to a menu, used to divide logical groups of menu items. Generally you will
    /// add one of these by using "-" in your call to add() or in your items config rather than creating one directly.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.menu.Menu">Ext.menu.Menu</see>', {
    /// width: 100,
    /// height: 100,
    /// floating: false,  // usually you want this set to True (default)
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),  // usually rendered by it's containing component
    /// items: [{
    /// text: 'icon item',
    /// iconCls: 'add16'
    /// },{
    /// xtype: 'menuseparator'
    /// },{
    /// text: 'separator above'
    /// },{
    /// text: 'regular item'
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Separator : Ext.menu.Item
    {
        /// <summary>
        /// The CSS class used by the separator item to show the incised line.
        /// Defaults to: <c>&quot;x-menu-item-separator&quot;</c>
        /// </summary>
        public JsString separatorCls;
        public Separator(Ext.menu.SeparatorConfig config){}
        public Separator(){}
        public Separator(params object[] args){}
    }
    #endregion
    #region SeparatorConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SeparatorConfig : Ext.menu.ItemConfig
    {
        /// <summary>
        /// The CSS class used by the separator item to show the incised line.
        /// Defaults to: <c>&quot;x-menu-item-separator&quot;</c>
        /// </summary>
        public JsString separatorCls;
        public SeparatorConfig(params object[] args){}
    }
    #endregion
    #region SeparatorEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SeparatorEvents : Ext.menu.ItemEvents
    {
        public SeparatorEvents(params object[] args){}
    }
    #endregion
}
