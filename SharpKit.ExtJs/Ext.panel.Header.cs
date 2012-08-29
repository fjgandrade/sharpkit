//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.panel
{
    #region Header
    /// <inheritdocs />
    /// <summary>
    /// <p>Simple header class which is used for on <see cref="Ext.panel.Panel">Ext.panel.Panel</see> and <see cref="Ext.window.Window">Ext.window.Window</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Header : Ext.container.Container
    {
        /// <summary>
        /// Path to image for an icon in the header. Used for displaying an icon to the left of a title.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// CSS class for an icon in the header. Used for displaying an icon to the left of a title.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// The title text to display.
        /// </summary>
        public JsString title;
        /// <summary>
        /// May be "left", "right" or "center".
        /// The alignment of the title text within the available space between the icon and the tools.
        /// Defaults to: <c>&quot;left&quot;</c>
        /// </summary>
        public JsString titleAlign;
        /// <summary>
        /// true in this class to identify an objact as an instantiated Header, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isHeader{get;set;}
        /// <summary>
        /// Add a tool to the header
        /// </summary>
        /// <param name="tool">
        /// </param>
        public void addTool(object tool){}
        /// <summary>
        /// Used when shrink wrapping a Panel to either content width or header width.
        /// This returns the minimum width required to display the header, icon and tools.
        /// This is only intended for use with horizontal headers.
        /// </summary>
        private void getMinWidth(){}
        /// <summary>
        /// Sets the image path that provides the icon image for this header.  This method will replace any existing
        /// icon if one has already been set.
        /// </summary>
        /// <param name="icon"><p>The new icon path</p>
        /// </param>
        public void setIcon(JsString icon){}
        /// <summary>
        /// Sets the CSS class that provides the icon image for this header.  This method will replace any existing
        /// icon class if one has already been set.
        /// </summary>
        /// <param name="cls"><p>The new CSS class name</p>
        /// </param>
        public void setIconCls(JsString cls){}
        /// <summary>
        /// Sets the title of the header.
        /// </summary>
        /// <param name="title"><p>The title to be set</p>
        /// </param>
        public void setTitle(JsString title){}
        public Header(HeaderConfig config){}
        public Header(){}
        public Header(params object[] args){}
    }
    #endregion
    #region HeaderConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HeaderConfig : Ext.container.ContainerConfig
    {
        /// <summary>
        /// Path to image for an icon in the header. Used for displaying an icon to the left of a title.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// CSS class for an icon in the header. Used for displaying an icon to the left of a title.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// The title text to display.
        /// </summary>
        public JsString title;
        /// <summary>
        /// May be "left", "right" or "center".
        /// The alignment of the title text within the available space between the icon and the tools.
        /// Defaults to: <c>&quot;left&quot;</c>
        /// </summary>
        public JsString titleAlign;
        public HeaderConfig(params object[] args){}
    }
    #endregion
    #region HeaderEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HeaderEvents : Ext.container.ContainerEvents
    {
        /// <summary>
        /// Fires when the header is clicked. This event will not be fired
        /// if the click was on a Ext.panel.Tool
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void click(Header @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when the header is double clicked. This event will not
        /// be fired if the click was on a Ext.panel.Tool
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void dblclick(Header @this, EventObject e, object eOpts){}
        public HeaderEvents(params object[] args){}
    }
    #endregion
}
