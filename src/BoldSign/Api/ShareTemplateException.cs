// <copyright file="ShareTemplateException.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using BoldSign.Api.Model;

    /// <summary>
    /// ShareTemplate exception.
    /// </summary>
    public class ShareTemplateException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareTemplateException"/> class.
        /// </summary>
        public ShareTemplateException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareTemplateException"/> class.
        /// </summary>
        /// <param name="errorCode">The HTTP status code.</param>
        /// <param name="error">The parsed error payload.</param>
        public ShareTemplateException(int errorCode, ShareTemplateError error)
            : base(errorCode, error?.Error ?? "Share template failed.", error)
        {
            this.ErrorCode = errorCode;
            this.ShareTemplateError = error;
        }

        /// <summary>
        ///     Gets or sets the error content (body json object)
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public ShareTemplateError ShareTemplateError { get; }
    }
}
