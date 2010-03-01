using System;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;
using SharpKit.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample
{
	[JsType(JsMode.Clr, "index.js")]
	class index
	{
		public static void doTest()
		{
			var list = new List<Product>();
			list.Add(new Product { Name = "Milk", Price = 9 });
			list.Add(new Product { Name = "Bread", Price = 6 });
			list.Add(new Product { Name = "Toothpaste", Price = 16 });
			list.Add(new Product { Name = "Soap", Price = 11 });

			var expensiveProducts = list.Where(t => t.Price > 10);
			writeLine("Expensive products: " + expensiveProducts.Count());
		}

		static void writeLine(string s)
		{
			HtmlContext.document.body.appendChild(HtmlContext.document.createTextNode(s));
			HtmlContext.document.body.appendChild(HtmlContext.document.createElement("br"));
		}
	}

	[JsType(JsMode.Clr, "index.js")]
	public class Product
	{
		public string Name { get; set; }
		public int Price { get; set; }
	}
}
