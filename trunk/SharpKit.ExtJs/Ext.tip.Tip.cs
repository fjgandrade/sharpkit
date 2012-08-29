//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tip
namespace Ext.tip
{
    #region Tip
    /// <inheritdocs />
    /// <summary>
    /// <p>This is the base class for <see cref="Ext.tip.QuickTip">Ext.tip.QuickTip</see> and <see cref="Ext.tip.ToolTip">Ext.tip.ToolTip</see> that provides the basic layout and
    /// positioning that all tip-based classes require. This class can be used directly for simple, statically-positioned
    /// tips that are displayed programmatically, or it can be extended to provide custom tip implementations.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Tip : Ext.panel.Panel
    {
        /// <summary>
        /// If true, then the tooltip will be automatically constrained to stay within
        /// the browser viewport.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool constrainPosition;
        /// <summary>
        /// Experimental. The default Ext.Element.alignTo anchor position value
        /// for this tip relative to its element of origin.
        /// Defaults to: <c>&quot;tl-bl?&quot;</c>
        /// </summary>
        public JsString defaultAlign;
        /// <summary>
        /// Set Tip draggable using base Component's draggability
        /// </summary>
        private void initDraggable(){}
        /// <summary>
        /// Shows this tip at the specified XY position.  Example usage:
        /// <code>// Show the tip at x:50 and y:100
        /// tip.showAt([50,100]);
        /// </code>
        /// </summary>
        /// <param name="xy"><p>An array containing the x and y coordinates</p>
        /// </param>
        public void showAt(JsArray<Number> xy){}
        /// <summary>
        /// Experimental. Shows this tip at a position relative to another element using
        /// a standard Ext.Element.alignTo anchor position value.  Example usage:
        /// // Show the tip at the default position ('tl-br?')
        /// tip.showBy('my-el');
        /// // Show the tip's top-left corner anchored to the element's top-right corner
        /// tip.showBy('my-el', 'tl-tr');
        /// </summary>
        /// <param name="el"><p>An HTMLElement, <see cref="Ext.dom.Element">Ext.Element</see> or string
        /// id of the target element to align to.</p>
        /// </param>
        /// <param name="position"><p>A valid <see cref="Ext.dom.Element.alignTo">Ext.Element.alignTo</see> anchor position.</p>
        /// <p>Defaults to 'tl-br?' or <see cref="Ext.tip.TipConfig.defaultAlign">defaultAlign</see> if specified.</p>
        /// </param>
        public void showBy(object el, object position=null){}
        public Tip(Ext.tip.TipConfig config){}
        public Tip(){}
        public Tip(params object[] args){}
    }
    #endregion
    #region TipConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TipConfig : Ext.panel.PanelConfig
    {
        /// <summary>
        /// If true, then the tooltip will be automatically constrained to stay within
        /// the browser viewport.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool constrainPosition;
        /// <summary>
        /// Experimental. The default Ext.Element.alignTo anchor position value
        /// for this tip relative to its element of origin.
        /// Defaults to: <c>&quot;tl-bl?&quot;</c>
        /// </summary>
        public JsString defaultAlign;
        public TipConfig(params object[] args){}
    }
    #endregion
    #region TipEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TipEvents : Ext.panel.PanelEvents
    {
        public TipEvents(params object[] args){}
    }
    #endregion
}
#endregion
