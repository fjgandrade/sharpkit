using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	//[JsType(Export = false,Name = "WorkerUtils")] //Duplicate
	//[HtmlSpecificationVersion(5)] //Duplicate
	public partial class WorkerUtils : WorkerUtilsDatabase
	{
		#region WorkerUtilsDatabase Members

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

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public DatabaseSync openDatabaseSync(string name, string version, string displayName, ulong estimatedSize)
		{
			throw new NotImplementedException();
		}

		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeOverloads = true)]
		public DatabaseSync openDatabaseSync(string name, string version, string displayName, ulong estimatedSize, DatabaseCallback creationCallback)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
