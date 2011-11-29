//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class ApplicationCache
{

	// ApplicationCache
	public static short UNCACHED = 0;
	public static short IDLE = 1;
	public static short CHECKING = 2;
	public static short DOWNLOADING = 3;
	public static short UPDATEREADY = 4;
	public static short OBSOLETE = 5;
	public short status {get { return default(short); } }
	public void update() {}
	public void swapCache() {}
	public JsAction onchecking {get { return default(JsAction); } set {}}
	public JsAction onerror {get { return default(JsAction); } set {}}
	public JsAction onnoupdate {get { return default(JsAction); } set {}}
	public JsAction ondownloading {get { return default(JsAction); } set {}}
	public JsAction onprogress {get { return default(JsAction); } set {}}
	public JsAction onupdateready {get { return default(JsAction); } set {}}
	public JsAction oncached {get { return default(JsAction); } set {}}
	public JsAction onobsolete {get { return default(JsAction); } set {}}
}

}