//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.view
namespace Ext.view
{
    #region BoundListKeyNav
    /// <summary>
    /// A specialized Ext.util.KeyNav implementation for navigating a Ext.view.BoundList using
    /// the keyboard. The up, down, pageup, pagedown, home, and end keys move the active highlight
    /// through the list. The enter key invokes the selection model&#39;s select action using the highlighted item.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class BoundListKeyNav : Ext.util.KeyNav
    {
    }
    #endregion
    #region BoundListKeyNavConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BoundListKeyNavConfig
    {
        /// <summary>
        /// @required
        /// The Ext.view.BoundList instance for which key navigation will be managed. ...
        /// </summary>
        public BoundList boundList{get;set;}
    }
    #endregion
    #region BoundListKeyNavEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BoundListKeyNavEvents
    {
    }
    #endregion
}
#endregion
