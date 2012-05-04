//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_.Plugin_
{
    /// <summary>
    /// <p>
    /// An augmentable class, which provides the augmented class with the ability to host plugins.
    /// It adds <a href="#method_plug">plug</a> and <a href="#method_unplug">unplug</a> methods to the augmented class, which can
    /// be used to add or remove plugins from instances of the class.
    /// </p>
    /// <p>Plugins can also be added through the constructor configuration object passed to the host class' constructor using
    /// the "plugins" property. Supported values for the "plugins" property are those defined by the <a href="#method_plug">plug</a> method.
    /// For example the following code would add the AnimPlugin and IOPlugin to Overlay (the plugin host):
    /// <xmp>
    /// var o = new Overlay({plugins: [ AnimPlugin, {fn:IOPlugin, cfg:{section:"header"}}]});
    /// </xmp>
    /// </p>
    /// <p>
    /// Plug.Host's protected <a href="#method_initPlugins">_initPlugins</a> and <a href="#method_destroyPlugins">_destroyPlugins</a>
    /// methods should be invoked by the host class at the appropriate point in the host's lifecyle.
    /// </p>
    /// </summary>
    public partial class Host
    {
        /// <summary>
        /// A protected initialization method, used by the host class to initialize
        /// plugin configurations passed the constructor, through the config object.
        /// Host objects should invoke this method at the appropriate time in their
        /// construction lifecycle.
        /// </summary>
        protected void _initConfigPlugins(object config){}
        /// <summary>
        /// Determines if a plugin has plugged into this host.
        /// </summary>
        public object hasPlugin(object ns){return null;}
        /// <summary>
        /// Registers plugins to be instantiated at the class level (plugins
        /// which should be plugged into every instance of the class by default).
        /// </summary>
        public void plug(JsAction hostClass, object plugin, object config){}
        /// <summary>
        /// Adds a plugin to the host object. This will instantiate the
        /// plugin and attach it to the configured namespace on the host object.
        /// </summary>
        public YUI_.Base plug(object P, object config){return null;}
        /// <summary>
        /// Unregisters any class level plugins which have been registered by the host class, or any
        /// other class in the hierarchy.
        /// </summary>
        public void unplug(JsAction hostClass, object plugin){}
        /// <summary>
        /// Removes a plugin from the host object. This will destroy the
        /// plugin instance and delete the namepsace from the host object.
        /// </summary>
        public YUI_.Base unplug(object plugin){return null;}
    }
}
