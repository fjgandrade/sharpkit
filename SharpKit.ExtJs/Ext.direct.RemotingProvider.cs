//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.direct
{
    #region RemotingProvider
    /// <inheritdocs />
    /// <summary>
    /// <p>The <see cref="Ext.direct.RemotingProvider">RemotingProvider</see> exposes access to
    /// server side methods on the client (a remote procedure call (RPC) type of
    /// connection where the client can initiate a procedure on the server).</p>
    /// <p>This allows for code to be organized in a fashion that is maintainable,
    /// while providing a clear path between client and server, something that is
    /// not always apparent when using URLs.</p>
    /// <p>To accomplish this the server-side needs to describe what classes and methods
    /// are available on the client-side. This configuration will typically be
    /// outputted by the server-side <see cref="Ext.direct.Manager">Ext.Direct</see> stack when the API description is built.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class RemotingProvider : JsonProvider
    {
        /// <summary>
        /// Object literal defining the server side actions and methods. For example, if
        /// the Provider is configured with:
        /// <code>"actions":{ // each property within the 'actions' object represents a server side Class
        /// "TestAction":[ // array of methods within each server side Class to be
        /// {              // stubbed out on client
        /// "name":"doEcho",
        /// "len":1
        /// },{
        /// "name":"multiply",// name of method
        /// "len":2           // The number of parameters that will be used to create an
        /// // array of data to send to the server side function.
        /// // Ensure the server sends back a Number, not a String.
        /// },{
        /// "name":"doForm",
        /// "formHandler":true, // direct the client to use specialized form handling method
        /// "len":1
        /// }]
        /// }
        /// </code>
        /// Note that a Store is not required, a server method can be called at any time.
        /// In the following example a <b>client side</b> handler is used to call the
        /// server side method "multiply" in the server-side "TestAction" Class:
        /// <code>TestAction.multiply(
        /// 2, 4, // pass two arguments to server, so specify len=2
        /// // callback function after the server is called
        /// // result: the result returned by the server
        /// //      e: <see cref="Ext.direct.RemotingEvent">Ext.direct.RemotingEvent</see> object
        /// function(result, e){
        /// var t = e.getTransaction();
        /// var action = t.action; // server side Class called
        /// var method = t.method; // server side method called
        /// if(e.status){
        /// var answer = <see cref="Ext.ExtContext.encode">Ext.encode</see>(result); // 8
        /// }else{
        /// var msg = e.message; // failure message
        /// }
        /// }
        /// );
        /// </code>
        /// In the example above, the server side "multiply" function will be passed two
        /// arguments (2 and 4).  The "multiply" method should return the value 8 which will be
        /// available as the <tt>result</tt> in the example above.
        /// </summary>
        public JsObject actions;
        /// <summary>
        /// true or false to enable or disable combining of method
        /// calls. If a number is specified this is the amount of time in milliseconds
        /// to wait before sending a batched request.
        /// Calls which are received within the specified timeframe will be
        /// <p>concatenated together and sent in a single request, optimizing the
        /// application by reducing the amount of round trips that have to be made
        /// to the server.</p>
        /// Defaults to: <c>10</c>
        /// </summary>
        public object enableBuffer;
        /// <summary>
        /// Specify which param will hold the arguments for the method.
        /// Defaults to 'data'.
        /// </summary>
        public JsString enableUrlEncode;
        /// <summary>
        /// Number of times to re-attempt delivery on failure of a call.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber maxRetries;
        /// <summary>
        /// Namespace for the Remoting Provider (defaults to the browser global scope of window).
        /// Explicitly specify the namespace Object, or specify a String to have a
        /// namespace created implicitly.
        /// </summary>
        public object @namespace;
        /// <summary>
        /// The timeout to use for each request.
        /// </summary>
        public JsNumber timeout;
        /// <summary>
        /// Required. The url to connect to the Ext.direct.Manager server-side router.
        /// </summary>
        public JsString url;
        /// <summary>
        /// Combine any buffered requests and send them off
        /// </summary>
        private void combineAndSend(){}
        /// <summary>
        /// Configure a form submission request
        /// </summary>
        /// <param name="action"><p>The action being executed</p>
        /// </param>
        /// <param name="method"><p>The method being executed</p>
        /// </param>
        /// <param name="form"><p>The form being submitted</p>
        /// </param>
        /// <param name="callback"><p>A callback to run after the form submits</p>
        /// </param>
        /// <param name="scope"><p>A scope to execute the callback in</p>
        /// </param>
        private void configureFormRequest(JsString action, object method, object form, object callback=null, object scope=null){}
        /// <summary>
        /// Configure a direct request
        /// </summary>
        /// <param name="action"><p>The action being executed</p>
        /// </param>
        /// <param name="method"><p>The being executed</p>
        /// </param>
        private void configureRequest(JsString action, object method){}
        /// <summary>
        /// Create a handler function for a direct call.
        /// </summary>
        /// <param name="action"><p>The action the call is for</p>
        /// </param>
        /// <param name="method"><p>The details of the method</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>A JS function that will kick off the call</p>
        /// </div>
        /// </returns>
        private System.Delegate createHandler(JsString action, object method){return null;}
        /// <summary>
        /// Gets the Ajax call info for a transaction
        /// </summary>
        /// <param name="transaction"><p>The transaction</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The call params</p>
        /// </div>
        /// </returns>
        private object getCallData(Transaction transaction){return null;}
        /// <summary>
        /// Get transaction from XHR options
        /// </summary>
        /// <param name="options"><p>The options sent to the Ajax request</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.direct.Transaction">Ext.direct.Transaction</see></span><div><p>The transaction, null if not found</p>
        /// </div>
        /// </returns>
        private Transaction getTransaction(object options){return null;}
        /// <summary>
        /// Initialize the API
        /// </summary>
        private void initAPI(){}
        /// <summary>
        /// React to the ajax request being completed
        /// </summary>
        /// <param name="options">
        /// </param>
        /// <param name="success">
        /// </param>
        /// <param name="response">
        /// </param>
        private void onData(object options, object success, object response){}
        /// <summary>
        /// Add a new transaction to the queue
        /// </summary>
        /// <param name="transaction"><p>The transaction</p>
        /// </param>
        private void queueTransaction(Transaction transaction){}
        /// <summary>
        /// Run any callbacks related to the transaction.
        /// </summary>
        /// <param name="transaction"><p>The transaction</p>
        /// </param>
        /// <param name="event"><p>The event</p>
        /// </param>
        private void runCallback(Transaction transaction, Ext.direct.Event @event){}
        /// <summary>
        /// Sends a form request
        /// </summary>
        /// <param name="transaction"><p>The transaction to send</p>
        /// </param>
        private void sendFormRequest(Transaction transaction){}
        /// <summary>
        /// Sends a request to the server
        /// </summary>
        /// <param name="data"><p>The data to send</p>
        /// </param>
        private void sendRequest(object data){}
        public RemotingProvider(RemotingProviderConfig config){}
        public RemotingProvider(){}
        public RemotingProvider(params object[] args){}
    }
    #endregion
    #region RemotingProviderConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RemotingProviderConfig : JsonProviderConfig
    {
        /// <summary>
        /// Object literal defining the server side actions and methods. For example, if
        /// the Provider is configured with:
        /// <code>"actions":{ // each property within the 'actions' object represents a server side Class
        /// "TestAction":[ // array of methods within each server side Class to be
        /// {              // stubbed out on client
        /// "name":"doEcho",
        /// "len":1
        /// },{
        /// "name":"multiply",// name of method
        /// "len":2           // The number of parameters that will be used to create an
        /// // array of data to send to the server side function.
        /// // Ensure the server sends back a Number, not a String.
        /// },{
        /// "name":"doForm",
        /// "formHandler":true, // direct the client to use specialized form handling method
        /// "len":1
        /// }]
        /// }
        /// </code>
        /// Note that a Store is not required, a server method can be called at any time.
        /// In the following example a <b>client side</b> handler is used to call the
        /// server side method "multiply" in the server-side "TestAction" Class:
        /// <code>TestAction.multiply(
        /// 2, 4, // pass two arguments to server, so specify len=2
        /// // callback function after the server is called
        /// // result: the result returned by the server
        /// //      e: <see cref="Ext.direct.RemotingEvent">Ext.direct.RemotingEvent</see> object
        /// function(result, e){
        /// var t = e.getTransaction();
        /// var action = t.action; // server side Class called
        /// var method = t.method; // server side method called
        /// if(e.status){
        /// var answer = <see cref="Ext.ExtContext.encode">Ext.encode</see>(result); // 8
        /// }else{
        /// var msg = e.message; // failure message
        /// }
        /// }
        /// );
        /// </code>
        /// In the example above, the server side "multiply" function will be passed two
        /// arguments (2 and 4).  The "multiply" method should return the value 8 which will be
        /// available as the <tt>result</tt> in the example above.
        /// </summary>
        public JsObject actions;
        /// <summary>
        /// true or false to enable or disable combining of method
        /// calls. If a number is specified this is the amount of time in milliseconds
        /// to wait before sending a batched request.
        /// Calls which are received within the specified timeframe will be
        /// <p>concatenated together and sent in a single request, optimizing the
        /// application by reducing the amount of round trips that have to be made
        /// to the server.</p>
        /// Defaults to: <c>10</c>
        /// </summary>
        public object enableBuffer;
        /// <summary>
        /// Specify which param will hold the arguments for the method.
        /// Defaults to 'data'.
        /// </summary>
        public JsString enableUrlEncode;
        /// <summary>
        /// Number of times to re-attempt delivery on failure of a call.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber maxRetries;
        /// <summary>
        /// Namespace for the Remoting Provider (defaults to the browser global scope of window).
        /// Explicitly specify the namespace Object, or specify a String to have a
        /// namespace created implicitly.
        /// </summary>
        public object @namespace;
        /// <summary>
        /// The timeout to use for each request.
        /// </summary>
        public JsNumber timeout;
        /// <summary>
        /// Required. The url to connect to the Ext.direct.Manager server-side router.
        /// </summary>
        public JsString url;
        public RemotingProviderConfig(params object[] args){}
    }
    #endregion
    #region RemotingProviderEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RemotingProviderEvents : JsonProviderEvents
    {
        /// <summary>
        /// Fires immediately before the client-side sends off the RPC call.
        /// By returning false from an event handler you can prevent the call from
        /// executing.
        /// </summary>
        /// <param name="provider">
        /// </param>
        /// <param name="transaction">
        /// </param>
        /// <param name="meta"><p>The meta data</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecall(RemotingProvider provider, Transaction transaction, object meta, object eOpts){}
        /// <summary>
        /// Fires immediately after the request to the server-side is sent. This does
        /// NOT fire after the response has come back from the call.
        /// </summary>
        /// <param name="provider">
        /// </param>
        /// <param name="transaction">
        /// </param>
        /// <param name="meta"><p>The meta data</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void call(RemotingProvider provider, Transaction transaction, object meta, object eOpts){}
        public RemotingProviderEvents(params object[] args){}
    }
    #endregion
}
