// <copyright file="UserStatusOption.cs" company="Syncfusion Inc">
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
    ///     Defines UserStatusOption as Activate Or Deactivate.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserStatusOption
    {
        /// <summary>
        ///     Enum ActivateUser for value: Activate
        /// </summary>
        [EnumMember(Value = "Activate")]
        Activate = 1,

        /// <summary>
        ///     Enum DeactivateUser for value: Deactivate
        /// </summary>
        [EnumMember(Value = "Deactivate")]
        Deactivate = 2,
    }
}
