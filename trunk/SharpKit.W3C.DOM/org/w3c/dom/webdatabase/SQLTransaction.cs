//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.webdatabase
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SQLTransaction
{

	// SQLTransaction
	public void executeSql(string sqlStatement) {}
	public void executeSql(string sqlStatement, object[] arguments) {}
	public void executeSql(string sqlStatement, object[] arguments, SQLStatementCallback callback) {}
	public void executeSql(string sqlStatement, object[] arguments, SQLStatementCallback callback, SQLStatementErrorCallback errorCallback) {}
}

}