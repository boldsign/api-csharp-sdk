// <copyright file="EmbeddedMergeTemplateRequestWithFiles.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Return send for embedded signature template details in which the document is in the form of in the form of base64 string.
    /// </summary>
    internal class EmbeddedMergeTemplateRequestWithFiles : EmbeddedMergeTemplateRequest, IDocumentUploadJson
    {
        /// <inheritdoc />
        [JsonProperty("files")]
        public new List<string> Files { get; set; }
    }
}