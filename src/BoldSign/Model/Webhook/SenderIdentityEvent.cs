// <copyright file="SenderIdentityEvent.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model.Webhook
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The webhook sender identity event object.
    /// </summary>
    public class SenderIdentityEvent : IWebhookData
    {
        /// <inheritdoc />
        [JsonProperty("object")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// <para>Gets or sets the status of authorized sender.</para>
        /// <para>One of Pending, Verified, Denied, Revoked.</para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        [JsonProperty("createdDate")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        [JsonProperty("modifiedDate")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the link approved date.
        /// </summary>
        [JsonProperty("approvedDateTime")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// Gets or sets the brand id.
        /// </summary>
        [JsonProperty("brandId")]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the RedirectUrl.
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of metadata.
        /// </summary>
        [JsonProperty("metaData")]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// Gets or sets the creator data.
        /// </summary>
        [JsonProperty("createdBy")]
        public SenderIdentityCreator CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}
