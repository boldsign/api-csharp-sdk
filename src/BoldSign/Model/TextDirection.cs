// <copyright file="TextDirection.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Specifies the possible directions of text.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextDirection
    {
        /// <summary>
        /// Left To Right.
        /// </summary>
        LTR,

        /// <summary>
        /// Right To Left.
        /// </summary>
        RTL,
    }
}
