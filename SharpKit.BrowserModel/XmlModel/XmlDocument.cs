﻿using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel.Xml
{

	[JsType(OmitCasts = true, Export=false)]
	public interface IXmlAttributeCollection
	{
		[JsProperty(NativeIndexer=true)]
		IXmlAttribute this[int index]{get;set;}

		[JsProperty(NativeField = true)]
		int length { get; }
	}

	[JsType(OmitCasts = true, Export = false)]
	//[ManuallyCodedAtClient]
	public interface IXmlAttribute : IXmlNode
	{
		[JsPropertyAttribute(NativeField = true)]
		string value { get; set; }

		[JsPropertyAttribute(NativeField = true)]
		string name { get; }
	}

	[JsType(OmitCasts = true, Export = false, NativeOverloads = true)]
	public interface IXmlDocumentParseError
	{
		string srcText { get; }
		string reason { get; }
	}
	[JsType(JsMode.Prototype, OmitCasts = true, Export = false)]
	//[ManuallyCodedAtClient]
	public interface IXmlDocument : IXmlNode
	{
		IXmlDocumentParseError parseError { get; }
		IXmlElement createElement(string tagName);

		IXmlElement documentElement { get; set; }

		IXmlAttribute[] attributes { get; }

		void loadXML(string xmlString);

		bool async { get; set; }

		JsArray<IXmlElement> getElementsByTagName(string tagName);
	}

	[JsType(OmitCasts = true, Export = false)]
	//[ManuallyCodedAtClient]
	public interface IXmlNode
	{
		/// <summary>
		/// Returns the base name for the name qualified with the namespace.
		/// </summary>
		[JsPropertyAttribute(NativeField = true)]
		string baseName { get; }
		/// <summary>
		/// Returns the Uniform Resource Identifier (URI) for the namespace
		/// </summary>
		[JsPropertyAttribute(NativeField = true)]
		string namespaceURI { get; }
		 
		[JsPropertyAttribute(NativeField = true)]
		IXmlNode firstChild { get; }

		[JsPropertyAttribute(NativeField = true)]
		IXmlNodeCollection children { get; }

		[JsPropertyAttribute(NativeField = true)]
		IXmlNode lastChild { get; }

		[JsPropertyAttribute(NativeField = true)]
		IXmlNodeCollection childNodes { get; }

		[JsPropertyAttribute(NativeField = true)]
		IXmlNode previousSibling { get; }

		[JsPropertyAttribute(NativeField = true)]
		IXmlNode nextSibling { get; }

		[JsPropertyAttribute(NativeField = true)]
		string nodeValue { get; set; }

		/// <summary>
		/// Returns the qualified name for attribute, document type, element, entity, or notation nodes. Returns a fixed string for all other node types. Read-only.
		/// </summary>
		[JsPropertyAttribute(NativeField = true)]
		string nodeName { get; set; }

		[JsPropertyAttribute(NativeField = true)]
		int nodeType { get; }

		/// <summary>
		/// Returns the namespace prefix.
		/// </summary>
		[JsPropertyAttribute(NativeField = true)]
		string prefix { get; }

		/// <summary>
		/// Represents the text content of the node or the concatenated text representing the node and its descendants. Read/write.
		/// </summary>
		[JsPropertyAttribute(NativeField = true)]
		string text { get; set; }

		[JsPropertyAttribute(NativeField = true)]
		string nodeTypeString { get;  }
	}
	[JsType(OmitCasts = true, Export = false)]
	public interface IXmlNodeCollection
	{
		[JsProperty(NativeField = true)]
		int length { get; }

		[JsProperty(NativeIndexer=true)]
		IXmlNode this[int index] { get; set; }
	}

	[JsType(JsMode.Prototype, OmitCasts = true, Export = false)]
	//[ManuallyCodedAtClient]
	public interface IXmlElement : IXmlNode
	{
		/// <summary>
		/// Contains the XML representation of the node and all its descendants. Read-only.
		/// </summary>
		string xml { get; }

		string tagName { get; set; }

		IXmlAttribute getAttributeNode(string name);

		IXmlAttributeCollection attributes { get; }

		string getAttribute(string name);

		JsArray<IXmlElement> getElementsByTagName(string tagName);

	}

	[JsType(OmitCasts = true, Export = false)]
	//[ManuallyCodedAtClient]
	public interface IXmlTextNode : IXmlNode
	{

		[JsPropertyAttribute(NativeField = true)]
		string data { get; set; }
	}

}
