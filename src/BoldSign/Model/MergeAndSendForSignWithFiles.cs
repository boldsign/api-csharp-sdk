// <copyright file="MergeAndSendForSignWithFiles.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    ///     Return send for signature template details in which the document is in the form of base64 string.
    /// </summary>
    internal class MergeAndSendForSignWithFiles : MergeAndSendForSign, IDocumentUploadJson
    {
        /// <inheritdoc />
        [JsonProperty("files")]
        public new List<string> Files { get; set; }
    }
}
