// <copyright file="RecipientNotificationSettings.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The Recipient Notification Settings.
    /// </summary>
    [DataContract]
    public class RecipientNotificationSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether document SignatureRequest.
        /// </summary>
        [DataMember(Name = "signatureRequest", EmitDefaultValue = true)]
        public bool SignatureRequest { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether decline document.
        /// </summary>
        [DataMember(Name = "declined", EmitDefaultValue = true)]
        public bool Declined { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether revoke document.
        /// </summary>
        [DataMember(Name = "revoked", EmitDefaultValue = true)]
        public bool Revoked { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether document Individual Sign Complete.
        /// </summary>
        [DataMember(Name = "signed", EmitDefaultValue = true)]
#pragma warning disable CA1720 // Identifier contains type name
        public bool Signed { get; set; } = true;
#pragma warning restore CA1720 // Identifier contains type name

        /// <summary>
        /// Gets or sets a value indicating whether complete document.
        /// </summary>
        [DataMember(Name = "completed", EmitDefaultValue = true)]
        public bool Completed { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether document expired.
        /// </summary>
        [DataMember(Name = "expired", EmitDefaultValue = true)]
        public bool Expired { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether reassign document.
        /// </summary>
        [DataMember(Name = "reassigned", EmitDefaultValue = true)]
        public bool Reassigned { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether deleted document.
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether sender reminder.
        /// </summary>
        [DataMember(Name = "reminders", EmitDefaultValue = true)]
        public bool Reminders { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether sender edited a recipient.
        /// </summary>
        [DataMember(Name = "editRecipient", EmitDefaultValue = true)]
        public bool EditRecipient { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether sender edited a document.
        /// </summary>
        [DataMember(Name = "editDocument", EmitDefaultValue = true)]
        public bool EditDocument { get; set; } = true;
    }
}
