// <copyright file="WebhookActorDetails.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    ///  The webhook actor details.
    /// </summary>
    public class WebhookActorDetails
    {
        /// <summary>
        /// Gets or sets the user type.
        /// </summary>
        [DataMember(Name = "userType", EmitDefaultValue = false)]
        [JsonProperty("userType")]
        public string UserType { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
