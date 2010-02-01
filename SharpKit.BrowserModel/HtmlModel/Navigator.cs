using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

///// <summary>
///// 6.5.6.1 Event handlers
///// </summary>
[JsType(Export = false,Name = "Navigator", NativeConstructors = true, NativeEnumerator = true)]
public interface Navigator:NavigatorID,NavigatorOnLine,NavigatorAbilities
{
}

}
