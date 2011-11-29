//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class XMLHttpRequest : XMLHttpRequestEventTarget
{

	// XMLHttpRequest
	public JsAction onreadystatechange {get; set; }
	public static short UNSENT = 0;
	public static short OPENED = 1;
	public static short HEADERS_RECEIVED = 2;
	public static short LOADING = 3;
	public static short DONE = 4;
	public short readyState {get; private set; }
	public void open(string method, string url) {}
	public void open(string method, string url, bool async) {}
	public void open(string method, string url, bool async, string user) {}
	public void open(string method, string url, bool async, string user, string password) {}
	public void setRequestHeader(string header, string value) {}
	public int timeout {get; set; }
	public bool withCredentials {get; set; }
	public XMLHttpRequestUpload upload {get; private set; }
	public void send() {}
	public void send(Blob data) {}
	public void send(Document data) {}
	public void send(string data) {}
	public void send(FormData data) {}
	public void abort() {}
	public short status {get; private set; }
	public JsString statusText {get; private set; }
	public JsString getResponseHeader(string header) { return default(JsString); }
	public JsString allResponseHeaders {get; private set; }
	public void overrideMimeType(string mime) {}
	public byte responseBody {get; private set; }
	public JsString responseText {get; private set; }
	public Document responseXML {get; private set; }
}

}