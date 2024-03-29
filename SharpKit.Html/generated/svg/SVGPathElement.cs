
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGPathElement.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2013 Sebastian Loncar, Web: http://loncar.de
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

namespace SharpKit.Html.svg
{

using SharpKit.JavaScript;
using SharpKit.Html.fileapi;
using SharpKit.Html.html.shadow;
using SharpKit.Html.html.track;
using SharpKit.Html.inspector;
using SharpKit.Html.loader.appcache;
using SharpKit.Html.battery;
using SharpKit.Html.filesystem;
using SharpKit.Html.gamepad;
using SharpKit.Html.geolocation;
using SharpKit.Html.indexeddb;
using SharpKit.Html.intents;
using SharpKit.Html.mediasource;
using SharpKit.Html.mediastream;
using SharpKit.Html.navigatorcontentutils;
using SharpKit.Html.networkinfo;
using SharpKit.Html.notifications;
using SharpKit.Html.proximity;
using SharpKit.Html.quota;
using SharpKit.Html.speech;
using SharpKit.Html.vibration;
using SharpKit.Html.webaudio;
using SharpKit.Html.webdatabase;
using SharpKit.Html.plugins;
using SharpKit.Html.storage;
using SharpKit.Html.svg;
using SharpKit.Html.workers;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGPathElement")]
public partial class SvgPathElement : SvgElement, SvgTests, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgTransformable
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('path')")]
	public   SvgPathElement() {}
	public  SvgAnimatedNumber pathLength {get; set; }
	public  double getTotalLength() { return default(double); }
	public  SvgPoint getPointAtLength(double distance) { return default(SvgPoint); }
	public  int getPathSegAtLength(double distance) { return default(int); }
	public  SvgPathSegClosePath createSVGPathSegClosePath() { return default(SvgPathSegClosePath); }
	public  SvgPathSegMovetoAbs createSVGPathSegMovetoAbs(double x, double y) { return default(SvgPathSegMovetoAbs); }
	public  SvgPathSegMovetoRel createSVGPathSegMovetoRel(double x, double y) { return default(SvgPathSegMovetoRel); }
	public  SvgPathSegLinetoAbs createSVGPathSegLinetoAbs(double x, double y) { return default(SvgPathSegLinetoAbs); }
	public  SvgPathSegLinetoRel createSVGPathSegLinetoRel(double x, double y) { return default(SvgPathSegLinetoRel); }
	public  SvgPathSegCurvetoCubicAbs createSVGPathSegCurvetoCubicAbs(double x, double y, double x1, double y1, double x2, double y2) { return default(SvgPathSegCurvetoCubicAbs); }
	public  SvgPathSegCurvetoCubicRel createSVGPathSegCurvetoCubicRel(double x, double y, double x1, double y1, double x2, double y2) { return default(SvgPathSegCurvetoCubicRel); }
	public  SvgPathSegCurvetoQuadraticAbs createSVGPathSegCurvetoQuadraticAbs(double x, double y, double x1, double y1) { return default(SvgPathSegCurvetoQuadraticAbs); }
	public  SvgPathSegCurvetoQuadraticRel createSVGPathSegCurvetoQuadraticRel(double x, double y, double x1, double y1) { return default(SvgPathSegCurvetoQuadraticRel); }
	public  SvgPathSegArcAbs createSVGPathSegArcAbs(double x, double y, double r1, double r2, double angle, bool largeArcFlag, bool sweepFlag) { return default(SvgPathSegArcAbs); }
	public  SvgPathSegArcRel createSVGPathSegArcRel(double x, double y, double r1, double r2, double angle, bool largeArcFlag, bool sweepFlag) { return default(SvgPathSegArcRel); }
	public  SvgPathSegLinetoHorizontalAbs createSVGPathSegLinetoHorizontalAbs(double x) { return default(SvgPathSegLinetoHorizontalAbs); }
	public  SvgPathSegLinetoHorizontalRel createSVGPathSegLinetoHorizontalRel(double x) { return default(SvgPathSegLinetoHorizontalRel); }
	public  SvgPathSegLinetoVerticalAbs createSVGPathSegLinetoVerticalAbs(double y) { return default(SvgPathSegLinetoVerticalAbs); }
	public  SvgPathSegLinetoVerticalRel createSVGPathSegLinetoVerticalRel(double y) { return default(SvgPathSegLinetoVerticalRel); }
	public  SvgPathSegCurvetoCubicSmoothAbs createSVGPathSegCurvetoCubicSmoothAbs(double x, double y, double x2, double y2) { return default(SvgPathSegCurvetoCubicSmoothAbs); }
	public  SvgPathSegCurvetoCubicSmoothRel createSVGPathSegCurvetoCubicSmoothRel(double x, double y, double x2, double y2) { return default(SvgPathSegCurvetoCubicSmoothRel); }
	public  SvgPathSegCurvetoQuadraticSmoothAbs createSVGPathSegCurvetoQuadraticSmoothAbs(double x, double y) { return default(SvgPathSegCurvetoQuadraticSmoothAbs); }
	public  SvgPathSegCurvetoQuadraticSmoothRel createSVGPathSegCurvetoQuadraticSmoothRel(double x, double y) { return default(SvgPathSegCurvetoQuadraticSmoothRel); }
	public  SvgPathSegList pathSegList {get; set; }
	public  SvgPathSegList normalizedPathSegList {get; set; }
	public  SvgPathSegList animatedPathSegList {get; set; }
	public  SvgPathSegList animatedNormalizedPathSegList {get; set; }
	public  SvgStringList requiredFeatures {get; set; }
	public  SvgStringList requiredExtensions {get; set; }
	public  SvgStringList systemLanguage {get; set; }
	public  bool hasExtension(string extension) { return default(bool); }
	public  JsString xmllang {get; set; }
	public  JsString xmlspace {get; set; }
	public  SvgAnimatedBoolean externalResourcesRequired {get; set; }
	public  SvgAnimatedString className {get; set; }
	public  CssStyleDeclaration style {get; set; }
	public  CssValue getPresentationAttribute(string name) { return default(CssValue); }
	public  SvgAnimatedTransformList transform {get; set; }
	public  SvgElement nearestViewportElement {get; set; }
	public  SvgElement farthestViewportElement {get; set; }
	public  SvgRect getBBox() { return default(SvgRect); }
	public  SvgMatrix getCTM() { return default(SvgMatrix); }
	public  SvgMatrix getScreenCTM() { return default(SvgMatrix); }
	public  SvgMatrix getTransformToElement(SvgElement element) { return default(SvgMatrix); }
}

}