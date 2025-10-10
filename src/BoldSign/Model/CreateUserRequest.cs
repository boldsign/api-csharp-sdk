// <copyright file="CreateUserRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
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
        /// <param name="metaData">Gets or sets the metaData(optional).</param>
        public CreateUserRequest(string emailId = default, string teamId = default, UserRoleType? userRole = UserRoleType.Member,Dictionary<string, string> metaData = default)
        {
            this.EmailId = emailId;
            this.TeamId = teamId;
            this.UserRole = userRole;
            this.MetaData= metaData;
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

        /// <summary>
        /// Gets or sets the MetaData value.
        /// </summary>
        [DataMember(Name = "MetaData", EmitDefaultValue = true)]
        public Dictionary<string, string> MetaData { get; set; }
    }
}
