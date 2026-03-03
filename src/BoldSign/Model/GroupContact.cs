// <copyright file="GroupContact.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The group contact details.
    /// </summary>
    [DataContract]
    public class GroupContact
    {
        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        [DataMember(Name = "groupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        [DataMember(Name = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the Contacts.
        /// </summary>
        [DataMember(Name = "contacts")]
        public List<Contacts> Contacts { get; set; }

        /// <summary>
        /// Gets or sets directories associated with the group.
        /// </summary>
        [DataMember(Name = "directories")]
        public List<string> Directories { get; set; }
    }
}
