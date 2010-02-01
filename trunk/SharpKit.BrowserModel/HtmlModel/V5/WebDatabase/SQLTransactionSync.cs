using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "SQLTransactionSync")]
	[HtmlSpecificationVersion(5)]
	public interface SQLTransactionSync
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		SQLResultSet executeSql(string sqlStatement);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		SQLResultSet executeSql(string sqlStatement, object[] arguments);
	}
}
