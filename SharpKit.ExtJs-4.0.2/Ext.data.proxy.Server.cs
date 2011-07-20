//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.proxy
namespace Ext.data.proxy
{
    #region Server
    /// <summary>
    /// ServerProxy is a superclass of JsonPProxy and AjaxProxy,
    /// and would not usually be used directly. ServerProxy should ideally be named HttpProxy as it is a superclass for all HTTP proxies - for Ext JS 4.x it has been
    /// called ServerProxy to enable any 3.x applications that reference the HttpProxy to continue to work (HttpProxy is now an
    /// alias of AjaxProxy).
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Server : Ext.data.proxy.Proxy, Ext.util.Observable
    {
        /// <summary>
        /// Optional callback function which can be used to clean up after a request has been completed. ...
        /// </summary>
        public object afterRequest(Request request, bool success){return null;}
        /// <summary>
        /// Creates and returns an Ext.data.Request object based on the options passed by the Store
        /// that this Proxy is attached to. ...
        /// </summary>
        public Request buildRequest(Operation operation){return null;}
        /// <summary>
        /// Generates a url based on a given Ext.data.Request object. ...
        /// </summary>
        public JsString buildUrl(Request request){return null;}
        /// <summary>
        /// In ServerProxy subclasses, the create, read, update and destroy methods all pass
        /// through to doRequest. ...
        /// </summary>
        public object doRequest(Operation operation, JsAction callback, object scope){return null;}
        /// <summary>
        /// Encodes the array of Ext.util.Filter objects into a string to be sent in the request url. ...
        /// </summary>
        public JsString encodeFilters(JsArray sorters){return null;}
        /// <summary>
        /// Encodes the array of Ext.util.Sorter objects into a string to be sent in the request url. ...
        /// </summary>
        public JsString encodeSorters(JsArray sorters){return null;}
        /// <summary>
        /// ...
        /// </summary>
        public object processResponse(object success, object operation, object request, object response, object callback, object scope){return null;}
    }
    #endregion
    #region ServerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ServerConfig : Ext.data.proxy.ProxyConfig
    {
        /// <summary>
        /// Specific urls to call on CRUD action methods "create", "read", "update" and "destroy". ...
        /// </summary>
        public object api{get;set;}
        public JsString cacheString{get;set;}
        /// <summary>
        /// The name of the direction parameter to send in a request. ...
        /// </summary>
        public JsString directionParam{get;set;}
        /// <summary>
        /// Extra parameters that will be included on every request. ...
        /// </summary>
        public object extraParams{get;set;}
        /// <summary>
        /// The name of the 'filter' parameter to send in a request. ...
        /// </summary>
        public JsString filterParam{get;set;}
        /// <summary>
        /// The name of the 'group' parameter to send in a request. ...
        /// </summary>
        public JsString groupParam{get;set;}
        /// <summary>
        /// The name of the 'limit' parameter to send in a request. ...
        /// </summary>
        public JsString limitParam{get;set;}
        /// <summary>
        /// (optional) Defaults to true. ...
        /// </summary>
        public bool noCache{get;set;}
        /// <summary>
        /// The name of the 'page' parameter to send in a request. ...
        /// </summary>
        public JsString pageParam{get;set;}
        /// <summary>
        /// The Ext.data.reader.Reader to use to decode the server's response. ...
        /// </summary>
        public object reader{get;set;}
        /// <summary>
        /// Enabling simpleSortMode in conjunction with remoteSort will only send one sort property and a direction when a remote...
        /// </summary>
        public bool simpleSortMode{get;set;}
        /// <summary>
        /// The name of the 'sort' parameter to send in a request. ...
        /// </summary>
        public JsString sortParam{get;set;}
        /// <summary>
        /// The name of the 'start' parameter to send in a request. ...
        /// </summary>
        public JsString startParam{get;set;}
        /// <summary>
        /// (optional) The number of milliseconds to wait for a response. ...
        /// </summary>
        public JsNumber timeout{get;set;}
        public JsString url{get;set;}
        /// <summary>
        /// The Ext.data.writer.Writer to use to encode any request sent to the server. ...
        /// </summary>
        public object writer{get;set;}
    }
    #endregion
    #region ServerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ServerEvents : Ext.data.proxy.ProxyEvents
    {
        /// <summary>
        /// Fires when the server returns an exception ...
        /// </summary>
        public static JsString exception="exception";
    }
    #endregion
}
#endregion
