using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;
using System.Collections;

namespace SharpKit.JavaScriptModel
{
	/// <summary>
	/// The Array object provides support for creation of arrays of any data type.
	/// </summary>
	[JsType(JsMode.Prototype, Export=false, Name="Array")]
	public class JsArray : JsObject
	{
		/// <summary>
		/// Specifies the function that creates an object.
		/// </summary>
		public JsArray()
		{
		}

		/// <summary>
		/// An array to be copied to the array being constructed. 
		/// </summary>
		/// <param name="array">Optional. An array to be copied to the array being constructed.</param>
		public JsArray(JsArray array)
		{
		}

		/// <summary>
		/// The size of the array. As arrays are zero-based, created elements will have indexes from zero to size -1. 
		/// </summary>
		/// <param name="size">Optional. The size of the array. As arrays are zero-based, created elements will have indexes from zero to size -1.</param>
		public JsArray(int size)
		{
		}

		/// <summary>
		/// A typed array that contains all the parameters passed to the constructor. These parameters are used as the first elements of the array. 
		/// </summary>
		/// <param name="items">Optional. A typed array that contains all the parameters passed to the constructor. These parameters are used as the first elements of the array.</param>
		public JsArray(params object[] items)
		{
		}

		public static implicit operator JsArray(Array array)
		{
			return new JsArray(array);
		}

		public static implicit operator Array(JsArray array)
		{
			throw new NotImplementedException();
		}

		public static implicit operator JsArray(object[] array)
		{
			return new JsArray(array);
		}

		public static implicit operator object[](JsArray array)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an integer value one higher than the highest element defined in an array.
		/// </summary>
		[JsProperty(NativeField = true)]
		public int length { get; set; }

		[JsProperty(NativeIndexer=true)]
		public object this[int index]
		{
			get
			{
				throw new NotImplementedException("TODO: Implement");
			}
			set
			{
				throw new NotImplementedException("TODO: Implement");
			}
		}

		/// <summary>
		/// Appends new elements to an array, and returns the new length of the array.
		/// </summary>
		/// <param name="items">Optional. New elements of the Array.</param>
		[JsMethod(NativeOverloads=true)]
		public void push(params object[] items)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		///// <summary>
		///// Appends a new element to an array
		///// </summary>
		///// <param name="obj">New element of the Array.</param>
		//[JsMethod(UseNativeOverloads = true)]
		//public void push(object obj)
		//{
		//  throw new NotImplementedException("TODO: Implement");
		//}

		[JsMethod(NativeOverloads = true)]
		public object peek()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Removes the last element from an array and returns it.
		/// </summary>
		/// <remarks>
		/// If the array is empty, undefined is returned.
		/// </remarks>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public object pop()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns a new array consisting of a combination of the current array and any additional items.
		/// </summary>
		/// <param name="items">Optional. Additional items to add to the end of the current array.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public JsArray concat(params object[] items)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string value consisting of all the elements of an array concatenated together and separated by the specified separator character.
		/// </summary>
		/// <param name="separator">Required. A string that is used to separate one element of an array from the next in the resulting String object. If omitted, the array elements are separated with a comma.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public string join(string separator)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements. Returns the elements removed from the array.
		/// </summary>
		/// <param name="start">Required. The zero-based location in the array from which to start removing elements.</param>
		/// <param name="deleteCount">Required. The number of elements to remove.</param>
		/// <param name="newItems">Optional. Elements to insert into the array in place of the deleted elements.</param>
		/// <remarks>
		/// The splice method modifies the array by removing the specified number of elements from position start and inserting new elements. The deleted elements are returned as a new array object.
		/// </remarks>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public JsArray splice(int start, int deleteCount, params object[] newItems)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a section of an array.
		/// </summary>
		/// <param name="start">Required. The index to the beginning of the specified portion of the array.</param>
		/// <param name="end">Optional. The index to the end of the specified portion of the array.</param>
		/// <remarks>
		/// The slice method returns an Array object containing the specified portion of the array.
		/// The slice method copies up to, but not including, the element indicated by end. If start is negative, it is treated as length + start where length is the length of the array. If end is negative, it is treated as length + end where length is the length of the array. If end is omitted, extraction continues to the end of the array. If end occurs before start, no elements are copied to the new array.
		/// </remarks>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public JsArray slice(int start, int end)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an Array object with the elements reversed.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public JsArray reverse()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes the first element from an array and returns that element.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads=true)]
		public object shift()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Inserts specified elements into the beginning of an array.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public object unshift()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Inserts specified elements into the beginning of an array.
		/// </summary>
		/// <param name="newItems">Optional. Elements to insert at the start of the Array.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public object unshift(params object[] newItems)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an Array object with the elements sorted.
		/// </summary>
		/// <param name="sortFunction">Optional. Name of the function used to determine the order of the elements.</param>
		[JsMethod(NativeOverloads = true)]
		public JsArray sort(Func<object,object,int> sortFunction)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an Array object with the elements sorted.
		/// </summary>
		/// <param name="sortFunction">Optional. Name of the function used to determine the order of the elements.</param>
		public JsArray sort(JsFunction sortFunction)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an Array object with the elements sorted.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public void sort()
		{
			throw new NotImplementedException();
		}

	}

	/// <summary>
	/// The Array object provides support for creation of arrays of any data type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[JsType(Name="Array", NativeConstructors=true)]
	public class JsArray<T> : JsObject
	{
		[JsMethod(IgnoreGenericArguments=true)]
		public JsArray()
		{
		}

		/// <summary>
		/// An array to be copied to the array being constructed. 
		/// </summary>
		/// <param name="array">Optional. An array to be copied to the array being constructed.</param>
		[JsMethod(IgnoreGenericArguments = true)]
		public JsArray(JsArray<T> array)
		{
		}

		/// <summary>
		/// The size of the array. As arrays are zero-based, created elements will have indexes from zero to size -1. 
		/// </summary>
		/// <param name="size">Optional. The size of the array. As arrays are zero-based, created elements will have indexes from zero to size -1.</param>
		[JsMethod(IgnoreGenericArguments = true)]
		public JsArray(int size)
		{
		}

		/// <summary>
		/// A typed array that contains all the parameters passed to the constructor. These parameters are used as the first elements of the array. 
		/// </summary>
		/// <param name="items">Optional. A typed array that contains all the parameters passed to the constructor. These parameters are used as the first elements of the array.</param>
		[JsMethod(IgnoreGenericArguments = true)]
		public JsArray(params T[] items)
		{
		}
		
		/// <summary>
		/// Returns an integer value one higher than the highest element defined in an array.
		/// </summary>
		[JsProperty(NativeField=true)]
		public int length { get; set; }

		[JsProperty(NativeIndexer = true)]
		public T this[int index]
		{
			[JsMethod(IgnoreGenericArguments = true)]
			get
			{
				throw new NotImplementedException("TODO: Implement");
			}
			[JsMethod(IgnoreGenericArguments = true)]
			set
			{
				throw new NotImplementedException("TODO: Implement");
			}
		}

		/// <summary>
		/// Appends new elements to an array, and returns the new length of the array.
		/// </summary>
		/// <param name="items">Optional. New elements of the Array.</param>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments=true)]
		public void push(params T[] items)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		[JsMethod(NativeOverloads = true, IgnoreGenericArguments=true)]
		public T peek()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Removes the last element from an array and returns it.
		/// </summary>
		/// <remarks>
		/// If the array is empty, undefined is returned.
		/// </remarks>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public T pop()
		{
			throw new NotImplementedException("TODO: Implement");
		}

		/// <summary>
		/// Returns a new array consisting of a combination of the current array and any additional items.
		/// </summary>
		/// <param name="items">Optional. Additional items to add to the end of the current array.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public JsArray<T> concat(params T[] items)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a string value consisting of all the elements of an array concatenated together and separated by the specified separator character.
		/// </summary>
		/// <param name="separator">Required. A string that is used to separate one element of an array from the next in the resulting String object. If omitted, the array elements are separated with a comma.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public string join(string separator)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements. Returns the elements removed from the array.
		/// </summary>
		/// <param name="start">Required. The zero-based location in the array from which to start removing elements.</param>
		/// <param name="deleteCount">Required. The number of elements to remove.</param>
		/// <param name="newItems">Optional. Elements to insert into the array in place of the deleted elements.</param>
		/// <remarks>
		/// The splice method modifies the array by removing the specified number of elements from position start and inserting new elements. The deleted elements are returned as a new array object.
		/// </remarks>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public JsArray<T> splice(int start, int deleteCount, params T[] newItems)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a section of an array.
		/// </summary>
		/// <param name="start">Required. The index to the beginning of the specified portion of the array.</param>
		/// <param name="end">Optional. The index to the end of the specified portion of the array.</param>
		/// <remarks>
		/// The slice method returns an Array object containing the specified portion of the array.
		/// The slice method copies up to, but not including, the element indicated by end. If start is negative, it is treated as length + start where length is the length of the array. If end is negative, it is treated as length + end where length is the length of the array. If end is omitted, extraction continues to the end of the array. If end occurs before start, no elements are copied to the new array.
		/// </remarks>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public JsArray<T> slice(int start, int end)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an Array object with the elements reversed.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public JsArray<T> reverse()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes the first element from an array and returns that element.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public T shift()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Inserts specified elements into the beginning of an array.
		/// </summary>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public T unshift()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Inserts specified elements into the beginning of an array.
		/// </summary>
		/// <param name="newItems">Optional. Elements to insert at the start of the Array.</param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
		public object unshift(params T[] newItems)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an Array object with the elements sorted.
		/// </summary>
		/// <param name="sortFunction">Optional. Name of the function used to determine the order of the elements.</param>
		[JsMethod(NativeOverloads = true, NativeDelegates=true)]
		public void sort(Func<T,T,int> sortFunction)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns an Array object with the elements sorted.
		/// </summary>
		[JsMethod(NativeOverloads = true)]
		public void sort()
		{
			throw new NotImplementedException();
		}
	}

}
