//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class Element : Node, IEventTarget
{

	// Element
	public JsString tagName {get; private set; }
	public JsString getAttribute(string name) { return default(JsString); }
	public void setAttribute(string name, string value) {}
	public void removeAttribute(string name) {}
	public Attr getAttributeNode(string name) { return default(Attr); }
	public Attr setAttributeNode(Attr newAttr) { return default(Attr); }
	public Attr removeAttributeNode(Attr oldAttr) { return default(Attr); }
	public NodeList getElementsByTagName(string name) { return default(NodeList); }
	public JsString getAttributeNS(string namespaceURI, string localName) { return default(JsString); }
	public void setAttributeNS(string namespaceURI, string qualifiedName, string value) {}
	public void removeAttributeNS(string namespaceURI, string localName) {}
	public Attr getAttributeNodeNS(string namespaceURI, string localName) { return default(Attr); }
	public Attr setAttributeNodeNS(Attr newAttr) { return default(Attr); }
	public void setAttributeNodeNS(string namespaceURI, string qualifiedName, string value) {}
	public NodeList getElementsByTagNameNS(string namespaceURI, string localName) { return default(NodeList); }
	public bool hasAttribute(string name) { return default(bool); }
	public bool hasAttributeNS(string namespaceURI, string localName) { return default(bool); }
	public TypeInfo schemaTypeInfo {get; private set; }
	public void setIdAttribute(string name, bool isId) {}
	public void setIdAttributeNS(string namespaceURI, string localName, bool isId) {}
	public void setIdAttributeNode(Attr idAttr, bool isId) {}

	// Element-41
	public ClientRectList clientRects {get; private set; }
	public ClientRect boundingClientRect {get; private set; }
	public int scrollTop {get; set; }
	public int scrollLeft {get; set; }
	public int scrollWidth {get; private set; }
	public int scrollHeight {get; private set; }
	public int clientTop {get; private set; }
	public int clientLeft {get; private set; }
	public int clientWidth {get; private set; }
	public int clientHeight {get; private set; }

	// NodeSelector
	public Element querySelector(string selectors) { return default(Element); }
	public NodeList querySelectorAll(string selectors) { return default(NodeList); }

    #region EventTarget Members

    public void addEventListener(string type, EventListener listener, bool useCapture)
    {
        throw new System.NotImplementedException();
    }

    public void removeEventListener(string type, EventListener listener, bool useCapture)
    {
        throw new System.NotImplementedException();
    }

    public bool dispatchEvent(DOMEvent evt)
    {
        throw new System.NotImplementedException();
    }

    #endregion
}

}