//JavaScript v1.5 
//SharpKit v4.02.8000

using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpKit.JavaScript
{
    #region JsAttributes
    #region JsTypeAttribute
    ///<summary>
    ///Controls the interoperability and convertion of a .NET type into JavaScript.
    ///</summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Delegate | AttributeTargets.Assembly, AllowMultiple = true)]
    public partial class JsTypeAttribute : Attribute
    {
        public JsTypeAttribute() { }
        public JsTypeAttribute(JsMode mode) { }
        public JsTypeAttribute(JsMode mode, string filename) { }

        /// <summary>
        /// Js code that will be written before exporting the type
        /// </summary>
        public string PreCode { get; set; }
        /// <summary>
        /// Js code that will be written after exporting the type
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Precendece between JsTypes in the same file, negative values will put the type before other types, and positive value will put it after other types
        /// </summary>
        public int OrderInFile { get; set; }

        /// <summary>
        /// When used as assembly attribute, indicates the type for which to apply this attribute on.
        /// This feature should be used when trying to describe classes on external assemblies that has no SharpKit support
        /// </summary>
        public Type TargetType { get; set; }

        ///<summary>
        ///Indicates that all delegate parameters in all members are native javascript functions
        ///</summary>
        public bool NativeDelegates { get; set; }
        ///<summary>
        ///When true, omits all casts to this type
        ///</summary>
        public bool OmitCasts { get; set; }
        public bool PropertiesAsFields { get; set; }
        public bool AutomaticPropertiesAsFields { get; set; }
        ///<summary>
        ///When true, foreach statements will use the for..in syntax of Javascript
        ///</summary>
        public bool NativeEnumerator { get; set; }
        ///<summary>
        ///When true, instanciations of this class will use the native Javascript method, rather than calling a constructor
        ///</summary>
        public bool NativeConstructors { get; set; }
        ///<summary>
        ///When true, instanciations of this class will use the native Javascript method, rather than calling a constructor
        ///</summary>
        public bool NativeOverloads { get; set; }
        ///<summary>
        ///Indicates that this type will be exported as native js type, 
        ///only one constructor is allowed, 
        ///all instance members will be exported to the constructor's prototype
        ///all static members will be exported to the constructor's members
        ///</summary>
        public bool Native { get; set; }
        ///<summary>
        ///When set, the class methods and properties will be declared on the window object, instead of a class.
        ///</summary>
        public bool GlobalObject { get; set; }
        ///<summary>
        ///Any anonymous delegate creation will be exported as a native inline function in javascript
        ///</summary>
        public bool NativeFunctions { get; set; }
        ///<summary>
        ///Anonymous objects will be created and treated as Json objects
        ///</summary>
        public bool NativeJsons { get; set; }
        /// <summary>
        ///	Indicates that SharpKit compiler will generate javascript code for this type / member
        /// This property is inherited and applied to all derived types. Default value is true
        /// </summary>
        public bool Export { get; set; }
        ///<summary>
        ///When set, changes the type name in the client code
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        ///The target filename to generate the javascript code into, when using a relative path, it will be relative to the current cs file,
        ///You may use the ~  (tilda) operator to designate the project directory
        ///</summary>
        public string Filename { get; set; }
        ///<summary>
        ///The type of js exporter to use
        ///</summary>
        public string Exporter { get; set; }
        public bool IgnoreGenericTypeArguments { get; set; }
        public JsMode Mode { get; set; }
    }
    #endregion
    #region JsMode
    ///<summary>
    ///Specifies the export and interopability mode of a C# type in JavaScript
    ///</summary>
    public enum JsMode 
    { 
        Global, 
        Prototype, 
        Clr, 
        Json 
    }

    #endregion

    #region JsExportAttribute
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public partial class JsExportAttribute : Attribute
    {
        public bool ExportComments { get; set; }
        public bool Minify { get; set; }
        public bool LongFunctionNames { get; set; }
        public bool EnableProfiler { get; set; }
    }
    #endregion
    #region JsMergedFileAttribute
    ///<summary>
    ///Instructs SharpKit Compiler to create a merged file from specified sources
    ///</summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public partial class JsMergedFileAttribute : Attribute
    {
        ///<summary>
        ///The source files to merge
        ///</summary>
        public string[] Sources { get; set; }
        ///<summary>
        ///The target merged file name
        ///</summary>
        public string Filename { get; set; }
    }
    #endregion
    #region JsMethodAttribute
    ///<summary>
    ///Indicates that the SharpKit Build precompiler will change the way it handles this method at the client
    ///</summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public partial class JsMethodAttribute : Attribute
    {
        ///<summary>
        ///Tells the compiler to omit calls to this method and assume that it was invoked
        ///Extension methods:  s.DoSomething() ==> s
        ///</summary>
        public bool OmitCalls { get; set; }
        public string Name { get; set; }
        ///<summary>
        ///Tells the compiler to drop the method call and write the inline code instead.
        ///Only available for extention methods.
        ///object.SomeExtentionMethod(param) with InlineCode="object==param" ==> object==param
        ///</summary>
        public string InlineCode { get; set; }
        ///<summary>
        ///Custom javascript code implementation for this method
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        ///When set to true - disables the overloading mechanism 
        ///and assumes that the overloads are implemented in a single javascript method with this name
        ///</summary>
        public bool NativeOverloads { get; set; }
        ///<summary>
        ///</summary>
        public bool IgnoreGenericArguments { get; set; }
        ///<summary>
        ///Marks this extension method as an instance method in javascript
        ///</summary>
        public bool ExtensionImplementedInInstance { get; set; }
        public bool NativeDelegates { get; set; }
        ///<summary>
        ///</summary>
        public bool GlobalCode { get; set; }
        ///<summary>
        ///Indicates that this method is global, if exported, it will be exported as a global function, and when invoked, it will be invoked without a class name prefix
        ///</summary>
        public bool Global { get; set; }
        /// <summary>
        ///	Indicates that SharpKit compiler will generate javascript code for this type / member
        /// This property is inherited and applied to all derived types. Default value is true
        /// </summary>
        public bool Export { get; set; }
    }
    #endregion
    #region JsPropertyAttribute
    ///<summary>
    ///Indicates that the SharpKit Build precompiler will change the way it handles this property at the client
    ///</summary>
    [AttributeUsage(AttributeTargets.Property)]
    public partial class JsPropertyAttribute : Attribute
    {
        ///<summary>
        ///When set, all references will not use getters and setter, but will treat it as a field instead
        ///</summary>
        ///<remarks>Default value is false</remarks>
        public bool NativeField { get; set; }
        ///<summary>
        ///When applied to an indexer property, all references will not use getters and setter, but will treat it as a native indexer instead
        ///</summary>
        ///<remarks>Default value is false</remarks>
        public bool NativeIndexer { get; set; }
        /// <summary>
        ///	Indicates that SharpKit compiler will generate javascript code for this type / member
        /// This property is inherited and applied to all derived types. Default value is true
        /// </summary>
        public bool Export { get; set; }
    }
    #endregion
    #region JsEventAttribute
    ///<summary>
    ///Indicates that the SharpKit Build precompiler will change the way it handles this property at the client
    ///</summary>
    [AttributeUsage(AttributeTargets.Event)]
    public partial class JsEventAttribute : Attribute
    {
        ///<summary>
        ///</summary>
        public bool NativeDelegates { get; set; }
    }
    #endregion
    #region JsDelegateAttribute
    ///<summary>
    ///Indicates that the SharpKit Build precompiler will change the way it handles this type at the client
    ///</summary>
    [AttributeUsage(AttributeTargets.Delegate)]
    public partial class JsDelegateAttribute : Attribute
    {
        public bool NativeDelegates { get; set; }
        public bool NativeFunction { get; set; }
    }
    #endregion
    #region BrowserCompatibility
    #region SupportedBrowsersAttribute
    ///<summary>
    ///Compile with browser compatibility #defines to activate (i.e. BROWSER_IE6, BROWSER_FireFox3)
    ///</summary>
    public partial class SupportedBrowsersAttribute : Attribute
    {
        public SupportedBrowsersAttribute(BrowserTypes sb) { }
        public SupportedBrowsersAttribute(BrowserTypes sb, string notSupportedRemark) { }
        public BrowserTypes SupportedBrowser { get; set; }
        ///<summary>
        ///If specified, and the browser is not supported, this text will be appended to the generate warning.
        ///</summary>
        public string NotSupportedRemark { get; set; }
        ///<summary>
        ///If specified, a warning will be generated even if the browser is supported. This is used for features that are partially supported.
        ///</summary>
        public string PartiallySupportedRemark { get; set; }
    }
    #endregion
    #region IgnoreBrowserCompatibilityAttribute
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly, AllowMultiple = true)]
    public partial class IgnoreBrowserCompatibilityAttribute : Attribute
    {
        public IgnoreBrowserCompatibilityAttribute() { }
        public IgnoreBrowserCompatibilityAttribute(string ignoredElements) { }
        public string IgnoredElements { get; set; }
    }
    #endregion
    #region HtmlSpecificationVersionAttribute
    ///<summary>
    ///Compile with html specification #deinfes to activate (ie. HTMLSPEC_4, HTMLSPEC_4_01, HTMLSPEC_5)
    ///</summary>
    public partial class HtmlSpecificationVersionAttribute : Attribute
    {
        public HtmlSpecificationVersionAttribute(float specLevel) { }
        public float Specification { get; set; }
    }
    #endregion
    [Flags]
    public enum BrowserTypes { None = 0, IE5_5 = 1, IE6 = 2, IE7 = 4, IE8 = 8, IE8AsIE7 = 16, IE9 = 32, FireFox2 = 64, FireFox3 = 128, FireFox3_5 = 256, FireFox4 = 512, Saf3Win = 1024, Saf3_1Win = 2048, Saf4Win = 4096, Chrome2 = 8192, Chrome3 = 16384, Chrome4 = 32768, Chrome5 = 65536, Opera9 = 131072, Opera10 = 262144, Konqueror3_57 = 524288 }
    #endregion
    #region JsEnumAttribute
    ///<summary>
    ///Controls the interoperability and convertion of a .NET type into JavaScript.
    ///</summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public partial class JsEnumAttribute : Attribute
    {
        public bool ValuesAsNames { get; set; }
    }

    #endregion

    #endregion


    #region JsArguments
    [JsType(Name = "arguments", Export = false)]
    public partial class JsArguments
    {
        [JsProperty(NativeIndexer = true)]
        public object this[JsNumber index] { get { return default(object); } set { } }
        [JsProperty(NativeField = true)]
        public JsNumber length { get; set; }
        /// <summary>
        /// Returns the Function object being executed, that is, the body text of the specified Function object.
        /// </summary>
        public JsFunction callee { get; set; }
    }
    #endregion
    #region JsArray
    ///<summary>
    ///The Array object provides support for creation of arrays of any data type.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Array", NativeEnumerator = false)]
    public partial class JsArray : JsObject, IEnumerable<object>
    {
        public JsArray() { }
        public JsArray(JsArray array) { }
        public JsArray(JsNumber size) { }
        public JsArray(params object[] items) { }
        public static implicit operator JsArray(Array array) { return default(JsArray); }
        public static implicit operator Array(JsArray array) { return default(Array); }
        public static implicit operator JsArray(object[] array) { return default(JsArray); }
        public static implicit operator object[](JsArray array) { return default(object[]); }
        ///<summary>
        ///Returns an integer value one higher than the highest element defined in an array.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber length { get; set; }
        [JsProperty(NativeIndexer = true)]
        public object this[JsNumber index] { get { return default(object); } set { } }
        ///<summary>
        ///Appends new elements to an array, and returns the new length of the array.
        ///</summary>
        ///<param name="items">Optional. New elements of the Array.</param>
        [JsMethod(NativeOverloads = true)]
        public void push(params object[] items) { }
        [JsMethod(NativeOverloads = true)]
        public object peek() { return default(object); }
        ///<summary>
        ///Removes the last element from an array and returns it.
        ///</summary>
        ///<remarks>
        ///If the array is empty, undefined is returned.
        ///</remarks>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public object pop() { return default(object); }
        ///<summary>
        ///Returns a new array consisting of a combination of the current array and any additional items.
        ///</summary>
        ///<param name="items">Optional. Additional items to add to the end of the current array.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsArray concat(params object[] items) { return default(JsArray); }
        ///<summary>
        ///Returns a JsString value consisting of all the elements of an array concatenated together and separated by the specified separator character.
        ///</summary>
        ///<param name="separator">Required. A JsString that is used to separate one element of an array from the next in the resulting String object. If omitted, the array elements are separated with a comma.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsString join(JsString separator) { return default(JsString); }
        ///<summary>
        ///Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements. Returns the elements removed from the array.
        ///</summary>
        ///<param name="start">Required. The zero-based location in the array from which to start removing elements.</param>
        ///<param name="deleteCount">Required. The number of elements to remove.</param>
        ///<param name="newItems">Optional. Elements to insert into the array in place of the deleted elements.</param>
        ///<remarks>
        ///The splice method modifies the array by removing the specified number of elements from position start and inserting new elements. The deleted elements are returned as a new array object.
        ///</remarks>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsArray splice(JsNumber start, JsNumber deleteCount, params object[] newItems) { return default(JsArray); }
        ///<summary>
        ///Returns a section of an array.
        ///</summary>
        ///<param name="start">Required. The index to the beginning of the specified portion of the array.</param>
        ///<param name="end">Optional. The index to the end of the specified portion of the array.</param>
        ///<remarks>
        ///The slice method returns an Array object containing the specified portion of the array.
        ///The slice method copies up to, but not including, the element indicated by end. If start is negative, it is treated as length + start where length is the length of the array. If end is negative, it is treated as length + end where length is the length of the array. If end is omitted, extraction continues to the end of the array. If end occurs before start, no elements are copied to the new array.
        ///</remarks>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsArray slice(JsNumber start, JsNumber end) { return default(JsArray); }
        ///<summary>
        ///Returns an Array object with the elements reversed.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsArray reverse() { return default(JsArray); }
        ///<summary>
        ///Removes the first element from an array and returns that element.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public object shift() { return default(object); }
        ///<summary>
        ///Inserts specified elements into the beginning of an array.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public object unshift() { return default(object); }
        ///<summary>
        ///Inserts specified elements into the beginning of an array.
        ///</summary>
        ///<param name="newItems">Optional. Elements to insert at the start of the Array.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public object unshift(params object[] newItems) { return default(object); }
        ///<summary>
        ///Returns an Array object with the elements sorted.
        ///</summary>
        ///<param name="sortFunction">Optional. OriginalValue of the function used to determine the order of the elements.</param>
        [JsMethod(NativeOverloads = true)]
        public JsArray sort(Func<object, object, JsNumber> sortFunction) { return default(JsArray); }
        ///<summary>
        ///Returns an Array object with the elements sorted.
        ///</summary>
        ///<param name="sortFunction">Optional. OriginalValue of the function used to determine the order of the elements.</param>
        public JsArray sort(JsFunction sortFunction) { return default(JsArray); }
        ///<summary>
        ///Returns an Array object with the elements sorted.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public void sort() { }
        public IEnumerator<object> GetEnumerator() { return default(IEnumerator<object>); }
        IEnumerator IEnumerable.GetEnumerator() { return default(IEnumerator); }
    }
    #endregion
    #region JsArray<T>
    ///<summary>
    ///The Array object provides support for creation of arrays of any data type.
    ///</summary>
    ///<typeparam name="T"></typeparam>
    [JsType(JsMode.Prototype, Name = "Array", NativeEnumerator = false, Export = false, IgnoreGenericTypeArguments = true)]
    public partial class JsArray<T> : JsArray, IEnumerable<T>
    {
        public static implicit operator T[](JsArray<T> x) { return default(T[]); }
        public static implicit operator JsArray<T>(T[] array) { return default(JsArray<T>); }
        [JsMethod(IgnoreGenericArguments = true)]
        public JsArray() { }
        [JsMethod(IgnoreGenericArguments = true)]
        public JsArray(JsArray<T> array) { }
        [JsMethod(IgnoreGenericArguments = true)]
        public JsArray(JsNumber size) { }
        [JsMethod(IgnoreGenericArguments = true)]
        public JsArray(params T[] items) { }
        [JsProperty(NativeIndexer = true)]
        public new T this[JsNumber index] { get { return default(T); } set { } }
        ///<summary>
        ///Appends new elements to an array, and returns the new length of the array.
        ///</summary>
        ///<param name="items">Optional. New elements of the Array.</param>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public void push(params T[] items) { }
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public new T peek() { return default(T); }
        ///<summary>
        ///Removes the last element from an array and returns it.
        ///</summary>
        ///<remarks>
        ///If the array is empty, undefined is returned.
        ///</remarks>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public new T pop() { return default(T); }
        ///<summary>
        ///Returns a new array consisting of a combination of the current array and any additional items.
        ///</summary>
        ///<param name="items">Optional. Additional items to add to the end of the current array.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public JsArray<T> concat(params T[] items) { return default(JsArray<T>); }
        ///<summary>
        ///Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements. Returns the elements removed from the array.
        ///</summary>
        ///<param name="start">Required. The zero-based location in the array from which to start removing elements.</param>
        ///<param name="deleteCount">Required. The number of elements to remove.</param>
        ///<param name="newItems">Optional. Elements to insert into the array in place of the deleted elements.</param>
        ///<remarks>
        ///The splice method modifies the array by removing the specified number of elements from position start and inserting new elements. The deleted elements are returned as a new array object.
        ///</remarks>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public JsArray<T> splice(JsNumber start, JsNumber deleteCount, params T[] newItems) { return default(JsArray<T>); }
        ///<summary>
        ///Returns a section of an array.
        ///</summary>
        ///<param name="start">Required. The index to the beginning of the specified portion of the array.</param>
        ///<param name="end">Optional. The index to the end of the specified portion of the array.</param>
        ///<remarks>
        ///The slice method returns an Array object containing the specified portion of the array.
        ///The slice method copies up to, but not including, the element indicated by end. If start is negative, it is treated as length + start where length is the length of the array. If end is negative, it is treated as length + end where length is the length of the array. If end is omitted, extraction continues to the end of the array. If end occurs before start, no elements are copied to the new array.
        ///</remarks>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public new JsArray<T> slice(JsNumber start, JsNumber end) { return default(JsArray<T>); }
        ///<summary>
        ///Returns an Array object with the elements reversed.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public new JsArray<T> reverse() { return default(JsArray<T>); }
        ///<summary>
        ///Removes the first element from an array and returns that element.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public new T shift() { return default(T); }
        ///<summary>
        ///Inserts specified elements into the beginning of an array.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public new T unshift() { return default(T); }
        ///<summary>
        ///Inserts specified elements into the beginning of an array.
        ///</summary>
        ///<param name="newItems">Optional. Elements to insert at the start of the Array.</param>
        ///<returns>the new length</returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        public JsNumber unshift(params T[] newItems) { return default(JsNumber); }
        ///<summary>
        ///Returns an Array object with the elements sorted.
        ///</summary>
        ///<param name="sortFunction">Optional. OriginalValue of the function used to determine the order of the elements.</param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void sort(Func<T, T, JsNumber> sortFunction) { }
        ///<summary>
        ///Returns an Array object with the elements sorted.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public new void sort() { }
        public new IEnumerator<T> GetEnumerator() { return default(IEnumerator<T>); }
        IEnumerator IEnumerable.GetEnumerator() { return default(IEnumerator); }
    }
    #endregion
    #region JsBoolean
    [JsType(JsMode.Prototype, Name = "Boolean", Export = false)]
    public partial class JsBoolean
    {
        public JsBoolean(object boolValue) { }
        public JsBoolean() { }
        public static implicit operator bool(JsBoolean x) { return default(bool); }
        public static implicit operator JsBoolean(bool x) { return default(JsBoolean); }
    }
    #endregion
    #region JsContext
    [JsType(JsMode.Global, Export = false)]
    public partial class JsContext
    {
        public static JsArguments arguments;
        ///<summary>
        ///indicates that a variable has not been assigned a value.
        ///</summary>
        [JsProperty(NativeField = true)]
        public static object undefined { get; set; }
        public static JsString @typeof(object obj) { return default(JsString); }
        public static object @this;
        public static object @return(object obj) { return null; }
        public static object @return() { return null; }
        ///<summary>
        ///Evaluates JScript code and executes it.
        ///</summary>
        ///<param name="code">A JsString value that contains valid JScript code. This JsString is parsed by the JScript parser and executed.</param>
        ///<returns></returns>
        public static object eval(JsString code) { return default(object); }
        ///<summary>
        ///Returns an integer converted from a JsString.
        ///</summary>
        ///<param name="s">A JsString to convert into a number.</param>
        ///<returns>An integer value equal to the number contained in numString. If no prefix of numString can be successfully parsed into an integer, NaN (not a number) is returned.</returns>
        public static JsNumber parseInt(JsString s) { return default(JsNumber); }
        ///<summary>
        ///Returns an integer converted from a JsString.
        ///</summary>
        ///<param name="numString">A JsString to convert into a number.</param>
        ///<param name="radix"> A value between 2 and 36 indicating the base 
        ///of the number contained in numString. If not supplied, strings with 
        ///a prefix of '0x' are considered hexadecimal and strings with a prefix 
        ///of '0' are considered octal. All other strings are considered decimal.</param>
        ///<returns>An integer value equal to the number contained in numString. 
        ///If no prefix of numString can be successfully parsed into an integer, 
        ///NaN (not a number) is returned.</returns>
        public static JsNumber parseInt(JsString numString, JsNumber radix) { return default(JsNumber); }
        ///<summary>
        ///Returns a Boolean value that indicates whether a value is the reserved value NaN (not a number).
        ///</summary>
        ///<param name="numValue">A value to be tested against NaN.</param>
        ///<returns>True if the value converted to the Number type is the NaN, otherwise false.</returns>
        public static JsBoolean isNaN(object numValue) { return default(JsBoolean); }
        ///<summary>
        ///Returns a Boolean value that indicates if a supplied number is finite.
        ///</summary>
        ///<param name="number">A numeric value.</param>
        ///<returns>True if number is any value other than NaN, negative infinity, 
        ///or positive infinity. In those three cases, it returns false.</returns>
        public static JsBoolean isFinite(double number) { return default(JsBoolean); }
        public static void @throw(JsError error) { }
        public static void delete(object obj) { }
        ///<summary>
        ///Returns a floating-point number converted from a JsString.
        ///</summary>
        ///<param name="s">A JsString that contains a floating-point number.</param>
        ///<returns>A numerical value equal to the number contained in numString. If no prefix of numString can be successfully parsed into a floating-point number, NaN (not a number) is returned.</returns>
        public static float parseFloat(JsString s) { return default(float); }
    }
    #endregion
    #region JsDate
    [JsType(Export = false, Name = "Date", NativeConstructors = true)]
    public partial class JsDate : JsObject
    {
        public static JsNumber operator -(JsDate date1, JsDate date2) { return default(JsNumber); }
        public JsDate(params object[] prms) { }
        ///<summary>
        ///Returns the year value in the Date object using local time.
        ///</summary>
        ///<returns>the year as an absolute number. For example, the year 1976 is returned as 1976.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getFullYear() { return default(JsNumber); }
        ///<summary>
        ///Returns the month value in the Date object using local time.
        ///</summary>
        ///<returns>integer between 0 and 11 indicating the month value in the Date object. The integer returned is not the traditional number used to indicate the month. It is one less. If "Jan 5, 1996 08:47:00" is stored in a Date object, getMonth returns 0.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getMonth() { return default(JsNumber); }
        ///<summary>
        ///Returns the day-of-the-month value in a Date object using local time.
        ///</summary>
        ///<returns> an integer between 1 and 31 that represents the day-of-the-month value in the Date object.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getDate() { return default(JsNumber); }
        ///<summary>
        ///Returns the hours value in a Date object using local time.
        ///</summary>
        ///<returns>an integer between 0 and 23, indicating the number of hours since midnight. A zero occurs in two situations: the time is before 1:00:00 am, or the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getHours() { return default(JsNumber); }
        ///<summary>
        ///Returns the minutes value in a Date object using local time.
        ///</summary>
        ///<returns>integer between 0 and 59 equal to the minutes value stored in the Date object. A zero is returned in two situations: when the time is less than one minute after the hour, or when the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getMinutes() { return default(JsNumber); }
        ///<summary>
        ///Returns the seconds value in a Date object using local time.
        ///</summary>
        ///<returns> integer between 0 and 59 indicating the seconds value of the indicated Date object. A zero is returned in two situations. One occurs when the time is less than one second into the current minute. The other occurs when the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and minutes for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getSeconds() { return default(JsNumber); }
        ///<summary>
        ///Returns the milliseconds value in a Date object using local time.
        ///</summary>
        ///<returns>The millisecond value returned can range from 0-999.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getMilliseconds() { return default(JsNumber); }
        ///<summary>
        ///Sets the month value in the Date object using local time.
        ///</summary>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
        [JsMethod(NativeOverloads = true)]
        public void setMonth(JsNumber numMonth) { }
        ///<summary>
        ///Sets the month value in the Date object using local time.
        ///</summary>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
        ///<param name="dateVal">A numeric value representing the day of the month. If this value is not supplied, the value from a call to the getDate method is used.</param>
        [JsMethod(NativeOverloads = true)]
        public void setMonth(JsNumber numMonth, JsNumber dateVal) { }
        ///<summary>
        ///Sets the hour value in the Date object using local time.
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setHours(JsNumber numHours) { }
        ///<summary>
        ///Sets the hour value in the Date object using local time.
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        ///<param name="numMin">A numeric value equal to the minutes value. </param>
        [JsMethod(NativeOverloads = true)]
        public void setHours(JsNumber numHours, JsNumber numMin) { }
        ///<summary>
        ///Sets the hour value in the Date object using local time.
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        ///<param name="numMin">A numeric value equal to the minutes value. </param>
        ///<param name="numSec">A numeric value equal to the seconds value. </param>
        [JsMethod(NativeOverloads = true)]
        public void setHours(JsNumber numHours, JsNumber numMin, JsNumber numSec) { }
        ///<summary>
        ///Sets the hour value in the Date object using local time.
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        ///<param name="numMin">A numeric value equal to the minutes value. </param>
        ///<param name="numSec">A numeric value equal to the seconds value. </param>
        ///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setHours(JsNumber numHours, JsNumber numMin, JsNumber numSec, JsNumber numMilli) { }
        ///<summary>
        ///Sets the minutes value in the Date object using local time.
        ///</summary>
        ///<param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
        [JsMethod(NativeOverloads = true)]
        public void setMinutes(JsNumber numMinutes) { }
        ///<summary>
        ///Sets the minutes value in the Date object using local time.
        ///</summary>
        ///<param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
        ///<param name="numSeconds">A numeric value equal to the seconds value. Must be supplied if the numMilli argument is used.</param>
        [JsMethod(NativeOverloads = true)]
        public void setMinutes(JsNumber numMinutes, JsNumber numSeconds) { }
        ///<summary>
        ///Sets the minutes value in the Date object using local time.
        ///</summary>
        ///<param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
        ///<param name="numSeconds">A numeric value equal to the seconds value. Must be supplied if the numMilli argument is used.</param>
        ///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setMinutes(JsNumber numMinutes, JsNumber numSeconds, JsNumber numMilli) { }
        ///<summary>
        ///Sets the seconds value in the Date object using local time.
        ///</summary>
        ///<param name="numSeconds">A numeric value equal to the seconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setSeconds(JsNumber numSeconds) { }
        ///<summary>
        ///Sets the seconds value in the Date object using local time.
        ///</summary>
        ///<param name="numSeconds">A numeric value equal to the seconds value.</param>
        ///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setSeconds(JsNumber numSeconds, JsNumber numMilli) { }
        ///<summary>
        ///Sets the milliseconds value in the Date object using local time.
        ///</summary>
        ///<param name="value">A numeric value equal to the millisecond value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setMilliseconds(JsNumber value) { }
        ///<summary>
        ///Sets the date and time value in the Date object.
        ///</summary>
        ///<param name="milliseconds">A numeric value representing the number of elapsed milliseconds since midnight, January 1, 1970 GMT.</param>
        [JsMethod(NativeOverloads = true)]
        public void setTime(JsNumber milliseconds) { }
        ///<summary>
        ///Sets the numeric day of the month in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numDate">A numeric value equal to the day of the month.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCDate(JsNumber numDate) { }
        ///<summary>
        ///Sets the year value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numYear">A numeric value equal to the year.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCFullYear(JsNumber numYear) { }
        ///<summary>
        ///Sets the year value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numYear">A numeric value equal to the year.</param>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCFullYear(JsNumber numYear, JsNumber numMonth) { }
        ///<summary>
        ///Sets the year value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numYear">A numeric value equal to the year.</param>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
        ///<param name="numDate">A numeric value equal to the day of the month.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCFullYear(JsNumber numYear, JsNumber numMonth, JsNumber numDate) { }
        ///<summary>
        ///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCHours(JsNumber numHours) { }
        ///<summary>
        ///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        ///<param name="numMin">A numeric value equal to the minutes value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCHours(JsNumber numHours, JsNumber numMin) { }
        ///<summary>
        ///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        ///<param name="numMin">A numeric value equal to the minutes value.</param>
        ///<param name="numSec">A numeric value equal to the seconds value</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCHours(JsNumber numHours, JsNumber numMin, JsNumber numSec) { }
        ///<summary>
        ///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numHours">A numeric value equal to the hours value.</param>
        ///<param name="numMin">A numeric value equal to the minutes value.</param>
        ///<param name="numSec">A numeric value equal to the seconds value</param>
        ///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCHours(JsNumber numHours, JsNumber numMin, JsNumber numSec, JsNumber numMilli) { }
        ///<summary>
        ///Sets the milliseconds value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numMilli">A numeric value equal to the millisecond value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCMilliseconds(JsNumber numMilli) { }
        ///<summary>
        ///Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numMinutes">A numeric value equal to the minutes value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCMinutes(JsNumber numMinutes) { }
        ///<summary>
        ///Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numMinutes">A numeric value equal to the minutes value.</param>
        ///<param name="numSeconds">A numeric value equal to the seconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCMinutes(JsNumber numMinutes, JsNumber numSeconds) { }
        ///<summary>
        ///Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numMinutes">A numeric value equal to the minutes value.</param>
        ///<param name="numSeconds">A numeric value equal to the seconds value.</param>
        ///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCMinutes(JsNumber numMinutes, JsNumber numSeconds, JsNumber numMilli) { }
        ///<summary>
        ///Sets the month value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCMonth(JsNumber numMonth) { }
        ///<summary>
        ///Sets the month value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
        ///<param name="dateVal">A numeric value representing the day of the month. If it is not supplied, the value from a call to the getUTCDate method is used.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCMonth(JsNumber numMonth, JsNumber dateVal) { }
        ///<summary>
        ///Sets the seconds value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numSeconds">A numeric value equal to the seconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCSeconds(JsNumber numSeconds) { }
        ///<summary>
        ///Sets the seconds value in the Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<param name="numSeconds">A numeric value equal to the seconds value.</param>
        ///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
        [JsMethod(NativeOverloads = true)]
        public void setUTCSeconds(JsNumber numSeconds, JsNumber numMilli) { }
        ///<summary>
        ///Sets the year value in the Date object.
        ///</summary>
        ///<param name="numYear">This method is obsolete, and is maintained for backwards compatibility only. Use the setFullYear method instead. For the years 1900 through 1999, this is a numeric value equal to the year minus 1900. For dates outside that range, this is a 4-digit numeric value.</param>
        [JsMethod(NativeOverloads = true)]
        [Obsolete]
        public void setYear(JsNumber numYear) { }
        ///<summary>
        ///Returns a date as a JsString value.
        ///</summary>
        ///<returns>A JsString value containing the date, in the current time zone, in a convenient, easily read format.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toDateString() { return default(JsString); }
        ///<summary>
        ///Returns a date converted to a JsString using Greenwich Mean Time(GMT).
        ///Obsolete, and is provided for backwards compatibility only. It is recommended that you use the toUTCString method instead.
        ///</summary>setyear
        ///<returns>A String object that contains the date formatted using GMT convention. The format of the return value is as follows: "05 Jan 1996 00:00:00 GMT."</returns>
        [Obsolete]
        [JsMethod(NativeOverloads = true)]
        public JsString toGMTString() { return default(JsString); }
        ///<summary>
        ///Used by the JSON.stringify method to enable the transformation of an object's data of before the JSON serialization.
        ///</summary>
        ///<returns>Returns an ISO-formatted date JsString for the UTC time zone (denoted by the suffix Z).</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toJSON() { return default(JsString); }
        ///<summary>
        ///Returns a date as a JsString value appropriate to the host environment's current locale.
        ///</summary>
        ///<returns>A JsString value that contains a date, in the current time zone, in an easily read format. The date is in the default format of the host environment's current locale. The return value of this method cannot be relied upon in scripting, as it will vary from computer to computer. The toLocaleDateString method should only be used to format display – never as part of a computation.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toLocaleDateString() { return default(JsString); }
        ///<summary>
        ///Returns a time as a JsString value appropriate to the host environment's current locale.
        ///</summary>
        ///<returns>A JsString value that contains a time, in the current time zone, in an easily read format. The time is in the default format of the host environment's current locale. The return value of this method cannot be relied upon in scripting, as it will vary from computer to computer. The toLocaleTimeString method should only be used to format display – never as part of a computation.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toLocaleTimeString() { return default(JsString); }
        ///<summary>
        ///Returns a time as a JsString value.
        ///</summary>
        ///<returns>A JsString value containing the time, in the current time zone, in a convenient, easily read format.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toTimeString() { return default(JsString); }
        ///<summary>
        ///Returns a date converted to a JsString using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>A String object that contains the date formatted using UTC convention in a convenient, easily read form.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toUTCString() { return default(JsString); }
        ///<summary>
        ///Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
        ///</summary>
        ///<param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
        ///<param name="month">The month as an integer between 0 and 11 (January to December).</param>
        ///<param name="day"> The date as an integer between 1 and 31.</param>
        ///<returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsString UTC(JsNumber year, JsNumber month, JsNumber day) { return default(JsString); }
        ///<summary>
        ///Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
        ///</summary>
        ///<param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
        ///<param name="month">The month as an integer between 0 and 11 (January to December).</param>
        ///<param name="day"> The date as an integer between 1 and 31.</param>
        ///<param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
        ///<returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsString UTC(JsNumber year, JsNumber month, JsNumber day, JsNumber hours) { return default(JsString); }
        ///<summary>
        ///Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
        ///</summary>
        ///<param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
        ///<param name="month">The month as an integer between 0 and 11 (January to December).</param>
        ///<param name="day"> The date as an integer between 1 and 31.</param>
        ///<param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
        ///<param name="minutes"> An integer from 0 to 59 that specifies the minutes.</param>
        ///<returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsString UTC(JsNumber year, JsNumber month, JsNumber day, JsNumber hours, JsNumber minutes) { return default(JsString); }
        ///<summary>
        ///Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
        ///</summary>
        ///<param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
        ///<param name="month">The month as an integer between 0 and 11 (January to December).</param>
        ///<param name="day"> The date as an integer between 1 and 31.</param>
        ///<param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
        ///<param name="minutes"> An integer from 0 to 59 that specifies the minutes.</param>
        ///<param name="seconds">An integer from 0 to 59 that specifies the seconds.</param>
        ///<returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsString UTC(JsNumber year, JsNumber month, JsNumber day, JsNumber hours, JsNumber minutes, JsNumber seconds) { return default(JsString); }
        ///<summary>
        ///Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
        ///</summary>
        ///<param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
        ///<param name="month">The month as an integer between 0 and 11 (January to December).</param>
        ///<param name="day"> The date as an integer between 1 and 31.</param>
        ///<param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
        ///<param name="minutes"> An integer from 0 to 59 that specifies the minutes.</param>
        ///<param name="seconds">An integer from 0 to 59 that specifies the seconds.</param>
        ///<param name="ms">An integer from 0 to 999 that specifies the milliseconds.</param>
        ///<returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsString UTC(JsNumber year, JsNumber month, JsNumber day, JsNumber hours, JsNumber minutes, JsNumber seconds, JsNumber ms) { return default(JsString); }
        ///<summary>
        ///Returns the primitive value of the specified object.
        ///</summary>
        ///<returns>The stored time value in milliseconds since midnight, January 1, 1970 UTC.</returns>
        [JsMethod(NativeOverloads = true)]
        public new JsNumber valueOf() { return default(JsNumber); }
        [JsMethod(NativeOverloads = true)]
        public JsDate addDays(JsNumber days) { return default(JsDate); }
        [JsMethod(NativeOverloads = true)]
        public JsDate addMonths(JsNumber months) { return default(JsDate); }
        [JsMethod(NativeOverloads = true)]
        public JsDate removeTime() { return default(JsDate); }
        ///<summary>
        ///Returns the time value in a Date object. 
        ///</summary>
        ///<returns>
        ///An integer value representing the number of milliseconds between midnight, January 1, 1970 and the time value in the Date object. 
        ///The range of dates is approximately 285,616 years from either side of midnight, January 1, 1970. 
        ///Negative numbers indicate dates prior to 1970. </returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getTime() { return default(JsNumber); }
        ///<summary>
        ///Returns the day of the week value in a Date object using local time.
        ///</summary>
        ///<returns>an integer between 0 and 6 representing the day of the week and corresponds to a day of the week as follows: 
        ///0 Sunday 1 Monday 2 Tuesday 3 Wednesday 4 Thursday 5 Friday 6 Saturday</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getDay() { return default(JsNumber); }
        ///<summary>
        ///Returns the difference in minutes between the time on the host computer and Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>An integer value representing the number of minutes between the time on the current machine and UTC. These values are appropriate to the computer the script is executed on. If it is called from a server script, the return value is appropriate to the server. If it is called from a client script, the return value is appropriate to the client.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getTimezoneOffset() { return default(JsNumber); }
        ///<summary>
        ///Returns the day-of-the-month value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>an integer between 1 and 31 that represents the day-of-the-month value in the Date object.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCDate() { return default(JsNumber); }
        ///<summary>
        ///Returns the day of the week value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>an integer between 0 and 6 representing the day of the week and corresponds to a day of the week as follows: 
        ///0 Sunday 1 Monday 2 Tuesday 3 Wednesday 4 Thursday 5 Friday 6 Saturday</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCDay() { return default(JsNumber); }
        ///<summary>
        ///Returns the year value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>The year as an absolute number. This avoids the year 2000 problem where dates beginning with January 1, 2000 are confused with those beginning with January 1, 1900.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCFullYear() { return default(JsNumber); }
        ///<summary>
        ///Returns the hours value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>An integer between 0 and 23 indicating the number of hours since midnight. A zero occurs in two situations: the time is before 1:00:00 A.M., or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCHours() { return default(JsNumber); }
        ///<summary>
        ///Returns the milliseconds value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>The millisecond value returned can range from 0-999.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCMilliseconds() { return default(JsNumber); }
        ///<summary>
        ///Returns the minutes value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>An integer between 0 and 59 equal to the number of minutes value in the Date object. A zero occurs in two situations: the time is less than one minute after the hour, or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCMinutes() { return default(JsNumber); }
        ///<summary>
        ///Returns the month value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>An integer between 0 and 11 indicating the month value in the Date object. The integer returned is not the traditional number used to indicate the month. It is one less. If "Jan 5, 1996 08:47:00.0" is stored in a Date object, getUTCMonth returns 0.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCMonth() { return default(JsNumber); }
        ///<summary>
        ///Returns the seconds value in a Date object using Universal Coordinated Time (UTC).
        ///</summary>
        ///<returns>An integer between 0 and 59 indicating the seconds value of the indicated Date object. A zero occurs in two situations: the time is less than one second into the current minute, or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and hours for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object..</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber getUTCSeconds() { return default(JsNumber); }
        ///<summary>
        ///Returns the year value in a Date object. This method is obsolete, and is provided for backwards compatibility only. Use the getFullYear method instead. For the years 1900 though 1999, the year is a 2-digit integer value returned as the difference between the stored year and 1900. For dates outside that period, the 4-digit year is returned. For example, 1996 is returned as 96, but 1825 and 2025 are returned as-is.
        ///</summary>
        [Obsolete]
        [JsMethod(NativeOverloads = true)]
        public JsNumber getYear() { return default(JsNumber); }
        ///<summary>
        ///Parses a JsString containing a date, and returns the number of milliseconds between that date and midnight, January 1, 1970.
        ///</summary>
        ///<param name="dateVal">Either a JsString containing a date in a format such as "Jan 5, 1996 08:47:00" or a VT_DATE value retrieved from an ActiveX® object or other object.</param>
        ///<returns>An integer value representing the number of milliseconds between midnight, January 1, 1970 and the date supplied in dateVal.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber Parse(JsString dateVal) { return default(JsNumber); }
        ///<summary>
        ///Sets the numeric day-of-the-month value of the Date object using local time.
        ///</summary>
        ///<param name="numDate">A numeric value equal to the day of the month.</param>
        [JsMethod(NativeOverloads = true)]
        public void setDate(JsNumber numDate) { }
        ///<summary>
        ///Sets the year value in the Date object using local time.
        ///</summary>
        ///<param name="numYear">A numeric value equal to the year.</param>
        [JsMethod(NativeOverloads = true)]
        public void setFullYear(JsNumber numYear) { }
        ///<summary>
        ///Sets the year value in the Date object using local time.
        ///</summary>
        ///<param name="numYear">A numeric value equal to the year.</param>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
        [JsMethod(NativeOverloads = true)]
        public void setFullYear(JsNumber numYear, JsNumber numMonth) { }
        ///<summary>
        ///Sets the year value in the Date object using local time.
        ///</summary>
        ///<param name="numYear">A numeric value equal to the year.</param>
        ///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
        ///<param name="numdate">A numeric value equal to the day of the month.</param>
        [JsMethod(NativeOverloads = true)]
        public void setFullYear(JsNumber numYear, JsNumber numMonth, JsNumber numdate) { }
    }
    #endregion
    #region JsError
    [JsType(JsMode.Prototype, Export = false, Name = "Error")]
    public partial class JsError : JsObject
    {
        public JsError() { }
        public JsError(JsString s) { }
        ///<summary>
        ///Returns or sets the descriptive JsString associated with a specific error.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsString description { get; set; }
        ///<summary>
        ///Returns an error message JsString.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsString message { get; set; }
        /// <summary>
        /// Returns the name of an error.
        /// When a runtime error occurs, the name property is set to one of the following native exception types:
        /// ConversionError		This error occurs whenever there is an attempt to convert an object into something to which it cannot be converted.
        /// RangeError				This error occurs when a function is supplied with an argument that has exceeded its allowable range. For example, this error occurs if you attempt to construct an Array object with a length that is not a valid positive integer.
        /// ReferenceError		This error occurs when an invalid reference has been detected. This error will occur, for example, if an expected reference is null.
        /// RegExpError				This error occurs when a compilation error occurs with a regular expression. Once the regular expression is compiled, however, this error cannot occur. This example will occur, for example, when a regular expression is declared with a pattern that has an invalid syntax, or flags other than i, g, or m, or if it contains the same flag more than once.
        ///	SyntaxError				This error occurs when source text is parsed and that source text does not follow correct syntax. This error will occur, for example, if the eval function is called with an argument that is not valid program text.
        ///	TypeError					This error occurs whenever the actual type of an operand does not match the expected type. An example of when this error occurs is a function call made on something that is not an object or does not support the call.
        ///	URIError					This error occurs when an illegal Uniform Resource Indicator (URI) is detected. For example, this is error occurs when an illegal character is found in a JsString being encoded or decoded.
        /// </summary>
        [JsProperty(NativeField = true)]
        public JsString name { get; set; }
        ///<summary>
        ///Returns or sets the numeric value associated with a specific error. The Error object's default property is number.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsString number { get; set; }
    }
    #endregion
    #region JsFunction
    [JsType(JsMode.Prototype, Export = false, Name = "Function")]
    public partial class JsFunction : JsObject
    {
        public JsFunction(params JsString[] prmsAndBody) { }
        ///<summary>
        ///Calls a method of an object, substituting another object for the current object.
        ///</summary>
        ///<param name="thisArg">The object to be used as the current object.</param>
        ///<param name="args">List of arguments to be passed to the method.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public object call(object thisArg, params object[] args) { return default(object); }
        ///<summary>
        ///Calls a method of an object, substituting another object for the current object.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public object call() { return default(object); }
        ///<summary>
        ///Calls a method of an object, substituting another object for the current object.
        ///</summary>
        ///<param name="thisArg">The object to be used as the current object.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public object call(object thisArg) { return default(object); }
        ///<summary>
        ///Applies a method of an object, substituting another object for the current object.
        ///</summary>
        ///<param name="thisArg">The object to be used as the current object.</param>
        ///<param name="args">Array of arguments to be passed to the function.</param>
        ///<returns>The return value of the function</returns>
        [JsMethod(NativeOverloads = true)]
        public object apply(object thisArg, object[] args) { return default(object); }
        ///<summary>
        ///Applies a method of an object, substituting another object for the current object.
        ///</summary>
        ///<param name="obj">The object to be used as the current object.</param>
        ///<returns>The return value of the function</returns>
        [JsMethod(NativeOverloads = true)]
        public object apply(object obj) { return default(object); }

        /// <summary>
        /// Returns a reference to the function that invoked the current function.
        /// </summary>
        public JsFunction caller { get; set; }

        ///<summary>
        ///Returns a reference to the prototype for a class of objects.
        ///</summary>
        public JsObject prototype;


    }
    #endregion
    #region JsMath
    [JsType(Export = false, Name = "Math")]
    public static partial class JsMath
    {
        ///<summary>
        ///Returns the mathematical constant e, the base of natural logarithms. The E property is approximately equal to 2.718.
        ///</summary>
        public readonly static JsNumber E;
        ///<summary>
        ///Returns the natural logarithm of 2.
        ///</summary>
        public readonly static JsNumber LN2;
        ///<summary>
        ///Returns the natural logarithm of 10.
        ///</summary>
        public readonly static JsNumber LN10;
        ///<summary>
        ///Returns the base-2 logarithm of e, Euler's number.
        ///</summary>
        public readonly static JsNumber LOG2E;
        ///<summary>
        ///Returns the base-10 logarithm of e, Euler's number.
        ///</summary>
        public readonly static JsNumber LOG10E;
        ///<summary>
        ///Returns the ratio of the circumference of a circle to its diameter, approximately 3.141592653589793.
        ///</summary>
        public readonly static JsNumber PI;
        ///<summary>
        ///Returns the square root of 0.5, or one divided by the square root of 2.
        ///</summary>
        public readonly static JsNumber SQRT1_2;
        ///<summary>
        ///Returns the square root of 2.
        ///</summary>
        public readonly static JsNumber SQRT2;
        ///<summary>
        ///Returns the absolute value of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the absolute value is needed</param>
        ///<returns>The absolute value of the number argument</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber abs(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the arccosine of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the arccosine is needed.</param>
        ///<returns>the arccosine of the number argument.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber acos(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the arcsine of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the arcsine is needed.</param>
        ///<returns>The arcsine of its numeric argument.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber asin(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the arctangent of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the arctangent is needed.</param>
        ///<returns>The return value is the arctangent of its numeric argument.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber atan(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the angle (in radians) from the X axis to a point (y,x).
        ///</summary>
        ///<param name="y">A numeric expression representing the cartesian x-coordinate.</param>
        ///<param name="x">A numeric expression representing the cartesian y-coordinate.</param>
        ///<returns>The return value is between -pi and pi, representing the angle of the supplied (y,x) point.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber atan2(JsNumber y, JsNumber x) { return default(JsNumber); }
        ///<summary>
        ///Returns the smallest integer greater than or equal to its numeric argument.
        ///</summary>
        ///<param name="number">A numeric expression.</param>
        ///<returns>An integer value equal to the smallest integer greater than or equal to its numeric argument.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber ceil(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the cosine of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the cosine is needed.</param>
        ///<returns>The return value is the cosine of its numeric argument.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber cos(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns e (the base of natural logarithms) raised to a power.
        ///</summary>
        ///<param name="number">A numeric expression representing the power of e.</param>
        ///<returns>The return value is a number. The constant e is Euler's number, approximately equal to 2.71828 and number is the supplied argument.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber exp(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the greatest integer less than or equal to its numeric argument.
        ///</summary>
        ///<param name="number">A numeric expression.</param>
        ///<returns>An integer value equal to the greatest integer less than or equal to its numeric argument.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber floor(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the natural logarithm of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the natural logarithm is sought.</param>
        ///<returns>The return value is the natural logarithm of number. The base is e.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber log(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the greater of zero or more supplied numeric expressions.
        ///</summary>
        ///<param name="numbers">Numeric expressions to be evaluated</param>
        ///<returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber max(params JsNumber[] numbers) { return default(JsNumber); }
        ///<summary>
        ///Returns the lesser of zero or more supplied numeric expressions.
        ///</summary>
        ///<param name="numbers">Numeric expressions to be evaluated</param>
        ///<returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber min(params JsNumber[] numbers) { return default(JsNumber); }
        ///<summary>
        ///Returns the value of a base expression taken to a specified power.
        ///</summary>
        ///<param name="base">The base value of the expression.</param>
        ///<param name="exponent">The exponent value of the expression.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber pow(JsNumber @base, JsNumber exponent) { return default(JsNumber); }
        ///<summary>
        ///Returns a pseudorandom number between 0 and 1.
        ///</summary>
        ///<returns>The pseudorandom number generated is from 0 (inclusive) to 1 (exclusive), that is, the returned number can be zero, but it will always be less than one.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber random() { return default(JsNumber); }
        ///<summary>
        ///Returns a supplied numeric expression rounded to the nearest integer.
        ///</summary>
        ///<param name="number">The value to be rounded to the nearest integer.</param>
        ///<returns>For positive numbers, if the decimal portion of number is 0.5 or greater, 
        ///the return value is equal to the smallest integer greater than number. If the 
        ///decimal portion is less than 0.5, the return value is the largest integer less than 
        ///or equal to number. For negative numbers, if the decimal portion is exactly -0.5, 
        ///the return value is the smallest integer that is greater than the number.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber round(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the sine of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the sine is needed</param>
        ///<returns>The sine of the numeric argument</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber sin(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the square root of a number.
        ///</summary>
        ///<param name="number">A numeric expression.</param>
        ///<returns>If number is negative, the return value is NaN.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber sqrt(JsNumber number) { return default(JsNumber); }
        ///<summary>
        ///Returns the tangent of a number.
        ///</summary>
        ///<param name="number">A numeric expression for which the tangent is sought.</param>
        ///<returns>The tangent of number.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsNumber tan(JsNumber number) { return default(JsNumber); }
    }
    #endregion
    #region JsNumber
    ///<summary>
    ///An object representation of the number data type and placeholder for numeric constants.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Number")]
    public partial class JsNumber : JsObject, IConvertible, IComparable, IComparable<JsNumber>, IEquatable<JsNumber>, IFormattable
    {
        public JsNumber(double d) { }
        public static implicit operator double(JsNumber number) { return default(double); }
        public static implicit operator decimal(JsNumber number) { return default(decimal); }
        public static implicit operator int(JsNumber number) { return default(int); }
        public static implicit operator float(JsNumber number) { return default(float); }
        public static implicit operator JsNumber(decimal d) { return default(JsNumber); }
        public static implicit operator JsNumber(double d) { return default(JsNumber); }
        public static implicit operator JsNumber(sbyte d) { return default(JsNumber); }
        public static implicit operator JsNumber(int d) { return default(JsNumber); }
        public static JsBoolean operator ==(JsNumber x, JsNumber y) { return default(JsBoolean); }
        public static JsBoolean operator !=(JsNumber x, JsNumber y) { return default(JsBoolean); }
        public static JsNumber operator ++(JsNumber x) { return default(JsNumber); }
        public static JsNumber operator --(JsNumber x) { return default(JsNumber); }
        //[EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) { return default(bool); }
        //[EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() { return default(int); }
        //[EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() { return default(string); }
        int IComparable.CompareTo(object obj) { return default(int); }
        static int Compare(JsNumber x, JsNumber y) { return default(int); }
        TypeCode IConvertible.GetTypeCode() { return default(TypeCode); }
        bool IConvertible.ToBoolean(IFormatProvider provider) { return default(bool); }
        byte IConvertible.ToByte(IFormatProvider provider) { return default(byte); }
        char IConvertible.ToChar(IFormatProvider provider) { return default(char); }
        DateTime IConvertible.ToDateTime(IFormatProvider provider) { return default(DateTime); }
        decimal IConvertible.ToDecimal(IFormatProvider provider) { return default(decimal); }
        double IConvertible.ToDouble(IFormatProvider provider) { return default(double); }
        short IConvertible.ToInt16(IFormatProvider provider) { return default(short); }
        int IConvertible.ToInt32(IFormatProvider provider) { return default(int); }
        long IConvertible.ToInt64(IFormatProvider provider) { return default(long); }
        sbyte IConvertible.ToSByte(IFormatProvider provider) { return default(sbyte); }
        float IConvertible.ToSingle(IFormatProvider provider) { return default(float); }
        string IConvertible.ToString(IFormatProvider provider) { return default(string); }
        object IConvertible.ToType(Type type, IFormatProvider provider) { return default(object); }
        ushort IConvertible.ToUInt16(IFormatProvider provider) { return default(ushort); }
        uint IConvertible.ToUInt32(IFormatProvider provider) { return default(uint); }
        ulong IConvertible.ToUInt64(IFormatProvider provider) { return default(ulong); }
        int IComparable<JsNumber>.CompareTo(JsNumber other) { return default(int); }
        bool IEquatable<JsNumber>.Equals(JsNumber other) { return default(bool); }
        string IFormattable.ToString(string format, IFormatProvider formatProvider) { return default(string); }
        ///<summary>
        ///Returns the largest number representable in JScript. Equal to approximately 1.79E+308.
        ///</summary>
        public readonly static JsNumber MAX_VALUE;
        ///<summary>
        ///Returns the number closest to zero representable in JScript. Equal to approximately 5.00E-324.
        ///</summary>
        public readonly static JsNumber MIN_VALUE;
        ///<summary>
        ///A special value that indicates an arithmetic expression returned a value that was not a number.
        ///</summary>
        public readonly static JsNumber NaN;
        ///<summary>
        ///Returns a value more negative than the largest negative number.
        ///</summary>
        public readonly static JsNumber NEGATIVE_INFINITY;
        ///<summary>
        ///Returns a value larger than the largest number.
        ///</summary>
        public readonly static JsNumber POSITIVE_INFINITY;
        ///<summary>
        ///Returns a JsString containing a number represented in exponential notation.
        ///</summary>
        ///<param name="fractionDigits">Number of digits after the decimal point. Must be in the range 0 – 20, inclusive.</param>
        ///<returns>A JsString representation of a number in exponential notation. The JsString contains one digit before the significand's decimal point, and may contain fractionDigits digits after it. If fractionDigits is not supplied, the toExponential method returns as many digits necessary to uniquely specify the number.</returns>
        public JsString toExponential(int fractionDigits) { return default(JsString); }
        ///<summary>
        ///Returns a JsString containing a number represented in exponential notation.
        ///</summary>
        ///<returns>A JsString representation of a number in exponential notation. The JsString contains one digit before the significand's decimal point, and may contain fractionDigits digits after it. If fractionDigits is not supplied, the toExponential method returns as many digits necessary to uniquely specify the number.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toExponential() { return default(JsString); }
        ///<summary>
        ///Returns a JsString containing a number represented either in exponential or fixed-point notation with a specified number of digits.
        ///</summary>
        ///<param name="precision">Number of significant digits. Must be in the range 1 – 21, inclusive.</param>
        ///<returns>For numbers in exponential notation, precision - 1 digits are returned after the decimal point. For numbers in fixed notation, precision significant digits are returned.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toPrecision(int precision) { return default(JsString); }
        ///<summary>
        ///Returns a JsString containing a number represented either in exponential or fixed-point notation with a specified number of digits.
        ///</summary>
        ///<returns>For numbers in exponential notation, precision - 1 digits are returned after the decimal point. For numbers in fixed notation, precision significant digits are returned.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toPrecision() { return default(JsString); }
        ///<summary>
        ///Returns a JsString representation of an object.
        ///</summary>
        ///<returns>Returns the textual representation of the number.</returns>
        [JsMethod(NativeOverloads = true)]
        public new JsString toString() { return default(JsString); }
        ///<summary>
        ///Returns a JsString representation of an object.
        ///</summary>
        ///<param name="radix">Specifies a radix for converting numeric values to strings. This value is only used for numbers.</param>
        ///<returns>Returns the textual representation of the number.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toString(int radix) { return default(JsString); }
        ///<summary>
        ///Returns the primitive value of the specified object.
        ///</summary>
        ///<returns>The numeric value.</returns>
        [JsMethod(NativeOverloads = true)]
        public new double valueOf() { return default(double); }
        ///<summary>
        ///The toFixed() method formats a number to use a specified number of trailing decimals.
        ///The number is rounded up, and nulls are added after the decimal point (if needed), to create the desired decimal length.
        ///</summary>
        ///<returns></returns>
        public JsString toFixed() { return default(JsString); }
        ///<summary>
        ///The toFixed() method formats a number to use a specified number of trailing decimals.
        ///The number is rounded up, and nulls are added after the decimal point (if needed), to create the desired decimal length.
        ///</summary>
        ///<param name="x">The number of digits after the decimal point. Default is 0 (no digits after the decimal point)</param>
        ///<returns></returns>
        public JsString toFixed(int x) { return default(JsString); }
    }
    #endregion
    #region JsObject
    [JsType(JsMode.Prototype, Export = false, Name = "Object")]
    public partial class JsObject : IEnumerable<JsString>
    {
        ///<summary>
        ///Watches for a property to be assigned a value and runs a function when that occurs.
        ///Watches for assignment to a property named prop in this object, calling handler(prop, oldval, newval) whenever prop is set and storing the return value in that property. A watchpoint can filter (or nullify) the value assignment, by returning a modified newval (or by returning oldval).
        ///If you delete a property for which a watchpoint has been set, that watchpoint does not disappear. If you later recreate the property, the watchpoint is still in effect.
        ///To remove a watchpoint, use the unwatch method. By default, the watch method is inherited by every object descended from Object.
        ///The JavaScript debugger has functionality similar to that provided by this method, as well as other debugging options. For information on the debugger, see Venkman.
        ///In NES 3.0 and 4.x, handler is called from native code as well as assignments in script. In Firefox, handler is only called from assignments in script, not from native code. For example, window.watch('location', myHandler) will not call myHandler if the user clicks a link to an anchor within the current document. However, window.location += '#myAnchor' will call myHandler:
        ///</summary>
        ///<param name="prop">The name of a property of the object.</param>
        ///<param name="handler">A function to call.</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4)]
        public virtual void watch(JsString prop, Action handler) { }
        ///<summary>
        ///Removes a watchpoint set with the watch method
        ///The JavaScript debugger has functionality similar to that provided by this method, as well as other debugging options. For information on the debugger, see Venkman.
        ///By default, this method is inherited by every object descended from Object.
        ///</summary>
        ///<param name="prop">The name of a property of the object.</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4)]
        public virtual void unwatch(JsString prop) { }
        ///<summary>
        ///Returns the primitive value of the specified object.
        ///The required object reference is any intrinsic JScript object.
        ///The valueOf method is defined differently for each intrinsic JScript object.
        ///Object
        ///Return Value
        ///Array
        ///Returns the array instance.
        ///Boolean
        ///The Boolean value.
        ///Date
        ///The stored time value in milliseconds since midnight, January 1, 1970 UTC.
        ///Function
        ///The function itself.
        ///Number
        ///The numeric value.
        ///Object
        ///The object itself. This is the default.
        ///String
        ///The JsString value.
        ///The Math and Error objects do not have a valueOf method.
        ///</summary>
        ///<returns></returns>
        public virtual object valueOf() { return default(object); }
        public JsObject() { }
        public JsObject(object json) { }
        public JsObject constructor;
        [JsProperty(NativeIndexer = true)]
        public object this[JsString name] { get { return default(object); } set { } }
        ///<summary>
        ///Returns a Boolean value indicating whether an object exists in another object's prototype chain.
        ///</summary>
        ///<param name="object2">Another object whose prototype chain is to be checked.</param>
        ///<returns>true if object2 has object1 in its prototype chain. The prototype chain is used to share functionality between instances of the same object type. The isPrototypeOf method returns false when object2 is not an object or when object1 does not appear in the prototype chain of the object2.</returns>
        public virtual JsBoolean isPrototypeOf(object object2) { return default(JsBoolean); }
        ///<summary>
        ///Returns a Boolean value indicating whether an object has a property with the specified name.
        ///</summary>
        ///<param name="proName">String value of a property name.</param>
        ///<returns> true if object has a property of the specified name, false if it does not. This method does not check if the property exists in the object's prototype chain; the property must be a member of the object itself.</returns>
        public virtual JsBoolean hasOwnProperty(JsString proName) { return default(JsBoolean); }
        ///<summary>
        ///Returns a JsString representation of an object.
        ///</summary>
        ///<returns>Returns "[object objectname]", where objectname is the name of the object type.</returns>
        public virtual JsString toString() { return default(JsString); }
        IEnumerator<JsString> IEnumerable<JsString>.GetEnumerator() { return default(IEnumerator<JsString>); }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    #endregion
    #region JsObject<T>
    [JsType(JsMode.Prototype, Export = false, Name = "Object")]
    public partial class JsObject<T> : JsObject
    {
        [JsMethod(IgnoreGenericArguments = true)]
        public JsObject() { }
        [JsProperty(NativeIndexer = true)]
        public new T this[JsString name] { get { return default(T); } set { } }
    }
    #endregion
    #region JsObject<K, T>

    [JsType(JsMode.Prototype, Export = false, Name = "Object", IgnoreGenericTypeArguments = true)]
    public class JsObject<K, T> : JsObject
    {
        [JsMethod(IgnoreGenericArguments = true)]
        public JsObject() { }
        [JsProperty(NativeIndexer = true)]
        public T this[K key] { get { return default(T); } set { } }
        [JsProperty(NativeIndexer = true)]
        public new T this[JsString key] { get { return default(T); } set { } }
    }
    #endregion

    #region JsRegExp
    ///<summary>
    ///An object that contains a regular expression pattern along with flags that identify how to apply the pattern.
    ///re = /pattern/[flags]
    ///re = new RegExp("pattern"[,"flags"]) 
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "RegExp")]
    public partial class JsRegExp : JsObject
    {
        public JsRegExp(JsString pattern) { }
        public JsRegExp(JsString pattern, JsString flags) { }
        [JsMethod(NativeOverloads = true)]
        public JsBoolean test(JsString ch) { return default(JsBoolean); }
        ///<summary>
        ///If the exec method does not find a match, it returns null. If it finds a match, exec returns an array, and the properties of the global RegExp object are updated to reflect the results of the match. Element zero of the array contains the entire match, while elements 1 – n contain any submatches that have occurred within the match. This behavior is identical to the behavior of the match method without the global flag (g) set. 
        ///If the global flag is set for a regular expression, exec searches the JsString beginning at the position indicated by the value of lastIndex. If the global flag is not set, exec ignores the value of lastIndex and searches from the beginning of the JsString. 
        ///</summary>
        ///<param name="text">The String object or JsString literal on which to perform the search</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsRegExpResult exec(JsString text) { return default(JsRegExpResult); }
    }
    #endregion
    #region JsRegExpResult
    public partial class JsRegExpResult : JsArray<JsString>
    {
        ///<summary>
        ///Returns the JsString against which a regular expression search was performed. Read-only.
        ///</summary>
        public readonly JsString input;
        ///<summary>
        ///Returns the character position where the first successful match begins in a searched JsString. Read-only.
        ///</summary>
        public readonly JsNumber index;
        ///<summary>
        ///Returns the character position where the next match begins in a searched JsString.
        ///</summary>
        public readonly JsNumber lastIndex;
        ///<summary>
        ///Returns the last matched characters from any regular expression search. Read-only.
        ///</summary>
        public readonly JsString lastMatch;
        ///<summary>
        ///Returns the last parenthesized submatch from any regular expression search, if any. Read-only.
        ///</summary>
        public readonly JsString lastParen;
        ///<summary>
        ///Returns the characters from the beginning of a searched JsString up to the position before the beginning of the last match. Read-only.
        ///</summary>
        public readonly JsString leftContext;
        ///<summary>
        ///Returns the characters from the position following the last match to the end of the searched JsString. Read-only.
        ///</summary>
        public readonly JsString rightContext;
    }
    #endregion
    #region JsString
    ///<summary>
    ///Allows manipulation and formatting of text strings and determination and location of substrings within strings.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "String")]
    public partial class JsString : JsObject
    {
        public JsString() { }
        public JsString(object obj) { }
        public static implicit operator JsString(string s) { return default(JsString); }
        public static implicit operator string(JsString s) { return default(string); }
        public static JsString operator +(JsString x, JsString y) { return default(JsString); }
        public static JsString operator +(JsString x, string y) { return default(JsString); }
        public static JsString operator +(string x, JsString y) { return default(JsString); }
        ///<summary>
        ///Returns the last occurrence of a substring within a String object.
        ///</summary>
        ///<param name="sub">The char to search for within the String object.</param>
        ///<returns> an integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned. If startindex is negative, startindex is treated as zero. If it is larger than the greatest character position index, it is treated as the largest possible index.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber lastIndexOf(char sub) { return default(JsNumber); }
        ///<summary>
        ///Returns the last occurrence of a substring within a String object.
        ///</summary>
        ///<param name="sub">The string to search for within the String object.</param>
        ///<returns> an integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned. If startindex is negative, startindex is treated as zero. If it is larger than the greatest character position index, it is treated as the largest possible index.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber lastIndexOf(JsString sub) { return default(JsNumber); }
        ///<summary>
        ///Returns the last occurrence of a substring within a String object.
        ///</summary>
        ///<param name="substring">The substring to search for within the String object.</param>
        ///<param name="startindex">Integer value specifying the index to begin searching within the String object. If omitted, searching begins at the end of the string.</param>
        ///<returns> an integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned. If startindex is negative, startindex is treated as zero. If it is larger than the greatest character position index, it is treated as the largest possible index.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber lastIndexOf(JsString substring, JsNumber startindex) { return default(JsNumber); }
        [JsMethod(NativeOverloads = true)]
        public JsBoolean startsWith(JsString start) { return default(JsBoolean); }
        [JsMethod(NativeOverloads = true)]
        public JsBoolean endsWith(JsString end) { return default(JsBoolean); }
        [JsMethod(NativeOverloads = true)]
        public JsString substring(JsNumber index) { return default(JsString); }
        [JsMethod(NativeOverloads = true)]
        public JsString substring(JsNumber index, JsNumber length) { return default(JsString); }
        [JsMethod(NativeOverloads = true)]
        public JsString substr(JsNumber start, JsNumber end) { return default(JsString); }
        [JsMethod(NativeOverloads = true)]
        public JsString substr(JsNumber start) { return default(JsString); }
        [JsMethod(NativeOverloads = true)]
        public JsArray<JsString> split(JsRegExp re) { return default(JsArray<JsString>); }
        [JsMethod(NativeOverloads = true)]
        public JsArray<JsString> split(char sep) { return default(JsArray<JsString>); }
        [JsMethod(NativeOverloads = true)]
        public JsArray<JsString> split(JsString sep) { return default(JsArray<JsString>); }
        ///<summary>
        ///Returns the character position where the first occurrence of a substring occurs within a String object.
        ///</summary>
        ///<param name="subString">Substring to search for within the String object.</param>
        ///<returns>An integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber indexOf(JsString subString) { return default(JsNumber); }
        ///<summary>
        ///Returns the character position where the first occurrence of a substring occurs within a String object.
        ///</summary>
        ///<param name="subString">Substring to search for within the String object.</param>
        ///<param name="startIndex">Integer value specifying the index to begin searching within the String object. If omitted, searching starts at the beginning of the string.</param>
        ///<returns>An integer value indicating the beginning of the substring within the String object. If the substring is not found, a -1 is returned.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber indexOf(JsString subString, JsNumber startIndex) { return default(JsNumber); }
        ///<summary>
        ///Returns the position of the first substring match in a regular expression search.
        ///</summary>
        ///<param name="regExp">An instance of a Regular Expression object containing the regular expression pattern and applicable flags.</param>
        ///<returns>The search method indicates if a match is present or not. If a match is found, the search method returns an integer value that indicates the offset from the beginning of the string where the match occurred. If no match is found, it returns -1.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber search(JsRegExp regExp) { return default(JsNumber); }
        ///<summary>
        ///Returns the position of the first substring match in a regular expression search.
        ///</summary>
        ///<param name="searchText">The String object or string literal on which to perform the search.</param>
        ///<returns>The search method indicates if a match is present or not. If a match is found, the search method returns an integer value that indicates the offset from the beginning of the string where the match occurred. If no match is found, it returns -1.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber search(string searchText) { return default(JsNumber); }
        ///<summary>
        ///Returns a copy of a string with text replaced using a regular expression or search string. 
        ///</summary>
        ///<param name="regExp">An instance of a Regular Expression object containing the regular expression pattern and applicable flags. </param>
        ///<param name="replaceText">Required. A String object or string literal containing the text to replace for every successful match of rgExp in stringObj. In JScript 5.5 or later, the replaceText argument can also be a function that returns the replacement text. </param>
        ///<returns>The result of the replace method is a copy of stringObj after the specified replacements have been made. </returns>
        [JsMethod(NativeOverloads = true)]
        public JsString replace(JsRegExp regExp, string replaceText) { return default(JsString); }
        ///<summary>
        ///Returns a copy of a string with text replaced using a regular expression or search string. 
        ///</summary>
        ///<param name="searchText">String object or literal that is converted to a string, and an exact search is made for the results; no attempt is made to convert the string into a regular expression. </param>
        ///<param name="replaceText">Required. A String object or string literal containing the text to replace for every successful match of rgExp in stringObj. In JScript 5.5 or later, the replaceText argument can also be a function that returns the replacement text. </param>
        ///<returns>The result of the replace method is a copy of stringObj after the specified replacements have been made. </returns>
        [JsMethod(NativeOverloads = true)]
        public JsString replace(string searchText, string replaceText) { return default(string); }
        ///<summary>
        ///Returns the length of a String object.
        ///</summary>
        public readonly JsNumber length;
        ///<summary>
        ///Places an HTML anchor with a NAME attribute around specified text in the object.
        ///</summary>
        ///<param name="anchorString">Text you want to place in the NAME attribute of an HTML anchor.</param>
        [JsMethod(NativeOverloads = true)]
        public void anchor(string anchorString) { }
        ///<summary>
        ///Places HTML &lt;BIG&gt; tags around text in a String object.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public JsString big() { return default(JsString); }
        ///<summary>
        ///Places HTML &lt;BLINK&gt; tags around text in a String object.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public JsString blink() { return default(JsString); }
        ///<summary>
        ///Places HTML &lt;B&gt; tags around text in a String object.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public JsString bold() { return default(JsString); }
        ///<summary>
        ///Returns the character at the specified index.
        ///</summary>
        ///<param name="index">Zero-based index of the desired character. Valid values are between 0 and the length of the string minus 1.</param>
        [JsMethod(NativeOverloads = true)]
        public JsString charAt(JsNumber index) { return default(JsString); }
        ///<summary>
        ///Returns an integer representing the Unicode encoding of the character at the specified location.
        ///</summary>
        ///<param name="index">Zero-based index of the desired character. Valid values are between 0 and the length of the string minus 1.</param>
        [JsMethod(NativeOverloads = true)]
        public JsNumber charCodeAt(JsNumber index) { return default(JsNumber); }
        ///<summary>
        ///Returns a string value containing the concatenation of two or more supplied strings.
        ///</summary>
        ///<param name="strings">String objects or literals to concatenate to the end of string1.</param>
        ///<returns>The result of the concat method is equivalent to: result = string1 + string2 + string3 + + stringN. A change of value in either a source or result string does not affect the value in the other string. If any of the arguments are not strings, they are first converted to strings before being concatenated to string1.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString concat(params JsString[] strings) { return default(JsString); }
        ///<summary>
        ///Places HTML &lt;TT&gt; tags around text in a String object.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public string @fixed() { return default(string); }
        ///<summary>
        ///Places an HTML &lt;FONT&gt; tag with the COLOR attribute around the text in a String object.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public JsString fontcolor() { return default(JsString); }
        ///<summary>
        ///Places an HTML &lt;FONT&gt; tag with the SIZE attribute around the text in a String object.
        ///</summary>
        ///<param name="size">Integer value that specifies the size of the text.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public string fontsize(JsNumber size) { return default(string); }
        ///<summary>
        ///Returns a string from a number of Unicode character values.
        ///</summary>
        ///<param name="charCodes">A series of Unicode character values to convert to a string.</param>
        ///<returns>If no arguments are supplied, the result is the empty string.</returns>
        [JsMethod(NativeOverloads = true)]
        public static JsString fromCharCode(params JsNumber[] charCodes) { return default(JsString); }
        ///<summary>
        ///Places HTML &lt;I&gt; tags around text in a String object.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsString italics() { return default(JsString); }
        ///<summary>
        ///Returns a string where all alphabetic characters have been converted to lowercase, taking into account the host environment's current locale.
        ///</summary>
        ///<returns>Converts the characters in a string, taking into account the host environment's current locale. In most cases, the results are the same as you would obtain with the toLowerCase method. Results differ if the rules for a language conflict with the regular Unicode case mappings.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toLocaleLowerCase() { return default(JsString); }
        ///<summary>
        ///Returns a string where all alphabetic characters have been converted to uppercase, taking into account the host environment's current locale.
        ///</summary>
        ///<returns>Converts the characters in a string, taking into account the host environment's current locale. In most cases, the results are the same as you would obtain with the toUpperCase method. Results differ if the rules for a language conflict with the regular Unicode case mappings.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toLocaleUpperCase() { return default(JsString); }
        ///<summary>
        ///Returns a string where all alphabetic characters have been converted to lowercase.
        ///</summary>
        ///<returns>The method has no effect on nonalphabetic characters.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toLowerCase() { return default(JsString); }
        ///<summary>
        ///Returns a string where all alphabetic characters have been converted to uppercase.
        ///</summary>
        ///<returns>The method has no effect on non-alphabetic characters.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString toUpperCase() { return default(JsString); }

        /// <summary>
        /// Executes a search on a string using a regular expression pattern, and returns an array containing the results of that search.
        /// </summary>
        /// <param name="rgExp">Required. An instance of a Regular Expression object containing the regular expression pattern and applicable flags. </param>
        /// <returns></returns>
        public JsRegExpResult match(JsRegExp rgExp) { return null; }
        /// <summary>
        /// Executes a search on a string using a regular expression pattern, and returns an array containing the results of that search.
        /// </summary>
        /// <param name="rgExp">Required. A string literal containing the regular expression pattern and flags. </param>
        /// <returns></returns>
        public JsRegExpResult match(JsString rgExp) { return null; }
    }
    #endregion

    #region Misc
    #region Delegates

    [JsDelegate(NativeFunction = true)]
    public delegate void JsAction();
    [JsDelegate(NativeFunction = true)]
    public delegate void JsAction<T>(T arg);
    [JsDelegate(NativeFunction = true)]
    public delegate void JsAction<T1, T2>(T1 arg1, T2 arg2);
    [JsDelegate(NativeFunction = true)]
    public delegate void JsAction<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
    [JsDelegate(NativeFunction = true)]
    public delegate void JsAction<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    [JsDelegate(NativeFunction = true)]
    public delegate TResult JsFunc<TResult>();
    [JsDelegate(NativeFunction = true)]
    public delegate TResult JsFunc<T, TResult>(T arg);
    [JsDelegate(NativeFunction = true)]
    public delegate TResult JsFunc<T1, T2, TResult>(T1 arg1, T2 arg2);
    [JsDelegate(NativeFunction = true)]
    public delegate TResult JsFunc<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);
    [JsDelegate(NativeFunction = true)]
    public delegate TResult JsFunc<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    #endregion

    #region JsExtensions
    public static partial class JsExtensions
    {
        ///<summary>
        ///Allows converting an object to a different type without affecting the generated javascript code.
        ///</summary>
        ///<typeparam name="T"></typeparam>
        ///<param name="obj"></param>
        ///<returns></returns>
        [JsMethod(OmitCalls = true)]
        public static T As<T>(this object obj) { return default(T); }
    }
    #endregion


    #endregion
}
