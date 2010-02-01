using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	public class StyleFilterCollection
	{
		[JsMethod(NativeOverloads = true)]
		public StyleFilter item(string name)
		{
			throw new NotImplementedException("style filters not implemented");
		}
	}
}
