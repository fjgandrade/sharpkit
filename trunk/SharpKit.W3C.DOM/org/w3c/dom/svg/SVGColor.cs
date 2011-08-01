//AutoGenerated

namespace org.w3c.dom.svg
{

    using CSSValue = org.w3c.dom.css.CSSValue;
    using RGBColor = org.w3c.dom.css.RGBColor;

    public interface SVGColor : org.w3c.dom.css.CSSValue
    {
        // SVGColor
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short SVG_COLORTYPE_UNKNOWN = 0;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short SVG_COLORTYPE_RGBCOLOR = 1;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short SVG_COLORTYPE_RGBCOLOR_ICCCOLOR = 2;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short SVG_COLORTYPE_CURRENTCOLOR = 3;
        short colorType {get;}
        RGBColor rgbColor {get;set;}
        SVGICCColor iccColor {get;}
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setRGBColor(String rgbColor) throws SVGException;
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setRGBColorICCColor(String rgbColor, String iccColor) throws SVGException;
        void setRGBColorICCColor(string rgbColor, string iccColor);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setColor(short colorType, String rgbColor, String iccColor) throws SVGException;
        void setColor(short colorType, string rgbColor, string iccColor);
    }

}