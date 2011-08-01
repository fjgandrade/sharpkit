using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    using NodeList = org.w3c.dom.NodeList;

    public interface HTMLButtonElement : HTMLElement
    {
        // HTMLButtonElement
        bool autofocus {get;set;}
        bool disabled {get;set;}
        HTMLFormElement form {get;}
        JsString formAction {get;set;}
        JsString formEnctype {get;set;}
        JsString formMethod {get;set;}
        JsString formNoValidate {get;set;}
        JsString formTarget {get;set;}
        JsString name {get;set;}
        JsString type {get;set;}
        JsString value {get;set;}
        bool willValidate {get;}
        ValidityState validity {get;}
        JsString validationMessage {get;}
        bool checkValidity();
        JsString customValidity {set;}
        NodeList labels {get;}
    }

}
