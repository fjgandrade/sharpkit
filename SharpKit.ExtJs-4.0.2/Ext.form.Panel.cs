//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region Panel
    /// <summary>
    /// FormPanel provides a standard container for forms. It is essentially a standard Ext.panel.Panel which
    /// automatically creates a BasicForm for managing any Ext.form.field.Field
    /// objects that are added as descendants of the panel. It also includes conveniences for configuring and
    /// working with the BasicForm and the collection of Fields. Layout By default, FormPanel is configured with layout:&#39;anchor&#39; for
    /// the layout of its immediate child items. This can be changed to any of the supported container layouts.
    /// The layout of sub-containers is configured in the standard way. BasicForm Although not listed as configuration options of FormPanel, the FormPanel class accepts all
    /// of the config options supported by the Ext.form.Basic class, and will pass them along to
    /// the internal BasicForm when it is created. Note**: If subclassing FormPanel, any configuration options for the BasicForm must be applied to
    /// the initialConfig property of the FormPanel. Applying BasicForm
    /// configuration settings to this will not* affect the BasicForm&#39;s configuration. The following events fired by the BasicForm will be re-fired by the FormPanel and can therefore be
    /// listened for on the FormPanel itself:  beforeaction actionfailed actioncomplete validitychange dirtychange  Field Defaults The fieldDefaults config option conveniently allows centralized configuration of default values
    /// for all fields added as descendants of the FormPanel. Any config option recognized by implementations
    /// of Ext.form.Labelable may be included in this object. See the fieldDefaults documentation
    /// for details of how the defaults are applied. Form Validation With the default configuration, form fields are validated on-the-fly while the user edits their values.
    /// This can be controlled on a per-field basis (or via the fieldDefaults config) with the field
    /// config properties Ext.form.field.Field.validateOnChange and Ext.form.field.Base.checkChangeEvents,
    /// and the FormPanel&#39;s config properties pollForChanges and pollInterval. Any component within the FormPanel can be configured with formBind: true. This will cause that
    /// component to be automatically disabled when the form is invalid, and enabled when it is valid. This is most
    /// commonly used for Button components to prevent submitting the form in an invalid state, but can be used on
    /// any component type. For more information on form validation see the following:  Ext.form.field.Field.validateOnChange pollForChanges and pollInterval Ext.form.field.VTypes BasicForm.doAction clientValidation notes  Form Submission By default, Ext Forms are submitted through Ajax, using Ext.form.action.Action. See the documentation for
    /// Ext.form.Basic for details.
    /// Example usage: Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;Simple Form&#39;,
    /// bodyPadding: 5,
    /// width: 350,
    /// // The form will submit an AJAX request to this URL when submitted
    /// url: &#39;save-form.php&#39;,
    /// // Fields will be arranged vertically, stretched to full width
    /// layout: &#39;anchor&#39;,
    /// defaults: {
    /// anchor: &#39;100%&#39;
    /// },
    /// // The fields
    /// defaultType: &#39;textfield&#39;,
    /// items: [{
    /// fieldLabel: &#39;First Name&#39;,
    /// name: &#39;first&#39;,
    /// allowBlank: false
    /// },{
    /// fieldLabel: &#39;Last Name&#39;,
    /// name: &#39;last&#39;,
    /// allowBlank: false
    /// }],
    /// // Reset and Submit buttons
    /// buttons: [{
    /// text: &#39;Reset&#39;,
    /// handler: function() {
    /// this.up(&#39;form&#39;).getForm().reset();
    /// }
    /// }, {
    /// text: &#39;Submit&#39;,
    /// formBind: true, //only enabled once the form is valid
    /// disabled: true,
    /// handler: function() {
    /// var form = this.up(&#39;form&#39;).getForm();
    /// if (form.isValid()) {
    /// form.submit({
    /// success: function(form, action) {
    /// Ext.Msg.alert(&#39;Success&#39;, action.result.msg);
    /// },
    /// failure: function(form, action) {
    /// Ext.Msg.alert(&#39;Failed&#39;, action.result.msg);
    /// }
    /// });
    /// }
    /// }
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Panel : Ext.panel.Panel, FieldAncestor, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Forces each field within the form panel to
        /// check if its value has changed. ...
        /// </summary>
        public object checkChange(){return null;}
        /// <summary>
        /// Provides access to the Form which this Panel contains. ...
        /// </summary>
        public Basic getForm(){return null;}
        /// <summary>
        /// Returns the currently loaded Ext.data.Model instance if one was loaded via loadRecord. ...
        /// </summary>
        public Ext.data.Model getRecord(){return null;}
        /// <summary>
        /// Convenience function for fetching the current value of each field in the form. ...
        /// </summary>
        public object getValues(){return null;}
        /// <summary>
        /// Initializes the FieldAncestor's state; this must be called from the initComponent method
        /// of any components importing ...
        /// </summary>
        public object initFieldAncestor(){return null;}
        /// <summary>
        /// This is a proxy for the underlying BasicForm's Ext.form.Basic.load call. ...
        /// </summary>
        public object load(object options){return null;}
        /// <summary>
        /// Loads an Ext.data.Model into this form (internally just calls Ext.form.Basic.loadRecord)
        /// See also trackResetOnLoad. ...
        /// </summary>
        public Basic loadRecord(Ext.data.Model record){return null;}
        /// <summary>
        /// Called when a Ext.form.field.Field instance is added to the container's subtree. ...
        /// </summary>
        public object onFieldAdded(Ext.form.field.Field field){return null;}
        /// <summary>
        /// Called when a Ext.form.field.Field instance is removed from the container's subtree. ...
        /// </summary>
        public object onFieldRemoved(Ext.form.field.Field field){return null;}
        /// <summary>
        /// Called when a Ext.form.Labelable instance is added to the container's subtree. ...
        /// </summary>
        public object onLabelableAdded(Labelable labelable){return null;}
        /// <summary>
        /// Called when a Ext.form.Labelable instance is removed from the container's subtree. ...
        /// </summary>
        public object onLabelableRemoved(Labelable labelable){return null;}
        /// <summary>
        /// Start an interval task to continuously poll all the fields in the form for changes in their
        /// values. ...
        /// </summary>
        public object startPolling(JsNumber interval){return null;}
        /// <summary>
        /// Stop a running interval task that was started by startPolling. ...
        /// </summary>
        public object stopPolling(){return null;}
        /// <summary>
        /// This is a proxy for the underlying BasicForm's Ext.form.Basic.submit call. ...
        /// </summary>
        public object submit(object options){return null;}
        public object onFieldErrorChange{get;set;}
        public object onFieldValidityChange{get;set;}
        public Panel(Ext.form.PanelConfig config){}
        public Panel(){}
    }
    #endregion
    #region PanelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class PanelConfig : Ext.panel.PanelConfig
    {
        /// <summary>
        /// If specified, the properties in this object are used as default config values for each
        /// Ext.form.Labelable instance (e.g. ...
        /// </summary>
        public object fieldDefaults{get;set;}
        /// <summary>
        /// The Ext.container.Container.layout for the form panel's immediate child items. ...
        /// </summary>
        public new JsString layout{get;set;}
        /// <summary>
        /// If set to true, sets up an interval task (using the pollInterval) in which the
        /// panel's fields are repeatedly checked ...
        /// </summary>
        public bool pollForChanges{get;set;}
        /// <summary>
        /// Interval in milliseconds at which the form's fields are checked for value changes. ...
        /// </summary>
        public JsNumber pollInterval{get;set;}
    }
    #endregion
    #region PanelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class PanelEvents : Ext.panel.PanelEvents
    {
        /// <summary>
        /// Fires when the active error message is changed for any one of the Ext.form.Labelable
        /// instances within this container. ...
        /// </summary>
        public static JsString fielderrorchange="fielderrorchange";
    }
    #endregion
}
#endregion
