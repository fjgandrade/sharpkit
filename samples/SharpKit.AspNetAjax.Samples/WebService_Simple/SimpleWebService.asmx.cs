using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using SharpKit.JavaScriptModel;
using Sys.Net;

namespace WebService_Simple
{
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[ScriptService]
	public class SimpleWebService : System.Web.Services.WebService
	{

		[WebMethod]
		public string EchoInput(String input)
		{
			string inputString = Server.HtmlEncode(input);
			if (!String.IsNullOrEmpty(inputString))
			{
				return String.Format("You entered {0}. The "
					+ "current time is {1}.", inputString, DateTime.Now);
			}
			else
			{
				return "The input string was null or empty.";
			}
		}
	}

	[JsType(JsMode.Prototype, Name = "WebService_Simple.SimpleWebService")]
	public class SimpleWebService_Proxy : WebServiceProxy
	{
		public WebRequest EchoInput(string input, Action<string> successCallback)
		{
			throw new NotImplementedException();
		}
		public WebRequest EchoInput(string input, Action<string> successCallback, WebServiceFailureCallback failedCallback)
		{
			throw new NotImplementedException();
		}

	}

}
