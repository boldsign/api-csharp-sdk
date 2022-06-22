// <copyright file="CreateUserRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Runtime.Serialization;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    /// The create user details.
    /// </summary>
    [DataContract]
    public class CreateUserRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest"/> class.
        /// </summary>
        /// <param name="emailId">Gets or sets the emailId.</param>
        /// <param name="teamId">Gets or sets the teamId(optional).</param>
        /// <param name="userRole">Gets or sets the userRole(optional).</param>
        public CreateUserRequest(string emailId = default, string teamId = default, UserRoleType? userRole = UserRoleType.Member)
        {
            this.EmailId = emailId;
            this.TeamId = teamId;
            this.UserRole = userRole;
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [Required]
        [EmailAddress]
        [DataMember(Name = "emailId", EmitDefaultValue = true)]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the TeamId.
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = true)]
        public string TeamId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the UserRole.
        /// </summary>
        [DataMember(Name = "userRole", EmitDefaultValue = true)]
        public UserRoleType? UserRole { get; set; }
    }
}