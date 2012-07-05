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
    /// <p>The class for creating Diffie-Hellman key exchanges.
    /// </p>
    /// <p>Returned by <code>crypto.createDiffieHellman</code>.
    /// </p>
    /// </summary>
    public partial class DiffieHellman
    {
        /// <summary>
        /// <p>Computes the shared secret using <code>other_public_key</code> as the other party&apos;s
        /// public key and returns the computed shared secret. Supplied key is
        /// interpreted using specified <code>input_encoding</code>, and secret is encoded using
        /// specified <code>output_encoding</code>. Encodings can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or
        /// <code>&apos;base64&apos;</code>. The input encoding defaults to <code>&apos;binary&apos;</code>.
        /// If no output encoding is given, the input encoding is used as output encoding.
        /// </p>
        /// </summary>
        public object computeSecret(object other_public_key){return null;}
        /// <summary>
        /// <p>Computes the shared secret using <code>other_public_key</code> as the other party&apos;s
        /// public key and returns the computed shared secret. Supplied key is
        /// interpreted using specified <code>input_encoding</code>, and secret is encoded using
        /// specified <code>output_encoding</code>. Encodings can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or
        /// <code>&apos;base64&apos;</code>. The input encoding defaults to <code>&apos;binary&apos;</code>.
        /// If no output encoding is given, the input encoding is used as output encoding.
        /// </p>
        /// </summary>
        public object computeSecret(object other_public_key, object output_encoding){return null;}
        /// <summary>
        /// <p>Computes the shared secret using <code>other_public_key</code> as the other party&apos;s
        /// public key and returns the computed shared secret. Supplied key is
        /// interpreted using specified <code>input_encoding</code>, and secret is encoded using
        /// specified <code>output_encoding</code>. Encodings can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or
        /// <code>&apos;base64&apos;</code>. The input encoding defaults to <code>&apos;binary&apos;</code>.
        /// If no output encoding is given, the input encoding is used as output encoding.
        /// </p>
        /// </summary>
        public object computeSecret(object other_public_key, object input_encoding, object output_encoding){return null;}
        /// <summary>
        /// <p>Generates private and public Diffie-Hellman key values, and returns the
        /// public key in the specified encoding. This key should be transferred to the
        /// other party. Encoding can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>.
        /// Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object generateKeys(){return null;}
        /// <summary>
        /// <p>Generates private and public Diffie-Hellman key values, and returns the
        /// public key in the specified encoding. This key should be transferred to the
        /// other party. Encoding can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>.
        /// Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object generateKeys(object encoding){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman prime in the specified encoding, which can be
        /// <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getGenerator(){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman prime in the specified encoding, which can be
        /// <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getGenerator(object encoding){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman prime in the specified encoding, which can be
        /// <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getPrime(){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman prime in the specified encoding, which can be
        /// <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getPrime(object encoding){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman private key in the specified encoding, which can
        /// be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getPrivateKey(){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman private key in the specified encoding, which can
        /// be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getPrivateKey(object encoding){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman public key in the specified encoding, which can
        /// be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getPublicKey(){return null;}
        /// <summary>
        /// <p>Returns the Diffie-Hellman public key in the specified encoding, which can
        /// be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>, or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object getPublicKey(object encoding){return null;}
        /// <summary>
        /// <p>Sets the Diffie-Hellman private key. Key encoding can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>,
        /// or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object setPrivateKey(object public_key){return null;}
        /// <summary>
        /// <p>Sets the Diffie-Hellman private key. Key encoding can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>,
        /// or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object setPrivateKey(object public_key, object encoding){return null;}
        /// <summary>
        /// <p>Sets the Diffie-Hellman public key. Key encoding can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>,
        /// or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object setPublicKey(object public_key){return null;}
        /// <summary>
        /// <p>Sets the Diffie-Hellman public key. Key encoding can be <code>&apos;binary&apos;</code>, <code>&apos;hex&apos;</code>,
        /// or <code>&apos;base64&apos;</code>. Defaults to <code>&apos;binary&apos;</code>.
        /// </p>
        /// </summary>
        public object setPublicKey(object public_key, object encoding){return null;}
    }
}
