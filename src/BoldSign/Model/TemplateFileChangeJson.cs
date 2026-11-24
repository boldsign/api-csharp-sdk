// <copyright file="TemplateFileChangeJson.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using Newtonsoft.Json;

    /// <summary>JSON representation of a template file operation.</summary>
    internal class TemplateFileChangeJson : TemplateFileChange
    {
        /// <summary>Gets or sets the JSON file content.</summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public new TemplateFileContent File { get; set; }
    }
}
