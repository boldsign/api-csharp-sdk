// <copyright file="AttachmentInfo.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Api.Resources;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    /// Attachment Info.
    /// </summary>
    [DataContract]
    public class AttachmentInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInfo" /> class.
        /// </summary>
        /// <param name="title">placeHolder.</param>
        /// <param name="description">description.</param>
        /// <param name="allowedFileTypes">allowedFileTypes.</param>
        public AttachmentInfo(string title = default(string), string description = default(string), string allowedFileTypes = default(string))
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new InvalidDataContractException(ApiValidationMessages.AttachmentTitleRequired);
            }

            this.Title = title;
            this.Description = description;
            if(String.IsNullOrEmpty(allowedFileTypes))
            {
                throw new InvalidDataContractException(ApiValidationMessages.FileTypeRequired);
            }

            this.AllowedFileTypes = allowedFileTypes.Trim();
            string[] allowedTypeSplit = this.AllowedFileTypes.Split(',');
            foreach (string type in allowedTypeSplit)
            {
                string selectedType = type.ToUpperInvariant();
                selectedType = selectedType.Trim();
                if (selectedType != "PDF" && selectedType != "DOCUMENT" && selectedType != "IMAGE")
                {
                    throw new InvalidDataContractException(ApiValidationMessages.InvalidFormat);
                }
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AttachmentInfo" /> class.
        /// </summary>
        [JsonConstructor]
        protected AttachmentInfo()
        {
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the file types such as document, pdf and image. Example : "document,pdf".
        /// </summary>
        [DataMember(Name = "allowedFileTypes", EmitDefaultValue = true)]
        public string AllowedFileTypes { get; set; }
    }
}
