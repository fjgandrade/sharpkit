//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.menu
namespace Ext.menu
{
    #region CheckItem
    /// <summary>
    /// A menu item that contains a togglable checkbox by default, but that can also be a part of a radio group.  Example Usage Ext.create(&#39;Ext.menu.Menu&#39;, {
    /// width: 100,
    /// height: 110,
    /// floating: false,  // usually you want this set to True (default)
    /// renderTo: Ext.getBody(),  // usually rendered by it&#39;s containing component
    /// items: [{
    /// xtype: &#39;menucheckitem&#39;,
    /// text: &#39;select all&#39;
    /// },{
    /// xtype: &#39;menucheckitem&#39;,
    /// text: &#39;select specific&#39;,
    /// },{
    /// iconCls: &#39;add16&#39;,
    /// text: &#39;icon item&#39;
    /// },{
    /// text: &#39;regular item&#39;
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class CheckItem : Ext.menu.Item, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Disables just the checkbox functionality of this menu Item. ...
        /// </summary>
        public object disableCheckChange(){return null;}
        /// <summary>
        /// Reenables the checkbox functionality of this menu item after having been disabled by disableCheckChange ...
        /// </summary>
        public object enableCheckChange(){return null;}
        /// <summary>
        /// Sets the checked state of the item ...
        /// </summary>
        public object setChecked(bool @checked, bool suppressEvents=false){return null;}
    }
    #endregion
    #region CheckItemConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckItemConfig
    {
        /// <summary>
        /// The CSS class used by cls to show the checked state. ...
        /// </summary>
        public JsString checkedCls{get;set;}
        /// <summary>
        /// The CSS class applied to this item's icon image to denote being a part of a radio group. ...
        /// </summary>
        public JsString groupCls{get;set;}
        /// <summary>
        /// Whether to not to hide the owning menu when this item is clicked. ...
        /// </summary>
        public bool hideOnClick{get;set;}
        /// <summary>
        /// The CSS class used by cls to show the unchecked state. ...
        /// </summary>
        public JsString uncheckedCls{get;set;}
    }
    #endregion
    #region CheckItemEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckItemEvents
    {
        /// <summary>
        /// Fires before a change event. ...
        /// </summary>
        public static JsString beforecheckchange="beforecheckchange";
        /// <summary>
        /// Fires after a change event. ...
        /// </summary>
        public static JsString checkchange="checkchange";
    }
    #endregion
}
#endregion
