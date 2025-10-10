// <copyright file="GroupValidation.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Defines id  that can be set as per need.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupValidation
    {
        /// <summary>
        /// Represents Minimum.
        /// </summary>
        [EnumMember(Value = "Minimum")]
        Minimum = 1,

        /// <summary>
        /// Represents Maximum.
        /// </summary>
        [EnumMember(Value = "Maximum")]
        Maximum = 2,

        /// <summary>
        /// Represents Absolute.
        /// </summary>
        [EnumMember(Value = "Absolute")]
        Absolute = 3,

        /// <summary>
        /// Represents Range.
        /// </summary>
        [EnumMember(Value = "Range")]
        Range = 4,
    }
}
