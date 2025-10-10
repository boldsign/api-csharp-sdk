// <copyright file="EditTemplateRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    ///  Edit template request DTO.
    /// </summary>
    [DataContract(Name = "EditTemplateRequest")]
    public class EditTemplateRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EditTemplateRequest" /> class.
        /// </summary>
        /// <param name="templateId">Gets or sets the template id.</param>
        public EditTemplateRequest(string templateId)
        {
            this.TemplateId = templateId;
        }

        /// <summary>
        ///     Gets or sets the template Id.
        /// </summary>
        /// <value>Gets or sets the templateId id.</value>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

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
        /// Gets or sets the Roles details.
        /// </summary>
        [JsonProperty("roles")]
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
        /// Gets or sets a value indicating whether the allow message editing option is enabled or disabled.
        /// </summary>
        [JsonProperty("allowMessageEditing")]
        public bool? AllowMessageEditing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the allow message allow new role option is enabled or disabled.
        /// </summary>
        [JsonProperty("allowNewRoles")]
        public bool? AllowNewRoles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the allow message allow new file option is enabled or disabled.
        /// </summary>
        [JsonProperty("allowNewFiles")]
        public bool? AllowNewFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the enable  reassign value option is enabled or disabled.
        /// </summary>
        [JsonProperty("enableReassign")]
        public bool? EnableReassign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the enable  print and sign value option is enabled or disabled.
        /// </summary>
        [JsonProperty("enablePrintAndSign")]
        public bool? EnablePrintAndSign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the enable  signing order  value option is enabled or disabled.
        /// </summary>
        [JsonProperty("enableSigningOrder")]
        public bool? EnableSigningOrder { get; set; }

        /// <summary>
        /// Gets or sets a documentInfo.
        /// </summary>
        [JsonProperty("documentInfo")]
        public IEnumerable<DocumentInfo> DocumentInfo { get; set; }

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
        /// Gets or sets the Recipient Notification Settings values.
        /// </summary>
        [DataMember(Name = "recipientNotificationSettings", EmitDefaultValue = true)]
        public RecipientNotificationSettings RecipientNotificationSettings { get; set; }
    }
}
