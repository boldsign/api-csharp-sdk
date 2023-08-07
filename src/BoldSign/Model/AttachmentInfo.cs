// <copyright file="AttachmentInfo.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
        [Obsolete("AllowedFileTypes is deprecated, please use AcceptedFileTypes instead.")]
        public AttachmentInfo(string title = default(string), string description = default(string), string allowedFileTypes = default(string))
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidDataContractException(ApiValidationMessages.AttachmentTitleRequired);
            }

            this.Title = title;
            this.Description = description;
            if (string.IsNullOrEmpty(allowedFileTypes))
            {
                throw new InvalidDataContractException(ApiValidationMessages.FileTypeRequired);
            }

            this.AllowedFileTypes = allowedFileTypes.Trim();
            string[] allowedTypeSplit = this.AllowedFileTypes.Split(',');
            FileTypesFormat(allowedTypeSplit.ToList());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInfo" /> class.
        /// </summary>
        /// <param name="title">placeHolder.</param>
        /// <param name="description">description.</param>
        /// <param name="acceptedFileTypes">acceptedFileTypes.</param>
        public AttachmentInfo(string title = default(string), string description = default(string), List<string> acceptedFileTypes = default(List<string>))
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidDataContractException(ApiValidationMessages.AttachmentTitleRequired);
            }

            this.Title = title;
            this.Description = description;
            if (acceptedFileTypes == null || acceptedFileTypes.Count <= 0)
            {
                throw new InvalidDataContractException(ApiValidationMessages.FileTypeRequired);
            }

            this.AcceptedFileTypes = acceptedFileTypes;
            FileTypesFormat(acceptedFileTypes);
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
        /// Gets or sets the allowed file types such as document, pdf and image. Example: "document,image".
        /// </summary>
        [DataMember(Name = "allowedFileTypes", EmitDefaultValue = true)]
        [Obsolete("AllowedFileTypes is deprecated, please use AcceptedFileTypes instead.")]
        public string AllowedFileTypes { get; set; }

        /// <summary>
        /// Gets or sets the accepted file types such as DOCUMENT, PDF and IMAGE. Example: ["PDF", "DOCUMENT", "IMAGE"].
        /// </summary>
        [DataMember(Name = "acceptedFileTypes", EmitDefaultValue = false)]
        public List<string> AcceptedFileTypes { get; set; }

        private static void FileTypesFormat(List<string> fileTypes)
        {
            foreach (string type in fileTypes)
            {
                string selectedType = type.ToUpperInvariant();
                selectedType = selectedType.Trim();
                if (selectedType != "PDF" && selectedType != "DOCUMENT" && selectedType != "IMAGE")
                {
                    throw new InvalidDataContractException(ApiValidationMessages.InvalidFormat);
                }
            }
        }
    }
}
