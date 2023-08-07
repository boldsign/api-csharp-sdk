// <copyright file="FileInfo.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// FileInfo.
    /// </summary>
    [DataContract]
    public class FileInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        /// <param name="fileName">fileName.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="extension">extension.</param>
        public FileInfo(string fileName = default(string), int fileSize = default(int), string contentType = default(string), string extension = default(string))
        {
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.ContentType = contentType;
            this.Extension = extension;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        [JsonConstructor]
        protected FileInfo ()
        {
        }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        [DataMember(Name = "fileName", EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the file size.
        /// </summary>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = true)]
        public string Extension { get; set; }
    }
}
