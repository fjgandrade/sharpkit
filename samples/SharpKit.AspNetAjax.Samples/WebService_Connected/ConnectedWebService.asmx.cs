using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;
using SharpKit.JavaScriptModel;
using Sys.Net;

namespace WebService_Connected
{
	[System.Web.Script.Services.ScriptService]
	[WebService(Namespace = "http://xmlforasp.net")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class ConnectedWebService : System.Web.Services.WebService
	{
		[WebMethod]
		public MyDataItem[] WaitForNewItems(int interval)
		{
			var list = new List<MyDataItem>();
			while (list.Count == 0)
			{
				list.Add(new MyDataItem { ID = new Random().Next(0, 1000000), Text = "New item created "+DateTime.Now });
				Thread.Sleep(interval);
			}
			return list.ToArray();
		}
	}

	/// <summary>
	/// This is a typed proxy for the CustomersService Web Service. 
	/// You need to create such a class if you want to access the service in C# on the client.
	/// Add to the method signature the successCallback and failedCallback as follows
	/// </summary>
	[JsType(Mode = JsMode.Prototype, Name = "WebService_Connected.ConnectedWebService", Export = false)]
	public class ConnectedWebService_Proxy : WebServiceProxy
	{
		public WebRequest WaitForNewItems(int interval, WebServiceSuccessCallback successCallback, WebServiceFailureCallback failedCallback)
		{
			throw new NotImplementedException();
		}
	}

}
