// <copyright file="UpdateUserMetaData.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The update user metadata.
    /// </summary>
    [DataContract]
    public class UpdateUserMetaData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserMetaData"/> class.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="metaData">The meteData.</param>
        public UpdateUserMetaData(string userId = default, Dictionary<string, string> metaData = default)
        {
            this.UserId = userId;
            this.MetaData = metaData;
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        [DataMember(Name = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the MetaData value.
        /// </summary>
        [DataMember(Name = "MetaData", EmitDefaultValue = true)]
        public Dictionary<string, string> MetaData { get; set; }
    }
}
