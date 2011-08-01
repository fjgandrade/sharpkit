using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.xpath
{

    using DOMException = org.w3c.dom.DOMException;
    using Node = org.w3c.dom.Node;

    public interface XPathResult
    {
        // XPathResult
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short ANY_TYPE = 0;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short NUMBER_TYPE = 1;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short STRING_TYPE = 2;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short BOOLEAN_TYPE = 3;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short UNORDERED_NODE_ITERATOR_TYPE = 4;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short ORDERED_NODE_ITERATOR_TYPE = 5;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short UNORDERED_NODE_SNAPSHOT_TYPE = 6;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short ORDERED_NODE_SNAPSHOT_TYPE = 7;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short ANY_UNORDERED_NODE_TYPE = 8;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short FIRST_ORDERED_NODE_TYPE = 9;
        short resultType {get;}
//TODO:
//ORIGINAL LINE: public double getNumberValue() throws XPathException;
        double numberValue {get;}
//TODO:
//ORIGINAL LINE: public String getStringValue() throws XPathException;
        JsString stringValue {get;}
//TODO:
//ORIGINAL LINE: public boolean getBooleanValue() throws XPathException;
        bool booleanValue {get;}
//TODO:
//ORIGINAL LINE: public org.w3c.dom.Node getSingleNodeValue() throws XPathException;
        Node singleNodeValue {get;}
        bool invalidIteratorState {get;}
//TODO:
//ORIGINAL LINE: public int getSnapshotLength() throws XPathException;
        int snapshotLength {get;}
//TODO:
//ORIGINAL LINE: public org.w3c.dom.Node iterateNext() throws XPathException, org.w3c.dom.DOMException;
        Node iterateNext();
//TODO:
//ORIGINAL LINE: public org.w3c.dom.Node snapshotItem(int index) throws XPathException;
        Node snapshotItem(int index);
    }

}
