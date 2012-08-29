//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Img
    /// <inheritdocs />
    /// <summary>
    /// <p>Simple helper class for easily creating image components. This renders an image tag to
    /// the DOM with the configured src.</p>
    /// <p><p><i></i></p></p>
    /// <h2>Example usage:</h2>
    /// <pre><code>var changingImage = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.Img">Ext.Img</see>', {
    /// src: 'http://www.sencha.com/img/20110215-feat-html5.png',
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// // change the src of the image programmatically
    /// changingImage.setSrc('http://www.sencha.com/img/20110215-feat-perf.png');
    /// </code></pre>
    /// <p>By default, only an img element is rendered and that is this component's primary
    /// <see cref="Ext.AbstractComponent.getEl">element</see>. If the <see cref="Ext.AbstractComponentConfig.autoEl">Ext.AbstractComponent.autoEl</see> property
    /// is other than 'img' (the default), the a child img element will be added to the primary
    /// element. This can be used to create a wrapper element around the img.</p>
    /// <h2>Wrapping the img in a div:</h2>
    /// <pre><code>var wrappedImage = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.Img">Ext.Img</see>', {
    /// src: 'http://www.sencha.com/img/20110215-feat-html5.png',
    /// autoEl: 'div', // wrap in a div
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Img : Ext.Component
    {
        /// <summary>
        /// The descriptive text for non-visual UI description.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString alt;
        /// <summary>
        /// Optional CSS classes to add to the img element.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString imgCls;
        /// <summary>
        /// The image src.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString src;
        /// <summary>
        /// Updates the src of the image.
        /// </summary>
        /// <param name="src">
        /// </param>
        public void setSrc(JsString src){}
        public Img(ImgConfig config){}
        public Img(){}
        public Img(params object[] args){}
    }
    #endregion
    #region ImgConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ImgConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// The descriptive text for non-visual UI description.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString alt;
        /// <summary>
        /// Optional CSS classes to add to the img element.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString imgCls;
        /// <summary>
        /// The image src.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString src;
        public ImgConfig(params object[] args){}
    }
    #endregion
    #region ImgEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ImgEvents : Ext.ComponentEvents
    {
        public ImgEvents(params object[] args){}
    }
    #endregion
}
#endregion
