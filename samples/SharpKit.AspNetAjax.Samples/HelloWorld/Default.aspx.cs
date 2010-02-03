using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace HelloWorld
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
	}

	[JsType(JsMode.Global, "Default.aspx.js")]
	public class Default_Client : AspNetAjaxContext
	{
		public static bool btn_click()
		{
			alert("Your browser is "+ Sys.Browser.name + " " + Sys.Browser.version);
			return false;
		}
	}
}
