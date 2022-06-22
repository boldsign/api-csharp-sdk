// <copyright file="UserRole.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Defines UserRoleType as Admin, TeamAdmin and TeamMember.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserRole
    {
        /// <summary>
        ///     Enum AccountAdmin for value: AccountAdmin
        /// </summary>
        [EnumMember(Value = "AccountAdmin")]
        AccountAdmin = 1,

        /// <summary>
        ///     Enum TeamAdmin for value: TeamAdmin
        /// </summary>
        [EnumMember(Value = "TeamAdmin")]
        TeamAdmin = 2,

        /// <summary>
        ///     Enum TeamMember for value: TeamMember
        /// </summary>
        [EnumMember(Value = "TeamMember")]
        TeamMember = 3,
    }
}
