using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.JavaScriptModel
{
	[JsType(JsMode.Prototype, Export = false, Name = "Object")]
	public class JsObject : IEnumerable<JsString>
	{
		/// <summary>
		/// Watches for a property to be assigned a value and runs a function when that occurs.
		/// Watches for assignment to a property named prop in this object, calling handler(prop, oldval, newval) whenever prop is set and storing the return value in that property. A watchpoint can filter (or nullify) the value assignment, by returning a modified newval (or by returning oldval).
		/// If you delete a property for which a watchpoint has been set, that watchpoint does not disappear. If you later recreate the property, the watchpoint is still in effect.
		/// To remove a watchpoint, use the unwatch method. By default, the watch method is inherited by every object descended from Object.
		/// The JavaScript debugger has functionality similar to that provided by this method, as well as other debugging options. For information on the debugger, see Venkman.
		/// In NES 3.0 and 4.x, handler is called from native code as well as assignments in script. In Firefox, handler is only called from assignments in script, not from native code. For example, window.watch('location', myHandler) will not call myHandler if the user clicks a link to an anchor within the current document. However, window.location += '#myAnchor' will call myHandler:
		/// </summary>
		/// <param name="prop">The name of a property of the object.</param>
		/// <param name="handler">A function to call.</param>
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4)]
		public virtual void watch(string prop, Action handler)
		{
		}

		/// <summary>
		/// Removes a watchpoint set with the watch method
		/// The JavaScript debugger has functionality similar to that provided by this method, as well as other debugging options. For information on the debugger, see Venkman.
		/// By default, this method is inherited by every object descended from Object.
		/// </summary>
		/// <param name="prop">The name of a property of the object.</param>
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4)]
		public virtual void unwatch(string prop)
		{
		}

		/// <summary>
		/// Returns a reference to the prototype for a class of objects.
		/// </summary>
		public JsObject prototype;		
		
		/// <summary>
		/// Returns the primitive value of the specified object.
		/// The required object reference is any intrinsic JScript object.
		/// The valueOf method is defined differently for each intrinsic JScript object.
		/// Object
		/// Return Value
		/// Array
		/// Returns the array instance.
		/// Boolean
		/// The Boolean value.
		/// Date
		/// The stored time value in milliseconds since midnight, January 1, 1970 UTC.
		/// Function
		/// The function itself.
		/// Number
		/// The numeric value.
		/// Object
		/// The object itself. This is the default.
		/// String
		/// The string value.
		/// The Math and Error objects do not have a valueOf method.
		/// </summary>
		/// <returns></returns>
		public virtual object valueOf()
		{
			throw new NotImplementedException();
		}
		
		public JsObject()
		{
		}

		public JsObject(object json)
		{
		}

		public JsObject constructor;

		[JsProperty(NativeIndexer = true)]
		public object this[string name]
		{
			get
			{
				return null;
				//throw new NotImplementedException("TODO: Implement");
			}
			set
			{
			}
		}

		//[AutoCreate]
		//Dictionary<string, object> ServerSideDictionary { get; set; }

		/// <summary>
		/// Returns a Boolean value indicating whether an object exists in another object's prototype chain.
		/// </summary>
		/// <param name="object2">Another object whose prototype chain is to be checked.</param>
		/// <returns>true if object2 has object1 in its prototype chain. The prototype chain is used to share functionality between instances of the same object type. The isPrototypeOf method returns false when object2 is not an object or when object1 does not appear in the prototype chain of the object2.</returns>
		public virtual bool isPrototypeOf(object object2)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a Boolean value indicating whether an object has a property with the specified name.
		/// </summary>
		/// <param name="proName">String value of a property name.</param>
		/// <returns> true if object has a property of the specified name, false if it does not. This method does not check if the property exists in the object's prototype chain; the property must be a member of the object itself.</returns>
		public virtual bool hasOwnProperty(string proName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string representation of an object.
		/// </summary>
		/// <returns>Returns "[object objectname]", where objectname is the name of the object type.</returns>
		public virtual JsString toString()
		{
			throw new NotImplementedException();
		}

		#region IEnumerable<string> Members

		IEnumerator<JsString> IEnumerable<JsString>.GetEnumerator()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		#endregion
	}



}
