using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[HtmlSpecificationVersion(5)]
	[JsType(Export = false, Name = "SQLTransaction")]
	public interface SQLTransaction
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void executeSql(string sqlStatement);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void executeSql(string sqlStatement, object[] arguments);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void executeSql(string sqlStatement, object[] arguments, SQLStatementCallback callback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void executeSql(string sqlStatement, object[] arguments, SQLStatementCallback callback, SQLStatementErrorCallback errorCallback);
	}
}
