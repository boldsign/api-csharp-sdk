// <copyright file="DocumentTags.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>
namespace BoldSign.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    ///     The Add and Delete tag model.
    /// </summary>
    [DataContract]
    public class DocumentTags
    {
        /// <summary>
        /// Gets or sets the DocumentId.
        /// </summary>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the Tags.
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }
    }
}
