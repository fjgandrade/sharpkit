//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Grouper
    /// <summary>
    /// Represents a single grouper that can be applied to a Store. The grouper works
    /// in the same fashion as the Ext.util.Sorter.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Grouper : Sorter
    {
        /// <summary>
        /// Returns the value for grouping to be used. ...
        /// </summary>
        public JsString getGroupString(Ext.data.Model instance){return null;}
    }
    #endregion
    #region GrouperConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class GrouperConfig : SorterConfig
    {
    }
    #endregion
    #region GrouperEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class GrouperEvents : SorterEvents
    {
    }
    #endregion
}
#endregion
