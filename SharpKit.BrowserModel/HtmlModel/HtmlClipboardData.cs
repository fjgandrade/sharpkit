using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.BrowserModel.BrowserCompatibility;
using SharpKit.JavaScriptModel;

namespace SharpKit.HtmlModel
{
	/// <summary>
	/// Provides access to predefined clipboard formats for use in editing operations.
	/// </summary>
	public class HtmlClipboardData
	{
		/// <summary>
		/// Assigns data in a specified format to the dataTransfer object or the clipboardData object.
		/// </summary>
		/// <param name="sDataFormat">Required. A String that specifies the format of the data to be transferred, using one of the following values. </param>
		/// <param name="sData">Required. A String that specifies the data supplied by the source object. This information can be descriptive text, a source path to an image, or a URL for an anchor. When you pass "URL" as the sDataFormat parameter, you must use the sData parameter to provide the location of the object that is transferred. </param>
		[JsMethod(NativeOverloads = true)]
		public void setData(string sDataFormat, string sData)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the data in the specified format from the clipboard through the dataTransfer object or the clipboardData object.
		/// </summary>
		/// <param name="sDataFormat">Required. A String that specifies one of the following data format values. </param>
		/// <returns>String. Returns the data in the format retrieved from the clipboard through the dataTransfer object or the clipboardData object. Depending on the information contained in setData, this variable can get a path to an image, text, or an anchor URL.</returns>
		[JsMethod(NativeOverloads = true)]
		public string getData(string sDataFormat)
		{
			throw new NotImplementedException();
		}
	}
}
