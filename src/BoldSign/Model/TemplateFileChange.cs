// <copyright file="TemplateFileChange.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    /// A file operation applied when sending a template. Use either uploads or URLs across the request.
    /// </summary>
    public class TemplateFileChange
    {
        /// <summary>Gets or sets the Add, Update, or Remove operation.</summary>
        [JsonProperty("editAction")]
        public EditAction? EditAction { get; set; }

        /// <summary>Gets or sets the inherited template file ID, required for Update and Remove.</summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>Gets or sets the optional zero-based final file position for Add or Update.</summary>
        [JsonProperty("fileOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileOrder { get; set; }

        /// <summary>Gets or sets the upload for Add or Update. Do not combine with file URLs.</summary>
        [JsonIgnore]
        public IDocumentFile File { get; set; }

        /// <summary>Gets or sets the file URL for Add or Update. Do not combine with uploads.</summary>
        [JsonProperty("fileUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri FileUrl { get; set; }
    }
}
