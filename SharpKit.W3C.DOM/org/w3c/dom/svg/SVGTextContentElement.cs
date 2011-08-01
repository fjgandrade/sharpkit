//AutoGenerated

namespace org.w3c.dom.svg
{

    using DOMException = org.w3c.dom.DOMException;

    public interface SVGTextContentElement : SVGElement, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGStylable
    {
        // SVGTextContentElement
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short LENGTHADJUST_UNKNOWN = 0;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short LENGTHADJUST_SPACING = 1;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short LENGTHADJUST_SPACINGANDGLYPHS = 2;
        SVGAnimatedLength textLength {get;}
        SVGAnimatedEnumeration lengthAdjust {get;}
        int numberOfChars {get;}
        float computedTextLength {get;}
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public float getSubStringLength(int charnum, int nchars) throws org.w3c.dom.DOMException;
        float getSubStringLength(int charnum, int nchars);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SVGPoint getStartPositionOfChar(int charnum) throws org.w3c.dom.DOMException;
        SVGPoint getStartPositionOfChar(int charnum);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SVGPoint getEndPositionOfChar(int charnum) throws org.w3c.dom.DOMException;
        SVGPoint getEndPositionOfChar(int charnum);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SVGRect getExtentOfChar(int charnum) throws org.w3c.dom.DOMException;
        SVGRect getExtentOfChar(int charnum);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public float getRotationOfChar(int charnum) throws org.w3c.dom.DOMException;
        float getRotationOfChar(int charnum);
        int getCharNumAtPosition(SVGPoint point);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void selectSubString(int charnum, int nchars) throws org.w3c.dom.DOMException;
        void selectSubString(int charnum, int nchars);
    }

}