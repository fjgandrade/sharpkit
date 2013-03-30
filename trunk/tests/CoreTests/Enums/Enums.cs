﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
[assembly: JsType(JsMode.Prototype, TargetType = typeof(System.ComponentModel.RefreshProperties), Filename = "~/Enums/Enums.js")]
namespace CoreTests.Enums
{
    [JsType(JsMode.Prototype)]
    class Enums
    {
        void foo()
        {
            var a = Enum1.a;
            var b = Enum2.b;
            var c = Enum3.c;
            var d = Enum4.a;
            var e = Enum5.b;
            var f = Enum6.b;

        }
        void Reflect()
        {
            var type = JsContext.CtorOf<Enum1>().As<JsObject>();
            foreach (var name in type)
            {
                var value = type[name];
                alert(name + "=" + value);
            }
        }

        private void alert(string p)
        {
            var x = Enum1.b;
            var y = Enum2.c;
        }
    }

    [JsType(JsMode.Prototype)]
    enum Enum1
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Prototype)]
    [JsEnum(ValuesAsNames = true)]
    enum Enum2
    {
        a,
        b,
        c,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    enum Enum3
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Json)]
    enum Enum4
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Clr)]
    [JsEnum(ValuesAsNames = true)]
    enum Enum5
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Clr)]
    enum Enum6
    {
        a = 1,
        b = 2,
        c = 3,
    }

}
