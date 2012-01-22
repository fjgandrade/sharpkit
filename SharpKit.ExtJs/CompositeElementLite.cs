//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region CompositeElementLite
    /// <summary>
    /// This class encapsulates a collection of DOM elements, providing methods to filter
    /// members, or to perform collective actions upon the whole set. Although they are not listed, this class supports all of the methods of Ext.core.Element and
    /// Ext.fx.Anim. The methods from these classes will be performed on all the elements in this collection. Example: var els = Ext.select(&quot;#some-el div.some-class&quot;);
    /// // or select directly from an existing element
    /// var el = Ext.get(&#39;some-el&#39;);
    /// el.select(&#39;div.some-class&#39;);
    /// els.setWidth(100); // all elements become 100 width
    /// els.hide(true); // all elements fade out and hide
    /// // or
    /// els.setWidth(100).hide(true);
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class CompositeElementLite
    {
        /// <summary>
        /// Adds elements to this Composite object. ...
        /// </summary>
        public Ext.CompositeElement add(object els, object root){return null;}
        /// <summary>
        /// Removes all elements. ...
        /// </summary>
        public object clear(){return null;}
        /// <summary>
        /// Returns true if this composite contains the passed element ...
        /// </summary>
        public object contains(object el){return null;}
        /// <summary>
        /// Calls the passed function for each element in this composite. ...
        /// </summary>
        public Ext.CompositeElement each(JsAction fn, object scope=null){return null;}
        /// <summary>
        /// Clears this Composite and adds the elements passed. ...
        /// </summary>
        public Ext.CompositeElement fill(object els){return null;}
        /// <summary>
        /// Filters this composite to only elements that match the passed selector. ...
        /// </summary>
        public Ext.CompositeElement filter(object selector){return null;}
        /// <summary>
        /// Returns the first Element ...
        /// </summary>
        public Ext.core.Element first(){return null;}
        /// <summary>
        /// Returns the number of elements in this Composite. ...
        /// </summary>
        public object getCount(){return null;}
        /// <summary>
        /// Find the index of the passed element within the composite collection. ...
        /// </summary>
        public object indexOf(object el){return null;}
        /// <summary>
        /// Returns a flyweight Element of the dom element object at the specified index ...
        /// </summary>
        public Ext.core.Element item(JsNumber index){return null;}
        /// <summary>
        /// Returns the last Element ...
        /// </summary>
        public Ext.core.Element last(){return null;}
        /// <summary>
        /// Removes the specified element(s). ...
        /// </summary>
        public Ext.CompositeElement removeElement(object el, bool removeDom=false){return null;}
        /// <summary>
        /// Replaces the specified element with the passed element. ...
        /// </summary>
        public Ext.CompositeElement replaceElement(object el, object replacement, bool domReplace){return null;}
        /// <summary>
        /// The Array of DOM elements which this CompositeElement encapsulates. ...
        /// </summary>
        public JsArray elements{get;set;}
        public CompositeElementLite(CompositeElementLiteConfig config){}
        public CompositeElementLite(){}
    }
    #endregion
    #region CompositeElementLiteConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CompositeElementLiteConfig
    {
    }
    #endregion
    #region CompositeElementLiteEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CompositeElementLiteEvents
    {
    }
    #endregion
}
#endregion
