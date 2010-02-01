using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	public interface XmlHttpRequest
	{
		[JsMethod(NativeOverloads = true)]
		void open(string method, string address, bool async);

		[JsMethod(NativeOverloads = true)]
		void send(string body);

		[JsProperty(NativeField = true)]
		string responseText { get; }

		[JsProperty(NativeField = true)]
		JsFunction onreadystatechange { get; set; }

		[JsProperty(NativeField = true)]
		int readyState { get; }

		[JsProperty(NativeField = true)]
		int status { get; }

		[JsProperty(NativeField = true)]
		string statusText { get; }

	}
}
