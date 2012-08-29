//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.container
namespace Ext.container
{
    #region Viewport
    /// <inheritdocs />
    /// <summary>
    /// <p>A specialized container representing the viewable application area (the browser viewport).</p>
    /// <p>The Viewport renders itself to the document body, and automatically sizes itself to the size of
    /// the browser viewport and manages window resizing. There may only be one Viewport created
    /// in a page.</p>
    /// <p>Like any <see cref="Ext.container.Container">Container</see>, a Viewport will only perform sizing and positioning
    /// on its child Components if you configure it with a <see cref="Ext.container.ViewportConfig.layout">layout</see>.</p>
    /// <p>A Common layout used with Viewports is <see cref="Ext.layout.container.Border">border layout</see>, but if the
    /// required layout is simpler, a different layout should be chosen.</p>
    /// <p>For example, to simply make a single child item occupy all available space, use
    /// <see cref="Ext.layout.container.Fit">fit layout</see>.</p>
    /// <p>To display one "active" item at full size from a choice of several child items, use
    /// <see cref="Ext.layout.container.Card">card layout</see>.</p>
    /// <p>Inner layouts are available because all <see cref="Ext.panel.Panel">Panel</see>s
    /// added to the Viewport, either through its <see cref="Ext.container.ViewportConfig.items">items</see>, or the <see cref="Ext.container.Viewport.add">add</see>
    /// method of any of its child Panels may themselves have a layout.</p>
    /// <p>The Viewport does not provide scrolling, so child Panels within the Viewport should provide
    /// for scrolling if needed using the <see cref="Ext.container.ViewportConfig.autoScroll">autoScroll</see> config.</p>
    /// <p>An example showing a classic application border layout:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.container.Viewport">Ext.container.Viewport</see>', {
    /// layout: 'border',
    /// items: [{
    /// region: 'north',
    /// html: '&lt;h1 class="x-panel-header"&gt;Page Title&lt;/h1&gt;',
    /// border: false,
    /// margins: '0 0 5 0'
    /// }, {
    /// region: 'west',
    /// collapsible: true,
    /// title: 'Navigation',
    /// width: 150
    /// // could use a TreePanel or AccordionLayout for navigational items
    /// }, {
    /// region: 'south',
    /// title: 'South Panel',
    /// collapsible: true,
    /// html: 'Information goes here',
    /// split: true,
    /// height: 100,
    /// minHeight: 100
    /// }, {
    /// region: 'east',
    /// title: 'East Panel',
    /// collapsible: true,
    /// split: true,
    /// width: 150
    /// }, {
    /// region: 'center',
    /// xtype: 'tabpanel', // TabPanel itself has no title
    /// activeTab: 0,      // First tab active by default
    /// items: {
    /// title: 'Default Tab',
    /// html: 'The first tab\'s content. Others may be added dynamically'
    /// }
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Viewport : Ext.container.Container
    {
        /// <summary>
        /// </summary>
        public bool allowDomMove;
        /// <summary>
        /// </summary>
        public object applyTo;
        /// <summary>
        /// true in this class to identify an object as an instantiated Viewport, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isViewport{get;set;}
        public Viewport(ViewportConfig config){}
        public Viewport(){}
        public Viewport(params object[] args){}
    }
    #endregion
    #region ViewportConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ViewportConfig : Ext.container.ContainerConfig
    {
        /// <summary>
        /// </summary>
        public bool allowDomMove;
        /// <summary>
        /// </summary>
        public object applyTo;
        public ViewportConfig(params object[] args){}
    }
    #endregion
    #region ViewportEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ViewportEvents : Ext.container.ContainerEvents
    {
        public ViewportEvents(params object[] args){}
    }
    #endregion
}
#endregion
