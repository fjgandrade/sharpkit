// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>This widget is used as feedback widget in drag and drop actions.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.DragDropCursor", OmitOptionalParameters = true, Export = false)]
    public partial class DragDropCursor : qx.ui.basic.Image
    {
		#region Properties

		/// <summary>
		/// <para>The current drag&amp;drop action</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "alias","copy","move"
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "action", NativeField = true)]
		public object Action { get; set; }

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>Whether the widget should moved using DOM methods.</para>
		/// </summary>
		[JsProperty(Name = "domMove", NativeField = true)]
		public bool DomMove { get; set; }

		/// <summary>
		/// <para>Offsets in one group</para>
		/// </summary>
		[JsProperty(Name = "offset", NativeField = true)]
		public object Offset { get; set; }

		/// <summary>
		/// <para>Bottom offset of the mouse pointer (in pixel)</para>
		/// </summary>
		[JsProperty(Name = "offsetBottom", NativeField = true)]
		public double OffsetBottom { get; set; }

		/// <summary>
		/// <para>Left offset of the mouse pointer (in pixel)</para>
		/// </summary>
		[JsProperty(Name = "offsetLeft", NativeField = true)]
		public double OffsetLeft { get; set; }

		/// <summary>
		/// <para>Right offset of the mouse pointer (in pixel)</para>
		/// </summary>
		[JsProperty(Name = "offsetRight", NativeField = true)]
		public double OffsetRight { get; set; }

		/// <summary>
		/// <para>Top offset of the mouse pointer (in pixel)</para>
		/// </summary>
		[JsProperty(Name = "offsetTop", NativeField = true)]
		public double OffsetTop { get; set; }

		/// <summary>
		/// <para>Selects the algorithm to place the widget horizontally. direct
		/// uses <see cref="qx.util.placement.DirectAxis"/>, keep-align
		/// uses <see cref="qx.util.placement.KeepAlignAxis"/> and best-fit
		/// uses <see cref="qx.util.placement.BestFitAxis"/>.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "direct","keep-align","best-fit"
		/// </remarks>
		[JsProperty(Name = "placementModeX", NativeField = true)]
		public object PlacementModeX { get; set; }

		/// <summary>
		/// <para>Selects the algorithm to place the widget vertically. direct
		/// uses <see cref="qx.util.placement.DirectAxis"/>, keep-align
		/// uses <see cref="qx.util.placement.KeepAlignAxis"/> and best-fit
		/// uses <see cref="qx.util.placement.BestFitAxis"/>.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "direct","keep-align","best-fit"
		/// </remarks>
		[JsProperty(Name = "placementModeY", NativeField = true)]
		public object PlacementModeY { get; set; }

		/// <summary>
		/// <para>Whether the widget should be placed relative to an other widget or to
		/// the mouse cursor.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "widget","mouse"
		/// </remarks>
		[JsProperty(Name = "placeMethod", NativeField = true)]
		public object PlaceMethod { get; set; }

		/// <summary>
		/// <para>Position of the aligned object in relation to the opener.</para>
		/// <para>Please note than changes to this property are only applied
		/// when re-aligning the widget.</para>
		/// <para>The first part of the value is the edge to attach to. The second
		/// part the alignment of the orthogonal edge after the widget
		/// has been attached.</para>
		/// <para>The default value &#8220;bottom-left&#8221; for example means that the
		/// widget should be shown directly under the given target and
		/// then should be aligned to be left edge:</para>
		/// 
		/// +--------+
		/// | target |
		/// +--------+
		/// +-------------+
		/// |   widget    |
		/// +-------------+
		/// </code>
		/// </summary>
		/// <remarks>
		/// Possible values: "top-left","top-center","top-right","bottom-left","bottom-center","bottom-right","left-top","left-middle","left-bottom","right-top","right-middle","right-bottom"
		/// </remarks>
		[JsProperty(Name = "position", NativeField = true)]
		public object Position { get; set; }

		#endregion Properties

		#region Methods

		public DragDropCursor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property action.</para>
		/// </summary>
		[JsMethod(Name = "getAction")]
		public object GetAction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property action
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property action.</param>
		[JsMethod(Name = "initAction")]
		public void InitAction(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property action.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAction")]
		public void ResetAction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property action.</para>
		/// </summary>
		/// <param name="value">New value for property action.</param>
		[JsMethod(Name = "setAction")]
		public void SetAction(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.ui.core.DragDropCursor GetInstance() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the move direction for an element which hides always visible element.
		/// See <see cref="SetMoveDirection"/> for more details.</para>
		/// </summary>
		/// <returns>The move direction.</returns>
		[JsMethod(Name = "getMoveDirection")]
		public static string GetMoveDirection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the given always visible element. See <see cref="SetVisibleElement"/>
		/// for more details.</para>
		/// </summary>
		/// <returns>The given widget.</returns>
		[JsMethod(Name = "getVisibleElement")]
		public static qx.ui.core.Widget GetVisibleElement() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the move direction for an element which hides always visible element.
		/// The value has only an effect when the <see cref="SetVisibleElement"/> is set.</para>
		/// </summary>
		/// <param name="direction">The direction left or top.</param>
		[JsMethod(Name = "setMoveDirection")]
		public static void SetMoveDirection(string direction) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the always visible element. If an element is set, the
		/// <see cref="MoveTo"/> method takes care of every move and tries not to cover
		/// the given element with a movable widget like a popup or context menu.</para>
		/// </summary>
		/// <param name="elem">The widget which should always be visible.</param>
		[JsMethod(Name = "setVisibleElement")]
		public static void SetVisibleElement(qx.ui.core.Widget elem) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property domMove.</para>
		/// </summary>
		[JsMethod(Name = "getDomMove")]
		public bool GetDomMove() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the location data like {qx.bom.element.Location#get} does,
		/// but does not rely on DOM elements coordinates to be rendered. Instead,
		/// this method works with the available layout data available in the moment
		/// when it is executed.
		/// This works best when called in some type of resize or
		/// move event which are supported by all widgets out of the
		/// box.</para>
		/// </summary>
		/// <param name="widget">Any widget</param>
		/// <returns>Returns a map with left, top, right and bottom which contains the distance of the widget relative coords the document.</returns>
		[JsMethod(Name = "getLayoutLocation")]
		public object GetLayoutLocation(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property offsetBottom.</para>
		/// </summary>
		[JsMethod(Name = "getOffsetBottom")]
		public double GetOffsetBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property offsetLeft.</para>
		/// </summary>
		[JsMethod(Name = "getOffsetLeft")]
		public double GetOffsetLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property offsetRight.</para>
		/// </summary>
		[JsMethod(Name = "getOffsetRight")]
		public double GetOffsetRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property offsetTop.</para>
		/// </summary>
		[JsMethod(Name = "getOffsetTop")]
		public double GetOffsetTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property placementModeX.</para>
		/// </summary>
		[JsMethod(Name = "getPlacementModeX")]
		public object GetPlacementModeX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property placementModeY.</para>
		/// </summary>
		[JsMethod(Name = "getPlacementModeY")]
		public object GetPlacementModeY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property placeMethod.</para>
		/// </summary>
		[JsMethod(Name = "getPlaceMethod")]
		public object GetPlaceMethod() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property position.</para>
		/// </summary>
		[JsMethod(Name = "getPosition")]
		public object GetPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property domMove
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property domMove.</param>
		[JsMethod(Name = "initDomMove")]
		public void InitDomMove(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property offsetBottom
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property offsetBottom.</param>
		[JsMethod(Name = "initOffsetBottom")]
		public void InitOffsetBottom(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property offsetLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property offsetLeft.</param>
		[JsMethod(Name = "initOffsetLeft")]
		public void InitOffsetLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property offsetRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property offsetRight.</param>
		[JsMethod(Name = "initOffsetRight")]
		public void InitOffsetRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property offsetTop
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property offsetTop.</param>
		[JsMethod(Name = "initOffsetTop")]
		public void InitOffsetTop(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property placementModeX
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property placementModeX.</param>
		[JsMethod(Name = "initPlacementModeX")]
		public void InitPlacementModeX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property placementModeY
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property placementModeY.</param>
		[JsMethod(Name = "initPlacementModeY")]
		public void InitPlacementModeY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property placeMethod
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property placeMethod.</param>
		[JsMethod(Name = "initPlaceMethod")]
		public void InitPlaceMethod(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property position
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property position.</param>
		[JsMethod(Name = "initPosition")]
		public void InitPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property domMove equals true.</para>
		/// </summary>
		[JsMethod(Name = "isDomMove")]
		public void IsDomMove() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the position. Uses low-level, high-performance DOM
		/// methods when the property <see cref="DomMove"/> is enabled.
		/// Checks if an always visible element is set and moves the widget to not
		/// overlay the always visible widget if possible. The algorithm tries to
		/// move the widget as far left as necessary but not of the screen.
		/// (<see cref="SetVisibleElement"/>)</para>
		/// </summary>
		/// <param name="left">The left position</param>
		/// <param name="top">The top position</param>
		[JsMethod(Name = "moveTo")]
		public void MoveTo(double left, double top) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Places the widget to any (rendered) DOM element.</para>
		/// </summary>
		/// <param name="elem">DOM element to align to</param>
		/// <param name="liveupdate">Flag indicating if the position of the widget should be checked and corrected automatically.</param>
		[JsMethod(Name = "placeToElement")]
		public void PlaceToElement(qx.html.Element elem, bool liveupdate) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Places the widget to the mouse cursor position.</para>
		/// </summary>
		/// <param name="eventx">Mouse event to align to</param>
		[JsMethod(Name = "placeToMouse")]
		public void PlaceToMouse(qx.eventx.type.Mouse eventx) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Places the widget in relation to the given point</para>
		/// </summary>
		/// <param name="point">Coordinate of any point with the keys left and top.</param>
		[JsMethod(Name = "placeToPoint")]
		public void PlaceToPoint(object point) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Places the widget to another (at least laid out) widget. The DOM
		/// element is not needed, but the bounds are needed to compute the
		/// location of the widget to align to.</para>
		/// </summary>
		/// <param name="target">Target coords align coords</param>
		/// <param name="liveupdate">Flag indicating if the position of the widget should be checked and corrected automatically.</param>
		/// <returns>true if the widget was successfully placed</returns>
		[JsMethod(Name = "placeToWidget")]
		public bool PlaceToWidget(qx.ui.core.Widget target, bool liveupdate) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property domMove.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDomMove")]
		public void ResetDomMove() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property offset.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOffset")]
		public void ResetOffset() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property offsetBottom.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOffsetBottom")]
		public void ResetOffsetBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property offsetLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOffsetLeft")]
		public void ResetOffsetLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property offsetRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOffsetRight")]
		public void ResetOffsetRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property offsetTop.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOffsetTop")]
		public void ResetOffsetTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property placementModeX.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPlacementModeX")]
		public void ResetPlacementModeX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property placementModeY.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPlacementModeY")]
		public void ResetPlacementModeY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property placeMethod.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPlaceMethod")]
		public void ResetPlaceMethod() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property position.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPosition")]
		public void ResetPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property domMove.</para>
		/// </summary>
		/// <param name="value">New value for property domMove.</param>
		[JsMethod(Name = "setDomMove")]
		public void SetDomMove(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group offset.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="offsetTop">Sets the value of the property #offsetTop.</param>
		/// <param name="offsetRight">Sets the value of the property #offsetRight.</param>
		/// <param name="offsetBottom">Sets the value of the property #offsetBottom.</param>
		/// <param name="offsetLeft">Sets the value of the property #offsetLeft.</param>
		[JsMethod(Name = "setOffset")]
		public void SetOffset(object offsetTop, object offsetRight, object offsetBottom, object offsetLeft) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property offsetBottom.</para>
		/// </summary>
		/// <param name="value">New value for property offsetBottom.</param>
		[JsMethod(Name = "setOffsetBottom")]
		public void SetOffsetBottom(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property offsetLeft.</para>
		/// </summary>
		/// <param name="value">New value for property offsetLeft.</param>
		[JsMethod(Name = "setOffsetLeft")]
		public void SetOffsetLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property offsetRight.</para>
		/// </summary>
		/// <param name="value">New value for property offsetRight.</param>
		[JsMethod(Name = "setOffsetRight")]
		public void SetOffsetRight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property offsetTop.</para>
		/// </summary>
		/// <param name="value">New value for property offsetTop.</param>
		[JsMethod(Name = "setOffsetTop")]
		public void SetOffsetTop(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property placementModeX.</para>
		/// </summary>
		/// <param name="value">New value for property placementModeX.</param>
		[JsMethod(Name = "setPlacementModeX")]
		public void SetPlacementModeX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property placementModeY.</para>
		/// </summary>
		/// <param name="value">New value for property placementModeY.</param>
		[JsMethod(Name = "setPlacementModeY")]
		public void SetPlacementModeY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property placeMethod.</para>
		/// </summary>
		/// <param name="value">New value for property placeMethod.</param>
		[JsMethod(Name = "setPlaceMethod")]
		public void SetPlaceMethod(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property position.</para>
		/// </summary>
		/// <param name="value">New value for property position.</param>
		[JsMethod(Name = "setPosition")]
		public void SetPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property domMove.</para>
		/// </summary>
		[JsMethod(Name = "toggleDomMove")]
		public void ToggleDomMove() { throw new NotImplementedException(); }

		#endregion Methods
    }
}