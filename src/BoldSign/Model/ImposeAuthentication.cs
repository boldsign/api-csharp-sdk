// <copyright file="ImposeAuthentication.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// AuthenticationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImposeAuthentication
    {
        /// <summary>
        ///  Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        ///  Enum EmailOTP for value: EmailOTP
        /// </summary>
        [EnumMember(Value = "EmailOTP")]
        EmailOTP = 2,

        /// <summary>
        ///  Enum AccessCode for value: AccessCode
        /// </summary>
        [EnumMember(Value = "AccessCode")]
        AccessCode = 3,
    }
}
