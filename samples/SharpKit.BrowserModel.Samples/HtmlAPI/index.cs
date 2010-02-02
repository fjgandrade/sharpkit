using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace HtmlAPI
{
	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		public static bool tbNewTask_onkeypress(HtmlInput sender, HtmlDomEventArgs e)
		{
			//If enter is hit, blur the input
			if (e.keyCode == 13)
			{
				sender.blur();
				return false;
			}
			return true;
		}

		public static bool tbNewTask_onblur(HtmlInput sender, HtmlDomEventArgs e)
		{
			//when input is blured, insert a new item if it is not empty
			if (sender.value == null || sender.value == "")
				return false;
			var ul = document.getElementById("ulTaskList").As<HtmlUnorderedList>();
			var li = document.createElement<HtmlListItem>("li");
			li.appendChild(document.createTextNode(sender.value));
			var liNewTask = document.getElementById("liNewTask").As<HtmlListItem>();
			liNewTask.insertAdjacentElement("beforeBegin", li);

			//reset the input to blank
			sender.value = "";
			sender.focus();
			return true;
		}
	}
}
