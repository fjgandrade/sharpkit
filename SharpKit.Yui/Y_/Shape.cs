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
    /// <p>Base class for creating shapes.</p>
    /// <p>`Shape` is an abstract class and is not meant to be used directly. The following classes extend
    /// `Shape`.
    /// <ul>
    /// <li><a href="Circle.html">`Circle`</a></li>
    /// <li><a href="Ellipse.html">`Ellipse`</a></li>
    /// <li><a href="Rect.html">`Rect`</a></li>
    /// <li><a href="Path.html">`Path`</a></li>
    /// </ul>
    /// `Shape` can also be extended to create custom shape classes.</p>
    /// `Shape` has the following implementations based on browser capability.
    /// <ul>
    /// <li><a href="SVGShape.html">`SVGShape`</a></li>
    /// <li><a href="VMLShape.html">`VMLShape`</a></li>
    /// <li><a href="CanvasShape.html">`CanvasShape`</a></li>
    /// </ul>
    /// It is not necessary to interact with these classes directly. `Shape` will point to the appropriate implemention.</p>
    /// </summary>
    public partial class Shape
    {
        /// <summary>
        /// Add a class name to each node.
        /// </summary>
        public void addClass(object className){}
        /// <summary>
        /// Compares nodes to determine if they match.
        /// Node instances can be compared to each other and/or HTMLElements.
        /// </summary>
        public object compareTo(object refNode){return null;}
        /// <summary>
        /// Determines whether the node is an ancestor of another HTML element in the DOM hierarchy.
        /// </summary>
        public object contains(object needle){return null;}
        /// <summary>
        /// Destroys the instance.
        /// </summary>
        public void destroy(){}
        /// <summary>
        /// Returns the bounds for a shape.
        /// Calculates the a new bounding box from the original corner coordinates (base on size and position) and the transform matrix.
        /// The calculated bounding box is used by the graphic instance to calculate its viewBox.
        /// </summary>
        public object getBounds(){return null;}
        /// <summary>
        /// Gets the current position of the node in page coordinates.
        /// </summary>
        public object getXY(){return null;}
        /// <summary>
        /// Init method, invoked during construction.
        /// Calls `initializer` method.
        /// </summary>
        protected void init(){}
        /// <summary>
        /// Removes a class name from each node.
        /// </summary>
        public void removeClass(object className){}
        /// <summary>
        /// Rotates the shape clockwise around it transformOrigin.
        /// </summary>
        public void rotate(Y_.DataType_.Number deg){}
        /// <summary>
        /// Specifies a 2d scaling operation.
        /// </summary>
        public void scale(Y_.DataType_.Number val){}
        /// <summary>
        /// Sets the value of an attribute.
        /// </summary>
        public void set(object name, object value){}
        /// <summary>
        /// Set the position of the shape in page coordinates, regardless of how the node is positioned.
        /// </summary>
        public void setXY(Y_.Array Contains){}
        /// <summary>
        /// Skews the shape around the x-axis and y-axis.
        /// </summary>
        public void skew(Y_.DataType_.Number x, Y_.DataType_.Number y){}
        /// <summary>
        /// Skews the shape around the x-axis.
        /// </summary>
        public void skewX(Y_.DataType_.Number x){}
        /// <summary>
        /// Skews the shape around the y-axis.
        /// </summary>
        public void skewY(Y_.DataType_.Number y){}
        /// <summary>
        /// Test if the supplied node matches the supplied selector.
        /// </summary>
        public object test(object selector){return null;}
        /// <summary>
        /// Specifies a 2d translation.
        /// </summary>
        public void translate(Y_.DataType_.Number x, Y_.DataType_.Number y){}
        /// <summary>
        /// Translates the shape along the x-axis. When translating x and y coordinates,
        /// use the `translate` method.
        /// </summary>
        public void translateX(Y_.DataType_.Number x){}
        /// <summary>
        /// Translates the shape along the y-axis. When translating x and y coordinates,
        /// use the `translate` method.
        /// </summary>
        public void translateY(Y_.DataType_.Number y){}
    }
}
