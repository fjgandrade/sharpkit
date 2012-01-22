//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region ProgressBar
    /// <summary>
    /// An updateable progress bar component.  The progress bar supports two different modes: manual and automatic. In manual mode, you are responsible for showing, updating (via updateProgress) and clearing the
    /// progress bar as needed from your own code.  This method is most appropriate when you want to show progress
    /// throughout an operation that has predictable points of interest at which you can update the control. In automatic mode, you simply call wait and let the progress bar run indefinitely, only clearing it
    /// once the operation is complete.  You can optionally have the progress bar wait for a specific amount of time
    /// and then clear itself.  Automatic mode is most appropriate for timed operations or asynchronous operations in
    /// which you have no need for indicating intermediate progress.
    /// Example Usage:  var p = Ext.create(&#39;Ext.ProgressBar&#39;, {
    /// renderTo: Ext.getBody(),
    /// width: 300
    /// });
    /// //Wait for 5 seconds, then update the status el (progress bar will auto-reset)
    /// p.wait({
    /// interval: 500, //bar will move fast!
    /// duration: 50000,
    /// increment: 15,
    /// text: &#39;Updating...&#39;,
    /// scope: this,
    /// fn: function(){
    /// p.updateText(&#39;Done!&#39;);
    /// }
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ProgressBar : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Returns true if the progress bar is currently in a wait operation ...
        /// </summary>
        public bool isWaiting(){return false;}
        /// <summary>
        /// Resets the progress bar value to 0 and text to empty string. ...
        /// </summary>
        public ProgressBar reset(bool hide=false){return null;}
        /// <summary>
        /// Updates the progress bar value, and optionally its text. ...
        /// </summary>
        public ProgressBar updateProgress(JsNumber value=null, JsString text=null, bool animate=false){return null;}
        /// <summary>
        /// Updates the progress bar text. ...
        /// </summary>
        public ProgressBar updateText(JsString text=null){return null;}
        /// <summary>
        /// Initiates an auto-updating progress bar. ...
        /// </summary>
        public ProgressBar wait(object config=null){return null;}
        public ProgressBar(ProgressBarConfig config){}
        public ProgressBar(){}
    }
    #endregion
    #region ProgressBarConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ProgressBarConfig : Ext.ComponentConfig
    {
        public bool animate{get;set;}
        public new JsString baseCls{get;set;}
        public new JsString id{get;set;}
        public JsString text{get;set;}
        public object textEl{get;set;}
        public JsNumber value{get;set;}
    }
    #endregion
    #region ProgressBarEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ProgressBarEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires after each update interval ...
        /// </summary>
        public static JsString update="update";
    }
    #endregion
}
#endregion
