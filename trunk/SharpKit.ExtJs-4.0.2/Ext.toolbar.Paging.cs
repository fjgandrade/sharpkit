//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.toolbar
namespace Ext.toolbar
{
    #region Paging
    /// <summary>
    /// As the amount of records increases, the time required for the browser to render
    /// them increases. Paging is used to reduce the amount of data exchanged with the client.
    /// Note: if there are more records/rows than can be viewed in the available screen area, vertical
    /// scrollbars will be added. Paging is typically handled on the server side (see exception below). The client sends
    /// parameters to the server side, which the server needs to interpret and then respond with the
    /// appropriate data. Ext.toolbar.Paging is a specialized toolbar that is bound to a Ext.data.Store
    /// and provides automatic paging control. This Component loads blocks
    /// of data into the store by passing paramNames used for
    /// paging criteria.  PagingToolbar is typically used as one of the Grid&#39;s toolbars:    var itemsPerPage = 2;   // set the number of items you want per page
    /// var store = Ext.create(&#39;Ext.data.Store&#39;, {
    /// id:&#39;simpsonsStore&#39;,
    /// autoLoad: false,
    /// fields:[&#39;name&#39;, &#39;email&#39;, &#39;phone&#39;],
    /// pageSize: itemsPerPage, // items per page
    /// proxy: {
    /// type: &#39;ajax&#39;,
    /// url: &#39;pagingstore.js&#39;,  // url that will load data with respect to start and limit params
    /// reader: {
    /// type: &#39;json&#39;,
    /// root: &#39;items&#39;,
    /// totalProperty: &#39;total&#39;
    /// }
    /// }
    /// });
    /// // specify segment of data you want to load using params
    /// store.load({
    /// params:{
    /// start:0,
    /// limit: itemsPerPage
    /// }
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Simpsons&#39;,
    /// store: store,
    /// columns: [
    /// {header: &#39;Name&#39;,  dataIndex: &#39;name&#39;},
    /// {header: &#39;Email&#39;, dataIndex: &#39;email&#39;, flex:1},
    /// {header: &#39;Phone&#39;, dataIndex: &#39;phone&#39;}
    /// ],
    /// width: 400,
    /// height: 125,
    /// dockedItems: [{
    /// xtype: &#39;pagingtoolbar&#39;,
    /// store: store,   // same store GridPanel is using
    /// dock: &#39;bottom&#39;,
    /// displayInfo: true
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// To use paging, pass the paging requirements to the server when the store is first loaded. store.load({
    /// params: {
    /// // specify params for the first page load if using paging
    /// start: 0,
    /// limit: myPageSize,
    /// // other params
    /// foo:   &#39;bar&#39;
    /// }
    /// });
    /// If using store&#39;s autoLoad configuration: var myStore = new Ext.data.Store({
    /// autoLoad: {start: 0, limit: 25},
    /// ...
    /// });
    /// The packet sent back from the server would have this form: {
    /// &quot;success&quot;: true,
    /// &quot;results&quot;: 2000,
    /// &quot;rows&quot;: [ // *Note: this must be an Array
    /// { &quot;id&quot;:  1, &quot;name&quot;: &quot;Bill&quot;, &quot;occupation&quot;: &quot;Gardener&quot; },
    /// { &quot;id&quot;:  2, &quot;name&quot;:  &quot;Ben&quot;, &quot;occupation&quot;: &quot;Horticulturalist&quot; },
    /// ...
    /// { &quot;id&quot;: 25, &quot;name&quot;:  &quot;Sue&quot;, &quot;occupation&quot;: &quot;Botanist&quot; }
    /// ]
    /// }
    /// Paging with Local Data Paging can also be accomplished with local data using extensions:  Ext.ux.data.PagingStore Paging Memory Proxy (examples/ux/PagingMemoryProxy.js)
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Paging : Toolbar, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Refresh the current page, has the same effect as clicking the 'refresh' button. ...
        /// </summary>
        public object doRefresh(){return null;}
        /// <summary>
        /// Move to the first page, has the same effect as clicking the 'first' button. ...
        /// </summary>
        public object moveFirst(){return null;}
        /// <summary>
        /// Move to the last page, has the same effect as clicking the 'last' button. ...
        /// </summary>
        public object moveLast(){return null;}
        /// <summary>
        /// Move to the next page, has the same effect as clicking the 'next' button. ...
        /// </summary>
        public object moveNext(){return null;}
        /// <summary>
        /// Move to the previous page, has the same effect as clicking the 'previous' button. ...
        /// </summary>
        public object movePrevious(){return null;}
    }
    #endregion
    #region PagingConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class PagingConfig
    {
        /// <summary>
        /// Customizable piece of the default paging text (defaults to 'of {0}'). ...
        /// </summary>
        public JsString afterPageText{get;set;}
        public JsString beforePageText{get;set;}
        public bool displayInfo{get;set;}
        /// <summary>
        /// The paging status message to display (defaults to 'Displaying {0} - {1} of {2}'). ...
        /// </summary>
        public JsString displayMsg{get;set;}
        public JsString emptyMsg{get;set;}
        /// <summary>
        /// The quicktip text displayed for the first page button (defaults to 'First Page'). ...
        /// </summary>
        public JsString firstText{get;set;}
        public JsNumber inputItemWidth{get;set;}
        /// <summary>
        /// The quicktip text displayed for the last page button (defaults to 'Last Page'). ...
        /// </summary>
        public JsString lastText{get;set;}
        /// <summary>
        /// The quicktip text displayed for the next page button (defaults to 'Next Page'). ...
        /// </summary>
        public JsString nextText{get;set;}
        /// <summary>
        /// true to insert any configured items before the paging buttons. ...
        /// </summary>
        public bool prependButtons{get;set;}
        /// <summary>
        /// The quicktip text displayed for the previous page button (defaults to 'Previous Page'). ...
        /// </summary>
        public JsString prevText{get;set;}
        /// <summary>
        /// The quicktip text displayed for the Refresh button (defaults to 'Refresh'). ...
        /// </summary>
        public JsString refreshText{get;set;}
        public Ext.data.Store store{get;set;}
    }
    #endregion
    #region PagingEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class PagingEvents
    {
        /// <summary>
        /// Fires just before the active page is changed. ...
        /// </summary>
        public static JsString beforechange="beforechange";
        /// <summary>
        /// Fires after the active page has been changed. ...
        /// </summary>
        public static JsString change="change";
    }
    #endregion
}
#endregion
