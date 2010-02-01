using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using System.Reflection;
using SharpKit.BrowserModel.BrowserCompatibility;
using System.Xml;

namespace SharpKit.HtmlModel
{
	public class HtmlDomImplementation
	{
		/// <summary>
		/// Creates a DOM document.
		/// </summary>
		/// <param name="namespaceURI">namespace URI of the document to be created (use null if none)</param>
		/// <param name="qualifiedNameStr">qualified name (optional prefix and colon plus the local root element name) of the document to be created</param>
		/// <param name="documentType">the DocumentType to be created.</param>
		[SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		public XmlDocument createDocument(string namespaceURI, string qualifiedNameStr, XmlDocumentType documentType)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates an HTMLDocument object with the minimal tree made of the following elements: HTML, HEAD, TITLE, and BODY.
		/// </summary>
		/// <remarks>Introduced in DOM Level 2</remarks>
		/// <returns>A new HTMLDocument object.</returns>
		[SupportedBrowsers(BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
		public HtmlDocument createHTMLDocument()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a DocumentType object which can either be used with DOMImplementation.createDocument upon document creation or they can be put into the document via Node.insertBefore() or Node.replaceChild()
		/// </summary>
		/// <param name="qualifiedNameStr"></param>
		/// <param name="publicId"></param>
		/// <param name="systemId"></param>
		/// <returns></returns>
		public XmlDocumentType createDocumentType(string qualifiedNameStr, string publicId, string systemId)
		{
			throw new NotImplementedException();
		}

		public object getFeature(string feature, string version)
		{
			throw new NotImplementedException();
		}

		public bool hasFeature(string feature, string version)
		{
			throw new NotImplementedException();
		}
	}
}
