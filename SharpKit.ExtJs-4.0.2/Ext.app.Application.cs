//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:50:41
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.app
namespace Ext.app
{
    #region Application
    /// <summary>
    /// Represents an Ext JS 4 application, which is typically a single page app using a Viewport.
    /// A typical Ext.app.Application might look like this: Ext.application({
    /// name: &#39;MyApp&#39;,
    /// launch: function() {
    /// Ext.create(&#39;Ext.container.Viewport&#39;, {
    /// items: {
    /// html: &#39;My App&#39;
    /// }
    /// });
    /// }
    /// });
    /// This does several things. First it creates a global variable called &#39;MyApp&#39; - all of your Application&#39;s classes (such
    /// as its Models, Views and Controllers) will reside under this single namespace, which drastically lowers the chances
    /// of colliding global variables. When the page is ready and all of your JavaScript has loaded, your Application&#39;s launch function is called,
    /// at which time you can run the code that starts your app. Usually this consists of creating a Viewport, as we do in
    /// the example above. Telling Application about the rest of the app Because an Ext.app.Application represents an entire app, we should tell it about the other parts of the app - namely
    /// the Models, Views and Controllers that are bundled with the application. Let&#39;s say we have a blog management app; we
    /// might have Models and Controllers for Posts and Comments, and Views for listing, adding and editing Posts and Comments.
    /// Here&#39;s how we&#39;d tell our Application about all these things: Ext.application({
    /// name: &#39;Blog&#39;,
    /// models: [&#39;Post&#39;, &#39;Comment&#39;],
    /// controllers: [&#39;Posts&#39;, &#39;Comments&#39;],
    /// launch: function() {
    /// ...
    /// }
    /// });
    /// Note that we didn&#39;t actually list the Views directly in the Application itself. This is because Views are managed by
    /// Controllers, so it makes sense to keep those dependencies there. The Application will load each of the specified
    /// Controllers using the pathing conventions laid out in the application
    /// architecture guide - in this case expecting the controllers to reside in app/controller/Posts.js and
    /// app/controller/Comments.js. In turn, each Controller simply needs to list the Views it uses and they will be
    /// automatically loaded. Here&#39;s how our Posts controller like be defined: Ext.define(&#39;MyApp.controller.Posts&#39;, {
    /// extend: &#39;Ext.app.Controller&#39;,
    /// views: [&#39;posts.List&#39;, &#39;posts.Edit&#39;],
    /// //the rest of the Controller here
    /// });
    /// Because we told our Application about our Models and Controllers, and our Controllers about their Views, Ext JS will
    /// automatically load all of our app files for us. This means we don&#39;t have to manually add script tags into our html
    /// files whenever we add a new class, but more importantly it enables us to create a minimized build of our entire
    /// application using the Ext JS 4 SDK Tools. For more information about writing Ext JS 4 applications, please see the
    /// application architecture guide.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Application : Controller, Ext.util.Observable
    {
        /// <summary>
        /// Creates new Application. ...
        /// </summary>
        public new object constructor(object config=null){return null;}
        /// <summary>
        /// Called automatically when the page has completely loaded. ...
        /// </summary>
        public JsAction launch{get;set;}
    }
    #endregion
    #region ApplicationConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ApplicationConfig
    {
        /// <summary>
        /// The path to the directory which contains all application's classes. ...
        /// </summary>
        public JsString appFolder{get;set;}
        public bool autoCreateViewport{get;set;}
        /// <summary>
        /// When the app is first loaded, this url will be redirected to. ...
        /// </summary>
        public JsString defaultUrl{get;set;}
        public bool enableQuickTips{get;set;}
        /// <summary>
        /// The name of your application. ...
        /// </summary>
        public JsString name{get;set;}
        /// <summary>
        /// The scope to execute the launch function in. ...
        /// </summary>
        public object scope{get;set;}
    }
    #endregion
    #region ApplicationEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ApplicationEvents
    {
    }
    #endregion
}
#endregion
