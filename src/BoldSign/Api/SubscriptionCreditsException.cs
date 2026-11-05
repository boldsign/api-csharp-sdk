// <copyright file="SubscriptionCreditsException.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using BoldSign.Model;

    /// <summary>
    ///     The exception thrown when a subscription credits request is refused with a typed error.
    ///     It is an <see cref="ApiException" /> with the same error code, message and error content, plus the parsed error.
    /// </summary>
    public class SubscriptionCreditsException : ApiException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SubscriptionCreditsException" /> class.
        /// </summary>
        public SubscriptionCreditsException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SubscriptionCreditsException" /> class.
        /// </summary>
        /// <param name="errorCode">The HTTP status code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="errorContent">The HTTP response body.</param>
        /// <param name="error">The parsed error.</param>
        public SubscriptionCreditsException(int errorCode, string message, string errorContent, SubscriptionCreditsError error)
            : base(errorCode, message, errorContent)
        {
            this.SubscriptionCreditsError = error;
        }

        /// <summary>
        ///     Gets the parsed error, with its error type and message.
        /// </summary>
        public SubscriptionCreditsError SubscriptionCreditsError { get; }
    }
}
