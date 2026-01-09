
// <copyright file="CreateGroupContactResponse.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>
namespace BoldSign.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The create group contact response.
    /// </summary>
    [DataContract]
    public class CreateGroupContactResponse
    {
        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }
    }
}