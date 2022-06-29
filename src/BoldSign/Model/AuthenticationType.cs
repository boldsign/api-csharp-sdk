// <copyright file="AuthenticationType.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// AuthenticationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticationType
    {
        /// <summary>
        /// Represents EmailOTP only.
        /// </summary>
        [EnumMember(Value = "EmailOTP")]
        EmailOTP = 1,

        /// <summary>
        /// Represents AccessCode only.
        /// </summary>
        [EnumMember(Value = "AccessCode")]
        AccessCode = 2,
    }
}