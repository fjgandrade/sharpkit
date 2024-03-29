//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using Node = org.w3c.dom.Node;
using Range = org.w3c.dom.ranges.Range;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class Selection
{

	// Selection
	public Node anchorNode {get;private set;}
	public int anchorOffset {get;private set;}
	public Node focusNode {get;private set;}
	public int focusOffset {get;private set;}
	public bool isCollapsed {get;private set;}
	public void collapse(Node parentNode, int offset) {}
	public void collapseToStart() {}
	public void collapseToEnd() {}
	public void selectAllChildren(Node parentNode) {}
	public void deleteFromDocument() {}
	public int rangeCount {get;private set;}
	public Range getRangeAt(int index) { return default(Range); }
	public void addRange(Range range) {}
	public void removeRange(Range range) {}
	public void removeAllRanges() {}
	public string toString() { return default(string); }
}

}