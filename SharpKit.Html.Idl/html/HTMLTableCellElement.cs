
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:27:57 GMT

  Content was generated from IDL file:
	http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLTableCellElement.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

	Copyright (C) 2012 Sebastian Loncar
	Copyright (C) 2009 Apple Inc. All Rights Reserved.

	MIT License:

	Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
	associated documentation files (the "Software"), to deal in the Software without restriction, 
	including without limitation the rights to use, copy, modify, merge, publish, distribute,
	sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in all copies or substantial
	portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
	NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
	NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
	OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
	CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLTableCellElement")]
public partial class HtmlTableCellElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('tablecell')")]
	public   HtmlTableCellElement() {}
	public  int cellIndex {get; set; }
	public  JsString abbr {get; set; }
	public  JsString align {get; set; }
	public  JsString axis {get; set; }
	public  JsString bgColor {get; set; }
	public  JsString ch {get; set; }
	public  JsString chOff {get; set; }
	public  int colSpan {get; set; }
	public  JsString headers {get; set; }
	public  JsString height {get; set; }
	public  bool noWrap {get; set; }
	public  int rowSpan {get; set; }
	public  JsString scope {get; set; }
	public  JsString vAlign {get; set; }
	public  JsString width {get; set; }
}

}