//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.smil
{

using SharpKit.JavaScript;
using Event = org.w3c.dom.events.Event;
using AbstractView = org.w3c.dom.views.AbstractView;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class TimeEvent : Event
{

	// TimeEvent
	public AbstractView view {get { return default(AbstractView); } }
	public int detail {get { return default(int); } }
	public void initTimeEvent(string typeArg, AbstractView viewArg, int detailArg) {}
}

}