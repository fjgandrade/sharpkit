<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWorld.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<asp:ScriptManager ID="ScriptManager1" runat="server">
		<Scripts>
			<asp:ScriptReference Path="Default.aspx.js" />
		</Scripts>
	</asp:ScriptManager>
	<div>
		<asp:Button runat="server" OnClientClick="return btn_click();" Text="Detect my browser" />
	</div>
	</form>
</body>
</html>
