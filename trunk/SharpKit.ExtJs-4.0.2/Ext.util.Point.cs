//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Point
    /// <summary>
    /// Represents a 2D point with x and y properties, useful for comparison and instantiation
    /// from an event: var point = Ext.util.Point.fromEvent(e);
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Point : Region
    {
        /// <summary>
        /// Compare this point and another point ...
        /// </summary>
        public bool equals(object The){return false;}
        /// <summary>
        /// Whether the given point is not away from this point within the given threshold amount. ...
        /// </summary>
        public bool isWithin(object The, object threshold){return false;}
        /// <summary>
        /// Compare this point with another point when the x and y values of both points are rounded. ...
        /// </summary>
        public bool roundedEquals(object The){return false;}
        /// <summary>
        /// Returns a human-eye-friendly string that represents this point,
        /// useful for debugging ...
        /// </summary>
        public JsString toString(){return null;}
        /// <summary>
        /// Translate this region by the given offset amount. ...
        /// </summary>
        public Region translate(object offset, JsNumber The){return null;}
    }
    #endregion
    #region PointConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class PointConfig
    {
    }
    #endregion
    #region PointEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class PointEvents
    {
    }
    #endregion
}
#endregion
