// <copyright file="TeamList.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    ///  Team list.
    /// </summary>
    [DataContract]
    public class TeamList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamList" /> class.
        /// </summary>
        /// <param name="results">Gets or sets the team results.</param>
        public TeamList(List<Teams> results = default(List<Teams>))
        {
            this.Results = results;
        }

        /// <summary>
        ///  Gets or sets page details.
        /// </summary>
        [DataMember(Name = "pageDetails", EmitDefaultValue = false)]
        public TeamPageDetails PageDetails { get; set; }

        /// <summary>
        /// Gets or sets the team results.
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<Teams> Results { get; set; }
    }
}
