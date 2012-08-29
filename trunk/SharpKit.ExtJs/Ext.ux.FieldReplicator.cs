//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.ux
namespace Ext.ux
{
    #region FieldReplicator
    /// <inheritdocs />
    /// <summary>
    /// <p>A plugin for Field Components which creates clones of the Field for as
    /// long as the user keeps filling them. Leaving the final one blank ends the repeating series.</p>
    /// <p>Usage:</p>
    /// <pre><code>    {
    /// xtype: 'combo',
    /// plugins: [ <see cref="Ext.ux.FieldReplicator">Ext.ux.FieldReplicator</see> ],
    /// triggerAction: 'all',
    /// fieldLabel: 'Select recipient',
    /// store: recipientStore
    /// }
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class FieldReplicator : Ext.Base
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        private static JsString @className{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject configMap{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        private static JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject initConfigMap{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        private static bool isInstance{get;set;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. Unlike statics,
        /// this.self is scope-dependent and it's meant to be used for dynamic inheritance. See statics
        /// for a detailed comparison
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// alert(this.self.speciesName); // dependent on 'this'
        /// },
        /// clone: function() {
        /// return new this.self();
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'         // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// }
        /// });
        /// var cat = new My.Cat();                     // alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard();     // alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));             // alerts 'My.SnowLeopard'
        /// </code>
        /// </summary>
        protected static Class self{get;set;}
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// constructor: function() {
        /// alert("I'm a cat!");
        /// }
        /// });
        /// My.Cat.override({
        /// constructor: function() {
        /// alert("I'm going to be a cat!");
        /// this.callOverridden();
        /// alert("Meeeeoooowwww");
        /// }
        /// });
        /// var kitty = new My.Cat(); // alerts "I'm going to be a cat!"
        /// // alerts "I'm a cat!"
        /// // alerts "Meeeeoooowwww"
        /// </code>
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>as of 4.1. Use <see cref="Ext.Base.callParent">callParent</see> instead.</p>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callOverridden(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the overridden method</p>
        /// </div>
        /// </returns>
        protected static object callOverridden(object args=null){return null;}
        /// <summary>
        /// Call the "parent" method of the current method. That is the method previously
        /// overridden by derivation or by an override (see Ext.define).
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Base', {
        /// constructor: function (x) {
        /// this.x = x;
        /// },
        /// statics: {
        /// method: function (x) {
        /// return x;
        /// }
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived', {
        /// extend: 'My.Base',
        /// constructor: function () {
        /// this.callParent([21]);
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // alerts 21
        /// </code>
        /// This can be used with an override as follows:
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.DerivedOverride', {
        /// override: 'My.Derived',
        /// constructor: function (x) {
        /// this.callParent([x*2]); // calls original My.Derived constructor
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // now alerts 42
        /// </code>
        /// This also works with static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2', {
        /// extend: 'My.Base',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Base.method
        /// }
        /// }
        /// });
        /// alert(My.Base.method(10);     // alerts 10
        /// alert(My.Derived2.method(10); // alerts 20
        /// </code>
        /// Lastly, it also works with overridden static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2Override', {
        /// override: 'My.Derived2',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Derived2.method
        /// }
        /// }
        /// });
        /// alert(My.Derived2.method(10); // now alerts 40
        /// </code>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callParent(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the parent method</p>
        /// </div>
        /// </returns>
        protected static object callParent(object args=null){return null;}
        /// <summary>
        /// </summary>
        private static void configClass(){}
        /// <summary>
        /// Overrides: <see cref="Ext.AbstractComponent.destroy">Ext.AbstractComponent.destroy</see>, <see cref="Ext.AbstractPlugin.destroy">Ext.AbstractPlugin.destroy</see>, <see cref="Ext.layout.Layout.destroy">Ext.layout.Layout.destroy</see>
        /// </summary>
        private static void destroy(){}
        /// <summary>
        /// Parameters<li><span>name</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="name">
        /// </param>
        private static void getConfig(object name){}
        /// <summary>
        /// Returns the initial configuration passed to constructor when instantiating
        /// this class.
        /// </summary>
        /// <param name="name"><p>Name of the config option to return.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see>/Mixed</span><div><p>The full config object or a single config value
        /// when <c>name</c> parameter specified.</p>
        /// </div>
        /// </returns>
        public static object getInitialConfig(object name=null){return null;}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        private static void hasConfig(object config){}
        /// <summary>
        /// Initialize configuration for this class. a typical example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.awesome.Class', {
        /// // The default config
        /// config: {
        /// name: 'Awesome',
        /// isAwesome: true
        /// },
        /// constructor: function(config) {
        /// this.initConfig(config);
        /// }
        /// });
        /// var awesome = new My.awesome.Class({
        /// name: 'Super Awesome'
        /// });
        /// alert(awesome.getName()); // 'Super Awesome'
        /// </code>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Base">Ext.Base</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        protected static Ext.Base initConfig(object config){return null;}
        /// <summary>
        /// Parameters<li><span>names</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>callback</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="names">
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="scope">
        /// </param>
        private static void onConfigUpdate(object names, object callback, object scope){}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>applyIfNotSet</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <param name="applyIfNotSet">
        /// </param>
        private static void setConfig(object config, object applyIfNotSet){}
        /// <summary>
        /// Get the reference to the class from which this object was instantiated. Note that unlike self,
        /// this.statics() is scope-independent and it always returns the class from which it was called, regardless of what
        /// this points to during run-time
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// totalCreated: 0,
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// var statics = this.statics();
        /// alert(statics.speciesName);     // always equals to 'Cat' no matter what 'this' refers to
        /// // equivalent to: My.Cat.speciesName
        /// alert(this.self.speciesName);   // dependent on 'this'
        /// statics.totalCreated++;
        /// },
        /// clone: function() {
        /// var cloned = new this.self;                      // dependent on 'this'
        /// cloned.groupName = this.statics().speciesName;   // equivalent to: My.Cat.speciesName
        /// return cloned;
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'     // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// },
        /// constructor: function() {
        /// this.callParent();
        /// }
        /// });
        /// var cat = new My.Cat();                 // alerts 'Cat', then alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard(); // alerts 'Cat', then alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));         // alerts 'My.SnowLeopard'
        /// alert(clone.groupName);                 // alerts 'Cat'
        /// alert(My.Cat.totalCreated);             // alerts 3
        /// </code>
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Class">Ext.Class</see></span><div>
        /// </div>
        /// </returns>
        protected static Class statics(){return null;}
        public FieldReplicator(FieldReplicatorConfig config){}
        public FieldReplicator(){}
        public FieldReplicator(params object[] args){}
    }
    #endregion
    #region FieldReplicatorConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FieldReplicatorConfig : Ext.BaseConfig
    {
        public FieldReplicatorConfig(params object[] args){}
    }
    #endregion
    #region FieldReplicatorEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FieldReplicatorEvents : Ext.BaseEvents
    {
        public FieldReplicatorEvents(params object[] args){}
    }
    #endregion
}
#endregion
