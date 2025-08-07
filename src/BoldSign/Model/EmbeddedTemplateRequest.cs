// <copyright file="EmbeddedTemplateRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using BoldSign.Api.Model;
    using Newtonsoft.Json;

    /// <summary>
    ///     Embedded send request using template DTO.
    /// </summary>
    [DataContract(Name = "EmbeddedTemplateRequest")]
    public class EmbeddedTemplateRequest : SendForSignFromTemplate, IEmbeddedRequest, IDocumentUpload
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmbeddedTemplateRequest" /> class.
        /// </summary>
        /// <param name="templateId">Gets or sets the document id..</param>
        /// <param name="title">Gets or sets the title..</param>
        /// <param name="message">Gets or sets the message..</param>
        /// <param name="roles">Gets or sets the roles..</param>
        /// <param name="brandId">Gets or sets the brandId..</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="sendLinkValidTill">Gets or sets the sendLinkValidTill.</param>
        /// <param name="disableExpiryAlert">Gets or sets the disableExpiryAlert.</param>
        /// <param name="enablePrintAndSign">Gets or sets the enablePrintAndSign.</param>
        /// <param name="enableReassign">Gets or sets the enableReassign.By Default True.</param>
        /// <param name="enableSigningOrder">Gets or sets the enableSigningOrder.</param>
        /// <param name="documentInfo">Gets or sets the send documentInfo.</param>
        /// <param name="roleRemovalIndices">Gets or sets the role removal indices.</param>
        public EmbeddedTemplateRequest(
            string templateId = default,
            string title = default,
            string message = default,
            List<Roles> roles = default,
            string brandId = default,
            List<string> labels = default,
            DateTime? sendLinkValidTill = default,
            bool disableExpiryAlert = default,
            bool enablePrintAndSign = default,
            bool enableReassign = true,
            bool? enableSigningOrder = default,
            IEnumerable<DocumentInfo> documentInfo = default,
            int[] roleRemovalIndices = default)
        {
            this.TemplateId = templateId;
            this.Title = title;
            this.Message = message;
            this.Roles = roles;
            this.TemplateId = templateId;
            this.Title = title;
            this.Message = message;
            this.Roles = roles;
            this.BrandId = brandId;
            this.Labels = labels;
            this.SendLinkValidTill = sendLinkValidTill;
            this.DisableExpiryAlert = disableExpiryAlert;
            this.EnablePrintAndSign = enablePrintAndSign;
            this.EnableReassign = enableReassign;
            this.EnableSigningOrder = enableSigningOrder;
            this.DocumentInfo = documentInfo;
            this.RoleRemovalIndices = roleRemovalIndices;
        }

        /// <summary>
        /// Gets or sets the redirect URL.
        /// </summary>
        [JsonProperty("redirectUrl")]
        public Uri RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show tool bar.
        /// </summary>
        [JsonProperty("showToolbar")]
        public bool ShowToolbar { get; set; }

        /// <summary>
        /// Gets or sets the send view option.
        /// </summary>
        [JsonProperty("sendViewOption")]
        public PageViewOption SendViewOption { get; set; } = PageViewOption.PreparePage;

        /// <summary>
        /// Gets or sets a value indicating whether to show save button.
        /// </summary>
        [JsonProperty("showSaveButton")]
        public bool ShowSaveButton { get; set; } = true;

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        [JsonProperty("locale")]
        public Locales Locale { get; set; } = Locales.EN;

        /// <summary>
        /// Gets or sets a value indicating whether to show send button.
        /// </summary>
        [JsonProperty("showSendButton")]
        public bool ShowSendButton { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to show preview button.
        /// </summary>
        [JsonProperty("showPreviewButton")]
        public bool ShowPreviewButton { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to show navigation buttons.
        /// </summary>
        [JsonProperty("showNavigationButtons")]
        public bool ShowNavigationButtons { get; set; } = true;

        /// <summary>
        /// Gets or sets a value send link valid till.
        /// Maximum valid till is 180 days.
        /// Default is 30 days.
        /// </summary>
        [JsonProperty("sendLinkValidTill")]
        public DateTime? SendLinkValidTill { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show tool tip.
        /// </summary>
        [JsonProperty("showTooltip")]
        public bool ShowTooltip { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public override string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
