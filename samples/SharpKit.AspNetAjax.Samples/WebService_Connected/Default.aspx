<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebService_Connected.Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:ScriptManager ID="ScriptManager1" runat="server">
			<Services>
				<asp:ServiceReference Path="ConnectedWebService.asmx" />
			</Services>
			<Scripts>
			<asp:ScriptReference Path="Default.aspx.js" />
			</Scripts>
		</asp:ScriptManager>
		Click the button bellow to start / stop polling the web service<br />
		<button id="btnConnect" onclick="btnConnect_Click();return false;">Connect</button>
		<div id="divRepeater1">
		</div>
	</div>
	</form>
</body>
</html>
