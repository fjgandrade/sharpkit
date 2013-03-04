/*Generated by SharpKit 5 v5.00.6000*/
"use strict";
if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var System$Collections$ArrayList =
{
    fullname: "System.Collections.ArrayList",
    baseTypeName: "System.Collections.Generic.List$1",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Collections.Generic.List$1.ctor.call(this, System.Object.ctor);
        }
    }
};
JsTypes.push(System$Collections$ArrayList);
var System$Collections$Generic$Dictionary$2 =
{
    fullname: "System.Collections.Generic.Dictionary$2",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IDictionary$2"],
    Kind: "Class",
    definition:
    {
        ctor: function (TKey, TValue)
        {
            this.TKey = TKey;
            this.TValue = TValue;
            this._table = null;
            this._keys = null;
            this._version = 0;
            this.Comparer = null;
            System.Object.ctor.call(this);
            this._table = new Object();
            this._keys = new Object();
            this._version = 0;
        },
        ctor$$IEqualityComparer$1: function (TKey, TValue, comparer)
        {
            this.TKey = TKey;
            this.TValue = TValue;
            this._table = null;
            this._keys = null;
            this._version = 0;
            this.Comparer = null;
            System.Object.ctor.call(this);
            this._table = new Object();
            this._keys = new Object();
            this._version = 0;
            this.Comparer = comparer;
        },
        GetHashKey: function (key)
        {
            if (this.Comparer != null)
                return this.Comparer.GetHashCode$$T(key);
            return SharpKit.JavaScript.Utils.Js.GetHashKey(key);
        },
        Add: function (key, value)
        {
            if (key == null)
                throw $CreateException(new System.ArgumentNullException.ctor$$String("key"), new Error());
            if (this.ContainsKey(key))
                throw $CreateException(new System.ArgumentException.ctor$$String$$String$$Exception("The specified key already exists.", "key", null), new Error());
            var hashKey = this.GetHashKey(key);
            this._table[hashKey] = value;
            this._keys[hashKey] = key;
            this._version++;
        },
        Remove: function (key)
        {
            if (key == null)
                throw $CreateException(new System.ArgumentNullException.ctor$$String("key"), new Error());
            if (!this.ContainsKey(key))
                throw $CreateException(new System.ArgumentException.ctor$$String$$String$$Exception("The specified key does not exist.", "key", null), new Error());
            var hashKey = this.GetHashKey(key);
            delete this._table[hashKey];
            delete this._keys[hashKey];
            this._version++;
            return true;
        },
        Item$$: "`1",
        get_Item$$TKey: function (key)
        {
            if (!this.ContainsKey(key))
                throw $CreateException(new System.Collections.Generic.KeyNotFoundException.ctor$$String("The specified key does not exist."), new Error());
            var hashKey = this.GetHashKey(key);
            return this._table[hashKey];
        },
        set_Item$$TKey: function (key, value)
        {
            var hashKey = this.GetHashKey(key);
            this._table[hashKey] = value;
            this._keys[hashKey] = key;
            this._version++;
        },
        ContainsKey: function (key)
        {
            var hashKey = this.GetHashKey(key);
            return typeof(this._table[hashKey]) != "undefined";
        },
        Keys$$: "System.Collections.Generic.ICollection`1[[`0]]",
        get_Keys: function ()
        {
            var keys =  [];
            for (var p in this._keys)
            {
                keys.push(this._keys[p]);
            }
            return keys;
        },
        Values$$: "System.Collections.Generic.ICollection`1[[`1]]",
        get_Values: function ()
        {
            var values =  [];
            for (var p in this._table)
            {
                values.push(this._table[p]);
            }
            return values;
        },
        GetEnumerator: function ()
        {
            var array =  [];
            for (var hashKey in this._table)
            {
                array.push(new System.Collections.Generic.KeyValuePair$2.ctor$$TKey$$TValue(this.TKey, this.TValue, this._keys[hashKey], this._table[hashKey]));
            }
            return array.GetEnumerator();
        },
        Clear: function ()
        {
            for (var hashKey in this._table)
            {
                this._keys = new Object();
                this._table = new Object();
                this._version++;
                return;
            }
        },
        TryGetValue: function (key, value)
        {
            var hashKey = this.GetHashKey(key);
            var v = this._table[hashKey];
            value.Value = v;
            return typeof(v) != "undefined";
        },
        Count$$: "System.Int32",
        get_Count: function ()
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        IsReadOnly$$: "System.Boolean",
        get_IsReadOnly: function ()
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        }
    }
};
JsTypes.push(System$Collections$Generic$Dictionary$2);
var System$Collections$Generic$HashSet$1 =
{
    fullname: "System.Collections.Generic.HashSet$1",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.ISet$1", "System.Collections.Generic.ICollection$1", "System.Collections.Generic.IEnumerable$1", "System.Collections.IEnumerable"],
    Kind: "Class",
    definition:
    {
        ctor: function (T)
        {
            this.T = T;
            this.Hashtable = new Object();
            this.Comparer = null;
            this._Count = 0;
            System.Object.ctor.call(this);
        },
        ctor$$IEqualityComparer$1: function (T, comparer)
        {
            this.T = T;
            this.Hashtable = new Object();
            this.Comparer = null;
            this._Count = 0;
            System.Object.ctor.call(this);
            this.Comparer = comparer;
        },
        GetHashKey: function (key)
        {
            if (this.Comparer != null)
                return this.Comparer.GetHashCode$$T(key);
            return SharpKit.JavaScript.Utils.Js.GetHashKey(key);
        },
        Add: function (item)
        {
            var key = this.GetHashKey(item);
            if (this.Hashtable[key] != null)
                return false;
            this.Hashtable[key] = item;
            this._Count++;
            return true;
        },
        UnionWith: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        IntersectWith: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        ExceptWith: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        SymmetricExceptWith: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        IsSubsetOf: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        IsSupersetOf: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        IsProperSupersetOf: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        IsProperSubsetOf: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Overlaps: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        SetEquals: function (other)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Count$$: "System.Int32",
        get_Count: function ()
        {
            return this._Count;
        },
        IsReadOnly$$: "System.Boolean",
        get_IsReadOnly: function ()
        {
            return false;
        },
        Clear: function ()
        {
            this.Hashtable = new Object();
            this._Count = 0;
        },
        Contains: function (item)
        {
            var key = this.GetHashKey(item);
            if (this.Hashtable[key] === item)
                return true;
            return false;
        },
        CopyTo: function (array, arrayIndex)
        {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        Remove: function (item)
        {
            var key = this.GetHashKey(item);
            if (this.Hashtable[key] === item)
            {
                delete this.Hashtable[key];
                this._Count--;
                return true;
            }
            return false;
        },
        GetEnumerator: function ()
        {
            var array =  [];
            for (var hashKey in this.Hashtable)
            {
                array.push(this.Hashtable[hashKey]);
            }
            return new System.Collections.Generic.JsArrayEnumerator$1.ctor(this.T, array);
        }
    }
};
JsTypes.push(System$Collections$Generic$HashSet$1);
var System$StringComparer =
{
    fullname: "System.StringComparer",
    baseTypeName: "System.Object",
    staticDefinition:
    {
        cctor: function ()
        {
            System.StringComparer._InvariantCultureIgnoreCase = null;
        },
        InvariantCultureIgnoreCase$$: "SharpKit.JavaScript.Private.StringComparer",
        get_InvariantCultureIgnoreCase: function ()
        {
            if (System.StringComparer._InvariantCultureIgnoreCase == null)
                System.StringComparer._InvariantCultureIgnoreCase = new SharpKit.JavaScript.Private.StringComparer_InvariantCultureIgnoreCase.ctor();
            return System.StringComparer._InvariantCultureIgnoreCase;
        }
    },
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collection.Generic.IEqualityComparer"],
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$StringComparer);
var SharpKit$JavaScript$Private$StringComparer_InvariantCultureIgnoreCase =
{
    fullname: "SharpKit.JavaScript.Private.StringComparer_InvariantCultureIgnoreCase",
    baseTypeName: "System.StringComparer",
    staticDefinition:
    {
        cctor: function ()
        {
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.StringComparer.ctor.call(this);
        },
        Equals$$T$$T: function (x, y)
        {
            if (x == y)
                return true;
            if (x == null || y == null)
                return false;
            return x.toLowerCase() == y.toLowerCase();
        },
        GetHashCode$$T: function (obj)
        {
            if (obj == null)
                return "null";
            return obj.toLowerCase();
        }
    }
};
JsTypes.push(SharpKit$JavaScript$Private$StringComparer_InvariantCultureIgnoreCase);
var System$Collections$Generic$KeyValuePair$2 =
{
    fullname: "System.Collections.Generic.KeyValuePair$2",
    baseTypeName: "System.ValueType",
    assemblyName: "SharpKit.JsClr",
    Kind: "Struct",
    definition:
    {
        ctor$$TKey$$TValue: function (TKey, TValue, key, value)
        {
            this.TKey = TKey;
            this.TValue = TValue;
            this._Key = null;
            this._Value = null;
            System.ValueType.ctor.call(this);
            this._Key = key;
            this._Value = value;
        },
        Key$$: "`0",
        get_Key: function ()
        {
            return this._Key;
        },
        Value$$: "`1",
        get_Value: function ()
        {
            return this._Value;
        },
        ctor: function (TKey, TValue)
        {
            this.TKey = TKey;
            this.TValue = TValue;
            this._Key = null;
            this._Value = null;
            System.ValueType.ctor.call(this);
        }
    }
};
JsTypes.push(System$Collections$Generic$KeyValuePair$2);
var System$Collections$Generic$List$1 =
{
    fullname: "System.Collections.Generic.List$1",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IList$1", "System.Collections.IList"],
    Kind: "Class",
    definition:
    {
        ctor: function (T)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
        },
        ctor$$IEnumerable$1: function (T, collection)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
            this.AddRange(collection);
        },
        RemoveRange: function (index, count)
        {
            this._list.splice(index, count);
        },
        Clear: function ()
        {
            this._list.Clear();
        },
        Item$$: "`0",
        get_Item$$Int32: function (index)
        {
            if (index >= this._list.length || index < 0)
                throw $CreateException(new System.ArgumentOutOfRangeException.ctor$$String("index"), new Error());
            return this._list[index];
        },
        set_Item$$Int32: function (index, value)
        {
            if (index >= this._list.length || index < 0)
                throw $CreateException(new System.ArgumentOutOfRangeException.ctor$$String("index"), new Error());
            this._list[index] = value;
        },
        Count$$: "System.Int32",
        get_Count: function ()
        {
            return this._list.length;
        },
        GetEnumerator: function ()
        {
            return new System.Collections.IListEnumerator$1.ctor(this.T, this);
        },
        ToArray: function ()
        {
            var len = this.get_Count();
            var array = new Array(len);
            for (var i = 0; i < len; i++)
                array[i] = this.get_Item$$Int32(i);
            return array;
        },
        AddRange: function (items)
        {
            var $it1 = items.GetEnumerator();
            while ($it1.MoveNext())
            {
                var item = $it1.get_Current();
                this.Add(item);
            }
        },
        Add: function (item)
        {
            this._list.push(item);
        },
        Remove: function (item)
        {
            var index = this._list.indexOf(item);
            if (index == -1)
                return false;
            this._list.RemoveAt(index);
            return true;
        },
        Contains: function (item)
        {
            return this._list.contains(item);
        },
        SetItems: function (items)
        {
            this.Clear();
            if (items != null)
                this.AddRange(items);
        },
        IndexOf: function (item)
        {
            return this._list.indexOf(item);
        },
        Insert: function (index, item)
        {
            this._list.insert(index, item);
        },
        RemoveAt: function (index)
        {
            this._list.RemoveAt(index);
        },
        TryRemove: function (item)
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("TryRemove"), new Error());
        },
        CopyTo: function (array, arrayIndex)
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("JsImplList$T"), new Error());
        },
        IsReadOnly$$: "System.Boolean",
        get_IsReadOnly: function ()
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("JsImplList$T"), new Error());
        },
        Sort: function ()
        {
            this._list.sort();
        },
        Sort$$Comparison$1: function (comparison)
        {
            this._list.sort(comparison);
        },
        ForEach: function (action)
        {
            if (action == null)
                throw $CreateException(new System.ArgumentNullException.ctor$$String("action"), new Error());
            for (var i = 0; i < this._list.length; i++)
            {
                action(this._list[i]);
            }
        }
    }
};
JsTypes.push(System$Collections$Generic$List$1);
var System$Collections$Generic$Queue$1 =
{
    fullname: "System.Collections.Generic.Queue$1",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IEnumerable$1", "System.Collections.ICollection"],
    Kind: "Class",
    definition:
    {
        ctor: function (T)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
        },
        ctor$$Int32: function (T, capacity)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array(capacity);
        },
        ctor$$IEnumerable$1: function (T, collection)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            var enumerator = collection.GetEnumerator();
            this._list = new Array();
            var i = 0;
            while (enumerator.MoveNext())
            this._list[i++] = enumerator.get_Current();
        },
        Clear: function ()
        {
            this._list.Clear();
        },
        Count$$: "System.Int32",
        get_Count: function ()
        {
            return this._list.length;
        },
        GetEnumerator: function ()
        {
            return this._list.GetEnumerator();
        },
        ToArray: function ()
        {
            return this._list.Clone();
        },
        Enqueue: function (item)
        {
            this._list.push(item);
        },
        Dequeue: function ()
        {
            if (this._list.length == 0)
                throw $CreateException(new Error("Cannot dequeue - queue is empty"), new Error());
            var item = this._list[0];
            this._list.RemoveAt(0);
            return item;
        },
        Peek: function ()
        {
            if (this._list.length == 0)
                throw $CreateException(new Error("Cannot peek in queue - queue is empty"), new Error());
            return this._list[0];
        },
        Contains: function (item)
        {
            return this._list.contains(item);
        }
    }
};
JsTypes.push(System$Collections$Generic$Queue$1);
var System$Collections$Generic$Stack$1 =
{
    fullname: "System.Collections.Generic.Stack$1",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IEnumerable$1", "System.Collections.ICollection"],
    Kind: "Class",
    definition:
    {
        ctor: function (T)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array();
        },
        ctor$$Int32: function (T, capacity)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            this._list = new Array(capacity);
        },
        ctor$$IEnumerable$1: function (T, collection)
        {
            this.T = T;
            this._list = null;
            System.Object.ctor.call(this);
            var enumerator = collection.GetEnumerator();
            this._list = new Array();
            var i = 0;
            while (enumerator.MoveNext())
            this._list[i++] = enumerator.get_Current();
        },
        Count$$: "System.Int32",
        get_Count: function ()
        {
            return this._list.length;
        },
        Clear: function ()
        {
            this._list.Clear();
        },
        ToArray: function ()
        {
            return this._list.Clone();
        },
        Push: function (item)
        {
            this._list.push(item);
        },
        Pop: function ()
        {
            if (this._list.length == 0)
                throw $CreateException(new Error("Cannot pop from stack - stack is empty"), new Error());
            return this._list.pop();
        },
        Peek: function ()
        {
            if (this._list.length == 0)
                throw $CreateException(new Error("Cannot peek in stack - stack is empty"), new Error());
            return this._list[this._list.length - 1];
        },
        Contains: function (item)
        {
            return this._list.contains(item);
        },
        GetEnumerator: function ()
        {
            return this._list.GetEnumerator();
        }
    }
};
JsTypes.push(System$Collections$Generic$Stack$1);
var System$Collections$Generic$JsArrayEnumerator$1 =
{
    fullname: "System.Collections.Generic.JsArrayEnumerator$1",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IEnumerator$1"],
    Kind: "Class",
    definition:
    {
        ctor: function (T, list)
        {
            this.T = T;
            this.List = null;
            this.Index = 0;
            this.ListCount = 0;
            System.Object.ctor.call(this);
            this.List = list;
            this.Index = -1;
            this.ListCount = list.length;
        },
        Current$$: "`0",
        get_Current: function ()
        {
            return this.List[this.Index];
        },
        Dispose: function ()
        {
            this.List = null;
        },
        MoveNext: function ()
        {
            this.Index++;
            return this.Index < this.ListCount;
        },
        Reset: function ()
        {
            this.Index = -1;
        }
    }
};
JsTypes.push(System$Collections$Generic$JsArrayEnumerator$1);
var System$Collections$IListEnumerator$1 =
{
    fullname: "System.Collections.IListEnumerator$1",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IEnumerator$1"],
    Kind: "Class",
    definition:
    {
        ctor: function (T, list)
        {
            this.T = T;
            this.List = null;
            this.Index = 0;
            this.ListCount = 0;
            System.Object.ctor.call(this);
            this.List = list;
            this.Index = -1;
            this.ListCount = list.get_Count();
        },
        Current$$: "`0",
        get_Current: function ()
        {
            return this.List.get_Item$$Int32(this.Index);
        },
        Dispose: function ()
        {
            this.List = null;
        },
        MoveNext: function ()
        {
            this.Index++;
            return this.Index < this.ListCount;
        },
        Reset: function ()
        {
            this.Index = -1;
        }
    }
};
JsTypes.push(System$Collections$IListEnumerator$1);
