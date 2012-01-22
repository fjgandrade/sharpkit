//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region Label
    /// <summary>
    /// Produces a standalone &amp;lt;label /&amp;gt; element which can be inserted into a form and be associated with a field
    /// in that form using the forId property. *NOTE:** in most cases it will be more appropriate to use the fieldLabel
    /// and associated config properties (Ext.form.Labelable.labelAlign, Ext.form.Labelable.labelWidth,
    /// etc.) in field components themselves, as that allows labels to be uniformly sized throughout the form.
    /// Ext.form.Label should only be used when your layout can not be achieved with the standard
    /// field layout. You will likely be associating the label with a field component that extends Ext.form.field.Base, so
    /// you should make sure the forId is set to the same value as the inputId
    /// of that field. The label&#39;s text can be set using either the text or html configuration properties; the
    /// difference between the two is that the former will automatically escape HTML characters when rendering, while
    /// the latter will not.
    /// Example usage: This example creates a Label after its associated Text field, an arrangement that cannot currently
    /// be achieved using the standard Field layout&#39;s labelAlign. Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;Field with Label&#39;,
    /// width: 400,
    /// bodyPadding: 10,
    /// renderTo: Ext.getBody(),
    /// layout: {
    /// type: &#39;hbox&#39;,
    /// align: &#39;middle&#39;
    /// },
    /// items: [{
    /// xtype: &#39;textfield&#39;,
    /// hideLabel: true,
    /// flex: 1
    /// }, {
    /// xtype: &#39;label&#39;,
    /// forId: &#39;myFieldId&#39;,
    /// text: &#39;My Awesome Field&#39;,
    /// margins: &#39;0 0 0 10&#39;
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Label : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Updates the label's innerHTML with the specified string. ...
        /// </summary>
        public Ext.form.Label setText(JsString text, bool encode=false){return null;}
        public Label(Ext.form.LabelConfig config){}
        public Label(){}
    }
    #endregion
    #region LabelConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class LabelConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// The id of the input element to which this label will be bound via the standard HTML 'for'
        /// attribute. ...
        /// </summary>
        public JsString forId{get;set;}
        /// <summary>
        /// An HTML fragment that will be used as the label's innerHTML (defaults to ''). ...
        /// </summary>
        public new JsString html{get;set;}
        /// <summary>
        /// The plain text to display within the label (defaults to ''). ...
        /// </summary>
        public JsString text{get;set;}
    }
    #endregion
    #region LabelEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class LabelEvents : Ext.ComponentEvents
    {
    }
    #endregion
}
#endregion
