// <copyright file="EmbeddedDocumentEditResponse.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The Embedded Document Edited.
    /// </summary>
    public class EmbeddedDocumentEditResponse
    {
        /// <summary>
        /// Gets or sets embedded document edit url.
        /// </summary>
        /// <value>Gets or sets embedded document edit url.</value>
        [DataMember(Name = "editUrl", EmitDefaultValue = true)]
        public Uri EditUrl { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}