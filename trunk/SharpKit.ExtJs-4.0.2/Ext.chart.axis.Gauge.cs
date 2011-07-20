//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:50:43
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.axis
namespace Ext.chart.axis
{
    #region Gauge
    /// <summary>
    /// Gauge Axis is the axis to be used with a Gauge series. The Gauge axis
    /// displays numeric data from an interval defined by the minimum, maximum and
    /// step configuration properties. The placement of the numeric data can be changed
    /// by altering the margin option that is set to 10 by default. A possible configuration for this axis would look like: axes: [{
    /// type: &#39;gauge&#39;,
    /// position: &#39;gauge&#39;,
    /// minimum: 0,
    /// maximum: 100,
    /// steps: 10,
    /// margin: 7
    /// }],
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Gauge : Abstract
    {
        /// <summary>
        /// Updates the title of this axis. ...
        /// </summary>
        public object setTitle(JsString title){return null;}
    }
    #endregion
    #region GaugeConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class GaugeConfig
    {
        /// <summary>
        /// (optional) the offset positioning of the tick marks and labels in pixels. ...
        /// </summary>
        public JsNumber margin{get;set;}
        public JsNumber maximum{get;set;}
        public JsNumber minimum{get;set;}
        public JsNumber steps{get;set;}
    }
    #endregion
    #region GaugeEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class GaugeEvents
    {
    }
    #endregion
}
#endregion
