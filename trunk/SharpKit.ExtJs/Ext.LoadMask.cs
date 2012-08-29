//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region LoadMask
    /// <inheritdocs />
    /// <summary>
    /// <p>A modal, floating Component which may be shown above a specified <see cref="Ext.Component">Component</see> while loading data.
    /// When shown, the configured owning Component will be covered with a modality mask, and the LoadMask's <see cref="Ext.LoadMaskConfig.msg">msg</see> will be
    /// displayed centered, accompanied by a spinner image.</p>
    /// <p>If the <see cref="Ext.LoadMaskConfig.store">store</see> config option is specified, the masking will be automatically shown and then hidden synchronized with
    /// the Store's loading process.</p>
    /// <p>Because this is a floating Component, its z-index will be managed by the global <see cref="Ext.WindowManager">ZIndexManager</see>
    /// object, and upon show, it will place itsef at the top of the hierarchy.</p>
    /// <p>Example usage:</p>
    /// <pre><code>// Basic mask:
    /// var myMask = new <see cref="Ext.LoadMask">Ext.LoadMask</see>(myPanel, {msg:"Please wait..."});
    /// myMask.show();
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class LoadMask : Ext.Component, Ext.util.Floating, Ext.util.Bindable
    {
        /// <summary>
        /// The CSS class to apply to the mask element
        /// Defaults to: <c>&quot;x-mask&quot;</c>
        /// </summary>
        public JsString maskCls;
        /// <summary>
        /// The text to display in a centered loading message box.
        /// Defaults to: <c>&quot;Loading...&quot;</c>
        /// </summary>
        public JsString msg;
        /// <summary>
        /// The CSS class to apply to the loading message element.
        /// Defaults to: <c>&quot;x-mask-loading&quot;</c>
        /// </summary>
        public JsString msgCls;
        /// <summary>
        /// Optional Store to which the mask is bound. The mask is displayed when a load request is issued, and
        /// hidden on either load success, or load fail.
        /// </summary>
        public Ext.data.Store store;
        /// <summary>
        /// Whether or not to use a loading message class or simply mask the bound element.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool useMsg;
        /// <summary>
        /// True to mask the targetEl of the bound Component. By default,
        /// the el will be masked.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool useTargetEl;
        /// <summary>
        /// Creates new LoadMask.
        /// </summary>
        /// <param name="comp"><p>The Component you wish to mask. The the mask will be automatically sized
        /// upon Component resize, and the message box will be kept centered.</p><p>
        /// </param>
        /// <param name="config"><p>The config object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public LoadMask(Ext.Component comp, object config=null){}
        /// <summary>
        /// Changes the data store bound to this LoadMask.
        /// </summary>
        /// <param name="store"><p>The store to bind to this LoadMask</p>
        /// </param>
        public void bindStore(Ext.data.Store store){}
        /// <summary>
        /// Binds listeners for this component to the store. By default it will add
        /// anything bound by the getStoreListeners method, however it can be overridden
        /// in a subclass to provide any more complicated handling.
        /// </summary>
        /// <param name="store"><p>The store to bind to</p>
        /// </param>
        public virtual void bindStoreListeners(Ext.data.AbstractStore store){}
        /// <summary>
        /// Gets the current store instance.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.data.AbstractStore">Ext.data.AbstractStore</see></span><div><p>The store, null if one does not exist.</p>
        /// </div>
        /// </returns>
        public virtual Ext.data.Store getStore(){return null;}
        /// <summary>
        /// Gets the listeners to bind to a new store.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The listeners to be bound to the store in object literal form. The scope
        /// may be omitted, it is assumed to be the current instance.</p>
        /// </div>
        /// </returns>
        public virtual object getStoreListeners(){return null;}
        /// <summary>
        /// Template method, it is called when a new store is bound
        /// to the current instance.
        /// </summary>
        /// <param name="store"><p>The store being bound</p>
        /// </param>
        /// <param name="initial"><p>True if this store is being bound as initialization of the instance.</p>
        /// </param>
        public virtual void onBindStore(Ext.data.AbstractStore store, bool initial){}
        /// <summary>
        /// Template method, it is called when an existing store is unbound
        /// from the current instance.
        /// </summary>
        /// <param name="store"><p>The store being unbound</p>
        /// </param>
        /// <param name="initial"><p>True if this store is being bound as initialization of the instance.</p>
        /// </param>
        public virtual void onUnbindStore(Ext.data.AbstractStore store, bool initial){}
        /// <summary>
        /// Called when this LoadMask's Component is resized. The toFront method rebases and resizes the modal mask.
        /// </summary>
        private void sizeMask(){}
        /// <summary>
        /// Unbinds listeners from this component to the store. By default it will remove
        /// anything bound by the bindStoreListeners method, however it can be overridden
        /// in a subclass to provide any more complicated handling.
        /// </summary>
        /// <param name="store"><p>The store to unbind from</p>
        /// </param>
        public virtual void unbindStoreListeners(Ext.data.AbstractStore store){}
        /// <summary>
        /// Binds a store to this instance.
        /// </summary>
        public virtual void bindStore(object store=null, object initial=null){}
        public LoadMask(LoadMaskConfig config){}
        public LoadMask(){}
        public LoadMask(params object[] args){}
    }
    #endregion
    #region LoadMaskConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LoadMaskConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// The CSS class to apply to the mask element
        /// Defaults to: <c>&quot;x-mask&quot;</c>
        /// </summary>
        public JsString maskCls;
        /// <summary>
        /// The text to display in a centered loading message box.
        /// Defaults to: <c>&quot;Loading...&quot;</c>
        /// </summary>
        public JsString msg;
        /// <summary>
        /// The CSS class to apply to the loading message element.
        /// Defaults to: <c>&quot;x-mask-loading&quot;</c>
        /// </summary>
        public JsString msgCls;
        /// <summary>
        /// Optional Store to which the mask is bound. The mask is displayed when a load request is issued, and
        /// hidden on either load success, or load fail.
        /// </summary>
        public Ext.data.Store store;
        /// <summary>
        /// Whether or not to use a loading message class or simply mask the bound element.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool useMsg;
        /// <summary>
        /// True to mask the targetEl of the bound Component. By default,
        /// the el will be masked.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool useTargetEl;
        public LoadMaskConfig(params object[] args){}
    }
    #endregion
    #region LoadMaskEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LoadMaskEvents : Ext.ComponentEvents
    {
        public LoadMaskEvents(params object[] args){}
    }
    #endregion
}
