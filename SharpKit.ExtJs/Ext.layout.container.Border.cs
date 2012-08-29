//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout.container
{
    #region Border
    /// <inheritdocs />
    /// <summary>
    /// <p>This is a multi-pane, application-oriented UI layout style that supports multiple nested panels, automatic bars
    /// between regions and built-in <see cref="Ext.panel.PanelConfig.collapsible">expanding and collapsing</see> of regions.</p>
    /// <p>This class is intended to be extended or created via the <c>layout:'border'</c> <see cref="Ext.container.ContainerConfig.layout">Ext.container.Container.layout</see>
    /// config, and should generally not need to be created directly via the new keyword.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.panel.Panel">Ext.panel.Panel</see>', {
    /// width: 500,
    /// height: 300,
    /// title: 'Border Layout',
    /// layout: 'border',
    /// items: [{
    /// title: 'South Region is resizable',
    /// region: 'south',     // position for region
    /// xtype: 'panel',
    /// height: 100,
    /// split: true,         // enable resizing
    /// margins: '0 5 5 5'
    /// },{
    /// // xtype: 'panel' implied by default
    /// title: 'West Region is collapsible',
    /// region:'west',
    /// xtype: 'panel',
    /// margins: '5 0 0 5',
    /// width: 200,
    /// collapsible: true,   // make collapsible
    /// id: 'west-region-container',
    /// layout: 'fit'
    /// },{
    /// title: 'Center Region',
    /// region: 'center',     // center region is required, no width/height specified
    /// xtype: 'panel',
    /// layout: 'fit',
    /// margins: '5 5 0 0'
    /// }],
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// <h1>Notes</h1>
    /// <ul>
    /// <li><p>When using the split option, the layout will automatically insert a <see cref="Ext.resizer.Splitter">Ext.resizer.Splitter</see>
    /// into the appropriate place. This will modify the underlying
    /// <see cref="Ext.container.Container.items">items</see> collection in the container.</p></li>
    /// <li><p>Any Container using the Border layout <strong>must</strong> have a child item with <c>region:'center'</c>.
    /// The child item in the center region will always be resized to fill the remaining space
    /// not used by the other regions in the layout.</p></li>
    /// <li><p>Any child items with a region of <c>west</c> or <c>east</c> may be configured with either an initial
    /// <c>width</c>, or a <see cref="Ext.layout.container.BoxConfig.flex">Ext.layout.container.Box.flex</see> value, or an initial percentage width
    /// <strong>string</strong> (Which is simply divided by 100 and used as a flex value).
    /// The 'center' region has a flex value of <c>1</c>.</p></li>
    /// <li><p>Any child items with a region of <c>north</c> or <c>south</c> may be configured with either an initial
    /// <c>height</c>, or a <see cref="Ext.layout.container.BoxConfig.flex">Ext.layout.container.Box.flex</see> value, or an initial percentage height
    /// <strong>string</strong> (Which is simply divided by 100 and used as a flex value).
    /// The 'center' region has a flex value of <c>1</c>.</p></li>
    /// <li><p><strong>There is no BorderLayout.Region class in ExtJS 4.0+</strong></p></li>
    /// </ul>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Border : Ext.layout.container.Container
    {
        /// <summary>
        /// Sets the padding to be applied to all child items managed by this layout.
        /// This property can be specified as a string containing space-separated, numeric
        /// padding values. The order of the sides associated with each value matches the way
        /// CSS processes padding values:
        /// <li>If there is only one value, it applies to all sides.</li>
        /// <li>If there are two values, the top and bottom borders are set to the first value
        /// and the right and left are set to the second.</li>
        /// <li>If there are three values, the top is set to the first value, the left and right
        /// are set to the second, and the bottom is set to the third.</li>
        /// <li>If there are four values, they apply to the top, right, bottom, and left,
        /// respectively.</li>
        /// </summary>
        public object padding;
        /// <summary>
        /// The default weights to assign to regions in the border layout. These values are
        /// used when a region does not contain a weight property. This object must have
        /// properties for all regions ("north", "south", "east" and "west").
        /// <strong>IMPORTANT:</strong> Since this is an object, changing its properties will impact ALL
        /// instances of Border layout. If this is not desired, provide a replacement object as
        /// a config option instead:
        /// <code> layout: {
        /// type: 'border',
        /// regionWeights: {
        /// west: 20,
        /// north: 10,
        /// south: -10,
        /// east: -20
        /// }
        /// }
        /// </code>
        /// The region with the highest weight is assigned space from the border before other
        /// regions. Regions of equal weight are assigned space based on their position in the
        /// owner's items list (first come, first served).
        /// </summary>
        public JsObject regionWeights;
        /// <summary>
        /// This configuration option is to be applied to the child items managed by this layout.
        /// Each region with split:true will get a Splitter that
        /// allows for manual resizing of the container. Except for the center region.
        /// </summary>
        public bool split;
        /// <summary>
        /// This configuration option is to be applied to the child items managed by this layout and
        /// is used in conjunction with split. By default, when specifying split, the region
        /// can be dragged to be resized. Set this option to false to show the split bar but prevent resizing.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool splitterResize;
        /// <summary>
        /// Reused meta-data objects that describe axis properties.
        /// Defaults to: <c>{horz: {borderBegin: &quot;west&quot;, borderEnd: &quot;east&quot;, horizontal: true, posProp: &quot;x&quot;, sizeProp: &quot;width&quot;, sizePropCap: &quot;Width&quot;}, vert: {borderBegin: &quot;north&quot;, borderEnd: &quot;south&quot;, horizontal: false, posProp: &quot;y&quot;, sizeProp: &quot;height&quot;, sizePropCap: &quot;Height&quot;}}</c>
        /// </summary>
        private JsObject axisProps{get;set;}
        /// <summary>
        /// Maps from region name to collapseDirection for panel.
        /// Defaults to: <c>{north: &quot;top&quot;, south: &quot;bottom&quot;, east: &quot;right&quot;, west: &quot;left&quot;}</c>
        /// </summary>
        private JsObject collapseDirections{get;set;}
        /// <summary>
        /// Lists the regions that would consider an interior region a neighbor. For example,
        /// a north region would consider an east or west region its neighbords (as well as
        /// an inner north region).
        /// Defaults to: <c>{center: [&quot;north&quot;, &quot;south&quot;, &quot;east&quot;, &quot;west&quot;], north: [&quot;north&quot;, &quot;east&quot;, &quot;west&quot;], south: [&quot;south&quot;, &quot;east&quot;, &quot;west&quot;], east: [&quot;east&quot;, &quot;north&quot;, &quot;south&quot;], west: [&quot;west&quot;, &quot;north&quot;, &quot;south&quot;]}</c>
        /// </summary>
        private JsObject touchedRegions{get;set;}
        /// <summary>
        /// Creates the axis objects for the layout. These are only missing size information
        /// which is added during calculate.
        /// </summary>
        /// <param name="ownerContext">
        /// </param>
        /// <param name="regions">
        /// </param>
        /// <param name="name">
        /// </param>
        private void beginAxis(object ownerContext, object regions, object name){}
        /// <summary>
        /// Performs the calculations for a region on a specified axis.
        /// </summary>
        /// <param name="childContext">
        /// </param>
        /// <param name="axis">
        /// </param>
        private void calculateChildAxis(object childContext, object axis){}
        /// <summary>
        /// Finishes the calculations on an axis. This basically just assigns the remaining
        /// space to the center region.
        /// </summary>
        /// <param name="ownerContext">
        /// </param>
        /// <param name="axis">
        /// </param>
        private void finishAxis(object ownerContext, object axis){}
        /// <summary>
        /// Finishes by setting the positions on the child items.
        /// </summary>
        /// <param name="childItems">
        /// </param>
        private void finishPositions(object childItems){}
        /// <summary>
        /// Inserts the splitter for a given region. A reference to the splitter is also stored
        /// on the component as "splitter".
        /// </summary>
        /// <param name="item">
        /// </param>
        /// <param name="index">
        /// </param>
        /// <param name="hidden">
        /// </param>
        private void insertSplitter(object item, object index, object hidden){}
        /// <summary>
        /// Called when a region (actually when any component) is added to the container. The
        /// region is decorated with some helpful properties (isCenter, isHorz, isVert) and its
        /// splitter is added if its "split" property is true.
        /// </summary>
        /// <param name="item">
        /// </param>
        /// <param name="index">
        /// </param>
        private void onAdd(object item, object index){}
        public Border(BorderConfig config){}
        public Border(){}
        public Border(params object[] args){}
    }
    #endregion
    #region BorderConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class BorderConfig : Ext.layout.container.ContainerConfig
    {
        /// <summary>
        /// Sets the padding to be applied to all child items managed by this layout.
        /// This property can be specified as a string containing space-separated, numeric
        /// padding values. The order of the sides associated with each value matches the way
        /// CSS processes padding values:
        /// <li>If there is only one value, it applies to all sides.</li>
        /// <li>If there are two values, the top and bottom borders are set to the first value
        /// and the right and left are set to the second.</li>
        /// <li>If there are three values, the top is set to the first value, the left and right
        /// are set to the second, and the bottom is set to the third.</li>
        /// <li>If there are four values, they apply to the top, right, bottom, and left,
        /// respectively.</li>
        /// </summary>
        public object padding;
        /// <summary>
        /// The default weights to assign to regions in the border layout. These values are
        /// used when a region does not contain a weight property. This object must have
        /// properties for all regions ("north", "south", "east" and "west").
        /// <strong>IMPORTANT:</strong> Since this is an object, changing its properties will impact ALL
        /// instances of Border layout. If this is not desired, provide a replacement object as
        /// a config option instead:
        /// <code> layout: {
        /// type: 'border',
        /// regionWeights: {
        /// west: 20,
        /// north: 10,
        /// south: -10,
        /// east: -20
        /// }
        /// }
        /// </code>
        /// The region with the highest weight is assigned space from the border before other
        /// regions. Regions of equal weight are assigned space based on their position in the
        /// owner's items list (first come, first served).
        /// </summary>
        public JsObject regionWeights;
        /// <summary>
        /// This configuration option is to be applied to the child items managed by this layout.
        /// Each region with split:true will get a Splitter that
        /// allows for manual resizing of the container. Except for the center region.
        /// </summary>
        public bool split;
        /// <summary>
        /// This configuration option is to be applied to the child items managed by this layout and
        /// is used in conjunction with split. By default, when specifying split, the region
        /// can be dragged to be resized. Set this option to false to show the split bar but prevent resizing.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool splitterResize;
        public BorderConfig(params object[] args){}
    }
    #endregion
    #region BorderEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class BorderEvents : Ext.layout.container.ContainerEvents
    {
        public BorderEvents(params object[] args){}
    }
    #endregion
}
