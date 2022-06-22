// <copyright file="UpdateUser.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The update user details.
    /// </summary>
    public class UpdateUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUser"/> class.
        /// </summary>
        /// <param name="userId">Gets or sets userId.</param>
        /// <param name="userRole">Gets or sets userRole.</param>
        public UpdateUser(string userId, UserRoleType userRole = UserRoleType.Member)
        {
            this.UserId = userId;
            this.UserRole = userRole;
        }

        /// <summary>
        /// Gets or sets the userId.
        /// </summary>
        [Required]
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the UserRole.
        /// </summary>
        [DataMember(Name = "userRole", EmitDefaultValue = true)]
        public UserRoleType UserRole { get; set; }
    }
}