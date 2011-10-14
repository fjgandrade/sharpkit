/*@AutoGenerated*/
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}

if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Collections.ArrayList",
    baseTypeName:"System.Collections.Generic.List$1",
    definition:{
        ctor:function()
        {
            System.Collections.Generic.List$1.ctor.call(this,System.Object);
        }
        
    }
    ,
    staticDefinition:{},
    isEnum:false,
    isInterface:false,
    isDelegate:false,
    isValueType:false,
    isPartial:false,
    assemblyName:"SharpKit.JsClr-4.1.0",
    customAttributes:[],
    interfaceNames:[]}
);
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Collections.Generic.Dictionary$2",
    baseTypeName:"System.Object",
    definition:{
        ctor:function(TKey,TValue)
        {
            this.TKey = TKey;
            this.TValue = TValue;
            this._table = null;
            this._keys = null;
            this._version = 0;
            System.Object.ctor.call(this);
            this._table = new Object();
            this._keys = new Object();
            this._version = 0;
        }
        ,
        Keys$$:"System.Collections.Generic.ICollection`1",
        get_Keys:function()
        {
            var keys=new Array();
            for(var p in this._keys)
            {
                keys.push(this._keys[p]);
            }
            return keys;
        }
        ,
        Values$$:"System.Collections.Generic.ICollection`1",
        get_Values:function()
        {
            var values=new Array();
            for(var p in this._table)
            {
                values.push(this._table[p]);
            }
            return values;
        }
        ,
        Count$$:"System.Int32",
        get_Count:function()
        {
            throw new System.NotImplementedException.ctor();
        }
        
        ,
        IsReadOnly$$:"System.Boolean",
        get_IsReadOnly:function()
        {
            throw new System.NotImplementedException.ctor();
        }
        
        ,
        Item$$:"TValue",
        get_Item$$TKey:function(key)
        {
            var hashKey=this.GetHashKey(key);
            return this._table[hashKey];
        }
        ,
        set_Item$$TKey:function(key,value)
        {
            var hashKey=this.GetHashKey(key);
            this._table[hashKey] = value;
            this._keys[hashKey] = key;
            this._version++;
        }
        ,
        GetHashKey:function(key)
        {
            return SharpKit.JavaScript.Utils.Js.GetHashKey(key);
        }
        
        ,
        Add:function(key,value)
        {
            var hashKey=this.GetHashKey(key);
            this._table[hashKey] = value;
            this._keys[hashKey] = key;
            this._version++;
        }
        ,
        Remove:function(key)
        {
            var hashKey=this.GetHashKey(key);
            delete(this._table[hashKey]);
            delete(this._keys[hashKey]);
            this._version++;
            return true;
        }
        ,
        ContainsKey:function(key)
        {
            var hashKey=this.GetHashKey(key);
            return typeof(this._table[hashKey]) != "undefined";
        }
        ,
        GetEnumerator:function()
        {
            var array=new Array();
            for(var hashKey in this._table)
            {
                array.push(new System.Collections.Generic.KeyValuePair$2.ctor(this.TKey,this.TValue,this._keys[hashKey],this._table[hashKey]));
            }
            return array.GetEnumerator();
        }
        ,
        Clear:function()
        {
            for(var hashKey in this._table)
            {
                this._keys = new Object();
                this._table = new Object();
                this._version++;
                return;
            }
        }
        
        ,
        TryGetValue:function(key,value)
        {
            throw new System.NotImplementedException.ctor();
        }
        
    }
    ,
    staticDefinition:{},
    isEnum:false,
    isInterface:false,
    isDelegate:false,
    isValueType:false,
    isPartial:false,
    assemblyName:"SharpKit.JsClr-4.1.0",
    customAttributes:[],
    interfaceNames:["System.Collections.Generic.IDictionary$2"]}
);
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Collections.Generic.KeyValuePair$2",
    baseTypeName:"System.Object",
    definition:{
        ctor:function(K,T,key,value)
        {
            this.K = K;
            this.T = T;
            this._Key = null;
            this._Value = null;
            System.Object.ctor.call(this);
            this._Key = key;
            this._Value = value;
        }
        ,
        Key$$:"K",
        get_Key:function()
        {
            return this._Key;
        }
        
        ,
        Value$$:"T",
        get_Value:function()
        {
            return this._Value;
        }
        
    }
    ,
    staticDefinition:{},
    isEnum:false,
    isInterface:false,
    isDelegate:false,
    isValueType:false,
    isPartial:false,
    assemblyName:"SharpKit.JsClr-4.1.0",
    customAttributes:[],
    interfaceNames:[]}
);
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Collections.Generic.Stack$1",
    baseTypeName:"System.Object",
    definition:{
        ctor:function(T)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
        }
        ,
        Count$$:"System.Int32",
        get_Count:function()
        {
            return this._list.length;
        }
        
        ,
        Clear:function()
        {
            this._list.Clear();
        }
        
        ,
        GetEnumerator:function()
        {
            return this._list.GetEnumerator();
        }
        
        ,
        ToArray:function()
        {
            return this._list.Clone();
        }
        
        ,
        Push:function(item)
        {
            this._list.push(item);
        }
        
        ,
        Pop:function()
        {
            if(this._list.length == 0)
                throw new Error("Cannot pop from stack - stack is empty");
            return this._list.pop();
        }
        ,
        Contains:function(item)
        {
            return this._list.contains(item);
        }
        
    }
    ,
    staticDefinition:{},
    isEnum:false,
    isInterface:false,
    isDelegate:false,
    isValueType:false,
    isPartial:false,
    assemblyName:"SharpKit.JsClr-4.1.0",
    customAttributes:[],
    interfaceNames:["System.Collections.Generic.IEnumerable$1","System.Collections.ICollection"]}
);
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Collections.IListEnumerator$1",
    baseTypeName:"System.Object",
    definition:{
        ctor:function(T,list)
        {
            this.T = T;
            this.List = null;
            this.Index = 0;
            this.ListCount = 0;
            System.Object.ctor.call(this);
            this.List = list;
            this.Index = -1;
            this.ListCount = list.get_Count();
        }
        ,
        Current$$:"T",
        get_Current:function()
        {
            return this.List.get_Item$$Int32(this.Index);
        }
        
        ,
        Dispose:function()
        {
            this.List = null;
        }
        
        ,
        MoveNext:function()
        {
            this.Index++;
            return this.Index < this.ListCount;
        }
        ,
        Reset:function()
        {
            this.Index = -1;
        }
        
    }
    ,
    staticDefinition:{},
    isEnum:false,
    isInterface:false,
    isDelegate:false,
    isValueType:false,
    isPartial:false,
    assemblyName:"SharpKit.JsClr-4.1.0",
    customAttributes:[],
    interfaceNames:["System.Collections.Generic.IEnumerator$1"]}
);
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Collections.Generic.List$1",
    baseTypeName:"System.Object",
    definition:{
        ctor:function(T)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
        }
        ,
        ctor$$IEnumerable:function(T,collection)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
            this.AddRange(collection);
        }
        ,
        Count$$:"System.Int32",
        get_Count:function()
        {
            return this._list.length;
        }
        
        ,
        IsReadOnly$$:"System.Boolean",
        get_IsReadOnly:function()
        {
            throw new System.NotImplementedException.ctor$$String("JsImplList$T");
        }
        
        ,
        Item$$:"T",
        get_Item$$Int32:function(index)
        {
            if(index >= this._list.length || index < 0)
                throw new System.ArgumentOutOfRangeException.ctor$$String("index");
            return this._list[index];
        }
        ,
        set_Item$$Int32:function(index,value)
        {
            if(index >= this._list.length || index < 0)
                throw new System.ArgumentOutOfRangeException.ctor$$String("index");
            this._list[index] = value;
        }
        ,
        RemoveRange:function(index,count)
        {
            this._list.splice(index,count);
        }
        
        ,
        Clear:function()
        {
            this._list.Clear();
        }
        
        ,
        GetEnumerator:function()
        {
            return new System.Collections.IListEnumerator$1.ctor(this.T,this);
        }
        
        ,
        ToArray:function()
        {
            return this._list.Clone();
        }
        
        ,
        AddRange:function(items)
        {
            var $it1=items.GetEnumerator();
            while($it1.MoveNext())
            {
                var item=$it1.get_Current();
                this.Add(item);
            }
        }
        ,
        Add:function(item)
        {
            this._list.push(item);
        }
        
        ,
        Remove:function(item)
        {
            var index=this._list.indexOf(item);
            if(index == -1)
                return false;
            this._list.RemoveAt(index);
            return true;
        }
        ,
        Contains:function(item)
        {
            return this._list.contains(item);
        }
        
        ,
        SetItems:function(items)
        {
            this.Clear();
            if(items != null)
                this.AddRange(items);
        }
        ,
        IndexOf:function(item)
        {
            return this._list.indexOf(item);
        }
        
        ,
        Insert:function(index,item)
        {
            this._list.insert(index,item);
        }
        
        ,
        RemoveAt:function(index)
        {
            this._list.RemoveAt(index);
        }
        
        ,
        TryRemove:function(item)
        {
            throw new System.NotImplementedException.ctor$$String("TryRemove");
        }
        
        ,
        CopyTo:function(array,arrayIndex)
        {
            throw new System.NotImplementedException.ctor$$String("JsImplList$T");
        }
        
        ,
        Sort:function(comparison)
        {
            this._list.sort(SharpKit.JavaScript.Utils.Js.ToJsFunction(comparison));
        }
        
    }
    ,
    staticDefinition:{},
    isEnum:false,
    isInterface:false,
    isDelegate:false,
    isValueType:false,
    isPartial:false,
    assemblyName:"SharpKit.JsClr-4.1.0",
    customAttributes:[],
    interfaceNames:["System.Collections.Generic.IList$1","System.Collections.IList"]}
);
