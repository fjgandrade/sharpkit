using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[JsType(Export = false, Name = "SQLResultSet")]
	[HtmlSpecificationVersion(5)]
	public interface SQLResultSet
	{
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		long insertId { get; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		long rowsAffected { get; }

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		SQLResultSetRowList rows { get; }
	}
}
