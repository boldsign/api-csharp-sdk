// <copyright file="TemplateTag.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>
namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    ///     The Add and Delete tag model.
    /// </summary>
    [DataContract]
    public class TemplateTag
    {
        /// <summary>
        /// Gets or sets the template id.
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or sets the Tag's Name.
        /// </summary>
        [DataMember(Name = "documentLabels", EmitDefaultValue = false)]
        public List<string> DocumentLabels { get; set; }

        /// <summary>
        /// Gets or sets the Tag's Name.
        /// </summary>
        [DataMember(Name = "templateLabels", EmitDefaultValue = false)]
        public List<string> TemplateLabels { get; set; }

        /// <summary>
        /// Gets or sets the on behalf of email.
        /// </summary>
        [DataMember(Name = "onBehalfOf", EmitDefaultValue = false)]
        public string OnBehalfOf { get; set; }
    }
}