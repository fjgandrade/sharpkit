//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.feature
namespace Ext.grid.feature
{
    #region GroupingSummary
    /// <summary>
    /// This feature adds an aggregate summary row at the bottom of each group that is provided
    /// by the Ext.grid.feature.Grouping feature. There are 2 aspects to the summary: Calculation The summary value needs to be calculated for each column in the grid. This is controlled
    /// by the summaryType option specified on the column. There are several built in summary types,
    /// which can be specified as a string on the column configuration. These call underlying methods
    /// on the store:  count sum min max average  Alternatively, the summaryType can be a function definition. If this is the case,
    /// the function is called with an array of records to calculate the summary value. Rendering Similar to a column, the summary also supports a summaryRenderer function. This
    /// summaryRenderer is called before displaying a value. The function is optional, if
    /// not specified the default calculated value is shown. The summaryRenderer is called with:  value {Object} - The calculated value. summaryData {Object} - Contains all raw summary values for the row. field {String} - The name of the field we are calculating  Example Usage Ext.define(&#39;TestResult&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [&#39;student&#39;, &#39;subject&#39;, {
    /// name: &#39;mark&#39;,
    /// type: &#39;int&#39;
    /// }]
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// width: 200,
    /// height: 240,
    /// renderTo: document.body,
    /// features: [{
    /// groupHeaderTpl: &#39;Subject: {name}&#39;,
    /// ftype: &#39;groupingsummary&#39;
    /// }],
    /// store: {
    /// model: &#39;TestResult&#39;,
    /// groupField: &#39;subject&#39;,
    /// data: [{
    /// student: &#39;Student 1&#39;,
    /// subject: &#39;Math&#39;,
    /// mark: 84
    /// },{
    /// student: &#39;Student 1&#39;,
    /// subject: &#39;Science&#39;,
    /// mark: 72
    /// },{
    /// student: &#39;Student 2&#39;,
    /// subject: &#39;Math&#39;,
    /// mark: 96
    /// },{
    /// student: &#39;Student 2&#39;,
    /// subject: &#39;Science&#39;,
    /// mark: 68
    /// }]
    /// },
    /// columns: [{
    /// dataIndex: &#39;student&#39;,
    /// text: &#39;Name&#39;,
    /// summaryType: &#39;count&#39;,
    /// summaryRenderer: function(value){
    /// return Ext.String.format(&#39;{0} student{1}&#39;, value, value !== 1 ? &#39;s&#39; : &#39;&#39;);
    /// }
    /// }, {
    /// dataIndex: &#39;mark&#39;,
    /// text: &#39;Mark&#39;,
    /// summaryType: &#39;average&#39;
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class GroupingSummary : Grouping, AbstractSummary
    {
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public new object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public new object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public new object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public new object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public new object clearManagedListeners(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public new object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public new bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Gets the value for the column from the attached data. ...
        /// </summary>
        public JsString getColumnValue(Ext.grid.column.Column column, object data){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public new bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public new object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public new object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public new object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public new object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public new object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public new object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public new object resumeEvents(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public new object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Toggle whether or not to show the summary row. ...
        /// </summary>
        public object toggleSummaryRow(bool visible){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public new object un(JsString eventName, JsAction handler, object scope=null){return null;}
    }
    #endregion
    #region GroupingSummaryConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class GroupingSummaryConfig
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        /// <summary>
        /// .  The name of the property
        /// which contains the Array of summary objects. ...
        /// </summary>
        public JsString remoteRoot{get;set;}
        /// <summary>
        /// True to show the summary row. ...
        /// </summary>
        public bool showSummaryRow{get;set;}
    }
    #endregion
    #region GroupingSummaryEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class GroupingSummaryEvents
    {
    }
    #endregion
}
#endregion
