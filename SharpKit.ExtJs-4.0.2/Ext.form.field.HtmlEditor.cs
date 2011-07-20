//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region HtmlEditor
    /// <summary>
    /// Provides a lightweight HTML Editor component. Some toolbar features are not supported by Safari and will be
    /// automatically hidden when needed. These are noted in the config options where appropriate. The editor&#39;s toolbar buttons have tooltips defined in the buttonTips property, but they are not
    /// enabled by default unless the global Ext.tip.QuickTipManager singleton is initialized. An Editor is a sensitive component that can&#39;t be used in all spots standard fields can be used. Putting an Editor within
    /// any element that has display set to &#39;none&#39; can cause problems in Safari and Firefox due to their default iframe reloading bugs.  Example usage  // Simple example rendered with default options:
    /// Ext.tip.QuickTips.init();  // enable tooltips
    /// Ext.create(&#39;Ext.form.HtmlEditor&#39;, {
    /// width: 580,
    /// height: 250,
    /// renderTo: Ext.getBody()
    /// });
    /// // Passed via xtype into a container and with custom options:
    /// Ext.tip.QuickTips.init();  // enable tooltips
    /// new Ext.panel.Panel({
    /// title: &#39;HTML Editor&#39;,
    /// renderTo: Ext.getBody(),
    /// width: 550,
    /// height: 250,
    /// frame: true,
    /// layout: &#39;fit&#39;,
    /// items: {
    /// xtype: &#39;htmleditor&#39;,
    /// enableColors: false,
    /// enableAlignments: false
    /// }
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class HtmlEditor : Ext.Component, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// A utility for grouping a set of modifications which may trigger value changes into a single
        /// transaction, to prevent e...
        /// </summary>
        public object batchChanges(object fn){return null;}
        /// <summary>
        /// Checks whether the value of the field has changed since the last time it was checked. ...
        /// </summary>
        public object checkChange(){return null;}
        /// <summary>
        /// Checks the isDirty state of the field and if it has changed since the last time
        /// it was checked, fires the dirtychange...
        /// </summary>
        public object checkDirty(){return null;}
        /// <summary>
        /// Protected method that will not generally be called directly. ...
        /// </summary>
        public JsString cleanHtml(JsString html){return null;}
        /// <summary>
        /// Clear any invalid styles/messages for this field. ...
        /// </summary>
        public object clearInvalid(){return null;}
        /// <summary>
        /// Executes a Midas editor command directly on the editor document. ...
        /// </summary>
        public object execCmd(JsString cmd, object value=null){return null;}
        /// <summary>
        /// Only relevant if the instance's isFileUpload method returns true. ...
        /// </summary>
        public HTMLInputElement extractFileInput(){return null;}
        /// <summary>
        /// Gets the active error message for this component, if any. ...
        /// </summary>
        public JsString getActiveError(){return null;}
        /// <summary>
        /// Gets an Array of any active error messages currently applied to the field. ...
        /// </summary>
        public JsArray getActiveErrors(){return null;}
        /// <summary>
        /// Calculate and return the natural width of the bodyEl. ...
        /// </summary>
        public object getBodyNaturalWidth(){return null;}
        /// <summary>
        /// Protected method that will not generally be called directly. ...
        /// </summary>
        public object getDocMarkup(){return null;}
        /// <summary>
        /// Runs this field's validators and returns an array of error messages for any validation failures. ...
        /// </summary>
        public JsArray getErrors(object value){return null;}
        /// <summary>
        /// Returns the label for the field. ...
        /// </summary>
        public JsString getFieldLabel(){return null;}
        /// <summary>
        /// Get the input id, if any, for this component. ...
        /// </summary>
        public JsString getInputId(){return null;}
        /// <summary>
        /// Generates the arguments for the field decorations rendering template. ...
        /// </summary>
        public object getLabelableRenderData(){return null;}
        /// <summary>
        /// Returns the additional Ext.AbstractComponent.renderSelectors for selecting the field
        /// decoration elements from the ren...
        /// </summary>
        public object getLabelableSelectors(){return null;}
        /// <summary>
        /// Returns the value(s) that should be saved to the Ext.data.Model instance for this field, when
        /// Ext.form.Basic.updateRe...
        /// </summary>
        public object getModelData(){return null;}
        /// <summary>
        /// Returns the name attribute of the field. ...
        /// </summary>
        public new JsString getName(){return null;}
        /// <summary>
        /// Gets the markup to be inserted into the outer template's bodyEl. ...
        /// </summary>
        public JsString getSubTplMarkup(){return null;}
        /// <summary>
        /// Returns the parameter(s) that would be included in a standard form submit for this field. ...
        /// </summary>
        public object getSubmitData(){return null;}
        /// <summary>
        /// Returns the editor's toolbar. ...
        /// </summary>
        public Ext.toolbar.Toolbar getToolbar(){return null;}
        /// <summary>
        /// Returns the current data value of the field. ...
        /// </summary>
        public object getValue(){return null;}
        /// <summary>
        /// Tells whether the field currently has an active error message. ...
        /// </summary>
        public bool hasActiveError(){return false;}
        /// <summary>
        /// Initializes this Field mixin on the current instance. ...
        /// </summary>
        public object initField(){return null;}
        /// <summary>
        /// Performs initialization of this mixin. ...
        /// </summary>
        public object initLabelable(){return null;}
        /// <summary>
        /// Initializes the field's value based on the initial config. ...
        /// </summary>
        public object initValue(){return null;}
        /// <summary>
        /// Inserts the passed text at the current cursor position. ...
        /// </summary>
        public object insertAtCursor(JsString text){return null;}
        /// <summary>
        /// Returns true if the value of this Field has been changed from its originalValue. ...
        /// </summary>
        public bool isDirty(){return false;}
        /// <summary>
        /// Returns whether two field values are logically equal. ...
        /// </summary>
        public bool isEqual(object value1, object value2){return false;}
        /// <summary>
        /// Returns whether this Field is a file upload field; if it returns true, forms will use
        /// special techniques for submitti...
        /// </summary>
        public bool isFileUpload(){return false;}
        /// <summary>
        /// Returns whether or not the field value is currently valid by validating the
        /// field's current value. ...
        /// </summary>
        public bool isValid(){return false;}
        /// <summary>
        /// Associate one or more error messages with this field. ...
        /// </summary>
        public object markInvalid(object errors){return null;}
        /// <summary>
        /// method that will not generally be called directly. ...
        /// </summary>
        public object pushValue(){return null;}
        /// <summary>
        /// Executes a Midas editor command on the editor document and performs necessary focus and
        /// toolbar updates. ...
        /// </summary>
        public object relayCmd(JsString cmd, object value=null){return null;}
        /// <summary>
        /// Resets the current field value to the originally loaded value and clears any validation messages. ...
        /// </summary>
        public object reset(){return null;}
        /// <summary>
        /// Resets the field's originalValue property so it matches the current value. ...
        /// </summary>
        public object resetOriginalValue(){return null;}
        /// <summary>
        /// Sets the active error message to the given string. ...
        /// </summary>
        public object setActiveError(JsString msg){return null;}
        /// <summary>
        /// Set the active error message to an Array of error messages. ...
        /// </summary>
        public object setActiveErrors(JsArray errors){return null;}
        /// <summary>
        /// Applies a set of default configuration values to this Labelable instance. ...
        /// </summary>
        public object setFieldDefaults(object defaults){return null;}
        /// <summary>
        /// Sets the read only state of this field. ...
        /// </summary>
        public object setReadOnly(bool readOnly){return null;}
        /// <summary>
        /// Sets a data value into the field and runs the change detection and validation. ...
        /// </summary>
        public Ext.form.field.Field setValue(object value){return null;}
        /// <summary>
        /// method that will not generally be called directly. ...
        /// </summary>
        public object syncValue(){return null;}
        /// <summary>
        /// Toggles the editor between standard and source edit mode. ...
        /// </summary>
        public object toggleSourceEdit(bool sourceEditMode=false){return null;}
        /// <summary>
        /// Clears the active error message(s). ...
        /// </summary>
        public object unsetActiveError(){return null;}
        /// <summary>
        /// Protected method that will not generally be called directly. ...
        /// </summary>
        public object updateToolbar(){return null;}
        /// <summary>
        /// Returns whether or not the field value is currently valid by validating the
        /// field's current value, and fires the vali...
        /// </summary>
        public bool validate(){return false;}
        /// <summary>
        /// The div Element wrapping the component's contents. ...
        /// </summary>
        public Ext.core.Element bodyEl{get;set;}
        /// <summary>
        /// Object collection of toolbar tooltips for the buttons in the editor. ...
        /// </summary>
        public object buttonTips{get;set;}
        /// <summary>
        /// The div Element that will contain the component's error message(s). ...
        /// </summary>
        public Ext.core.Element errorEl{get;set;}
        /// <summary>
        /// Flag denoting that this object is labelable as a field. ...
        /// </summary>
        public bool isFieldLabelable{get;set;}
        /// <summary>
        /// Flag denoting that this component is a Field. ...
        /// </summary>
        public bool isFormField{get;set;}
        /// <summary>
        /// The label Element for this component. ...
        /// </summary>
        public Ext.core.Element labelEl{get;set;}
        /// <summary>
        /// The original value of the field as configured in the value configuration, or as loaded by
        /// the last form load operatio...
        /// </summary>
        public object originalValue{get;set;}
        public HtmlEditor(HtmlEditorConfig config){}
        public HtmlEditor(){}
    }
    #endregion
    #region HtmlEditorConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class HtmlEditorConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// If specified, then the component will be displayed with this value as its active error when
        /// first rendered. ...
        /// </summary>
        public JsString activeError{get;set;}
        /// <summary>
        /// The template used to format the Array of error messages passed to setActiveErrors
        /// into a single HTML string. ...
        /// </summary>
        public XTemplate activeErrorsTpl{get;set;}
        /// <summary>
        /// Whether to adjust the component's body area to make room for 'side' or 'under'
        /// error messages. ...
        /// </summary>
        public bool autoFitErrors{get;set;}
        /// <summary>
        /// The CSS class to be applied to the body content element. ...
        /// </summary>
        public JsString baseBodyCls{get;set;}
        /// <summary>
        /// The CSS class to be applied to the special clearing div rendered directly after the field
        /// contents wrapper to provide...
        /// </summary>
        public JsString clearCls{get;set;}
        public JsString createLinkText{get;set;}
        public JsString defaultLinkValue{get;set;}
        /// <summary>
        /// A default value to be put into the editor to resolve focus issues (defaults to &#160; (Non-breaking space) in Opera a...
        /// </summary>
        public JsString defaultValue{get;set;}
        /// <summary>
        /// True to disable the field (defaults to false). ...
        /// </summary>
        public new bool disabled{get;set;}
        public bool enableAlignments{get;set;}
        public bool enableColors{get;set;}
        /// <summary>
        /// Enable font selection. ...
        /// </summary>
        public bool enableFont{get;set;}
        public bool enableFontSize{get;set;}
        public bool enableFormat{get;set;}
        /// <summary>
        /// Enable the create link button. ...
        /// </summary>
        public bool enableLinks{get;set;}
        /// <summary>
        /// Enable the bullet and numbered list buttons. ...
        /// </summary>
        public bool enableLists{get;set;}
        /// <summary>
        /// Enable the switch to source edit button. ...
        /// </summary>
        public bool enableSourceEdit{get;set;}
        /// <summary>
        /// The CSS class to be applied to the error message element. ...
        /// </summary>
        public JsString errorMsgCls{get;set;}
        /// <summary>
        /// An extra CSS class to be applied to the body content element in addition to fieldBodyCls. ...
        /// </summary>
        public JsString fieldBodyCls{get;set;}
        /// <summary>
        /// The label for the field. ...
        /// </summary>
        public JsString fieldLabel{get;set;}
        public JsArray fontFamilies{get;set;}
        /// <summary>
        /// A CSS class to be applied to the outermost element to denote that it is participating in the form
        /// field layout. ...
        /// </summary>
        public JsString formItemCls{get;set;}
        /// <summary>
        /// When set to true, the label element (fieldLabel and labelSeparator) will be
        /// automatically hidden if the fieldLabel is...
        /// </summary>
        public bool hideEmptyLabel{get;set;}
        /// <summary>
        /// Set to true to completely hide the label element (fieldLabel and labelSeparator). ...
        /// </summary>
        public bool hideLabel{get;set;}
        public JsString invalidCls{get;set;}
        /// <summary>
        /// Controls the position and alignment of the fieldLabel. ...
        /// </summary>
        public JsString labelAlign{get;set;}
        /// <summary>
        /// The CSS class to be applied to the label element. ...
        /// </summary>
        public JsString labelCls{get;set;}
        /// <summary>
        /// The amount of space in pixels between the fieldLabel and the input field. ...
        /// </summary>
        public JsNumber labelPad{get;set;}
        public JsString labelSeparator{get;set;}
        /// <summary>
        /// A CSS style specification string to apply directly to this field's label. ...
        /// </summary>
        public JsString labelStyle{get;set;}
        /// <summary>
        /// The width of the fieldLabel in pixels. ...
        /// </summary>
        public JsNumber labelWidth{get;set;}
        /// <summary>
        /// The rendering template for the field decorations. ...
        /// </summary>
        public object labelableRenderTpl{get;set;}
        /// <summary>
        /// The location where the error message text should display. ...
        /// </summary>
        public JsString msgTarget{get;set;}
        /// <summary>
        /// The name of the field (defaults to undefined). ...
        /// </summary>
        public JsString name{get;set;}
        /// <summary>
        /// true to disable displaying any error message set on this object. ...
        /// </summary>
        public bool preventMark{get;set;}
        /// <summary>
        /// Setting this to false will prevent the field from being
        /// submitted even when it is not disabled. ...
        /// </summary>
        public bool submitValue{get;set;}
        /// <summary>
        /// Specifies whether this field should be validated immediately whenever a change in its value is detected. ...
        /// </summary>
        public bool validateOnChange{get;set;}
        public object value{get;set;}
    }
    #endregion
    #region HtmlEditorEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class HtmlEditorEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires when the editor is first receives the focus. ...
        /// </summary>
        public static new JsString activate="activate";
        /// <summary>
        /// Fires before the iframe editor is updated with content from the textarea. ...
        /// </summary>
        public static JsString beforepush="beforepush";
        /// <summary>
        /// Fires before the textarea is updated with content from the editor iframe. ...
        /// </summary>
        public static JsString beforesync="beforesync";
        /// <summary>
        /// Fires when a user-initiated change is detected in the value of the field. ...
        /// </summary>
        public static JsString change="change";
        /// <summary>
        /// Fires when a change in the field's isDirty state is detected. ...
        /// </summary>
        public static JsString dirtychange="dirtychange";
        /// <summary>
        /// Fires when the editor switches edit modes ...
        /// </summary>
        public static JsString editmodechange="editmodechange";
        /// <summary>
        /// Fires when the active error message is changed via setActiveError. ...
        /// </summary>
        public static JsString errorchange="errorchange";
        /// <summary>
        /// Fires when the editor is fully initialized (including the iframe) ...
        /// </summary>
        public static JsString initialize="initialize";
        /// <summary>
        /// Fires when the iframe editor is updated with content from the textarea. ...
        /// </summary>
        public static JsString push="push";
        /// <summary>
        /// Fires when the textarea is updated with content from the editor iframe. ...
        /// </summary>
        public static JsString sync="sync";
        /// <summary>
        /// Fires when a change in the field's validity is detected. ...
        /// </summary>
        public static JsString validitychange="validitychange";
    }
    #endregion
}
#endregion
