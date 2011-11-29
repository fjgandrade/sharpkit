//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using Document = org.w3c.dom.Document;
using Element = org.w3c.dom.Element;
using CSSStyleDeclaration = org.w3c.dom.css.CSSStyleDeclaration;
using Database = org.w3c.dom.webdatabase.Database;
using DatabaseCallback = org.w3c.dom.webdatabase.DatabaseCallback;
using Storage = org.w3c.dom.webstorage.Storage;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class Window
{

	// Window
	public Window window {get { return default(Window); } }
	public Window self {get { return default(Window); } }
	public string name {get { return default(string); } set {}}
	public Location location {get { return default(Location); } set {}}
	public History history {get { return default(History); } }
	public UndoManager undoManager {get { return default(UndoManager); } }
	public Selection selection {get { return default(Selection); } }
	public object locationbar {get { return default(object); } set {}}
	public object menubar {get { return default(object); } set {}}
	public object personalbar {get { return default(object); } set {}}
	public object scrollbars {get { return default(object); } set {}}
	public object statusbar {get { return default(object); } set {}}
	public object toolbar {get { return default(object); } set {}}
	public void close() {}
	public void stop() {}
	public void focus() {}
	public void blur() {}
	public object frames {get { return default(object); } set {}}
	public object length {get { return default(object); } set {}}
	public Window top {get { return default(Window); } }
	public object opener {get { return default(object); } set {}}
	public Window parent {get { return default(Window); } }
	public Element frameElement {get { return default(Element); } }
	public Window open() { return default(Window); }
	public Window open(string url) { return default(Window); }
	public Window open(string url, string target) { return default(Window); }
	public Window open(string url, string target, string features) { return default(Window); }
	public Window open(string url, string target, string features, string replace) { return default(Window); }
	public Window getElement(int index) { return default(Window); }
	public object getElement(string name) { return default(object); }
	public void setElement(string name, object value) {}
	public Navigator navigator {get { return default(Navigator); } }
	public ApplicationCache applicationCache {get { return default(ApplicationCache); } }
	public void alert(string message) {}
	public bool confirm(string message) { return default(bool); }
	public string prompt(string message) { return default(string); }
	public string prompt(string message, string _default) { return default(string); }
	public void print() {}
	public object showModalDialog(string url) { return default(object); }
	public object showModalDialog(string url, object argument) { return default(object); }
	public void postMessage(object message, string targetOrigin) {}
	public void postMessage(object message, string targetOrigin, MessagePort[] ports) {}
	public JsAction onabort {get { return default(JsAction); } set {}}
	public JsAction onafterprint {get { return default(JsAction); } set {}}
	public JsAction onbeforeprint {get { return default(JsAction); } set {}}
	public JsAction onbeforeunload {get { return default(JsAction); } set {}}
	public JsAction onblur {get { return default(JsAction); } set {}}
	public JsAction oncanplay {get { return default(JsAction); } set {}}
	public JsAction oncanplaythrough {get { return default(JsAction); } set {}}
	public JsAction onchange {get { return default(JsAction); } set {}}
	public JsAction onclick {get { return default(JsAction); } set {}}
	public JsAction oncontextmenu {get { return default(JsAction); } set {}}
	public JsAction ondblclick {get { return default(JsAction); } set {}}
	public JsAction ondrag {get { return default(JsAction); } set {}}
	public JsAction ondragend {get { return default(JsAction); } set {}}
	public JsAction ondragenter {get { return default(JsAction); } set {}}
	public JsAction ondragleave {get { return default(JsAction); } set {}}
	public JsAction ondragover {get { return default(JsAction); } set {}}
	public JsAction ondragstart {get { return default(JsAction); } set {}}
	public JsAction ondrop {get { return default(JsAction); } set {}}
	public JsAction ondurationchange {get { return default(JsAction); } set {}}
	public JsAction onemptied {get { return default(JsAction); } set {}}
	public JsAction onended {get { return default(JsAction); } set {}}
	public JsAction onerror {get { return default(JsAction); } set {}}
	public JsAction onfocus {get { return default(JsAction); } set {}}
	public JsAction onformchange {get { return default(JsAction); } set {}}
	public JsAction onforminput {get { return default(JsAction); } set {}}
	public JsAction onhashchange {get { return default(JsAction); } set {}}
	public JsAction oninput {get { return default(JsAction); } set {}}
	public JsAction oninvalid {get { return default(JsAction); } set {}}
	public JsAction onkeydown {get { return default(JsAction); } set {}}
	public JsAction onkeypress {get { return default(JsAction); } set {}}
	public JsAction onkeyup {get { return default(JsAction); } set {}}
	public JsAction onload {get { return default(JsAction); } set {}}
	public JsAction onloadeddata {get { return default(JsAction); } set {}}
	public JsAction onloadedmetadata {get { return default(JsAction); } set {}}
	public JsAction onloadstart {get { return default(JsAction); } set {}}
	public JsAction onmessage {get { return default(JsAction); } set {}}
	public JsAction onmousedown {get { return default(JsAction); } set {}}
	public JsAction onmousemove {get { return default(JsAction); } set {}}
	public JsAction onmouseout {get { return default(JsAction); } set {}}
	public JsAction onmouseover {get { return default(JsAction); } set {}}
	public JsAction onmouseup {get { return default(JsAction); } set {}}
	public JsAction onmousewheel {get { return default(JsAction); } set {}}
	public JsAction onoffline {get { return default(JsAction); } set {}}
	public JsAction ononline {get { return default(JsAction); } set {}}
	public JsAction onpause {get { return default(JsAction); } set {}}
	public JsAction onplay {get { return default(JsAction); } set {}}
	public JsAction onplaying {get { return default(JsAction); } set {}}
	public JsAction onpagehide {get { return default(JsAction); } set {}}
	public JsAction onpageshow {get { return default(JsAction); } set {}}
	public JsAction onpopstate {get { return default(JsAction); } set {}}
	public JsAction onprogress {get { return default(JsAction); } set {}}
	public JsAction onratechange {get { return default(JsAction); } set {}}
	public JsAction onreadystatechange {get { return default(JsAction); } set {}}
	public JsAction onredo {get { return default(JsAction); } set {}}
	public JsAction onresize {get { return default(JsAction); } set {}}
	public JsAction onscroll {get { return default(JsAction); } set {}}
	public JsAction onseeked {get { return default(JsAction); } set {}}
	public JsAction onseeking {get { return default(JsAction); } set {}}
	public JsAction onselect {get { return default(JsAction); } set {}}
	public JsAction onshow {get { return default(JsAction); } set {}}
	public JsAction onstalled {get { return default(JsAction); } set {}}
	public JsAction onstorage {get { return default(JsAction); } set {}}
	public JsAction onsubmit {get { return default(JsAction); } set {}}
	public JsAction onsuspend {get { return default(JsAction); } set {}}
	public JsAction ontimeupdate {get { return default(JsAction); } set {}}
	public JsAction onundo {get { return default(JsAction); } set {}}
	public JsAction onunload {get { return default(JsAction); } set {}}
	public JsAction onvolumechange {get { return default(JsAction); } set {}}
	public JsAction onwaiting {get { return default(JsAction); } set {}}

	// Window-1
	public CSSStyleDeclaration getComputedStyle(Element elt) { return default(CSSStyleDeclaration); }
	public CSSStyleDeclaration getComputedStyle(Element elt, string pseudoElt) { return default(CSSStyleDeclaration); }

	// Window-2
	public Document document {get { return default(Document); } }
	public StyleMedia styleMedia {get { return default(StyleMedia); } }
	public Screen screen {get { return default(Screen); } }
	public int innerWidth {get { return default(int); } }
	public int innerHeight {get { return default(int); } }
	public int pageXOffset {get { return default(int); } }
	public int pageYOffset {get { return default(int); } }
	public void scroll(int x, int y) {}
	public void scrollTo(int x, int y) {}
	public void scrollBy(int x, int y) {}
	public int screenX {get { return default(int); } }
	public int screenY {get { return default(int); } }
	public int outerWidth {get { return default(int); } }
	public int outerHeight {get { return default(int); } }

	// WindowTimers
	public int setTimeout(object handler) { return default(int); }
	public int setTimeout(object handler, object timeout, params object[] args) { return default(int); }
	public void clearTimeout(int handle) {}
	public int setInterval(object handler) { return default(int); }
	public int setInterval(object handler, object timeout, params object[] args) { return default(int); }
	public void clearInterval(int handle) {}

	// WindowDatabase
	public Database openDatabase(string name, string version, string displayName, int estimatedSize) { return default(Database); }
	public Database openDatabase(string name, string version, string displayName, int estimatedSize, DatabaseCallback creationCallback) { return default(Database); }

	// WindowSessionStorage
	public Storage sessionStorage {get { return default(Storage); } }

	// WindowLocalStorage
	public Storage localStorage {get { return default(Storage); } }
}

}