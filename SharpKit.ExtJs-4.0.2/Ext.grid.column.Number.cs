//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.column
namespace Ext.grid.column
{
    #region Number
    /// <summary>
    /// A Column definition class which renders a numeric data field according to a format string.  Code Ext.create(&#39;Ext.data.Store&#39;, {
    /// storeId:&#39;sampleStore&#39;,
    /// fields:[
    /// {name: &#39;symbol&#39;, type: &#39;string&#39;},
    /// {name: &#39;price&#39;, type: &#39;number&#39;},
    /// {name: &#39;change&#39;, type: &#39;number&#39;},
    /// {name: &#39;volume&#39;, type: &#39;number&#39;},
    /// ],
    /// data:[
    /// {symbol:&quot;msft&quot;, price:25.76, change:2.43, volume:61606325},
    /// {symbol:&quot;goog&quot;, price:525.73, change:0.81, volume:3053782},
    /// {symbol:&quot;apple&quot;, price:342.41, change:1.35, volume:24484858},
    /// {symbol:&quot;sencha&quot;, price:142.08, change:8.85, volume:5556351}
    /// ]
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Number Column Demo&#39;,
    /// store: Ext.data.StoreManager.lookup(&#39;sampleStore&#39;),
    /// columns: [
    /// {text: &#39;Symbol&#39;,  dataIndex: &#39;symbol&#39;, flex: 1},
    /// {text: &#39;Current Price&#39;,  dataIndex: &#39;price&#39;, renderer: Ext.util.Format.usMoney},
    /// {text: &#39;Change&#39;,  dataIndex: &#39;change&#39;, xtype: &#39;numbercolumn&#39;, format:&#39;0.00&#39;},
    /// {text: &#39;Volume&#39;,  dataIndex: &#39;volume&#39;, xtype: &#39;numbercolumn&#39;, format:&#39;0,000&#39;}
    /// ],
    /// height: 200,
    /// width: 400,
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Number : Ext.grid.column.Column, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public Number(Ext.grid.column.NumberConfig config){}
        public Number(){}
    }
    #endregion
    #region NumberConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class NumberConfig : Ext.grid.column.ColumnConfig
    {
        /// <summary>
        /// A formatting string as used by Ext.util.Format.number to format a numeric value for this Column
        /// (defaults to '0,000.0...
        /// </summary>
        public JsString format{get;set;}
    }
    #endregion
    #region NumberEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class NumberEvents : Ext.grid.column.ColumnEvents
    {
    }
    #endregion
}
#endregion
