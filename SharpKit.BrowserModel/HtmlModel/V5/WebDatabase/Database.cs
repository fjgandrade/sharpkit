using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "Database")]
	public interface Database
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void transaction(SQLTransactionCallback callback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void readTransaction(SQLTransactionCallback callback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void readTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void readTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		string version { get; }

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void changeVersion(string oldVersion, string newVersion);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void changeVersion(string oldVersion, string newVersion, SQLTransactionCallback callback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void changeVersion(string oldVersion, string newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		void changeVersion(string oldVersion, string newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);
	}
}
