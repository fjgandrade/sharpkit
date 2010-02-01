using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScriptModel;
using SharpKit.BrowserModel.BrowserCompatibility;

namespace SharpKit.HtmlModel
{
	[HtmlSpecificationVersion(5)]
	[JsType(Export = false, Name = "SQLException")]
	public class SQLException : Exception
	{
		/// <summary>
		/// The transaction failed for reasons unrelated to the database itself and not covered by any other error code.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort UNKNOWN_ERR = 0;
		/// <summary>
		/// The statement failed for database reasons not covered by any other error code.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort DATABASE_ERR = 1;
		/// <summary>
		/// The operation failed because the actual database version was not what it should be. For example, a statement found that the actual database version no longer matched the expected version of the Database or DatabaseSync object, or the Database.changeVersion() or DatabaseSync.changeVersion() methods were passed a version that doesn't match the actual database version.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort VERSION_ERR = 2;
		/// <summary>
		/// The statement failed because the data returned from the database was too large. The SQL "LIMIT" modifier might be useful to reduce the size of the result set.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort TOO_LARGE_ERR = 3;
		/// <summary>
		/// The statement failed because there was not enough remaining storage space, or the storage quota was reached and the user declined to give more space to the database.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort QUOTA_ERR = 4;
		/// <summary>
		/// The statement failed because of a syntax error, or the number of arguments did not match the number of ? placeholders in the statement, or the statement tried to use a statement that is not allowed, such as BEGIN, COMMIT, or ROLLBACK, or the statement tried to use a verb that could modify the database but the transaction was read-only.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort SYNTAX_ERR = 5;
		/// <summary>
		/// An INSERT, UPDATE, or REPLACE statement failed due to a constraint failure. For example, because a row was being inserted and the value given for the primary key column duplicated the value of an existing row.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort CONSTRAINT_ERR = 6;
		/// <summary>
		/// A lock for the transaction could not be obtained in a reasonable time.
		/// </summary>
		[HtmlSpecificationVersion(5)]
		public const ushort TIMEOUT_ERR = 7;

		/// <summary>
		/// see SQLException constants
		/// </summary>
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ushort code { get; private set; }

		/// <summary>
		/// an error message describing the error encountered
		/// </summary>
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string message { get; private set; }
	}
}
