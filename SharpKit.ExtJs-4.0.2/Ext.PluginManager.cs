//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region PluginManager
    /// <summary>
    /// Provides a registry of available Plugin classes indexed by a mnemonic code known as the Plugin&#39;s ptype.
    /// The xtype provides a way to avoid instantiating child Components
    /// when creating a full, nested config object for a complete Ext page. A child Component may be specified simply as a config object
    /// as long as the correct xtype is specified so that if and when the Component
    /// needs rendering, the correct type can be looked up for lazy instantiation. For a list of all available xtypes, see Ext.Component.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class PluginManager : AbstractManager
    {
        /// <summary>
        /// Creates a new Plugin from the specified config object using the
        /// config object's ptype to determine the class to insta...
        /// </summary>
        public static Ext.Component create(object config, Constructor defaultType){return null;}
        /// <summary>
        /// Returns all plugins registered with the given type. ...
        /// </summary>
        public static JsArray findByType(JsString type, bool defaultsOnly){return null;}
        public PluginManager(PluginManagerConfig config){}
        public PluginManager(){}
    }
    #endregion
    #region PluginManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class PluginManagerConfig : AbstractManagerConfig
    {
    }
    #endregion
    #region PluginManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class PluginManagerEvents : AbstractManagerEvents
    {
    }
    #endregion
}
#endregion