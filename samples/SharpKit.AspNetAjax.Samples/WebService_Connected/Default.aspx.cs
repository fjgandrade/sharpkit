﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using Sys.Net;

namespace WebService_Connected
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
	}

	[JsType(JsMode.Global, "Default.aspx.js")]
	class Default_Client : JsScript
	{
		static bool IsConnected;
		public static void btnConnectForNewCustomers_Click()
		{
			var btn = document.getElementById("btnConnectForNewCustomers");
			if (!IsConnected)
			{
				IsConnected = true;
				btn.innerText = "Disconnect";
				var service = new ConnectedWebService_Proxy();
				service.WaitForNewCustomers(1500, ConnectForNewCustomers_SucceededCallback, ConnectForNewCustomers_ErrorCallback);
			}
			else
			{
				IsConnected = false;
				btn.innerText = "Connect";
			}
		}

		public static void ConnectForNewCustomers_ErrorCallback(WebServiceError error, object userContext, string methodName)
		{
			if (IsConnected)
			{
				var service = new ConnectedWebService_Proxy();
				service.WaitForNewCustomers(1500, ConnectForNewCustomers_SucceededCallback, null);
			}
		}

		public static void ConnectForNewCustomers_SucceededCallback(object result, object context, string methodName)
		{
			if (IsConnected)
			{
				var customers = result.As<JsArray<MyDataItem>>();
				if (customers != null)
				{
					var divRepeater = document.getElementById("divRepeater1");
					for (var i = 0; i < customers.length; i++)
					{
						MyDataItem cust = customers[i];
						var div = document.createElement("div");
						div.innerText = "ID=" + cust.ID + " Name=" + cust.Text;
						divRepeater.appendChild(div);
					}
				}
				var service = new ConnectedWebService_Proxy();
				service.WaitForNewCustomers(1500, ConnectForNewCustomers_SucceededCallback, null);
			}
		}


	}
}
