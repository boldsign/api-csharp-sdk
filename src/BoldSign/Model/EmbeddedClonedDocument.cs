// <copyright file="EmbeddedClonedDocument.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///     Embedded cloned document result.
    /// </summary>
    public class EmbeddedClonedDocument
   {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmbeddedClonedDocument"/> class.
        /// </summary>
        /// <param name="documentId">Gets or sets template ID.</param>
        public EmbeddedClonedDocument(string documentId = default)
        {
            this.DocumentId = documentId;
        }

        /// <summary>
        ///     Gets or sets document ID for a cloned document.
        /// </summary>
        /// <value>Gets or sets document ID.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = true)]
        public string DocumentId { get; set; }

        /// <summary>
        ///    Gets or sets document embed url.
        /// </summary>
        /// <value>Gets or sets docuemnt embed url.</value>
        [DataMember(Name = "embedUrl", EmitDefaultValue = true)]
        public Uri EmbedUrl { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
