// <copyright file="TemplateEvent.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Webhook.Template
{
    using System;
    using System.ComponentModel;
    using BoldSign.Model;
    using BoldSign.Model.Webhook;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The webhook template event object.
    /// </summary>
    public class TemplateEvent : IWebhookData
    {
        /// <inheritdoc />
        [JsonProperty("object")]
        public string ObjectType { get; set; } = WebhookConstants.Template;

        /// <summary>
        /// Gets or sets templateId.
        /// </summary>
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or sets the document sender details.
        /// </summary>
        [JsonProperty("senderDetail", DefaultValueHandling = DefaultValueHandling.Include)]
        public TemplateSender SenderDetail { get; set; }

        /// <summary>
        ///     Gets or sets the CC details.
        /// </summary>
        [JsonProperty("ccDetails")]
        public TemplateCc[] CCDetails { get; set; }

        /// <summary>
        /// Gets or sets the createdDate.
        /// </summary>
        [JsonProperty("createdDate")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the activityDate.
        /// </summary>
        [JsonProperty("activityDate")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ActivityDate { get; set; }

        /// <summary>
        /// Gets or sets the activityBy.
        /// </summary>
        [JsonProperty("activityBy")]
        public string ActivityBy { get; set; }

        /// <summary>
        /// Gets or sets the messageTitle.
        /// </summary>
        [JsonProperty("messageTitle")]
        public string MessageTitle { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public DocumentStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the signerDetails.
        /// </summary>
        [JsonProperty("signerDetails")]
        public TemplateSigner[] SignerDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the SigningOrder is enabled.
        /// </summary>
        [JsonProperty("enableSigningOrder")]
        public bool EnableSigningOrder { get; set; }

        /// <summary>
        /// Gets or sets the templateName.
        /// </summary>
        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the templateDescription.
        /// </summary>
        [JsonProperty("templateDescription")]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// <para>Gets or sets the ErrorMessage.</para>
        /// <para>Available only when the template send is failed.</para>
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether get or Set the isTemplate.
        /// </summary>
        [JsonProperty("isTemplate")]
        [DefaultValue(false)]
        public bool IsTemplate { get; set; }
    }
}
