/*
 * BoldSign API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace BoldSign.Model.Webhook
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines WebHookEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebHookEventType
    {
        /// <summary>
        /// Enum Sent for value: Sent
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent = 1,
        /// <summary>
        /// Enum Signed for value: Signed
        /// </summary>
        [EnumMember(Value = "Signed")]
        Signed = 2,
        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 3,
        /// <summary>
        /// Enum Declined for value: Declined
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined = 4,
        /// <summary>
        /// Enum Revoked for value: Revoked
        /// </summary>
        [EnumMember(Value = "Revoked")]
        Revoked = 5,
        /// <summary>
        /// Enum Reassigned for value: Reassigned
        /// </summary>
        [EnumMember(Value = "Reassigned")]
        Reassigned = 6,
        /// <summary>
        /// Enum Expired for value: Expired
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired = 7,
        /// <summary>
        /// Enum Viewed for value: Viewed
        /// </summary>
        [EnumMember(Value = "Viewed")]
        Viewed = 8,
        /// <summary>
        /// Enum AuthenticationFailed for value: AuthenticationFailed
        /// </summary>
        [EnumMember(Value = "AuthenticationFailed")]
        AuthenticationFailed = 9,
        /// <summary>
        /// Enum DeliveryFailed for value: DeliveryFailed
        /// </summary>
        [EnumMember(Value = "DeliveryFailed")]
        DeliveryFailed = 10,
        /// <summary>
        /// Enum Verification for value: Verification
        /// </summary>
        [EnumMember(Value = "Verification")]
        Verification = 11,

        /// <summary>
        /// Enum SendFailed for value: SendFailed
        /// </summary>
        [EnumMember(Value = "SendFailed")]
        SendFailed = 12,

        /// <summary>
        /// Sender identity created event
        /// </summary>
        [EnumMember(Value = "SenderIdentityCreated")]
        SenderIdentityCreated = 13,

        /// <summary>
        /// Sender identity updated event
        /// </summary>
        [EnumMember(Value = "SenderIdentityUpdated")]
        SenderIdentityUpdated = 14,

        /// <summary>
        /// Sender identity deleted event
        /// </summary>
        [EnumMember(Value = "SenderIdentityDeleted")]
        SenderIdentityDeleted = 15,

        /// <summary>
        /// Sender identity revoked event
        /// </summary>
        [EnumMember(Value = "SenderIdentityRevoked")]
        SenderIdentityRevoked = 16,

        /// <summary>
        /// Sender identity verified event
        /// </summary>
        [EnumMember(Value = "SenderIdentityVerified")]
        SenderIdentityVerified = 17,

        /// <summary>
        /// Sender identity denied event
        /// </summary>
        [EnumMember(Value = "SenderIdentityDenied")]
        SenderIdentityDenied = 18,

        /// <summary>
        /// Template created event.
        /// </summary>
        [EnumMember(Value = "TemplateCreated")]
        TemplateCreated = 19,
        /// <summary>
        /// Create template failed event.
        /// </summary>
        [EnumMember(Value = "TemplateCreateFailed")]
        TemplateCreateFailed = 20,

        /// <summary>
        /// Template draft created event.
        /// </summary>
        [EnumMember(Value = "TemplateDraftCreated")]
        TemplateDraftCreated = 21,

        /// <summary>
        /// Draft created event
        /// </summary>
        [EnumMember(Value = "DraftCreated")]
        DraftCreated = 22,
    }
}
