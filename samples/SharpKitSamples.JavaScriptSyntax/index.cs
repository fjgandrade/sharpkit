using System;
using System.Collections.Generic;
using System.Linq;
using SharpKit.HtmlModel;
using SharpKit.JavaScriptModel;

namespace SharpKitSamples.JavaScriptSyntax
{
	[JsType(JsMode.Json, "index.js")]
	class Product
	{
		public string name { get; set; }
		public double price { get; set; }
	}

	[JsType(JsMode.Prototype, "index.js", Name = "ShoppingCart")]
	class ShoppingCart
	{
		public double total = 0;
		JsArray items = new JsArray();

		public void addItem(string name, double price)
		{ 
		  var p = new Product {name=name, price = price};
			items.push(p);
			total += price;
		}

		public void print(HtmlDocument writer)
		{
			writer.write("total products:" + items.length);
			writer.write(", total price:" + total);
		}
	}

	[JsType(JsMode.Global, "index.js")]
	class index : HtmlContext
	{
		static void anonymous_function_demo()
		{
			//Delegates can be used to annotate an anonymous function.
			//The return value can be assigned to a JsAction
			JsAction f = delegate()
			{
				document.writeln("anonymous function demo: this line was emitted from an anonymous function<br/>");
			};
			f();
		}

		static void json_syntax_demo()
		{
			var p = new Product { name = "Bread", price = 10 };
			document.writeln("json demo: a new Product was created - {name:" + p.name + ", price:" + p.price + "}<br/>");
		}

		static void prototype_demo()
		{
			var cart = new ShoppingCart();
			document.writeln("prototype demo: a new Cart was created - ");
			cart.addItem("Milk", 9);
			cart.addItem("Toothpaste", 22);
			cart.print(document);
		}

		//Static constructors are converted into global code
		static index()
		{
			document.writeln("global code demo: this line was emitted from global code<br/>");
			anonymous_function_demo();
			json_syntax_demo();
			prototype_demo();
		}
	}

}
