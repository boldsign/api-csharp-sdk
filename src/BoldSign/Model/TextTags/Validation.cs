// <copyright file="Validation.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The validation type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValidationType
    {
        /// <summary>
        /// Number only.
        /// </summary>
        NumberOnly,

        /// <summary>
        /// Email.
        /// </summary>
        Email,

        /// <summary>
        /// Currency.
        /// </summary>
        Currency,

        /// <summary>
        /// Regex.
        /// </summary>
        Regex,
    }

    /// <summary>
    /// The validation model.
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public ValidationType Type { get; set; }

        /// <summary>
        /// Gets or sets the regex value.
        /// </summary>
        public string Regex { get; set; }
    }
}
