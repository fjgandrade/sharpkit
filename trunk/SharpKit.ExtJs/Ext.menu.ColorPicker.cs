//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.menu
{
    #region ColorPicker
    /// <inheritdocs />
    /// <summary>
    /// <p>A menu containing a <see cref="Ext.picker.Color">Ext.picker.Color</see> Component.</p>
    /// <p>Notes:</p>
    /// <ul>
    /// <li>Although not listed here, the <strong>constructor</strong> for this class accepts all of the
    /// configuration options of <see cref="Ext.picker.Color">Ext.picker.Color</see>.</li>
    /// <li>If subclassing ColorMenu, any configuration options for the ColorPicker must be
    /// applied to the <strong>initialConfig</strong> property of the ColorMenu. Applying
    /// <see cref="Ext.picker.Color">ColorPicker</see> configuration settings to <c>this</c> will <strong>not</strong>
    /// affect the ColorPicker's configuration.</li>
    /// </ul>
    /// <p>Example:</p>
    /// <pre><code>var colorPicker = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.menu.ColorPicker">Ext.menu.ColorPicker</see>', {
    /// value: '000000'
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.menu.Menu">Ext.menu.Menu</see>', {
    /// width: 100,
    /// height: 90,
    /// floating: false,  // usually you want this set to True (default)
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),  // usually rendered by it's containing component
    /// items: [{
    /// text: 'choose a color',
    /// menu: colorPicker
    /// },{
    /// iconCls: 'add16',
    /// text: 'icon item'
    /// },{
    /// text: 'regular item'
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ColorPicker : Ext.menu.Menu
    {
        /// <summary>
        /// False to continue showing the menu after a date is selected.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool hideOnClick;
        /// <summary>
        /// An id to assign to the underlying color picker.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString pickerId;
        /// <summary>
        /// The Ext.picker.Color instance for this ColorMenu
        /// </summary>
        public Ext.picker.Color picker{get;set;}
        /// <summary>
        /// Hides picker on select if hideOnClick is true
        /// </summary>
        private void hidePickerOnSelect(){}
        public ColorPicker(ColorPickerConfig config){}
        public ColorPicker(){}
        public ColorPicker(params object[] args){}
    }
    #endregion
    #region ColorPickerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ColorPickerConfig : Ext.menu.MenuConfig
    {
        /// <summary>
        /// False to continue showing the menu after a date is selected.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool hideOnClick;
        /// <summary>
        /// An id to assign to the underlying color picker.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString pickerId;
        public ColorPickerConfig(params object[] args){}
    }
    #endregion
    #region ColorPickerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ColorPickerEvents : Ext.menu.MenuEvents
    {
        /// <summary>
        /// Parameters<li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>Overrides: <see cref="Ext.menu.MenuEvents.click">Ext.menu.Menu.click</see>
        /// </summary>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        private void click(object eOpts){}
        /// <summary>
        /// Fires when a color is selected
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="color"><p>The 6-digit color hex code (without the # symbol)</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void select(Ext.picker.Color @this, JsString color, object eOpts){}
        public ColorPickerEvents(params object[] args){}
    }
    #endregion
}
