// <copyright file="EmbeddedCloneDocumentRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    ///  Embedded clone document request.
    /// </summary>
    [DataContract(Name = "EmbeddedCloneDocumentRequest")]
    public class EmbeddedCloneDocumentRequest
    {
        /// <summary>
        /// Gets or sets the document id.
        /// </summary>
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

       /// <summary>
        /// Gets or sets the RedirectUrl.
        /// </summary>
        [JsonProperty("redirectUrl")]
        [Display(Description = "This property is used to redirect to the URL after the embed cloned document process is completed.")]
        public Uri RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets the create view option.
        /// </summary>
        [JsonProperty("viewOption")]
        [Display(Description = "Setting enum to FillingPage will make the user start with document uploading and signers filling page. Setting enum to PreparePage will make the user start with preparing or configuring fields page of the document.")]
        public PageViewOption ViewOption { get; set; } = PageViewOption.PreparePage;

        /// <summary>
        /// Gets or sets a value indicating whether to show save button.
        /// </summary>
        [JsonProperty("showSaveButton")]
        [Display(Description = "Show the save option in both filling and prepare page, to save the progress of the document.")]
        public bool ShowSaveButton { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to show preview button.
        /// </summary>
        [JsonProperty("showPreviewButton")]
        [Display(Description = "Show the preview of the document to review.")]
        public bool ShowPreviewButton { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to show navigation buttons.
        /// </summary>
        [JsonProperty("showNavigationButtons")]
        [Display(Description = "Show the navigation buttons in both filling and prepare page.")]
        public bool ShowNavigationButtons { get; set; } = true;

        /// <summary>
        /// Gets or sets a expiry date for create link.
        /// Maximum valid till is 180 days.
        /// Default is 30 days.
        /// </summary>
        [JsonProperty("linkValidTill")]
        [Display(Description = "Set the validity of the generated URL and its maximum validity is 180 days.")]
        [DataType(DataType.DateTime)]
        public DateTime? LinkValidTill { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show With FormField Values.
        /// </summary>
        [JsonProperty("includeFormFieldValues")]
        [Display(Description = "Show the document With FormField Values.")]
        public bool IncludeFormFieldValues { get; set; }

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        [JsonProperty("locale")]
        [Display(Description = "Contents exists in the New Page, Prepare Page and Preview Page will be displayed in the language selected.")]
        public Locales Locale { get; set; } = Locales.EN;

        /// <summary>
        /// Gets or sets a value indicating whether to show send button.
        /// </summary>
        [JsonProperty("showSendButton")]
        [Display(Description = "Show the send button in prepare page to send the document.")]
        public bool ShowSendButton { get; set; } = true;

         /// <summary>
        /// Gets or sets a value indicating whether to show tool bar.
        /// </summary>
        [JsonProperty("showToolbar")]
        [Display(Description = "Toggle the visibility of the tool bar with options in both the filling and prepare pages.")]
        public bool ShowToolbar { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the tooltip.
        /// </summary>
        [JsonProperty("showTooltip")]
        [Display(Description = "Show the tooltip in the prepare page.")]
        public bool ShowTooltip { get; set; }

        /// <summary>
        /// Gets or sets the on behalf of email address.
        /// </summary>
        [JsonProperty("onBehalfOf")]
        [Display(Description = "The property is used to get or set the on behalf of sender email address.")]
        public string OnBehalfOf { get; set; }
    }
}
