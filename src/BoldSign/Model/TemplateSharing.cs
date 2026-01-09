// <copyright file="TemplateSharing.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using BoldSign.Model;

    /// <summary>
    /// The share templates with the list of teams.
    /// </summary>
    [DataContract]
    public class TemplateSharing
    {
        /// <summary>
        /// Gets or sets the list of teams.
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<TemplateTeamShare> Teams { get; set; }
    }
}
