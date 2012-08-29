//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tab
namespace Ext.tab
{
    #region Bar
    /// <inheritdocs />
    /// <summary>
    /// <p>TabBar is used internally by a <see cref="Ext.tab.Panel">TabPanel</see> and typically should not need to be created manually.
    /// The tab bar automatically removes the default title provided by <see cref="Ext.panel.Header">Ext.panel.Header</see></p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Bar : Ext.panel.Header
    {
        /// <summary>
        /// The maximum width for a tab in this tab Bar. Defaults to the tab Panel's maxTabWidth value.
        /// <p>This cfg has been <strong>deprecated</strong> </p>
        /// <p>This config is deprecated. It is much easier to use the <see cref="Ext.tab.PanelConfig.maxTabWidth">maxTabWidth</see> config on the TabPanel.</p>
        /// </summary>
        public JsNumber maxTabWidth;
        /// <summary>
        /// The minimum width for a tab in this tab Bar. Defaults to the tab Panel's minTabWidth value.
        /// <p>This cfg has been <strong>deprecated</strong> </p>
        /// <p>This config is deprecated. It is much easier to use the <see cref="Ext.tab.PanelConfig.minTabWidth">minTabWidth</see> config on the TabPanel.</p>
        /// </summary>
        public JsNumber minTabWidth;
        /// <summary>
        /// True to not show the full background on the tabbar
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool plain;
        /// <summary>
        /// true in this class to identify an objact as an instantiated Tab Bar, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isTabBar{get;set;}
        /// <summary>
        /// Closes the given tab by removing it from the TabBar and removing the corresponding card from the TabPanel
        /// </summary>
        /// <param name="toClose"><p>The tab to close</p>
        /// </param>
        private void closeTab(Ext.tab.Tab toClose){}
        /// <summary>
        /// Marks the given tab as active
        /// </summary>
        /// <param name="tab"><p>The tab to mark active</p>
        /// </param>
        private void setActiveTab(Ext.tab.Tab tab){}
        public Bar(Ext.tab.BarConfig config){}
        public Bar(){}
        public Bar(params object[] args){}
    }
    #endregion
    #region BarConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class BarConfig : Ext.panel.HeaderConfig
    {
        /// <summary>
        /// The maximum width for a tab in this tab Bar. Defaults to the tab Panel's maxTabWidth value.
        /// <p>This cfg has been <strong>deprecated</strong> </p>
        /// <p>This config is deprecated. It is much easier to use the <see cref="Ext.tab.PanelConfig.maxTabWidth">maxTabWidth</see> config on the TabPanel.</p>
        /// </summary>
        public JsNumber maxTabWidth;
        /// <summary>
        /// The minimum width for a tab in this tab Bar. Defaults to the tab Panel's minTabWidth value.
        /// <p>This cfg has been <strong>deprecated</strong> </p>
        /// <p>This config is deprecated. It is much easier to use the <see cref="Ext.tab.PanelConfig.minTabWidth">minTabWidth</see> config on the TabPanel.</p>
        /// </summary>
        public JsNumber minTabWidth;
        /// <summary>
        /// True to not show the full background on the tabbar
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool plain;
        public BarConfig(params object[] args){}
    }
    #endregion
    #region BarEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class BarEvents : Ext.panel.HeaderEvents
    {
        /// <summary>
        /// Fired when the currently-active tab has changed
        /// </summary>
        /// <param name="tabBar"><p>The TabBar</p>
        /// </param>
        /// <param name="tab"><p>The new Tab</p>
        /// </param>
        /// <param name="card"><p>The card that was just shown in the TabPanel</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void change(Ext.tab.Bar tabBar, Ext.tab.Tab tab, Ext.Component card, object eOpts){}
        public BarEvents(params object[] args){}
    }
    #endregion
}
#endregion
