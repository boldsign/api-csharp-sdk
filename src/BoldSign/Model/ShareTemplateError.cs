// <copyright file="ShareTemplateError.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class ShareTemplateError
    {
        /// <summary>
        /// Gets or sets the templateId.
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or sets the team IDs.
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<string> Teams { get; set; }

        /// <summary>
        /// Gets or sets the error type.
        /// </summary>
        [DataMember(Name = "errorType", EmitDefaultValue = false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or sets the error detail.
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }
    }
}
