// <copyright file="CreateTemplateRequest.cs" company="Syncfusion Inc">
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
    ///  create template request  DTO.
    /// </summary>
    [DataContract(Name = "CreateTemplateRequest")]
    public class CreateTemplateRequest : ITextTags, IDocumentUpload
    {
        /// <summary>
        ///  Gets or sets title for the Template request.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets template description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets list of files.
        /// </summary>
        [Required]
        [JsonProperty("files")]
        public List<IDocumentFile> Files { get; set; } = new List<IDocumentFile>();

        /// <summary>
        /// Gets or sets the FileUrl.
        /// </summary>
        [JsonProperty("fileUrls")]
        public List<Uri> FileUrls { get; set; } = new List<Uri>();

        /// <summary>
        /// Gets or sets the Roles details.
        /// </summary>
        [Required]
        public IEnumerable<TemplateRole> Roles { get; set; }

        /// <summary>
        /// Gets or sets Template CC.
        /// </summary>
        [JsonProperty("cc")]
        public IEnumerable<DocumentCC> CC { get; set; }

        /// <summary>
        /// Gets or sets document title.
        /// </summary>
        [JsonProperty("documentTitle")]
        public string DocumentTitle { get; set; }

        /// <summary>
        /// Gets or sets document message or description.
        /// </summary>
        [JsonProperty("documentMessage")]
        public string DocumentMessage { get; set; }

        /// <summary>
        /// Gets or sets the brandId.
        /// </summary>
        [JsonProperty("brandId")]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to allow senders to replace or delete files.
        /// </summary>
        [JsonProperty("allowModifyFiles")]
        public bool AllowModifyFiles { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether  the allow message editing option is enabled or disabled.
        /// </summary>
        [JsonProperty("allowMessageEditing")]
        public bool AllowMessageEditing { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether  the allow message allow new role option is enabled or disabled.
        /// </summary>
        [JsonProperty("allowNewRoles")]
        public bool AllowNewRoles { get; set; } = true;

        /// <summary>
        /// Gets or sets list of allow new files.
        /// </summary>
        [JsonProperty("allowNewFiles")]
        public bool AllowNewFiles { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether  the enable  reassign value option is enabled or disabled.
        /// </summary>
        [JsonProperty("enableReassign")]
        public bool EnableReassign { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether  the enable  print and sign value option is enabled or disabled.
        /// </summary>
        [JsonProperty("enablePrintAndSign")]
        public bool EnablePrintAndSign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether  the enable  signing order  value option is enabled or disabled.
        /// </summary>
        public bool EnableSigningOrder { get; set; }

        /// <summary>
        /// Gets or sets a documentInfo.
        /// </summary>
        [JsonProperty("documentInfo")]
        public IEnumerable<DocumentInfo> DocumentInfo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to convert the text tags to form fields.
        /// </summary>
        [JsonProperty("useTextTags")]
        public bool UseTextTags { get; set; }

        /// <summary>
        /// Gets or sets the text tags definitions declared in the list can be used in the document by using the definition ID.
        /// </summary>
        [JsonProperty("textTagDefinitions")]
        public List<TextTagDefinition> TextTagDefinitions { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether to AutoDetect Fields for the document signer.
        /// </summary>
        [JsonProperty("autoDetectFields")]
        public bool AutoDetectFields { get; set; }

        /// <summary>
        /// Gets or sets the on behalf of email.
        /// </summary>
        [JsonProperty("onBehalfOf")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Gets or sets the document labels.
        /// </summary>
        [JsonProperty("labels")]
        public IEnumerable<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets the template labels.
        /// </summary>
        [JsonProperty("templateLabels")]
        public IEnumerable<string> TemplateLabels { get; set; }

        /// <summary>
        /// Gets or sets form group values for grouped form fields.
        /// </summary>
        [DataMember(Name = "formGroups", EmitDefaultValue = false)]
        public List<FormGroup> FormGroups { get; set; }

        /// <summary>
        /// Gets or sets the Recipient Notification Settings.
        /// </summary>
        [JsonProperty("recipientNotificationSettings")]
        [Display(Description = "Recipient Notification Settings of the Template.")]
        public RecipientNotificationSettings RecipientNotificationSettings { get; set; }
    }
}
