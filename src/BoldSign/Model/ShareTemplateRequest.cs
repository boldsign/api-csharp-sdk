// <copyright file="ShareTemplateRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The shared template request
    /// </summary>
    [DataContract]
    public class ShareTemplateRequest
    {
        /// <summary>
        /// Gets or sets the template teams share.
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<TemplateTeamShareRequest> Teams { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
