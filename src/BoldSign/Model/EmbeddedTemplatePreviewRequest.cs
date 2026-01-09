// <copyright file="EmbeddedTemplatePreviewRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The Embedded Template Preview.
    /// </summary>
    [DataContract(Name = "EmbeddedTemplatePreviewRequest")]
    public class EmbeddedTemplatePreviewRequest
    {
        /// <summary>
        /// Gets or sets the template id.
        /// </summary>
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

	    /// <summary>
        /// Gets or sets a value indicating whether to show tool bar.
        /// </summary>
        [JsonProperty("showToolbar")]
        public bool ShowToolbar { get; set; }

        /// <summary>
        /// Gets or sets a expiry date for create link.
        /// Maximum valid till is 180 days.
        /// Default is 30 days.
        /// </summary>
        [JsonProperty("linkValidTill")]
        public DateTime? LinkValidTill { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}