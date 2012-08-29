//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region Request
    /// <inheritdocs />
    /// <summary>
    /// <p>Simple class that represents a Request that will be made by any <see cref="Ext.data.proxy.Server">Ext.data.proxy.Server</see> subclass.
    /// All this class does is standardize the representation of a Request as used by any ServerProxy subclass,
    /// it does not contain any actual logic or perform the request itself.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Request : Ext.Base
    {
        /// <summary>
        /// The name of the action this Request represents. Usually one of 'create', 'read', 'update' or 'destroy'.
        /// </summary>
        public JsString action;
        /// <summary>
        /// The HTTP method to use on this Request. Should be one of 'GET', 'POST', 'PUT' or 'DELETE'.
        /// Defaults to: <c>&quot;GET&quot;</c>
        /// </summary>
        public JsString method;
        /// <summary>
        /// HTTP request params. The Proxy and its Writer have access to and can modify this object.
        /// </summary>
        public JsObject @params;
        /// <summary>
        /// The url to access on this Request
        /// </summary>
        public JsString url;
        /// <summary>
        /// Creates the Request object.
        /// </summary>
        /// <param name="config"><p>Config object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Request(object config=null){}
        public Request(RequestConfig config){}
        public Request(params object[] args){}
    }
    #endregion
    #region RequestConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RequestConfig : Ext.BaseConfig
    {
        /// <summary>
        /// The name of the action this Request represents. Usually one of 'create', 'read', 'update' or 'destroy'.
        /// </summary>
        public JsString action;
        /// <summary>
        /// The HTTP method to use on this Request. Should be one of 'GET', 'POST', 'PUT' or 'DELETE'.
        /// Defaults to: <c>&quot;GET&quot;</c>
        /// </summary>
        public JsString method;
        /// <summary>
        /// HTTP request params. The Proxy and its Writer have access to and can modify this object.
        /// </summary>
        public JsObject @params;
        /// <summary>
        /// The url to access on this Request
        /// </summary>
        public JsString url;
        public RequestConfig(params object[] args){}
    }
    #endregion
    #region RequestEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RequestEvents : Ext.BaseEvents
    {
        public RequestEvents(params object[] args){}
    }
    #endregion
}
