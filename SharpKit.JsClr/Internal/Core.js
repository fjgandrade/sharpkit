/*@Generated by SharpKit v4.23.4000*/
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
var System$Activator=
{
    fullname:"System.Activator",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        CreateInstance$$Type:function(type)
        {
            return new type._JsType.ctor();
        },
        CreateInstance$$Type$$BindingFlags$$Binder$$Object$Array$$CultureInfo:function(type,bindingAttr,binder,args,culture)
        {
            throw new System.NotImplementedException.ctor();
        },
        CreateInstance$$Type$$BindingFlags$$Binder$$Object$Array$$CultureInfo$$Object$Array:function(type,bindingAttr,binder,args,culture,activationAttributes)
        {
            throw new System.NotImplementedException.ctor();
        },
        CreateInstance$$Type$$Object$Array:function(type,args)
        {
            throw new System.NotImplementedException.ctor();
        },
        CreateInstance$$Type$$Object$Array$$Object$Array:function(type,args,activationAttributes)
        {
            throw new System.NotImplementedException.ctor();
        },
        CreateInstance$$Type$$Boolean:function(type,nonPublic)
        {
            throw new System.NotImplementedException.ctor();
        },
        CreateInstance$1:function(T)
        {
            return Cast(System.Activator.CreateInstance$$Type(Typeof(T)),T);
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Activator);
var System$Attribute=
{
    fullname:"System.Attribute",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Attribute);
var System$Collections$Generic$IEnumerator$1={fullname:"System.Collections.Generic.IEnumerator$1",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$Collections$Generic$IEnumerator$1);
var System$Collections$Generic$IEnumerable$1={fullname:"System.Collections.Generic.IEnumerable$1",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",interfaceNames:["System.Collections.IEnumerable"],Kind:"Interface"};
JsTypes.push(System$Collections$Generic$IEnumerable$1);
var System$Collections$Generic$IList$1={fullname:"System.Collections.Generic.IList$1",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",interfaceNames:["System.Collections.Generic.ICollection$1"],Kind:"Interface"};
JsTypes.push(System$Collections$Generic$IList$1);
var System$Collections$Generic$ICollection$1={fullname:"System.Collections.Generic.ICollection$1",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",interfaceNames:["System.Collections.Generic.IEnumerable$1"],Kind:"Interface"};
JsTypes.push(System$Collections$Generic$ICollection$1);
var System$Collections$Generic$IDictionary$2={fullname:"System.Collections.Generic.IDictionary$2",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$Collections$Generic$IDictionary$2);
var System$Collections$IDictionary={fullname:"System.Collections.IDictionary",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",interfaceNames:["System.Collections.ICollection","System.Collections.IEnumerable"],Kind:"Interface"};
JsTypes.push(System$Collections$IDictionary);
var System$Collections$IEnumerable={fullname:"System.Collections.IEnumerable",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$Collections$IEnumerable);
var System$Collections$IEnumerator={fullname:"System.Collections.IEnumerator",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$Collections$IEnumerator);
var System$Collections$ICollection={fullname:"System.Collections.ICollection",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",interfaceNames:["System.Collections.IEnumerable"],Kind:"Interface"};
JsTypes.push(System$Collections$ICollection);
var System$Collections$IList={fullname:"System.Collections.IList",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",interfaceNames:["System.Collections.ICollection"],Kind:"Interface"};
JsTypes.push(System$Collections$IList);
var System$Comparison$1=
{
    fullname:"System.Comparison$1",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T,obj,func)
        {
            this.T = T;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Comparison$1);
var System$ComponentModel$CancelEventHandler=
{
    fullname:"System.ComponentModel.CancelEventHandler",
    Kind:"Delegate",
    definition:
    {
        ctor:function(obj,func)
        {
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$ComponentModel$CancelEventHandler);
var System$ComponentModel$CancelEventArgs=
{
    fullname:"System.ComponentModel.CancelEventArgs",
    baseTypeName:"System.EventArgs",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this._Cancel = false;
            System.EventArgs.ctor.call(this);
            this._Cancel = false;
        },
        ctor$$Boolean:function(cancel)
        {
            this._Cancel = false;
            System.EventArgs.ctor.call(this);
            this._Cancel = cancel;
        },
        Cancel$$:"System.Boolean",
        get_Cancel:function()
        {
            return this._Cancel;
        },
        set_Cancel:function(value)
        {
            this._Cancel = value;
        }
    }
};
JsTypes.push(System$ComponentModel$CancelEventArgs);
var System$ComponentModel$INotifyPropertyChanging={fullname:"System.ComponentModel.INotifyPropertyChanging",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$ComponentModel$INotifyPropertyChanging);
var System$ComponentModel$INotifyPropertyChanged={fullname:"System.ComponentModel.INotifyPropertyChanged",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$ComponentModel$INotifyPropertyChanged);
var System$ComponentModel$PropertyChangedEventHandler=
{
    fullname:"System.ComponentModel.PropertyChangedEventHandler",
    Kind:"Delegate",
    definition:
    {
        ctor:function(obj,func)
        {
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$ComponentModel$PropertyChangedEventHandler);
var System$ComponentModel$PropertyChangedEventArgs=
{
    fullname:"System.ComponentModel.PropertyChangedEventArgs",
    baseTypeName:"System.EventArgs",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function(propertyName)
        {
            this._PropertyName = null;
            System.EventArgs.ctor.call(this);
            this._PropertyName = propertyName;
        },
        PropertyName$$:"System.String",
        get_PropertyName:function()
        {
            return this._PropertyName;
        }
    }
};
JsTypes.push(System$ComponentModel$PropertyChangedEventArgs);
var System$DateTime=
{
    fullname:"System.DateTime",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        cctor:function()
        {
            System.DateTime.MinValue = null;
        },
        DaysInMonth:function(year,month)
        {
            return 32 - new Date(year, month-1, 32).getDate();
        },
        Compare:function(t1,t2)
        {
            return t1.date.valueOf() - t2.date.valueOf();
        },
        Now$$:"SharpKit.JavaScript.Private.JsImplDateTime",
        get_Now:function()
        {
            return new System.DateTime.ctor$$Date(new Date());
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this.date = null;
            System.Object.ctor.call(this);
            this.date = System.DateTime.MinValue.date;
        },
        ToJsDate:function()
        {
            return this.date;
        },
        ctor$$Int32$$Int32$$Int32:function(year,month,day)
        {
            this.date = null;
            System.Object.ctor.call(this);
            this.date = new Date();
            this.set_Year(year);
            this.set_Month(month);
            this.set_Day(day);
        },
        ctor$$Int32$$Int32$$Int32$$Int32$$Int32$$Int32:function(year,month,day,hour,minute,second)
        {
            this.date = null;
            System.Object.ctor.call(this);
            this.date = new Date();
            this.set_Year(year);
            this.set_Month(month);
            this.set_Day(day);
            this.set_Hour(hour);
            this.set_Minute(minute);
            this.set_Second(second);
        },
        ctor$$Date:function(jsDate)
        {
            this.date = null;
            System.Object.ctor.call(this);
            if(jsDate != null)
                this.date = jsDate;
            else
                this.date = System.DateTime.MinValue.date;
        },
        CompareTo:function(value)
        {
            return this.date.valueOf() - value.date.valueOf();
        },
        Year$$:"System.Int32",
        get_Year:function()
        {
            return this.date.getFullYear();
        },
        set_Year:function(value)
        {
            this.date.setFullYear(value);
        },
        Month$$:"System.Int32",
        get_Month:function()
        {
            return this.date.getMonth() + 1;
        },
        set_Month:function(value)
        {
            this.date.setMonth(value - 1);
        },
        Day$$:"System.Int32",
        get_Day:function()
        {
            return this.date.getDate();
        },
        set_Day:function(value)
        {
            this.date.setDate(value);
        },
        Hour$$:"System.Int32",
        get_Hour:function()
        {
            return this.date.getHours();
        },
        set_Hour:function(value)
        {
            this.date.setHours(value);
        },
        Minute$$:"System.Int32",
        get_Minute:function()
        {
            return this.date.getMinutes();
        },
        set_Minute:function(value)
        {
            this.date.setMinutes(value);
        },
        Second$$:"System.Int32",
        get_Second:function()
        {
            return this.date.getSeconds();
        },
        set_Second:function(value)
        {
            this.date.setSeconds(value);
        },
        Millisecond$$:"System.Int32",
        get_Millisecond:function()
        {
            return this.date.getMilliseconds();
        },
        set_Millisecond:function(value)
        {
            this.date.setMilliseconds(value);
        },
        DayOfWeek$$:"System.Int32",
        get_DayOfWeek:function()
        {
            return this.date.getDay();
        },
        toString:function()
        {
            return this.date.toString();
        },
        ToString$$String:function(format)
        {
            format = format.Replace$$String$$String("yyyy",this.get_Year().ToString$$String("0000"));
            format = format.Replace$$String$$String("yyyy",this.get_Year().ToString$$String("00"));
            format = format.Replace$$String$$String("y",this.get_Year().toString());
            format = format.Replace$$String$$String("MM",this.get_Month().ToString$$String("00"));
            format = format.Replace$$String$$String("M",this.get_Month().toString());
            format = format.Replace$$String$$String("dd",this.get_Day().ToString$$String("00"));
            format = format.Replace$$String$$String("d",this.get_Day().toString());
            format = format.Replace$$String$$String("HH",this.get_Hour().ToString$$String("00"));
            format = format.Replace$$String$$String("H",this.get_Hour().toString());
            format = format.Replace$$String$$String("mm",this.get_Minute().ToString$$String("00"));
            format = format.Replace$$String$$String("m",this.get_Minute().toString());
            format = format.Replace$$String$$String("ss",this.get_Second().ToString$$String("00"));
            format = format.Replace$$String$$String("s",this.get_Second().toString());
            return format;
        },
        AddDays:function(days)
        {
            return new System.DateTime.ctor$$Date(SharpKit.JavaScript.Private.Extensions.addDays(this.date,days));
        },
        AddMonths:function(months)
        {
            return new System.DateTime.ctor$$Date(SharpKit.JavaScript.Private.Extensions.addMonths(this.date,months));
        },
        Today$$:"SharpKit.JavaScript.Private.JsImplDateTime",
        get_Today:function()
        {
            return new System.DateTime.ctor$$Date(SharpKit.JavaScript.Private.Extensions.removeTime(new Date()));
        }
    }
};
JsTypes.push(System$DateTime);
var SharpKit$JavaScript$Private$Extensions=
{
    fullname:"SharpKit.JavaScript.Private.Extensions",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        addDays:function(date,days)
        {
            var date2=new Date(date.valueOf());
            date2.setDate(date2.getDate() + days);
            return date2;
        },
        addMonths:function(date,months)
        {
            var date2=new Date(date.valueOf());
            date2.setMonth(date2.getMonth() + months);
            return date2;
        },
        removeTime:function(date)
        {
            var date2=new Date(date.getFullYear(),date.getMonth(),date.getDate());
            return date2;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$JavaScript$Private$Extensions);
var System$Delegate=
{
    fullname:"System.Delegate",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        Combine$$Delegate$Array:function(delegates)
        {
            throw new System.NotImplementedException.ctor();
        },
        Combine$$Delegate$$Delegate:function(delegate1,delegate2)
        {
            return CombineDelegates(delegate1,delegate2);
        },
        Remove:function(delegate1,delegate2)
        {
            return RemoveDelegate(delegate1,delegate2);
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        },
        DynamicInvoke:function(args)
        {
            throw new System.NotImplementedException.ctor();
        }
    }
};
JsTypes.push(System$Delegate);
var System$MulticastDelegate=
{
    fullname:"System.MulticastDelegate",
    baseTypeName:"System.Delegate",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Delegate.ctor.call(this);
        },
        GetInvocationList:function()
        {
            throw new System.NotImplementedException.ctor();
        },
        Equals$$MulticastDelegate:function(del)
        {
            throw new System.NotImplementedException.ctor();
        },
        Invoke:function(varargs)
        {
            throw new System.NotImplementedException.ctor();
        }
    }
};
JsTypes.push(System$MulticastDelegate);
var System$Action=
{
    fullname:"System.Action",
    Kind:"Delegate",
    definition:
    {
        ctor:function(obj,func)
        {
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Action);
var System$Action$1=
{
    fullname:"System.Action$1",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T,obj,func)
        {
            this.T = T;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Action$1);
var System$Action$2=
{
    fullname:"System.Action$2",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T1,T2,obj,func)
        {
            this.T1 = T1;
            this.T2 = T2;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Action$2);
var System$Action$3=
{
    fullname:"System.Action$3",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T1,T2,T3,obj,func)
        {
            this.T1 = T1;
            this.T2 = T2;
            this.T3 = T3;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Action$3);
var System$Func$1=
{
    fullname:"System.Func$1",
    Kind:"Delegate",
    definition:
    {
        ctor:function(TResult,obj,func)
        {
            this.TResult = TResult;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Func$1);
var System$Func$2=
{
    fullname:"System.Func$2",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T,TResult,obj,func)
        {
            this.T = T;
            this.TResult = TResult;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Func$2);
var System$Func$3=
{
    fullname:"System.Func$3",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T1,T2,TResult,obj,func)
        {
            this.T1 = T1;
            this.T2 = T2;
            this.TResult = TResult;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Func$3);
var System$Func$4=
{
    fullname:"System.Func$4",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T1,T2,T3,TResult,obj,func)
        {
            this.T1 = T1;
            this.T2 = T2;
            this.T3 = T3;
            this.TResult = TResult;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Func$4);
var System$EventHandler=
{
    fullname:"System.EventHandler",
    Kind:"Delegate",
    definition:
    {
        ctor:function(obj,func)
        {
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$EventHandler);
var System$EventHandler$1=
{
    fullname:"System.EventHandler$1",
    Kind:"Delegate",
    definition:
    {
        ctor:function(TEventArgs,obj,func)
        {
            this.TEventArgs = TEventArgs;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$EventHandler$1);
var System$Predicate$1=
{
    fullname:"System.Predicate$1",
    Kind:"Delegate",
    definition:
    {
        ctor:function(T,obj,func)
        {
            this.T = T;
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(System$Predicate$1);
var System$Enum=
{
    fullname:"System.Enum",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        GetNames:function(type)
        {
            var jsType=type._JsType;
            var array=new Array();
            for(var p in jsType.staticDefinition)
            {
                array.push(p);
            }
            return array;
        },
        GetValues:function(type)
        {
            var jsType=type._JsType;
            var array=new Array();
            for(var p in jsType.staticDefinition)
            {
                array.push(jsType.staticDefinition[p]);
            }
            return array;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Enum);
var System$Environment=
{
    fullname:"System.Environment",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        GetResourceString:function(p)
        {
            return p;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Environment);
var System$EventArgs=
{
    fullname:"System.EventArgs",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$EventArgs);
var System$Exception=
{
    fullname:"System.Exception",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor$$String$$Exception:function(message,innerException)
        {
            this._InnerException = null;
            this._Message = null;
            System.Object.ctor.call(this);
            this._Message = message;
            this._InnerException = innerException;
        },
        ctor$$String:function(message)
        {
            this._InnerException = null;
            this._Message = null;
            System.Object.ctor.call(this);
            this._Message = message;
        },
        ctor:function()
        {
            this._InnerException = null;
            this._Message = null;
            System.Object.ctor.call(this);
        },
        InnerException$$:"System.Exception",
        get_InnerException:function()
        {
            return this._InnerException;
        },
        Message$$:"System.String",
        get_Message:function()
        {
            return this._Message;
        },
        toString:function()
        {
            var ie=this.get_InnerException();
            if(ie == null)
                return this.get_Message();
            return this.get_Message() + ", " + this.get_InnerException();
        },
        SetErrorCode:function(hr)
        {
        }
    }
};
JsTypes.push(System$Exception);
var System$NotImplementedException=
{
    fullname:"System.NotImplementedException",
    baseTypeName:"System.Exception",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Exception.ctor$$String.call(this,"NotImplementedException");
        },
        ctor$$String:function(s)
        {
            System.Exception.ctor$$String.call(this,"NotImplementedException: " + s);
        }
    }
};
JsTypes.push(System$NotImplementedException);
var System$SystemException=
{
    fullname:"System.SystemException",
    baseTypeName:"System.Exception",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Exception.ctor$$String.call(this,System.Environment.GetResourceString("Arg_SystemException"));
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233087);
        },
        ctor$$String:function(message)
        {
            System.Exception.ctor$$String.call(this,message);
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233087);
        },
        ctor$$String$$Exception:function(message,innerException)
        {
            System.Exception.ctor$$String$$Exception.call(this,message,innerException);
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233087);
        }
    }
};
JsTypes.push(System$SystemException);
var System$ArgumentException=
{
    fullname:"System.ArgumentException",
    baseTypeName:"System.SystemException",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this.m_paramName = null;
            System.SystemException.ctor$$String.call(this,System.Environment.GetResourceString("Arg_ArgumentException"));
            System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);
        },
        ctor$$String:function(message)
        {
            this.m_paramName = null;
            System.SystemException.ctor$$String.call(this,message);
            System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);
        },
        ctor$$String$$Exception:function(message,innerException)
        {
            this.m_paramName = null;
            System.SystemException.ctor$$String$$Exception.call(this,message,innerException);
        },
        ctor$$String$$String:function(message,paramName)
        {
            this.m_paramName = null;
            System.SystemException.ctor$$String.call(this,message);
            this.m_paramName = paramName;
            System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);
        },
        ctor$$String$$String$$Exception:function(message,paramName,innerException)
        {
            this.m_paramName = null;
            System.SystemException.ctor$$String$$Exception.call(this,message,innerException);
            this.m_paramName = paramName;
            System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);
        },
        ParamName$$:"System.String",
        get_ParamName:function()
        {
            return this.m_paramName;
        }
    }
};
JsTypes.push(System$ArgumentException);
var System$NullReferenceException=
{
    fullname:"System.NullReferenceException",
    baseTypeName:"System.SystemException",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.SystemException.ctor$$String.call(this,"Object reference not set to an instance of object");
        },
        ctor$$String:function(message)
        {
            System.SystemException.ctor$$String.call(this,message);
        }
    }
};
JsTypes.push(System$NullReferenceException);
var System$NotSupportedException=
{
    fullname:"System.NotSupportedException",
    baseTypeName:"System.SystemException",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.SystemException.ctor$$String.call(this,"Arg_NotSupportedException");
        },
        ctor$$String:function(message)
        {
            System.SystemException.ctor$$String.call(this,message);
        },
        ctor$$String$$Exception:function(message,innerException)
        {
            System.SystemException.ctor$$String$$Exception.call(this,message,innerException);
        }
    }
};
JsTypes.push(System$NotSupportedException);
var System$ArgumentOutOfRangeException=
{
    fullname:"System.ArgumentOutOfRangeException",
    baseTypeName:"System.ArgumentException",
    staticDefinition:
    {
        cctor:function()
        {
            System.ArgumentOutOfRangeException._rangeMessage = null;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this.m_actualValue = null;
            System.ArgumentException.ctor$$String.call(this,"Arg_ArgumentOutOfRangeException");
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);
        },
        ctor$$String:function(paramName)
        {
            this.m_actualValue = null;
            System.ArgumentException.ctor$$String$$String.call(this,"Arg_ArgumentOutOfRangeException",paramName);
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);
        },
        ctor$$String$$Exception:function(message,innerException)
        {
            this.m_actualValue = null;
            System.ArgumentException.ctor$$String$$Exception.call(this,message,innerException);
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);
        },
        ctor$$String$$String:function(paramName,message)
        {
            this.m_actualValue = null;
            System.ArgumentException.ctor$$String$$String.call(this,message,paramName);
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);
        },
        ctor$$String$$Object$$String:function(paramName,actualValue,message)
        {
            this.m_actualValue = null;
            System.ArgumentException.ctor$$String$$String.call(this,message,paramName);
            this.m_actualValue = actualValue;
            System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);
        },
        ActualValue$$:"System.Object",
        get_ActualValue:function()
        {
            return this.m_actualValue;
        },
        RangeMessage$$:"System.String",
        get_RangeMessage:function()
        {
            if(System.ArgumentOutOfRangeException._rangeMessage == null)
            {
                System.ArgumentOutOfRangeException._rangeMessage = "Arg_ArgumentOutOfRangeException";
            }
            return System.ArgumentOutOfRangeException._rangeMessage;
        }
    }
};
JsTypes.push(System$ArgumentOutOfRangeException);
var System$IDisposable={fullname:"System.IDisposable",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$IDisposable);
var System$Nullable$1=
{
    fullname:"System.Nullable$1",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function(T,value)
        {
            this.T = T;
            this.hasValue = false;
            this.value = null;
            System.Object.ctor.call(this);
            this.value = value;
            this.hasValue = true;
        },
        HasValue$$:"System.Boolean",
        get_HasValue:function()
        {
            return this.hasValue;
        },
        Value$$:"T",
        get_Value:function()
        {
            if(!this.get_HasValue())
            {
                throw new System.InvalidOperationException.ctor$$String("InvalidOperation_NoValue");
            }
            return this.value;
        },
        GetValueOrDefault:function()
        {
            return this.value;
        },
        GetValueOrDefault$$T:function(defaultValue)
        {
            if(!this.get_HasValue())
            {
                return defaultValue;
            }
            return this.value;
        },
        Equals$$Object:function(other)
        {
            if(!this.get_HasValue())
            {
                return (other == null);
            }
            if(other == null)
            {
                return false;
            }
            return this.value.Equals$$Object(other);
        },
        GetHashCode:function()
        {
            if(!this.get_HasValue())
            {
                return 0;
            }
            return this.value.GetHashCode();
        },
        toString:function()
        {
            if(!this.get_HasValue())
            {
                return "";
            }
            return this.value.toString();
        }
    }
};
JsTypes.push(System$Nullable$1);
var System$StringSplitOptions=
{
    fullname:"System.StringSplitOptions",
    staticDefinition:{None:"None",RemoveEmptyEntries:"RemoveEmptyEntries"},
    Kind:"Enum"
};
JsTypes.push(System$StringSplitOptions);
var System$Char=
{
    fullname:"System.Char",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        IsWhiteSpace:function(c)
        {
            return /\s/.test(c);
        },
        IsUpper:function(c)
        {
            return c.toUpperCase() == c;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Char);
var System$CharEnumerator=
{
    fullname:"System.CharEnumerator",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    interfaceNames:["System.Collections.Generic.IEnumerator$1","System.Collections.IEnumerator"],
    Kind:"Class",
    definition:
    {
        ctor:function(str2)
        {
            this.currentElement = '\0';
            this.index = 0;
            this.str = null;
            System.Object.ctor.call(this);
            this.str = str2;
            this.index = -1;
        },
        MoveNext:function()
        {
            if(this.index < (this.str.length - 1))
            {
                this.index++;
                this.currentElement = this.str.charAt(this.index);
                return true;
            }
            this.index = this.str.length;
            return false;
        },
        Reset:function()
        {
            this.currentElement = '\0';
            this.index = -1;
        },
        Current$$:"System.Char",
        get_Current:function()
        {
            if(this.index == -1)
            {
                throw new System.InvalidOperationException.ctor$$String("Enum Not Started");
            }
            if(this.index >= this.str.length)
            {
                throw new System.InvalidOperationException.ctor$$String("Enum Ended");
            }
            return this.currentElement;
        }
    }
};
JsTypes.push(System$CharEnumerator);
var System$StringComparison=
{
    fullname:"System.StringComparison",
    staticDefinition:{CurrentCulture:"CurrentCulture",CurrentCultureIgnoreCase:"CurrentCultureIgnoreCase",InvariantCulture:"InvariantCulture",InvariantCultureIgnoreCase:"InvariantCultureIgnoreCase",Ordinal:"Ordinal",OrdinalIgnoreCase:"OrdinalIgnoreCase"},
    Kind:"Enum"
};
JsTypes.push(System$StringComparison);
var System$Uri=
{
    fullname:"System.Uri",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function(uri)
        {
            this._OriginalString = null;
            System.Object.ctor.call(this);
            this._OriginalString = uri;
        },
        OriginalString$$:"System.String",
        get_OriginalString:function()
        {
            return this._OriginalString;
        },
        toString:function()
        {
            return this._OriginalString;
        }
    }
};
JsTypes.push(System$Uri);
var System$ValueType=
{
    fullname:"System.ValueType",
    baseTypeName:"System.Object",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$ValueType);
var SharpKit$Html4$HtmlDomEventHandler=
{
    fullname:"SharpKit.Html4.HtmlDomEventHandler",
    Kind:"Delegate",
    definition:
    {
        ctor:function(obj,func)
        {
            System.MulticastDelegate.ctor.call(this,obj,func);
        }
    }
};
JsTypes.push(SharpKit$Html4$HtmlDomEventHandler);
JsRuntime = function()
{
};
JsRuntime.Start = function()
{
    Compile();
};
