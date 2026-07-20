// <copyright file="Format.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Format.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Format
    {
        /// <summary>
        /// Represents Combined.
        /// </summary>
        [EnumMember(Value = "Combined")]
        Combined,

        /// <summary>
        /// Represents Individually.
        /// </summary>
        [EnumMember(Value = "Individually")]
        Individually,
    }
}
