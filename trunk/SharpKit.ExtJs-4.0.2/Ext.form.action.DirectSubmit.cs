//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.action
namespace Ext.form.action
{
    #region DirectSubmit
    /// <summary>
    /// Provides Ext.direct support for submitting form data. This example illustrates usage of Ext.direct.Direct to submit a form through Ext.Direct. var myFormPanel = new Ext.form.Panel({
    /// // configs for FormPanel
    /// title: &#39;Basic Information&#39;,
    /// renderTo: document.body,
    /// width: 300, height: 160,
    /// padding: 10,
    /// buttons:[{
    /// text: &#39;Submit&#39;,
    /// handler: function(){
    /// myFormPanel.getForm().submit({
    /// params: {
    /// foo: &#39;bar&#39;,
    /// uid: 34
    /// }
    /// });
    /// }
    /// }],
    /// // configs apply to child items
    /// defaults: {anchor: &#39;100%&#39;},
    /// defaultType: &#39;textfield&#39;,
    /// items: [{
    /// fieldLabel: &#39;Name&#39;,
    /// name: &#39;name&#39;
    /// },{
    /// fieldLabel: &#39;Email&#39;,
    /// name: &#39;email&#39;
    /// },{
    /// fieldLabel: &#39;Company&#39;,
    /// name: &#39;company&#39;
    /// }],
    /// // configs for BasicForm
    /// api: {
    /// // The server-side method to call for load() requests
    /// load: Profile.getBasicInfo,
    /// // The server-side must mark the submit handler as a &#39;formHandler&#39;
    /// submit: Profile.updateBasicInfo
    /// },
    /// // specify the order for the passed params
    /// paramOrder: [&#39;uid&#39;, &#39;foo&#39;]
    /// });
    /// The data packet sent to the server will resemble something like: {
    /// &quot;action&quot;:&quot;Profile&quot;,&quot;method&quot;:&quot;updateBasicInfo&quot;,&quot;type&quot;:&quot;rpc&quot;,&quot;tid&quot;:&quot;6&quot;,
    /// &quot;result&quot;:{
    /// &quot;success&quot;:true,
    /// &quot;id&quot;:{
    /// &quot;extAction&quot;:&quot;Profile&quot;,&quot;extMethod&quot;:&quot;updateBasicInfo&quot;,
    /// &quot;extType&quot;:&quot;rpc&quot;,&quot;extTID&quot;:&quot;6&quot;,&quot;extUpload&quot;:&quot;false&quot;,
    /// &quot;name&quot;:&quot;Aaron Conran&quot;,&quot;email&quot;:&quot;aaron@sencha.com&quot;,&quot;company&quot;:&quot;Sencha Inc.&quot;
    /// }
    /// }
    /// }
    /// The form will process a data packet returned by the server that is similar
    /// to the following: // sample success packet (batched requests)
    /// [
    /// {
    /// &quot;action&quot;:&quot;Profile&quot;,&quot;method&quot;:&quot;updateBasicInfo&quot;,&quot;type&quot;:&quot;rpc&quot;,&quot;tid&quot;:3,
    /// &quot;result&quot;:{
    /// &quot;success&quot;:true
    /// }
    /// }
    /// ]
    /// // sample failure packet (one request)
    /// {
    /// &quot;action&quot;:&quot;Profile&quot;,&quot;method&quot;:&quot;updateBasicInfo&quot;,&quot;type&quot;:&quot;rpc&quot;,&quot;tid&quot;:&quot;6&quot;,
    /// &quot;result&quot;:{
    /// &quot;errors&quot;:{
    /// &quot;email&quot;:&quot;already taken&quot;
    /// },
    /// &quot;success&quot;:false,
    /// &quot;foo&quot;:&quot;bar&quot;
    /// }
    /// }
    /// Also see the discussion in Ext.form.action.DirectLoad.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DirectSubmit : Submit
    {
        public DirectSubmit(DirectSubmitConfig config){}
        public DirectSubmit(){}
    }
    #endregion
    #region DirectSubmitConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DirectSubmitConfig : SubmitConfig
    {
    }
    #endregion
    #region DirectSubmitEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DirectSubmitEvents : SubmitEvents
    {
    }
    #endregion
}
#endregion
