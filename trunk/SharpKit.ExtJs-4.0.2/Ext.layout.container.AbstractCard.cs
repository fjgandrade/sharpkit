//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region AbstractCard
    /// <summary>
    /// This layout manages multiple child Components, each is fit to the Container, where only a single child Component
    /// can be visible at any given time.  This layout style is most commonly used for wizards, tab implementations, etc.
    /// This class is intended to be extended or created via the layout:&#39;card&#39; Ext.container.Container.layout config,
    /// and should generally not need to be created directly via the new keyword. The CardLayout&#39;s focal method is setActiveItem.  Since only one panel is displayed at a time,
    /// the only way to move from one Component to the next is by calling setActiveItem, passing the id or index of
    /// the next panel to display.  The layout itself does not provide a user interface for handling this navigation,
    /// so that functionality must be provided by the developer. Containers that are configured with a card layout will have a method setActiveItem dynamically added to it. var p = new Ext.panel.Panel({
    /// fullscreen: true,
    /// layout: &#39;card&#39;,
    /// items: [{
    /// html: &#39;Card 1&#39;
    /// },{
    /// html: &#39;Card 2&#39;
    /// }]
    /// });
    /// p.setActiveItem(1);
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class AbstractCard : Fit
    {
        /// <summary>
        /// Return the active (visible) component in the layout. ...
        /// </summary>
        public Ext.Component getActiveItem(){return null;}
        /// <summary>
        /// Return the active (visible) component in the layout to the next card ...
        /// </summary>
        public Ext.Component getNext(){return null;}
        /// <summary>
        /// Return the active (visible) component in the layout to the previous card ...
        /// </summary>
        public Ext.Component getPrev(){return null;}
        /// <summary>
        /// Sets the active (visible) component in the layout to the next card ...
        /// </summary>
        public Ext.Component next(){return null;}
        /// <summary>
        /// Sets the active (visible) component in the layout to the previous card ...
        /// </summary>
        public Ext.Component prev(){return null;}
    }
    #endregion
    #region AbstractCardConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractCardConfig
    {
        /// <summary>
        /// True to render each contained item at the time it becomes active, false to render all contained items
        /// as soon as the ...
        /// </summary>
        public bool deferredRender{get;set;}
    }
    #endregion
    #region AbstractCardEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractCardEvents
    {
    }
    #endregion
}
#endregion
