// <copyright file="CreatedContact.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The Create Contact Details.
    /// </summary>
    [DataContract]
    public class CreatedContact
    {
        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>Gets or sets the contacts response.</value>
        [DataMember(Name = "createdContacts", EmitDefaultValue = true)]
        public List<CreateContact> CreatedContacts { get; set; }
    }
}