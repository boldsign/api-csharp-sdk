// <copyright file="TemplateCreated.cs" company="Syncfusion Inc">
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
    /// template Created Action Result.
    /// </summary>
    [DataContract]
    public class TemplateCreated
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="TemplateCreated" /> class.
        /// </summary>
        /// <param name="templateId">Gets or sets template ID..</param>
        public TemplateCreated(string templateId = default)
        {
            this.TemplateId = templateId;
        }

        /// <summary>
        ///  Gets or sets template ID for a created template.
        /// </summary>
        /// <value>Gets or sets template ID.</value>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        ///  Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
