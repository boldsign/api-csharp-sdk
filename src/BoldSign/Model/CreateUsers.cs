// <copyright file="CreateUsers.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The create user details.
    /// </summary>
    [DataContract]
    public class CreateUsers
    {
        /// <summary>
        /// Gets or sets the EmailId.
        /// </summary>
        [DataMember(Name = "emailId", EmitDefaultValue = true)]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the TeamId.
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = true)]
        public string TeamId { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}