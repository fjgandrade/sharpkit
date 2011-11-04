using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.svg
{

    using DOMException = org.w3c.dom.DOMException;

    public interface SVGNumberList
    {
        // SVGNumberList
        int numberOfItems {get;}
//TODO:
//ORIGINAL LINE: public void clear() throws org.w3c.dom.DOMException;
        void clear();
//TODO:
//ORIGINAL LINE: public SVGNumber initialize(SVGNumber newItem) throws org.w3c.dom.DOMException, SVGException;
        SVGNumber initialize(SVGNumber newItem);
//TODO:
//ORIGINAL LINE: public SVGNumber getItem(int index) throws org.w3c.dom.DOMException;
        SVGNumber getItem(int index);
//TODO:
//ORIGINAL LINE: public SVGNumber insertItemBefore(SVGNumber newItem, int index) throws org.w3c.dom.DOMException, SVGException;
        SVGNumber insertItemBefore(SVGNumber newItem, int index);
//TODO:
//ORIGINAL LINE: public SVGNumber replaceItem(SVGNumber newItem, int index) throws org.w3c.dom.DOMException, SVGException;
        SVGNumber replaceItem(SVGNumber newItem, int index);
//TODO:
//ORIGINAL LINE: public SVGNumber removeItem(int index) throws org.w3c.dom.DOMException;
        SVGNumber removeItem(int index);
//TODO:
//ORIGINAL LINE: public SVGNumber appendItem(SVGNumber newItem) throws org.w3c.dom.DOMException, SVGException;
        SVGNumber appendItem(SVGNumber newItem);
    }

}