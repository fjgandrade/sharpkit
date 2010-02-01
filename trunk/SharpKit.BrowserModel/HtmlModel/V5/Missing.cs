using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	public abstract class MouseEvent
	{
	}

	public abstract class Element
	{
	}

	public abstract class WindowProxy : HtmlWindow //Hack
	{
	}

	public abstract class File
	{
	}

	public abstract class Document
	{
	}

	public abstract class Node
	{
	}

	public abstract class Date : JsDate
	{
	}

	public abstract class Range
	{
	}

	public abstract class NodeList
	{
	}

	public abstract class PropertyValueArray : JsArray
	{
	}

	public interface EventTarget
	{
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		void addEventListener(string type, HtmlDomEventHandler listener, bool useCapture);
		[JsMethod(NativeDelegates = true, NativeOverloads=true)]
		void removeEventListener(string type, HtmlDomEventHandler listener, bool useCapture);
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		bool dispatchEvent(HtmlDomEventArgs evt);
	}


	public interface LinkStyle
	{
	}

	public class MessagePortArray : JsArray<MessagePort>
	{ 
	}
	public class DOMStringList : JsArray<string>
	{ 
	}
	public interface AbstractView
	{
	}
	public interface FileList
	{
	}


	

	/*typedef sequence<any> PropertyValueArray;
Document implements HTMLDocument;
DOMImplementation implements DOMHTMLImplementation;
typedef sequence<MessagePort> MessagePortArray;*/

	/*public abstract class CanvasGradient
	{
		// opaque object
		void addColorStop(float offset, string color);
	};

	public abstract class CanvasPattern
	{
		// opaque object
	};

	public abstract class TextMetrics
	{
		public float width { get; private set; }
	};

	public abstract class ImageData
	{
		public ulong width { get; private set; }
		public ulong height { get; private set; }
		public CanvasPixelArray data { get; private set; }
	};

	public abstract class CanvasPixelArray
	{
		public ulong length { get; private set; }

		public ulong this[ulong index]
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
			}
		}
	}*/
}
