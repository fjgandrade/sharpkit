//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class IDBCursorRequest : IDBCursor
{

	// IDBCursorRequest
	public IDBRequest request {get; private set; }
	public object key {get; private set; }
	public object value {get; private set; }
	public long count {get; private set; }
	public void update(object value) {}
	public void _continue() {}
	public void _continue(object key) {}
	public void remove() {}
}

}