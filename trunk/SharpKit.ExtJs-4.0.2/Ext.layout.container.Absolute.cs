//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region Absolute
    /// <summary>
    /// This is a layout that inherits the anchoring of Ext.layout.container.Anchor and adds the
    /// ability for x/y positioning using the standard x and y component config options. This class is intended to be extended or created via the layout
    /// configuration property.  See Ext.container.Container.layout for additional details.  Example usage: Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;Absolute Layout&#39;,
    /// width: 300,
    /// height: 275,
    /// layout:&#39;absolute&#39;,
    /// layoutConfig: {
    /// // layout-specific configs go here
    /// //itemCls: &#39;x-abs-layout-item&#39;,
    /// },
    /// url:&#39;save-form.php&#39;,
    /// defaultType: &#39;textfield&#39;,
    /// items: [{
    /// x: 10,
    /// y: 10,
    /// xtype:&#39;label&#39;,
    /// text: &#39;Send To:&#39;
    /// },{
    /// x: 80,
    /// y: 10,
    /// name: &#39;to&#39;,
    /// anchor:&#39;90%&#39;  // anchor width by percentage
    /// },{
    /// x: 10,
    /// y: 40,
    /// xtype:&#39;label&#39;,
    /// text: &#39;Subject:&#39;
    /// },{
    /// x: 80,
    /// y: 40,
    /// name: &#39;subject&#39;,
    /// anchor: &#39;90%&#39;  // anchor width by percentage
    /// },{
    /// x:0,
    /// y: 80,
    /// xtype: &#39;textareafield&#39;,
    /// name: &#39;msg&#39;,
    /// anchor: &#39;100% 100%&#39;  // anchor width and height
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Absolute : Anchor
    {
    }
    #endregion
    #region AbsoluteConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AbsoluteConfig
    {
    }
    #endregion
    #region AbsoluteEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AbsoluteEvents
    {
    }
    #endregion
}
#endregion
