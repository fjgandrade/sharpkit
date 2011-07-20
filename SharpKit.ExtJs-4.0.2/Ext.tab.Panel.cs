//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:55
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tab
namespace Ext.tab
{
    #region Panel
    /// <summary>
    /// A basic tab container. TabPanels can be used exactly like a standard Ext.panel.Panel for layout purposes, but also
    /// have special support for containing child Components (items) that are managed
    /// using a CardLayout layout manager, and displayed as separate tabs. Note: By default, a tab&#39;s close tool destroys the child tab Component and all its descendants. This makes the child tab
    /// Component, and all its descendants unusable. To enable re-use of a tab, configure the TabPanel with autoDestroy: false. TabPanel&#39;s layout: TabPanels use a Dock layout to position the TabBar at the top of the widget. Panels added to the TabPanel will have their
    /// header hidden by default because the Tab will automatically take the Panel&#39;s configured title and icon. TabPanels use their header or footer element (depending on the tabPosition
    /// configuration) to accommodate the tab selector buttons. This means that a TabPanel will not display any configured title, and will not display any
    /// configured header tools. To display a header, embed the TabPanel in a Panel which uses layout:&#39;fit&#39;. Controlling tabs:
    /// Configuration options for the Ext.tab.Tab that represents the component can be passed in by specifying the tabConfig option: Ext.create(&#39;Ext.tab.Panel&#39;, {
    /// width: 400,
    /// height: 400,
    /// renderTo: document.body,
    /// items: [{
    /// title: &#39;Foo&#39;
    /// }, {
    /// title: &#39;Bar&#39;,
    /// tabConfig: {
    /// title: &#39;Custom Title&#39;,
    /// tooltip: &#39;A button tooltip&#39;
    /// }
    /// }]
    /// });
    /// Examples: Here is a basic TabPanel rendered to the body. This also shows the useful configuration activeTab, which allows you to set the active tab on render.
    /// If you do not set an activeTab, no tabs will be active by default.
    /// Example usage: Ext.create(&#39;Ext.tab.Panel&#39;, {
    /// width: 300,
    /// height: 200,
    /// activeTab: 0,
    /// items: [
    /// {
    /// title: &#39;Tab 1&#39;,
    /// bodyPadding: 10,
    /// html : &#39;A simple tab&#39;
    /// },
    /// {
    /// title: &#39;Tab 2&#39;,
    /// html : &#39;Another one&#39;
    /// }
    /// ],
    /// renderTo : Ext.getBody()
    /// });
    /// It is easy to control the visibility of items in the tab bar. Specify hidden: true to have the
    /// tab button hidden initially. Items can be subsequently hidden and show by accessing the
    /// tab property on the child item. Example usage: var tabs = Ext.create(&#39;Ext.tab.Panel&#39;, {
    /// width: 400,
    /// height: 400,
    /// renderTo: document.body,
    /// items: [{
    /// title: &#39;Home&#39;,
    /// html: &#39;Home&#39;,
    /// itemId: &#39;home&#39;
    /// }, {
    /// title: &#39;Users&#39;,
    /// html: &#39;Users&#39;,
    /// itemId: &#39;users&#39;,
    /// hidden: true
    /// }, {
    /// title: &#39;Tickets&#39;,
    /// html: &#39;Tickets&#39;,
    /// itemId: &#39;tickets&#39;
    /// }]
    /// });
    /// setTimeout(function(){
    /// tabs.child(&#39;#home&#39;).tab.hide();
    /// var users = tabs.child(&#39;#users&#39;);
    /// users.tab.show();
    /// tabs.setActiveTab(users);
    /// }, 1000);
    /// You can remove the background of the TabBar by setting the plain property to true. Example usage: Ext.create(&#39;Ext.tab.Panel&#39;, {
    /// width: 300,
    /// height: 200,
    /// activeTab: 0,
    /// plain: true,
    /// items: [
    /// {
    /// title: &#39;Tab 1&#39;,
    /// bodyPadding: 10,
    /// html : &#39;A simple tab&#39;
    /// },
    /// {
    /// title: &#39;Tab 2&#39;,
    /// html : &#39;Another one&#39;
    /// }
    /// ],
    /// renderTo : Ext.getBody()
    /// });
    /// Another useful configuration of TabPanel is tabPosition. This allows you to change the position where the tabs are displayed. The available
    /// options for this are &#39;top&#39; (default) and &#39;bottom&#39;.
    /// Example usage: Ext.create(&#39;Ext.tab.Panel&#39;, {
    /// width: 300,
    /// height: 200,
    /// activeTab: 0,
    /// bodyPadding: 10,
    /// tabPosition: &#39;bottom&#39;,
    /// items: [
    /// {
    /// title: &#39;Tab 1&#39;,
    /// html : &#39;A simple tab&#39;
    /// },
    /// {
    /// title: &#39;Tab 2&#39;,
    /// html : &#39;Another one&#39;
    /// }
    /// ],
    /// renderTo : Ext.getBody()
    /// });
    /// The setActiveTab is a very useful method in TabPanel which will allow you to change the current active tab. You can either give it an index or
    /// an instance of a tab. Example usage: var tabs = Ext.create(&#39;Ext.tab.Panel&#39;, {
    /// items: [
    /// {
    /// id   : &#39;my-tab&#39;,
    /// title: &#39;Tab 1&#39;,
    /// html : &#39;A simple tab&#39;
    /// },
    /// {
    /// title: &#39;Tab 2&#39;,
    /// html : &#39;Another one&#39;
    /// }
    /// ],
    /// renderTo : Ext.getBody()
    /// });
    /// var tab = Ext.getCmp(&#39;my-tab&#39;);
    /// Ext.create(&#39;Ext.button.Button&#39;, {
    /// renderTo: Ext.getBody(),
    /// text    : &#39;Select the first tab&#39;,
    /// scope   : this,
    /// handler : function() {
    /// tabs.setActiveTab(tab);
    /// }
    /// });
    /// Ext.create(&#39;Ext.button.Button&#39;, {
    /// text    : &#39;Select the second tab&#39;,
    /// scope   : this,
    /// handler : function() {
    /// tabs.setActiveTab(1);
    /// },
    /// renderTo : Ext.getBody()
    /// });
    /// The getActiveTab is a another useful method in TabPanel which will return the current active tab. Example usage: var tabs = Ext.create(&#39;Ext.tab.Panel&#39;, {
    /// items: [
    /// {
    /// title: &#39;Tab 1&#39;,
    /// html : &#39;A simple tab&#39;
    /// },
    /// {
    /// title: &#39;Tab 2&#39;,
    /// html : &#39;Another one&#39;
    /// }
    /// ],
    /// renderTo : Ext.getBody()
    /// });
    /// Ext.create(&#39;Ext.button.Button&#39;, {
    /// text    : &#39;Get active tab&#39;,
    /// scope   : this,
    /// handler : function() {
    /// var tab = tabs.getActiveTab();
    /// alert(&#39;Current tab: &#39; + tab.title);
    /// },
    /// renderTo : Ext.getBody()
    /// });
    /// Adding a new tab is very simple with a TabPanel. You simple call the add method with an config object for a panel. Example usage: var tabs = Ext.Create(&#39;Ext.tab.Panel&#39;, {
    /// items: [
    /// {
    /// title: &#39;Tab 1&#39;,
    /// html : &#39;A simple tab&#39;
    /// },
    /// {
    /// title: &#39;Tab 2&#39;,
    /// html : &#39;Another one&#39;
    /// }
    /// ],
    /// renderTo : Ext.getBody()
    /// });
    /// Ext.create(&#39;Ext.button.Button&#39;, {
    /// text    : &#39;New tab&#39;,
    /// scope   : this,
    /// handler : function() {
    /// var tab = tabs.add({
    /// title: &#39;Tab &#39; + (tabs.items.length + 1), //we use the tabs.items property to get the length of current items/tabs
    /// html : &#39;Another one&#39;
    /// });
    /// tabs.setActiveTab(tab);
    /// },
    /// renderTo : Ext.getBody()
    /// });
    /// Additionally, removing a tab is very also simple with a TabPanel. You simple call the remove method with an config object for a panel. Example usage: var tabs = Ext.Create(&#39;Ext.tab.Panel&#39;, {
    /// items: [
    /// {
    /// title: &#39;Tab 1&#39;,
    /// html : &#39;A simple tab&#39;
    /// },
    /// {
    /// id   : &#39;remove-this-tab&#39;,
    /// title: &#39;Tab 2&#39;,
    /// html : &#39;Another one&#39;
    /// }
    /// ],
    /// renderTo : Ext.getBody()
    /// });
    /// Ext.Create(&#39;Ext.button.Button&#39;, {
    /// text    : &#39;Remove tab&#39;,
    /// scope   : this,
    /// handler : function() {
    /// var tab = Ext.getCmp(&#39;remove-this-tab&#39;);
    /// tabs.remove(tab);
    /// },
    /// renderTo : Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Panel : Ext.panel.Panel, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Returns the item that is currently active inside this TabPanel. ...
        /// </summary>
        public object getActiveTab(){return null;}
        /// <summary>
        /// Returns the Ext.tab.Bar currently used in this TabPanel ...
        /// </summary>
        public Ext.tab.Bar getTabBar(){return null;}
        /// <summary>
        /// Makes the given card active (makes it the visible card in the TabPanel's CardLayout and highlights the Tab) ...
        /// </summary>
        public object setActiveTab(Ext.Component card){return null;}
        /// <summary>
        /// At this point the item hasn't been removed from the items collection. ...
        /// </summary>
        public object hasItemsLeft{get;set;}
        public Ext.tab.Bar tabBar{get;set;}
        public Panel(Ext.tab.PanelConfig config){}
        public Panel(){}
    }
    #endregion
    #region PanelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class PanelConfig : Ext.panel.PanelConfig
    {
        public bool Boolean{get;set;}
        /// <summary>
        /// true by default to defer the rendering of child items
        /// to the browsers DOM until a tab is activated. ...
        /// </summary>
        public bool deferredRender{get;set;}
        /// <summary>
        /// The class added to each child item of this TabPanel. ...
        /// </summary>
        public JsString itemCls{get;set;}
        /// <summary>
        /// Optional configuration object for the internal card layout. ...
        /// </summary>
        public new object layout{get;set;}
        /// <summary>
        /// The minimum width for a tab in the tabBar. ...
        /// </summary>
        public JsNumber minTabWidth{get;set;}
        /// <summary>
        /// True to instruct each Panel added to the TabContainer to not render its header
        /// element. ...
        /// </summary>
        public bool removePanelHeader{get;set;}
        /// <summary>
        /// Optional configuration object for the internal Ext.tab.Bar. ...
        /// </summary>
        public object tabBar{get;set;}
        /// <summary>
        /// The position where the tab strip should be rendered (defaults to 'top'). ...
        /// </summary>
        public JsString tabPosition{get;set;}
    }
    #endregion
    #region PanelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class PanelEvents : Ext.panel.PanelEvents
    {
        /// <summary>
        /// Fires before a tab change (activated by setActiveTab). ...
        /// </summary>
        public static JsString beforetabchange="beforetabchange";
        /// <summary>
        /// Fires when a new tab has been activated (activated by setActiveTab). ...
        /// </summary>
        public static JsString tabchange="tabchange";
    }
    #endregion
}
#endregion
