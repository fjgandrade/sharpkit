//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region CheckboxGroup
    /// <summary>
    /// A field container which has a specialized layout for arranging
    /// Ext.form.field.Checkbox controls into columns, and provides convenience Ext.form.field.Field methods
    /// for getting, setting, and validating the group
    /// of checkboxes as a whole. Validation Individual checkbox fields themselves have no default validation behavior, but
    /// sometimes you want to require a user to select at least one of a group of checkboxes. CheckboxGroup
    /// allows this by setting the config allowBlank:false; when the user does not check at
    /// least one of the checkboxes, the entire group will be highlighted as invalid and the
    /// error message will be displayed according to the msgTarget config. Layout The default layout for CheckboxGroup makes it easy to arrange the checkboxes into
    /// columns; see the columns and vertical config documentation for details. You may also
    /// use a completely different layout by setting the layout to one of the other supported layout
    /// types; for instance you may wish to use a custom arrangement of hbox and vbox containers. In that case
    /// the checkbox components at any depth will still be managed by the CheckboxGroup&#39;s validation.  Example usage Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;Checkbox Group&#39;,
    /// width: 300,
    /// height: 125,
    /// bodyPadding: 10,
    /// renderTo: Ext.getBody(),
    /// items:[{
    /// xtype: &#39;checkboxgroup&#39;,
    /// fieldLabel: &#39;Two Columns&#39;,
    /// // Arrange radio buttons into two columns, distributed vertically
    /// columns: 2,
    /// vertical: true,
    /// items: [
    /// {boxLabel: &#39;Item 1&#39;, name: &#39;rb&#39;, inputValue: &#39;1&#39;},
    /// {boxLabel: &#39;Item 2&#39;, name: &#39;rb&#39;, inputValue: &#39;2&#39;, checked: true},
    /// {boxLabel: &#39;Item 3&#39;, name: &#39;rb&#39;, inputValue: &#39;3&#39;},
    /// {boxLabel: &#39;Item 4&#39;, name: &#39;rb&#39;, inputValue: &#39;4&#39;},
    /// {boxLabel: &#39;Item 5&#39;, name: &#39;rb&#39;, inputValue: &#39;5&#39;},
    /// {boxLabel: &#39;Item 6&#39;, name: &#39;rb&#39;, inputValue: &#39;6&#39;}
    /// ]
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class CheckboxGroup : FieldContainer, Ext.form.field.Field, Labelable, FieldAncestor, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
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
        /// Clear any invalid styles/messages for this field. ...
        /// </summary>
        public object clearInvalid(){return null;}
        /// <summary>
        /// Only relevant if the instance's isFileUpload method returns true. ...
        /// </summary>
        public HTMLInputElement extractFileInput(){return null;}
        /// <summary>
        /// Returns an Array of all checkboxes in the container which are currently checked ...
        /// </summary>
        public JsArray getChecked(){return null;}
        /// <summary>
        /// Runs CheckboxGroup's validations and returns an array of any errors. ...
        /// </summary>
        public JsArray getErrors(){return null;}
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
        /// Returns the parameter(s) that would be included in a standard form submit for this field. ...
        /// </summary>
        public object getSubmitData(){return null;}
        /// <summary>
        /// Returns an object containing the values of all checked checkboxes within the group. ...
        /// </summary>
        public object getValue(){return null;}
        /// <summary>
        /// Initializes this Field mixin on the current instance. ...
        /// </summary>
        public object initField(){return null;}
        /// <summary>
        /// Initializes the field's value based on the initial config. ...
        /// </summary>
        public object initValue(){return null;}
        /// <summary>
        /// Returns true if the value of this Field has been changed from its originalValue. ...
        /// </summary>
        public bool isDirty(){return false;}
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
        /// Resets the checked state of all checkboxes in the group to their
        /// originally loaded values and clears any validation m...
        /// </summary>
        public object reset(){return null;}
        /// <summary>
        /// Resets the field's originalValue property so it matches the current value. ...
        /// </summary>
        public object resetOriginalValue(){return null;}
        /// <summary>
        /// Returns whether or not the field value is currently valid by validating the
        /// field's current value, and fires the vali...
        /// </summary>
        public bool validate(){return false;}
        /// <summary>
        /// Flag denoting that this component is a Field. ...
        /// </summary>
        public bool isFormField{get;set;}
        /// <summary>
        /// The original value of the field as configured in the value configuration, or as loaded by
        /// the last form load operatio...
        /// </summary>
        public object originalValue{get;set;}
    }
    #endregion
    #region CheckboxGroupConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckboxGroupConfig
    {
        /// <summary>
        /// False to validate that at least one item in the group is checked (defaults to true). ...
        /// </summary>
        public bool allowBlank{get;set;}
        public JsString blankText{get;set;}
        /// <summary>
        /// Specifies the number of columns to use when displaying grouped
        /// checkbox/radio controls using automatic layout. ...
        /// </summary>
        public object columns{get;set;}
        /// <summary>
        /// True to disable the field (defaults to false). ...
        /// </summary>
        public bool disabled{get;set;}
        /// <summary>
        /// An extra CSS class to be applied to the body content element in addition to baseBodyCls. ...
        /// </summary>
        public JsString fieldBodyCls{get;set;}
        public JsArray items{get;set;}
        /// <summary>
        /// The name of the field (defaults to undefined). ...
        /// </summary>
        public JsString name{get;set;}
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
        /// <summary>
        /// True to distribute contained controls across columns, completely filling each column
        /// top to bottom before starting on...
        /// </summary>
        public bool vertical{get;set;}
    }
    #endregion
    #region CheckboxGroupEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckboxGroupEvents
    {
        /// <summary>
        /// Fires when a user-initiated change is detected in the value of the field. ...
        /// </summary>
        public static JsString change="change";
        /// <summary>
        /// Fires when a change in the field's isDirty state is detected. ...
        /// </summary>
        public static JsString dirtychange="dirtychange";
        /// <summary>
        /// Fires when a change in the field's validity is detected. ...
        /// </summary>
        public static JsString validitychange="validitychange";
    }
    #endregion
}
#endregion
