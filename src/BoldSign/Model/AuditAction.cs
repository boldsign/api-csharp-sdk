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
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Defines AuditAction to be recorded in audit trail.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditAction
    {
        /// <summary>
        ///     Enum Sent for value: Sent
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent = 1,

        /// <summary>
        ///     Enum Viewed for value: Viewed
        /// </summary>
        [EnumMember(Value = "Viewed")]
        Viewed = 2,

        /// <summary>
        ///     Enum Signed for value: Signed
        /// </summary>
        [EnumMember(Value = "Signed")]
        Signed = 3,

        /// <summary>
        ///     Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 4,

        /// <summary>
        ///     Enum Downloaded for value: Downloaded
        /// </summary>
        [EnumMember(Value = "Downloaded")]
        Downloaded = 5,

        /// <summary>
        ///     Enum Reassigned for value: Reassigned
        /// </summary>
        [EnumMember(Value = "Reassigned")]
        Reassigned = 6,

        /// <summary>
        ///     Enum Declined for value: Declined
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined = 7,

        /// <summary>
        ///     Enum Recalled for value: Recalled
        /// </summary>
        [EnumMember(Value = "Recalled")]
        Recalled = 8,

        /// <summary>
        ///     Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")]
        Created = 9,

        /// <summary>
        ///     Enum AuthenticationFailed for value: AuthenticationFailed
        /// </summary>
        [EnumMember(Value = "AuthenticationFailed")]
        AuthenticationFailed = 10,

        /// <summary>
        ///     Enum Reminder for value: Reminder
        /// </summary>
        [EnumMember(Value = "Reminder")]
        Reminder = 11,

        /// <summary>
        ///     Enum AccessCodeChanged for value: AccessCodeChanged
        /// </summary>
        [EnumMember(Value = "AccessCodeChanged")]
        AccessCodeChanged = 12,

        /// <summary>
        ///     Enum AccessCodeViewed for value: AccessCodeViewed
        /// </summary>
        [EnumMember(Value = "AccessCodeViewed")]
        AccessCodeViewed = 13,

        /// <summary>
        ///     Enum DownloadedForPrintSign for value: DownloadedForPrintSign
        /// </summary>
        [EnumMember(Value = "DownloadedForPrintSign")]
        DownloadedForPrintSign = 14,

        /// <summary>
        ///     Enum FormCreated for value: FormCreated
        /// </summary>
        [EnumMember(Value = "FormCreated")]
        FormCreated = 15,

        /// <summary>
        ///     Enum EmailOTP for value: EmailOTP
        /// </summary>
        [EnumMember(Value = "EmailOTP")]
        EmailOTP = 16,

        /// <summary>
        ///     Enum AuthenticationRemoved for value: AuthenticationRemoved
        /// </summary>
        [EnumMember(Value = "AuthenticationRemoved")]
        AuthenticationRemoved = 17,

        /// <summary>
        /// Enum DownloadedAuditTrail for value: DownloadedAuditTrail.
        /// </summary>
        [EnumMember(Value = "DownloadedAuditTrail")]
        DownloadedAuditTrail = 18,

        /// <summary>
        /// Enum Cloned for value: Cloned.
        /// </summary>
        [EnumMember(Value = "Cloned")]
        Cloned = 19,

        /// <summary>
        /// Enum Deleted for value: Deleted.
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted = 20,

        /// <summary>
        /// Enum MovedToTrash for value: MovedToTrash.
        /// </summary>
        [EnumMember(Value = "MovedToTrash")]
        MovedToTrash = 21,

        /// <summary>
        /// Enum Restored for value: Restored.
        /// </summary>
        [EnumMember(Value = "Restored")]
        Restored = 22,

        /// <summary>
        /// Enum AutoReminder for value: AutoReminder.
        /// </summary>
        [EnumMember(Value = "AutoReminder")]
        AutoReminder = 23,

        /// <summary>
        /// Enum Resend for value: Resend.
        /// </summary>
        [EnumMember(Value = "Resend")]
        Resend = 24,

        /// <summary>
        /// Enum Reviewed for value: Reviewed.
        /// </summary>
        [EnumMember(Value = "Reviewed")]
        Reviewed = 25,

        /// <summary>
        /// Enum InitiatePrintSign for value: InitiatePrintSign.
        /// </summary>
        [EnumMember(Value = "InitiatePrintSign")]
        InitiatePrintSign = 26,

        /// <summary>
        /// Enum CancelPrintSign for value: CancelPrintSign.
        /// </summary>
        [EnumMember(Value = "CancelPrintSign")]
        CancelPrintSign = 27,

        /// <summary>
        /// Enum CompletePrintSign for value: CompletePrintSign.
        /// </summary>
        [EnumMember(Value = "CompletePrintSign")]
        CompletePrintSign = 28,

        /// <summary>
        /// Enum Generated embedded sign link for value:Generated embedded sign link.
        /// </summary>
        [EnumMember(Value = "GeneratedEmbeddedSignLink")]
        GeneratedEmbeddedSignLink = 29,

        /// <summary>
        ///  Enum Embedded signed for value: Embedded signed.
        /// </summary>
        [EnumMember(Value = "EmbeddedSigned")]
        EmbeddedSigned = 30,

        /// <summary>
        ///  Enum Embedded reviewed for value: Embedded reviewed.
        /// </summary>
        [EnumMember(Value = "EmbeddedReviewed")]
        EmbeddedReviewed = 31,

        /// <summary>
        /// Enum ExpiryDateExtended for value: ExpiryDateExtended.
        /// </summary>
        [EnumMember(Value = "ExpiryDateExtended")]
        ExpiryDateExtended = 32,

        /// <summary>
        /// Enum EditRecipient for value: EditRecipient
        /// </summary>
        [EnumMember(Value = "EditRecipient")]
        EditRecipient = 33,

        /// <summary>
        ///     Enum AuthenticationAdded for value: AuthenticationAdded
        /// </summary>
        [EnumMember(Value = "AuthenticationAdded")]
        AuthenticationAdded = 34,

        /// <summary>
        ///     Enum Attachment for value: Attachment
        /// </summary>
        [EnumMember(Value = "Attachment")]
        Attachment = 35,
    }
}
