//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.tinymce.html
{
    /// <summary>
    /// This class is used to parse CSS styles it also compresses styles to reduce the output size.
    /// </summary>
    public  partial class Styles
    {
        /// <summary>
        /// Parses the specified style value into an object collection. This parser will also
        /// merge and remove any redundant items that browsers might have added. It will also convert non hex
        /// colors to hex values. Urls inside the styles will also be converted to absolute/relative based on settings.
        /// </summary>
        /// <param name="css">Style value to parse for example: border:1px solid red;.</param>
        public object parse(string css){return null;}
        /// <summary>
        /// Serializes the specified style object into a string.
        /// </summary>
        /// <param name="styles">Object to serialize as string for example: {border : '1px solid red'}</param>
        /// <param name="element_name">Optional element name, if specified only the styles that matches the schema will be serialized.</param>
        public string serialize(object styles, string element_name){return null;}
        /// <summary>
        /// Parses the specified RGB color value and returns a hex version of that color.
        /// </summary>
        /// <param name="color">RGB string value like rgb(1,2,3)</param>
        public string toHex(string color){return null;}
    }
}
