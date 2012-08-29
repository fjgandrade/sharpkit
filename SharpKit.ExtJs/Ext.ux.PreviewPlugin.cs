//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.ux
namespace Ext.ux
{
    #region PreviewPlugin
    /// <inheritdocs />
    /// <summary>
    /// <p>The Preview enables you to show a configurable preview of a record.</p>
    /// <p>This plugin assumes that it has control over the features used for this
    /// particular grid section and may conflict with other plugins.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class PreviewPlugin : AbstractPlugin
    {
        /// <summary>
        /// Field to display in the preview. Must be a field within the Model definition
        /// that the store is using.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString bodyField;
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool previewExpanded;
        /// <summary>
        /// Toggle between the preview being expanded/hidden
        /// </summary>
        /// <param name="expanded"><p>Pass true to expand the record and false to not show the preview.</p>
        /// </param>
        public void toggleExpanded(bool expanded){}
        public PreviewPlugin(PreviewPluginConfig config){}
        public PreviewPlugin(){}
        public PreviewPlugin(params object[] args){}
    }
    #endregion
    #region PreviewPluginConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PreviewPluginConfig : AbstractPluginConfig
    {
        /// <summary>
        /// Field to display in the preview. Must be a field within the Model definition
        /// that the store is using.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString bodyField;
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool previewExpanded;
        public PreviewPluginConfig(params object[] args){}
    }
    #endregion
    #region PreviewPluginEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PreviewPluginEvents : AbstractPluginEvents
    {
        public PreviewPluginEvents(params object[] args){}
    }
    #endregion
}
#endregion
