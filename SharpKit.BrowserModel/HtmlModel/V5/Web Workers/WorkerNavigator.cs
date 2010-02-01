using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "WorkerNavigator")]
	[HtmlSpecificationVersion(5)]
	public interface WorkerNavigator : NavigatorID, NavigatorOnLine
	{
	}
}
