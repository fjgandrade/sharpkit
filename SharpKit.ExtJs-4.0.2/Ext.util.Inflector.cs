//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Inflector
    /// <summary>
    /// General purpose inflector class that pluralizes, singularizes and
    /// ordinalizes words. Sample usage: //turning singular words into plurals
    /// Ext.util.Inflector.pluralize(&#39;word&#39;); //&#39;words&#39;
    /// Ext.util.Inflector.pluralize(&#39;person&#39;); //&#39;people&#39;
    /// Ext.util.Inflector.pluralize(&#39;sheep&#39;); //&#39;sheep&#39;
    /// //turning plurals into singulars
    /// Ext.util.Inflector.singularize(&#39;words&#39;); //&#39;word&#39;
    /// Ext.util.Inflector.singularize(&#39;people&#39;); //&#39;person&#39;
    /// Ext.util.Inflector.singularize(&#39;sheep&#39;); //&#39;sheep&#39;
    /// //ordinalizing numbers
    /// Ext.util.Inflector.ordinalize(11); //&quot;11th&quot;
    /// Ext.util.Inflector.ordinalize(21); //&quot;21th&quot;
    /// Ext.util.Inflector.ordinalize(1043); //&quot;1043rd&quot;
    /// Customization The Inflector comes with a default set of US English pluralization rules. These can be augmented with additional
    /// rules if the default rules do not meet your application&#39;s requirements, or swapped out entirely for other languages.
    /// Here is how we might add a rule that pluralizes &quot;ox&quot; to &quot;oxen&quot;: Ext.util.Inflector.plural(/^(ox)$/i, &quot;$1en&quot;);
    /// Each rule consists of two items - a regular expression that matches one or more rules, and a replacement string.
    /// In this case, the regular expression will only match the string &quot;ox&quot;, and will replace that match with &quot;oxen&quot;.
    /// Here&#39;s how we could add the inverse rule: Ext.util.Inflector.singular(/^(ox)en$/i, &quot;$1&quot;);
    /// Note that the ox/oxen rules are present by default.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Inflector
    {
        /// <summary>
        /// Returns the correct Model name for a given string. ...
        /// </summary>
        public JsString classify(JsString word){return null;}
        /// <summary>
        /// Removes all registered pluralization rules ...
        /// </summary>
        public object clearPlurals(){return null;}
        /// <summary>
        /// Removes all registered singularization rules ...
        /// </summary>
        public object clearSingulars(){return null;}
        /// <summary>
        /// Returns true if the given word is transnumeral (the word is its own singular and plural form - e.g. ...
        /// </summary>
        public bool isTransnumeral(JsString word){return false;}
        /// <summary>
        /// Ordinalizes a given number by adding a prefix such as 'st', 'nd', 'rd' or 'th' based on the last digit of the
        /// number. ...
        /// </summary>
        public JsString ordinalize(JsNumber number){return null;}
        /// <summary>
        /// Adds a new pluralization rule to the Inflector. ...
        /// </summary>
        public object plural(JsRegExp matcher, JsString replacer){return null;}
        /// <summary>
        /// Returns the pluralized form of a word (e.g. ...
        /// </summary>
        public JsString pluralize(JsString word){return null;}
        /// <summary>
        /// Adds a new singularization rule to the Inflector. ...
        /// </summary>
        public object singular(JsRegExp matcher, JsString replacer){return null;}
        /// <summary>
        /// Returns the singularized form of a word (e.g. ...
        /// </summary>
        public JsString singularize(JsString word){return null;}
    }
    #endregion
    #region InflectorConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class InflectorConfig
    {
    }
    #endregion
    #region InflectorEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class InflectorEvents
    {
    }
    #endregion
}
#endregion
