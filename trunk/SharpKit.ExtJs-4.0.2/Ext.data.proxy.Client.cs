//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.proxy
namespace Ext.data.proxy
{
    #region Client
    /// <summary>
    /// Base class for any client-side storage. Used as a superclass for Memory and
    /// Web Storage proxies. Do not use directly, use one of the subclasses instead.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Client : Ext.data.proxy.Proxy, Ext.util.Observable
    {
        /// <summary>
        /// Abstract function that must be implemented by each ClientProxy subclass. ...
        /// </summary>
        public object clear(){return null;}
    }
    #endregion
    #region ClientConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ClientConfig : Ext.data.proxy.ProxyConfig
    {
    }
    #endregion
    #region ClientEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ClientEvents : Ext.data.proxy.ProxyEvents
    {
    }
    #endregion
}
#endregion
