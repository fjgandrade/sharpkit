//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region Types
    /// <summary>
    /// This is s static class containing the system-supplied data types which may be given to a Field. The properties in this class are used as type indicators in the Field class, so to
    /// test whether a Field is of a certain type, compare the type property against properties
    /// of this class. Developers may add their own application-specific data types to this class. Definition names must be UPPERCASE.
    /// each type definition must contain three properties:  convert : FunctionA function to convert raw data values from a data block into the data
    /// to be stored in the Field. The function is passed the collowing parameters:
    /// v : MixedThe data value as read by the Reader, if undefined will use
    /// the configured defaultValue. rec : MixedThe data object containing the row as read by the Reader.
    /// Depending on the Reader type, this could be an Array (ArrayReader), an object
    /// (JsonReader), or an XML element.  sortType : Function A function to convert the stored data into comparable form, as defined by Ext.data.SortTypes. type : String A textual data type name.  For example, to create a VELatLong field (See the Microsoft Bing Mapping API) containing the latitude/longitude value of a datapoint on a map from a JsonReader data block
    /// which contained the properties lat and long, you would define a new data type like this: // Add a new Field data type which stores a VELatLong object in the Record.
    /// Ext.data.Types.VELATLONG = {
    /// convert: function(v, data) {
    /// return new VELatLong(data.lat, data.long);
    /// },
    /// sortType: function(v) {
    /// return v.Latitude;  // When sorting, order by latitude
    /// },
    /// type: &#39;VELatLong&#39;
    /// };
    /// Then, when declaring a Model, use
    /// var types = Ext.data.Types; // allow shorthand type access
    /// Ext.define(&#39;Unit&#39;,
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// { name: &#39;unitName&#39;, mapping: &#39;UnitName&#39; },
    /// { name: &#39;curSpeed&#39;, mapping: &#39;CurSpeed&#39;, type: types.INT },
    /// { name: &#39;latitude&#39;, mapping: &#39;lat&#39;, type: types.FLOAT },
    /// { name: &#39;latitude&#39;, mapping: &#39;lat&#39;, type: types.FLOAT },
    /// { name: &#39;position&#39;, type: types.VELATLONG }
    /// ]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Types : Ext.Base
    {
        public object AUTO{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a boolean before it is placed into
        /// a Record. ...
        /// </summary>
        public object BOOL{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a boolean before it is placed into
        /// a Record. ...
        /// </summary>
        public object BOOLEAN{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a Date before it is placed into a Record. ...
        /// </summary>
        public object DATE{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a number before it is placed into a Record. ...
        /// </summary>
        public object FLOAT{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into an integer before it is placed into a Record. ...
        /// </summary>
        public object INT{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into an integer before it is placed into a Record. ...
        /// </summary>
        public object INTEGER{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a number before it is placed into a Record. ...
        /// </summary>
        public object NUMBER{get;set;}
        public object STRING{get;set;}
        /// <summary>
        /// A regular expression for stripping non-numeric characters from a numeric value. ...
        /// </summary>
        public JsRegExp stripRe{get;set;}
    }
    #endregion
    #region TypesConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TypesConfig
    {
    }
    #endregion
    #region TypesEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TypesEvents
    {
    }
    #endregion
}
#endregion
