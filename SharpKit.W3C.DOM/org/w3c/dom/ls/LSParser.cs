//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.ls
{

using SharpKit.JavaScript;
using DOMConfiguration = org.w3c.dom.DOMConfiguration;
using DOMException = org.w3c.dom.DOMException;
using Document = org.w3c.dom.Document;
using Node = org.w3c.dom.Node;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class LSParser
{

	// LSParser
	public DOMConfiguration domConfig {get;private set;}
	public LSParserFilter filter {get;set;}
	public bool async {get;private set;}
	public bool busy {get;private set;}
	public Document parse(LSInput input) { return default(Document); }
	public Document parseURI(string uri) { return default(Document); }
	public static short ACTION_APPEND_AS_CHILDREN = 1;
	public static short ACTION_REPLACE_CHILDREN = 2;
	public static short ACTION_INSERT_BEFORE = 3;
	public static short ACTION_INSERT_AFTER = 4;
	public static short ACTION_REPLACE = 5;
	public Node parseWithContext(LSInput input, Node contextArg, short action) { return default(Node); }
	public void abort() {}
}

}