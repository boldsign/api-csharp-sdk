// <copyright file="TextAlign.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The TextAlign.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextAlign
    {
        /// <summary>
        /// Left.
        /// </summary>
        Left,

        /// <summary>
        /// Center.
        /// </summary>
        Center,

        /// <summary>
        /// Right.
        /// </summary>
        Right,
    }
}
