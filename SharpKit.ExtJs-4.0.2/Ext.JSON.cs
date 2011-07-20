//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region JSON
    /// <summary>
    /// Modified version of Douglas Crockford&quot;s json.js that doesn&quot;t
    /// mess with the Object prototype
    /// http://www.json.org/js.html
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class JSON
    {
        /// <summary>
        /// Decodes (parses) a JSON string to an object. ...
        /// </summary>
        public object decode(JsString json, bool safe=false){return null;}
        /// <summary>
        /// Encodes an Object, Array or other value ...
        /// </summary>
        public JsString encode(object o){return null;}
        /// <summary>
        /// Encodes a Date. ...
        /// </summary>
        public JsString encodeDate(JsDate d){return null;}
    }
    #endregion
    #region JSONConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class JSONConfig
    {
    }
    #endregion
    #region JSONEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class JSONEvents
    {
    }
    #endregion
}
#endregion
