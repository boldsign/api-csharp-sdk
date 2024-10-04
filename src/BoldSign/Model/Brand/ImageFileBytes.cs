// <copyright file="ImageFileBytes.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    /// <summary>
    /// The image file bytes.
    /// </summary>
    public class ImageFileBytes : IImageFile
    {
        /// <summary>
        /// Gets or sets the file bytes.
        /// </summary>
        public byte[] FileBytes { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        public string ContentType { get; set; }
    }
}
