// <copyright file="CreateContact.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The create Contact details.
    /// </summary>
    [DataContract]
    public class CreateContact
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }
    }
}
