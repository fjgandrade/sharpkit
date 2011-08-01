using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    using Node = org.w3c.dom.Node;
    using Range = org.w3c.dom.ranges.Range;

    public interface Selection
    {
        // Selection
        Node anchorNode {get;}
        int anchorOffset {get;}
        Node focusNode {get;}
        int focusOffset {get;}
        bool isCollapsed {get;}
        void collapse(Node parentNode, int offset);
        void collapseToStart();
        void collapseToEnd();
        void selectAllChildren(Node parentNode);
        void deleteFromDocument();
        int rangeCount {get;}
        Range getRangeAt(int index);
        void addRange(Range range);
        void removeRange(Range range);
        void removeAllRanges();
        JsString ToString();
    }

}
