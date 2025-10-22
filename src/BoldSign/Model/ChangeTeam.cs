// <copyright file="ChangeTeam.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
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
        public string ToTeamId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember(Name = "transferDocumentsToUserId")]
        public string TransferDocumentsToUserId { get; set; }
    }
}
