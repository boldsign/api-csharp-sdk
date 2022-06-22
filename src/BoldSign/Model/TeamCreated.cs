// <copyright file="TeamCreated.cs" company="Syncfusion Inc">
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
    public class TeamCreated
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamCreated" /> class.
        /// </summary>
        /// <param name="teamId">Gets or sets team Id.</param>
        public TeamCreated(string teamId = default(string))
        {
            this.TeamId = teamId;
        }

        /// <summary>
        /// Gets or sets the team Id.
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        public string TeamId { get; set; }
    }
}
