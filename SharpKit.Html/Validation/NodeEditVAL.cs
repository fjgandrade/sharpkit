//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class NodeEditVAL
{

	// NodeEditVAL
	public static short VAL_WF = 1;
	public static short VAL_NS_WF = 2;
	public static short VAL_INCOMPLETE = 3;
	public static short VAL_SCHEMA = 4;
	public static short VAL_TRUE = 5;
	public static short VAL_FALSE = 6;
	public static short VAL_UNKNOWN = 7;
	public JsString defaultValue {get; private set; }
	public DOMStringList enumeratedValues {get; private set; }
	public short canInsertBefore(Node newChild, Node refChild) { return default(short); }
	public short canRemoveChild(Node oldChild) { return default(short); }
	public short canReplaceChild(Node newChild, Node oldChild) { return default(short); }
	public short canAppendChild(Node newChild) { return default(short); }
	public short nodeValidity(short valType) { return default(short); }
}

}