//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.view
namespace Ext.view
{
    #region View
    /// <summary>
    /// A mechanism for displaying data using custom layout templates and formatting. DataView uses an Ext.XTemplate
    /// as its internal templating mechanism, and is bound to an Ext.data.Store
    /// so that as the data in the store changes the view is automatically updated to reflect the changes.  The view also
    /// provides built-in behavior for many common events that can occur for its contained items including click, doubleclick,
    /// mouseover, mouseout, etc. as well as a built-in selection model. In order to use these features, an itemSelector
    /// config must be provided for the DataView to determine what nodes it will be working with. The example below binds a DataView to a Ext.data.Store and renders it into an Ext.panel.Panel.  Ext.regModel(&#39;Image&#39;, {
    /// Fields: [
    /// {name:&#39;src&#39;, type:&#39;string&#39;},
    /// {name:&#39;caption&#39;, type:&#39;string&#39;}
    /// ]
    /// });
    /// Ext.create(&#39;Ext.data.Store&#39;, {
    /// id:&#39;imagesStore&#39;,
    /// model: &#39;Image&#39;,
    /// data: [
    /// {src:&#39;http://www.sencha.com/img/20110215-feat-drawing.png&#39;, caption:&#39;Drawing &amp;amp; Charts&#39;},
    /// {src:&#39;http://www.sencha.com/img/20110215-feat-data.png&#39;, caption:&#39;Advanced Data&#39;},
    /// {src:&#39;http://www.sencha.com/img/20110215-feat-html5.png&#39;, caption:&#39;Overhauled Theme&#39;},
    /// {src:&#39;http://www.sencha.com/img/20110215-feat-perf.png&#39;, caption:&#39;Performance Tuned&#39;}
    /// ]
    /// });
    /// var imageTpl = new Ext.XTemplate(
    /// &#39;&amp;amp;lt;tpl for=&quot;.&quot;&amp;amp;gt;&#39;,
    /// &#39;&amp;amp;lt;div style=&quot;thumb-wrap&quot;&amp;amp;gt;&#39;,
    /// &#39;&amp;amp;lt;img src=&quot;{src}&quot; /&amp;amp;gt;&#39;,
    /// &#39;&amp;amp;lt;br/&amp;amp;gt;&amp;amp;lt;span&amp;amp;gt;{caption}&amp;amp;lt;/span&amp;amp;gt;&#39;,
    /// &#39;&amp;amp;lt;/div&amp;amp;gt;&#39;,
    /// &#39;&amp;amp;lt;/tpl&amp;amp;gt;&#39;
    /// );
    /// Ext.create(&#39;Ext.DataView&#39;, {
    /// store: Ext.data.StoreManager.lookup(&#39;imagesStore&#39;),
    /// tpl: imageTpl,
    /// itemSelector: &#39;div.thumb-wrap&#39;,
    /// emptyText: &#39;No images available&#39;,
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class View : AbstractView, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Un-highlight the currently highlighted item, if any. ...
        /// </summary>
        public object clearHighlight(){return null;}
        /// <summary>
        /// Highlight a given item in the DataView. ...
        /// </summary>
        public object highlightItem(HTMLElement item){return null;}
    }
    #endregion
    #region ViewConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ViewConfig : AbstractViewConfig
    {
    }
    #endregion
    #region ViewEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ViewEvents : AbstractViewEvents
    {
        /// <summary>
        /// Fires before the click event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainerclick="beforecontainerclick";
        /// <summary>
        /// Fires before the contextmenu event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainercontextmenu="beforecontainercontextmenu";
        /// <summary>
        /// Fires before the dblclick event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainerdblclick="beforecontainerdblclick";
        /// <summary>
        /// Fires before the keydown event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainerkeydown="beforecontainerkeydown";
        /// <summary>
        /// Fires before the mousedown event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermousedown="beforecontainermousedown";
        /// <summary>
        /// Fires before the mouseout event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermouseout="beforecontainermouseout";
        /// <summary>
        /// Fires before the mouseover event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermouseover="beforecontainermouseover";
        /// <summary>
        /// Fires before the mouseup event on the container is processed. ...
        /// </summary>
        public static JsString beforecontainermouseup="beforecontainermouseup";
        /// <summary>
        /// Fires before the click event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemclick="beforeitemclick";
        /// <summary>
        /// Fires before the contextmenu event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemcontextmenu="beforeitemcontextmenu";
        /// <summary>
        /// Fires before the dblclick event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemdblclick="beforeitemdblclick";
        /// <summary>
        /// Fires before the keydown event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemkeydown="beforeitemkeydown";
        /// <summary>
        /// Fires before the mousedown event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmousedown="beforeitemmousedown";
        /// <summary>
        /// Fires before the mouseenter event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmouseenter="beforeitemmouseenter";
        /// <summary>
        /// Fires before the mouseleave event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmouseleave="beforeitemmouseleave";
        /// <summary>
        /// Fires before the mouseup event on an item is processed. ...
        /// </summary>
        public static JsString beforeitemmouseup="beforeitemmouseup";
        /// <summary>
        /// Fires before a selection is made. ...
        /// </summary>
        public static JsString beforeselect="beforeselect";
        /// <summary>
        /// Fires when the container is clicked. ...
        /// </summary>
        public static JsString containerclick="containerclick";
        /// <summary>
        /// Fires when the container is right clicked. ...
        /// </summary>
        public static JsString containercontextmenu="containercontextmenu";
        /// <summary>
        /// Fires when the container is double clicked. ...
        /// </summary>
        public static JsString containerdblclick="containerdblclick";
        /// <summary>
        /// Fires when a key is pressed while the container is focused, and no item is currently selected. ...
        /// </summary>
        public static JsString containerkeydown="containerkeydown";
        /// <summary>
        /// Fires when you move the mouse out of the container. ...
        /// </summary>
        public static JsString containermouseout="containermouseout";
        /// <summary>
        /// Fires when you move the mouse over the container. ...
        /// </summary>
        public static JsString containermouseover="containermouseover";
        /// <summary>
        /// Fires when there is a mouse up on the container ...
        /// </summary>
        public static JsString containermouseup="containermouseup";
        /// <summary>
        /// Fires when an item is clicked. ...
        /// </summary>
        public static JsString itemclick="itemclick";
        /// <summary>
        /// Fires when an item is right clicked. ...
        /// </summary>
        public static JsString itemcontextmenu="itemcontextmenu";
        /// <summary>
        /// Fires when an item is double clicked. ...
        /// </summary>
        public static JsString itemdblclick="itemdblclick";
        /// <summary>
        /// Fires when a key is pressed while an item is currently selected. ...
        /// </summary>
        public static JsString itemkeydown="itemkeydown";
        /// <summary>
        /// Fires when there is a mouse down on an item ...
        /// </summary>
        public static JsString itemmousedown="itemmousedown";
        /// <summary>
        /// Fires when the mouse enters an item. ...
        /// </summary>
        public static JsString itemmouseenter="itemmouseenter";
        /// <summary>
        /// Fires when the mouse leaves an item. ...
        /// </summary>
        public static JsString itemmouseleave="itemmouseleave";
        /// <summary>
        /// Fires when there is a mouse up on an item ...
        /// </summary>
        public static JsString itemmouseup="itemmouseup";
        /// <summary>
        /// Fires when the selected nodes change. ...
        /// </summary>
        public static JsString selectionchange="selectionchange";
    }
    #endregion
}
#endregion
