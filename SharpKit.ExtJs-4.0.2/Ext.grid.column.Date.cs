//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.column
namespace Ext.grid.column
{
    #region Date
    /// <summary>
    /// A Column definition class which renders a passed date according to the default locale, or a configured
    /// format.  Code Ext.create(&#39;Ext.data.Store&#39;, {
    /// storeId:&#39;sampleStore&#39;,
    /// fields:[
    /// {name: &#39;symbol&#39;, type: &#39;string&#39;},
    /// {name: &#39;date&#39;, type: &#39;date&#39;},
    /// {name: &#39;change&#39;, type: &#39;number&#39;},
    /// {name: &#39;volume&#39;, type: &#39;number&#39;},
    /// {name: &#39;topday&#39;, type: &#39;date&#39;}
    /// ],
    /// data:[
    /// {symbol:&quot;msft&quot;, date:&#39;2011/04/22&#39;, change:2.43, volume:61606325, topday:&#39;04/01/2010&#39;},
    /// {symbol:&quot;goog&quot;, date:&#39;2011/04/22&#39;, change:0.81, volume:3053782, topday:&#39;04/11/2010&#39;},
    /// {symbol:&quot;apple&quot;, date:&#39;2011/04/22&#39;, change:1.35, volume:24484858, topday:&#39;04/28/2010&#39;},
    /// {symbol:&quot;sencha&quot;, date:&#39;2011/04/22&#39;, change:8.85, volume:5556351, topday:&#39;04/22/2010&#39;}
    /// ]
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Date Column Demo&#39;,
    /// store: Ext.data.StoreManager.lookup(&#39;sampleStore&#39;),
    /// columns: [
    /// {text: &#39;Symbol&#39;,  dataIndex: &#39;symbol&#39;, flex: 1},
    /// {text: &#39;Date&#39;,  dataIndex: &#39;date&#39;, xtype: &#39;datecolumn&#39;, format:&#39;Y-m-d&#39;},
    /// {text: &#39;Change&#39;,  dataIndex: &#39;change&#39;, xtype: &#39;numbercolumn&#39;, format:&#39;0.00&#39;},
    /// {text: &#39;Volume&#39;,  dataIndex: &#39;volume&#39;, xtype: &#39;numbercolumn&#39;, format:&#39;0,000&#39;},
    /// {text: &#39;Top Day&#39;,  dataIndex: &#39;topday&#39;, xtype: &#39;datecolumn&#39;, format:&#39;l&#39;}
    /// ],
    /// height: 200,
    /// width: 450,
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Date : Ext.grid.column.Column, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public Date(Ext.grid.column.DateConfig config){}
        public Date(){}
    }
    #endregion
    #region DateConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DateConfig : Ext.grid.column.ColumnConfig
    {
        /// <summary>
        /// A formatting string as used by Ext.Date.format to format a Date for this Column. ...
        /// </summary>
        public JsString format{get;set;}
    }
    #endregion
    #region DateEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DateEvents : Ext.grid.column.ColumnEvents
    {
    }
    #endregion
}
#endregion
