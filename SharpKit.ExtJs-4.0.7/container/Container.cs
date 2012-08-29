//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.container
namespace Ext.container
{
    #region Container
    /// <summary>
    /// Base class for any Ext.Component that may contain other Components. Containers handle the
    /// basic behavior of containing items, namely adding, inserting and removing items. The most commonly used Container classes are Ext.panel.Panel, Ext.window.Window and Ext.tab.Panel.
    /// If you do not need the capabilities offered by the aforementioned classes you can create a lightweight
    /// Container to be encapsulated by an HTML element to your specifications by using the
    /// autoEl config option.  The code below illustrates how to explicitly create a Container:
    /// // explicitly create a Container
    /// Ext.create(&#39;Ext.container.Container&#39;, {
    /// layout: {
    /// type: &#39;hbox&#39;
    /// },
    /// width: 400,
    /// renderTo: Ext.getBody(),
    /// border: 1,
    /// style: {borderColor:&#39;#000000&#39;, borderStyle:&#39;solid&#39;, borderWidth:&#39;1px&#39;},
    /// defaults: {
    /// labelWidth: 80,
    /// // implicitly create Container by specifying xtype
    /// xtype: &#39;datefield&#39;,
    /// flex: 1,
    /// style: {
    /// padding: &#39;10px&#39;
    /// }
    /// },
    /// items: [{
    /// xtype: &#39;datefield&#39;,
    /// name: &#39;startDate&#39;,
    /// fieldLabel: &#39;Start date&#39;
    /// },{
    /// xtype: &#39;datefield&#39;,
    /// name: &#39;endDate&#39;,
    /// fieldLabel: &#39;End date&#39;
    /// }]
    /// });
    /// Layout Container classes delegate the rendering of child Components to a layout
    /// manager class which must be configured into the Container using the
    /// layout configuration property. When either specifying child items of a Container,
    /// or dynamically adding Components to a Container, remember to
    /// consider how you wish the Container to arrange those child elements, and
    /// whether those child elements need to be sized using one of Ext&#39;s built-in
    /// layout schemes. By default, Containers use the
    /// Auto scheme which only
    /// renders child components, appending them one after the other inside the
    /// Container, and does not apply any sizing at all. A common mistake is when a developer neglects to specify a
    /// layout (e.g. widgets like GridPanels or
    /// TreePanels are added to Containers for which no layout
    /// has been specified). If a Container is left to use the default
    /// {Ext.layout.container.Auto Auto} scheme, none of its
    /// child components will be resized, or changed in any way when the Container
    /// is resized. Certain layout managers allow dynamic addition of child components.
    /// Those that do include Ext.layout.container.Card,
    /// Ext.layout.container.Anchor, Ext.layout.container.VBox, Ext.layout.container.HBox, and
    /// Ext.layout.container.Table. For example:
    /// //  Create the GridPanel.
    /// var myNewGrid = new Ext.grid.Panel({
    /// store: myStore,
    /// headers: myHeaders,
    /// title: &#39;Results&#39;, // the title becomes the title of the tab
    /// });
    /// myTabPanel.add(myNewGrid); // Ext.tab.Panel implicitly uses Card
    /// myTabPanel.setActiveTab(myNewGrid);
    /// The example above adds a newly created GridPanel to a TabPanel. Note that
    /// a TabPanel uses Ext.layout.container.Card as its layout manager which
    /// means all its child items are sized to fit
    /// exactly into its client area.
    /// Overnesting is a common problem.
    /// An example of overnesting occurs when a GridPanel is added to a TabPanel
    /// by wrapping the GridPanel inside a wrapping Panel (that has no
    /// layout specified) and then add that wrapping Panel
    /// to the TabPanel. The point to realize is that a GridPanel is a
    /// Component which can be added directly to a Container. If the wrapping Panel
    /// has no layout configuration, then the overnested
    /// GridPanel will not be sized as expected. Adding via remote configuration A server side script can be used to add Components which are generated dynamically on the server.
    /// An example of adding a GridPanel to a TabPanel where the GridPanel is generated by the server
    /// based on certain parameters:
    /// // execute an Ajax request to invoke server side script:
    /// Ext.Ajax.request({
    /// url: &#39;gen-invoice-grid.php&#39;,
    /// // send additional parameters to instruct server script
    /// params: {
    /// startDate: Ext.getCmp(&#39;start-date&#39;).getValue(),
    /// endDate: Ext.getCmp(&#39;end-date&#39;).getValue()
    /// },
    /// // process the response object to add it to the TabPanel:
    /// success: function(xhr) {
    /// var newComponent = eval(xhr.responseText); // see discussion below
    /// myTabPanel.add(newComponent); // add the component to the TabPanel
    /// myTabPanel.setActiveTab(newComponent);
    /// },
    /// failure: function() {
    /// Ext.Msg.alert(&quot;Grid create failed&quot;, &quot;Server communication failure&quot;);
    /// }
    /// });
    /// The server script needs to return a JSON representation of a configuration object, which, when decoded
    /// will return a config object with an xtype. The server might return the following
    /// JSON: {
    /// &quot;xtype&quot;: &#39;grid&#39;,
    /// &quot;title&quot;: &#39;Invoice Report&#39;,
    /// &quot;store&quot;: {
    /// &quot;model&quot;: &#39;Invoice&#39;,
    /// &quot;proxy&quot;: {
    /// &quot;type&quot;: &#39;ajax&#39;,
    /// &quot;url&quot;: &#39;get-invoice-data.php&#39;,
    /// &quot;reader&quot;: {
    /// &quot;type&quot;: &#39;json&#39;
    /// &quot;record&quot;: &#39;transaction&#39;,
    /// &quot;idProperty&quot;: &#39;id&#39;,
    /// &quot;totalRecords&quot;: &#39;total&#39;
    /// })
    /// },
    /// &quot;autoLoad&quot;: {
    /// &quot;params&quot;: {
    /// &quot;startDate&quot;: &#39;01/01/2008&#39;,
    /// &quot;endDate&quot;: &#39;01/31/2008&#39;
    /// }
    /// }
    /// },
    /// &quot;headers&quot;: [
    /// {&quot;header&quot;: &quot;Customer&quot;, &quot;width&quot;: 250, &quot;dataIndex&quot;: &#39;customer&#39;, &quot;sortable&quot;: true},
    /// {&quot;header&quot;: &quot;Invoice Number&quot;, &quot;width&quot;: 120, &quot;dataIndex&quot;: &#39;invNo&#39;, &quot;sortable&quot;: true},
    /// {&quot;header&quot;: &quot;Invoice Date&quot;, &quot;width&quot;: 100, &quot;dataIndex&quot;: &#39;date&#39;, &quot;renderer&quot;: Ext.util.Format.dateRenderer(&#39;M d, y&#39;), &quot;sortable&quot;: true},
    /// {&quot;header&quot;: &quot;Value&quot;, &quot;width&quot;: 120, &quot;dataIndex&quot;: &#39;value&#39;, &quot;renderer&quot;: &#39;usMoney&#39;, &quot;sortable&quot;: true}
    /// ]
    /// }
    /// When the above code fragment is passed through the eval function in the success handler
    /// of the Ajax request, the result will be a config object which, when added to a Container, will cause instantiation
    /// of a GridPanel. Be sure that the Container is configured with a layout which sizes and positions the child items to your requirements. Note: since the code above is generated by a server script, the autoLoad params for
    /// the Store, the user&#39;s preferred date format, the metadata to allow generation of the Model layout, and the ColumnModel
    /// can all be generated into the code since these are all known on the server.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Container : Ext.container.AbstractContainer, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Return the immediate child Component in which the passed element is located. ...
        /// </summary>
        public Ext.Component getChildByElement(object el){return null;}
        public Container(Ext.container.ContainerConfig config){}
        public Container(){}
    }
    #endregion
    #region ContainerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ContainerConfig : Ext.container.AbstractContainerConfig
    {
    }
    #endregion
    #region ContainerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ContainerEvents : Ext.container.AbstractContainerEvents
    {
    }
    #endregion
}
#endregion
