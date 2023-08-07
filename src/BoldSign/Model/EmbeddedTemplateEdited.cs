// <copyright file="EmbeddedTemplateEdited.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The Embedded Template Edited.
    /// </summary>
    public class EmbeddedTemplateEdited
    {
        /// <summary>
        /// Gets or sets embedded template edit url.
        /// </summary>
        /// <value>Gets or sets Template  create url.</value>
        [DataMember(Name = "createUrl", EmitDefaultValue = true)]
        public Uri EditUrl { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
