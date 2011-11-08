//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Array
    /// <summary>
    /// A set of useful static methods to deal with arrays; provide missing methods for older browsers.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Array
    {
        /// <summary>
        /// Filter through an array and remove empty item as defined in Ext.isEmpty
        /// See filter ...
        /// </summary>
        public static JsArray clean(JsArray array){return null;}
        /// <summary>
        /// Clone a flat array without referencing the previous one. ...
        /// </summary>
        public static JsArray clone(JsArray array){return null;}
        /// <summary>
        /// Checks whether or not the given array contains the specified item ...
        /// </summary>
        public static bool contains(JsArray array, object item){return false;}
        /// <summary>
        /// Perform a set difference A-B by subtracting all items in array B from array A. ...
        /// </summary>
        public static JsArray difference(JsArray arrayA, JsArray arrayB){return null;}
        /// <summary>
        /// Iterates an array or an iterable value and invoke the given callback function for each item. ...
        /// </summary>
        public static bool each(object iterable, JsAction fn, object scope, bool reverse){return false;}
        /// <summary>
        /// Iterates an array or an iterable value and invoke the given callback function for each item. ...
        /// </summary>
        public static bool each( object iterable, JsAction fn, object scope ) { return false; }
        /// <summary>
        /// Iterates an array or an iterable value and invoke the given callback function for each item. ...
        /// </summary>
        public static bool each( object iterable, JsAction fn ) { return false; }
        /// <summary>
        /// Removes items from an array. ...
        /// </summary>
        public static JsArray erase(JsArray array, JsNumber index, JsNumber removeCount){return null;}
        /// <summary>
        /// Executes the specified function for each array element until the function returns a falsy value. ...
        /// </summary>
        public static bool every(JsArray array, JsAction fn, object scope){return false;}
        /// <summary>
        /// Creates a new array with all of the elements of this array for which
        /// the provided filtering function returns true. ...
        /// </summary>
        public static JsArray filter(JsArray array, JsAction fn, object scope){return null;}
        /// <summary>
        /// Recursively flattens into 1-d Array. ...
        /// </summary>
        public static object flatten(object array){return null;}
        /// <summary>
        /// Iterates an array and invoke the given callback function for each item. ...
        /// </summary>
        public static object forEach(JsArray array, JsAction fn, object scope){return null;}
        /// <summary>
        /// Converts a value to an array if it's not already an array; returns:
        /// An empty array if given value is undefined or n...
        /// </summary>
        public static JsArray from(object value, bool newReference){return null;}
        /// <summary>
        /// Push an item into the array only if the array doesn't contain it yet ...
        /// </summary>
        public static object include(JsArray array, object item){return null;}
        /// <summary>
        /// Get the index of the provided item in the given array, a supplement for the
        /// missing arrayPrototype.indexOf in Interne...
        /// </summary>
        public static JsNumber indexOf(JsArray array, object item, JsNumber from){return null;}
        /// <summary>
        /// Get the index of the provided item in the given array, a supplement for the
        /// missing arrayPrototype.indexOf in Interne...
        /// </summary>
        public static JsNumber indexOf( JsArray array, object item ) { return null; }
        /// <summary>
        /// Inserts items in to an array. ...
        /// </summary>
        public static JsArray insert(JsArray array, JsNumber index, JsArray items){return null;}
        /// <summary>
        /// Merge multiple arrays into one with unique items that exist in all of the arrays. ...
        /// </summary>
        public static JsArray intersect(JsArray array1, JsArray array2, JsArray etc){return null;}
        /// <summary>
        /// Creates a new array with the results of calling a provided function on every element in this array. ...
        /// </summary>
        public static JsArray map(JsArray array, JsAction fn, object scope){return null;}
        /// <summary>
        /// Returns the maximum value in the Array. ...
        /// </summary>
        public static object max(object array, JsAction comparisonFn=null){return null;}
        /// <summary>
        /// Calculates the mean of all items in the array. ...
        /// </summary>
        public static JsNumber mean(JsArray array){return null;}
        /// <summary>
        /// Merge multiple arrays into one with unique items. ...
        /// </summary>
        public static JsArray merge(JsArray array1, JsArray array2, JsArray etc){return null;}
        /// <summary>
        /// Returns the minimum value in the Array. ...
        /// </summary>
        public static object min(object array, JsAction comparisonFn=null){return null;}
        /// <summary>
        /// Plucks the value of a property from each item in the Array. ...
        /// </summary>
        public static JsArray pluck(object array, JsString propertyName){return null;}
        /// <summary>
        /// Removes the specified item from the array if it exists ...
        /// </summary>
        public static JsArray remove(JsArray array, object item){return null;}
        /// <summary>
        /// Replaces items in an array. ...
        /// </summary>
        public static JsArray replace(JsArray array, JsNumber index, JsNumber removeCount, JsArray insert){return null;}
        /// <summary>
        /// Returns a shallow copy of a part of an array. ...
        /// </summary>
        public static JsArray slice(JsArray array, JsNumber begin, JsNumber end){return null;}
        /// <summary>
        /// Executes the specified function for each array element until the function returns a truthy value. ...
        /// </summary>
        public static bool some(JsArray array, JsAction fn, object scope){return false;}
        /// <summary>
        /// Sorts the elements of an Array. ...
        /// </summary>
        public static JsArray sort(JsArray array, JsAction sortFn=null){return null;}
        /// <summary>
        /// Replaces items in an array. ...
        /// </summary>
        public static JsArray splice(JsArray array, JsNumber index, JsNumber removeCount){return null;}
        /// <summary>
        /// Calculates the sum of all items in the given array. ...
        /// </summary>
        public static JsNumber sum(JsArray array){return null;}
        /// <summary>
        /// Converts any iterable (numeric indices and a length property) into a true array. ...
        /// </summary>
        public static JsArray toArray(object iterable, JsNumber start, JsNumber end){return null;}
        /// <summary>
        /// Merge multiple arrays into one with unique items. ...
        /// </summary>
        public static JsArray union(JsArray array1, JsArray array2, JsArray etc){return null;}
        /// <summary>
        /// Returns a new array with unique items ...
        /// </summary>
        public static JsArray unique(JsArray array){return null;}
        public Array(Ext.ArrayConfig config){}
        public Array(){}
    }
    #endregion
    #region ArrayConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ArrayConfig
    {
    }
    #endregion
    #region ArrayEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ArrayEvents
    {
    }
    #endregion
}
#endregion
