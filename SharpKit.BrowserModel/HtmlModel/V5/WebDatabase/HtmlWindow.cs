using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	public partial class HtmlWindow : WindowDatabase
	{
		#region WindowDatabase Members

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public Database openDatabase(string name, string version, string displayName, ulong estimatedSize)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public Database openDatabase(string name, string version, string displayName, ulong estimatedSize, DatabaseCallback creationCallback)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}