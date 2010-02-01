using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{

/// <summary>
/// interface ApplicationCache { // update status const unsigned short UNCACHED = 0; const unsigned short IDLE = 1; const unsigned short CHECKING = 2; const unsigned short DOWNLOADING = 3; const unsigned short UPDATEREADY = 4; const unsigned short OBSOLETE = 5; readonly attribute unsigned short status ; // updates void update (); void swapCache (); // events attribute Function onchecking ; attribute Function onerror ; attribute Function onnoupdate ; attribute Function ondownloading ; attribute Function onprogress ; attribute Function onupdateready ; attribute Function oncached ; attribute Function onobsolete ; }; ApplicationCache implements EventTarget ;
/// </summary>
[HtmlSpecificationVersion(5)]
[JsType(Export = false,Name = "ApplicationCache", NativeConstructors = true, NativeEnumerator = true)]
public abstract class ApplicationCache: EventTarget
{
	 const ushort UNCACHED = 0;
	 const ushort IDLE = 1;
	 const ushort CHECKING = 2;
	 const ushort DOWNLOADING = 3;
	 const ushort UPDATEREADY = 4;
	 const ushort OBSOLETE = 5;
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public ushort status
	{
		get;
		private set;
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void update()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true,NativeOverloads=true)]
	public void swapCache()
	{
		throw new NotImplementedException();
	}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler onchecking {get;set;}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler onerror {get;set;}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler onnoupdate {get;set;}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler ondownloading {get;set;}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler onprogress {get;set;}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler onupdateready {get;set;}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler oncached {get;set;}
	[HtmlSpecificationVersion(5)]
	[JsProperty(NativeField=true)]
	public HtmlDomEventHandler onobsolete {get;set;}

	#region EventTarget Members

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates=true, NativeOverloads=true)]
	public void addEventListener(string type, HtmlDomEventHandler listener, bool useCapture)
	{
		throw new NotImplementedException();
	}

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates = true, NativeOverloads = true)]
	public void removeEventListener(string type, HtmlDomEventHandler listener, bool useCapture)
	{
		throw new NotImplementedException();
	}

	[HtmlSpecificationVersion(5)]
	[JsMethod(NativeDelegates = true, NativeOverloads = true)]
	public bool dispatchEvent(HtmlDomEventArgs evt)
	{
		throw new NotImplementedException();
	}

	#endregion
}

}
