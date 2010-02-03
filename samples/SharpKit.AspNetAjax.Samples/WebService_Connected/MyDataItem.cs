using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScriptModel;

namespace WebService_Connected
{
	[JsType(JsMode.Json, Export = false)]
	[Serializable]
	public class MyDataItem
	{
		public long ID { get; set; }
		public string Text { get; set; }
	}

}
