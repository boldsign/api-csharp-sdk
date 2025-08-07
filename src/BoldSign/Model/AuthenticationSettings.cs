// <copyright file="AuthenticationSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>
namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Authentication settings.
    /// </summary>
    public class AuthenticationSettings
    {
        /// <summary>
        /// Gets or sets the id verification type.
        /// </summary>
        [DataMember(Name = "authenticationFrequency", EmitDefaultValue = false)]

        public AuthenticationFrequency? AuthenticationFrequency { get; set; }
    }
}
