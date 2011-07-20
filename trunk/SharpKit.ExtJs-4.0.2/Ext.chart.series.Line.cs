//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.series
namespace Ext.chart.series
{
    #region Line
    /// <summary>
    /// Creates a Line Chart. A Line Chart is a useful visualization technique to display quantitative information for different
    /// categories or other real values (as opposed to the bar chart), that can show some progression (or regression) in the dataset.
    /// As with all other series, the Line Series must be appended in the series Chart array configuration. See the Chart
    /// documentation for more information. A typical configuration object for the line series could be:  var store = Ext.create(&#39;Ext.data.JsonStore&#39;, {
    /// fields: [&#39;name&#39;, &#39;data1&#39;, &#39;data2&#39;, &#39;data3&#39;, &#39;data4&#39;, &#39;data5&#39;],
    /// data: [
    /// {&#39;name&#39;:&#39;metric one&#39;, &#39;data1&#39;:10, &#39;data2&#39;:12, &#39;data3&#39;:14, &#39;data4&#39;:8, &#39;data5&#39;:13},
    /// {&#39;name&#39;:&#39;metric two&#39;, &#39;data1&#39;:7, &#39;data2&#39;:8, &#39;data3&#39;:16, &#39;data4&#39;:10, &#39;data5&#39;:3},
    /// {&#39;name&#39;:&#39;metric three&#39;, &#39;data1&#39;:5, &#39;data2&#39;:2, &#39;data3&#39;:14, &#39;data4&#39;:12, &#39;data5&#39;:7},
    /// {&#39;name&#39;:&#39;metric four&#39;, &#39;data1&#39;:2, &#39;data2&#39;:14, &#39;data3&#39;:6, &#39;data4&#39;:1, &#39;data5&#39;:23},
    /// {&#39;name&#39;:&#39;metric five&#39;, &#39;data1&#39;:27, &#39;data2&#39;:38, &#39;data3&#39;:36, &#39;data4&#39;:13, &#39;data5&#39;:33}
    /// ]
    /// });
    /// Ext.create(&#39;Ext.chart.Chart&#39;, {
    /// renderTo: Ext.getBody(),
    /// width: 500,
    /// height: 300,
    /// animate: true,
    /// store: store,
    /// axes: [{
    /// type: &#39;Numeric&#39;,
    /// position: &#39;bottom&#39;,
    /// fields: [&#39;data1&#39;],
    /// label: {
    /// renderer: Ext.util.Format.numberRenderer(&#39;0,0&#39;)
    /// },
    /// title: &#39;Sample Values&#39;,
    /// grid: true,
    /// minimum: 0
    /// }, {
    /// type: &#39;Category&#39;,
    /// position: &#39;left&#39;,
    /// fields: [&#39;name&#39;],
    /// title: &#39;Sample Metrics&#39;
    /// }],
    /// series: [{
    /// type: &#39;line&#39;,
    /// highlight: {
    /// size: 7,
    /// radius: 7
    /// },
    /// axis: &#39;left&#39;,
    /// xField: &#39;name&#39;,
    /// yField: &#39;data1&#39;,
    /// markerCfg: {
    /// type: &#39;cross&#39;,
    /// size: 4,
    /// radius: 4,
    /// &#39;stroke-width&#39;: 0
    /// }
    /// }, {
    /// type: &#39;line&#39;,
    /// highlight: {
    /// size: 7,
    /// radius: 7
    /// },
    /// axis: &#39;left&#39;,
    /// fill: true,
    /// xField: &#39;name&#39;,
    /// yField: &#39;data3&#39;,
    /// markerCfg: {
    /// type: &#39;circle&#39;,
    /// size: 4,
    /// radius: 4,
    /// &#39;stroke-width&#39;: 0
    /// }
    /// }]
    /// });
    /// In this configuration we&#39;re adding two series (or lines), one bound to the data1
    /// property of the store and the other to data3. The type for both configurations is
    /// line. The xField for both series is the same, the name propert of the store.
    /// Both line series share the same axis, the left axis. You can set particular marker
    /// configuration by adding properties onto the markerConfig object. Both series have
    /// an object as highlight so that markers animate smoothly to the properties in highlight
    /// when hovered. The second series has fill=true which means that the line will also
    /// have an area below it of the same color. Note: In the series definition remember to explicitly set the axis to bind the
    /// values of the line series to. This can be done by using the axis configuration property.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Line : Cartesian, Ext.util.Observable, Ext.chart.Label, Highlight, Ext.chart.Tip, Callout
    {
        /// <summary>
        /// Draws the series for the current chart. ...
        /// </summary>
        public object drawSeries(){return null;}
    }
    #endregion
    #region LineConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class LineConfig : CartesianConfig
    {
        /// <summary>
        /// The position of the axis to bind the values to. ...
        /// </summary>
        public JsString axis{get;set;}
        /// <summary>
        /// If true, the area below the line will be filled in using the style.eefill and
        /// style.opacity config properties. ...
        /// </summary>
        public bool fill{get;set;}
        /// <summary>
        /// The display style for the markers. ...
        /// </summary>
        public object markerConfig{get;set;}
        /// <summary>
        /// The offset distance from the cursor position to the line series to trigger events (then used for highlighting series,...
        /// </summary>
        public JsNumber selectionTolerance{get;set;}
        /// <summary>
        /// Whether markers should be displayed at the data points along the line. ...
        /// </summary>
        public bool showMarkers{get;set;}
        /// <summary>
        /// If set to true or a non-zero number, the line will be smoothed/rounded around its points; otherwise
        /// straight line seg...
        /// </summary>
        public object smooth{get;set;}
        /// <summary>
        /// An object containing styles for the visualization lines. ...
        /// </summary>
        public object style{get;set;}
    }
    #endregion
    #region LineEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class LineEvents : CartesianEvents
    {
    }
    #endregion
}
#endregion
