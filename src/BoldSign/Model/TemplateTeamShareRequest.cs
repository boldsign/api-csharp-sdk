// <copyright file="TemplateTeamShare.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using BoldSign.Model;

    [DataContract]
    public class TemplateTeamShareRequest
    {
        /// <summary>
        /// Gets or sets the team Id.
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = true)]
        [Required(ErrorMessage = "Team Id is required.")]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        [Required(ErrorMessage = "Action is required.")]
        public TemplateShareAction? Action { get; set; }

        /// <summary>
        /// Gets or sets the access level.
        /// </summary>
        [DataMember(Name = "accessLevel", EmitDefaultValue = false)]
        public TemplateAccessType? AccessLevel { get; set; }
    }
}
