using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[HtmlSpecificationVersion(5)]
	[JsType(Export = false, Name = "WorkerUtilsDatabase")]
	public interface WorkerUtilsDatabase
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		Database openDatabase(string name, string version, string displayName, ulong estimatedSize);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		Database openDatabase(string name, string version, string displayName, ulong estimatedSize, DatabaseCallback creationCallback);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		DatabaseSync openDatabaseSync(string name, string version, string displayName, ulong estimatedSize);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		DatabaseSync openDatabaseSync(string name, string version, string displayName, ulong estimatedSize, DatabaseCallback creationCallback);
	}
}
