// <copyright file="TeamUsers.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Model;

    /// <summary>
    ///  Team and team user details.
    /// </summary>
    [DataContract]
    public class TeamUsers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamUsers" /> class.
        /// </summary>
        /// <param name="userId">Gets or sets the user Id.</param>
        /// <param name="email">Gets or sets the email.</param>
        /// <param name="firstName">Gets or sets the first Name.</param>
        /// <param name="lastName">Gets or sets the last Name.</param>
        /// <param name="userRole">Gets or sets user Role.</param>
        /// <param name="userStatus">Gets or sets the user Status.</param>
        public TeamUsers(string userId = default(string), string email = default(string), string firstName = default(string), string lastName = default(string), UserRole userRole = default(UserRole), UserStatus userStatus = default(UserStatus))
        {
            this.UserId = userId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserRole = userRole;
            this.UserStatus = userStatus;
        }

        /// <summary>
        /// Gets or sets the user Id.
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first Name.
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last Name.
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user Role.
        /// </summary>
        [DataMember(Name = "userRole", EmitDefaultValue = false)]
        public UserRole UserRole { get; set; }

        /// <summary>
        /// Gets or sets the User Status.
        /// </summary>
        [DataMember(Name = "userStatus", EmitDefaultValue = false)]
        public UserStatus UserStatus { get; set; }
    }
}
