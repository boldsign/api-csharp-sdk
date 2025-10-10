// <copyright file="SenderIdentityRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The sender identity request.
    /// </summary>
    [DataContract]
    public class SenderIdentityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderIdentityRequest"/> class.
        /// </summary>
        /// <param name="name">Gets or sets name.</param>
        /// <param name="email">Gets or sets email.</param>
        /// <param name="notificationSettings">Gets or sets notification settings.</param>
        /// <param name="brandId">Gets or sets brand id.</param>
        /// <param name="redirectUrl">Gets or sets redirect url.</param>
        public SenderIdentityRequest(string name, string email, NotificationSettings notificationSettings, string brandId = null, Uri redirectUrl = null)
        {
            this.Name = name;
            this.Email = email;
            this.NotificationSettings = notificationSettings;
            this.BrandId = brandId;
            this.RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [Required]
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [Required]
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the notification settings.
        /// </summary>
        [DataMember(Name = "notificationSettings")]
        public NotificationSettings NotificationSettings { get; set; }

        /// <summary>
        /// Gets or sets the brand Id.
        /// </summary>
        [DataMember(Name = "brandId", EmitDefaultValue = true)]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the redirect URL.
        /// </summary>
        [DataMember(Name = "redirectUrl", EmitDefaultValue = true)]
        public Uri RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of metadata.
        /// </summary>
        [DataMember(Name = "metaData", EmitDefaultValue = true)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
