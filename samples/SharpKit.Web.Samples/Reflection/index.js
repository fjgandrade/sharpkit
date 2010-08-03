
function doTest(sender,e)
{var c=NewWithInitializer(Reflection.Contact,{FirstName:"Shooki",LastName:"Booki",Birthday:new System.DateTime.ctor$$Int32$$Int32$$Int32(1976,9,24)});var type=c.GetType();writeLine(type.get_Name());writeLine("{");var $it1=type.GetProperties().GetEnumerator();while($it1.MoveNext())
{var prop=$it1.get_Current();writeLine(prop.get_Name()+" : "+prop.GetValue$$Object$$Object$Array(c,null));}
writeLine("}");}
function writeLine(s)
{document.body.appendChild(document.createTextNode(s));document.body.appendChild(document.createElement("br"));}
Class("Reflection.Contact","System.Object",{ctor:function()
{this._Birthday=System.DateTime.MinValue;System.Object.ctor.call(this);},FirstName$$:"System.String",get_FirstName:function()
{return this._FirstName;},set_FirstName:function(value)
{this._FirstName=value;},LastName$$:"System.String",get_LastName:function()
{return this._LastName;},set_LastName:function(value)
{this._LastName=value;},Birthday$$:"System.DateTime",get_Birthday:function()
{return this._Birthday;},set_Birthday:function(value)
{this._Birthday=value;}},{},null,"Reflection",null);