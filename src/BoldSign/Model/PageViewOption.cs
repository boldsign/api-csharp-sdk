// <copyright file="PageViewOption.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System.Runtime.Serialization;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// View option.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PageViewOption
    {
        /// <summary>
        /// Prepare page.
        /// </summary>
        [EnumMember(Value = "PreparePage")]
        PreparePage = 0,

        /// <summary>
        /// Filling page.
        /// </summary>
        [EnumMember(Value = "FillingPage")]
        FillingPage = 1,
    }
}
