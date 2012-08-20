﻿<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>SharpKit Samples</title>
    <link href="../../../res/css/redmond/jquery-ui-1.8.13.custom.css" rel="stylesheet"
        type="text/css" />
    <script src="../../../res/jquery-1.5.2.js" type="text/javascript"></script>
    <script src="../../../res/jquery-ui-1.8.11.custom.min.js" type="text/javascript"></script>
    <script src="Default.js" type="text/javascript"></script>
    <script>        $(jQueryUITabsSample_Load)</script>
</head>
<body>
    <h1>jQuery UI Tabs</h1>
    <p>This sample demonstrates how to use jQuery UI tabs from C#. </p>
    <div id="tabs">
        <ul>
            <li><a href="#tab1">Tab1</a></li>
            <li><a href="#tab2">Tab2</a></li>
        </ul>
        <div id="tab1">
            Welcome to tab 1
        </div>
        <div id="tab2">
            Welcome to tab 2
        </div>
    </div>
</body>
</html>
