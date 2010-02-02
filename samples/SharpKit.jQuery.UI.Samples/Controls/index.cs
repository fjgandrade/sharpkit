using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.jQuery;
using SharpKit.jQuery.UI;

namespace Controls
{
	[JsType(JsMode.Global, "index.js")]
	class index : jQueryContext
	{
		static index()
		{
			jQuery(delegate()
			{
				jQuery("#myTabs").tabs();
				jQuery("#myDatePicker").datepicker();
				jQuery("#mySlider").slider();
				jQuery("#myAccordion").accordion();
			});
		}
	}
}
