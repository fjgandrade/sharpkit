//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// <p>The `Path` class creates a shape through the use of drawing methods. The `Path` class has the following drawing methods available:</p>
    /// <ul>
    /// <li><a href="#method_clear">`clear`</a></li>
    /// <li><a href="#method_curveTo">`curveTo`</a></li>
    /// <li><a href="#method_drawRect">`drawRect`</a></li>
    /// <li><a href="#method_drawRoundRect">`drawRoundRect`</a></li>
    /// <li><a href="#method_end">`end`</a></li>
    /// <li><a href="#method_lineTo">`lineTo`</a></li>
    /// <li><a href="#method_moveTo">`moveTo`</a></li>
    /// <li><a href="#method_quadraticCurveTo">`quadraticCurveTo`</a></li>
    /// </ul>
    /// <p>Like other shapes, `Path` elements are created using the <a href="Graphic.html#method_addShape">`addShape`</a> method of the <a href="Graphic.html">`Graphic`</a>
    /// class. The method's `cfg` argument contains a `type` attribute. Assigning "path" or `Y.Path` to this attribute will create a `Path` instance.
    /// After instantiation, a series of drawing operations must be performed in order to render a shape. The below code instantiates a path element by defining the `type`
    /// attribute as "path":</p>
    /// var myPath = myGraphic.addShape({
    /// type: "path",
    /// fill: {
    /// color: "#9aa"
    /// },
    /// stroke: {
    /// weight: 1,
    /// color: "#000"
    /// }
    /// });
    /// Below a `Path` element with the same properties is instantiated by defining the `type` attribute with a class reference:
    /// var myPath = myGraphic.addShape({
    /// type: Y.Path,
    /// fill: {
    /// color: "#9aa"
    /// },
    /// stroke: {
    /// weight: 1,
    /// color: "#000"
    /// }
    /// });
    /// After instantiation, a shape or segment needs to be drawn for an element to render. After all draw operations are performed, the <a href="#method_end">`end`</a>
    /// method will render the shape. The code below will draw a triangle:
    /// myPath.moveTo(35, 5);
    /// myPath.lineTo(65, 65);
    /// myPath.lineTo(5, 65);
    /// myPath.lineTo(35, 5);
    /// myPath.end();
    /// <p>`Path` has the following implementations based on browser capability.
    /// <ul>
    /// <li><a href="SVGPath.html">`SVGPath`</a></li>
    /// <li><a href="VMLPath.html">`VMLPath`</a></li>
    /// <li><a href="CanvasPath.html">`CanvasPath`</a></li>
    /// </ul>
    /// It is not necessary to interact with these classes directly. `Path` will point to the appropriate implemention.</p>
    /// </summary>
    public partial class Path : Shape
    {
    }
}
