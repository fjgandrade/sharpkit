using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using google.maps;

namespace HelloWorld
{
	[JsType(JsMode.Global, "index.js")]
	class index : GMapContext
	{
		public static void initialize()
		{
			if (GBrowserIsCompatible())
			{
				var map = new GMap2(document.getElementById("map_canvas"));
				map.setCenter(new GLatLng(37.4419, -122.1419), 13);
				map.setUIToDefault();
			}
		}
	}
}
