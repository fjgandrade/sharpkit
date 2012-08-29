//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region AbstractManager
    /// <inheritdocs />
    /// <summary>
    /// <p>Base Manager class</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractManager : Ext.Base
    {
        /// <summary>
        /// Contains all of the items currently managed
        /// </summary>
        public Ext.util.HashMap all{get;set;}
        /// <summary>
        /// Creates and returns an instance of whatever this manager manages, based on the supplied type and
        /// config object.
        /// </summary>
        /// <param name="config"><p>The config object</p>
        /// </param>
        /// <param name="defaultType"><p>If no type is discovered in the config object, we fall back to this type</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The instance of whatever this manager is managing</p>
        /// </div>
        /// </returns>
        public object create(object config, JsString defaultType){return null;}
        /// <summary>
        /// Executes the specified function once for each item in the collection.
        /// </summary>
        /// <param name="fn"><p>The function to execute.</p>
        /// <h3>Parameters</h3><ul><li><span>key</span> : <see cref="String">String</see><div><p>The key of the item</p>
        /// </div></li><li><span>value</span> : <see cref="Number">Number</see><div><p>The value of the item</p>
        /// </div></li><li><span>length</span> : <see cref="Number">Number</see><div><p>The total number of items in the collection</p>
        /// </div></li></ul><h3>Returns</h3><ul><li><span><see cref="bool">Boolean</see></span><div><p>False to cease iteration.</p>
        /// </div></li></ul></param>
        /// <param name="scope"><p>The scope to execute in. Defaults to <c>this</c>.</p>
        /// </param>
        public void each(System.Delegate fn, object scope){}
        /// <summary>
        /// Returns an item by id.
        /// For additional details see Ext.util.HashMap.get.
        /// </summary>
        /// <param name="id"><p>The id of the item</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The item, undefined if not found.</p>
        /// </div>
        /// </returns>
        public object get(JsString id){return null;}
        /// <summary>
        /// Gets the number of items in the collection.
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The number of items in the collection.</p>
        /// </div>
        /// </returns>
        public JsNumber getCount(){return null;}
        /// <summary>
        /// Checks if an item type is registered.
        /// </summary>
        /// <param name="type"><p>The mnemonic string by which the class may be looked up</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>Whether the type is registered.</p>
        /// </div>
        /// </returns>
        public bool isRegistered(JsString type){return false;}
        /// <summary>
        /// Registers a function that will be called when an item with the specified id is added to the manager.
        /// This will happen on instantiation.
        /// </summary>
        /// <param name="id"><p>The item id</p>
        /// </param>
        /// <param name="fn"><p>The callback function. Called with a single parameter, the item.</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the callback is executed.
        /// Defaults to the item.</p>
        /// </param>
        public void onAvailable(JsString id, System.Delegate fn, object scope){}
        /// <summary>
        /// Registers an item to be managed
        /// </summary>
        /// <param name="item"><p>The item to register</p>
        /// </param>
        public void register(object item){}
        /// <summary>
        /// Registers a new item constructor, keyed by a type key.
        /// </summary>
        /// <param name="type"><p>The mnemonic string by which the class may be looked up.</p>
        /// </param>
        /// <param name="cls"><p>The new instance class.</p>
        /// </param>
        public void registerType(JsString type, System.Delegate cls){}
        /// <summary>
        /// Unregisters an item by removing it from this manager
        /// </summary>
        /// <param name="item"><p>The item to unregister</p>
        /// </param>
        public void unregister(object item){}
        public AbstractManager(AbstractManagerConfig config){}
        public AbstractManager(){}
        public AbstractManager(params object[] args){}
    }
    #endregion
    #region AbstractManagerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractManagerConfig : Ext.BaseConfig
    {
        public AbstractManagerConfig(params object[] args){}
    }
    #endregion
    #region AbstractManagerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractManagerEvents : Ext.BaseEvents
    {
        public AbstractManagerEvents(params object[] args){}
    }
    #endregion
}
#endregion
