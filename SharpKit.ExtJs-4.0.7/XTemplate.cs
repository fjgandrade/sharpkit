//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region XTemplate
    /// <summary>
    /// A template class that supports advanced functionality like: Autofilling arrays using templates and sub-templates Conditional processing with basic comparison operators Basic math function support Execute arbitrary inline code with special built-in template variables Custom member functions Many special tags and built-in operators that aren&#39;t defined as part of
    /// the API, but are supported in the templates that can be created  XTemplate provides the templating mechanism built into: Ext.view.View  The Ext.Template describes
    /// the acceptable parameters to pass to the constructor. The following
    /// examples demonstrate all of the supported features.  Sample Data  This is the data object used for reference in each code example: var data = {
    /// name: &#39;Tommy Maintz&#39;,
    /// title: &#39;Lead Developer&#39;,
    /// company: &#39;Sencha Inc.&#39;,
    /// email: &#39;tommy@sencha.com&#39;,
    /// address: &#39;5 Cups Drive&#39;,
    /// city: &#39;Palo Alto&#39;,
    /// state: &#39;CA&#39;,
    /// zip: &#39;44102&#39;,
    /// drinks: [&#39;Coffee&#39;, &#39;Soda&#39;, &#39;Water&#39;],
    /// kids: [{
    /// name: &#39;Joshua&#39;,
    /// age:3
    /// },{
    /// name: &#39;Matthew&#39;,
    /// age:2
    /// },{
    /// name: &#39;Solomon&#39;,
    /// age:0
    /// }]
    /// };
    /// Auto filling of arrays  The tpl tag and the for operator are used
    /// to process the provided data object:
    /// If the value specified in for is an array, it will auto-fill,
    /// repeating the template block inside the tpl tag for each item in the
    /// array. If for=&quot;.&quot; is specified, the data object provided is examined. While processing an array, the special variable {#}
    /// will provide the current array index + 1 (starts at 1, not 0).   &amp;lt;tpl for=&quot;.&quot;&gt;...&amp;lt;/tpl&gt;       // loop through array at root node
    /// &amp;lt;tpl for=&quot;foo&quot;&gt;...&amp;lt;/tpl&gt;     // loop through array at foo node
    /// &amp;lt;tpl for=&quot;foo.bar&quot;&gt;...&amp;lt;/tpl&gt; // loop through array at foo.bar node
    /// Using the sample data above:
    /// var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;Kids: &#39;,
    /// &#39;&amp;lt;tpl for=&quot;.&quot;&gt;&#39;,       // process the data.kids node
    /// &#39;&amp;lt;p&gt;{#}. {name}&amp;lt;/p&gt;&#39;,  // use current array index to autonumber
    /// &#39;&amp;lt;/tpl&gt;&amp;lt;/p&gt;&#39;
    /// );
    /// tpl.overwrite(panel.body, data.kids); // pass the kids property of the data object
    /// An example illustrating how the for property can be leveraged
    /// to access specified members of the provided data object to populate the template: var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;Name: {name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Title: {title}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Company: {company}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Kids: &#39;,
    /// &#39;&amp;lt;tpl for=&quot;kids&quot;&gt;&#39;,     // interrogate the kids property within the data
    /// &#39;&amp;lt;p&gt;{name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&amp;lt;/p&gt;&#39;
    /// );
    /// tpl.overwrite(panel.body, data);  // pass the root node of the data object
    /// Flat arrays that contain values (and not objects) can be auto-rendered
    /// using the special {.} variable inside a loop.  This variable
    /// will represent the value of the array at the current index: var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;{name}\&amp;#39;s favorite beverages:&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;tpl for=&quot;drinks&quot;&gt;&#39;,
    /// &#39;&amp;lt;div&gt; - {.}&amp;lt;/div&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&#39;
    /// );
    /// tpl.overwrite(panel.body, data);
    /// When processing a sub-template, for example while looping through a child array,
    /// you can access the parent object&#39;s members via the parent object: var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;Name: {name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Kids: &#39;,
    /// &#39;&amp;lt;tpl for=&quot;kids&quot;&gt;&#39;,
    /// &#39;&amp;lt;tpl if=&quot;age &amp;amp;gt; 1&quot;&gt;&#39;,
    /// &#39;&amp;lt;p&gt;{name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Dad: {parent.name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&amp;lt;/p&gt;&#39;
    /// );
    /// tpl.overwrite(panel.body, data);
    /// Conditional processing with basic comparison operators  The tpl tag and the if operator are used
    /// to provide conditional checks for deciding whether or not to render specific
    /// parts of the template. Notes: Double quotes must be encoded if used within the conditional There is no else operator &amp;mdash; if needed, two opposite
    /// if statements should be used.  &amp;lt;tpl if=&quot;age &amp;gt; 1 &amp;amp;&amp;amp; age &amp;lt; 10&quot;&gt;Child&amp;lt;/tpl&gt;
    /// &amp;lt;tpl if=&quot;age &gt;= 10 &amp;&amp; age Teenager&amp;lt;/tpl&gt;
    /// &amp;lt;tpl if=&quot;this.isGirl(name)&quot;&gt;...&amp;lt;/tpl&gt;
    /// &amp;lt;tpl if=&quot;id==\&#39;download\&#39;&quot;&gt;...&amp;lt;/tpl&gt;
    /// &amp;lt;tpl if=&quot;needsIcon&quot;&gt;&amp;lt;img src=&quot;{icon}&quot; class=&quot;{iconCls}&quot;/&gt;&amp;lt;/tpl&gt;
    /// // no good:
    /// &amp;lt;tpl if=&quot;name == &quot;Tommy&quot;&quot;&gt;Hello&amp;lt;/tpl&gt;
    /// // encode &amp;#34; if it is part of the condition, e.g.
    /// &amp;lt;tpl if=&quot;name == &amp;#38;quot;Tommy&amp;#38;quot;&quot;&gt;Hello&amp;lt;/tpl&gt;
    /// Using the sample data above:
    /// var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;Name: {name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Kids: &#39;,
    /// &#39;&amp;lt;tpl for=&quot;kids&quot;&gt;&#39;,
    /// &#39;&amp;lt;tpl if=&quot;age &amp;amp;gt; 1&quot;&gt;&#39;,
    /// &#39;&amp;lt;p&gt;{name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&amp;lt;/p&gt;&#39;
    /// );
    /// tpl.overwrite(panel.body, data);
    /// Basic math support  The following basic math operators may be applied directly on numeric
    /// data values: + - * /
    /// For example:
    /// var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;Name: {name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Kids: &#39;,
    /// &#39;&amp;lt;tpl for=&quot;kids&quot;&gt;&#39;,
    /// &#39;&amp;lt;tpl if=&quot;age &amp;amp;gt; 1&quot;&gt;&#39;,  // {#}: {name}&amp;lt;/p&gt;&#39;,  // In 5 Years: {age+5}&amp;lt;/p&gt;&#39;,  // Dad: {parent.name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&amp;lt;/p&gt;&#39;
    /// );
    /// tpl.overwrite(panel.body, data);
    /// Execute arbitrary inline code with special built-in template variables  Anything between {[ ... ]} is considered code to be executed
    /// in the scope of the template. There are some special variables available in that code:
    /// values: The values in the current scope. If you are using
    /// scope changing sub-templates, you can change what values is. parent: The scope (values) of the ancestor template. xindex: If you are in a looping template, the index of the
    /// loop you are in (1-based). xcount: If you are in a looping template, the total length
    /// of the array you are looping.
    /// This example demonstrates basic row striping using an inline code block and the
    /// xindex variable: var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;Name: {name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Company: {[values.company.toUpperCase() + &quot;, &quot; + values.title]}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Kids: &#39;,
    /// &#39;&amp;lt;tpl for=&quot;kids&quot;&gt;&#39;,
    /// &#39;&amp;lt;div class=&quot;{[xindex % 2 === 0 ? &quot;even&quot; : &quot;odd&quot;]}&quot;&gt;&#39;,
    /// &#39;{name}&#39;,
    /// &#39;&amp;lt;/div&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&amp;lt;/p&gt;&#39;
    /// );
    /// tpl.overwrite(panel.body, data);
    /// Template member functions  One or more member functions can be specified in a configuration
    /// object passed into the XTemplate constructor for more complex processing: var tpl = new Ext.XTemplate(
    /// &#39;&amp;lt;p&gt;Name: {name}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Kids: &#39;,
    /// &#39;&amp;lt;tpl for=&quot;kids&quot;&gt;&#39;,
    /// &#39;&amp;lt;tpl if=&quot;this.isGirl(name)&quot;&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Girl: {name} - {age}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&#39;,
    /// // use opposite if statement to simulate &#39;else&#39; processing:
    /// &#39;&amp;lt;tpl if=&quot;this.isGirl(name) == false&quot;&gt;&#39;,
    /// &#39;&amp;lt;p&gt;Boy: {name} - {age}&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&#39;,
    /// &#39;&amp;lt;tpl if=&quot;this.isBaby(age)&quot;&gt;&#39;,
    /// &#39;&amp;lt;p&gt;{name} is a baby!&amp;lt;/p&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&#39;,
    /// &#39;&amp;lt;/tpl&gt;&amp;lt;/p&gt;&#39;,
    /// {
    /// // XTemplate configuration:
    /// compiled: true,
    /// // member functions:
    /// isGirl: function(name){
    /// return name == &#39;Sara Grace&#39;;
    /// },
    /// isBaby: function(age){
    /// return age
    /// </summary>
    [JsType( JsMode.Prototype, Export = false )]
    public partial class XTemplate : Ext.Template
    {
        /// <summary>
        /// Alias for applyTemplate
        /// Returns an HTML fragment of this template with the specified values applied. ...
        /// </summary>
        public new JsString apply( object values ) { return null; }
        /// <summary>
        /// Returns an HTML fragment of this template with the specified values applied. ...
        /// </summary>
        public new JsString applyTemplate( object values ) { return null; }
        /// <summary>
        /// Compile the template to a function for optimized performance. ...
        /// </summary>
        public new JsAction compile() { return null; }
        public XTemplate( XTemplateConfig config ) { }
        public XTemplate() { }
        public XTemplate( params object[] parametros ) { }
    }
    #endregion
    #region XTemplateConfig
    [JsType( JsMode.Json, Export = false )]
    public partial class XTemplateConfig : Ext.TemplateConfig
    {
        public JsRegExp codeRe { get; set; }
    }
    #endregion
    #region XTemplateEvents
    [JsType( JsMode.Json, Export = false )]
    public partial class XTemplateEvents : Ext.TemplateEvents
    {
    }
    #endregion
}
#endregion
