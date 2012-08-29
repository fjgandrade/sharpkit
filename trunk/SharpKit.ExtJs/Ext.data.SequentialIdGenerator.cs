//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region SequentialIdGenerator
    /// <inheritdocs />
    /// <summary>
    /// <p>This class is a sequential id generator. A simple use of this class would be like so:</p>
    /// <pre><code><see cref="Ext.ExtContext.define">Ext.define</see>('MyApp.data.MyModel', {
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// idgen: 'sequential'
    /// });
    /// // assign id's of 1, 2, 3, etc.
    /// </code></pre>
    /// <p>An example of a configured generator would be:</p>
    /// <pre><code><see cref="Ext.ExtContext.define">Ext.define</see>('MyApp.data.MyModel', {
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// idgen: {
    /// type: 'sequential',
    /// prefix: 'ID_',
    /// seed: 1000
    /// }
    /// });
    /// // assign id's of ID_1000, ID_1001, ID_1002, etc.
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class SequentialIdGenerator : IdGenerator
    {
        /// <summary>
        /// The string to place in front of the sequential number for each generated id. The
        /// default is blank.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString prefix;
        /// <summary>
        /// The number at which to start generating sequential id's. The default is 1.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber seed;
        public SequentialIdGenerator(SequentialIdGeneratorConfig config){}
        public SequentialIdGenerator(){}
        public SequentialIdGenerator(params object[] args){}
    }
    #endregion
    #region SequentialIdGeneratorConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SequentialIdGeneratorConfig : IdGeneratorConfig
    {
        /// <summary>
        /// The string to place in front of the sequential number for each generated id. The
        /// default is blank.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString prefix;
        /// <summary>
        /// The number at which to start generating sequential id's. The default is 1.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber seed;
        public SequentialIdGeneratorConfig(params object[] args){}
    }
    #endregion
    #region SequentialIdGeneratorEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SequentialIdGeneratorEvents : IdGeneratorEvents
    {
        public SequentialIdGeneratorEvents(params object[] args){}
    }
    #endregion
}
