//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region Trigger
    /// <summary>
    /// Provides a convenient wrapper for TextFields that adds a clickable trigger button (looks like a combobox by default).
    /// The trigger has no default action, so you must assign a function to implement the trigger click handler by
    /// overriding onTriggerClick. You can create a Trigger field directly, as it renders exactly like a combobox
    /// for which you can provide a custom implementation.
    /// For example: Ext.define(&#39;Ext.ux.CustomTrigger&#39;, {
    /// extend: &#39;Ext.form.field.Trigger&#39;,
    /// alias: &#39;widget.customtrigger&#39;,
    /// // override onTriggerClick
    /// onTriggerClick: function() {
    /// Ext.Msg.alert(&#39;Status&#39;, &#39;You clicked my trigger!&#39;);
    /// }
    /// });
    /// Ext.create(&#39;Ext.form.FormPanel&#39;, {
    /// title: &#39;Form with TriggerField&#39;,
    /// bodyPadding: 5,
    /// width: 350,
    /// renderTo: Ext.getBody(),
    /// items:[{
    /// xtype: &#39;customtrigger&#39;,
    /// fieldLabel: &#39;Sample Trigger&#39;,
    /// emptyText: &#39;click the trigger&#39;,
    /// }]
    /// });
    /// However, in general you will most likely want to use Trigger as the base class for a reusable component.
    /// Ext.form.field.Date and Ext.form.field.ComboBox are perfect examples of this.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Trigger : Text, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Create a new Trigger field. ...
        /// </summary>
        public new object constructor(object config){return null;}
        /// <summary>
        /// Get the total width of the trigger button area. ...
        /// </summary>
        public JsNumber getTriggerWidth(){return null;}
        /// <summary>
        /// The function that should handle the trigger's click event. ...
        /// </summary>
        public object onTriggerClick(Ext.EventObject e){return null;}
        /// <summary>
        /// ...
        /// </summary>
        public object setEditable(bool editable){return null;}
        /// <summary>
        /// ...
        /// </summary>
        public new object setReadOnly(bool readOnly){return null;}
        /// <summary>
        /// A composite of all the trigger button elements. ...
        /// </summary>
        public Ext.CompositeElement triggerEl{get;set;}
        /// <summary>
        /// A reference to the div element wrapping the trigger button(s). ...
        /// </summary>
        public Ext.core.Element triggerWrap{get;set;}
    }
    #endregion
    #region TriggerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TriggerConfig : TextConfig
    {
        /// <summary>
        /// false to prevent the user from typing text directly into the field;
        /// the field can only have its value set via an acti...
        /// </summary>
        public bool editable{get;set;}
        public bool hideTrigger{get;set;}
        /// <summary>
        /// true to prevent the user from changing the field, and
        /// hides the trigger. ...
        /// </summary>
        public new bool readOnly{get;set;}
        /// <summary>
        /// true to attach a click repeater
        /// to the trigger. ...
        /// </summary>
        public bool repeatTriggerClick{get;set;}
        /// <summary>
        /// true to select any existing text in the field immediately on focus. ...
        /// </summary>
        public new bool selectOnFocus{get;set;}
        /// <summary>
        /// The base CSS class that is always added to the trigger button. ...
        /// </summary>
        public JsString triggerBaseCls{get;set;}
        /// <summary>
        /// An additional CSS class used to style the trigger button. ...
        /// </summary>
        public JsString triggerCls{get;set;}
        public JsString triggerWrapCls{get;set;}
    }
    #endregion
    #region TriggerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TriggerEvents : TextEvents
    {
    }
    #endregion
}
#endregion
