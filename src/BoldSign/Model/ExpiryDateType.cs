// <copyright file="ExpiryDateType.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Expiry Date Type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpiryDateType
    {
        /// <summary>
        /// Days.
        /// </summary>
        [EnumMember(Value = "Days")]
        Days,

        /// <summary>
        /// Hours.
        /// </summary>
        [EnumMember(Value = "Hours")]
        Hours,

        /// <summary>
        /// Specific Date and Time.
        /// </summary>
        [EnumMember(Value = "SpecificDateTime")]
        SpecificDateTime,
    }
}
