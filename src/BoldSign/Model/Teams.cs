// <copyright file="Teams.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    ///  Team and team user details.
    /// </summary>
    [DataContract]
    public class Teams
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Teams" /> class.
        /// </summary>
        /// <param name="teamName">Gets or sets the team Name.</param>
        /// <param name="createdDate">Gets or sets created Date.</param>
        /// <param name="modifiedDate">Gets or sets modified Date.</param>
        /// <param name="teamId">Gets or sets teamId.</param>
        public Teams(string teamName = default(string), long createdDate = default(long), long modifiedDate = default(long), string teamId = default(string))
        {
            this.TeamName = teamName;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Gets or sets the team Name.
        /// </summary>
        [DataMember(Name = "teamName", EmitDefaultValue = false)]
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets the created Date.
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public long CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified Date.
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]

        public long ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the teamId.
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]

        public string TeamId { get; set; }
    }
}
