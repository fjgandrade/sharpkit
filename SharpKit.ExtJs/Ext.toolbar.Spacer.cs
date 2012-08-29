//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.toolbar
{
    #region Spacer
    /// <inheritdocs />
    /// <summary>
    /// <p>A simple element that adds extra horizontal space between items in a toolbar.
    /// By default a 2px wide space is added via CSS specification:</p>
    /// <pre><code>.x-toolbar .x-toolbar-spacer {
    /// width: 2px;
    /// }
    /// </code></pre>
    /// <p>Example:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.panel.Panel">Ext.panel.Panel</see>', {
    /// title: 'Toolbar Spacer Example',
    /// width: 300,
    /// height: 200,
    /// tbar : [
    /// 'Item 1',
    /// { xtype: 'tbspacer' }, // or ' '
    /// 'Item 2',
    /// // space width is also configurable via javascript
    /// { xtype: 'tbspacer', width: 50 }, // add a 50px space
    /// 'Item 3'
    /// ],
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Spacer : Ext.Component
    {
        public Spacer(SpacerConfig config){}
        public Spacer(){}
        public Spacer(params object[] args){}
    }
    #endregion
    #region SpacerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SpacerConfig : Ext.ComponentConfig
    {
        public SpacerConfig(params object[] args){}
    }
    #endregion
    #region SpacerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SpacerEvents : Ext.ComponentEvents
    {
        public SpacerEvents(params object[] args){}
    }
    #endregion
}
