//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class HtmlCollection
{

	// HTMLCollection
	public int length {get; private set; }
	[JsProperty(NativeIndexer = true)]
    public HtmlElement this[int index] { get { return default(HtmlElement); } }
	[JsProperty(NativeIndexer = true)]
    public HtmlElement this[string name] { get { return default(HtmlElement); } }
}

}