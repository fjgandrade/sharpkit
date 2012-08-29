//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region TextArea
    /// <inheritdocs />
    /// <summary>
    /// <p>This class creates a multiline text field, which can be used as a direct replacement for traditional
    /// textarea fields. In addition, it supports automatically <see cref="Ext.form.field.TextAreaConfig.grow">growing</see> the height of the textarea to
    /// fit its content.</p>
    /// <p>All of the configuration options from <see cref="Ext.form.field.Text">Ext.form.field.Text</see> can be used on TextArea.</p>
    /// <p>Example usage:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.FormPanel</see>', {
    /// title      : 'Sample TextArea',
    /// width      : 400,
    /// bodyPadding: 10,
    /// renderTo   : <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items: [{
    /// xtype     : 'textareafield',
    /// grow      : true,
    /// name      : 'message',
    /// fieldLabel: 'Message',
    /// anchor    : '100%'
    /// }]
    /// });
    /// </code></pre>
    /// <p>Some other useful configuration options when using <see cref="Ext.form.field.TextAreaConfig.grow">grow</see> are <see cref="Ext.form.field.TextAreaConfig.growMin">growMin</see> and <see cref="Ext.form.field.TextAreaConfig.growMax">growMax</see>.
    /// These allow you to set the minimum and maximum grow heights for the textarea.</p>
    /// <p><strong>NOTE:</strong> In some browsers, carriage returns ('\r', not to be confused with new lines)
    /// will be automatically stripped out the value is set to the textarea. Since we cannot
    /// use any reasonable method to attempt to re-insert these, they will automatically be
    /// stripped out to ensure the behaviour is consistent across browser.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class TextArea : Ext.form.field.Text
    {
        /// <summary>
        /// An initial value for the 'cols' attribute on the textarea element. This is only used if the component has no
        /// configured width and is not given a width by its container's layout.
        /// Defaults to: <c>20</c>
        /// </summary>
        public JsNumber cols;
        /// <summary>
        /// True if you want the ENTER key to be classed as a special key and the specialkey event to be fired
        /// when ENTER is pressed.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool enterIsSpecial;
        /// <summary>
        /// true to prevent scrollbars from appearing regardless of how much text is in the field. This option is only
        /// relevant when grow is true. Equivalent to setting overflow: hidden.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool preventScrollbars;
        /// <summary>
        /// An initial value for the 'rows' attribute on the textarea element. This is only used if the component has no
        /// configured height and is not given a height by its container's layout. Defaults to 4.
        /// Defaults to: <c>4</c>
        /// </summary>
        public JsNumber rows;
        public TextArea(Ext.form.field.TextAreaConfig config){}
        public TextArea(){}
        public TextArea(params object[] args){}
    }
    #endregion
    #region TextAreaConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TextAreaConfig : Ext.form.field.TextConfig
    {
        /// <summary>
        /// An initial value for the 'cols' attribute on the textarea element. This is only used if the component has no
        /// configured width and is not given a width by its container's layout.
        /// Defaults to: <c>20</c>
        /// </summary>
        public JsNumber cols;
        /// <summary>
        /// True if you want the ENTER key to be classed as a special key and the specialkey event to be fired
        /// when ENTER is pressed.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool enterIsSpecial;
        /// <summary>
        /// true to prevent scrollbars from appearing regardless of how much text is in the field. This option is only
        /// relevant when grow is true. Equivalent to setting overflow: hidden.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool preventScrollbars;
        /// <summary>
        /// An initial value for the 'rows' attribute on the textarea element. This is only used if the component has no
        /// configured height and is not given a height by its container's layout. Defaults to 4.
        /// Defaults to: <c>4</c>
        /// </summary>
        public JsNumber rows;
        public TextAreaConfig(params object[] args){}
    }
    #endregion
    #region TextAreaEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TextAreaEvents : Ext.form.field.TextEvents
    {
        public TextAreaEvents(params object[] args){}
    }
    #endregion
}
#endregion
