//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:23
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.column
namespace Ext.grid.column
{
    #region Template
    /// <summary>
    /// A Column definition class which renders a value by processing a Model&#39;s
    /// data using a configured XTemplate.   Code Ext.create(&#39;Ext.data.Store&#39;, {
    /// storeId:&#39;employeeStore&#39;,
    /// fields:[&#39;firstname&#39;, &#39;lastname&#39;, &#39;senority&#39;, &#39;department&#39;],
    /// groupField: &#39;department&#39;,
    /// data:[
    /// {firstname:&quot;Michael&quot;, lastname:&quot;Scott&quot;, senority:7, department:&quot;Manangement&quot;},
    /// {firstname:&quot;Dwight&quot;, lastname:&quot;Schrute&quot;, senority:2, department:&quot;Sales&quot;},
    /// {firstname:&quot;Jim&quot;, lastname:&quot;Halpert&quot;, senority:3, department:&quot;Sales&quot;},
    /// {firstname:&quot;Kevin&quot;, lastname:&quot;Malone&quot;, senority:4, department:&quot;Accounting&quot;},
    /// {firstname:&quot;Angela&quot;, lastname:&quot;Martin&quot;, senority:5, department:&quot;Accounting&quot;}
    /// ]
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Column Template Demo&#39;,
    /// store: Ext.data.StoreManager.lookup(&#39;employeeStore&#39;),
    /// columns: [
    /// {text: &#39;Full Name&#39;,  xtype:&#39;templatecolumn&#39;, tpl:&#39;{firstname} {lastname}&#39;, flex:1},
    /// {text: &#39;Deparment (Yrs)&#39;, xtype:&#39;templatecolumn&#39;, tpl:&#39;{department} ({senority})&#39;}
    /// ],
    /// height: 200,
    /// width: 300,
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Template : Ext.grid.column.Column, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
    }
    #endregion
    #region TemplateConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TemplateConfig
    {
        public object tpl{get;set;}
    }
    #endregion
    #region TemplateEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TemplateEvents
    {
    }
    #endregion
}
#endregion
