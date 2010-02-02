using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using Ext;
using Ext.grid;
using Ext.data;
using Ext.state;

namespace Controls_grid
{
	/*!
* Ext JS Library 3.1.0
* Copyright(c) 2006-2009 Ext JS, LLC
* licensing@extjs.com
* http://www.extjs.com/license
*/
	[JsType(JsMode.Global, "index.js")]
	public class index
	{
		static index()
		{
			ExtClass.onReady(delegate
			{

				// NOTE: This is an example showing simple state management. During development,
				// it is generally best to disable state management as dynamically-generated ids
				// can change across page loads, leading to unpredictable results.  The developer
				// should ensure that stable state ids are set for stateful components in real apps.    
				Manager.setProvider(new CookieProvider());

				// sample static data for the store
				var myData = new object[]
				{
						new object[]{"3m Co",71.72,0.02,0.03,"9/1 12:00am"},
						new object[]{"Alcoa Inc",29.01,0.42,1.47,"9/1 12:00am"},
						new object[]{"Altria Group Inc",83.81,0.28,0.34,"9/1 12:00am"},
						new object[]{"American Express Company",52.55,0.01,0.02,"9/1 12:00am"},
						new object[]{"American International Group, Inc.",64.13,0.31,0.49,"9/1 12:00am"},
						new object[]{"AT&T Inc.",31.61,-0.48,-1.54,"9/1 12:00am"},
						new object[]{"Boeing Co.",75.43,0.53,0.71,"9/1 12:00am"},
						new object[]{"Caterpillar Inc.",67.27,0.92,1.39,"9/1 12:00am"},
						new object[]{"Citigroup, Inc.",49.37,0.02,0.04,"9/1 12:00am"},
						new object[]{"E.I. du Pont de Nemours and Company",40.48,0.51,1.28,"9/1 12:00am"},
						new object[]{"Exxon Mobil Corp",68.1,-0.43,-0.64,"9/1 12:00am"},
						new object[]{"General Electric Company",34.14,-0.08,-0.23,"9/1 12:00am"},
						new object[]{"General Motors Corporation",30.27,1.09,3.74,"9/1 12:00am"},
						new object[]{"Hewlett-Packard Co.",36.53,-0.03,-0.08,"9/1 12:00am"},
						new object[]{"Honeywell Intl Inc",38.77,0.05,0.13,"9/1 12:00am"},
						new object[]{"Intel Corporation",19.88,0.31,1.58,"9/1 12:00am"},
						new object[]{"International Business Machines",81.41,0.44,0.54,"9/1 12:00am"},
						new object[]{"Johnson & Johnson",64.72,0.06,0.09,"9/1 12:00am"},
						new object[]{"JP Morgan & Chase & Co",45.73,0.07,0.15,"9/1 12:00am"},
						new object[]{"McDonald\"s Corporation",36.76,0.86,2.40,"9/1 12:00am"},
						new object[]{"Merck & Co., Inc.",40.96,0.41,1.01,"9/1 12:00am"},
						new object[]{"Microsoft Corporation",25.84,0.14,0.54,"9/1 12:00am"},
						new object[]{"Pfizer Inc",27.96,0.4,1.45,"9/1 12:00am"},
						new object[]{"The Coca-Cola Company",45.07,0.26,0.58,"9/1 12:00am"},
						new object[]{"The Home Depot, Inc.",34.64,0.35,1.02,"9/1 12:00am"},
						new object[]{"The Procter & Gamble Company",61.91,0.01,0.02,"9/1 12:00am"},
						new object[]{"United Technologies Corporation",63.26,0.55,0.88,"9/1 12:00am"},
						new object[]{"Verizon Communications",35.57,0.39,1.11,"9/1 12:00am"},            
						new object[]{"Wal-Mart Stores, Inc.",45.45,0.73,1.63,"9/1 12:00am"}
				};

				// create the data store
				var store = new Ext.data.ArrayStore(new ArrayStoreConfig
				{
					fields = new[]
					{
            new FieldConfig{name= "company"},
            new FieldConfig{name= "price", type= "float"},
            new FieldConfig{name= "change", type= "float"},
            new FieldConfig{name= "pctChange", type= "float"},
            new FieldConfig{name= "lastChange", type= "date", dateFormat= "n/j h:ia"}
					}
				});
				// manually load local data
				store.loadData(myData);

				// create the Grid
				var grid = new GridPanel(new GridPanelConfig
				{
					store = store,
					columns = new[]
					{
            new ColumnConfig{id="company",header= "Company", width= 160, sortable= true, dataIndex= "company"},
            new ColumnConfig{header= "Price", width= 75, sortable= true, renderer= "usMoney", dataIndex= "price"},
            new ColumnConfig{header= "Change", width= 75, sortable= true, renderer = new Func<int, string>(change), dataIndex= "change"},
            new ColumnConfig{header= "% Change", width= 75, sortable= true, renderer = new Func<int, string>(pctChange), dataIndex= "pctChange"},
            new ColumnConfig{header= "Last Updated", width= 85, sortable= true, renderer= Ext.util.Format.dateRenderer("m/d/Y"), dataIndex= "lastChange"}
					},
					stripeRows = true,
					autoExpandColumn = "company",
					height = 350,
					width = 600,
					title = "Array Grid",
					// config options for stateful behavior
					stateful = true,
					stateId = "grid"
				});

				// render the grid to the specified div in the page
				grid.render("grid-example");
			});
		}

		/**
		 * Custom function used for column renderer
		 * @param {Object} val
		 */
		public static string change(int val)
		{
			if (val > 0)
			{
				return "<span style=\"color:green;\">" + val + "</span>";
			}
			else if (val < 0)
			{
				return "<span style=\"color:red;\">" + val + "</span>";
			}
			return val.As<string>();
		}

		/**
		 * Custom function used for column renderer
		 * @param {Object} val
		 */
		public static string pctChange(int val)
		{
			if (val > 0)
			{
				return "<span style=\"color:green;\">" + val + "%</span>";
			}
			else if (val < 0)
			{
				return "<span style=\"color:red;\">" + val + "%</span>";
			}
			return val.As<string>();
		}


	}
}
