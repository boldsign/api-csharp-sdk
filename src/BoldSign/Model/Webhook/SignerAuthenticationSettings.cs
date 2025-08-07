// <copyright file="SignerAuthenticationSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model.Webhook
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The id verification.
    /// </summary>
    public class SignerAuthenticationSettings
    {
        /// <summary>
        /// Gets or sets the type of authentication.
        /// </summary>
        [DataMember(Name = "authenticationFrequency", EmitDefaultValue = false)]
        public string AuthenticationFrequency { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }
    }
}
