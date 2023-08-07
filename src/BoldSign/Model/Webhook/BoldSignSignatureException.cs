// <copyright file="BoldSignSignatureException.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System;

    /// <summary>
    /// The signature verification exception message.
    /// </summary>
    [Serializable]
    public class BoldSignSignatureException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoldSignSignatureException"/> class.
        /// </summary>
        public BoldSignSignatureException()
        {
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="BoldSignSignatureException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public BoldSignSignatureException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoldSignSignatureException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public BoldSignSignatureException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoldSignSignatureException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The serialization info.</param>
        /// <param name="streamingContext">The streaming context.</param>
        protected BoldSignSignatureException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
        }
    }
}