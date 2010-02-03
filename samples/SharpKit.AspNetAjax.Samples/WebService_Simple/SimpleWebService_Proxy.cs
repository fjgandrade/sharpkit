using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sys.Net;
using SharpKit.JavaScriptModel;

namespace WebService_Simple
{
	[JsType(JsMode.Prototype, Name = "WebService_Simple.SimpleWebService")]
	public class SimpleWebService_Proxy : WebServiceProxy
	{
		//[JsMethod(UseNativeDelegates = true, UseNativeOverloads = true)]
		public WebRequest EchoInput(string input, Action<string> successCallback)
		{
			throw new NotImplementedException();
		}
		//[JsMethod(UseNativeDelegates = true, UseNativeOverloads = true)]
		public WebRequest EchoInput(string input, Action<string> successCallback, WebServiceFailureCallback failedCallback)
		{
			throw new NotImplementedException();
		}

	}
}
