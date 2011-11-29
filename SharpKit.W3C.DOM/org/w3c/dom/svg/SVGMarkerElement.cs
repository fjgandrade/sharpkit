//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.svg
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SVGMarkerElement : SVGElement
{

	// SVGMarkerElement
	public static short SVG_MARKERUNITS_UNKNOWN = 0;
	public static short SVG_MARKERUNITS_USERSPACEONUSE = 1;
	public static short SVG_MARKERUNITS_STROKEWIDTH = 2;
	public static short SVG_MARKER_ORIENT_UNKNOWN = 0;
	public static short SVG_MARKER_ORIENT_AUTO = 1;
	public static short SVG_MARKER_ORIENT_ANGLE = 2;
	public SVGAnimatedLength refX {get;private set;}
	public SVGAnimatedLength refY {get;private set;}
	public SVGAnimatedEnumeration markerUnits {get;private set;}
	public SVGAnimatedLength markerWidth {get;private set;}
	public SVGAnimatedLength markerHeight {get;private set;}
	public SVGAnimatedEnumeration orientType {get;private set;}
	public SVGAnimatedAngle orientAngle {get;private set;}
	public void setOrientToAuto() {}
	public void setOrientToAngle(SVGAngle angle) {}
}

}