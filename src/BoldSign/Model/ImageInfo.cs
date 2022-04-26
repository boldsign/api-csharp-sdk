// <copyright file="ImageInfo.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    /*
 * BoldSign API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    /// ImageInfo.
    /// </summary>
    [DataContract]
    public class ImageInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageInfo" /> class.
        /// </summary>
        /// <param name="allowedFileExtensions">allowedFileExtensions.</param>
        /// <param name="description">description.</param>
        /// <param name="title">title (required).</param>
        public ImageInfo(string title = default(string), string description = default(string), string allowedFileExtensions = default(string))
        {
            // to ensure "title" is required (not null)
            if (String.IsNullOrEmpty(title))
            {
                throw new InvalidDataException(ApiValidationMessages.ImageTitleRequired);
            }

            this.Title = title;
            this.Description = description;
            if (String.IsNullOrEmpty(allowedFileExtensions))
            {
                throw new InvalidDataException(ApiValidationMessages.ImageFormatRequired);
            }

            this.AllowedFileExtensions = allowedFileExtensions.Trim();
            string[] allowedTypeSplit = this.AllowedFileExtensions.Split(',');
            foreach (string type in allowedTypeSplit)
            {
                string selectedType = type.ToUpperInvariant();
                selectedType = selectedType.Trim();
                if (selectedType != ".JPG" && selectedType != ".JPEG" && selectedType != ".SVG" && selectedType != ".PNG" && selectedType != ".BMP")
                {
                    throw new InvalidDataContractException(ApiValidationMessages.InvalidFormat);
                }
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ImageInfo" /> class.
        /// </summary>
        [JsonConstructor]
        protected ImageInfo()
        {
        }

        /// <summary>
        /// Gets or Sets Title value.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the allowed file extensions such as jpg, jpeg, png, svg and bmp. Example : ".jpg,.jpeg,.png".
        /// </summary>
        [DataMember(Name = "allowedFileExtensions", EmitDefaultValue = false)]
        public string AllowedFileExtensions { get; set; }
    }
}