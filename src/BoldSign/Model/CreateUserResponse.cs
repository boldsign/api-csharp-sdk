// <copyright file="CreateUserResponse.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The create user details.
    /// </summary>
    [DataContract]
    public class CreateUserResponse
    {
        /// <summary>
        ///     Gets or sets the create users.
        /// </summary>
        /// <value>Gets or sets the user response.</value>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<CreateUsers> Users { get; set; }
    }
}