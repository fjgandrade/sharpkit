//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.ui
{
    /// <summary>
    /// This class is base class for all menu item types like DropMenus items etc.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.ui.MenuItem", Export=false)]
    public  partial class MenuItem
    {
        public object destroy(){return null;}
        public object isActive(){return null;}
        public object isDisabled(){return null;}
        public object isRendered(){return null;}
        /// <summary>
        /// Returns true/false if the control is selected or not.
        /// </summary>
        public bool isSelected(){return false;}
        /// <summary>
        /// Constructs a new button control instance.
        /// </summary>
        /// <param name="id">Button control id for the button.</param>
        /// <param name="s">Optional name/value settings object.</param>
        public MenuItem(string id, object s){}
        /// <summary>
        /// Post render handler. This function will be called after the UI has been
        /// rendered so that events can be added.
        /// </summary>
        public object postRender(){return null;}
        public object remove(){return null;}
        public object renderHTML(){return null;}
        public object renderTo(){return null;}
        public object setActive(){return null;}
        public object setDisabled(){return null;}
        /// <summary>
        /// Sets the selected state for the control. This will add CSS classes to the
        /// element that contains the control. So that it can be selected visually.
        /// </summary>
        /// <param name="s">Boolean state if the control should be selected or not.</param>
        public object setSelected(bool s){return null;}
        public object setState(){return null;}
    }
}
