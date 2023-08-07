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
        /// <param name="userStatus">Gets or sets userStatus.</param>
        /// <param name="toUserId">Gets or sets toUserId.</param>
        public UpdateUser(string userId, UserRoleType userRole = UserRoleType.Member, UserStatusOption userStatus = default, string toUserId = default)
        {
            this.UserId = userId;
            this.UserRole = userRole;
            this.UserStatus = userStatus;
            this.ToUserId = toUserId;
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

        /// <summary>
        /// Gets or sets the UserStatus.
        /// </summary>
        [DataMember(Name = "userStatus", EmitDefaultValue = false)]
        public UserStatusOption UserStatus { get; set; }

        /// <summary>
        /// Gets or sets the toUserId.
        /// </summary>
        [DataMember(Name = "toUserId", EmitDefaultValue = false)]
        public string ToUserId { get; set; }
    }
}