//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class LSProgressEvent : Event
{

	// LSProgressEvent
	public LSInput input {get; private set; }
	public int position {get; private set; }
	public int totalSize {get; private set; }
}

}