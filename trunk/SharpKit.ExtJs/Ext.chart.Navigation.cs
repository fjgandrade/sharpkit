//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart
namespace Ext.chart
{
    #region Navigation
    /// <summary>
    /// <p>Handles panning and zooming capabilities.</p>
    /// <p>Used as mixin by <see cref="Ext.chart.Chart">Ext.chart.Chart</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial interface Navigation
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        JsString @className{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        JsObject configMap{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        JsObject initConfigMap{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        bool isInstance{get;set;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. Unlike statics,
        /// this.self is scope-dependent and it's meant to be used for dynamic inheritance. See statics
        /// for a detailed comparison
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// alert(this.self.speciesName); // dependent on 'this'
        /// },
        /// clone: function() {
        /// return new this.self();
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'         // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// }
        /// });
        /// var cat = new My.Cat();                     // alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard();     // alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));             // alerts 'My.SnowLeopard'
        /// </code>
        /// </summary>
        Class self{get;set;}
        /// <summary>
        /// Restores the zoom to the original value. This can be used to reset
        /// the previous zoom state set by setZoom. For example:
        /// <code>myChart.restoreZoom();
        /// </code>
        /// </summary>
        void restoreZoom();
        /// <summary>
        /// Zooms the chart to the specified selection range.
        /// Can be used with a selection mask. For example:
        /// <code>items: {
        /// xtype: 'chart',
        /// animate: true,
        /// store: store1,
        /// mask: 'horizontal',
        /// listeners: {
        /// select: {
        /// fn: function(me, selection) {
        /// me.setZoom(selection);
        /// me.mask.hide();
        /// }
        /// }
        /// }
        /// }
        /// </code>
        /// </summary>
        /// <param name="zoomConfig">
        /// </param>
        void setZoom(object zoomConfig);
    }
    #endregion
    #region NavigationConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NavigationConfig : Ext.BaseConfig
    {
        public NavigationConfig(params object[] args){}
    }
    #endregion
    #region NavigationEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NavigationEvents : Ext.BaseEvents
    {
        public NavigationEvents(params object[] args){}
    }
    #endregion
}
#endregion
