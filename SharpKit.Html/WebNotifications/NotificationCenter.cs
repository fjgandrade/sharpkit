//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class NotificationCenter
{

	// NotificationCenter
	public static int PERMISSION_ALLOWED = 0;
	public static int PERMISSION_UNKNOWN = 1;
	public static int PERMISSION_DENIED = 2;
	public int permissionLevel {get; set; }
	public Notification createNotification(string iconUrl, string title, string body) { return default(Notification); }
	public Notification createHtmlNotification(string url) { return default(Notification); }
	public void requestPermission(JsAction callback) {}

	// NotificationCenter-44
	public Notification createWebNotification(string url) { return default(Notification); }
}

}