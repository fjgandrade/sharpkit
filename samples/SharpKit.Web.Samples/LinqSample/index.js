
Class("LinqSample.index","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{doTest:function()
{var list=new System.Collections.Generic.List$1.ctor(LinqSample.Product);list.Add$$T(NewWithInitializer(LinqSample.Product,{Name:"Milk",Price:9}));list.Add$$T(NewWithInitializer(LinqSample.Product,{Name:"Bread",Price:6}));list.Add$$T(NewWithInitializer(LinqSample.Product,{Name:"Toothpaste",Price:16}));list.Add$$T(NewWithInitializer(LinqSample.Product,{Name:"Soap",Price:11}));var expensiveProducts=System.Linq.Enumerable.Where$$IEnumerable$1$$Func$2("LinqSample.Product",list,new System.Func$2.ctor(LinqSample.Product,System.Boolean,null,function(t){return t.get_Price()>10}));LinqSample.index.writeLine$$String("Expensive products: "+System.Linq.Enumerable.Count$$IEnumerable$1("LinqSample.Product",expensiveProducts));},writeLine$$String:function(s)
{document.body.appendChild(document.createTextNode(s));document.body.appendChild(document.createElement("br"));}},null,"LinqSample",null);Class("LinqSample.Product","System.Object",{ctor:function()
{this._Price=0;System.Object.ctor.call(this);},Name$$:"System.String",get_Name:function()
{return this._Name;},set_Name:function(value)
{this._Name=value;},Price$$:"System.Int32",get_Price:function()
{return this._Price;},set_Price:function(value)
{this._Price=value;}},{},null,"LinqSample",null);