//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.chart.series
{
    #region Area
    /// <inheritdocs />
    /// <summary>
    /// <p>Creates a Stacked Area Chart. The stacked area chart is useful when displaying multiple aggregated layers of information.
    /// As with all other series, the Area Series must be appended in the <em>series</em> Chart array configuration. See the Chart
    /// documentation for more information. A typical configuration object for the area series could be:</p>
    /// <pre><code>var store = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.JsonStore">Ext.data.JsonStore</see>', {
    /// fields: ['name', 'data1', 'data2', 'data3', 'data4', 'data5'],
    /// data: [
    /// { 'name': 'metric one',   'data1':10, 'data2':12, 'data3':14, 'data4':8,  'data5':13 },
    /// { 'name': 'metric two',   'data1':7,  'data2':8,  'data3':16, 'data4':10, 'data5':3  },
    /// { 'name': 'metric three', 'data1':5,  'data2':2,  'data3':14, 'data4':12, 'data5':7  },
    /// { 'name': 'metric four',  'data1':2,  'data2':14, 'data3':6,  'data4':1,  'data5':23 },
    /// { 'name': 'metric five',  'data1':27, 'data2':38, 'data3':36, 'data4':13, 'data5':33 }
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.chart.Chart">Ext.chart.Chart</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// width: 500,
    /// height: 300,
    /// store: store,
    /// axes: [
    /// {
    /// type: 'Numeric',
    /// grid: true,
    /// position: 'left',
    /// fields: ['data1', 'data2', 'data3', 'data4', 'data5'],
    /// title: 'Sample Values',
    /// grid: {
    /// odd: {
    /// opacity: 1,
    /// fill: '#ddd',
    /// stroke: '#bbb',
    /// 'stroke-width': 1
    /// }
    /// },
    /// minimum: 0,
    /// adjustMinimumByMajorUnit: 0
    /// },
    /// {
    /// type: 'Category',
    /// position: 'bottom',
    /// fields: ['name'],
    /// title: 'Sample Metrics',
    /// grid: true,
    /// label: {
    /// rotate: {
    /// degrees: 315
    /// }
    /// }
    /// }
    /// ],
    /// series: [{
    /// type: 'area',
    /// highlight: false,
    /// axis: 'left',
    /// xField: 'name',
    /// yField: ['data1', 'data2', 'data3', 'data4', 'data5'],
    /// style: {
    /// opacity: 0.93
    /// }
    /// }]
    /// });
    /// </code></pre>
    /// <p>In this configuration we set <c>area</c> as the type for the series, set highlighting options to true for highlighting elements on hover,
    /// take the left axis to measure the data in the area series, set as xField (x values) the name field of each element in the store,
    /// and as yFields (aggregated layers) seven data fields from the same store. Then we override some theming styles by adding some opacity
    /// to the style object.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Area : Cartesian
    {
        /// <summary>
        /// Append styling properties to this object for it to override theme properties.
        /// Defaults to: <c>{}</c>
        /// </summary>
        public JsObject style;
        /// <summary>
        /// Draws the series for the current chart.
        /// </summary>
        public void drawSeries(){}
        /// <summary>
        /// Highlight this entire series.
        /// </summary>
        /// <param name="item"><p>Info about the item; same format as returned by <see cref="Ext.chart.series.Area.getItemForPoint">getItemForPoint</see>.</p>
        /// </param>
        public void highlightSeries(object item){}
        /// <summary>
        /// Un-highlights the specified item. If no item is provided it will un-highlight the entire series.
        /// </summary>
        /// <param name="item"><p>Info about the item; same format as returned by <see cref="Ext.chart.series.Area.getItemForPoint">getItemForPoint</see></p>
        /// </param>
        public void unHighlightItem(object item){}
        /// <summary>
        /// UnHighlight this entire series.
        /// </summary>
        /// <param name="item"><p>Info about the item; same format as returned by <see cref="Ext.chart.series.Area.getItemForPoint">getItemForPoint</see>.</p>
        /// </param>
        public void unHighlightSeries(object item){}
        public Area(AreaConfig config){}
        public Area(){}
        public Area(params object[] args){}
    }
    #endregion
    #region AreaConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AreaConfig : CartesianConfig
    {
        /// <summary>
        /// Append styling properties to this object for it to override theme properties.
        /// Defaults to: <c>{}</c>
        /// </summary>
        public JsObject style;
        public AreaConfig(params object[] args){}
    }
    #endregion
    #region AreaEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AreaEvents : CartesianEvents
    {
        public AreaEvents(params object[] args){}
    }
    #endregion
}
