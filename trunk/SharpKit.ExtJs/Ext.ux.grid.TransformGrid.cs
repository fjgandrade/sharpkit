//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux.grid
{
    #region TransformGrid
    /// <inheritdocs />
    /// <summary>
    /// <p>A Grid which creates itself from an existing HTML table element.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class TransformGrid : Ext.grid.Panel
    {
        /// <summary>
        /// Creates the grid from HTML table element.
        /// </summary>
        /// <param name="table"><p>The table element from which this grid will be created -
        /// The table MUST have some type of size defined for the grid to fill. The container will be
        /// automatically set to position relative if it isn't already.</p>
        /// </param>
        /// <param name="config"><p>A config object that sets properties on this grid and has two additional (optional)
        /// properties: fields and columns which allow for customizing data fields and columns for this grid.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public TransformGrid(object table, object config=null){}
        public TransformGrid(TransformGridConfig config){}
        public TransformGrid(){}
        public TransformGrid(params object[] args){}
    }
    #endregion
    #region TransformGridConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TransformGridConfig : Ext.grid.PanelConfig
    {
        public TransformGridConfig(params object[] args){}
    }
    #endregion
    #region TransformGridEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TransformGridEvents : Ext.grid.PanelEvents
    {
        public TransformGridEvents(params object[] args){}
    }
    #endregion
}
