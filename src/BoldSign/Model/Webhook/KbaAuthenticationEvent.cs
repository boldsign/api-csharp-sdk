// <copyright file="KbaAuthenticationEvent.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model.Webhook
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The webhook KBA authentication event object.
    /// </summary>
    [DataContract]
    public class KbaAuthenticationEvent : IWebhookData
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
        /// Gets or sets the message title.
        /// </summary>
        /// <value>Gets the value of message title.</value>
        [DataMember(Name = "messageTitle", EmitDefaultValue = false)]
        [JsonProperty("messageTitle")]
        public string MessageTitle { get; set; }

        /// <summary>
        /// Gets or sets the document description.
        /// </summary>
        /// <value>Gets the value of document description.</value>
        [DataMember(Name = "documentDescription", EmitDefaultValue = false)]
        [JsonProperty("documentDescription")]
        public string DocumentDescription { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>Gets the value of status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty("status")]
        public DocumentStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the sender details.
        /// </summary>
        /// <value>Gets the value of sender details.</value>
        [DataMember(Name = "senderDetail", EmitDefaultValue = false)]
        [JsonProperty("senderDetail")]
        public DocumentSenderDetails SenderDetail { get; set; }

        /// <summary>
        /// Gets or sets the signer details.
        /// </summary>
        /// <value>Gets the value of signer details.</value>
        [DataMember(Name = "signerDetail", EmitDefaultValue = false)]
        [JsonProperty("signerDetail")]
        public SignerDetails SignerDetail { get; set; }
    }
}
