//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:53
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.axis
namespace Ext.chart.axis
{
    #region Axis
    /// <summary>
    /// Defines axis for charts. The axis position, type, style can be configured.
    /// The axes are defined in an axes array of configuration objects where the type,
    /// field, grid and other configuration options can be set. To know more about how
    /// to create a Chart please check the Chart class documentation. Here&#39;s an example for the axes part:
    /// An example of axis for a series (in this case for an area chart that has multiple layers of yFields) could be: axes: [{
    /// type: &#39;Numeric&#39;,
    /// grid: true,
    /// position: &#39;left&#39;,
    /// fields: [&#39;data1&#39;, &#39;data2&#39;, &#39;data3&#39;],
    /// title: &#39;Number of Hits&#39;,
    /// grid: {
    /// odd: {
    /// opacity: 1,
    /// fill: &#39;#ddd&#39;,
    /// stroke: &#39;#bbb&#39;,
    /// &#39;stroke-width&#39;: 1
    /// }
    /// },
    /// minimum: 0
    /// }, {
    /// type: &#39;Category&#39;,
    /// position: &#39;bottom&#39;,
    /// fields: [&#39;name&#39;],
    /// title: &#39;Month of the Year&#39;,
    /// grid: true,
    /// label: {
    /// rotate: {
    /// degrees: 315
    /// }
    /// }
    /// }]
    /// In this case we use a Numeric axis for displaying the values of the Area series and a Category axis for displaying the names of
    /// the store elements. The numeric axis is placed on the left of the screen, while the category axis is placed at the bottom of the chart.
    /// Both the category and numeric axes have grid set, which means that horizontal and vertical lines will cover the chart background. In the
    /// category axis the labels will be rotated so they can fit the space better.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Axis : Abstract
    {
        /// <summary>
        /// Renders the axis into the screen and updates it's position. ...
        /// </summary>
        public object drawAxis(object init){return null;}
        /// <summary>
        /// Renders an horizontal and/or vertical grid into the Surface. ...
        /// </summary>
        public object drawGrid(){return null;}
        /// <summary>
        /// Renders the labels in the axes. ...
        /// </summary>
        public object drawLabel(){return null;}
        /// <summary>
        /// Updates the title of this axis. ...
        /// </summary>
        public object setTitle(JsString title){return null;}
        public Axis(AxisConfig config) : base(null){}
        public Axis() : base(null){}
    }
    #endregion
    #region AxisConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AxisConfig : AbstractConfig
    {
        /// <summary>
        /// The size of the dash marker. ...
        /// </summary>
        public JsNumber dashSize{get;set;}
        /// <summary>
        /// The grid configuration enables you to set a background grid for an axis. ...
        /// </summary>
        public object grid{get;set;}
        /// <summary>
        /// Offset axis position. ...
        /// </summary>
        public JsNumber length{get;set;}
        public JsNumber majorTickSteps{get;set;}
        /// <summary>
        /// The number of small ticks between two major ticks. ...
        /// </summary>
        public JsNumber minorTickSteps{get;set;}
        /// <summary>
        /// Where to set the axis. ...
        /// </summary>
        public JsString position{get;set;}
        /// <summary>
        /// Offset axis width. ...
        /// </summary>
        public JsNumber width{get;set;}
    }
    #endregion
    #region AxisEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AxisEvents : AbstractEvents
    {
    }
    #endregion
}
#endregion
