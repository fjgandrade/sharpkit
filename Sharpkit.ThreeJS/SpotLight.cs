﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.Html4;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class SpotLight : Light
    {
        SpotLight(JsNumber hex, JsNumber intensity, JsNumber distance, JsBoolean castShadow) { }
    }
}