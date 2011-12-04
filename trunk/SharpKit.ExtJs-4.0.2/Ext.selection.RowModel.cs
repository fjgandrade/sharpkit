//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.selection
namespace Ext.selection
{
    #region RowModel
    /// <summary>
    /// Implement row based navigation via keyboard. Must synchronize across grid sections
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class RowModel : Ext.selection.Model
    {
        public RowModel(RowModelConfig config){}
        public RowModel(){}
    }
    #endregion
    #region RowModelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RowModelConfig : Ext.selection.ModelConfig
    {
        /// <summary>
        /// Turns on/off keyboard navigation within the grid. ...
        /// </summary>
        public bool enableKeyNav{get;set;}
    }
    #endregion
    #region RowModelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RowModelEvents : Ext.selection.ModelEvents
    {
        /// <summary>
        /// Fired before a record is deselected. ...
        /// </summary>
        public static JsString beforedeselect="beforedeselect";
        /// <summary>
        /// Fired before a record is selected. ...
        /// </summary>
        public static JsString beforeselect="beforeselect";
        /// <summary>
        /// Fired after a record is deselected ...
        /// </summary>
        public static JsString deselect="deselect";
        /// <summary>
        /// Fired after a record is selected ...
        /// </summary>
        public static JsString select="select";
    }
    #endregion
}
#endregion