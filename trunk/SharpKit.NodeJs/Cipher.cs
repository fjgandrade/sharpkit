//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>Class for encrypting data.
    /// </p>
    /// <p>Returned by <code>crypto.createCipher</code> and <code>crypto.createCipheriv</code>.
    /// </p>
    /// </summary>
    public partial class Cipher
    {
        /// <summary>
        /// <p>Returns any remaining enciphered contents, with <code>output_encoding</code> being one of:
        /// <code>&apos;binary&apos;</code>, <code>&apos;base64&apos;</code> or <code>&apos;hex&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>Note: <code>cipher</code> object can not be used after <code>final()</code> method been called.
        /// </p>
        /// </summary>
        public object final(){return null;}
        /// <summary>
        /// <p>Returns any remaining enciphered contents, with <code>output_encoding</code> being one of:
        /// <code>&apos;binary&apos;</code>, <code>&apos;base64&apos;</code> or <code>&apos;hex&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>Note: <code>cipher</code> object can not be used after <code>final()</code> method been called.
        /// </p>
        /// </summary>
        public object final(object output_encoding){return null;}
        /// <summary>
        /// <p>Updates the cipher with <code>data</code>, the encoding of which is given in
        /// <code>input_encoding</code> and can be <code>&apos;utf8&apos;</code>, <code>&apos;ascii&apos;</code> or <code>&apos;binary&apos;</code>.
        /// Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>The <code>output_encoding</code> specifies the output format of the enciphered data,
        /// and can be <code>&apos;binary&apos;</code>, <code>&apos;base64&apos;</code> or <code>&apos;hex&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>Returns the enciphered contents, and can be called many times with new data as it is streamed.
        /// </p>
        /// </summary>
        public object update(object data){return null;}
        /// <summary>
        /// <p>Updates the cipher with <code>data</code>, the encoding of which is given in
        /// <code>input_encoding</code> and can be <code>&apos;utf8&apos;</code>, <code>&apos;ascii&apos;</code> or <code>&apos;binary&apos;</code>.
        /// Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>The <code>output_encoding</code> specifies the output format of the enciphered data,
        /// and can be <code>&apos;binary&apos;</code>, <code>&apos;base64&apos;</code> or <code>&apos;hex&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>Returns the enciphered contents, and can be called many times with new data as it is streamed.
        /// </p>
        /// </summary>
        public object update(object data, object output_encoding){return null;}
        /// <summary>
        /// <p>Updates the cipher with <code>data</code>, the encoding of which is given in
        /// <code>input_encoding</code> and can be <code>&apos;utf8&apos;</code>, <code>&apos;ascii&apos;</code> or <code>&apos;binary&apos;</code>.
        /// Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>The <code>output_encoding</code> specifies the output format of the enciphered data,
        /// and can be <code>&apos;binary&apos;</code>, <code>&apos;base64&apos;</code> or <code>&apos;hex&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// <p>Returns the enciphered contents, and can be called many times with new data as it is streamed.
        /// </p>
        /// </summary>
        public object update(object data, object input_encoding, object output_encoding){return null;}
    }
}
