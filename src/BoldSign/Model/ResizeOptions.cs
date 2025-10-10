// <copyright file="ResizeOptions.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Resize options.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResizeOptions
    {
        /// <summary>
        /// Grows Vertically.
        /// </summary>
        [EnumMember(Value = "GrowVertically")]
        GrowVertically,

        /// <summary>
        /// Grows Horizontally.
        /// </summary>
        [EnumMember(Value = "GrowHorizontally")]
        GrowHorizontally,

        /// <summary>
        /// Grow both Horizontally and Vertically.
        /// </summary>
        [EnumMember(Value = "GrowBoth")]
        GrowBoth,

        /// <summary>
        /// Fixed size option.
        /// </summary>
        [EnumMember(Value = "Fixed")]
        Fixed,

        /// <summary>
        /// Fixed auto resize option.
        /// </summary>
        [EnumMember(Value = "AutoResizeFont")]
        AutoResizeFont,
    }
}
