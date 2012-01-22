//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.proxy
namespace Ext.data.proxy
{
    #region LocalStorage
    /// <summary>
    /// The LocalStorageProxy uses the new HTML5 localStorage API to save Model data locally on
    /// the client browser. HTML5 localStorage is a key-value store (e.g. cannot save complex objects like JSON), so
    /// LocalStorageProxy automatically serializes and deserializes data when saving and retrieving it. localStorage is extremely useful for saving user-specific information without needing to build server-side
    /// infrastructure to support it. Let&#39;s imagine we&#39;re writing a Twitter search application and want to save the user&#39;s
    /// searches locally so they can easily perform a saved search again later. We&#39;d start by creating a Search model: Ext.define(&#39;Search&#39;, {
    /// fields: [&#39;id&#39;, &#39;query&#39;],
    /// extend: &#39;Ext.data.Model&#39;,
    /// proxy: {
    /// type: &#39;localstorage&#39;,
    /// id  : &#39;twitter-Searches&#39;
    /// }
    /// });
    /// Our Search model contains just two fields - id and query - plus a Proxy definition. The only configuration we
    /// need to pass to the LocalStorage proxy is an id. This is important as it separates the Model data in this
    /// Proxy from all others. The localStorage API puts all data into a single shared namespace, so by setting an id we
    /// enable LocalStorageProxy to manage the saved Search data. Saving our data into localStorage is easy and would usually be done with a Store: //our Store automatically picks up the LocalStorageProxy defined on the Search model
    /// var store = new Ext.data.Store({
    /// model: &quot;Search&quot;
    /// });
    /// //loads any existing Search data from localStorage
    /// store.load();
    /// //now add some Searches
    /// store.add({query: &#39;Sencha Touch&#39;});
    /// store.add({query: &#39;Ext JS&#39;});
    /// //finally, save our Search data to localStorage
    /// store.sync();
    /// The LocalStorageProxy automatically gives our new Searches an id when we call store.sync(). It encodes the Model
    /// data and places it into localStorage. We can also save directly to localStorage, bypassing the Store altogether: var search = Ext.ModelManager.create({query: &#39;Sencha Animator&#39;}, &#39;Search&#39;);
    /// //uses the configured LocalStorageProxy to save the new Search to localStorage
    /// search.save();
    /// Limitations If this proxy is used in a browser where local storage is not supported, the constructor will throw an error.
    /// A local storage proxy requires a unique ID which is used as a key in which all record data are stored in the
    /// local storage object. It&#39;s important to supply this unique ID as it cannot be reliably determined otherwise. If no id is provided
    /// but the attached store has a storeId, the storeId will be used. If neither option is presented the proxy will
    /// throw an error.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class LocalStorage : WebStorage, Ext.util.Observable
    {
        public LocalStorage(LocalStorageConfig config) : base(null){}
        public LocalStorage() : base(null){}
    }
    #endregion
    #region LocalStorageConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class LocalStorageConfig : WebStorageConfig
    {
    }
    #endregion
    #region LocalStorageEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class LocalStorageEvents : WebStorageEvents
    {
    }
    #endregion
}
#endregion
