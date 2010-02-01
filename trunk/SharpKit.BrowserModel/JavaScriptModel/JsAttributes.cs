using System;
using System.Collections.Generic;
using System.Text;

namespace SharpKit.JavaScriptModel
{
	/// <summary>
	/// Instructs SharpKit Compiler to create a merged file from specified sources
	/// </summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple=true)]
	public class JsMergedFileAttribute : Attribute
	{
		/// <summary>
		/// The source files to merge
		/// </summary>
		public string[] Sources { get; set; }

		/// <summary>
		/// The target merged file name
		/// </summary>
		public string Filename { get; set; }
	}

	/// <summary>
	/// Indicates that the SharpKit Build precompiler will change the way it handles this method at the client
	/// </summary>
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
	public class JsMethodAttribute : Attribute
	{
		/// <summary>
		/// Tells the compiler to omit calls to this method and assume that it was invoked
		/// Extension methods:  s.DoSomething() ==> s
		/// </summary>
		public bool OmitCalls { get; set; }

		public string Name { get; set; }

		/// <summary>
		/// Tells the compiler to drop the method call and write the inline code instead.
		/// Only available for extention methods.
		/// object.SomeExtentionMethod(param) with InlineCode="object==param" ==> object==param
		/// </summary>
		public string InlineCode { get; set; }

		/// <summary>
		/// Custom javascript code implementation for this method
		/// </summary>
		public string Code { get; set; }


		/// <summary>
		/// When set to true - disables the overloading mechanism 
		/// and assumes that the overloads are implemented in a single javascript method with this name
		/// </summary>
		public bool NativeOverloads { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public bool IgnoreGenericArguments { get; set; }

		/// <summary>
		/// Marks this extension method as an instance method in javascript
		/// </summary>
		public bool ExtensionImplementedInInstance { get; set; }

		public bool NativeDelegates { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public bool GlobalCode { get; set; }

		/// <summary>
		/// Indicates that this method is global, if exported, it will be exported as a global function, and when invoked, it will be invoked without a class name prefix
		/// </summary>
		public bool Global { get; set; }

		bool? _Export;
		/// <summary>
		///	Indicates that SharpKit compiler will generate javascript code for this type / member
		/// This property is inherited and applied to all derived types. Default value is true
		/// </summary>
		public bool Export
		{
			get
			{
				return _Export.GetValueOrDefault(true);
			}
			set
			{
				_Export = value;
			}
		}

	}

	/// <summary>
	/// Indicates that the SharpKit Build precompiler will change the way it handles this property at the client
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class JsPropertyAttribute : Attribute
	{
		/// <summary>
		/// When set, all references will not use getters and setter, but will treat it as a field instead
		/// </summary>
		/// <remarks>Default value is false</remarks>
		public bool NativeField { get; set; }

		/// <summary>
		/// When applied to an indexer property, all references will not use getters and setter, but will treat it as a native indexer instead
		/// </summary>
		/// <remarks>Default value is false</remarks>
		public bool NativeIndexer { get; set; }

		///// <summary>
		///// 
		///// </summary>
		//public bool DoNotExport { get; set; }

		bool? _Export;
		/// <summary>
		///	Indicates that SharpKit compiler will generate javascript code for this type / member
		/// This property is inherited and applied to all derived types. Default value is true
		/// </summary>
		public bool Export
		{
			get
			{
				return _Export.GetValueOrDefault(true);
			}
			set
			{
				_Export = value;
			}
		}

	}

	/// <summary>
	/// Indicates that the SharpKit Build precompiler will change the way it handles this property at the client
	/// </summary>
	[AttributeUsage(AttributeTargets.Event)]
	public class JsEventAttribute : Attribute
	{
		/// <summary>
		/// 
		/// </summary>
		public bool NativeDelegates { get; set; }


	}

	/// <summary>
	/// Indicates that the SharpKit Build precompiler will change the way it handles this type at the client
	/// </summary>
	[AttributeUsage(AttributeTargets.Delegate)]
	public class JsDelegateAttribute : Attribute
	{
		public bool NativeDelegates { get; set; }
		public bool NativeFunction { get; set; }
	}

	/// <summary>
	/// Controls the interoperability and convertion of a .NET type into JavaScript.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Delegate)]
	public class JsTypeAttribute : Attribute
	{
		public JsTypeAttribute()
		{
		}

		public JsTypeAttribute(JsMode mode)
		{
			Mode = mode;
		}

		public JsTypeAttribute(JsMode mode, string filename)
		{
			Mode = mode;
			Filename = filename;
		}

		/// <summary>
		/// Indicates that all delegate parameters in all members are native javascript functions
		/// </summary>
		public bool NativeDelegates { get; set; }

		/// <summary>
		/// When true, omits all casts to this type
		/// </summary>
		public bool OmitCasts { get; set; }

		public bool NativeFields { get; set; }

		/// <summary>
		/// When true, foreach statements will use the for..in syntax of Javascript
		/// </summary>
		public bool NativeEnumerator { get; set; }

		/// <summary>
		/// When true, instanciations of this class will use the native Javascript method, rather than calling a constructor
		/// </summary>
		public bool NativeConstructors { get; set; }

		/// <summary>
		/// When true, instanciations of this class will use the native Javascript method, rather than calling a constructor
		/// </summary>
		public bool NativeOverloads { get; set; }

		/// <summary>
		/// When set, changes the type name in the client code
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Indicates that this type will be exported as native js type, 
		/// only one constructor is allowed, 
		/// all instance members will be exported to the constructor's prototype
		/// all static members will be exported to the constructor's members
		/// </summary>
		public bool Native { get; set; }

		/// <summary>
		/// When set, the class methods and properties will be declared on the window object, instead of a class.
		/// </summary>
		public bool GlobalObject { get; set; }

		bool? _Export;
		/// <summary>
		///	Indicates that SharpKit compiler will generate javascript code for this type / member
		/// This property is inherited and applied to all derived types. Default value is true
		/// </summary>
		public bool Export
		{
			get
			{
				return _Export.GetValueOrDefault(true);
			}
			set
			{
				_Export = value;
			}
		}

		/// <summary>
		/// The target filename to generate the javascript code into, when using a relative path, it will be relative to the current cs file,
		/// You may use the ~  (tilda) operator to designate the project directory
		/// </summary>
		public string Filename { get; set; }

		/// <summary>
		/// The type of js exporter to use
		/// </summary>
		public string Exporter { get; set; }

		/// <summary>
		/// Any anonymous delegate creation will be exported as a native inline function in javascript
		/// </summary>
		public bool NativeFunctions { get; set; }

		/// <summary>
		/// Anonymous objects will be created and treated as Json objects
		/// </summary>
		public bool NativeJsons { get; set; }

		internal JsMode? _Mode;
		public JsMode Mode
		{
			get
			{
				return _Mode.GetValueOrDefault();
			}
			set
			{
				_Mode = value;
				if (_Mode == JsMode.Global)
				{
					GlobalObject = true;
					NativeOverloads = true;
					NativeDelegates = true;
					NativeFields = true;
					NativeConstructors = true;
					NativeEnumerator = true;
					NativeFunctions = true;
					NativeJsons = true;
				}
				else if (_Mode == JsMode.Prototype)
				{
					Native = true;
					NativeOverloads = true;
					NativeDelegates = true;
					NativeFields = true;
					NativeConstructors = true;
					NativeEnumerator = true;
					NativeFunctions = true;
					NativeJsons = true;
				}
				else if (_Mode == JsMode.Clr)
				{
				}
				else if (_Mode == JsMode.Json)
				{
					Native = true;
					Export = false;
					NativeOverloads = true;
					NativeDelegates = true;
					NativeFields = true;
					NativeConstructors = true;
					NativeEnumerator = true;
					NativeFunctions = true;
					NativeJsons = true;
				}
			}
		}

	}


	/// <summary>
	/// Specifies the export and interopability mode of a C# type in JavaScript
	/// </summary>
	public enum JsMode
	{
		/// <summary>
		/// Static fields and methods will be exported and referred to as globally named functions, overloading is not allowed,
		/// Static constructor will be exported as global code without a function decleration
		/// All delegates are treated as native JavaScript functions
		/// </summary>
		Global,
		/// <summary>
		/// One instance constructor is allowed, and will be exported as a function, 
		/// static members will be exported into the constructor function itself
		/// instance members will be exported into the prototype of the constructor function
		/// Static constructor will be exported as global code without a function decleration
		/// All delegates are treated as native JavaScript functions
		/// <code>
		/// Contact = function()
		/// {
		/// }
		/// Contact.prototype.GetFullName = function()
		/// {
		/// }
		/// Contact.Load = function()
		/// {
		/// }
		/// </code>
		/// </summary>
		Prototype,
		/// <summary>
		/// Type will be exported for full .NET support, requires SharpKit.Web/System.js for this class to run and compile on the client side.
		/// Supported: Multiple constructors, Method overloading, Properties, Events, Delegates
		/// Reflection and LINQ is also supported
		/// Static constructors are not allowed
		/// </summary>
		Clr,
		/// <summary>
		/// Type will not be exported, and will be treated as json object when instantiated. static members aren't supported.
		/// </summary>
		Json,
	}
}
