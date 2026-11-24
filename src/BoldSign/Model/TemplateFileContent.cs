// <copyright file="TemplateFileContent.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using Newtonsoft.Json;

    /// <summary>A named file in the API's existing data-URI format.</summary>
    internal class TemplateFileContent
    {
        /// <summary>Gets or sets the data URI.</summary>
        [JsonProperty("base64")]
        public string Base64 { get; set; }

        /// <summary>Gets or sets the original file name.</summary>
        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }
}
