//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:22
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Function
    /// <summary>
    /// A collection of useful static methods to deal with function callbacks
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Function
    {
        /// <summary>
        /// Create an alias to the provided method property with name methodName of object. ...
        /// </summary>
        public JsAction alias(object @object, JsString methodName){return null;}
        /// <summary>
        /// Create a new function from the provided fn, change this to the provided scope, optionally
        /// overrides arguments for the...
        /// </summary>
        public JsAction bind(JsAction fn, object scope=null, JsArray args=null, object appendArgs=null){return null;}
        /// <summary>
        /// Creates a delegate function, optionally with a bound scope which, when called, buffers
        /// the execution of the passed fu...
        /// </summary>
        public JsAction createBuffered(JsAction fn, JsNumber buffer, object scope=null, JsArray args=null){return null;}
        /// <summary>
        /// Creates a delegate (callback) which, when called, executes after a specific delay. ...
        /// </summary>
        public JsAction createDelayed(JsAction fn, JsNumber delay, object scope=null, JsArray args=null, object appendArgs=null){return null;}
        /// <summary>
        /// Creates an interceptor function. ...
        /// </summary>
        public JsAction createInterceptor(JsAction origFn, JsAction newFn, object scope=null, object returnValue=null){return null;}
        /// <summary>
        /// Create a combined function call sequence of the original function + the passed function. ...
        /// </summary>
        public JsAction createSequence(JsAction origFn, JsAction newFn, object scope=null){return null;}
        /// <summary>
        /// Creates a throttled version of the passed function which, when called repeatedly and
        /// rapidly, invokes the passed func...
        /// </summary>
        public JsAction createThrottled(JsAction fn, JsNumber interval, object scope=null){return null;}
        /// <summary>
        /// Calls this function after the number of millseconds specified, optionally in a specific scope. ...
        /// </summary>
        public JsNumber defer(JsAction fn, JsNumber millis, object scope=null, JsArray args=null, object appendArgs=null){return null;}
        /// <summary>
        /// A very commonly used method throughout the framework. ...
        /// </summary>
        public JsAction flexSetter(JsAction setter){return null;}
        /// <summary>
        /// Create a new function from the provided fn, the arguments of which are pre-set to args. ...
        /// </summary>
        public JsAction pass(JsAction fn, JsArray args, object scope=null){return null;}
    }
    #endregion
    #region FunctionConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class FunctionConfig
    {
    }
    #endregion
    #region FunctionEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class FunctionEvents
    {
    }
    #endregion
}
#endregion
