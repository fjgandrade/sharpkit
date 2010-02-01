using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	public partial class HtmlWindow : WindowSessionStorage, WindowLocalStorage
	{
		#region WindowSessionStorage Members

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public Storage sessionStorage
		{
			get { throw new NotImplementedException(); }
		}

		#endregion

		#region WindowLocalStorage Members

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public Storage localStorage
		{
			get { throw new NotImplementedException(); }
		}

		#endregion
	}
}