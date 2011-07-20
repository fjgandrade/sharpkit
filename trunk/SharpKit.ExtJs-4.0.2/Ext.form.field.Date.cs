//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region Date
    /// <summary>
    /// Provides a date input field with a date picker dropdown and automatic date
    /// validation. This field recognizes and uses the JavaScript Date object as its main value type. In addition,
    /// it recognizes string values which are parsed according to the format and/or altFormats
    /// configs. These may be reconfigured to use date formats appropriate for the user&#39;s locale. The field may be limited to a certain range of dates by using the minValue, maxValue,
    /// disabledDays, and disabledDates config parameters. These configurations will be used both
    /// in the field&#39;s validation, and in the date picker dropdown by preventing invalid dates from being selected.
    /// Example usage: Ext.create(&#39;Ext.form.Panel&#39;, {
    /// width: 300,
    /// bodyPadding: 10,
    /// title: &#39;Dates&#39;,
    /// items: [{
    /// xtype: &#39;datefield&#39;,
    /// anchor: &#39;100%&#39;,
    /// fieldLabel: &#39;From&#39;,
    /// name: &#39;from_date&#39;,
    /// maxValue: new Date()  // limited to the current date or prior
    /// }, {
    /// xtype: &#39;datefield&#39;,
    /// anchor: &#39;100%&#39;,
    /// fieldLabel: &#39;To&#39;,
    /// name: &#39;to_date&#39;,
    /// value: new Date()  // defaults to today
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// Date Formats Examples This example shows a couple of different date format parsing scenarios. Both use custom date format
    /// configurations; the first one matches the configured format while the second matches the altFormats. Ext.create(&#39;Ext.form.Panel&#39;, {
    /// renderTo: Ext.getBody(),
    /// width: 300,
    /// bodyPadding: 10,
    /// title: &#39;Dates&#39;,
    /// items: [{
    /// xtype: &#39;datefield&#39;,
    /// anchor: &#39;100%&#39;,
    /// fieldLabel: &#39;Date&#39;,
    /// name: &#39;date&#39;,
    /// // The value matches the format; will be parsed and displayed using that format.
    /// format: &#39;m d Y&#39;,
    /// value: &#39;2 4 1978&#39;
    /// }, {
    /// xtype: &#39;datefield&#39;,
    /// anchor: &#39;100%&#39;,
    /// fieldLabel: &#39;Date&#39;,
    /// name: &#39;date&#39;,
    /// // The value does not match the format, but does match an altFormat; will be parsed
    /// // using the altFormat and displayed using the format.
    /// format: &#39;m d Y&#39;,
    /// altFormats: &#39;m,d,Y|m.d.Y&#39;,
    /// value: &#39;2.4.1978&#39;
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Date : Picker, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Runs all of Date's validations and returns an array of any errors. ...
        /// </summary>
        public new JsArray getErrors(object value){return null;}
        /// <summary>
        /// Attempts to parse a given string value using a given date format. ...
        /// </summary>
        public JsDate safeParse(JsString value, JsString format){return null;}
        /// <summary>
        /// Replaces any existing disabled dates with new values and refreshes the Date picker. ...
        /// </summary>
        public object setDisabledDates(JsArray disabledDates){return null;}
        /// <summary>
        /// Replaces any existing disabled days (by index, 0-6) with new values and refreshes the Date picker. ...
        /// </summary>
        public object setDisabledDays(JsArray disabledDays){return null;}
        /// <summary>
        /// Replaces any existing maxValue with the new value and refreshes the Date picker. ...
        /// </summary>
        public object setMaxValue(JsDate value){return null;}
        /// <summary>
        /// Replaces any existing minValue with the new value and refreshes the Date picker. ...
        /// </summary>
        public object setMinValue(JsDate value){return null;}
        /// <summary>
        /// Sets the value of the date field. ...
        /// </summary>
        public new Ext.form.field.Field setValue(object date){return null;}
        public Date(Ext.form.field.DateConfig config){}
        public Date(){}
    }
    #endregion
    #region DateConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DateConfig : PickerConfig
    {
        /// <summary>
        /// Multiple date formats separated by "|" to try when parsing a user input value and it
        /// does not match the defined forma...
        /// </summary>
        public JsString altFormats{get;set;}
        /// <summary>
        /// An array of "dates" to disable, as strings. ...
        /// </summary>
        public JsArray disabledDates{get;set;}
        public JsString disabledDatesText{get;set;}
        /// <summary>
        /// An array of days to disable, 0 based (defaults to undefined). ...
        /// </summary>
        public JsArray disabledDays{get;set;}
        public JsString disabledDaysText{get;set;}
        /// <summary>
        /// The default date format string which can be overriden for localization support. ...
        /// </summary>
        public JsString format{get;set;}
        /// <summary>
        /// The error text to display when the date in the field is invalid (defaults to
        /// '{value} is not a valid date - it must b...
        /// </summary>
        public new JsString invalidText{get;set;}
        /// <summary>
        /// The error text to display when the date in the cell is after maxValue (defaults to
        /// 'The date in this field must be be...
        /// </summary>
        public JsString maxText{get;set;}
        /// <summary>
        /// The maximum allowed date. ...
        /// </summary>
        public object maxValue{get;set;}
        /// <summary>
        /// The error text to display when the date in the cell is before minValue (defaults to
        /// 'The date in this field must be a...
        /// </summary>
        public JsString minText{get;set;}
        /// <summary>
        /// The minimum allowed date. ...
        /// </summary>
        public object minValue{get;set;}
        /// <summary>
        /// false to hide the footer area of the Date picker containing the Today button and disable
        /// the keyboard handler for spa...
        /// </summary>
        public bool showToday{get;set;}
        public JsNumber startDay{get;set;}
        /// <summary>
        /// The date format string which will be submitted to the server. ...
        /// </summary>
        public JsString submitFormat{get;set;}
        /// <summary>
        /// An additional CSS class used to style the trigger button. ...
        /// </summary>
        public new JsString triggerCls{get;set;}
    }
    #endregion
    #region DateEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DateEvents : PickerEvents
    {
    }
    #endregion
}
#endregion
