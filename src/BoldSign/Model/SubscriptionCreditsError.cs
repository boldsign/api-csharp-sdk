// <copyright file="SubscriptionCreditsError.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    ///     The error returned when a subscription credits request is refused.
    /// </summary>
    [DataContract]
    public class SubscriptionCreditsError
    {
        /// <summary>
        ///     Gets or sets the type of the error. The known values are in <see cref="SubscriptionCreditsErrorType" />; more may be added later.
        /// </summary>
        [DataMember(Name = "errorType", EmitDefaultValue = false)]
        public string ErrorType { get; set; }

        /// <summary>
        ///     Gets or sets the error message.
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }
    }
}
