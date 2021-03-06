// <copyright file="TemplateType.cs" company="Syncfusion Inc">
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
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///   Represents user’s different template type.
    /// </summary>
    /// <value>Represents user template type.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemplateType
    {
        /// <summary>
        /// Represents My Template.
        /// </summary>
        [Description("mytemplates")]
        [EnumMember(Value = "mytemplates")]
        MyTemplates,

        /// <summary>
        /// Represents Shared Template.
        /// </summary>
        [Description("sharedtemplate")]
        [EnumMember(Value = "sharedtemplate")]
        SharedTemplate,

        /// <summary>
        /// Represents All Template.
        /// </summary>
        [Description("all")]
        [EnumMember(Value = "all")]
        All,
    }
}
