//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.tinymce.dom
{
    /// <summary>
    /// Element class, this enables element blocking in IE.
    /// </summary>
    public  partial class Element
    {
        /// <summary>
        /// Constructs a new Element instance. Consult the Wiki for more details on this class.
        /// </summary>
        /// <param name="id">Element ID to bind/execute methods on.</param>
        /// <param name="settings">Optional settings name/value collection.</param>
        public Element(string id, object settings){}
        /// <summary>
        /// Returns the size of the element by a object with w and h fields.
        /// </summary>
        public object getSize(){return null;}
        /// <summary>
        /// Returns the absolute X, Y cordinate of the element.
        /// </summary>
        public object getXY(){return null;}
        /// <summary>
        /// Moves the element relative to the current position.
        /// </summary>
        /// <param name="x">Relative X cordinate of element position.</param>
        /// <param name="y">Relative Y cordinate of element position.</param>
        public object moveBy(object x, object y){return null;}
        /// <summary>
        /// Moves the element to a specific absolute position.
        /// </summary>
        /// <param name="x">X cordinate of element position.</param>
        /// <param name="y">Y cordinate of element position.</param>
        public object moveTo(object x, object y){return null;}
        /// <summary>
        /// Adds a event handler to the element.
        /// </summary>
        /// <param name="n">Event name like for example "click".</param>
        /// <param name="f">Function to execute on the specified event.</param>
        /// <param name="s">Optional scope to execute function on.</param>
        public object on(string n, object f, object s){return null;}
        /// <summary>
        /// Resizes the element relative to the current sizeto a specific size.
        /// </summary>
        /// <param name="w">Relative width of element.</param>
        /// <param name="h">Relative height of element.</param>
        public object resizeBy(object w, object h){return null;}
        /// <summary>
        /// Resizes the element to a specific size.
        /// </summary>
        /// <param name="w">New width of element.</param>
        /// <param name="h">New height of element.</param>
        public object resizeTo(object w, object h){return null;}
        /// <summary>
        /// Updates the element blocker in IE6 based on the style information of the element.
        /// </summary>
        /// <param name="k">Optional function key. Used internally.</param>
        public object update(string k){return null;}
    }
}
