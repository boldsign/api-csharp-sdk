// <copyright file="BehalfOf.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The behalf of details.
    /// </summary>
    public class BehalfOf
    {
        /// <summary>
        ///     Gets or sets the behalf id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the on behalf of email.
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
