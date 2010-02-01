using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.BrowserModel.BrowserCompatibility
{
	/// <summary>
	/// Compile with browser compatibility #defines to activate (i.e. BROWSER_IE6, BROWSER_FireFox3)
	/// </summary>
	public class SupportedBrowsersAttribute : Attribute
	{
		public SupportedBrowsersAttribute(BrowserTypes sb)
		{
			SupportedBrowser = sb;
		}
		public SupportedBrowsersAttribute(BrowserTypes sb, string notSupportedRemark)
		{
			SupportedBrowser = sb;
			NotSupportedRemark = notSupportedRemark;
		}
		public BrowserTypes SupportedBrowser { get; set; }
		/// <summary>
		/// If specified, and the browser is not supported, this text will be appended to the generate warning.
		/// </summary>
		public string NotSupportedRemark { get; set; }

		/// <summary>
		/// If specified, a warning will be generated even if the browser is supported. This is used for features that are partially supported.
		/// </summary>
		public string PartiallySupportedRemark { get; set; }
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly, AllowMultiple=true)]
	public class IgnoreBrowserCompatibilityAttribute : Attribute
	{
		public IgnoreBrowserCompatibilityAttribute()
		{
		}

		public IgnoreBrowserCompatibilityAttribute(string ignoredElements)
		{
		}

		public string IgnoredElements { get; set; }
	}

	/// <summary>
	/// Compile with html specification #deinfes to activate (ie. HTMLSPEC_4, HTMLSPEC_4_01, HTMLSPEC_5)
	/// </summary>
	public class HtmlSpecificationVersionAttribute : Attribute
	{
		public HtmlSpecificationVersionAttribute(float specLevel)
		{
			Specification = specLevel;
		}

		public float Specification { get; set; }
	}

	[Flags]
	public enum BrowserTypes : uint
	{
		None = 0,                 
		IE5_5 = 1,                //2^0
		IE6 = 2,                  //2^1
		IE7 = 4,                  //2^2
		IE8 = 8,                  //2^3
		IE8AsIE7 = 16,            //2^4
		IE9 = 32,                 //2^5

		FireFox2 = 64,            //2^6
		FireFox3 = 128,           //2^7
		FireFox3_5 = 256,         //2^8
		FireFox4 = 512,           //2^9

		Saf3Win = 1024,           //2^10
		Saf3_1Win = 2048,         //2^11
		Saf4Win = 4096,           //2^12

		Chrome2 = 8192,           //2^13
		Chrome3 = 16384,          //2^14
		Chrome4 = 32768,          //2^15
		Chrome5 = 65536,          //2^16

		Opera9 = 131072,          //2^17
		Opera10 = 262144,         //2^18

		Konqueror3_57 = 524288,   //2^19

		//IPhone2 = 1048576,        //2^20
		//IPhone3 = 2097152,        //2^21
		//IPhone4 = 4194304,        //2^22


		//Reserved1 = 8388608,      //2^23
		//Reserved2 = 16777216,     //2^24
		//Reserved3 = 33554432,     //2^25
		//Reserved4 = 67108864,     //2^26
		//Reserved5 = 134217728,    //2^27
		//Reserved6 = 268435456,    //2^28
		//Reserved7 = 536870912,    //2^29
		//Reserved8 = 1073741824,   //2^30
		//Reserved9 = 2147483648    //2^31
	}
}
