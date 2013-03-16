// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.dev.unit
{
    /// <summary>
	/// <para>The test loader is the base class of a native application, which can be used
	/// to run tests from a non-GUI application or from within JSUnit.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.dev.unit.TestLoader", OmitOptionalParameters = true, Export = false)]
    public partial class TestLoader : qx.application.Standalone
    {
		#region Properties

		/// <summary>
		/// <para>The test suite</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "suite", NativeField = true)]
		public qx.dev.unit.TestSuite Suite { get; set; }

		#endregion Properties

		#region Methods

		public TestLoader() { throw new NotImplementedException(); }

		[JsMethod(Name = "main")]
		public void Main() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property suite.</para>
		/// </summary>
		[JsMethod(Name = "getSuite")]
		public qx.dev.unit.TestSuite GetSuite() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of test descriptions</para>
		/// </summary>
		/// <returns>A description of all tests.</returns>
		[JsMethod(Name = "getTestDescriptions")]
		public string GetTestDescriptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property suite
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property suite.</param>
		[JsMethod(Name = "initSuite")]
		public void InitSuite(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property suite.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSuite")]
		public void ResetSuite() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Run all tests and export the results to JSUnit</para>
		/// </summary>
		[JsMethod(Name = "runJsUnit")]
		public void RunJsUnit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Run tests as standalone application</para>
		/// </summary>
		[JsMethod(Name = "runStandAlone")]
		public void RunStandAlone() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Runs exactly one test from the test suite</para>
		/// </summary>
		/// <param name="testResult">the result logger</param>
		/// <param name="className">Name of the test class</param>
		/// <param name="methodName">Name of the test method</param>
		[JsMethod(Name = "runTests")]
		public void RunTests(TestResult testResult, string className, string methodName) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Runs all tests inside of the given namespace</para>
		/// </summary>
		/// <param name="testResult">the result logger</param>
		/// <param name="namespaceName">Namespace of the tests to run</param>
		[JsMethod(Name = "runTestsFromNamespace")]
		public void RunTestsFromNamespace(TestResult testResult, string namespaceName) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property suite.</para>
		/// </summary>
		/// <param name="value">New value for property suite.</param>
		[JsMethod(Name = "setSuite")]
		public void SetSuite(qx.dev.unit.TestSuite value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the top level namespace of the test cases to test. All classes
		/// below this namespace extending <see cref="TestCase"/> will be tested.</para>
		/// </summary>
		/// <param name="namespacex">Namespace to add</param>
		[JsMethod(Name = "setTestNamespace")]
		public void SetTestNamespace(object namespacex) { throw new NotImplementedException(); }

		#endregion Methods
    }
}