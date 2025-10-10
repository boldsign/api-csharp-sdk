// <copyright file="EmbeddedTemplateCreated.cs" company="Syncfusion Inc">
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
    ///     Embedded create template created result.
    /// </summary>
    public class EmbeddedTemplateCreated
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmbeddedTemplateCreated"/> class.
        /// </summary>
        /// <param name="templateId">Gets or sets template ID..</param>
        public EmbeddedTemplateCreated(string templateId = default)
        {
            this.TemplateId = templateId;
        }

        /// <summary>
        ///     Gets or sets template ID for a created template.
        /// </summary>
        /// <value>Gets or sets template ID.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        ///     Gets or sets template create  url.
        /// </summary>
        /// <value>Gets or sets Template  create url.</value>
        [DataMember(Name = "createUrl", EmitDefaultValue = true)]
        public Uri CreateUrl { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
