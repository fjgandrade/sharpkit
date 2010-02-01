using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "DatabaseSync")]
	public interface DatabaseSync
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void transaction(SQLTransactionSyncCallback callback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void readTransaction(SQLTransactionSyncCallback callback);

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string version { get; }

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void changeVersion(string oldVersion, string newVersion);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void changeVersion(string oldVersion, string newVersion, SQLTransactionSyncCallback callback);
	}
}
