using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// An audio element represents a sound or audio stream.
/// </summary>

[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "HTMLAudioElement", NativeConstructors = true, NativeEnumerator = true)]
public abstract class HtmlAudioElement: HtmlMediaElement
{
	public HtmlAudioElement()
	{
		throw new NotImplementedException();
	}
	public HtmlAudioElement(string src)
	{
		throw new NotImplementedException();
	}
}

}
