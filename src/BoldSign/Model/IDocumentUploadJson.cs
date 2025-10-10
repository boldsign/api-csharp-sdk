// <copyright file="IDocumentUpload.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using BoldSign.Model;

    /// <summary>
    /// Interface for document JSON upload.
    /// </summary>
    public interface IDocumentUploadJson
    {
        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        List<string> Files { get; set; }

        /// <summary>
        /// Gets or sets the file urls.
        /// </summary>
        List<Uri> FileUrls { get; set; }
    }
}
