//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class HtmlScriptElement : HtmlElement
{

	// HTMLScriptElement
	public JsString src {get; set; }
	public bool @async {get; set; }
	public bool defer {get; set; }
	public JsString type {get; set; }
	public JsString charset {get; set; }
	public JsString text {get; set; }

	// HTMLScriptElement-30
	public JsString @event {get; set; }
	public JsString htmlFor {get; set; }
}

}