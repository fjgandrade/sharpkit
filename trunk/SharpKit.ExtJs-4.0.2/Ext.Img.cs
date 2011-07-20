//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Img
    /// <summary>
    /// Simple helper class for easily creating image components. This simply renders an image tag to the DOM
    /// with the configured src.  Example usage: var changingImage = Ext.create(&#39;Ext.Img&#39;, {
    /// src: &#39;http://www.sencha.com/img/20110215-feat-html5.png&#39;,
    /// renderTo: Ext.getBody()
    /// });
    /// // change the src of the image programmatically
    /// changingImage.setSrc(&#39;http://www.sencha.com/img/20110215-feat-perf.png&#39;);
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Img : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Updates the src of the image ...
        /// </summary>
        public object setSrc(object src){return null;}
    }
    #endregion
    #region ImgConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ImgConfig : Ext.ComponentConfig
    {
        public JsString src{get;set;}
    }
    #endregion
    #region ImgEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ImgEvents : Ext.ComponentEvents
    {
    }
    #endregion
}
#endregion
