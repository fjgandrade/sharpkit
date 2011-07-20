//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.toolbar
namespace Ext.toolbar
{
    #region Separator
    /// <summary>
    /// A simple class that adds a vertical separator bar between toolbar items
    /// (css class:&#39;x-toolbar-separator&#39;).  Example Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// title: &#39;Toolbar Seperator Example&#39;,
    /// width: 300,
    /// height: 200,
    /// tbar : [
    /// &#39;Item 1&#39;,
    /// {xtype: &#39;tbseparator&#39;}, // or &#39;-&#39;
    /// &#39;Item 2&#39;
    /// ],
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Separator : Ext.toolbar.Item, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
    }
    #endregion
    #region SeparatorConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class SeparatorConfig
    {
    }
    #endregion
    #region SeparatorEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class SeparatorEvents
    {
    }
    #endregion
}
#endregion
