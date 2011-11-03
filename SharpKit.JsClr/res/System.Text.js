/*@Generated by SharpKit v4.22.1000*/
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push(
{
    fullname:"System.Text.StringBuilder",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this.array = null;
            this.length = 0;
            System.Object.ctor.call(this);
            this.array = [];
            this.length = 0;
        },
        ctor$$String:function(s)
        {
            this.array = null;
            this.length = 0;
            System.Object.ctor.call(this);
            this.array = [s];
            this.length = s == null?0:s.get_Length();
        },
        Length$$:"System.Int32",
        get_Length:function()
        {
            return this.length;
        },
        set_Length:function(value)
        {
            if(value != 0)
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
            if(obj != null)
            {
                var s=obj.ToString();
                this.array.push(s);
                this.length += s.get_Length();
            }
        },
        AppendFormat$$String$$Object:function(s,arg0)
        {
            var ss=System.String.Format$$String$$Object(s,arg0);
            this.array.push(ss);
            this.length += ss.get_Length();
        },
        AppendFormat$$String$$Object$$Object:function(s,arg0,arg1)
        {
            var ss=System.String.Format$$String$$Object$$Object(s,arg0,arg1);
            this.array.push(ss);
            this.length += ss.get_Length();
        },
        AppendFormat$$String$$Object$$Object$$Object:function(s,arg0,arg1,arg2)
        {
            var ss=System.String.Format$$String$$Object$$Object$$Object(s,arg0,arg1,arg2);
            this.array.push(ss);
            this.length += ss.get_Length();
        },
        ToString:function()
        {
            return this.array.join("");
        },
        Remove:function(start,count)
        {
            var s=this.array.join("");
            s = s.Remove$$Int32$$Int32(start,count);
            this.array = [s];
            this.length = s.length;
            return this;
        }
    }
});
