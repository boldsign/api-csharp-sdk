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
    using BoldSign.Api.Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///    The document properties includes any activity taken on the document, the user who acts on it, date of action, description of document, and so on.
    /// </summary>
    [DataContract]
    public class DocumentProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProperties" /> class.
        /// </summary>
        /// <param name="documentId">Gets or sets the document id..</param>
        /// <param name="messageTitle">Gets or sets the messageTitle..</param>
        /// <param name="documentDescription">Gets or Sets document description..</param>
        /// <param name="status">status.</param>
        /// <param name="files">Gets or Sets document uploaded file information..</param>
        /// <param name="senderDetail">senderDetail.</param>
        /// <param name="signerDetails">Gets or sets the signerDetails..</param>
        /// <param name="commonFields">Gets or sets the common fields.</param>
        /// <param name="ccDetails">Gets or sets the CC details..</param>
        /// <param name="reminderSettings">reminderSettings.</param>
        /// <param name="reassign">&lt;br&gt;Gets or Sets Reassign message.  &lt;br&gt;Available only when at least one of the signer have reassigned to another signer..</param>
        /// <param name="documentHistory">Gets or Sets document history (Audit log)..</param>
        /// <param name="activityBy">Gets or sets the activityBy..</param>
        /// <param name="activityDate">Gets or sets the activityDate..</param>
        /// <param name="activityAction">activityAction.</param>
        /// <param name="createdDate">Gets or sets the createdDate..</param>
        /// <param name="expiryDays">Gets or Sets expiry days of the document..</param>
        /// <param name="expiryDate">Gets or sets the expiry date of the document..</param>
        /// <param name="enableSigningOrder">Gets or sets a value indicating whether to enable signing order..</param>
        /// <param name="isDeleted">Gets or sets a value indicating whether the document is deleted..</param>
        /// <param name="revokeMessage">&lt;br&gt;Gets or Sets document revoked message by the sender.  &lt;br&gt;Available only when the document is revoked..</param>
        /// <param name="declineMessage">&lt;br&gt;Gets or Sets document declined message by the signer.  &lt;br&gt;Available only when any one of the signer have declined the document..</param>
        /// <param name="disableExpiryAlert">Gets or sets a value indicating whether Disableexpiryalert is true or false.</param>
        /// <param name="enablePrintAndSign">Gets or sets a value indicating whether to Enable Print And Sign.</param>
        /// <param name="enableReassign">Gets or sets a value indicating whether to Enable Reassign.By Default True.</param>
        /// <param name="hideDocumentId">Gets or sets a value indicating whether HideDocumentId is true or false.</param>
        /// <param name="behalfOf">Gets or sets the behalf details.</param>
        /// <param name="expiryDateType">Gets or sets the expiry data type of the document..</param>
        /// <param name="expiryValue">Gets or sets the expiry value of the document..</param>
        /// <param name="documentDownloadOption">Gets or sets the document download option.</param>
        public DocumentProperties(
            string documentId = default(string),
            string messageTitle = default(string),
            string documentDescription = default(string),
            DocumentStatus status = default(DocumentStatus),
            List<DocumentFiles> files = default(List<DocumentFiles>),
            DocumentSenderDetail senderDetail = default(DocumentSenderDetail),
            List<DocumentSignerDetails> signerDetails = default(List<DocumentSignerDetails>),
            List<DocumentFormFields> commonFields = default(List<DocumentFormFields>),
            List<DocumentCcDetails> ccDetails = default(List<DocumentCcDetails>),
            ReminderSettings reminderSettings = default(ReminderSettings),
            List<DocumentReassign> reassign = default(List<DocumentReassign>),
            List<AuditTrail> documentHistory = default(List<AuditTrail>),
            string activityBy = default(string),
            long? activityDate = default(long?),
            ActivityAction activityAction = default(ActivityAction),
            long? createdDate = default(long?),
            int? expiryDays = default(int?),
            long? expiryDate = default(long?),
            bool? enableSigningOrder = default(bool?),
            bool? isDeleted = default(bool?),
            string revokeMessage = default(string),
            string declineMessage = default(string),
            string brandId = default(string),
            List<string> labels = default,
            string applicationId = default(string),
            bool disableExpiryAlert = default(bool),
            bool? hideDocumentId = default,
            bool enablePrintAndSign = default(bool),
            bool enableReassign = default(bool),
            BehalfOf behalfOf = default(BehalfOf),
            ExpiryDateType expiryDateType = default(ExpiryDateType),
            long? expiryValue = default(long?),
            DocumentDownloadOption documentDownloadOption = default(DocumentDownloadOption))
        {
            this.DocumentId = documentId;
            this.MessageTitle = messageTitle;
            this.DocumentDescription = documentDescription;
            this.Status = status;
            this.Files = files;
            this.SenderDetail = senderDetail;
            this.SignerDetails = signerDetails;
            this.CommonFields = commonFields;
            this.CcDetails = ccDetails;
            this.ReminderSettings = reminderSettings;
            this.Reassign = reassign;
            this.DocumentHistory = documentHistory;
            this.ActivityBy = activityBy;
            this.ActivityDate = activityDate;
            this.ActivityAction = activityAction;
            this.CreatedDate = createdDate;
            this.ExpiryDays = expiryDays;
            this.ExpiryDate = expiryDate;
            this.EnableSigningOrder = enableSigningOrder;
            this.IsDeleted = isDeleted;
            this.RevokeMessage = revokeMessage;
            this.DeclineMessage = declineMessage;
            this.BrandId = brandId;
            this.ApplicationId = applicationId;
            this.Labels = labels;
            this.DisableExpiryAlert = disableExpiryAlert;
            this.EnablePrintAndSign = enablePrintAndSign;
            this.EnableReassign = enableReassign;
            this.HideDocumentId = hideDocumentId;
            this.BehalfOf = behalfOf;
            this.ExpiryDateType = expiryDateType;
            this.ExpiryValue = expiryValue;
            this.DocumentDownloadOption = documentDownloadOption;
        }

        /// <summary>
        /// Gets or sets the document ID.
        /// </summary>
        /// <value>Gets or sets the document id.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the message title.
        /// </summary>
        /// <value>Gets or sets the messageTitle.</value>
        [DataMember(Name = "messageTitle", EmitDefaultValue = false)]
        public string MessageTitle { get; set; }

        /// <summary>
        /// Gets or sets document description.
        /// </summary>
        /// <value>Gets or Sets document description.</value>
        [DataMember(Name = "documentDescription", EmitDefaultValue = false)]
        public string DocumentDescription { get; set; }

        /// <summary>
        /// Gets or sets the document status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DocumentStatus Status { get; set; }

        /// <summary>
        /// Gets or sets document uploaded file information.
        /// </summary>
        /// <value>Gets or Sets document uploaded file information.</value>
        [DataMember(Name = "files", EmitDefaultValue = false)]
        public List<DocumentFiles> Files { get; set; }

        /// <summary>
        /// Gets or sets Sender detail.
        /// </summary>
        [DataMember(Name = "senderDetail", EmitDefaultValue = false)]
        public DocumentSenderDetail SenderDetail { get; set; }

        /// <summary>
        /// Gets or sets the signer details.
        /// </summary>
        /// <value>Gets or sets the signerDetails.</value>
        [DataMember(Name = "signerDetails", EmitDefaultValue = false)]
        public List<DocumentSignerDetails> SignerDetails { get; set; }

        /// <summary>
        /// Gets or sets the common fields in the document.
        /// </summary>
        /// <value>Gets or sets the common fields.</value>
        [DataMember(Name = "commonFields", EmitDefaultValue = false)]
        public List<DocumentFormFields> CommonFields { get; set; }

        /// <summary>
        ///     Gets or sets the behalf detail.
        /// </summary>
        [DataMember(Name = "behalfOf", EmitDefaultValue = false)]
        public BehalfOf BehalfOf { get; set; }

        /// <summary>
        /// Gets or sets the CC details.
        /// </summary>
        /// <value>Gets or sets the CC details.</value>
        [DataMember(Name = "ccDetails", EmitDefaultValue = false)]
        public List<DocumentCcDetails> CcDetails { get; set; }

        /// <summary>
        /// Gets or sets reminder settings.
        /// </summary>
        [DataMember(Name = "reminderSettings", EmitDefaultValue = false)]
        public ReminderSettings ReminderSettings { get; set; }

        /// <summary>
        /// &lt;br&gt;Gets or sets reassign message.  &lt;br&gt;Available only when at least one of the signers have reassigned to another signer.
        /// </summary>
        /// <value>&lt;br&gt;Gets or Sets Reassign message.  &lt;br&gt;Available only when at least one of the signers have reassigned to another signer.</value>
        [DataMember(Name = "reassign", EmitDefaultValue = false)]
        public List<DocumentReassign> Reassign { get; set; }

        /// <summary>
        /// Gets or sets document history (Audit log) for a document.
        /// </summary>
        /// <value>Gets or Sets document history (Audit log).</value>
        [DataMember(Name = "documentHistory", EmitDefaultValue = false)]
        public List<AuditTrail> DocumentHistory { get; set; }

        /// <summary>
        /// Gets or sets the name of the user who performed action.
        /// </summary>
        /// <value>Gets or sets the activityBy.</value>
        [DataMember(Name = "activityBy", EmitDefaultValue = false)]
        public string ActivityBy { get; set; }

        /// <summary>
        /// Gets or sets the activity date.
        /// </summary>
        /// <value>Gets or sets the activityDate.</value>
        [DataMember(Name = "activityDate", EmitDefaultValue = false)]
        public long? ActivityDate { get; set; }

        /// <summary>
        /// Gets or sets activity action done on the document.
        /// </summary>
        [DataMember(Name = "activityAction", EmitDefaultValue = false)]
        public ActivityAction ActivityAction { get; set; }

        /// <summary>
        /// Gets or sets the created date of a document.
        /// </summary>
        /// <value>Gets or sets the createdDate.</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets expiry days for the document.
        /// </summary>
        /// <value>Gets or Sets expiry days of the document.</value>
        [DataMember(Name = "expiryDays", EmitDefaultValue = false)]
        public int? ExpiryDays { get; set; }

        /// <summary>
        /// Gets or sets the expiry date of the document.
        /// </summary>
        /// <value>Gets or sets the expiry date of the document.</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public long? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether signing order is enabled.
        /// </summary>
        /// <value>Gets or sets a value indicating whether to enable signing order.</value>
        [DataMember(Name = "enableSigningOrder", EmitDefaultValue = false)]
        public bool? EnableSigningOrder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the document is deleted.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the document is deleted.</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// &lt;br&gt;Gets or Sets document revoked message by the sender.  &lt;br&gt;Available only when the document is revoked.
        /// </summary>
        /// <value>&lt;br&gt;Gets or Sets document revoked message by the sender.  &lt;br&gt;Available only when the document is revoked.</value>
        [DataMember(Name = "revokeMessage", EmitDefaultValue = false)]
        public string RevokeMessage { get; set; }

        /// <summary>
        /// &lt;br&gt;Gets or Sets document declined message by the signer.  &lt;br&gt;Available only when any one of the signers have declined the document.
        /// </summary>
        /// <value>&lt;br&gt;Gets or Sets document declined message by the signer.  &lt;br&gt;Available only when any one of the signers have declined the document.</value>
        [DataMember(Name = "declineMessage", EmitDefaultValue = false)]
        public string DeclineMessage { get; set; }

        /// <summary>
        /// Gets or sets the Brand Id.
        /// </summary>
        /// <value>Gets or sets the brand id.</value>
        [DataMember(Name = "brandId", EmitDefaultValue = false)]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>Gets or sets the labels.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets a GUID value that used to identify the application client ID.
        /// </summary>
        /// <value>Gets or sets a GUID value that used to identify the application client ID.</value>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the disableEmails.
        /// </summary>
        /// <value>When DisableEmails is enabled, Reminder is automatically ignored</value>
        [DataMember(Name = "disableEmails", EmitDefaultValue = false)]
        public bool DisableEmails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Disableexpiryalert is true or false.
        /// </summary>
        /// <value>This property will send the expiry alert email before the day of expiry for the pending signers.If the document expires in one day, the email will be sent before 2 hours of the expiry.</value>
        [DataMember(Name = "disableExpiryAlert ", EmitDefaultValue = false)]
        public bool DisableExpiryAlert { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether print and sign is enabled.
        /// </summary>
        /// <value>Gets or sets a value of indicating whether to enable print and sign mode.</value>
        [DataMember(Name = "enablePrintAndSign", EmitDefaultValue = false)]
        public bool EnablePrintAndSign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether reassign is enabled.
        /// </summary>
        /// <value>Gets or sets a value of indicating whether to enable reassign mode.By Default True.</value>
        [DataMember(Name = "enableReassign", EmitDefaultValue = false)]
        public bool EnableReassign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether HideDocumentId is true or false.
        /// </summary>
        /// <value>When HideDocumentId is enabled , the document Id in the documents is not visible.</value>
        [DataMember(Name = "hideDocumentId ", EmitDefaultValue = false)]
        public bool? HideDocumentId { get; set; }

        /// <summary>
        /// Gets or sets the expiry date type.
        /// </summary>
        [DataMember(Name = "expiryDateType", EmitDefaultValue = false)]
        public ExpiryDateType ExpiryDateType { get; set; }

        /// <summary>
        /// Gets or sets the expiry value of the document.
        /// </summary>
        /// <value>Gets the value of expiry value of the document.</value>
        [DataMember(Name = "expiryValue", EmitDefaultValue = false)]
        public long? ExpiryValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable individual document downloads.
        /// </summary>
        [DataMember(Name = "documentDownloadOption", EmitDefaultValue = true)]
        public DocumentDownloadOption DocumentDownloadOption { get; set; }

        /// <summary>
        /// Gets or sets the Recipient Notification Settings.
        /// </summary>
        /// <value>Gets or sets the Recipient Notification Settings of the signer.</value>
        [DataMember(Name = "recipientNotificationSettings", EmitDefaultValue = false)]
        public RecipientNotificationSettings RecipientNotificationSettings { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
