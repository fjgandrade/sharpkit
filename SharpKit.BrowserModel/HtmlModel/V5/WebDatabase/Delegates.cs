using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "SQLTransactionSyncCallback")]
	[HtmlSpecificationVersion(5)]
	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLTransactionSyncCallback(SQLTransactionSync transaction);

	[HtmlSpecificationVersion(5)]
	[JsDelegate(NativeDelegates = true)]
	[JsType(Export = false, Name = "SQLStatementCallback")]
	public delegate void SQLStatementCallback(SQLTransaction transaction, SQLResultSet resultSet);

	[HtmlSpecificationVersion(5)]
	[JsDelegate(NativeDelegates = true)]
	[JsType(Export = false, Name = "SQLStatementErrorCallback")]
	public delegate void SQLStatementErrorCallback(SQLTransaction transaction, SQLError error);

	[JsType(Export = false, Name = "DatabaseCallback")]
	[HtmlSpecificationVersion(5)]
	public delegate void DatabaseCallback(Database database);

	[JsType(Export = false, Name = "SQLVoidCallback")]
	[HtmlSpecificationVersion(5)]
	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLVoidCallback();

	[JsType(Export = false, Name = "SQLTransactionCallback")]
	[HtmlSpecificationVersion(5)]
	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLTransactionCallback(SQLTransaction transaction);

	[JsType(Export = false, Name = "SQLTransactionErrorCallback")]
	[HtmlSpecificationVersion(5)]
	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLTransactionErrorCallback(SQLError error);
}
