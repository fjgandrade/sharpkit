using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.ls
{

    using Document = org.w3c.dom.Document;
    using Event = org.w3c.dom.events.Event;

    public interface LSLoadEvent : org.w3c.dom.events.Event
    {
        // LSLoadEvent
        Document newDocument {get;}
        LSInput input {get;}
    }

}