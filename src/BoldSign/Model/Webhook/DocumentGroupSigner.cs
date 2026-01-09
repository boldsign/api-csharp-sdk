// <copyright file="DocumentGroupSigner.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

using System;
using System.Runtime.Serialization;
using BoldSign.Model;
using Newtonsoft.Json;

namespace BoldSign.Api.Model.Webhook
{
    /// <summary>
    /// The Document group signer webhook model.
    /// </summary>
    public class DocumentGroupSigner
    {
        /// <summary>
        /// Gets the id of the signer.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets the signer email.
        /// </summary>
        [DataMember(Name = "signerEmail", EmitDefaultValue = false)]
        [JsonProperty("signerEmail")]
        public string SignerEmail { get; set; }

        /// <summary>
        /// Gets the signer name.
        /// </summary>
        [DataMember(Name = "signerName", EmitDefaultValue = false)]
        [JsonProperty("signerName")]
        public string SignerName { get; set; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty("status")]
        public SignerStatus Status { get; set; }

        /// <summary>
        /// Gets a value indicating whether is viewed.
        /// </summary>
        [DataMember(Name = "isViewed", EmitDefaultValue = false)]
        [JsonProperty("isViewed")]
        public bool IsViewed { get; set; }

        /// <summary>
        /// Gets a value indicating whether delivery is failed.
        /// </summary>
        [DataMember(Name = "isDeliveryFailed", EmitDefaultValue = false)]
        [JsonProperty("isDeliveryFailed")]
        public bool IsDeliveryFailed { get; set; }

        /// <summary>
        ///     <para>Gets a value indicating whether authentication is failed.</para>
        /// </summary>
        [DataMember(Name = "isAuthenticationFailed", EmitDefaultValue = false)]
        [JsonProperty("isAuthenticationFailed")]
        public bool? IsAuthenticationFailed { get; set; }

        /// <summary>
        /// Gets or sets the last reminder sent on date time.
        /// </summary>
        /// <value>Gets or sets a value indicating whether gets or sets the Last reminder sent time.</value>
        [DataMember(Name = "lastReminderSentOn", EmitDefaultValue = false)]
        [JsonProperty("lastReminderSentOn")]
        public long? LastReminderSentOn { get; set; }
    }
}
