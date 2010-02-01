using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;

namespace SharpKit.JavaScriptModel
{
	[JsType(Name="arguments", Export=false)]
	public class JsArguments
	{
		[JsProperty(NativeIndexer=true)]
		public object this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		[JsProperty(NativeField=true)]
		public int length { get; private set; }
	}
}
