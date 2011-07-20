//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:26
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.property
namespace Ext.grid.property
{
    #region Property
    /// <summary>
    /// A specific Ext.data.Model type that represents a name/value pair and is made to work with the
    /// Ext.grid.property.Grid.  Typically, Properties do not need to be created directly as they can be
    /// created implicitly by simply using the appropriate data configs either via the Ext.grid.property.Grid.source
    /// config property or by calling Ext.grid.property.Grid.setSource.  However, if the need arises, these records
    /// can also be created explicitly as shown below.  Example usage: var rec = new Ext.grid.property.Property({
    /// name: &#39;birthday&#39;,
    /// value: Ext.Date.parse(&#39;17/06/1962&#39;, &#39;d/m/Y&#39;)
    /// });
    /// // Add record to an already populated grid
    /// grid.store.addSorted(rec);
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Property : Ext.data.Model, Ext.util.Observable
    {
        /// <summary>
        /// ...
        /// </summary>
        public object constructor(object config){return null;}
    }
    #endregion
    #region PropertyConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class PropertyConfig
    {
    }
    #endregion
    #region PropertyEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class PropertyEvents
    {
    }
    #endregion
}
#endregion
