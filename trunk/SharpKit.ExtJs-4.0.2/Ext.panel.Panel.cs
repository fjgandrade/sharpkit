//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.panel
namespace Ext.panel
{
    #region Panel
    /// <summary>
    /// Panel is a container that has specific functionality and structural components that make
    /// it the perfect building block for application-oriented user interfaces. Panels are, by virtue of their inheritance from Ext.container.Container, capable
    /// of being configured with a layout, and containing child Components. When either specifying child items of a Panel, or dynamically adding Components
    /// to a Panel, remember to consider how you wish the Panel to arrange those child elements, and whether
    /// those child elements need to be sized using one of Ext&amp;#39;s built-in layout schemes. By
    /// default, Panels use the Auto scheme. This simply renders
    /// child components, appending them one after the other inside the Container, and does not apply any sizing
    /// at all.  A Panel may also contain bottom and top toolbars, along with separate
    /// header, footer and body sections (see frame for additional
    /// information). Panel also provides built-in collapsible, expandable and closable behavior.
    /// Panels can be easily dropped into any Container or layout, and the
    /// layout and rendering pipeline is completely managed by the framework. Note: By default, the close header tool destroys the Panel resulting in removal of the Panel
    /// and the destruction of any descendant Components. This makes the Panel object, and all its descendants unusable. To enable the close
    /// tool to simply hide a Panel for later re-use, configure the Panel with closeAction: &#39;hide&#39;. Usually, Panels are used as constituents within an application, in which case, they would be used as child items of Containers,
    /// and would themselves use Ext.Components as child items. However to illustrate simply rendering a Panel into the document,
    /// here&amp;#39;s how to do it:
    /// Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// title: &#39;Hello&#39;,
    /// width: 200,
    /// html: &#39;&amp;lt;p&amp;gt;World!&amp;lt;/p&amp;gt;&#39;,
    /// renderTo: document.body
    /// });
    /// A more realistic scenario is a Panel created to house input fields which will not be rendered, but used as a constituent part of a Container:
    /// var filterPanel = Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// bodyPadding: 5,  // Don&amp;#39;t want content to crunch against the borders
    /// title: &#39;Filters&#39;,
    /// items: [{
    /// xtype: &#39;datefield&#39;,
    /// fieldLabel: &#39;Start date&#39;
    /// }, {
    /// xtype: &#39;datefield&#39;,
    /// fieldLabel: &#39;End date&#39;
    /// }]
    /// });
    /// Note that the Panel above is not configured to render into the document, nor is it configured with a size or position. In a real world scenario,
    /// the Container into which the Panel is added will use a layout to render, size and position its child Components. Panels will often use specific layouts to provide an application with shape and structure by containing and arranging child
    /// Components:
    /// var resultsPanel = Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// title: &#39;Results&#39;,
    /// width: 600,
    /// height: 400,
    /// renderTo: document.body,
    /// layout: {
    /// type: &#39;vbox&#39;,       // Arrange child items vertically
    /// align: &#39;stretch&#39;,    // Each takes up full width
    /// padding: 5
    /// },
    /// items: [{               // Results grid specified as a config object with an xtype of &#39;grid&#39;
    /// xtype: &#39;grid&#39;,
    /// columns: [{header: &#39;Column One&#39;}],            // One header just for show. There&amp;#39;s no data,
    /// store: Ext.create(&#39;Ext.data.ArrayStore&#39;, {}), // A dummy empty data store
    /// flex: 1                                       // Use 1/3 of Container&amp;#39;s height (hint to Box layout)
    /// }, {
    /// xtype: &#39;splitter&#39;   // A splitter between the two child items
    /// }, {                    // Details Panel specified as a config object (no xtype defaults to &#39;panel&#39;).
    /// title: &#39;Details&#39;,
    /// bodyPadding: 5,
    /// items: [{
    /// fieldLabel: &#39;Data item&#39;,
    /// xtype: &#39;textfield&#39;
    /// }], // An array of form fields
    /// flex: 2             // Use 2/3 of Container&amp;#39;s height (hint to Box layout)
    /// }]
    /// });
    /// The example illustrates one possible method of displaying search results. The Panel contains a grid with the resulting data arranged
    /// in rows. Each selected row may be displayed in detail in the Panel below. The vbox layout is used
    /// to arrange the two vertically. It is configured to stretch child items horizontally to full width. Child items may either be configured
    /// with a numeric height, or with a flex value to distribute available space proportionately. This Panel itself may be a child item of, for exaple, a Ext.tab.Panel which will size its child items to fit within its
    /// content area. Using these techniques, as long as the layout is chosen and configured correctly, an application may have any level of
    /// nested containment, all dynamically sized according to configuration, the user&amp;#39;s preference and available browser size.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Panel : AbstractPanel, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Closes the Panel. ...
        /// </summary>
        public object close(){return null;}
        /// <summary>
        /// Collapses the panel body so that the body becomes hidden. ...
        /// </summary>
        public Ext.panel.Panel collapse(JsString direction, bool animate, object @internal){return null;}
        /// <summary>
        /// Expands the panel body so that it becomes visible. ...
        /// </summary>
        public Ext.panel.Panel expand(bool animate){return null;}
        /// <summary>
        /// Set the iconCls for the panel&#39;s header. ...
        /// </summary>
        public object setIconCls(JsString newIconCls){return null;}
        /// <summary>
        /// Set a title for the panel&#39;s header. ...
        /// </summary>
        public object setTitle(JsString newTitle){return null;}
        /// <summary>
        /// Shortcut for performing an expand or collapse based on the current state of the panel. ...
        /// </summary>
        public Ext.panel.Panel toggleCollapse(){return null;}
        /// <summary>
        /// If this Panel is configured draggable, this property will contain
        /// an instance of Ext.dd.DragSource which handles drag...
        /// </summary>
        public Ext.dd.DragSource dd{get;set;}
        public Panel(Ext.panel.PanelConfig config){}
        public Panel(){}
    }
    #endregion
    #region PanelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class PanelConfig : AbstractPanelConfig
    {
        /// <summary>
        /// true to animate the transition when the panel is collapsed, false to skip the
        /// animation (defaults to true if the Ext....
        /// </summary>
        public bool animCollapse{get;set;}
        /// <summary>
        /// Convenience method. ...
        /// </summary>
        public object bbar{get;set;}
        /// <summary>
        /// The alignment of any buttons added to this panel. ...
        /// </summary>
        public JsString buttonAlign{get;set;}
        /// <summary>
        /// Convenience method used for adding buttons docked to the bottom of the panel. ...
        /// </summary>
        public object buttons{get;set;}
        /// <summary>
        /// True to display the 'close' tool button and allow the user to close the window, false to
        /// hide the button and disallow...
        /// </summary>
        public bool closable{get;set;}
        /// <summary>
        /// The action to take when the close header tool is clicked:
        /// 'destroy' : Default
        /// remove the window from the DOM and des...
        /// </summary>
        public JsString closeAction{get;set;}
        /// <summary>
        /// The direction to collapse the Panel when the toggle button is clicked. ...
        /// </summary>
        public bool collapseDirection{get;set;}
        /// <summary>
        /// true to make sure the collapse/expand toggle button always renders first (to the left of)
        /// any other tools in the pane...
        /// </summary>
        public bool collapseFirst{get;set;}
        /// <summary>
        /// Important: this config is only effective for collapsible Panels which are direct child items of a border layout. ...
        /// </summary>
        public JsString collapseMode{get;set;}
        public bool collapsed{get;set;}
        public JsString collapsedCls{get;set;}
        /// <summary>
        /// True to make the panel collapsible and have an expand/collapse toggle Tool added into
        /// the header tool button area. ...
        /// </summary>
        public bool collapsible{get;set;}
        /// <summary>
        /// A component or series of components to be added as docked items to this panel. ...
        /// </summary>
        public new object dockedItems{get;set;}
        /// <summary>
        /// Convenience method used for adding items to the bottom of the panel. ...
        /// </summary>
        public object fbar{get;set;}
        /// <summary>
        /// Important: This config is only effective for collapsible Panels which are direct child items of a border layout. ...
        /// </summary>
        public bool floatable{get;set;}
        public new bool frame{get;set;}
        public bool frameHeader{get;set;}
        /// <summary>
        /// Specify as 'top', 'bottom', 'left' or 'right'. ...
        /// </summary>
        public JsString headerPosition{get;set;}
        public bool hideCollapseTool{get;set;}
        /// <summary>
        /// Convenience method. ...
        /// </summary>
        public object lbar{get;set;}
        /// <summary>
        /// Minimum width of all footer toolbar buttons in pixels (defaults to 75). ...
        /// </summary>
        public JsNumber minButtonWidth{get;set;}
        /// <summary>
        /// True to overlap the header in a panel over the framing of the panel itself. ...
        /// </summary>
        public object overlapHeader{get;set;}
        /// <summary>
        /// Important: This config is only effective for collapsible Panels which are direct child items of a border layout
        /// when ...
        /// </summary>
        public object placeholder{get;set;}
        /// <summary>
        /// Prevent a Header from being created and shown. ...
        /// </summary>
        public bool preventHeader{get;set;}
        /// <summary>
        /// Convenience method. ...
        /// </summary>
        public object rbar{get;set;}
        /// <summary>
        /// Convenience method. ...
        /// </summary>
        public object tbar{get;set;}
        /// <summary>
        /// The title text to be used to display in the panel header (defaults to ''). ...
        /// </summary>
        public JsString title{get;set;}
        /// <summary>
        /// true to allow expanding and collapsing the panel (when collapsible = true)
        /// by clicking anywhere in the header bar, fa...
        /// </summary>
        public bool titleCollapse{get;set;}
        /// <summary>
        /// An array of Ext.panel.Tool configs/instances to be added to the header tool area. ...
        /// </summary>
        public JsArray tools{get;set;}
    }
    #endregion
    #region PanelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class PanelEvents : AbstractPanelEvents
    {
        /// <summary>
        /// Fires before this panel is collapsed. ...
        /// </summary>
        public static JsString beforecollapse="beforecollapse";
        /// <summary>
        /// Fires before this panel is expanded. ...
        /// </summary>
        public static JsString beforeexpand="beforeexpand";
        /// <summary>
        /// Fires after this Panel hass collapsed. ...
        /// </summary>
        public static JsString collapse="collapse";
        /// <summary>
        /// Fires after this Panel has expanded. ...
        /// </summary>
        public static JsString expand="expand";
        /// <summary>
        /// Fires after the Panel iconCls has been set or changed. ...
        /// </summary>
        public static JsString iconchange="iconchange";
        /// <summary>
        /// Fires after the Panel title has been set or changed. ...
        /// </summary>
        public static JsString titlechange="titlechange";
    }
    #endregion
}
#endregion
