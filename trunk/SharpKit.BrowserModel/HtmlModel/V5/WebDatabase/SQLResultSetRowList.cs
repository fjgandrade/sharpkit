using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "SQLResultSetRowList")]
	[HtmlSpecificationVersion(5)]
	public class SQLResultSetRowList : JsArray<object>
	{
		//[HtmlSpecificationVersion(5)]
		//[JsProperty(NativeField = true)]
		//ulong length { get; }

		//[HtmlSpecificationVersion(5)]
		//[JsMethod(NativeOverloads = true)]
		//object item(ulong index);
	}
}
