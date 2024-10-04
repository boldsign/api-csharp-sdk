// <copyright file="ImageFileStream.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.IO;

    /// <summary>
    /// The image file stream.
    /// </summary>
    public class ImageFileStream : IImageFile
    {
        /// <summary>
        /// Gets or sets the file stream.
        /// </summary>
        public Stream FileStream { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        public string ContentType { get; set; }
    }
}
