//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.action
namespace Ext.form.action
{
    #region Submit
    /// <inheritdocs />
    /// <summary>
    /// <p>A class which handles submission of data from <see cref="Ext.form.Basic">Form</see>s and processes the returned response.</p>
    /// <p>Instances of this class are only created by a <see cref="Ext.form.Basic">Form</see> when
    /// <see cref="Ext.form.Basic.submit">submit</see>ting.</p>
    /// <h1>Response Packet Criteria</h1>
    /// <p>A response packet may contain:</p>
    /// <ul>
    /// <li><p><strong><c>success</c></strong> property : Boolean - required.</p></li>
    /// <li><p><strong><c>errors</c></strong> property : Object - optional, contains error messages for invalid fields.</p></li>
    /// </ul>
    /// <h1>JSON Packets</h1>
    /// <p>By default, response packets are assumed to be JSON, so a typical response packet may look like this:</p>
    /// <pre><code>{
    /// success: false,
    /// errors: {
    /// clientCode: "Client not found",
    /// portOfLoading: "This field must not be null"
    /// }
    /// }
    /// </code></pre>
    /// <p>Other data may be placed into the response for processing by the <see cref="Ext.form.Basic">Ext.form.Basic</see>'s callback or event handler
    /// methods. The object decoded from this JSON is available in the <see cref="Ext.form.action.Action.result">result</see> property.</p>
    /// <p>Alternatively, if an <see cref="Ext.form.BasicConfig.errorReader">errorReader</see> is specified as an
    /// <see cref="Ext.data.reader.Xml">XmlReader</see>:</p>
    /// <pre><code>errorReader: new <see cref="Ext.data.reader.Xml">Ext.data.reader.Xml</see>({
    /// record : 'field',
    /// success: '@success'
    /// }, [
    /// 'id', 'msg'
    /// ]
    /// )
    /// </code></pre>
    /// <p>then the results may be sent back in XML format:</p>
    /// <pre><code>&lt;?xml version="1.0" encoding="UTF-8"?&gt;
    /// &lt;message success="false"&gt;
    /// &lt;errors&gt;
    /// &lt;field&gt;
    /// &lt;id&gt;clientCode&lt;/id&gt;
    /// &lt;msg&gt;&lt;![CDATA[Code not found. &lt;br /&gt;&lt;i&gt;This is a test validation message from the server &lt;/i&gt;]]&gt;&lt;/msg&gt;
    /// &lt;/field&gt;
    /// &lt;field&gt;
    /// &lt;id&gt;portOfLoading&lt;/id&gt;
    /// &lt;msg&gt;&lt;![CDATA[Port not found. &lt;br /&gt;&lt;i&gt;This is a test validation message from the server &lt;/i&gt;]]&gt;&lt;/msg&gt;
    /// &lt;/field&gt;
    /// &lt;/errors&gt;
    /// &lt;/message&gt;
    /// </code></pre>
    /// <p>Other elements may be placed into the response XML for processing by the <see cref="Ext.form.Basic">Ext.form.Basic</see>'s callback or event
    /// handler methods. The XML document is available in the <see cref="Ext.form.BasicConfig.errorReader">errorReader</see>'s
    /// <see cref="Ext.data.reader.Xml.xmlData">xmlData</see> property.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Submit : Ext.form.action.Action
    {
        /// <summary>
        /// Determines whether a Form's fields are validated in a final call to isValid prior
        /// to submission. Pass false in the Form's submit options to prevent this.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool clientValidation;
        /// <summary>
        /// Builds a form element containing fields corresponding to all the parameters to be
        /// submitted (everything returned by getParams.
        /// NOTE: the form element is automatically added to the DOM, so any code that uses
        /// it must remove it from the DOM after finishing with it.
        /// </summary>
        /// <returns>
        /// <span>HTMLElement</span><div>
        /// </div>
        /// </returns>
        private JsObject buildForm(){return null;}
        /// <summary>
        /// Performs the submit of the form data.
        /// </summary>
        private void doSubmit(){}
        public Submit(SubmitConfig config){}
        public Submit(){}
        public Submit(params object[] args){}
    }
    #endregion
    #region SubmitConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SubmitConfig : Ext.form.action.ActionConfig
    {
        /// <summary>
        /// Determines whether a Form's fields are validated in a final call to isValid prior
        /// to submission. Pass false in the Form's submit options to prevent this.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool clientValidation;
        public SubmitConfig(params object[] args){}
    }
    #endregion
    #region SubmitEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SubmitEvents : Ext.form.action.ActionEvents
    {
        public SubmitEvents(params object[] args){}
    }
    #endregion
}
#endregion
