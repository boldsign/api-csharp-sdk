// <copyright file="SenderIdentityRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
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
        public SenderIdentityRequest(string name, string email, NotificationSettings notificationSettings)
        {
            this.Name = name;
            this.Email = email;
            this.NotificationSettings = notificationSettings;
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
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
