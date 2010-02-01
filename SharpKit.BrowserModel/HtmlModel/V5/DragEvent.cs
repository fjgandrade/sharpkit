//using System;
//using System.Collections.Generic;
//using System.Text;
//using SharpKit.JavaScriptModel;
//using SharpKit.BrowserModel.BrowserCompatibility;

//namespace SharpKit.HtmlModel
//{

///// <summary>
///// The drag-and-drop processing model involves several events. They all use the DragEvent interface.
///// </summary>

//[HtmlSpecificationVersion(5)]
//[JsType(Export = false,Name = "DragEvent", NativeConstructors = true, NativeEnumerator = true)]
//public abstract class DragEvent: MouseEvent
//{
//  [HtmlSpecificationVersion(5)]
//  [JsProperty(NativeField=true)]
//  public DataTransfer dataTransfer
//  {
//    get;
//    private set;
//  }
//  [HtmlSpecificationVersion(5)]
//  [JsMethod(NativeDelegates=true,NativeOverloads=true)]
//  public void initDragEvent(string typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, long detailArg, long screenXArg, long screenYArg, long clientXArg, long clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, ushort buttonArg, EventTarget relatedTargetArg, DataTransfer dataTransferArg)
//  {
//    throw new NotImplementedException();
//  }
//}

//}
