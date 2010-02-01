using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Creates a scrolling text marquee.
	/// </summary>
	public class HtmlMarqueeElement : HtmlElement
	{
		/// <summary>
		/// Fires when the behavior property of the marquee object is set to "alternate" and the contents of the marquee reach one side of the window.
		/// </summary>		
		public HtmlDomEventHandler onbounce;

		/// <summary>
		/// Fires when marquee looping is complete.
		/// </summary>		
		public HtmlDomEventHandler onfinish;

		/// <summary>
		/// Fires at the beginning of every loop of the marquee object.
		/// </summary>		
		public HtmlDomEventHandler onstart;

		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string behavior
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string bgColor
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string direction
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string height
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong hspace
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public long loop
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong scrollAmount
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong scrollDelay
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string trueSpeed
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public ulong vspace
		{
			get;
			set;
		}
		[HtmlSpecificationVersion(5)]
		[JsProperty(NativeField = true)]
		public string width
		{
			get;
			set;
		}

		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void start()
		{
			throw new NotImplementedException();
		}
		[HtmlSpecificationVersion(5)]
		[JsMethod(NativeDelegates = true, NativeOverloads = true)]
		public void stop()
		{
			throw new NotImplementedException();
		}
	}
}
