// <copyright file="Contacts.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The group user details.
    /// </summary>
    [DataContract]
    public class Contacts
    {
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user email.
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}
