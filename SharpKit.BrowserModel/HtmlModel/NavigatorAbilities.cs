using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

[JsType(Export = false,Name = "NavigatorAbilities", NativeConstructors = true, NativeEnumerator = true)]
public interface NavigatorAbilities
{
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	void registerProtocolHandler(string scheme, string url, string title);

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	void registerContentHandler(string mimeType, string url, string title);

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	void yieldForStorageUpdates();
}

}
