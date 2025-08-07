// <copyright file="IdentityVerificationEvent.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model.Webhook
{
    using System.Runtime.Serialization;
    using BoldSign.Model.IdVerification;
    using Newtonsoft.Json;

    /// <summary>
    /// The webhook identity verification event object.
    /// </summary>
    [DataContract]
    public class IdentityVerificationEvent : IWebhookData
    {
        /// <inheritdoc />
        [JsonProperty("object")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the document id.
        /// </summary>
        /// <value>Gets the value of document id.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the messageTitle.
        /// </summary>
        /// <value>Gets the value of messageTitle.</value>
        [DataMember(Name = "messageTitle", EmitDefaultValue = false)]
        [JsonProperty("messageTitle")]
        public string MessageTitle { get; set; }

        /// <summary>
        /// Gets or sets document description.
        /// </summary>
        /// <value>Gets the value of document description.</value>
        [DataMember(Name = "documentDescription", EmitDefaultValue = false)]
        [JsonProperty("documentDescription")]
        public string DocumentDescription { get; set; }

        /// <summary>
        /// Gets or Sets Status.
        /// </summary>
        /// <value>Gets the value of Status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty("status")]
        public DocumentStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets SenderDetail.
        /// </summary>
        /// <value>Gets the value of SenderDetail.</value>
        [DataMember(Name = "senderDetail", EmitDefaultValue = false)]
        [JsonProperty("senderDetail")]
        public DocumentSenderDetails SenderDetail { get; set; }

        /// <summary>
        /// Gets or sets the signerDetails.
        /// </summary>
        /// <value>Gets the value of signerDetail.</value>
        [DataMember(Name = "signerDetail", EmitDefaultValue = false)]
        [JsonProperty("signerDetail")]
        public SignerDetails SignerDetail { get; set; }
    }
}
