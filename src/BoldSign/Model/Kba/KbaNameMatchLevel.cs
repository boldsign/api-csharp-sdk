// <copyright file="KbaNameMatchLevel.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model.Kba
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Specifies the KBA name matching level.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KbaNameMatchLevel
    {
        /// <summary>
        /// Do not perform KBA name matching.
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Lenient KBA name matching.
        /// </summary>
        [EnumMember(Value = "Lenient")]
        Lenient = 1,

        /// <summary>
        /// Moderate KBA name matching.
        /// </summary>
        [EnumMember(Value = "Moderate")]
        Moderate = 2,

        /// <summary>
        /// Strict KBA name matching.
        /// </summary>
        [EnumMember(Value = "Strict")]
        Strict = 3,
    }
}
