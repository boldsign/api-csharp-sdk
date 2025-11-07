// <copyright file="SignatureType.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Represents the field SignatureType options.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SignatureType
    {
        /// <summary>
        /// Text flag.
        /// </summary>
        [EnumMember(Value = "Text")]
        Text = 0,

        /// <summary>
        /// Draw flag.
        /// </summary>
        [EnumMember(Value = "Draw")]
        Draw = 1,

        /// <summary>
        /// Image flag.
        /// </summary>
        [EnumMember(Value = "Image")]
        Image = 2,
    }
}

