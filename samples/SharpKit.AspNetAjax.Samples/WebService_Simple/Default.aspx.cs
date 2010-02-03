using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace WebService_Simple
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
		// This function calls the Web Service method.  
		public static void EchoUserInput()
		{
			var echoElem = document.getElementById("EnteredValue").As<HtmlInput>();
			var service = new SimpleWebService_Proxy();
			service.EchoInput(echoElem.value, SucceededCallback);
		}

		// This is the callback function that
		// processes the Web Service return value.
		public static void SucceededCallback(string result)
		{
			var RsltElem = document.getElementById("Results");
			RsltElem.innerHTML = result;
		}
	}
}
