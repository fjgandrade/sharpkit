//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.tinymce.ui
{
    /// <summary>
    /// This class is the base class for all container controls like toolbars.
    /// </summary>
    public  partial class Container
    {
        /// <summary>
        /// Adds a control to the collection of controls for the container.
        /// </summary>
        /// <param name="c">Control instance to add to the container.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control add(SharpKit.TinyMCE.tinymce.ui.Control c){return null;}
        /// <summary>
        /// Base contrustor a new container control instance.
        /// </summary>
        /// <param name="id">Control id to use for the container.</param>
        /// <param name="s">Optional name/value settings object.</param>
        public Container(string id, object s){}
        public object destroy(){return null;}
        /// <summary>
        /// Returns a control by id from the containers collection.
        /// </summary>
        /// <param name="n">Id for the control to retrive.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control get(string n){return null;}
        public object isActive(){return null;}
        public object isDisabled(){return null;}
        public object isRendered(){return null;}
        public object postRender(){return null;}
        public object remove(){return null;}
        public object renderHTML(){return null;}
        public object renderTo(){return null;}
        public object setActive(){return null;}
        public object setDisabled(){return null;}
        public object setState(){return null;}
        /// <summary>
        /// Array of controls added to the container.
        /// </summary>
        public Array controls{get;set;}
    }
}
