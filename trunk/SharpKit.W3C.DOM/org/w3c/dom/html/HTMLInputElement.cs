using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    using NodeList = org.w3c.dom.NodeList;
    using File = org.w3c.dom.file.File;

    public interface HTMLInputElement : HTMLElement
    {
        // HTMLInputElement
        JsString accept {get;set;}
        JsString alt {get;set;}
        bool autocomplete {get;set;}
        bool autofocus {get;set;}
        bool defaultChecked {get;set;}
        bool @checked {get;set;}
        bool disabled {get;set;}
        HTMLFormElement form {get;}
        File[] files {get;}
        JsString formAction {get;set;}
        JsString formEnctype {get;set;}
        JsString formMethod {get;set;}
        bool formNoValidate {get;set;}
        JsString formTarget {get;set;}
        JsString height {get;set;}
        bool indeterminate {get;set;}
        HTMLElement list {get;}
        JsString max {get;set;}
        int maxLength {get;set;}
        JsString min {get;set;}
        bool multiple {get;set;}
        JsString name {get;set;}
        JsString pattern {get;set;}
        JsString placeholder {get;set;}
        bool readOnly {get;set;}
        bool required {get;set;}
        int size {get;set;}
        JsString src {get;set;}
        JsString step {get;set;}
        JsString type {get;set;}
        JsString defaultValue {get;set;}
        JsString value {get;set;}
        long valueAsDate {get;set;}
        float valueAsNumber {get;set;}
        HTMLOptionElement selectedOption {get;}
        JsString width {get;set;}
        void stepUp();
        void stepUp(int n);
        void stepDown();
        void stepDown(int n);
        bool willValidate {get;}
        ValidityState validity {get;}
        JsString validationMessage {get;}
        bool checkValidity();
        JsString customValidity {set;}
        NodeList labels {get;}
        void select();
        int selectionStart {get;set;}
        int selectionEnd {get;set;}
        void setSelectionRange(int start, int end);
        // HTMLInputElement-19
        JsString align {get;set;}
        JsString useMap {get;set;}
    }

}
