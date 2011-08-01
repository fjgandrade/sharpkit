using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom
{

    using Blob = org.w3c.dom.file.Blob;
    using Function = org.w3c.dom.html.Function;

    public interface XMLHttpRequest : XMLHttpRequestEventTarget
    {
        // XMLHttpRequest
        Function onreadystatechange {get;set;}
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short UNSENT = 0;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short OPENED = 1;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short HEADERS_RECEIVED = 2;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short LOADING = 3;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short DONE = 4;
        short readyState {get;}
        void open(string method, JsString url);
        void open(string method, JsString url, bool async);
        void open(string method, JsString url, bool async, JsString user);
        void open(string method, JsString url, bool async, JsString user, JsString password);
        void setRequestHeader(string header, JsString value);
        int timeout {get;set;}
        bool withCredentials {get;set;}
        XMLHttpRequestUpload upload {get;}
        void send();
        void send(Blob data);
        void send(Document data);
        void send(string data);
        void send(FormData data);
        void abort();
        short status {get;}
        JsString statusText {get;}
        JsString getResponseHeader(string header);
        JsString allResponseHeaders {get;}
        void overrideMimeType(string mime);
        sbyte[] responseBody {get;}
        JsString responseText {get;}
        Document responseXML {get;}
    }

}
