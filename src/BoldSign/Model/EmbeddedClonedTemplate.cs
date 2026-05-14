// <copyright file="EmbeddedClonedTemplate.cs" company="Syncfusion Inc">
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
    ///     Embedded cloned template result.
    /// </summary>
    public class EmbeddedClonedTemplate
   {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmbeddedClonedTemplate"/> class.
        /// </summary>
        /// <param name="templateId">Gets or sets template ID..</param>
        public EmbeddedClonedTemplate(string templateId = default)
        {
            this.TemplateId = templateId;
        }

        /// <summary>
        ///     Gets or sets template ID for a cloned template.
        /// </summary>
        /// <value>Gets or sets template ID.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        ///     Gets or sets template embed  url.
        /// </summary>
        /// <value>Gets or sets Template  embed url.</value>
        [DataMember(Name = "embedUrl", EmitDefaultValue = true)]
        public Uri EmbedUrl { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
