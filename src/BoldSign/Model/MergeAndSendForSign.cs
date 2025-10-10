// <copyright file="MergeAndSendForSign.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    /// The merge and send for sign.
    /// </summary>
    [DataContract]
    public class MergeAndSendForSign : IDocumentUpload
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MergeAndSendForSign" /> class.
        /// </summary>
        /// <param name="templateIds">Gets or sets the template ids.</param>
        /// <param name="title">Gets or sets the title..</param>
        /// <param name="message">Gets or sets the message..</param>
        /// <param name="roles">Gets or sets the roles..</param>
        /// <param name="brandId">Gets or sets the brandId..</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="disableEmails">Gets or sets the disableEmails.</param>
        /// <param name="hideDocumentId">Gets or sets the hideDocumentId.</param>
        /// <param name="reminderSettings">Gets or sets the reminderSettings.</param>
        /// <param name="cc">Gets or sets the cc.</param>
        /// <param name="expiryDays">Gets or sets the expiryDays.</param>
        /// <param name="expiryValue">Gets or sets the expiry value based on expiry date type.</param>
        /// <param name="expiryDateType">Gets or sets the expiry date type.</param>
        /// <param name="disableExpiryAlert">Gets or sets the disableExpiryAlert.</param>
        /// <param name="enablePrintAndSign">Gets or sets the enablePrintAndSign.</param>
        /// <param name="enableReassign">Gets or sets the enableReassign.</param>
        /// <param name="enableSigningOrder">Gets or sets the enableSigningOrder.</param>
        /// <param name="documentInfo">Gets or sets the documentInfo.</param>
        /// <param name="onBehalfOf">Gets or sets the on behalf of email id.</param>
        /// <param name="roleRemovalIndices">Gets or sets the role removal indices.</param>
        public MergeAndSendForSign(
            string[] templateIds = default,
            string title = default,
            string message = default,
            List<Roles> roles = default,
            string brandId = default,
            List<string> labels = default,
            bool disableEmails = default,
            bool? hideDocumentId = default,
            ReminderSettings reminderSettings = default,
            IEnumerable<DocumentCC> cc = default,
            int expiryDays = default,
            long expiryValue = 60,
            ExpiryDateType? expiryDateType = default,
            bool disableExpiryAlert = default,
            bool enablePrintAndSign = default,
            bool enableReassign = true,
            bool? enableSigningOrder = default,
            IEnumerable<DocumentInfo> documentInfo = default,
            string onBehalfOf = default,
            int[] roleRemovalIndices = default)
        {
            this.TemplateIds = templateIds;
            this.Title = title;
            this.Message = message;
            this.Roles = roles;
            this.BrandId = brandId;
            this.Labels = labels;
            this.DisableEmails = disableEmails;
            this.HideDocumentId = hideDocumentId;
            this.ReminderSettings = reminderSettings;
            this.CC = cc;
            this.ExpiryDays = expiryDays;
            this.ExpiryValue = expiryValue;
            this.ExpiryDateType = expiryDateType;
            this.DisableExpiryAlert = disableExpiryAlert;
            this.EnablePrintAndSign = enablePrintAndSign;
            this.EnableReassign = enableReassign;
            this.EnableSigningOrder = enableSigningOrder;
            this.DocumentInfo = documentInfo;
            this.OnBehalfOf = onBehalfOf;
            this.RoleRemovalIndices = roleRemovalIndices;
        }

        /// <inheritdoc />
        [JsonIgnore]
        public List<IDocumentFile> Files { get; set; } = new List<IDocumentFile>();

        /// <inheritdoc />
        [JsonProperty("fileUrls")]
        public List<Uri> FileUrls { get; set; } = new List<Uri>();

        /// <summary>
        /// Gets or sets the template Ids.
        /// </summary>
        /// <value>Gets or sets the template ids.</value>
        [DataMember(Name = "templateIds", EmitDefaultValue = true)]
        public string[] TemplateIds { get; set; }

        /// <summary>
        ///     Gets or sets title for the signature request.
        /// </summary>
        /// <value>Gets or sets the title.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        ///     Gets or sets common message for all the document recipients.
        /// </summary>
        /// <value>Gets or sets the message.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the signer roles in a template of the document.
        /// </summary>
        /// <value>Gets or sets the roles.</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<Roles> Roles { get; set; }

        /// <summary>
        /// Gets or sets the brand id.
        /// </summary>
        [DataMember(Name = "brandId", EmitDefaultValue = true)]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = true)]
        public List<string> Labels { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether to enable or disable emails.When disable emails is set to true, all the status emails and completed document email will be stopped, and reminder is also automatically ignored.
        /// </summary>
        [DataMember(Name = "disableEmails", EmitDefaultValue = true)]
        public bool DisableEmails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to remove the document ID watermark from all the PDF pages of the document.
        /// Default is false.
        /// </summary>
        [DataMember(Name = "hideDocumentId", EmitDefaultValue = true)]
        public bool? HideDocumentId { get; set; }

        /// <summary>
        /// Gets or sets the reminder settings for the signature request.
        /// </summary>
        [DataMember(Name = "reminderSettings", EmitDefaultValue = true)]
        public ReminderSettings ReminderSettings { get; set; }

        /// <summary>
        ///     Gets or sets document CC details.
        /// </summary>
        [DataMember(Name = "cc", EmitDefaultValue = true)]
        public IEnumerable<DocumentCC> CC { get; set; }

        /// <summary>
        /// Gets or sets the expiry date type.
        /// </summary>
        [DataMember(Name = "expiryDateType", EmitDefaultValue = false)]
        public ExpiryDateType? ExpiryDateType { get; set; }

        /// <summary>
        ///  Gets or sets number of days after which the document will expire.
        /// </summary>
        [DataMember(Name = "expiryDays", EmitDefaultValue = true)]
        public int ExpiryDays { get; set; }

        /// <summary>
        ///  Gets or sets the value when the document should get expired.
        /// </summary>
        [DataMember(Name = "expiryValue", EmitDefaultValue = false)]
        public long ExpiryValue { get; set; } = 60;

        /// <summary>
        ///  Gets or sets a value indicating whether Disableexpiryalert is true or false.
        ///  This property will send the expiry alert email before the day of expiry for the pending signers.
        ///  If the document expires in one day, the email will be sent before 2 hours of the expiry.
        /// </summary>
        [DataMember(Name = "disableExpiryAlert", EmitDefaultValue = true)]
        public bool DisableExpiryAlert { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether to enable print and sign mode.
        /// </summary>
        [DataMember(Name = "enablePrintAndSign", EmitDefaultValue = true)]
        public bool EnablePrintAndSign { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether to enable reassign mode.
        ///  By Default True.
        /// </summary>
        [DataMember(Name = "enableReassign", EmitDefaultValue = true)]
        public bool EnableReassign { get; set; } = true;

        /// <summary>
        ///     Gets or sets a value indicating whether to enable signing order for the document signer.
        /// </summary>
        [DataMember(Name = "enableSigningOrder", EmitDefaultValue = true)]
        public bool? EnableSigningOrder { get; set; }

        /// <summary>
        /// Gets or sets a documentInfo.
        /// </summary>
        [JsonProperty("documentInfo")]
        public IEnumerable<DocumentInfo> DocumentInfo { get; set; }

        /// <summary>
        /// Gets or sets the on behalf of mail id.
        /// </summary>
        [DataMember(Name = "onBehalfOf", EmitDefaultValue = true)]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Gets or sets the role removal indices which starts from 1. For example, if you want to remove role 2 and 3 the input should be new []{2,3}.
        /// </summary>
        [DataMember(Name = "roleRemovalIndices", EmitDefaultValue = false)]
        public int[] RoleRemovalIndices { get; set; }

        /// <summary>
        /// Gets or sets a value to customize how the documents are downloaded.
        /// </summary>
        [DataMember(Name = "documentDownloadOption", EmitDefaultValue = true)]
        public DocumentDownloadOption? DocumentDownloadOption { get; set; }

        /// <summary>
        /// Gets or sets the metadata of the document.
        /// </summary>
        [DataMember(Name = "metaData", EmitDefaultValue = true)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// Gets or sets form group values for grouped form fields.
        /// </summary>
        [DataMember(Name = "formGroups", EmitDefaultValue = false)]
        public List<FormGroup> FormGroups { get; set; }

        /// <summary>
        /// Gets or sets remove form fields id.
        /// </summary>
        [DataMember(Name = "removeFormFields", EmitDefaultValue = false)]
        public List<string> RemoveFormFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable a localization support for audit trail.
        /// </summary>
        [DataMember(Name = "enableAuditTrailLocalization", EmitDefaultValue = false)]
        public bool? EnableAuditTrailLocalization { get; set; }

        /// <summary>
        /// Gets or sets the download file name.
        /// </summary>
        [DataMember(Name = "downloadFileName", EmitDefaultValue = true)]
        public string DownloadFileName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to convert the text tags to form fields.
        /// </summary>
        [DataMember(Name = "useTextTags", EmitDefaultValue = false)]
        public bool UseTextTags { get; set; }

        /// <summary>
        /// Gets or sets the text tags definitions declared in the list can be used in the document by using the definition ID.
        /// </summary>
        [DataMember(Name = "textTagDefinitions", EmitDefaultValue = false)]
        public List<TextTagDefinition> TextTagDefinitions { get; set; }

        /// <summary>
        /// Gets or sets the document scheduled date value.
        /// </summary>
        [DataMember(Name = "scheduledSendTime", EmitDefaultValue = false)]
        public long? ScheduledSendTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show send later option in embedded page.
        /// </summary>
        [DataMember(Name = "AllowScheduledSend", EmitDefaultValue = false)]
        public bool AllowScheduledSend { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
