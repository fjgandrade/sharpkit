//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region ClassManager
    /// <summary>
    /// Ext.ClassManager manages all classes and handles mapping from string class name to
    /// actual class objects throughout the whole framework. It is not generally accessed directly, rather through
    /// these convenient shorthands:  Ext.define Ext.create Ext.widget Ext.getClass Ext.getClassName
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ClassManager
    {
        /// <summary>
        /// Defines a class. ...
        /// </summary>
        public static Ext.Base create(JsString className, object data, JsAction createdFn){return null;}
        /// <summary>
        /// Retrieve a class by its name. ...
        /// </summary>
        public static Class get(JsString name){return null;}
        /// <summary>
        /// Get the aliases of a class by the class name ...
        /// </summary>
        public static JsArray getAliasesByName(JsString name){return null;}
        /// <summary>
        /// Get a reference to the class by its alias. ...
        /// </summary>
        public static Class getByAlias(JsString alias){return null;}
        /// <summary>
        /// Get the class of the provided object; returns null if it's not an instance
        /// of any class created with Ext.define. ...
        /// </summary>
        public static Class getClass(object @object){return null;}
        /// <summary>
        /// ...
        /// </summary>
        public static object getDisplayName(object @object){return null;}
        /// <summary>
        /// Get the name of the class by its reference or its instance. ...
        /// </summary>
        public static JsString getName(object @object){return null;}
        /// <summary>
        /// Get the name of a class by its alias. ...
        /// </summary>
        public static JsString getNameByAlias(JsString alias){return null;}
        /// <summary>
        /// Get the name of a class by its alternate name. ...
        /// </summary>
        public static JsString getNameByAlternate(JsString alternate){return null;}
        /// <summary>
        /// Converts a string expression to an array of matching class names. ...
        /// </summary>
        public static JsArray getNamesByExpression(JsString expression){return null;}
        /// <summary>
        /// Instantiate a class by either full name, alias or alternate name. ...
        /// </summary>
        public static object instantiate(JsString name, object args){return null;}
        /// <summary>
        /// Instantiate a class by its alias. ...
        /// </summary>
        public static object instantiateByAlias(JsString alias, object args){return null;}
        /// <summary>
        /// Checks if a class has already been created. ...
        /// </summary>
        public static bool isCreated(JsString className){return false;}
        /// <summary>
        /// Register a post-processor function. ...
        /// </summary>
        public static object registerPostprocessor(JsString name, JsAction postprocessor, object always){return null;}
        /// <summary>
        /// Sets a name reference to a class. ...
        /// </summary>
        public static ClassManager set(JsString name, object value){return null;}
        /// <summary>
        /// Register the alias for a class. ...
        /// </summary>
        public static object setAlias(object cls, JsString alias){return null;}
        /// <summary>
        /// Insert this post-processor at a specific position in the stack, optionally relative to
        /// any existing post-processor ...
        /// </summary>
        public static ClassManager setDefaultPostprocessorPosition(JsString name, JsString offset, JsString relativeName){return null;}
        /// <summary>
        /// Set the default post processors array stack which are applied to every class. ...
        /// </summary>
        public static ClassManager setDefaultPostprocessors(object The){return null;}
        /// <summary>
        /// Creates a namespace and assign the value to the created object
        /// Ext.ClassManager.setNamespace('MyCompany.pkg.Example'...
        /// </summary>
        public static object setNamespace(JsString name, object value){return null;}
        public ClassManager(ClassManagerConfig config){}
        public ClassManager(){}
    }
    #endregion
    #region ClassManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ClassManagerConfig
    {
    }
    #endregion
    #region ClassManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ClassManagerEvents
    {
    }
    #endregion
}
#endregion
