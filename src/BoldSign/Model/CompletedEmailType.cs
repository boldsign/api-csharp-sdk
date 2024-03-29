// <copyright file="CompletedEmailType.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Represents completed email type.
    /// </summary>
    /// <value>Represents the completed email type.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompletedEmailType
    {
        /// <summary>
        /// Attachment with link type.
        /// </summary>
        AttachmentsWithLink = 1,

        /// <summary>
        /// Document link in email type.
        /// </summary>
        LinkOnly = 2,
    }
}
