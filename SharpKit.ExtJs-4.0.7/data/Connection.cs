//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region Connection
    /// <summary>
    /// The Connection class encapsulates a connection to the page&#39;s originating domain, allowing requests to be made either
    /// to a configured URL, or to a URL specified at request time. Requests made by this class are asynchronous, and will return immediately. No data from the server will be available
    /// to the statement immediately following the request call. To process returned data, use a success callback
    /// in the request options object, or an event listener. File Uploads File uploads are not performed using normal &quot;Ajax&quot; techniques, that is they are not performed using XMLHttpRequests.
    /// Instead the form is submitted in the standard manner with the DOM &amp;lt;form&amp;gt; element temporarily modified to have its
    /// target set to refer to a dynamically generated, hidden &amp;lt;iframe&amp;gt; which is inserted into the document but removed
    /// after the return data has been gathered. The server response is parsed by the browser to create the document for the IFRAME. If the server is using JSON to
    /// send the return object, then the Content-Type header must be set to &quot;text/html&quot; in order to tell the browser to
    /// insert the text unchanged into the document body. Characters which are significant to an HTML parser must be sent as HTML entities, so encode &quot;&amp;lt;&quot; as &quot;&amp;amp;lt;&quot;, &quot;&amp;amp;&quot; as
    /// &quot;&amp;amp;amp;&quot; etc. The response text is retrieved from the document, and a fake XMLHttpRequest object is created containing a
    /// responseText property in order to conform to the requirements of event handlers and callbacks. Be aware that file upload packets are sent with the content type multipart/form and some server technologies
    /// (notably JEE) may require some custom processing in order to retrieve parameter names and parameter values from the
    /// packet content. Also note that it&#39;s not possible to check the response code of the hidden iframe, so the success handler will ALWAYS fire.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Connection : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Aborts any outstanding request. ...
        /// </summary>
        public object abort(object request){return null;}
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents( object o, params object[] more ){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent( JsString eventName, params object[] args ){return false;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Determine whether this object has a request outstanding. ...
        /// </summary>
        public bool isLoading(object request){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Check if the response status was successful ...
        /// </summary>
        public object parseStatus(JsNumber status){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents( object origin, object events, object prefix ){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Sends an HTTP request to a remote server. ...
        /// </summary>
        public object request(object options){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Set various options such as the url, params for the request ...
        /// </summary>
        public object setOptions(object options, object scope){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Upload a form using a hidden iframe. ...
        /// </summary>
        public object upload(object form, JsString url, JsString @params, object options){return null;}
        public Connection(ConnectionConfig config){}
        public Connection(){}
    }
    #endregion
    #region ConnectionConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ConnectionConfig : Ext.BaseConfig
    {
        /// <summary>
        /// (Optional) True to add a unique cache-buster param to GET requests. ...
        /// </summary>
        public bool disableCaching{get;set;}
        /// <summary>
        /// (Optional) Change the parameter which is sent went disabling caching
        /// through a cache buster. ...
        /// </summary>
        public JsString disableCachingParam{get;set;}
        public object extraParams{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        /// <summary>
        /// (Optional) The timeout in milliseconds to be used for requests. ...
        /// </summary>
        public JsNumber timeout{get;set;}
    }
    #endregion
    #region ConnectionEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ConnectionEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires before a network request is made to retrieve a data object. ...
        /// </summary>
        public static JsString beforerequest="beforerequest";
        /// <summary>
        /// Fires if the request was successfully completed. ...
        /// </summary>
        public static JsString requestcomplete="requestcomplete";
        /// <summary>
        /// Fires if an error HTTP status was returned from the server. ...
        /// </summary>
        public static JsString requestexception="requestexception";
    }
    #endregion
}
#endregion
