using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "WindowDatabase")]
	[HtmlSpecificationVersion(5)]
	public interface WindowDatabase
	{
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		Database openDatabase(string name, string version, string displayName, ulong estimatedSize);

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true, NativeDelegates = true)]
		Database openDatabase(string name, string version, string displayName, ulong estimatedSize, DatabaseCallback creationCallback);
	}
}
