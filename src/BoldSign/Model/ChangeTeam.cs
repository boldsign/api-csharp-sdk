// <copyright file="ChangeTeam.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// The change team data.
    /// </summary>
    [DataContract]
    public class ChangeTeam
    {
        /// <summary>
        /// Gets or sets the to team ID.
        /// </summary>
        [DataMember(Name = "toTeamId")]
        [Required(ErrorMessage = "ToTeamId is required")]
        public string ToTeamId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember(Name = "transferDocumentsToUserId")]
        public string TransferDocumentsToUserId { get; set; }
    }
}
