//@AutoGenerated
Class("System.Text.StringBuilder", "System.Object",
{ //Instance members
	ctor:function()
	{
		this.length = 0;
		System.Object.ctor.call(this);
		this.array = [];
		this.length = 0;
	}
	,
	ctor$$String:function(s)
	{
		this.length = 0;
		System.Object.ctor.call(this);
		this.array = [s];
		this.length = s == null ? 0 : s.get_Length();
	}
	,
	Length$$:"System.Int32",
	get_Length:function()
	{
		return this.length;
	},
	set_Length:function(value)
	{
		if (value != 0)
			throw new System.Exception.ctor$$String("Not Implemented");
		this.array.Clear();
		this.length = value;
	},
	Append$$Char:function(s)
	{
		this.array.push(s);
		this.length += 1;
	},
	Append$$String:function(s)
	{
		this.array.push(s);
		this.length += s.get_Length();
	},
	Append$$Object:function(obj)
	{
		if (obj != null)
		{
			var s = obj.ToString();
			this.array.push(s);
			this.length += s.get_Length();
		}
	},
	AppendFormat$$String$$Object:function(s, arg0)
	{
		var ss = System.String.Format(s, arg0);
		this.array.push(ss);
		this.length += ss.get_Length();
	},
	AppendFormat$$String$$Object$$Object:function(s, arg0, arg1)
	{
		var ss = System.String.Format(s, arg0, arg1);
		this.array.push(ss);
		this.length += ss.get_Length();
	},
	AppendFormat$$String$$Object$$Object$$Object:function(s, arg0, arg1, arg2)
	{
		var ss = System.String.Format(s, arg0, arg1, arg2);
		this.array.push(ss);
		this.length += ss.get_Length();
	},
	ToString:function()
	{
		return this.array.join("");
	},
	Remove:function(start, count)
	{
		var s = this.array.join("");
		s = s.Remove$$Int32$$Int32(start, count);
		this.array = [s];
		this.length = s.length;
		return this;
	}
},
{ //Static members
	
}, //Interfaces
null,
"SharpKit.JsClr", 
//Metadata
[
]
);
